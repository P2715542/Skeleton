USE [p2715542]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblStaff_SelectAll]

SELECT	@return_value as 'Return Value'

GO
