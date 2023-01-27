CREATE TABLE [dbo].[EmployeeTbl]
(
	[EmpId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmpName] VARCHAR(50) NOT NULL, 
    [EmpGen] VARCHAR(10) NOT NULL, 
    [EmpDep] INT NOT NULL, 
    [EmpDOB] DATE NOT NULL, 
    [EmpJDate] DATE NOT NULL, 
    [EmpSal] INT NOT NULL, 
    CONSTRAINT [Fk1] FOREIGN KEY (EmpDep) REFERENCES [DepartmentTbl]([])
)
