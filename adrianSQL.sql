--ej 1
Use PracticaSQL
SELECT ID, LAST_NAME, HIRE_DATE, SALARY
FROM TEST.EMPLOYEES 

--ej 2
Use PracticaSQL
SELECT ID, LAST_NAME, HIRE_DATE , (SALARY * 12) AS ANNUAL_SALARY--validar
FROM TEST.EMPLOYEES 


--ej 3 -4
Use PracticaSQL
SELECT ID,
       LAST_NAME + '||' +  FIRST_NAME AS FULL_NAME,
       HIRE_DATE,
       (SALARY * 12) AS SALARY_ANUAL
FROM TEST.EMPLOYEES;


--ej 5 - a
Use PracticaSQL
SELECT DEPARTMENT_ID 
FROM TEST.EMPLOYEES

--ej 5 - b
Use PracticaSQL
SELECT DISTINCT DEPARTMENT_ID 
FROM TEST.EMPLOYEES


----------------------------------------------------------------------------------------------------------

--Comparaciones simples y especiales/ Comparecioes nulas

--ej 6
Use PracticaSQL

SELECT ID, LAST_NAME, HIRE_DATE, SALARY
FROM TEST.EMPLOYEES 
WHERE SALARY < 2000


--ej 7
Use PracticaSQL

SELECT ID, LAST_NAME, HIRE_DATE, SALARY
FROM TEST.EMPLOYEES 
WHERE SALARY BETWEEN 1800 AND 3000


--ej 8
Use PracticaSQL

SELECT ID, LAST_NAME, HIRE_DATE, SALARY
FROM TEST.EMPLOYEES 
WHERE DEPARTMENT_ID IN (10, 30, 31)



--ej 9
Use PracticaSQL

SELECT ID, LAST_NAME, HIRE_DATE, SALARY
FROM TEST.EMPLOYEES 
WHERE LAST_NAME LIKE 'F%'

--EJ 10 -A
Use PracticaSQL

SELECT ID, LAST_NAME, JOB_ID
FROM TEST.EMPLOYEES 
WHERE JOB_ID IS NULL



--EJ 10 - B
Use PracticaSQL

SELECT ID, LAST_NAME, JOB_ID
FROM TEST.EMPLOYEES 
WHERE JOB_ID IS NOT NULL

----------------------------------------------------------------------------------------------------------

--Comparaciones con nexos lógicos/ Precencia de condiciones

--EJ 11
Use PracticaSQL

SELECT ID, LAST_NAME, JOB_ID
FROM TEST.EMPLOYEES 
WHERE JOB_ID = 'ADA_CTB' OR JOB_ID = 'FQ_GRT' 
    AND SALARY > 1900

--ej 12
Use PracticaSQL

SELECT ID, LAST_NAME, JOB_ID
FROM TEST.EMPLOYEES 
WHERE (JOB_ID = 'ADA_CTB' OR JOB_ID = 'FQ_GRT') 
    AND SALARY > 1900


----------------------------------------------------------------------------------------------------------

--Ordenamiento 

--13
Use PracticaSQL

SELECT ID, LAST_NAME, HIRE_DATE
FROM TEST.EMPLOYEES 
ORDER BY HIRE_DATE ASC

--14
Use PracticaSQL

SELECT ID, LAST_NAME, HIRE_DATE
FROM TEST.EMPLOYEES 
ORDER BY HIRE_DATE DESC , LAST_NAME ASC


--15 - 16
Use PracticaSQL

SELECT ID, LAST_NAME, (SALARY * 12) AS ANNUAL_SALARY
FROM TEST.EMPLOYEES 
ORDER BY ANNUAL_SALARY DESC


----------------------------------------------------------------------------------------------------------

--USO DE CLAUSULAS JOIN

--EJ 17 
Use PracticaSQL

SELECT e.ID, e.FIRST_NAME , e.LAST_NAME, e.DEPARTMENT_ID,d.DEPARTMENT_DESCRIPTION
FROM TEST.EMPLOYEES AS e
INNER JOIN TEST.DEPARTMENTS AS d
ON e.DEPARTMENT_ID = d.ID 

--EJ 18
Use PracticaSQL

SELECT e.ID, e.FIRST_NAME , e.LAST_NAME, e.DEPARTMENT_ID,d.DEPARTMENT_DESCRIPTION
FROM TEST.EMPLOYEES AS e
FULL JOIN TEST.DEPARTMENTS AS d
ON e.DEPARTMENT_ID = d.ID 

--EJ 19
Use PracticaSQL

SELECT d.ID, d.DEPARTMENT_NAME,d.DEPARTMENT_DESCRIPTION ,e.DEPARTMENT_ID, e.FIRST_NAME , e.LAST_NAME
FROM TEST.DEPARTMENTS AS d
FULL JOIN TEST.EMPLOYEES  AS e
ON   d.ID = e.DEPARTMENT_ID


----------------------------------------------------------------------------------------------------------

--Selfjoin


--EJ 20
Use PracticaSQL

SELECT e.FIRST_NAME, e.LAST_NAME, e.MANAGER_ID, j.JOB_NAME
FROM TEST.EMPLOYEES AS e
INNER JOIN TEST.JOBS  AS j
ON   e.JOB_ID = j.ID

----------------------------------------------------------------------------------------------------------

--Funciones de agrupamiento
--EJ 21

SELECT MIN(SALARY) AS MIN_SALARY,
	   MAX(SALARY) AS MAX_SALARY,
	   AVG(SALARY) AS AVG_SALARY,
	   SUM(SALARY) AS SUM_SALARY
FROM TEST.EMPLOYEES 

--EJ 22

SELECT MIN(HIRE_DATE) AS MIN_HIRE_DATE,
	   MAX(HIRE_DATE) AS MAX_HIRE_DATE,
	    AVG(CAST(HIRE_DATE AS FLOAT)) AS PROMEDIO_CONTRATACION,
		--SUM(CAST(HIRE_DATE AS FLOAT)) AS SUM_HIRE_DATE
FROM TEST.EMPLOYEES 

--EJ 23

SELECT 
    d.department_name,
    COUNT(e.id) AS empleados_por_departamento
FROM 
    test.departments d
LEFT JOIN 
    test.employees e ON d.id = e.department_id
GROUP BY 
    d.department_name;

-- 24

SELECT
	d.department_name,
	j.job_name,
	COUNT(e.id) AS empleados_departamento
FROM
	test.employees e
RIGHT JOIN
	test.departments d ON d.id = e.department_id
RIGHT JOIN
	test.jobs j on j.id = e.job_id
GROUP BY
	d.department_name, j.job_name

----------------------------------------------------------------------------------------------------------

--Condiciones de grupo

-- 25

SELECT
	d.department_name,
	AVG(e.salary) AS salario_promedio
FROM
	test.employees e
JOIN
	test.departments d ON d.id = e.department_id
GROUP BY
	d.department_name
HAVING
	AVG(e.salary) < 1200

-- 27
USE PracticaSQL
INSERT INTO TEST.EMPLOYEES(
	ID,
	FIRST_NAME, 
	LAST_NAME, 
	HIRE_DATE
	)
VALUES (
	504,
	'ADRIAN',
	'AGÜERO',
	'19961110 06:00:00'
	)

--28

USE PracticaSQL
SELECT COLUMN_NAME AS REQUIRED_FIELDS
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'EMPLOYEES' AND IS_NULLABLE = 'NO'

--29
USE PracticaSQL
INSERT INTO TEST.EMPLOYEES(
	ID,
	FIRST_NAME, 
	LAST_NAME, 
	SALARY, 
	DEPARTMENT_ID, 
	JOB_ID, 
	HIRE_DATE, 
	MANAGER_ID
	)
SELECT
	ID = 102,
	FIRST_NAME = 'ADRIÁN', 
	LAST_NAME, 
	SALARY + 200, 
	DEPARTMENT_ID, 
	JOB_ID, 
	HIRE_DATE, 
	MANAGER_ID = NULL
FROM TEST.EMPLOYEES
WHERE FIRST_NAME = 'Gustavo' AND LAST_NAME = 'Boulette'

-- 30

USE PracticaSQL
UPDATE TEST.EMPLOYEES
SET SALARY = 1100
WHERE ID = 10

-- 30 -1

USE PracticaSQL
UPDATE TEST.EMPLOYEES SET
	SALARY = SALARY * 1.1
WHERE DEPARTMENT_ID = 40;

-- 30 -2

USE PracticaSQL
DELETE FROM TEST.DEPARTMENTS WHERE ID>50

-- 30 - 3

Use PracticaSQL
SELECT ID,FIRST_NAME,LAST_NAME,SALARY,DEPARTMENT_ID,JOB_ID,HIRE_DATE FROM TEST.EMPLOYEES WHERE DEPARTMENT_ID = 40;
DELETE FROM TEST.DEPARTMENTS WHERE ID = 40;

----------------------------------------------------------------------------------------------------------

--FUNCION

--30 -4


CREATE FUNCTION fn_AntiguedadEmpleado(@id INT)
RETURNS INT
AS
BEGIN
    DECLARE @antiguedad_empleado INT
    DECLARE @hire_date DATE

    SELECT @hire_date = HIRE_DATE FROM TEST.EMPLOYEES WHERE ID = @id
    SELECT @antiguedad_empleado = DATEDIFF(YEAR, @hire_date, GETDATE())

    RETURN @antiguedad_empleado
END;


----------------------------------------------------------------------------------------------------------

--SP
--31

CREATE PROCEDURE sp_GetNombreAntiguedad
AS
BEGIN
    SELECT
        CONCAT(e.FIRST_NAME, ', ', e.LAST_NAME) AS 'NOMBRE COMPLETO',
		dbo.fn_AntiguedadEmpleado(e.id) AS 'ANTIGUEDAD'
    FROM
        TEST.EMPLOYEES e
    ORDER BY
        Antiguedad DESC;
END;

EXECUTE sp_GetNombreAntiguedad;