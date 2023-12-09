CREATE TABLE DEPARTMENT (
  deptId int,
  dname varchar(100),
  deptNo varchar(50)
);

-- insert
INSERT INTO DEPARTMENT(deptId,dname,deptNo) VALUES (11, 'A', '20');
INSERT INTO DEPARTMENT(deptId,dname,deptNo) VALUES (12, 'B', '30');
INSERT INTO DEPARTMENT(deptId,dname,deptNo) VALUES (13, 'C', '40');

-- fetch 
--select * from EMPLOYEE;

--select * from EMPLOYEE
--where name ='clark';

--select distinct dept,name
--from EMPLOYEE;

--select * 
--from EMPLOYEE
--order by name;

--select empid as ID,name as EMPNAME,dept as DEPT
--from EMPLOYEE;\

select  empId,name, distinct dept from EMPLOYEE;
SELECT DISTINCT dept, name, empId FROM EMPLOYEE;

select * from EMPLOYEE;

SELECT *
FROM (
    SELECT empId, name, dept, ROW_NUMBER() OVER (PARTITION BY dept ORDER BY empId) AS row_num
    FROM EMPLOYEE
) AS ranked
WHERE row_num = 1
order by empid;





