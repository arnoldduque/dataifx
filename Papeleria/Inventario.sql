CREATE TABLE [dbo].[Inventario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdProducto] INT NOT NULL, 
    [IdUnidad] INT NOT NULL, 
    [Cantidad] BIGINT NOT NULL, 
    [Creado] DATE NOT NULL,
	CONSTRAINT [FK_dbo.Inventario_dbo.Producto_Id] FOREIGN KEY ([IdProducto]) 
        REFERENCES [dbo].[Producto] ([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.Inventario_dbo.Unidad_Id] FOREIGN KEY ([IdUnidad]) 
        REFERENCES [dbo].[Unidad] ([Id]) ON DELETE CASCADE
)
