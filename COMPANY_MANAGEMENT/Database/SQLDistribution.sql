CREATE TABLE Distribution (
	IDJob varchar(10),
	IDStaff varchar(10)
);

ALTER TABLE Distribution
ALTER COLUMN IDJob varchar(10) NOT NULL
ALTER TABLE Distribution
ALTER COLUMN IDStaff varchar(10) NOT NULL
ALTER TABLE Distribution ADD CONSTRAINT PK_Distribution PRIMARY KEY (IDJob,IDStaff) ;

DELETE Distribution WHERE IDStaff = 'EMP12342'

SELECT IDJob,IDStaff,DateStart,DateEnd FROM Distribution INNER JOIN Job ON IDJob = ID ;
SELECT ID, DateStart, DateEnd FROM Job WHERE ID = 'JOB2347'
SELECT * FROM Staff WHERE (ID NOT IN (SELECT IDStaff FROM Distribution) 
	OR ID NOT IN (SELECT IDStaff
				FROM Distribution
				INNER JOIN Job ON IDJob = ID
				WHERE (DateStart BETWEEN '02/03/2023' AND '02/13/2023')
					OR (DateEnd BETWEEN '02/03/2023' AND '02/13/2023')
					OR ('02/03/2023' BETWEEN DateStart AND DateEnd)
					OR ('02/13/2023' BETWEEN DateStart AND DateEnd)) )AND Manager_ID = 'MAN12345'
SELECT DISTINCT IDJob FROM Distribution WHERE IDStaff= 'MAN12345'