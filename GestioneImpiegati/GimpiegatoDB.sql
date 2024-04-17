CREATE TABLE Impiegato(
	impiegatoID INT PRIMARY KEY IDENTITY(1,1),
	matricola VARCHAR(250) NOT NULL UNIQUE,
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	data_nascita DATE NOT NULL,
	ruolo VARCHAR(250) NOT NULL,
	reparto VARCHAR(250) NOT NULL,
	indirizzo_residenza VARCHAR(250) NOT NULL,
	citta_residenza VARCHAR(250) NOT NULL,
	provincia_residenza VARCHAR(250) NOT NULL,
);

CREATE TABLE Reparto(
	repartoID INT PRIMARY KEY IDENTITY(1,1),
	tipo_reparto VARCHAR(250) NOT NULL
);

CREATE TABLE Citta_Residenza(
	citta_residenzaID INT PRIMARY KEY IDENTITY(1,1),
	citta VARCHAR(250) NOT NULL
);

CREATE TABLE Provincia_Residenza(
	provincia_residenzaID INT PRIMARY KEY IDENTITY(1,1),
	provincia VARCHAR(250) NOT NULL,
	cittaRIF INT NOT NULL,
	FOREIGN KEY (cittaRIF) REFERENCES Citta_Residenza(citta_residenzaID)
);

INSERT INTO Impiegato(matricola, nome, cognome, data_nascita, ruolo, reparto, indirizzo_residenza, citta_residenza, provincia_residenza) VALUES
('ABC123', 'Mario', 'Rossi', '01/01/1991', 'impiegato semplice', 'ICT', 'via gallia 89', 'Barletta', 'BAT');

INSERT INTO Reparto(tipo_reparto) VALUES
('ICT');

INSERT INTO Citta_Residenza(citta) VALUES
('Barletta');

INSERT INTO Provincia_Residenza(provincia, cittaRIF) VALUES
('BAT', 1);