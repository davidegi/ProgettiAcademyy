CREATE TABLE OggettoCeleste(
	oggettoCelesteId INT PRIMARY KEY IDENTITY(1,1),
	codiceUnivoco VARCHAR(250) DEFAULT NEWID() NOT NULL UNIQUE,
	nome VARCHAR(250) NOT NULL,
	dataScoperta DATE NOT NULL,
	scopritore VARCHAR(250),
	tipologia VARCHAR(250) NOT NULL,
	distanzaTerra DECIMAL(10,2) NOT NULL,
	cpRadiale DECIMAL(10,2) NOT NULL,
	cpAngolare DECIMAL(10,2) NOT NULL
);

CREATE TABLE Sistema(
	sistemaId INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) NOT NULL UNIQUE,
	nome VARCHAR(250) NOT NULL,
	tipo VARCHAR(250) NOT NULL
);

CREATE TABLE OggettoCeleste_Sistema(
	oggettoCelesteRif INT NOT NULL,
	sistemaRif INT NOT NULL,
	FOREIGN KEY (oggettoCelesteRif) REFERENCES OggettoCeleste(oggettoCelesteId),
	FOREIGN KEY (sistemaRif) REFERENCES Sistema(sistemaId),
	PRIMARY KEY (oggettoCelesteRif, sistemaRif)
);

INSERT INTO OggettoCeleste(codiceUnivoco, nome, dataScoperta, scopritore, tipologia, distanzaTerra, cpRadiale, cpAngolare) VALUES
('abc1', 'Andromeda Galaxy', '20-12-1923', 'Edwin Hubble', 'Galassia', 2530000.00, 140.00, 185.00),
('abc2', 'Orion Nebula', '26-11-1610', 'Nicolas-Claude Fabri de Peiresc', 'Nebula', 1344.00, 5.50, 83.00),
('abc3', 'Saturn', '25-7-1610', 'Galileo Galilei', 'Planet', 13400000.00, 58232.00, 83.00),
('abc4', 'Mars', '23-8-1659', 'Christiaan Huygens', 'Planet', 2250000.00, 3390.00, 317.00),
('abc5', 'Crab Nebula', '12-07-1731', 'John Bevis', 'Supernova Remnant', 6500.00, 6.00, 83.00),
('abc6', 'Jupiter', '07-01-1610', 'Galileo Galilei', 'Planet', 4840000.00, 69911.00, 83.00);


INSERT INTO Sistema (codice, nome, tipo) VALUES
('def1', 'Sistema Solare', 'Stellare'),
('def2', 'Sistema di Galassie', 'Galattico'),
('def3', 'Sistema Binario', 'Stellare'),
('def4', 'Sistema di Pianeti', 'Stellare');

SELECT * FROM OggettoCeleste;
SELECT * FROM Sistema;