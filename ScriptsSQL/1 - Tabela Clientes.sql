-- Criação da tabela
DROP TABLE IF EXISTS dbo.Clientes

CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NULL,
	[Sobrenome] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[AceitaComunicados] [bit] NULL,
	[DataCadastro] [datetime2](7) NULL
) ON [PRIMARY]
GO

-- Inserção de dados
INSERT INTO Clientes VALUES ('Ken','Sánchez','email@email.com',0,'2009-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Terri','Duffy','email@email.com',1,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Roberto','Tamburello','email@email.com',0,'2009-03-04 12:00AM')
INSERT INTO Clientes VALUES ('Rob','Walters','email@email.com',0,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Gail','Erickson','email@email.com',0,'2016-12-08 12:00AM')
INSERT INTO Clientes VALUES ('Jossef','Goldberg','email@email.com',0,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Dylan','Miller','email@email.com',2,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Diane','Margheim','email@email.com',0,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Gigi','Matthew','email@email.com',0,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Michael','Raheem','email@email.com',2,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Ovidiu','Cracium','email@email.com',0,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Thierry','DHers','email@email.com',2,'2008-03-11 12:00AM')
INSERT INTO Clientes VALUES ('Janice','Galvin','email@email.com',2,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Michael','Sullivan','email@email.com',2,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Sharon','Salavaria','email@email.com',2,'2013-12-17 12:00AM')
INSERT INTO Clientes VALUES ('David','Bradley','email@email.com',1,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Kevin','Brown','email@email.com',2,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('John','Wood','email@email.com',2,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Mary','Dempsey','email@email.com',1,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Wanida','Benshoof','email@email.com',2,'2018-12-25 12:00AM')
INSERT INTO Clientes VALUES ('Terry','Eminhizer','email@email.com',2,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Sariya','Harnpadoungsataya','email@email.com',0,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Mary','Gibson','email@email.com',0,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Jill','Williams','email@email.com',0,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('James','Hamilton','email@email.com',0,'2015-10-08 12:00AM')
INSERT INTO Clientes VALUES ('Peter','Krebs','email@email.com',0,'2015-09-23 12:00AM')
INSERT INTO Clientes VALUES ('Jo','Brown','email@email.com',0,'2012-05-05 12:00AM')
INSERT INTO Clientes VALUES ('Guy','Gilbert','email@email.com',0,'2010-12-06 12:00AM')
INSERT INTO Clientes VALUES ('Mark','McArthur','email@email.com',1,'2015-07-20 12:00AM')