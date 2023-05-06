CREATE TABLE Projects (
  ID VARCHAR(10) PRIMARY KEY,
  Project_Name VARCHAR(50) NOT NULL,
  StartDate DATE,
  EndDate DATE,
  Project_description TEXT,
  Project_status varchar(50) DEFAULT 'NotStarted'
);
CREATE TABLE Tasks (
  ID VARCHAR(10) PRIMARY KEY,
  Task_Name VARCHAR(50) NOT NULL,
  StartDate DATE,
  EndDate DATE,
  Task_description TEXT,
  Task_status varchar(50) DEFAULT 'NotStarted', 
  Project_ID VARCHAR(10),
  FOREIGN KEY (Project_ID) REFERENCES Projects(ID) ON DELETE CASCADE
);

INSERT INTO Projects (ID, Project_Name, StartDate, EndDate, Project_description, Project_status) VALUES 
('PRO001', 'Website Redesign', '2022-01-01', '2022-03-31', 'Redesigning company website to improve user experience', 'InProgress'),
('PRO002', 'Marketing Campaign', '2023-05-01', '2023-06-30', 'Planning and executing a marketing campaign to increase sales', 'NotStarted'),
('PRO003', 'Marketing Campaign', '2022-07-01', '2022-08-31', 'Running summer marketing campaign to increase sales', 'NotStarted'),
('PRO004', 'IT System Upgrade', '2022-09-01', '2022-11-30', 'Upgrading IT systems to improve efficiency and security', 'NotStarted'),
('PRO005', 'Customer Survey', '2022-12-01', '2023-01-31', 'Conducting annual customer survey to gather feedback and insights', 'NotStarted');

INSERT INTO Tasks (ID, Task_Name, StartDate, EndDate, Task_description, Task_status, Project_ID) VALUES 
('TKS001', 'Research Competitors', '2022-01-01', '2022-01-14', 'Conduct research on competitors websites to determine what changes are needed', 'Completed', 'PRO001'),
('TKS002', 'Design Mockups', '2022-01-15', '2022-02-15', 'Create mockups of new website design', 'InProgress', 'PRO001'),
('TKS003', 'Get Client Approval', '2022-02-16', '2022-02-28', 'Present website redesign to client for approval', 'NotStarted', 'PRO001'),
('TKS004', 'Develop Website', '2022-03-01', '2022-03-31', 'Develop and code the new website design', 'NotStarted', 'PRO001'),
('TKS005', 'Test and Launch', '2022-04-01', '2022-04-15', 'Test website for bugs and launch it to the public', 'NotStarted', 'PRO001'),
('TKS006', 'Define Target Audience', '2023-05-01', '2023-05-05', 'Identify and define the target audience for the marketing campaign', 'Completed', 'PRO002'),
('TKS007', 'Develop Campaign Strategy', '2023-05-06', '2023-05-20', 'Develop a strategy for the marketing campaign including the channels to be used and the message to be conveyed', 'InProgress', 'PRO002'),
('TKS008', 'Create Campaign Materials', '2023-05-21', '2023-06-10', 'Create the necessary materials for the marketing campaign such as ad copy, images, and videos', 'NotStarted', 'PRO002'),
('TKS009', 'Execute Campaign', '2023-06-11', '2023-06-24', 'Launch and execute the marketing campaign according to the strategy developed earlier', 'NotStarted', 'PRO002'),
('TKS0010', 'Monitor and Evaluate Results', '2023-06-25', '2023-06-30', 'Monitor and evaluate the results of the marketing campaign to determine its effectiveness and make any necessary adjustments', 'NotStarted', 'PRO002'),
('TKS0011', 'Define Target Audience', '2022-07-01', '2022-07-07', 'Identify and define the target audience for the summer marketing campaign', 'NotStarted', 'PRO003'),
('TKS0012', 'Develop Campaign Strategy', '2022-07-08', '2022-07-15', 'Develop a strategy for the summer marketing campaign including the channels to be used and the message to be conveyed', 'NotStarted', 'PRO003'),
('TKS0013', 'Create Campaign Materials', '2022-07-16', '2022-08-05', 'Create the necessary materials for the summer marketing campaign such as ad copy, images, and videos', 'NotStarted', 'PRO003'),
('TKS0014', 'Execute Campaign', '2022-08-06', '2022-08-19', 'Launch and execute the summer marketing campaign according to the strategy developed earlier', 'NotStarted', 'PRO003'),
('TKS0015', 'Monitor and Evaluate Results', '2022-08-20', '2022-08-31', 'Monitor and evaluate the results of the summer marketing campaign to determine its effectiveness and make any necessary adjustments', 'NotStarted', 'PRO003'),
('TKS0016', 'Assess Current IT Infrastructure', '2022-09-01', '2022-09-30', 'Conduct an assessment of the current IT infrastructure to identify areas that need improvement', 'Completed', 'PRO004'),
('TKS0017', 'Develop IT System Upgrade Plan', '2022-10-01', '2022-10-31', 'Develop a plan for upgrading the IT systems based on the assessment', 'Completed', 'PRO004'),
('TKS0018', 'Acquire IT Equipment', '2022-11-01', '2022-11-15', 'Purchase and receive the necessary IT equipment for the upgrade', 'Completed', 'PRO004'),
('TKS0019', 'Install and Configure New IT System', '2022-11-16', '2022-11-30', 'Install and configure the new IT system according to the plan', 'Completed', 'PRO004'),
('TKS0020', 'Test and Train', '2022-12-01', '2022-12-15', 'Test the new IT system and provide training to users', 'Completed', 'PRO004'),
('TKS0021', 'Survey Planning', '2022-12-01', '2022-12-15', 'Planning the customer survey', 'NotStarted', 'PRO005'),
('TKS0022', 'Survey Questionnaire Design', '2022-12-16', '2022-12-31', 'Designing the questionnaire for the customer survey', 'NotStarted', 'PRO005'),
('TKS0023', 'Survey Distribution', '2023-01-01', '2023-01-15', 'Distributing the survey to customers', 'NotStarted', 'PRO005'),
('TKS0024', 'Survey Data Collection', '2023-01-16', '2023-01-25', 'Collecting data from customer survey', 'NotStarted', 'PRO005'),
('TKS0025', 'Survey Analysis and Reporting', '2023-01-26', '2023-01-31', 'Analyzing data from customer survey and preparing a report', 'NotStarted', 'PRO005');
SELECT * FROM Tasks WHERE ID = 'TKS001'
GO
CREATE TRIGGER update_tasks_status
ON Projects
AFTER UPDATE
AS
BEGIN
  IF UPDATE(Project_status) AND (SELECT COUNT(*) FROM deleted WHERE Project_status = 'Cancelled') = 0 AND (SELECT COUNT(*) FROM inserted WHERE Project_status = 'Cancelled') > 0
  BEGIN
    UPDATE Tasks SET Task_status = 'Cancelled' WHERE Project_ID IN (SELECT ID FROM inserted WHERE Project_status = 'Cancelled')
  END
END

select * from staff