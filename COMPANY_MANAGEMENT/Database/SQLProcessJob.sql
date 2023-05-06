CREATE TABLE ProcessJob(
	IDJob varchar(10),
	Content varchar(500),
	Process float
)
ALTER TABLE ProcessJob
ALTER COLUMN IDJob varchar(10) NOT NULL
ALTER TABLE ProcessJob ADD CONSTRAINT PK_ProcessJob PRIMARY KEY (IDJob) ;

INSERT INTO ProcessJob(IDJob,Content,Process,Bonus) VALUES ('JOB2345','Ve so do thiet ke',0,10000)
INSERT INTO ProcessJob(IDJob,Content,Process,Bonus) VALUES ('JOB2347','Ve so do thiet ke may',0,50000)
