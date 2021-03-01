/** SOLUTION A: **/
SELECT *
FROM [employees] JOIN [departments] ON [employees].[department_id] = [departments].[id]
				 JOIN [salary] ON [employees].[salary_id] = [salary].[id]
WHERE [salary] = (SELECT MAX([salary]) FROM [salary])

/** SOLUTION B: **/
SELECT [id], [name], [date_hired]
FROM [employees]
WHERE [date_hired] >= '2017-01-01' AND [date_hired] <= '2018-12-31'  --filter start from beginning of 2017 and last day of 2018

/** SOLUTION C: **/
SELECT [employees].[id], [name], [date_hired], [department]
FROM [employees] JOIN [departments] ON [employees].[department_id] = [departments].[id]
WHERE [department] = 'IT' AND [date_hired] >= '2018-01-01'