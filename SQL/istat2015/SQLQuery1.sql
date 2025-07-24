use istat2015
go
insert into Regione(Id, Denominazione, IdRipartizione)
SELECT distinct [Codice Regione]
		,[Denominazione Regione]
		,[Codice Ripartizione Geografica]
		FROM [Istat2015].[dbo].[import]