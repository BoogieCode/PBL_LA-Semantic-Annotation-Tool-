USE [greeceprojectdb]
GO
/****** Object:  Schema [m2ss]    Script Date: 7/8/2021 10:32:19 AM ******/
CREATE SCHEMA [m2ss]
GO
/****** Object:  Schema [testultimcurs]    Script Date: 7/8/2021 10:32:19 AM ******/
CREATE SCHEMA [testultimcurs]
GO
/****** Object:  Table [testultimcurs].[activity]    Script Date: 7/8/2021 10:32:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[activity](
	[idactivity] [int] IDENTITY(46,1) NOT NULL,
	[activity_name] [nvarchar](45) NULL,
 CONSTRAINT [PK_activity_idactivity] PRIMARY KEY CLUSTERED 
(
	[idactivity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[course_phase]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[course_phase](
	[idcourse_phase] [int] NOT NULL,
	[cphase_name] [nvarchar](45) NULL,
 CONSTRAINT [PK_course_phase_idcourse_phase] PRIMARY KEY CLUSTERED 
(
	[idcourse_phase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[data]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[data](
	[iddata] [int] NOT NULL,
	[data_name] [nvarchar](500) NULL,
 CONSTRAINT [PK_data_iddata] PRIMARY KEY CLUSTERED 
(
	[iddata] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[la_method]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[la_method](
	[idla_method] [int] NOT NULL,
	[lamethod_name] [nvarchar](500) NULL,
 CONSTRAINT [PK_la_method_idla_method] PRIMARY KEY CLUSTERED 
(
	[idla_method] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[pbl_step]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[pbl_step](
	[idpbl_step] [int] IDENTITY(10,1) NOT NULL,
	[step_name] [nvarchar](45) NULL,
 CONSTRAINT [PK_pbl_step_idpbl_step] PRIMARY KEY CLUSTERED 
(
	[idpbl_step] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[rel_latool_lam]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[rel_latool_lam](
	[idrel4] [int] NULL,
	[techid] [int] NOT NULL,
	[lamid] [int] NOT NULL,
 CONSTRAINT [PK_rel_latool_lam_techid] PRIMARY KEY CLUSTERED 
(
	[techid] ASC,
	[lamid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[rel_step_act_tool]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[rel_step_act_tool](
	[idrel1] [int] NULL,
	[actid] [int] NOT NULL,
	[stepid] [int] NOT NULL,
	[techid] [int] NOT NULL,
 CONSTRAINT [PK_rel_step_act_tool_actid] PRIMARY KEY CLUSTERED 
(
	[actid] ASC,
	[stepid] ASC,
	[techid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[rel_tool_data]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[rel_tool_data](
	[idrel2] [int] NULL,
	[dataid] [int] NOT NULL,
	[techid] [int] NOT NULL,
 CONSTRAINT [PK_rel_tool_data_dataid] PRIMARY KEY CLUSTERED 
(
	[dataid] ASC,
	[techid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[relations]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[relations](
	[idrelation] [int] NULL,
	[actid] [int] NOT NULL,
	[stepid] [int] NOT NULL,
	[dataid] [int] NOT NULL,
	[techid] [int] NOT NULL,
	[lamid] [int] NOT NULL,
 CONSTRAINT [PK_relations_actid] PRIMARY KEY CLUSTERED 
(
	[actid] ASC,
	[stepid] ASC,
	[dataid] ASC,
	[techid] ASC,
	[lamid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[relations3]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[relations3](
	[idrelation] [int] NULL,
	[actid] [int] NOT NULL,
	[stepid] [int] NOT NULL,
	[techid] [int] NOT NULL,
	[lamid] [int] NOT NULL,
 CONSTRAINT [PK_relations3_actid] PRIMARY KEY CLUSTERED 
(
	[actid] ASC,
	[stepid] ASC,
	[techid] ASC,
	[lamid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[skills]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[skills](
	[idskills] [int] NOT NULL,
	[skill_name] [nvarchar](45) NULL,
 CONSTRAINT [PK_skills_idskills] PRIMARY KEY CLUSTERED 
(
	[idskills] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[step_skill]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[step_skill](
	[stepskill_id] [int] IDENTITY(114,1) NOT NULL,
	[stepid] [int] NOT NULL,
	[skillid] [int] NOT NULL,
 CONSTRAINT [PK_step_skill_stepskill_id] PRIMARY KEY CLUSTERED 
(
	[stepskill_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [testultimcurs].[technology]    Script Date: 7/8/2021 10:32:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [testultimcurs].[technology](
	[idtechnology] [int] NOT NULL,
	[tech_name] [nvarchar](45) NULL,
	[tech_category] [nvarchar](45) NULL,
 CONSTRAINT [PK_technology_idtechnology] PRIMARY KEY CLUSTERED 
(
	[idtechnology] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [testultimcurs].[activity] ADD  DEFAULT (NULL) FOR [activity_name]
GO
ALTER TABLE [testultimcurs].[course_phase] ADD  DEFAULT (NULL) FOR [cphase_name]
GO
ALTER TABLE [testultimcurs].[data] ADD  DEFAULT (NULL) FOR [data_name]
GO
ALTER TABLE [testultimcurs].[la_method] ADD  DEFAULT (NULL) FOR [lamethod_name]
GO
ALTER TABLE [testultimcurs].[pbl_step] ADD  DEFAULT (NULL) FOR [step_name]
GO
ALTER TABLE [testultimcurs].[rel_latool_lam] ADD  DEFAULT (NULL) FOR [idrel4]
GO
ALTER TABLE [testultimcurs].[rel_step_act_tool] ADD  DEFAULT (NULL) FOR [idrel1]
GO
ALTER TABLE [testultimcurs].[rel_tool_data] ADD  DEFAULT (NULL) FOR [idrel2]
GO
ALTER TABLE [testultimcurs].[relations] ADD  DEFAULT (NULL) FOR [idrelation]
GO
ALTER TABLE [testultimcurs].[relations3] ADD  DEFAULT (NULL) FOR [idrelation]
GO
ALTER TABLE [testultimcurs].[skills] ADD  DEFAULT (NULL) FOR [skill_name]
GO
ALTER TABLE [testultimcurs].[technology] ADD  DEFAULT (NULL) FOR [tech_name]
GO
ALTER TABLE [testultimcurs].[technology] ADD  DEFAULT (NULL) FOR [tech_category]
GO
ALTER TABLE [testultimcurs].[rel_latool_lam]  WITH NOCHECK ADD  CONSTRAINT [rel_latool_lam$lam_id_idx_lam] FOREIGN KEY([lamid])
REFERENCES [testultimcurs].[la_method] ([idla_method])
GO
ALTER TABLE [testultimcurs].[rel_latool_lam] CHECK CONSTRAINT [rel_latool_lam$lam_id_idx_lam]
GO
ALTER TABLE [testultimcurs].[rel_latool_lam]  WITH NOCHECK ADD  CONSTRAINT [rel_latool_lam$tech_id_idx_tec] FOREIGN KEY([techid])
REFERENCES [testultimcurs].[technology] ([idtechnology])
GO
ALTER TABLE [testultimcurs].[rel_latool_lam] CHECK CONSTRAINT [rel_latool_lam$tech_id_idx_tec]
GO
ALTER TABLE [testultimcurs].[rel_step_act_tool]  WITH NOCHECK ADD  CONSTRAINT [rel_step_act_tool$act_id_idx] FOREIGN KEY([actid])
REFERENCES [testultimcurs].[activity] ([idactivity])
GO
ALTER TABLE [testultimcurs].[rel_step_act_tool] CHECK CONSTRAINT [rel_step_act_tool$act_id_idx]
GO
ALTER TABLE [testultimcurs].[rel_step_act_tool]  WITH NOCHECK ADD  CONSTRAINT [rel_step_act_tool$step_id_idx] FOREIGN KEY([stepid])
REFERENCES [testultimcurs].[pbl_step] ([idpbl_step])
GO
ALTER TABLE [testultimcurs].[rel_step_act_tool] CHECK CONSTRAINT [rel_step_act_tool$step_id_idx]
GO
ALTER TABLE [testultimcurs].[rel_step_act_tool]  WITH NOCHECK ADD  CONSTRAINT [rel_step_act_tool$tech_id_idx] FOREIGN KEY([techid])
REFERENCES [testultimcurs].[technology] ([idtechnology])
GO
ALTER TABLE [testultimcurs].[rel_step_act_tool] CHECK CONSTRAINT [rel_step_act_tool$tech_id_idx]
GO
ALTER TABLE [testultimcurs].[rel_tool_data]  WITH NOCHECK ADD  CONSTRAINT [rel_tool_data$data_id_idx5] FOREIGN KEY([dataid])
REFERENCES [testultimcurs].[data] ([iddata])
GO
ALTER TABLE [testultimcurs].[rel_tool_data] CHECK CONSTRAINT [rel_tool_data$data_id_idx5]
GO
ALTER TABLE [testultimcurs].[rel_tool_data]  WITH NOCHECK ADD  CONSTRAINT [rel_tool_data$tech_id_idx5] FOREIGN KEY([techid])
REFERENCES [testultimcurs].[technology] ([idtechnology])
GO
ALTER TABLE [testultimcurs].[rel_tool_data] CHECK CONSTRAINT [rel_tool_data$tech_id_idx5]
GO
ALTER TABLE [testultimcurs].[relations]  WITH NOCHECK ADD  CONSTRAINT [relations$act_id] FOREIGN KEY([actid])
REFERENCES [testultimcurs].[activity] ([idactivity])
GO
ALTER TABLE [testultimcurs].[relations] CHECK CONSTRAINT [relations$act_id]
GO
ALTER TABLE [testultimcurs].[relations]  WITH NOCHECK ADD  CONSTRAINT [relations$data_id] FOREIGN KEY([dataid])
REFERENCES [testultimcurs].[data] ([iddata])
GO
ALTER TABLE [testultimcurs].[relations] CHECK CONSTRAINT [relations$data_id]
GO
ALTER TABLE [testultimcurs].[relations]  WITH NOCHECK ADD  CONSTRAINT [relations$lam_id] FOREIGN KEY([lamid])
REFERENCES [testultimcurs].[la_method] ([idla_method])
GO
ALTER TABLE [testultimcurs].[relations] CHECK CONSTRAINT [relations$lam_id]
GO
ALTER TABLE [testultimcurs].[relations]  WITH NOCHECK ADD  CONSTRAINT [relations$step_id] FOREIGN KEY([stepid])
REFERENCES [testultimcurs].[pbl_step] ([idpbl_step])
GO
ALTER TABLE [testultimcurs].[relations] CHECK CONSTRAINT [relations$step_id]
GO
ALTER TABLE [testultimcurs].[relations]  WITH NOCHECK ADD  CONSTRAINT [relations$tech_id] FOREIGN KEY([techid])
REFERENCES [testultimcurs].[technology] ([idtechnology])
GO
ALTER TABLE [testultimcurs].[relations] CHECK CONSTRAINT [relations$tech_id]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.activity' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'activity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.course_phase' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'course_phase'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.data' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'data'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.la_method' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'la_method'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.pbl_step' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'pbl_step'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.rel_latool_lam' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'rel_latool_lam'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.rel_step_act_tool' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'rel_step_act_tool'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.rel_tool_data' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'rel_tool_data'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.relations' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'relations'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.relations3' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'relations3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.skills' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'skills'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.step_skill' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'step_skill'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'testultimcurs.technology' , @level0type=N'SCHEMA',@level0name=N'testultimcurs', @level1type=N'TABLE',@level1name=N'technology'
GO
