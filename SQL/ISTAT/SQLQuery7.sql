INSERT INTO Regione
SELECT DISTINCT [Codice Regione],[Codice Ripartizione Geografica], [Ripartizione geografica] 
FROM [ISTAT2025].[dbo].[Import]
ORDER BY [Codice Ripartizione Geografica];
