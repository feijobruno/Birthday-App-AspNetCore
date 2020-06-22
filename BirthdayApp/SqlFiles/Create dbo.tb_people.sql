USE [InfnetDatabase]
GO

/****** Object: Table [dbo].[tb_people] Script Date: 18/06/2020 17:25:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* SELECT * FROM [tb_people] ; */

SELECT 
	  ID
	, FIRSTNAME
	, Birthday
	, DATEADD(year,2020, Birthday) AS TESTE 
	, SUBSTRING(1,4,birthday) AS TESTE2
	FROM [tb_people] 
/* WHERE MONTH(Birthday) * 100 + DAY(Birthday) > MONTH(getdate()) * 100 + DAY(getdate()) 
ORDER BY MONTH(Birthday), DAY(Birthday) */





