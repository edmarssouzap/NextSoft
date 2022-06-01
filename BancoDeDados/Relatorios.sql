USE NextSoft;
GO

-- Quest�o 1: Elabore a consulta SQL para obter um relat�rio de pessoas com 50 anos ou mais por Condominio.
SELECT 
	C.Nome AS Condominio,
	COUNT(M.Idade) AS 'Pessoas com 50 anos ou mais'
FROM Morador M
	INNER JOIN Familia F ON F.Id = M.Id_Familia
	INNER JOIN Condominio C ON C.Id = F.Id_Condominio
WHERE M.Idade >= 50
group by C.Nome;

-- Quest�o 2: Elabore a consulta SQL para obter um relat�rio de pessoas, familias que pertencem e condominio onde mora.

SELECT 
	M.Nome AS 'Pessoa',
	F.Nome AS 'Familia',
	C.Nome AS 'Condominio'
FROM Morador M
	INNER JOIN Familia F ON F.Id = M.Id_Familia
	INNER JOIN Condominio C ON C.Id = F.Id_Condominio
ORDER BY M.Nome;

-- Quest�o 3: Elabore a consulta SQL para obter um relat�rio de Media de idade das pessoas por bairro.
SELECT 
	C.Nome AS Bairro,
	AVG(M.Idade) AS 'Media Idade'
FROM Morador M
	INNER JOIN Familia F ON F.Id = M.Id_Familia
	INNER JOIN Condominio C ON C.Id = F.Id_Condominio
GROUP BY C.Nome;
