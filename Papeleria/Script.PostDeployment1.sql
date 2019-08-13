/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

MERGE INTO TipoProducto AS Target 
USING (VALUES 
        (1, 'Papeleria'), 
        (2, 'Dulces'), 
        (3, 'Libros')
) 
AS Source (Id, Nombre) 
ON Target.Id = Source.Id 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Nombre) 
VALUES (Nombre);


MERGE INTO Unidad AS Target 
USING (VALUES 
        (1, 'Unitario'), 
        (2, 'Docena'), 
        (3, 'Caja'),
		(4, 'Bolsa')
) 
AS Source (Id, Nombre) 
ON Target.Id = Source.Id 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Nombre) 
VALUES (Nombre);


MERGE INTO Producto AS Target
USING (VALUES 
	(1, 'Lapiz B12', 1),
	(2, 'Borrador Nata', 1),
	(3, 'Menta', 2),
	(4, 'TicTac', 2),
	(5, 'Algebra Baldor', 3),
	(6, 'Calculo Integral', 3)
)
AS Source (Id, Nombre, IdTipoProducto)
ON Target.Id = Source.Id
WHEN NOT MATCHED BY TARGET THEN
INSERT (Nombre, IdTipoProducto)
VALUES (Nombre, IdTipoProducto);

MERGE INTO Inventario AS Target
USING (VALUES 
	(1, 1, 1, 10, '2019-08-01'),
	(2, 1, 2, 1, '2019-08-02'),
	(3, 2, 3, 20, '2019-08-03'),
	(4, 2, 4, 30, '2019-08-04'),
	(5, 3, 1, 40, '2019-08-05'),
	(6, 4, 2, 1, '2019-08-06'),
	(7, 5, 3, 50, '2019-08-07'),
	(8, 5, 4, 60, '2019-08-07'),
	(9, 6, 1, 70, '2019-08-08'),
	(10, 6, 2, 1, '2019-08-08')
)
AS Source (Id, IdProducto, IdUnidad, Cantidad, Creado)
ON Target.Id = Source.Id
WHEN NOT MATCHED BY TARGET THEN
INSERT (IdProducto, IdUnidad, Cantidad, Creado)
VALUES (IdProducto, IdUnidad, Cantidad, Creado);
