/*
Navicat SQL Server Data Transfer

Source Server         : DATASERVER
Source Server Version : 120000
Source Host           : PC34\DATASERVER:1433
Source Database       : LIBRARY_1202
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 120000
File Encoding         : 65001

Date: 2019-02-11 19:23:07
*/


-- ----------------------------
-- Table structure for TBL_BORROW
-- ----------------------------
DROP TABLE [dbo].[TBL_BORROW]
GO
CREATE TABLE [dbo].[TBL_BORROW] (
[LRN] varchar(12) NOT NULL ,
[STUDENTNAME] varchar(50) NULL ,
[TRACKSTRAND] varchar(50) NULL ,
[SECTION] varchar(50) NOT NULL ,
[BOOKID] varchar(12) NULL ,
[BOOKTITLE] varchar(12) NULL ,
[CATEGORY] varchar(50) NULL ,
[STATUS] varchar(50) NULL ,
[BORROWDATE] datetime2(7) NULL ,
[RETURNDATE] datetime2(7) NULL 
)


GO

-- ----------------------------
-- Records of TBL_BORROW
-- ----------------------------
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'', N'', N'', N'', N'', N'', N'', N'', N'2019-02-11 00:00:00.0000000', N'2019-02-14 00:00:00.0000000')
GO
GO
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'111111', N'', N'', N'', N'2221212', N'', N'', N'Available', N'2019-02-11 00:00:00.0000000', N'2019-02-20 00:00:00.0000000')
GO
GO
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'13659989898', N'', N'', N'', N'20195656565', N'', N'', N'', N'2019-02-11 00:00:00.0000000', N'2019-02-22 00:00:00.0000000')
GO
GO
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'136656565', N'', N'', N'', N'15151515151', N'', N'', N'Available', N'2019-02-11 00:00:00.0000000', N'2019-02-16 00:00:00.0000000')
GO
GO
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'136900012121', N'', N'', N'', N'201921154184', N'', N'', N'', N'2019-02-11 00:00:00.0000000', N'2019-02-14 00:00:00.0000000')
GO
GO
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'136900060020', N'', N'', N'', N'', N'201912', N'', N'', N'2019-02-11 00:00:00.0000000', N'2019-02-22 00:00:00.0000000')
GO
GO

-- ----------------------------
-- Indexes structure for table TBL_BORROW
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_BORROW
-- ----------------------------
ALTER TABLE [dbo].[TBL_BORROW] ADD PRIMARY KEY ([LRN], [SECTION])
GO
