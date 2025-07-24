USE Magazzino27;

CREATE TABLE Cliente(
CodiceFiscale CHAR(16) not null PRIMARY KEY,
Cognome VARCHAR(50) not null,
Nome VARCHAR(50) not null,
Telefono VARCHAR(30),
Email VARCHAR(50) not null UNIQUE
);

CREATE TABLE IndirizzoSpedizione (
Id INT not null PRIMARY KEY,
Indirizzo VARCHAR(100) not null,
Cap CHAR(5) not null,
Citta VARCHAR(100) not null,
Provincia CHAR(2) not null,
IdCliente CHAR(16) not null REFERENCES Cliente(CodiceFiscale)
);

CREATE TABLE StatoOrdine (
Id INT not null PRIMARY KEY,
Denominazione VARCHAR(100) not null,
);

CREATE TABLE Pagamento (
Id INT not null PRIMARY KEY,
Denominazione VARCHAR(100) not null,
Maggiorazione FLOAT null
);

CREATE TABLE Ordine (
Riferimento CHAR(8) not null PRIMARY KEY,
Data DateTime not null,
IdCliente CHAR(16) not null REFERENCES Cliente(CodiceFiscale),
IdStatoOrdine INT not null REFERENCES StatoOrdine(Id),
IdIndirizzo INT not null REFERENCES indirizzoSpedizione(Id),
IdPagamento INT not null REFERENCES Pagamento(Id)
);

CREATE TABLE DettaglioOrdine (
IdOrdine CHAR(8) not null,
IdProdotto INT not null,
Quantita INT not null,
PRIMARY KEY (IdOrdine,IdProdotto),
CONSTRAINT FK_DettaglioOrdine_Ordine FOREIGN KEY (IdOrdine) REFERENCES Ordine(Riferimento),
CONSTRAINT FK_DettaglioOrdine_Prodotto FOREIGN KEY (IdProdotto) REFERENCES Prodotto(Id)

--STESSA COSA CHE SCRIVERE REFERENCES , MA CON CONSTRAINT CREI TU IL NOME DEL CONSTRAINT E NON LO LASVI FARE ALLA MACCHINA
);
