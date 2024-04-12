DROP TABLE TeamUser;
CREATE TABLE TeamUser(
	teamUserID INT PRIMARY KEY IDENTITY (1,1),
	code VARCHAR(250) DEFAULT NEWID(),
	teamName VARCHAR(250) NOT NULL UNIQUE,
	budget INT NOT NULL DEFAULT 10
);

DROP TABLE CharacterUser;
CREATE TABLE CharacterUser(
	characterID INT PRIMARY KEY IDENTITY (1,1),
	code VARCHAR(250) DEFAULT NEWID(),
	characterName VARCHAR(250) NOT NULL UNIQUE,
	category VARCHAR(250) NOT NULL,
	credit INT NOT NULL,
	teamUserRIF INT,
	FOREIGN KEY (teamUserRIF) REFERENCES TeamUser(teamUserID) ON DELETE SET NULL
);

INSERT INTO TeamUser(teamName) VALUES
('I Pelati');

INSERT INTO CharacterUser(characterName, category, credit) VALUES
('Pawel Sloka', '150cc', 4);

SELECT * FROM TeamUser;
SELECT * FROM CharacterUser;