CREATE TABLE Absence (
	ID varchar(10),
	Name varchar(100),
	Reason varchar(100),
	StartDate date,
	EndDate date
);
ALTER TABLE Absence
ALTER COLUMN ID varchar(10) NOT NULL
ALTER TABLE Absence
ALTER COLUMN StartDate date NOT NULL
ALTER TABLE Absence ADD CONSTRAINT PK_IDAbsence PRIMARY KEY (ID,StartDate) ;

SELECT * FROM Absence WHERE  ID LIKE 'MAN%'
