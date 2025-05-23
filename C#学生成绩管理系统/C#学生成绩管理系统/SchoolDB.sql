USE [SchoolDB]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 2024/10/31 0:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[course_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[course_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 2024/10/31 0:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[student_id] [varchar](50) NOT NULL,
	[course_name] [varchar](50) NOT NULL,
	[grade] [int] NULL,
	[message] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[student_id] ASC,
	[course_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2024/10/31 0:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[student_id] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[class] [varchar](50) NOT NULL,
	[hometown] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 2024/10/31 0:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[teacher_id] [varchar](50) NOT NULL,
	[course_name] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[teacher_id] ASC,
	[course_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Course] ([course_name]) VALUES (N'数学')
INSERT [dbo].[Course] ([course_name]) VALUES (N'英语')
INSERT [dbo].[Course] ([course_name]) VALUES (N'语文')
GO
INSERT [dbo].[Grade] ([student_id], [course_name], [grade], [message]) VALUES (N'222200411', N'数学', 100, NULL)
INSERT [dbo].[Grade] ([student_id], [course_name], [grade], [message]) VALUES (N'222200411', N'英语', 99, N'很好')
INSERT [dbo].[Grade] ([student_id], [course_name], [grade], [message]) VALUES (N'222200411', N'语文', 99, N'很好')
INSERT [dbo].[Grade] ([student_id], [course_name], [grade], [message]) VALUES (N'222200413', N'英语', 100, N'很好')
GO
INSERT [dbo].[Student] ([student_id], [name], [class], [hometown], [password]) VALUES (N'222200411', N'李超', N'三年一班', N'福建省福清市', N'123456')
INSERT [dbo].[Student] ([student_id], [name], [class], [hometown], [password]) VALUES (N'222200412', N'兰平', N'三年一班', N'福建省福清市', N'123456')
INSERT [dbo].[Student] ([student_id], [name], [class], [hometown], [password]) VALUES (N'222200413', N'陈袁辉', N'三年一班', N'福建省福清市', N'123456')
GO
INSERT [dbo].[Teacher] ([teacher_id], [course_name], [name], [password]) VALUES (N'1', N'语文', N'冰心', N'123456')
INSERT [dbo].[Teacher] ([teacher_id], [course_name], [name], [password]) VALUES (N'2', N'数学', N'陈景润', N'123456')
INSERT [dbo].[Teacher] ([teacher_id], [course_name], [name], [password]) VALUES (N'3', N'英语', N'Peter', N'123456')
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD FOREIGN KEY([course_name])
REFERENCES [dbo].[Course] ([course_name])
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[Student] ([student_id])
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Student] FOREIGN KEY([student_id])
REFERENCES [dbo].[Student] ([student_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [FK_Grade_Student]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD FOREIGN KEY([course_name])
REFERENCES [dbo].[Course] ([course_name])
GO
