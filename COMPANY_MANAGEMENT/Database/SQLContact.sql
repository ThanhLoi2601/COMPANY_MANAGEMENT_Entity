create table Contact (
	IDSent varchar(10),
	NameSent varchar(100),
	Subject varchar(100),
	Content varchar(500),
	IDReceive varchar(20),
	InfoDate Datetime 
)
ALTER TABLE Contact
ALTER COLUMN IDSent varchar(10) NOT NULL
ALTER TABLE Contact
ALTER COLUMN InfoDate Datetime NOT NULL
ALTER TABLE Contact ADD CONSTRAINT PK_Contact PRIMARY KEY (IDSent,InfoDate) ;

INSERT INTO Contact(IDSent,NameSent,Subject,Content,IDReceive,InfoDate) values ('LD12345','Tran Van A','Submit a plan','Planning and submission','All Manager','4/19/2023')