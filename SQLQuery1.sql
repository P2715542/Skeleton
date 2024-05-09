USE [p2715542]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblSofa_FilterBySofaId]
		@SofaId = 1

SELECT	@return_value as 'Return Value'

GO
