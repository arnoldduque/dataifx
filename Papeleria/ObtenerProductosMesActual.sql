CREATE PROCEDURE [dbo].[ObtenerProductosMesActual]	
AS
BEGIN
	SELECT DISTINCT 			
			TP.Nombre [Tipo Producto],
			P.Nombre [Producto]
	FROM Inventario I
	INNER JOIN Producto P
		ON I.IdProducto = P.Id
	INNER JOIN TipoProducto TP
		ON P.IdTipoProducto = TP.Id
	WHERE MONTH(I.Creado) = MONTH(GETDATE()) AND YEAR(I.Creado) = YEAR(GETDATE())
	ORDER BY TP.Nombre
END
