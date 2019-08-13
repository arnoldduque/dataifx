CREATE PROCEDURE [dbo].[ObtenerDiasProducto]
	@IdProducto INT
AS
BEGIN	

	SELECT DISTINCT DAY(I.Creado)
	FROM Inventario I
	WHERE I.IdProducto = @IdProducto
		AND MONTH(I.Creado) = MONTH(GETDATE()) AND YEAR(I.Creado) = YEAR(GETDATE())

END