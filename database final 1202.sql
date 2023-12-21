/*
Navicat SQL Server Data Transfer

Source Server         : DATASERVER
Source Server Version : 120000
Source Host           : PC34\DATASERVER:1433
Source Database       : 3423423423432
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 120000
File Encoding         : 65001

Date: 2019-03-05 11:08:49
*/


-- ----------------------------
-- Table structure for TBL_ACCOUNT
-- ----------------------------
DROP TABLE [dbo].[TBL_ACCOUNT]
GO
CREATE TABLE [dbo].[TBL_ACCOUNT] (
[USERNAME] varchar(250) NOT NULL ,
[PASSWORD] varchar(250) NOT NULL ,
[LASTNAME] varchar(50) NULL ,
[FIRSTNAME] varchar(50) NULL 
)


GO

-- ----------------------------
-- Records of TBL_ACCOUNT
-- ----------------------------
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD], [LASTNAME], [FIRSTNAME]) VALUES (N'admin', N'MQ==', null, null)
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD], [LASTNAME], [FIRSTNAME]) VALUES (N'e', N'MQ==', null, null)
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD], [LASTNAME], [FIRSTNAME]) VALUES (N'Admin666', N'MTIzNDU2', N'Dilla', N'Rhyan')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD], [LASTNAME], [FIRSTNAME]) VALUES (N'JOSHUA', N'QWE', null, null)
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD], [LASTNAME], [FIRSTNAME]) VALUES (N'Joey', N'SnVuZ2NvY2s=', null, null)
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD], [LASTNAME], [FIRSTNAME]) VALUES (N'admin123', N'YWRtaW4=', null, null)
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD], [LASTNAME], [FIRSTNAME]) VALUES (N'raven', N'ZQ==', N'Barajas', N'Raven')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD], [LASTNAME], [FIRSTNAME]) VALUES (N'eee', N'ZWVl', N'e', N'e')
GO
GO

-- ----------------------------
-- Table structure for TBL_BCODE
-- ----------------------------
DROP TABLE [dbo].[TBL_BCODE]
GO
CREATE TABLE [dbo].[TBL_BCODE] (
[pcode] varchar(20) NULL ,
[prefix] varchar(20) NULL 
)


GO

-- ----------------------------
-- Records of TBL_BCODE
-- ----------------------------
INSERT INTO [dbo].[TBL_BCODE] ([pcode], [prefix]) VALUES (N'0000010', N'TRANS')
GO
GO

-- ----------------------------
-- Table structure for TBL_BOOKS
-- ----------------------------
DROP TABLE [dbo].[TBL_BOOKS]
GO
CREATE TABLE [dbo].[TBL_BOOKS] (
[BOOKID] varchar(100) NOT NULL ,
[CATEGO] varchar(50) NULL ,
[TITLE] varchar(100) NULL ,
[AUTHOR] varchar(50) NULL ,
[YEARPUB] varchar(20) NULL ,
[DESCRIPTION] varchar(300) NULL ,
[PRICE] varchar(10) NULL ,
[STATUS] varchar(50) NULL 
)


GO

-- ----------------------------
-- Records of TBL_BOOKS
-- ----------------------------
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-001-154', N'000-Computer Science, Information & General works', N'The art of computer programming', N'Donald knunth', N'1968', N'the art of computer programming is a comprehensive monograph written by donald knunth that covers many kinds of programming algorithms and their analysis.', N'499', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-002-546', N'000-Computer Science, Information & General works', N'The C programming language', N'Brian kernighan, dennis ritchie', N'1978', N'the c programming language is a computer programming book written by brian kernighan and dennis ritchie, the latter of whom orginally designed and i mplemented the language.', N'399', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-003-214', N'000-Computer Science, Information & General works', N'Clean code', N'Robert cecil martin', N'2008', N'even bad code can function. But if code isn''t clean it can bring development organization to its knees.', N'699', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-005-000', N'000-Computer Science, Information & General works', N'Intro to algorithms', N'Thomas h. cormer', N'1989', N'Introduction to algorithms.', N'999', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-101-654', N'100-Philosophy & Psychology', N'Medaitors', N'Marcus aurelius', N'2016', N'Mediators is a series of personal writings by Marcus aurelius, roman emperor from 161 to 180 AD recording his private notes to himself and ideas on stoic philosophy.', N'599', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-201-542', N'200-Religion', N'Mere Christianity', N'C.S Lewis', N'1944', N'Merry christianity is a theological book by c.s lewis adapted from a series of bbc radio talks made between 1941 and 1944.', N'999', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-301-651', N'300-Social Sciences', N'The tippings point', N'Malcolm  gladwell', N'2000', N'The tipping point: How little things kcan make a big diffrence is the debut book by Malcolm Gladwell, first published by little, brown in 2000. Gladwell defines a tipping point as "the moment of critical mass, the threshold, the bioling point".', N'399', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-401-357', N'400-Language', N'A brief history of time', N'Stephen hawking', N'1988', N'A brief history of the time: from the big bang to the black holes is a popular science on cosmology by british physicist stephen hawking it was first published in 1988.
', N'399', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-501-523', N'500-Science', N'Ghost soldiers: the forgotten epic story of world war II''s most dramatic mission', N'Hampton sides', N'2001', N'Ghost soldier is greatest rescue mission is a non-fiction book written by hampton sides it is about the world war II allied prison camp raid at cabanatuan philippines.', N'699', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-601-155', N'600-Technology', N'Steve jobs', N'Walter isaacson', N'2011', N'From the author of bestselling biographies of benjamin franklin and albert einstien, this is the exclusice new york times bestselling biography of the apple co founder steve jobs.', N'799', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-701-564', N'700-Arts & Recreation', N'The new drawing on the right side of the brain', N'Betty edwards', N'1989', N'When drawing on the right side of the brain was first publishes in 1979, it hit the new york times bestseller list within two weeks and stayed there for more tan years in 1989.', N'899', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-710-545', N'700-Arts & Recreation', N'the age of insight: the quest to understand the unconcious in art ,mind and brain', N'Erick r, Kandel', N'2012', N'the age of insight takes us to viena 1900, where leaders in science,medicine and art began a revolution that change forever how we think about the humans mind oir concious.', N'289', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-801-632', N'800-Literature', N'Nineteen eighty-four ', N'George orwell', N'1949', N'Nineteen eighty-four, often published as 1984, is a dystonian novel by english writer george Orwell published in june 1949. The novel is set in the year 1984 when most of the world population have become victims of perpetual war, omnipersent government surveillance and propaganda.', N'999', N'*Newly Added')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION], [PRICE], [STATUS]) VALUES (N'2019-905-545', N'900-History & Geography', N'A little History of the world', N'Ernst Gombrich', N'1935', N'This is a history book.', N'599', N'*Newly Added')
GO
GO

-- ----------------------------
-- Table structure for TBL_BORROW
-- ----------------------------
DROP TABLE [dbo].[TBL_BORROW]
GO
CREATE TABLE [dbo].[TBL_BORROW] (
[TRANS] varchar(12) NULL ,
[LRN] varchar(12) NULL ,
[STUDENTNAME] varchar(50) NULL ,
[TRACKSTRAND] varchar(50) NULL ,
[SECTION] varchar(12) NULL ,
[BOOKID] varchar(12) NULL ,
[BOOKTITLE] varchar(50) NULL ,
[STATUS] varchar(50) NULL ,
[BORROWDATE] datetime2(7) NULL ,
[RETURNDATE] datetime2(7) NULL ,
[DUE] varchar(20) NULL ,
[FINE] varchar(20) NULL 
)


GO

-- ----------------------------
-- Records of TBL_BORROW
-- ----------------------------

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
[TRACKSTRAND] varchar(20) NULL ,
[SECTION] varchar(10) NULL ,
[PARENTNAME] varchar(50) NULL ,
[PARENTCONTACT] varchar(11) NULL 
)


GO

-- ----------------------------
-- Records of TBL_STUDENT
-- ----------------------------
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'120321943216', N'Hannah Paquilit', N'Putatan Muntinlupa City', N'09521654984', N'ICT', N'1202', N'Evelyn Paquilit', N'09365165149')
GO
GO
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'127070060051', N'Julie Santos', N'Poblacion Muntinlupa City', N'09275667973', N'GAS', N'1102', N'Marie Santos', N'09275667862')
GO
GO
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'127070060052', N'Joan Ebañiz', N'Cupang Muntinlupa City', N'09275667556', N'SPORTS TRACK', N'1202', N'willeam Ebañez', N'09264675756')
GO
GO
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'127070060053', N'Jessica Salvador', N'san pedro laguna', N'09246568468', N'HE', N'1201', N'Mario Salvador', N'09561468468')
GO
GO
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'127070060054', N'Mar ky Lambino', N'tunasan muntinlupa city', N'09246846984', N'ABM', N'1103', N'Evelyn Lambino', N'09268469846')
GO
GO
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'134984654984', N'Jake Tarrayo', N'9th 3rd Street Freewill Putatan Muntinlupa City', N'09561465160', N'HE', N'1202', N'Prince albvert Tarrayo', N'09565161654')
GO
GO
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'136903121396', N'Mark Louise D. Magbitang', N'43 Katihan Street kappi Ville Poblacion Muntinlupa City', N'09213123149', N'ICT', N'1202', N' Eduardo D. Magbitang', N'09654362148')
GO
GO
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'136903121763', N'Joshua Leonardo', N'Country homes, Muntinlupa City', N'09546512354', N'ICT', N'1202', N'Jose Leonardo', N'09565656565')
GO
GO
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'136904060132', N'Rhyan T. Dilla ', N'P4 Bayanan Muntinlupa City', N'09856230311', N'ICT', N'1202', N'Jaime T. Dilla', N'09232015233')
GO
GO
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'136909048481', N'Rozz Añasco', N'Greenheights, Putatan Muntinlupa CIty', N'09465189456', N'ICT', N'1202', N'Roger Añasco', N'09465184685')
GO
GO
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'136945862313', N'Joey Esteva', N'BLK8 Summit Ville Village Muntinlupa city', N'09546513216', N'GAS', N'1211', N'Dante Esteva', N'09656549816')
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

-- ----------------------------
-- Indexes structure for table TBL_BOOKS
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_BOOKS
-- ----------------------------
ALTER TABLE [dbo].[TBL_BOOKS] ADD PRIMARY KEY ([BOOKID])
GO

-- ----------------------------
-- Indexes structure for table TBL_STUDENT
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_STUDENT
-- ----------------------------
ALTER TABLE [dbo].[TBL_STUDENT] ADD PRIMARY KEY ([LRN])
GO
