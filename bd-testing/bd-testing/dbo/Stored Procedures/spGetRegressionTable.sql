-- =============================================
-- Author:		Juan Osorio
-- Create date: 2020-04-04
-- Description:	Stored Procedure
-- =============================================
CREATE PROCEDURE spGetRegressionTable 	
AS
BEGIN	
	SET NOCOUNT ON;
    
	SELECT Id, Name, Value FROM RegressionTable
END