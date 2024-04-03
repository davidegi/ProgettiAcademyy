DROP TABLE IF EXISTS Ferramenta;

CREATE TABLE Ferramenta(
	ferramentaId INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(250) DEFAULT NEWID(),
	nome VARCHAR(250) NOT NULL,
	descrizione VARCHAR(250),
	prezzo DECIMAL(10,2) NOT NULL,
	quantita INT NOT NULL CHECK(quantita >= 0),
	categoria VARCHAR(250) NOT NULL CHECK (Categoria IN ('Agricoltura', 'Antinfortunistica', 'Bricolage', 'Coperture', 'Idraulica', 'Industria', 'Recinzioni', 'Saldatura')),
	creazione DATE
);