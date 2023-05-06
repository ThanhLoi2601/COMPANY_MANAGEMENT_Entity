CREATE TABLE CompleteJob (
	IDJob varchar(10),
	Content varchar(500),
	CompleDate Date,
	Bonus int
);
ALTER TABLE CompleteJob
ALTER COLUMN IDJob varchar(10) NOT NULL
ALTER TABLE CompleteJob ADD CONSTRAINT PK_IDJob PRIMARY KEY (IDJob) ;

