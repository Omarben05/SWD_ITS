/*
Visualizzare il numero di regioni per ogni ripartizione geografica
Visualizzare le dimensioni territoriali per ogni provincia italiana
Elencare il primo comune con altitudine dal centro max per per ogni regione italiana
Elencare la popolazione media nel 2011 per provincia ordinata in senso decrescente
Elencare la popolazione totale nel 2001 per provincia solo delle ripartizioni del nord ordinata in senso decrescente
*/


----
SELECT COUNT (Id)
FROM Regione 
GROUP BY IdRipartizione;

----
SELECT Provincia.Denominazione, Comune.Superficie
FROM Comune
join Provincia ON Comune.Id = Provincia.Id;

----
SELECT max(AltitudineCentro) as "altitudine dal centro", Regione.Denominazione
FROM Comune
join Regione on Comune.Id = Regione.Id
GROUP BY Regione.Denominazione;

----
SELECT avg(Popolazione2011) as "media popolazione", Provincia.Denominazione
FROM Comune
join Provincia on Comune.Id = Provincia.Id
GROUP BY Provincia.Denominazione, Comune.Popolazione2011
ORDER BY Popolazione2011;

----
