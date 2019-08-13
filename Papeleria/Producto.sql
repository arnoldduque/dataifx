CREATE TABLE [dbo].[Producto]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] VARCHAR(50) NOT NULL, 
    [IdTipoProducto] INT NOT NULL,
	CONSTRAINT [FK_dbo.Producto_dbo.TipoProducto_Id] FOREIGN KEY ([IdTipoProducto]) 
        REFERENCES [dbo].[TipoProducto] ([Id]) ON DELETE CASCADE
)
