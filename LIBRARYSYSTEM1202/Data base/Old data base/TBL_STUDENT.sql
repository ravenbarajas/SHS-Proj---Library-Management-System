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

Date: 2019-02-11 19:23:18
*/


-- ----------------------------
-- Table structure for TBL_STUDENT
-- ----------------------------
DROP TABLE [dbo].[TBL_STUDENT]
GO
CREATE TABLE [dbo].[TBL_STUDENT] (
[LRN] varchar(12) NOT NULL ,
[NAME] varchar(50) NULL ,
[ADDRESS] varchar(100) NULL ,
[CONTACTN] varchar(11) NULL ,
[DEPT] varchar(30) NULL ,
[TRACKSTRAND] varchar(20) NULL ,
[SECTION] varchar(10) NULL ,
[PARENTNAME] varchar(51) NULL ,
[PARENTCONTACT] varchar(11) NULL 
)


GO

-- ----------------------------
-- Records of TBL_STUDENT
-- ----------------------------
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [DEPT], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'132465555', N'rAVEN', N'mUNTI', N'12346', N'SDSD', N'SDSD', N'DSD', N'SDSDS', N'SDS')
GO
GO

-- ----------------------------
-- Indexes structure for table TBL_STUDENT
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_STUDENT
-- ----------------------------
ALTER TABLE [dbo].[TBL_STUDENT] ADD PRIMARY KEY ([LRN])
GO
