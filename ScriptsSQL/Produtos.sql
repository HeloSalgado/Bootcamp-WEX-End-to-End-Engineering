SELECT * FROM Produtos

SELECT COUNT(*) QuantidadeProdutos FROM Produtos

SELECT COUNT(*) QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'

SELECT SUM(Preco) PrecoTotal FROM Produtos

SELECT SUM(Preco) PrecoTotalProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'

SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos

SELECT MAX(Preco) ProdutoMaisCaroTamanhoM FROM Produtos WHERE Tamanho = 'M'

SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos

SELECT MIN(Preco) ProdutoMaisBaratoTamanhoM FROM Produtos WHERE Tamanho = 'M'

SELECT AVG(Preco) MediaDePrecoDosProdutos FROM Produtos

SELECT 
	Nome + ', Cor: ' + Cor + ' - ' + Genero NomeProdutoCompleto,
	UPPER(Nome) Nome,
	LOWER(Cor) Cor,
	FORMAT(DataCadastro, 'dd-MM-yyyy HH:mm') Data
FROM Produtos

ALTER TABLE Produtos
ADD DataCadastro DATETIME2

ALTER TABLE Produtos
DROP COLUMN DataCadastro

UPDATE Produtos SET DataCadastro = GETDATE()

SELECT 
	Tamanho,
	COUNT(*) Quantidade
FROM Produtos
WHERE Tamanho <> ''
GROUP BY Tamanho
ORDER BY Quantidade DESC