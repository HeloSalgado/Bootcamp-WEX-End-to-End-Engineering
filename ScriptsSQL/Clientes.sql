--SELECT * FROM dbo.Clientes 
--WHERE Nome LIKE '%an%'
--ORDER BY Nome, Sobrenome


INSERT INTO dbo.Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES ('Heloisa', 'Salgado', 'email@gmail.com', 1, GETDATE())

INSERT INTO dbo.Clientes VALUES ('Heloisa', 'Salgado', 'email@gmail.com', 1, GETDATE())

SELECT * FROM dbo.Clientes WHERE Nome = 'Heloisa'

UPDATE Clientes
SET	Email = 'heloisa@gmail.com',
	AceitaComunicados = 0
WHERE Id = 30 

DELETE Clientes WHERE Id = 2