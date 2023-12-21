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

Date: 2019-02-11 19:22:53
*/


-- ----------------------------
-- Table structure for TBL_ACCOUNT
-- ----------------------------
DROP TABLE [dbo].[TBL_ACCOUNT]
GO
CREATE TABLE [dbo].[TBL_ACCOUNT] (
[USERNAME] varchar(250) NOT NULL ,
[PASSWORD] varchar(250) NOT NULL 
)


GO

-- ----------------------------
-- Records of TBL_ACCOUNT
-- ----------------------------
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'', N'')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'Raven1221212', N'1212121')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'Nygaw', N'1234455555')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'Rhyan_pogi_69', N'12345')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'Raven', N'123456')
GO
GO

-- ----------------------------
-- Indexes structure for table TBL_ACCOUNT
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_ACCOUNT
-- ----------------------------
ALTER TABLE [dbo].[TBL_ACCOUNT] ADD PRIMARY KEY ([PASSWORD], [USERNAME])
GO
