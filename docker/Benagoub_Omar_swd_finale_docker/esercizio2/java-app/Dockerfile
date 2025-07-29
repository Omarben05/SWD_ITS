FROM openjdk:11-jdk-slim

# crea la directory app e installa wget
RUN mkdir -p /app && \
    apt-get update && apt-get install -y wget && \
    wget https://jdbc.postgresql.org/download/postgresql-42.7.0.jar -O /app/postgresql.jar

# copia il file java
COPY App.java /app/App.java

WORKDIR /app

# usa percorsi relativi corretti
CMD ["sh", "-c", "javac -cp postgresql.jar App.java && java -cp .:postgresql.jar App"]

EXPOSE 8080