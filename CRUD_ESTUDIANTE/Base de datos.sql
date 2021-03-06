USE [Segundo parcial]
GO
/****** Object:  Table [dbo].[carrera]    Script Date: 07/07/2020 14:42:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[carrera](
	[id_carrera] [int] IDENTITY(1,1) NOT NULL,
	[carrera] [varchar](25) NOT NULL,
 CONSTRAINT [PK__carrera__82525F26108B795B] PRIMARY KEY CLUSTERED 
(
	[id_carrera] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[provincia]    Script Date: 07/07/2020 14:42:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[provincia](
	[id_provincia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_provincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 07/07/2020 14:42:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estudiante](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[matricula] [int] NOT NULL,
	[nombre] [varchar](25) NULL,
	[carrera] [varchar](25) NULL,
	[provincia] [varchar](25) NULL,
	[id_carrera] [int] NOT NULL,
	[id_provincia] [int] NOT NULL,
 CONSTRAINT [PK__Estudian__3213E83F1CF15040] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK__Estudiant__id_ca__1ED998B2]    Script Date: 07/07/2020 14:42:21 ******/
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK__Estudiant__id_ca__1ED998B2] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[carrera] ([id_carrera])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK__Estudiant__id_ca__1ED998B2]
GO
/****** Object:  ForeignKey [FK__Estudiant__id_pr__1FCDBCEB]    Script Date: 07/07/2020 14:42:21 ******/
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK__Estudiant__id_pr__1FCDBCEB] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[provincia] ([id_provincia])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK__Estudiant__id_pr__1FCDBCEB]
GO
