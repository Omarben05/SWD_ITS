package controller;

import java.io.IOException;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import model.Automobile;
import services.AutomobileService;

@WebServlet("/automobili")
public class AutosaloneMVC extends HttpServlet{
	
	private AutomobileService service = new AutomobileService();
	
	@Override
	protected void doGet(HttpServletRequest richiesta, HttpServletResponse risposta) throws ServletException, IOException {
		service.getAutomobili();
	}
	
}