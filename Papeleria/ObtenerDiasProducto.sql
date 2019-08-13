CREATE PROCEDURE [dbo].[ObtenerDiasProducto]
	@IdProducto INT
AS
BEGIN	

	SELECT DISTINCT 
			MONTH(I.Creado) [Mes],
			DAY(I.Creado) [Dia]
	FROM Inventario I
	WHERE I.IdProducto = @IdProducto
		AND MONTH(I.Creado) = MONTH(GETDATE()) AND YEAR(I.Creado) = YEAR(GETDATE())

END