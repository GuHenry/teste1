CREATE TABLE peixes(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
raca VARCHAR(50),
preco DECIMAL(8,2),
quantidade INT
); 
SELECT * FROM peixes; 



DROP TABLE colaboradores; 
CREATE TABLE colaboradores(
id INT PRIMARY KEY IDENTITY(1,1), 
nome VARCHAR(50),
salario dECIMAL(15),
cpf VARCHAR(14),
sexo VARCHAR(9),
cargo VARCHAR(50),
programador Bit
); 

SELECT * FROM colaboradores; 