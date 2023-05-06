CREATE TABLE Job (
	ID varchar(10),
	Name  varchar(100),
	Content varchar(500),
	DateStart Date,
	DateEnd Date,
	Bonus int,
	IDTasks VARCHAR(10)
);

ALTER TABLE Job
ALTER COLUMN ID varchar(10) NOT NULL
ALTER TABLE Job ADD CONSTRAINT PK_Job PRIMARY KEY (ID) ;

INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('JOB2345','DRAW','Ve so do thiet ke','3/1/2023','3/17/2023',10000,'TKS001');
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('JOB2346','DRAW','Ve so do','3/1/2023','3/27/2023',0,'TKS001');
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('JOB2347','DRAW','Ve so do thiet ke may','2/3/2023','2/13/2023',50000,'TKS002');
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('JOB2348','DRAW','Ve so do thiet ke code','3/1/2023','3/29/2023',0,'TKS002');
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('JOB2349','DRAW','Ve so do thiet ke do hoa','3/1/2023','3/12/2023',10000,'TKS003');
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('JOB2341','DRAW','Ve so do thiet ke game','3/10/2023','3/17/2023',20000,'TKS003');
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('JOB2342','DRAW','Ve so do thiet ke phan mem','3/21/2023','3/22/2023',100000,'TKS004');
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('JOB2343','DRAW','Ve so do thiet ke phan cung','4/1/2023','4/10/2023',30000,'TKS004');
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('JOB2344','DRAW','Ve so do thiet ke so do','3/16/2023','3/22/2023',50000,'TKS005');



SELECT d.IDJob,j.Name,j.Content FROM Job j,  Distribution d WHERE j.ID = d.IDJob AND d.IDStaff = 'EMP12345'
SELECT d.IDJob , d.IDStaff , j.DateStart, j.DateEnd, pj.Process, j.IDTasks
                FROM Distribution d, Job j, ProcessJob pj  WHERE d.IDJob = j.ID and d.IDJob = pj.IDJob