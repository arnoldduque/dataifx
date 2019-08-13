CREATE PROCEDURE [dbo].[CrearNuevoItem]
	@IdProducto int,
	@IdUnidad int,
	@Cantidad bigint
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM Inventario WHERE YEAR(Creado) = YEAR(GETDATE()) AND MONTH(Creado) = MONTH(GETDATE()) AND DAY(Creado) = DAY(GETDATE())) 
	BEGIN
		INSERT INTO Inventario(IdProducto, IdUnidad, Cantidad, Creado) VALUES (@IdProducto, @IdUnidad, @Cantidad, GETDATE())
		SELECT 'Producto Creado.'
	END

	SELECT 'El dia de hoy ya se creo un producto, Producto No Creado.'
END
