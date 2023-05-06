CREATE TABLE SQLCheck (
  ID varchar(10),
  Name  varchar(100),
  DateCheck DATE,
  CheckIn BIT,
  CheckOut BIT,
  TimesLate int
)

ALTER TABLE SQLCheck
ADD TimeCheckIn DATETIME,
    TimeCheckOut DATETIME;

SELECT * FROM SQLCheck WHERE ID = 'EMP12345' ---and MONTH(TimeCheckIn) = 5 AND MONTH(TimeCheckOut) = 5
SELECT DateCheck,TimeCheckIn,TimeCheckOut FROM SQLCheck WHERE ID = 'EMP12345' and MONTH(DateCheck) = 01