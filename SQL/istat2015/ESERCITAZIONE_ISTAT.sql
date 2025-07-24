use Istat;
go


/*Selezione le ripartizioni geografiche d'Italia*/
SELECT * FROM RipartizioneGeografica;
/*Selezionare tutte le regioni d'Italia*/
SELECT Denominazione FROM Regione;
/*Selezionare le provincie d'Italia in ordine alfabetico crescente*/
SELECT * FROM Provincia ORDER BY Denominazione ;
/*Selezionare le regione del Nord-Ovest*/
SELECT * FROM Regione R
join RipartizioneGeografica RG on R.IdRipartizione = RG.Id WHERE RG.Id=1;
/*Visualizzare la provincia e la sigla automobilistica delle provincie della regione Toscana*/
SELECT P.Denominazione,P.Sigla from Provincia P 
join Regione R on P.IdRegione = P.IdRegione where P.IdRegione= 9;
/*Visualizzare il comune, il codice catastale, la provincia di tutti i comuni appartenenti al Piemonte*/
SELECT C.Denominazione, C.CodiceCatastale, C.IdProvincia from Comune C 
join Provincia P on C.IdProvincia = P.id
join Regione R on P.IdRegione = R.Id
WHERE R.Denominazione = 'Piemonte';
/*Visualizzare la regione, la provincia, il comune che hanno altitudine dal centro minore di 500 metri*/
SELECT R.Denominazione, P.Denominazione, C.Denominazione FROM Comune C
join Provincia P ON C.IdProvincia = P.Id
join Regione R ON R.Id = P.IdRegione
WHERE C.AltitudineCentro<500
ORDER BY C.AltitudineCentro;
/*Visualizzare la popolazione al 2011 della provincia di Torino*/
SELECT sum(C.Popolazione2011) as PopolazioneProvinciaTO FROM Comune C join Provincia P on C.IdProvincia= P.Id
WHERE P.Denominazione = 'Torino';
/*Quanti sono i comuni del Nord-Est*/
SELECT count(C.id) as Comuni from Comune C 
join Provincia P on C.IdProvincia = P.Id
join Regione R on P.IdRegione = R.Id
join RipartizioneGeografica RG on R.IdRipartizione = RG.Id
WHERE RG.Denominazione = 'Nord-Est';
/*Quale comune ha il maggior numero di abitanti nel 2001*/
SELECT TOP 1 Denominazione FROM Comune ORDER BY Popolazione2001 DESC;
/*Visualizzare la popolazione nel 2011 minore d'Italia*/
SELECT TOP 1 * FROM Comune ORDER BY Popolazione2011 ASC;
/*Visualizzare la superficie media dei comuni della provincia di Salerno*/

/*Visualizzare la ripartizione geografica, la regione, la provincia, il comune, la zona litoranea, l'altitudine dal centro, la superficie, la zona montana, la zona altimetrica di tutti i comuni capoluoghi*/