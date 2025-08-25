CREATE TABLE Enderecos (
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdCliente int NULL,
	Rua varchar(255) NULL,
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado char(2) NULL,
	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente)
	REFERENCES Clientes(Id)
)

SELECT * FROM Enderecos

INSERT INTO Enderecos VALUES (3, 'Rua Teste', 'Bairro teste', 'Cidade teste', 'SP')

SELECT * FROM Clientes WHERE Id = 3
SELECT * FROM Enderecos WHERE IdCliente = 3

SELECT 
	C.Nome,
	C.Sobrenome,
	C.Email,
	E.Rua,
	E.Bairro,
	E.Cidade,
	E.Estado
FROM Clientes C 
INNER JOIN Enderecos E ON C.Id = E.IdCliente
WHERE C.Id = 3