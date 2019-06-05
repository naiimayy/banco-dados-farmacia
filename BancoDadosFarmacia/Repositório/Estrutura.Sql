	CREATE TABLE produtos_higienicos(
		id INT PRIMARY KEY IDENTITY (1,1),
		nome VARCHAR (100) NOT NULL,
		preco DECIMAL(8,2),
		categoria VARCHAR(30),
	);

	SELECT id, nome, preco, categoria FROM produtos_higienicos;
	
