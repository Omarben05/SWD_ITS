USE Magazzino27;
 -- creazione tabelle con SQL
CREATE TABLE Categoria(
Id INT not null PRIMARY KEY,
Denominazione VARCHAR(100) not null,
Descrizione TEXT null 
);

--DROP TABLE Prodotto;

CREATE TABLE Prodotto(
Id INT not null PRIMARY KEY,
Denominazione VARCHAR(100) not null,
-- usare char quando si sanno numero caratteri senno varchar
Descrizione TEXT null,
Prezzo FLOAT not null,
Giacenza INT not null,
IdCategoria INT not null REFERENCES Categoria(Id)
);

/*
ALTER TABLE Prodotto 
ADD 
CONSTRAINT 
/*