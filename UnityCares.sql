USE [UnityCares]
GO
/****** Object:  User [alumno]    Script Date: 24/5/2024 11:56:37 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Donaciones]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[idONG] [int] NOT NULL,
	[idTipoDonacion] [int] NOT NULL,
	[descripcion] [varchar](1024) NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_Donaciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventos]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idONG] [int] NOT NULL,
	[nombre] [varchar](150) NOT NULL,
	[localidad] [varchar](1024) NOT NULL,
	[IdProvincia] [int] NULL,
	[fechaEventos] [datetime] NOT NULL,
	[horaEvento] [varchar](50) NULL,
	[cantidadPersonas] [int] NOT NULL,
 CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Noticias]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Noticias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdONG] [int] NULL,
	[Titulo] [varchar](50) NULL,
	[Descripcion] [varchar](max) NULL,
	[Foto] [varchar](2048) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_Noticias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ONGs]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ONGs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[logo] [varchar](1024) NULL,
	[descripcion] [varchar](max) NULL,
	[domicilio] [varchar](max) NULL,
	[IdProvincia] [int] NULL,
	[Latitud] [varchar](50) NULL,
	[Longitud] [varchar](50) NULL,
 CONSTRAINT [PK_ONGs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDonaciones]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDonaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TipoDonaciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](320) NOT NULL,
	[clave] [varchar](50) NOT NULL,
	[nombreUsuario] [varchar](50) NOT NULL,
	[fechaNacimiento] [date] NULL,
    [Descripcion] [varchar](MAX) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Donaciones] ON 

INSERT [dbo].[Donaciones] ([id], [idUsuario], [idONG], [idTipoDonacion], [descripcion], [fecha]) VALUES (1, 5, 7, 1, N'Para la ONG', CAST(N'2024-05-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Donaciones] ([id], [idUsuario], [idONG], [idTipoDonacion], [descripcion], [fecha]) VALUES (4, 4, 6, 2, N'Para los chicos', CAST(N'2024-05-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Donaciones] ([id], [idUsuario], [idONG], [idTipoDonacion], [descripcion], [fecha]) VALUES (5, 6, 5, 3, N'Para que los chicos tengan lo que realmente necesitan', CAST(N'2024-06-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Donaciones] ([id], [idUsuario], [idONG], [idTipoDonacion], [descripcion], [fecha]) VALUES (6, 7, 6, 1, N'Dono plata porque tengo la posibilidad todos los meses de darle a los necesitados un poquito', CAST(N'2024-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[Donaciones] ([id], [idUsuario], [idONG], [idTipoDonacion], [descripcion], [fecha]) VALUES (7, 8, 5, 2, N'Siempre hay quer contribuir con los demas, el dia de mañana lo bueno vuelve', CAST(N'2024-06-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Donaciones] ([id], [idUsuario], [idONG], [idTipoDonacion], [descripcion], [fecha]) VALUES (8, 10, 10, 1, N'Facilitariamos a la compra de tablets para el evento en navidad de BrawlGamersq', CAST(N'2024-10-11T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Donaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Eventos] ON 

INSERT [dbo].[Eventos] ([id], [idONG], [nombre], [localidad], [IdProvincia], [fechaEventos], [horaEvento], [cantidadPersonas]) VALUES (6, 5, N'JuguetesParaTodos', N'santa lucia', NULL, CAST(N'2024-06-10T00:00:00.000' AS DateTime), NULL, 50)
INSERT [dbo].[Eventos] ([id], [idONG], [nombre], [localidad], [IdProvincia], [fechaEventos], [horaEvento], [cantidadPersonas]) VALUES (8, 8, N'PelotasparalosPibes', N'Predio Tita', NULL, CAST(N'2024-10-10T00:00:00.000' AS DateTime), NULL, 100)
INSERT [dbo].[Eventos] ([id], [idONG], [nombre], [localidad], [IdProvincia], [fechaEventos], [horaEvento], [cantidadPersonas]) VALUES (9, 7, N'RedesYpelotas', N'Av.Rivadvia 3000', NULL, CAST(N'2024-09-15T00:00:00.000' AS DateTime), NULL, 150)
INSERT [dbo].[Eventos] ([id], [idONG], [nombre], [localidad], [IdProvincia], [fechaEventos], [horaEvento], [cantidadPersonas]) VALUES (10, 9, N'MaderaParaElMundo', N'Brandsen 805', NULL, CAST(N'2024-08-12T00:00:00.000' AS DateTime), NULL, 300)
INSERT [dbo].[Eventos] ([id], [idONG], [nombre], [localidad], [IdProvincia], [fechaEventos], [horaEvento], [cantidadPersonas]) VALUES (11, 10, N'tabletsParaTodos', N'Coronel Diaz 2170', NULL, CAST(N'2024-12-24T00:00:00.000' AS DateTime), NULL, 500)
SET IDENTITY_INSERT [dbo].[Eventos] OFF
GO
SET IDENTITY_INSERT [dbo].[ONGs] ON 

INSERT [dbo].[ONGs] ([id], [idUsuario], [nombre], [logo], [descripcion], [domicilio], [IdProvincia], [Latitud], [Longitud]) VALUES (5, 2, N'Mariposas y Soles', N'file:///C:/Users/47571983/Downloads/image0.jpeg', N'Es una ong de..', NULL, NULL, NULL, NULL)
INSERT [dbo].[ONGs] ([id], [idUsuario], [nombre], [logo], [descripcion], [domicilio], [IdProvincia], [Latitud], [Longitud]) VALUES (6, 4, N'Fulbito', N'https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.conectate.com.do%2Farticulo%2Ftodo-lo-que-necesitas-saber-sobre-el-futbol%2F&psig=AOvVaw0TfYpWO7o7RYewjwRtVG6X&ust=1716031550826000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKD3yurJlIYDFQAAAAAdAAAAABAJ', N'Es una ong que se dedica a tratar de inculcarle a los chicos el futbol en sus vidas', NULL, NULL, NULL, NULL)
INSERT [dbo].[ONGs] ([id], [idUsuario], [nombre], [logo], [descripcion], [domicilio], [IdProvincia], [Latitud], [Longitud]) VALUES (7, 4, N'voleicito', N'https://chajarialdia.com.ar/wp-content/uploads/2021/09/ViveSeleccion-y-Comunidad-Voley_76353721.jpg', N'Somos una ong que se dedica a inculcar voley desde que naces ', NULL, NULL, NULL, NULL)
INSERT [dbo].[ONGs] ([id], [idUsuario], [nombre], [logo], [descripcion], [domicilio], [IdProvincia], [Latitud], [Longitud]) VALUES (8, 5, N'LosFutbolitos', N'https://www.infobae.com/new-resizer/L-zGSUKQXVaHSV-fCS3Hry0FrZs=/1440x1440/filters:format(webp):quality(85)/s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2017/01/18131140/futbol-1920-3-1024x575.jpg', N'Los chicos de racing necesitan apoyo en algunas cosas y te necesitamos ', N'Yattay 240, cacabksabkd', 1, N'-35', N'-45')
INSERT [dbo].[ONGs] ([id], [idUsuario], [nombre], [logo], [descripcion], [domicilio], [IdProvincia], [Latitud], [Longitud]) VALUES (9, 8, N'losPalos', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTiDqGmd7sRQpTHKn92GTA_NXgaZvL98OxZRWIpEDqWbA&s', N'Es una ONG que busca donar madera para que se puedan armar cosas', NULL, NULL, NULL, NULL)
INSERT [dbo].[ONGs] ([id], [idUsuario], [nombre], [logo], [descripcion], [domicilio], [IdProvincia], [Latitud], [Longitud]) VALUES (10, 9, N'BrawlGamers', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSM7af0Uu1rWHrFTJJQkWrtxkBX569wLqIgtb3Yq5Uj2A&s', N'ong divertida para los chicos, les ofrecemos y les abrimos las puertas al hermoso mundo de los videojuegos', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ONGs] OFF
GO
SET IDENTITY_INSERT [dbo].[Provincias] ON 

INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (1, N'Ciudad Autonomna')
INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (2, N'Buenos Aires')
INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (3, N'Tuvcuman')
SET IDENTITY_INSERT [dbo].[Provincias] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoDonaciones] ON 

INSERT [dbo].[TipoDonaciones] ([id], [nombre]) VALUES (1, N'Plata')
INSERT [dbo].[TipoDonaciones] ([id], [nombre]) VALUES (2, N'Objetos')
INSERT [dbo].[TipoDonaciones] ([id], [nombre]) VALUES (3, N'Alimentos')
INSERT [dbo].[TipoDonaciones] ([id], [nombre]) VALUES (4, N'Servicios')
SET IDENTITY_INSERT [dbo].[TipoDonaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (2, N'mate@gmail.com', N'12345', N'mate', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (4, N'franco@gmail.com', N'12345', N'fran', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (5, N'leandrosolarte@gmail.com', N'76543', N'lean', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (6, N'guidinho@gmail.com', N'guiDOpalmeiras1', N'gudinhoPalmeiras', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (7, N'polshu@gmail.com', N'superPollo', N'PolshetaGamer', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (8, N'matiasxesteves@gmail.com', N'merlini36', N'matiasxpalo', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (9, N'ezegajer@gmail.com', N'boyitaboye69', N'ezocapo10', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (10, N'donantes@gmail.com', N'nosotrosAyudamos10', N'MrDonaciones', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (11, N'polshu@polshu.com.ar', N'pablito', N'pol', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (12, N'polshu@polshu.com.ar', N'pablito', N'pol', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (13, N'polshu@polshu.com.ar', N'pablito', N'pol', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (14, N'polshu@polshu.com.ar', N'pablito', N'pol', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (15, N'polshu@polshu.com.ar', N'pablito', N'pol', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (16, N'polshu@polshu.com.ar', N'pablito', N'pol', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (17, N'polshu@polshu.com.ar', N'pablito', N'pol', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (18, N'polshu@polshu.com.ar', N'pablito', N'pol', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (19, N'polshu@polshu.com.ar', N'pablito', N'pol', NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [email], [clave], [nombreUsuario], [fechaNacimiento], [Descripcion]) VALUES (20, N'polshu@polshu.com.ar', N'pass', N'polcito', CAST(N'1972-07-13' AS Date))
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Donaciones]  WITH CHECK ADD  CONSTRAINT [FK_Donaciones_ONGs] FOREIGN KEY([idONG])
REFERENCES [dbo].[ONGs] ([id])
GO
ALTER TABLE [dbo].[Donaciones] CHECK CONSTRAINT [FK_Donaciones_ONGs]
GO
ALTER TABLE [dbo].[Donaciones]  WITH CHECK ADD  CONSTRAINT [FK_Donaciones_TipoDonaciones] FOREIGN KEY([idTipoDonacion])
REFERENCES [dbo].[TipoDonaciones] ([id])
GO
ALTER TABLE [dbo].[Donaciones] CHECK CONSTRAINT [FK_Donaciones_TipoDonaciones]
GO
ALTER TABLE [dbo].[Donaciones]  WITH CHECK ADD  CONSTRAINT [FK_Donaciones_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[Donaciones] CHECK CONSTRAINT [FK_Donaciones_Usuarios]
GO
ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [FK_Eventos_ONGs] FOREIGN KEY([idONG])
REFERENCES [dbo].[ONGs] ([id])
GO
ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [FK_Eventos_ONGs]
GO
ALTER TABLE [dbo].[ONGs]  WITH CHECK ADD  CONSTRAINT [FK_ONGs_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[ONGs] CHECK CONSTRAINT [FK_ONGs_Usuarios]
GO
/****** Object:  StoredProcedure [dbo].[Donaciones_Insert]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Donaciones_Insert] 
	(
	-- Add the parameters for the stored procedure here
		@id				    int,
		@idUsuario			int,
		@idONG			    int,
		@idTipoDonacion	    int,
		@descripcion varchar(1024),
		@fecha			 datetime
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	INSERT INTO [Donaciones](
		
		[id],
		[idUsuario],
		[idONG],
		[idTipoDonacion],
		[descripcion],
		[fecha]


	)
	VALUES (
		@id,
		@idUsuario,
		@idONG,
		@idTipoDonacion,
		@descripcion,
		@fecha
	)

END
GO
/****** Object:  StoredProcedure [dbo].[Eventos_Insert]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Eventos_Insert](
	-- Add the parameters for the stored procedure here
	@id				    int,
	@idONG			    int,
	@nombre	    varchar(150),
	@localidad varchar(1024),
	@fechaEventos datetime,
	@cantidadPersonas   int
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO [Eventos](
		[id],
		[idONG],
		[nombre],
		[localidad],
		[fechaEventos],
		[cantidadPersonas]
	) VALUES (
		@id,
		@idONG,
		@nombre,
		@localidad,
		@fechaEventos,
		@cantidadPersonas
	)
END
GO
/****** Object:  StoredProcedure [dbo].[TipoDonaciones_Insert]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TipoDonaciones_Insert]( 
	@id		int,
	@nombre varchar(150)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [TipoDonaciones](
	[id],
	[nombre]
	)VALUES(
	@id,
	@nombre
	)
END
GO
/****** Object:  StoredProcedure [dbo].[Usuarios_Insert]    Script Date: 24/5/2024 11:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuarios_Insert](
/*
	Ejemplo 
	EXEC [Usuarios_Insert] 'polshu@polshu.com.ar', 'pass', 'polcito', '1972-07-13'

*/
	-- Add the parameters for the stored procedure here
	@email				varchar(320),
	@clave				varchar(50),
	@nombreUsuario		varchar(50),
	@fechaNacimiento	Date,
    @Descripcion        varchar(MAX)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	INSERT INTO [Usuarios] (
		[email],
		[clave],
		[nombreUsuario],
		[fechaNacimiento],
        [Descripcion]
	) VALUES (
		@email,
		@clave,
		@nombreUsuario,
		@fechaNacimiento,
        @Descripcion
	)
END
GO
