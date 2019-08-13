CREATE PROCEDURE [dbo].[CrearNuevoItem]
	@IdProducto int,
	@IdUnidad int,
	@Cantidad bigint
AS
BEGIN
	IF NOT EXISTS(
					SELECT 1 FROM Inventario 
					WHERE YEAR(Creado) = YEAR(GETDATE()) 
					  AND MONTH(Creado) = MONTH(GETDATE()) 
					  AND DAY(Creado) = DAY(GETDATE())
					  AND IdProducto = @IdProducto) 
	BEGIN
		INSERT INTO Inventario(IdProducto, IdUnidad, Cantidad, Creado) VALUES (@IdProducto, @IdUnidad, @Cantidad, GETDATE())
		SELECT 'Producto Creado.'
	END
	ELSE
	BEGIN
		SELECT 'El día de hoy ya se creó el producto ' + CaST(@IdProducto AS varchar) + ', Producto No Creado.'
	END
END
 