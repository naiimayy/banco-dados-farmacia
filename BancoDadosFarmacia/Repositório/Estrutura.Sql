	CREATE TABLE produtos_higienicos(
		id INT PRIMARY KEY IDENTITY (1,1),
		nome VARCHAR (100) NOT NULL,
		preco DECIMAL(8,2),
		categoria VARCHAR(30),
	);

	SELECT id, nome, preco, categoria FROM produtos_higienicos;
	
	CREATE TABLE produtos_comestiveis(
		id INT  PRIMARY KEY IDENTITY (1,1),
		nome VARCHAR (100) NOT NULL,
		preco DECIMAL (8,2),
		data_vencimento VARCHAR (8),
		quantidade INT,
		marca VARCHAR (30),
	);

	SELECT id, nome, preco, data_vencimento, quantidade, marca FROM produtos_comestiveis;

	CREATE TABLE remedios(
		id INT  PRIMARY KEY IDENTITY (1,1),
		generico BIT,
		nome VARCHAR (100) NOT NULL,
		categoria VARCHAR(30),
		solido BIT,
		bula VARCHAR(30),
		faixa VARCHAR(30),
		receita BIT,
	);

	SELECT id, generico, nome, categoria, solido, bula, faixa, receita FROM remedios;
