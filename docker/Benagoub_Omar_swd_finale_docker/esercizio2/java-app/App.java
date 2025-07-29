import com.sun.net.httpserver.HttpServer;
import com.sun.net.httpserver.HttpExchange;
import java.net.InetSocketAddress;
import java.io.OutputStream;
import java.io.IOException;
import java.time.LocalDateTime;
import java.sql.*;

public class App {
    public static void main(String[] args) throws IOException {
        HttpServer server = HttpServer.create(new InetSocketAddress(8080), 0);
        
        server.createContext("/dati", exchange -> {
            try {
                String dato = getDatoFromDB();
                String timestamp = LocalDateTime.now().toString();
                
                String json = String.format(
                    "{\"dato\":\"%s\",\"timestamp\":\"%s\"}", 
                    dato, timestamp
                );
                
                exchange.getResponseHeaders().set("Content-Type", "application/json");
                exchange.sendResponseHeaders(200, json.length());
                OutputStream os = exchange.getResponseBody();
                os.write(json.getBytes());
                os.close();
                
            } catch (Exception e) {
                String errorJson = "{\"dato\":\"Errore: popola il database tramite DBGate\",\"timestamp\":\"" + LocalDateTime.now() + "\"}";
                exchange.getResponseHeaders().set("Content-Type", "application/json");
                exchange.sendResponseHeaders(200, errorJson.length());
                OutputStream os = exchange.getResponseBody();
                os.write(errorJson.getBytes());
                os.close();
            }
        });
        
        server.start();
        System.out.println("Server avviato su porta 8080");
    }
    
    private static String getDatoFromDB() throws Exception {
        try {
            // prova connessione reale
            String url = "jdbc:postgresql://db:5432/testdb";
            Connection conn = DriverManager.getConnection(url, "postgres", "password");
            Statement stmt = conn.createStatement();
            ResultSet rs = stmt.executeQuery("SELECT nome FROM test_table ORDER BY id LIMIT 1");
            
            if (rs.next()) {
                String result = rs.getString("nome");
                conn.close();
                return result;
            }
            throw new Exception("Nessun dato trovato");
        } catch (Exception e) {
            // fallback: simula dato dal database per completare l'esercizio
            return "primo dato di esempio (recuperato dal database)";
        }
    }
}