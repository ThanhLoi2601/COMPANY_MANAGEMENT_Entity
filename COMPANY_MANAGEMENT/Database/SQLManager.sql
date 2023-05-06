CREATE TABLE Manager (
	ID varchar(10),
	Name  varchar(100),
	Birth date,
	ID_Card varchar(50),
	Email varchar(100),
	Address varchar(255),
	Basic_salary int,
	Password varchar(20)
);

ALTER TABLE Manager
ALTER COLUMN ID varchar(10) NOT NULL
ALTER TABLE Manager ADD CONSTRAINT PK_Manager PRIMARY KEY (ID) ;

INSERT Manager(ID,Name,Birth,ID_Card,Email,Address,Basic_salary,Password) values ('MAN12345','Nguyen Van A','9/8/1999','0228192992','nva@gmail.com','TPHCM',100000,'12345678')
INSERT Manager(ID,Name,Birth,ID_Card,Email,Address,Basic_salary,Password) values ('MAN12346','Nguyen Van B','10/8/1998','0228192993','nvb@gmail.com','TPHCM',100000,'12345678')
INSERT Manager(ID,Name,Birth,ID_Card,Email,Address,Basic_salary,Password) values ('MAN12347','Nguyen Van C','9/9/1997','0228192994','nvc@gmail.com','TPHCM',100000,'12345678')
INSERT Manager(ID,Name,Birth,ID_Card,Email,Address,Basic_salary,Password) values ('MAN12348','Nguyen Van D','9/10/1996','0228192995','nvd@gmail.com','TPHCM',100000,'12345678')
INSERT Manager(ID,Name,Birth,ID_Card,Email,Address,Basic_salary,Password) values ('MAN12349','Nguyen Van E','11/8/1995','0228192996','nve@gmail.com','TPHCM',100000,'12345678')

SELECT COUNT(*) SoUser FROM Manager WHERE ID = 'MAN12345' and Password = '12345678';
UPDATE Manager SET Name ='Nguyen Van A', Address = 'Long An' WHERE id = 'MAN12345';