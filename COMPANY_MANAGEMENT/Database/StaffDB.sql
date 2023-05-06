CREATE TABLE Staff (
	ID varchar(10),
	Name  varchar(100),
	Birth date,
	ID_Card varchar(50),
	Email varchar(100),
	Address varchar(255),
	Manager_ID varchar(10),
	Basic_salary int,
	Password varchar(20)
);

ALTER TABLE Staff
ALTER COLUMN ID varchar(10) NOT NULL
ALTER TABLE Staff ADD CONSTRAINT PK_Staff PRIMARY KEY (ID) ;

INSERT Staff(ID,Name,Birth,ID_Card,Email,Address,Manager_ID,Basic_salary,Password) values ('EMP12345','Nguyen Van A','9/8/1999','nva@gmail.com','0123456789','TPHCM','MAN12345',50000,'12345678')
INSERT Staff(ID,Name,Birth,ID_Card,Email,Address,Manager_ID,Basic_salary,Password) values ('EMP12341','Nguyen Van F','9/10/1999','nvf@gmail.com','0123456799','TPHCM','MAN12345',50000,'12345678')
INSERT Staff(ID,Name,Birth,ID_Card,Email,Address,Manager_ID,Basic_salary,Password) values ('EMP12342','Nguyen Van L','9/9/1999','nvl@gmail.com','0123454589','TPHCM','MAN12345',50000,'12345678')
INSERT Staff(ID,Name,Birth,ID_Card,Email,Address,Manager_ID,Basic_salary,Password) values ('EMP12346','Nguyen Van B','10/8/1998','nvb@gmail.com','0123456782','TPHCM','MAN12346',50000,'12345678')
INSERT Staff(ID,Name,Birth,ID_Card,Email,Address,Manager_ID,Basic_salary,Password) values ('EMP12347','Nguyen Van C','9/9/1997','nvc@gmail.com','0123456723','TPHCM','MAN12347',50000,'12345678')
INSERT Staff(ID,Name,Birth,ID_Card,Email,Address,Manager_ID,Basic_salary,Password) values ('EMP12348','Nguyen Van D','9/10/1996','nvd@gmail.com','0123456764','TPHCM','MAN12348',50000,'12345678')
INSERT Staff(ID,Name,Birth,ID_Card,Email,Address,Manager_ID,Basic_salary,Password) values ('EMP12349','Nguyen Van E','11/8/1995','nve@gmail.com','0123456777','TPHCM','MAN12349',50000,'12345678')

Select* from Staff