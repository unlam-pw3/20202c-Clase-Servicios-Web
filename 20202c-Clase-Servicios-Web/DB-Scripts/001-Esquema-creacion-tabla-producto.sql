USE [master]
GO
/****** Object:  Database [2020-2c-EF]    Script Date: 10/21/2020 9:20:36 PM ******/
CREATE DATABASE [2020-2c-EF]
 GO
USE [2020-2c-EF]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 10/21/2020 9:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
	[Precio] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

GO
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Precio]) VALUES (1, N'Pelota', CAST(6000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Precio]) VALUES (2, N'Camiseta Banfield', CAST(12000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Precio]) VALUES (3, N'Medias', CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Precio]) VALUES (4, N'Zapatilla Runner', CAST(15000.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
USE [master]
GO
ALTER DATABASE [2020-2c-EF] SET  READ_WRITE 
GO
