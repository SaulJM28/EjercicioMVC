USE [EjercicioMVC]
GO

/****** Object:  Table [dbo].[Productos]    Script Date: 04/10/2021 17:25:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Productos](
	[ProductoId] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ProductoNombre] [varchar](150) NULL,
	[Precio] [money] NULL,
	[ProductosTipoId] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ProductoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([ProductosTipoId])
REFERENCES [dbo].[ProductosTipo] ([ProductosTipoId])
GO


