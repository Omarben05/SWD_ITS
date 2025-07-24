INSERT INTO RipartizioneGeografica
SELECT DISTINCT [Codice Ripartizione Geografica], [Ripartizione geografica] 
FROM [ISTAT2025].[dbo].[Import]
ORDER BY [Codice Ripartizione Geografica];
