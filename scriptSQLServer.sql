USE [LabEstoque]
GO
/****** Object:  Table [dbo].[Dados_Experimentos]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dados_Experimentos](
	[ID] [smallint] IDENTITY(100,1) NOT NULL,
	[Curso] [varchar](250) NOT NULL,
	[Experimento] [varchar](500) NOT NULL,
	[Material] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dados_Ocorrencia]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dados_Ocorrencia](
	[ID] [smallint] IDENTITY(100,1) NOT NULL,
	[Cod_Aluno] [varchar](6) NOT NULL,
	[Cod_Turma] [varchar](30) NOT NULL,
	[Cod_Prof] [varchar](30) NOT NULL,
	[Cod_Aux] [varchar](30) NOT NULL,
	[Ocorrencia] [varchar](2000) NOT NULL,
	[Hora_Dia] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dados_Presenca]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dados_Presenca](
	[ID] [smallint] IDENTITY(100,1) NOT NULL,
	[Cod_Prof] [varchar](30) NOT NULL,
	[Temp_Prof] [varchar](4) NOT NULL,
	[Cod_Aux] [varchar](30) NOT NULL,
	[Temp_Aux] [varchar](4) NOT NULL,
	[Cod_Aluno] [varchar](6) NOT NULL,
	[Temp_Aluno] [varchar](4) NOT NULL,
	[Cod_Turma] [varchar](30) NOT NULL,
	[Hora_Dia] [datetime] NOT NULL,
	[Observacao] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dados_Turma]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dados_Turma](
	[ID] [smallint] IDENTITY(100,1) NOT NULL,
	[Cod_Turma] [varchar](30) NOT NULL,
	[Nome_Turma] [varchar](50) NOT NULL,
	[Período] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva_Experimentos]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva_Experimentos](
	[ID] [smallint] IDENTITY(100,1) NOT NULL,
	[Cod_Aluno] [varchar](6) NOT NULL,
	[Nome_Aluno] [varchar](255) NOT NULL,
	[Curso] [varchar](250) NOT NULL,
	[Semestre] [varchar](20) NOT NULL,
	[Disciplina] [varchar](500) NOT NULL,
	[Experimento] [varchar](500) NOT NULL,
	[Nome_Prof] [varchar](255) NOT NULL,
	[Sala] [varchar](4) NOT NULL,
	[DataEntrada] [varchar](12) NOT NULL,
	[HoraEntrada] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDevoluções]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDevoluções](
	[ID] [smallint] IDENTITY(100,1) NOT NULL,
	[Item] [varchar](50) NOT NULL,
	[Quantidade] [int] NOT NULL,
	[Data] [varchar](38) NOT NULL,
	[Observação] [varchar](max) NULL,
	[Patrimônio] [varchar](38) NULL,
	[Registro] [varchar](38) NOT NULL,
	[Responsavel] [varchar](38) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmpréstimos]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmpréstimos](
	[ID] [smallint] IDENTITY(100,1) NOT NULL,
	[Item] [varchar](50) NOT NULL,
	[Quantidade] [int] NOT NULL,
	[Data] [varchar](38) NOT NULL,
	[Patrimônio] [varchar](50) NOT NULL,
	[PrevisãoDeDevolução] [varchar](38) NOT NULL,
	[Registro] [varchar](38) NOT NULL,
	[Setor_Materia] [varchar](38) NOT NULL,
	[Responsavel] [varchar](38) NOT NULL,
	[Itens_para_devolver] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEstoque2]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstoque2](
	[ID] [smallint] IDENTITY(100,1) NOT NULL,
	[Item] [text] NOT NULL,
	[Quantidade_Total] [int] NULL,
	[Quantidade_Atual] [int] NULL,
	[Descrição] [text] NOT NULL,
	[Sala] [text] NULL,
	[Armário] [text] NULL,
	[Espécie] [text] NOT NULL,
	[Classificação] [text] NULL,
	[Foto] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoginUsuarios]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoginUsuarios](
	[IdCliente] [smallint] IDENTITY(100,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Telefone] [varchar](50) NOT NULL,
	[RG] [varchar](38) NOT NULL,
	[CPF] [varchar](38) NOT NULL,
	[Endereço] [varchar](max) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblManutenção]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblManutenção](
	[ID] [smallint] IDENTITY(100,1) NOT NULL,
	[Item] [varchar](50) NOT NULL,
	[Patrimônio] [varchar](50) NULL,
	[Ocorrência] [varchar](38) NOT NULL,
	[Registro] [varchar](38) NOT NULL,
	[Data] [varchar](38) NOT NULL,
	[Observação] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPatrimônio2]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPatrimônio2](
	[ID] [smallint] IDENTITY(100,1) NOT NULL,
	[Item] [text] NOT NULL,
	[Código] [varchar](50) NOT NULL,
	[Patrimônio] [text] NOT NULL,
	[Situação] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRegistro]    Script Date: 27/02/2021 15:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRegistro](
	[IdCliente] [smallint] IDENTITY(100,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[RG] [varchar](38) NOT NULL,
	[CPF] [varchar](38) NOT NULL,
	[Endereço] [varchar](max) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Telefone] [varchar](38) NOT NULL,
	[Registro] [varchar](38) NOT NULL,
	[Telefone_2] [varchar](38) NULL,
	[Email] [varchar](38) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
