USE Magazzino27;

--inserire tre categorie 
INSERT INTO Categoria(Id,Denominazione,Descrizione) VALUES(1,'categoria 1', null);
INSERT INTO Categoria(Id,Denominazione,Descrizione) VALUES(2,'categoria 2', null);
INSERT INTO Categoria(Id,Denominazione,Descrizione) VALUES(3,'categoria 3', 'descrizione categoria 3');




--inserire 5 prodotti
INSERT INTO Prodotto(Id,Denominazione,Descrizione,Prezzo,Giacenza,IdCategoria) VALUES(1,'prodotto 1', null,10.25,100,1);
INSERT INTO Prodotto(Id,Denominazione,Descrizione,Prezzo,Giacenza,IdCategoria) VALUES(2,'prodotto 2', null,10.25,100,2);
INSERT INTO Prodotto(Id,Denominazione,Descrizione,Prezzo,Giacenza,IdCategoria) VALUES(3,'prodotto 3', null,10.25,100,3);
INSERT INTO Prodotto(Id,Denominazione,Descrizione,Prezzo,Giacenza,IdCategoria) VALUES(4,'prodotto 4', null,10.25,100,1);
INSERT INTO Prodotto(Id,Denominazione,Descrizione,Prezzo,Giacenza,IdCategoria) VALUES(5,'prodotto 5', null,10.25,100,2);