USE TransInfo;

-- -------------------------------------------------------------------------------------
-- ------------------------------------trunk metadata information-----------------------
-- -------------------------------------------------------------------------------------

DROP TABLE IF EXISTS `trunknumberprefix`;

CREATE TABLE `trunknumberprefix`(
	`id` bigint(20) auto_increment,
	`prefixname` varchar(2) NOT NULL,
	PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO trunknumberprefix (prefixname) VALUES ('京');
INSERT INTO trunknumberprefix (prefixname) VALUES ('津');
INSERT INTO trunknumberprefix (prefixname) VALUES ('沪');
INSERT INTO trunknumberprefix (prefixname) VALUES ('渝');
INSERT INTO trunknumberprefix (prefixname) VALUES ('冀');
INSERT INTO trunknumberprefix (prefixname) VALUES ('豫');
INSERT INTO trunknumberprefix (prefixname) VALUES ('云');
INSERT INTO trunknumberprefix (prefixname) VALUES ('辽');
INSERT INTO trunknumberprefix (prefixname) VALUES ('黑');
INSERT INTO trunknumberprefix (prefixname) VALUES ('湘');
INSERT INTO trunknumberprefix (prefixname) VALUES ('皖');
INSERT INTO trunknumberprefix (prefixname) VALUES ('闽');
INSERT INTO trunknumberprefix (prefixname) VALUES ('鲁');
INSERT INTO trunknumberprefix (prefixname) VALUES ('新');
INSERT INTO trunknumberprefix (prefixname) VALUES ('苏');
INSERT INTO trunknumberprefix (prefixname) VALUES ('浙');
INSERT INTO trunknumberprefix (prefixname) VALUES ('赣');
INSERT INTO trunknumberprefix (prefixname) VALUES ('鄂');
INSERT INTO trunknumberprefix (prefixname) VALUES ('桂');
INSERT INTO trunknumberprefix (prefixname) VALUES ('甘');
INSERT INTO trunknumberprefix (prefixname) VALUES ('晋');
INSERT INTO trunknumberprefix (prefixname) VALUES ('蒙');
INSERT INTO trunknumberprefix (prefixname) VALUES ('陕');
INSERT INTO trunknumberprefix (prefixname) VALUES ('吉');
INSERT INTO trunknumberprefix (prefixname) VALUES ('贵');
INSERT INTO trunknumberprefix (prefixname) VALUES ('粤');
INSERT INTO trunknumberprefix (prefixname) VALUES ('青');
INSERT INTO trunknumberprefix (prefixname) VALUES ('藏');
INSERT INTO trunknumberprefix (prefixname) VALUES ('川');
INSERT INTO trunknumberprefix (prefixname) VALUES ('宁');
INSERT INTO trunknumberprefix (prefixname) VALUES ('琼');

--
-- trunknumber table
-- 
DROP TABLE IF EXISTS `trunknumber`;
CREATE TABLE `trunknumber`(
	`id` bigint(20) auto_increment,
	`prefixid` bigint NOT NULL,
	`number` varchar(20) NOT NULL,
	`userid` bigint NOT NULL,
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(prefixid) REFERENCES trunknumberprefix(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_trunknumber_prefix ON trunknumber(prefixid);



--
-- create table vantype
--
DROP TABLE IF EXISTS `vantype`;
CREATE TABLE `vantype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;


INSERT INTO vantype (typename ) VALUES ('货车');
INSERT INTO vantype (typename ) VALUES ('自卸车');
INSERT INTO vantype (typename ) VALUES ('冷藏车');
INSERT INTO vantype (typename ) VALUES ('保温车');
INSERT INTO vantype (typename ) VALUES ('油罐车');
INSERT INTO vantype (typename ) VALUES ('起重车');
INSERT INTO vantype (typename ) VALUES ('中型罐车');
INSERT INTO vantype (typename ) VALUES ('铁茏车');
INSERT INTO vantype (typename ) VALUES ('进口气囊避震车');
INSERT INTO vantype (typename ) VALUES ('不锈钢大槽罐车');

--
-- create table trunktype 
--
DROP TABLE IF EXISTS `trunktype`;
CREATE TABLE `trunktype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;


INSERT INTO trunktype (typename ) VALUES ('厢式');
INSERT INTO trunktype (typename ) VALUES ('敞蓬');
INSERT INTO trunktype (typename ) VALUES ('单桥');
INSERT INTO trunktype (typename ) VALUES ('三桥');
INSERT INTO trunktype (typename ) VALUES ('四桥');
INSERT INTO trunktype (typename ) VALUES ('高栏');
INSERT INTO trunktype (typename ) VALUES ('中栏');
INSERT INTO trunktype (typename ) VALUES ('低栏');
INSERT INTO trunktype (typename ) VALUES ('平板');
INSERT INTO trunktype (typename ) VALUES ('半挂');
INSERT INTO trunktype (typename ) VALUES ('全挂');
INSERT INTO trunktype (typename ) VALUES ('加长挂');
INSERT INTO trunktype (typename ) VALUES ('后八轮');
INSERT INTO trunktype (typename ) VALUES ('前四后八');
INSERT INTO trunktype (typename ) VALUES ('仓栏');    

--
-- create table trunkmetadata
--
DROP TABLE IF EXISTS `trunkmetadata`;
CREATE TABLE `trunkmetadata`(
	`id` bigint(20) auto_increment,
	`numberid` bigint NOT NULL, -- （车牌号）
	`length` varchar(10) NOT NULL, -- 车长（米）
	`weightcapacity` varchar(10) NOT NULL, -- 载重（吨）
	`volume` varchar(10) NULL, -- 容积
	`countycode` varchar(6) NOT NULL, -- 车辆驻地
	`location` varchar(200) NULL, -- 车辆常停放位置（如：XX物流园区）	
	`vantypeid` bigint NOT NULL, -- 车辆类型
	`brand` varchar(45) NULL, -- 品牌型号
	`trunktypeid` bigint NOT NULL, -- 车体类型
	`contactpersonname` varchar(45) NOT NULL, -- 随车联系人
	`conatactphone` varchar(15) NOT NULL, -- 随车电话
	`trunkidentifynumber` varchar(100) NULL, -- 车辆识别代号（？）
	`vanimageuri` varchar(200) NULL, -- 车辆图片
	`licenseuri` varchar(200) NULL, -- 行车证图片
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY (numberid) REFERENCES trunknumber(id),
	FOREIGN KEY(vantypeid) REFERENCES vantype(id),
	FOREIGN KEY(trunktypeid) REFERENCES trunktype(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_trunkmetadata_number ON trunkmetadata(numberid);
CREATE INDEX IX_trunkmetadata_length ON trunkmetadata(length);
CREATE INDEX IX_trunkmetadata_weight ON trunkmetadata(weightcapacity);
CREATE INDEX IX_trunkmetadata_countycode ON trunkmetadata(countycode);
CREATE INDEX IX_trunkmetadata_vantype ON trunkmetadata(vantypeid);
CREATE INDEX IX_trunkmetadata_trunktype ON trunkmetadata(trunktypeid);
-- --------------------------------------------------------------------------------------------
-- ------------------------------VIEW----------------------------------------------------------
-- --------------------------------------------------------------------------------------------
--
-- vehicle number view
--
DROP VIEW IF EXISTS `V_vehicle_number`;
CREATE VIEW `V_vehicle_number`
AS
SELECT trunknumber.id, trunknumber.userid, trunknumberprefix.prefixname,trunknumber.number FROM trunknumber
JOIN trunknumberprefix ON trunknumber.prefixid = trunknumberprefix.id;
--
-- trunk metadata view
--
DROP VIEW IF EXISTS `V_trunkmetadata`;
CREATE VIEW `V_trunkmetadata`
AS
SELECT trunkmetadata.id,
trunknumberprefix.prefixname,
trunknumber.number,
trunkmetadata.length,
trunkmetadata.weightcapacity,
trunkmetadata.volume,
county.name AS countyname, -- uncomplete
trunkmetadata.countycode,
location,
vantype.typename as vantypename,
brand,
trunktype.typename as trunktypename,
contactpersonname,
conatactphone,
trunkidentifynumber,
vanimageuri,
licenseuri
FROM trunkmetadata
JOIN trunknumber ON trunknumber.id = trunkmetadata.numberid
JOIN trunknumberprefix ON trunknumberprefix.id = trunknumber.prefixid
JOIN vantype ON vantype.id = trunkmetadata.vantypeid
JOIN trunktype ON trunktype.id = trunkmetadata.trunktypeid
JOIN county ON county.code = trunkmetadata.countycode;
-- WHERE trunkmetadata.active = 1;

-- --------------------------------------------------------------------------------------------
-- ------------------------------Trunk publish information---------------------------------------------
-- --------------------------------------------------------------------------------------------

--
-- route type table 
--

DROP TABLE IF EXISTS `trunkroutetype`;
CREATE TABLE `trunkroutetype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO trunkroutetype(typename) VALUES('本地车'),('返程车');

--
-- trunk time type 
--

DROP TABLE IF EXISTS `trunktimetype`;
CREATE TABLE `trunktimetype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO trunktimetype(typename) VALUES('即时车源'),('长期车源');

--
-- trunk return type
--
DROP TABLE IF EXISTS `trunkreturntype`;
CREATE TABLE `trunkreturntype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO trunkreturntype(typename) VALUES('单程'),('往返');

--
-- Trunk information 车源信息
--
DROP TABLE IF EXISTS `trunkinformation`;
CREATE TABLE `trunkinformation`(
	`id` bigint(20) auto_increment,
	`trunkid` bigint NOT NULL, -- 相关货车
	`routetypeid` bigint NOT NULL, -- 0:  本地车，1:返程车
	`srccountycode` varchar(6) NOT NULL, -- 出发地
	`dstcountycode` varchar(6) NOT NULL, -- 目的地
	`router` varchar(200) , -- 途经地名
	`takeofftime` datetime  , -- 发车时间
	`marketprice` varchar(40) DEFAULT '面议' NULL, -- 市场运价
	`negotiateprice` varchar(40) NULL, -- 协议运价
	`timetypeid` bigint NOT NULL, -- 0: 即时车源 1： 长期车源
	`description` varchar(2000) DEFAULT '求货源', -- 信息说明
	`returntypeid` bigint NOT NULL, -- 0:单程 1： 往返
	`userid` bigint NOT NULL, -- 发布信息用户
	`title` varchar (350) NOT NULL, -- 信息标题	
	`releasedate` datetime DEFAULT NOW() NOT NULL, -- 发布时间
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(userid) REFERENCES users(id),
	FOREIGN KEY(trunkid) REFERENCES trunkmetadata(id),
	FOREIGN KEY(routetypeid) REFERENCES trunkroutetype(id),
	FOREIGN KEY(timetypeid) REFERENCES trunktimetype(id),
	FOREIGN KEY(returntypeid) REFERENCES trunkreturntype(id),
	FOREIGN KEY(srccountycode) REFERENCES county(code),
	FOREIGN KEY(dstcountycode) REFERENCES county(code)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;


CREATE INDEX IX_trunkinfo_userid ON trunkinformation (userid);
CREATE INDEX IX_trunkinfo_title ON trunkinformation (title);
CREATE INDEX IX_trunkinfo_routetype ON trunkinformation (routetypeid);
CREATE INDEX IX_trunkinfo_src ON trunkinformation (srccountycode);
CREATE INDEX IX_trunkinfo_dst ON trunkinformation (dstcountycode);
CREATE INDEX IX_trunkinfo_timetype ON trunkinformation (timetypeid);
CREATE INDEX IX_trunkinfo_returntype ON trunkinformation (returntypeid);

GO

--
-- trunk information view
--
DROP VIEW IF EXISTS `V_Trunkinformation`;
CREATE VIEW `V_Trunkinformation`
AS
SELECT 
users.username,
trunkinformation.id,
V_provincecitycounty.fullname AS srcregionname,
dstregion.fullname AS dstregionname,
V_provincecitycounty.cityname AS srccityname,
V_provincecitycounty.citycode AS srccitycode,
dstregion.cityname AS dstcityname,
dstregion.citycode AS dstcitycode,
V_trunkmetadata.prefixname,
V_trunkmetadata.number,
V_trunkmetadata.length,
V_trunkmetadata.weightcapacity,
V_trunkmetadata.volume,
V_trunkmetadata.countyname AS trunkcountyname, -- uncomplete
V_trunkmetadata.location,
V_trunkmetadata.vantypename,
V_trunkmetadata.brand,
V_trunkmetadata.trunktypename,
V_trunkmetadata.contactpersonname,
V_trunkmetadata.conatactphone,
V_trunkmetadata.trunkidentifynumber,
V_trunkmetadata.vanimageuri,
V_trunkmetadata.licenseuri,
trunkroutetype.typename AS routetype
FROM V_provincecitycounty
JOIN trunkinformation ON trunkinformation.srccountycode = V_provincecitycounty.countycode OR trunkinformation.srccountycode = V_provincecitycounty.citycode OR trunkinformation.srccountycode = V_provincecitycounty.provincecode
JOIN V_provincecitycounty AS dstregion ON trunkinformation.dstcountycode = dstregion.countycode OR trunkinformation.dstcountycode = dstregion.citycode OR trunkinformation.dstcountycode = dstregion.provincecode
JOIN V_trunkmetadata ON V_trunkmetadata.id = trunkinformation.trunkid
JOIN trunkroutetype ON trunkroutetype.id = trunkinformation.routetypeid
JOIN users ON users.id = trunkinformation.userid;



-- ----------------------------------------------------------------------------------
-- ---------------------------货源信息-----------------------------------------------
-- ----------------------------------------------------------------------------------
--
-- Goods type
--
DROP TABLE IF EXISTS `goodstype`;
CREATE TABLE `goodstype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(8) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO goodstype(typename) VALUES ('设备');
INSERT INTO goodstype(typename) VALUES ('煤炭');
INSERT INTO goodstype(typename) VALUES ('矿产'),
('钢材'),
('饲料'),
('建材'),
('木材'),
('粮食'),
('食品'),
('饮料'),
('蔬菜'),
('电器'),
('化工产品'),
('畜产品');

--
-- 运输类型
--
DROP TABLE IF EXISTS `transporttype`;
CREATE TABLE `transporttype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(8) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO transporttype(typename) VALUES('不限'),
('物流公司'),
('整车配货'),
('零担配货');

--
-- 注意事项
--
DROP TABLE IF EXISTS `cautiontype`;
CREATE TABLE `cautiontype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(8) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
INSERT INTO cautiontype (typename) VALUES('向上'),('防潮'),('易碎'),('危险品'),('无');

--
-- 货源信息
--
DROP TABLE IF EXISTS `goodssourceinformation`;
CREATE TABLE `goodssourceinformation`(
	`id` bigint(20) auto_increment,
	`userid` bigint NOT NULL,
	`srccountycode` varchar(6) NOT NULL, -- 启运地
	`dstcountycode` varchar(6) NOT NULL, -- 目的地
	`deadline` datetime NULL, -- 默认十天
	`title` varchar(350) NOT NULL,
	`titlecolor` varchar(10),
	`goodsname` varchar(50) NOT NULL,
	`transporttypeid` bigint NOT NULL,
	`cautiontypeid` bigint NOT NULL,
	`goodstypeid` bigint NOT NULL,
	`price` varchar(40) NOT NULL, 
	`needtrunklength` bigint,
	`needtrunkweight` bigint,
	`needtrunkvolume` bigint,
	`content` text,
	`releasedate` datetime DEFAULT NOW() NOT NULL,
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(srccountycode) REFERENCES county(code),
	FOREIGN KEY(dstcountycode) REFERENCES county(code),
	FOREIGN KEY(goodstypeid) REFERENCES goodstype(id),
	FOREIGN KEY(transporttypeid) REFERENCES transporttype(id),
	FOREIGN KEY(cautiontypeid) REFERENCES cautiontype(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_goodssrcinfo_userid ON goodssourceinformation (userid);
CREATE INDEX IX_goodssrcinfo_title ON goodssourceinformation(title);
CREATE INDEX IX_goodssrcinfo_goodsname ON goodssourceinformation(goodsname);
CREATE INDEX IX_goodssrcinfo_goodstype ON goodssourceinformation(goodstypeid);
CREATE INDEX IX_goodssrcinfo_cautiontype ON goodssourceinformation(cautiontypeid);
CREATE INDEX IX_goodssrcinfo_transporttype ON goodssourceinformation(transporttypeid);
CREATE INDEX IX_goodssrcinfo_deadline ON goodssourceinformation(deadline);
CREATE INDEX IX_goodssrcinfo_price ON goodssourceinformation(price);
CREATE INDEX IX_goodssrcinfo_releasedate ON goodssourceinformation(releasedate);
CREATE INDEX IX_goodssrcinfo_needtrunklength ON goodssourceinformation(needtrunklength);
CREATE INDEX IX_goodssrcinfo_needtrunkweight ON goodssourceinformation(needtrunkweight);
CREATE INDEX IX_goodssrcinfo_needtrunkvolume ON goodssourceinformation(needtrunkvolume);
 
 
 --
 -- Goods source information view
 --
 
 DROP VIEW IF EXISTS `V_Goodssourceinformation`;
 CREATE VIEW `V_Goodssourceinformation`
 AS
 SELECT
 goodssourceinformation.id,
 users.username,
 V_provincecitycounty.fullname AS srcregionname,
 dstregion.fullname AS dstregionname,
 V_provincecitycounty.cityname AS srccityname,
 V_provincecitycounty.citycode AS srccitycode,
 dstregion.cityname AS dstcityname,
 dstregion.citycode AS dstcitycode,
 goodssourceinformation.deadline,
 goodssourceinformation.title,
 goodssourceinformation.titlecolor,
 goodssourceinformation.goodsname,
 transporttype.typename AS transporttypename,
 cautiontype.typename AS cautiontypename,
 goodstype.typename AS goodstypename,
 goodssourceinformation.price,
 goodssourceinformation.needtrunklength,
 goodssourceinformation.needtrunkweight,
 goodssourceinformation.needtrunkvolume,
 goodssourceinformation.content,
 goodssourceinformation.releasedate
 FROM V_provincecitycounty
 JOIN goodssourceinformation ON goodssourceinformation.srccountycode = V_provincecitycounty.countycode OR goodssourceinformation.srccountycode = V_provincecitycounty.citycode OR goodssourceinformation.srccountycode = V_provincecitycounty.provincecode
 JOIN V_provincecitycounty AS dstregion ON goodssourceinformation.dstcountycode = dstregion.countycode OR goodssourceinformation.dstcountycode = dstregion.citycode OR goodssourceinformation.dstcountycode = dstregion.provincecode
 JOIN users ON users.id = goodssourceinformation.userid
 JOIN transporttype ON transporttype.id = goodssourceinformation.transporttypeid
 JOIN cautiontype ON cautiontype.id = goodssourceinformation.cautiontypeid
 JOIN goodstype ON goodstype.id = goodssourceinformation.goodstypeid;
 
 
-- ----------------------------------------------------------------------------------
-- ---------------------------专线信息-----------------------------------------------
-- ----------------------------------------------------------------------------------
--
-- table line type
--

DROP TABLE IF EXISTS `speciallinetype`;
CREATE TABLE `speciallinetype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20),
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO speciallinetype (typename) VALUES ('单程'),('往返');

--
-- table departuretype
--
DROP TABLE IF EXISTS `departuretype`;
CREATE TABLE `departuretype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20),
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO departuretype(typename) VALUES('不固定'),
('每隔1天一班'),
('每隔2天一班'),
('每隔3天一班'),
('每隔4天一班'),
('每隔5天一班');

--
-- 地点信息
--

DROP TABLE IF EXISTS `placeinfo`;
CREATE TABLE `placeinfo`(
	`id` bigint(20) auto_increment,
	`address` varchar(500),
	`contactpersonname` varchar(30) NOT NULL,
	`contactcellphone` varchar(20),
	`contactphone` varchar(20),
	`countycode` varchar(10),
	PRIMARY KEY(id),
	FOREIGN KEY(`countycode`) REFERENCES county(code)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_placeinfo_county ON placeinfo(countycode);

--
--  专线信息
--

DROP TABLE IF EXISTS `speciallineinfo`;
CREATE TABLE `speciallineinfo`(
	`id` bigint(20) auto_increment,
	`userid` bigint NOT NULL,
	`title` varchar(200) NOT NULL,
	`sourceplaceinfoid` bigint NOT NULL,
	`destinationplaceinfoid` bigint NOT NULL,
	`weightprice` int, -- 重货价格
	`volumeprice` int, -- 泡货价格
	`departuretypeid` bigint,
	`speciallinetypeid` bigint,
	`description` text, -- 专线说明
	`releasedate` datetime DEFAULT NOW() NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY (`userid`) REFERENCES users(id),
	FOREIGN KEY (`sourceplaceinfoid`) REFERENCES placeinfo(id),
	FOREIGN KEY(`destinationplaceinfoid`) REFERENCES placeinfo(id),
	FOREIGN KEY(`departuretypeid`) REFERENCES departuretype(id),
	FOREIGN KEY(`speciallinetypeid`) REFERENCES speciallinetype(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_speciallineinfo_user ON speciallineinfo(userid);
CREATE INDEX IX_speciallineinfo_title ON speciallineinfo(title);
CREATE INDEX IX_speciallineinfo_srcplace ON speciallineinfo(sourceplaceinfoid);
CREATE INDEx IX_speciallineinfo_dstplace ON speciallineinfo(destinationplaceinfoid);
CREATE INDEX IX_speciallineinfo_departuretype ON speciallineinfo(departuretypeid);
CREATE INDEX IX_speciallineinfo_linetype ON speciallineinfo(speciallinetypeid);


-- --------------------------------------------------------------------------------------------
-- ------------------------------VIEW----------------------------------------------------------
-- --------------------------------------------------------------------------------------------

DROP VIEW IF EXISTS `V_speciallineinfo`;
CREATE VIEW `V_speciallineinfo`
AS
SELECT 
speciallineinfo.id,
speciallineinfo.userid,
users.username,
speciallineinfo.title,
placeinfo.address AS srcplaceaddress,
placeinfo.contactpersonname AS srccontactpersonname,
placeinfo.contactcellphone AS srccontactcellphone,
placeinfo.contactphone AS srccontactphone,
srccounty.fullname AS srcregionname,
srccounty.cityname AS srccityname,
srccounty.citycode AS srccitycode,
dstplaceinfo.address AS dstplaceaddress,
dstplaceinfo.contactpersonname AS dstcontactpersonname,
dstplaceinfo.contactcellphone AS dstcontactcellphone,
dstplaceinfo.contactphone AS dstcontactphone,
dstcounty.fullname AS dstregionname,
dstcounty.cityname AS dstcityname,
dstcounty.citycode AS dstcitycode,
weightprice,
volumeprice,
departuretype.typename AS departuretypename, 
speciallinetype.typename AS speciallinetypename,
description,
speciallineinfo.releasedate
FROM placeinfo
JOIN speciallineinfo ON speciallineinfo.sourceplaceinfoid = placeinfo.id
JOIN users ON speciallineinfo.userid = users.id
JOIN placeinfo AS dstplaceinfo ON dstplaceinfo.id = speciallineinfo.destinationplaceinfoid
JOIN departuretype ON departuretype.id = speciallineinfo.departuretypeid
JOIN speciallinetype ON speciallineinfo.speciallinetypeid = speciallinetype.id
JOIN V_provincecitycounty AS srccounty ON srccounty.countycode  = placeinfo.countycode
JOIN V_provincecitycounty AS dstcounty ON dstcounty.countycode = dstplaceinfo.countycode;


-- --------------------------------------------------------------------------------------------
-- ------------------------------User Store Procedure------------------------------------------
-- --------------------------------------------------------------------------------------------

--
-- Special line PROCEDURE
--
DROP PROCEDURE IF EXISTS `uspInsertSpecialineData`;
DELIMITER //
CREATE PROCEDURE uspInsertSpecialineData(IN xmlData text)
COMMENT
'
  <speciallinedata>
	<userid></userid>
	<title></title>
	<srcaddress></srcaddress>
	<srccontactperson></srccontactperson>
	<srccontactcellphone></srccontactcellphone>
	<srccontactphone></srccontactphone>
	<srccountycode></srccountycode>
	<dstaddress></dstaddress>
	<dstcontactperson></dstcontactperson>
	<dstcontactcellphone></dstcontactcellphone>
	<dstcontactphone></dstcontactphone>
	<dstcountycode></dstcountycode>
	<weightprice></weightprice>
	<volumeprice></volumeprice>
	<departuretypeid></departuretypeid>
	<speciallinetypeid></speciallinetypeid>
	<description></description>
 </speciallinedata>
'
BEGIN

SELECT @userid  := EXTRACTVALUE(xmlData,'/speciallinedata/userid');
SELECT @title := EXTRACTVALUE(xmlData,'/speciallinedata/title');
SELECT @srcaddress := EXTRACTVALUE(xmlData,'/speciallinedata/srcaddress');
SELECT @srccontactperson := EXTRACTVALUE(xmlData,'/speciallinedata/srccontactperson');
SELECT @srccontactcellphone := EXTRACTVALUE(xmlData,'/speciallinedata/srccontactcellphone');
SELECT @srccontactphone := EXTRACTVALUE(xmlData,'/speciallinedata/srccontactphone');
SELECT @srccountycode := EXTRACTVALUE(xmlData,'/speciallinedata/srccountycode');
SELECT @dstaddress := EXTRACTVALUE(xmlData,'/speciallinedata/dstaddress');
SELECT @dstcontactperson := EXTRACTVALUE(xmlData,'/speciallinedata/dstcontactperson');
SELECT @dstcontactcellphone := EXTRACTVALUE(xmlData,'/speciallinedata/dstcontactcellphone');
SELECT @dstcontactphone := EXTRACTVALUE(xmlData,'/speciallinedata/dstcontactphone');
SELECT @dstcountycode := EXTRACTVALUE(xmlData,'/speciallinedata/dstcountycode');
SELECT @weightprice := EXTRACTVALUE(xmlData,'/speciallinedata/weightprice');
SELECT @volumeprice := EXTRACTVALUE(xmlData,'/speciallinedata/volumeprice');
SELECT @departuretypeid := EXTRACTVALUE(xmlData,'/speciallinedata/departuretypeid');
SELECT @speciallinetypeid := EXTRACTVALUE(xmlData,'/speciallinedata/speciallinetypeid');
SELECT @description  := EXTRACTVALUE(xmlData,'/speciallinedata/description');

INSERT INTO placeinfo(address,contactpersonname,contactcellphone,contactphone,countycode)
VALUES (@srcaddress,@srccontactperson,@srccontactcellphone,@srccontactphone,@srccountycode);
SELECT @src_place_id := LAST_INSERT_ID();

INSERT INTO placeinfo(address,contactpersonname,contactcellphone,contactphone,countycode)
VALUES (@dstaddress,@dstcontactperson,@dstcontactcellphone,@dstcontactphone,@dstcountycode);
SELECT @dst_place_id := LAST_INSERT_ID();

INSERT INTO speciallineinfo(userid,title,sourceplaceinfoid,destinationplaceinfoid,weightprice,volumeprice,departuretypeid,speciallinetypeid,description)
VALUES(@userid,@title,@src_place_id,@dst_place_id,@weightprice,@volumeprice,@departuretypeid,@speciallinetypeid,@description);

END//
DELIMITER ;

--
-- Store procedure for trun metadata
--
DROP PROCEDURE IF EXISTS `uspInsertTrunkMetadata`;
DELIMITER //
CREATE PROCEDURE `uspInsertTrunkMetadata` (IN xmlData text)
COMMENT
'
<trunkmetadata>
	<userid></userid>
	<numberprefixid></numberprefixid>
	<trunknumber></trunknumber>
	<length></length>
	<weightcapacity></weightcapacity>
	<volume></volume>
	<countycode></countycode>
	<location></location>
	<vantypeid></vantypeid>
	<brand></brand>
	<trunktypeid></trunktypeid>
	<contactpersonname></contactpersonname>
	<contactphone></contactphone>
	<trunkidentifynumber></trunkidentifynumber>
	<vanimageuri></vanimageuri>
	<licenseuri></licenseuri>
</trunkmetadata>
'
BEGIN
	SELECT @userId := EXTRACTVALUE(xmlData,'/trunkmetadata/userid');
	SELECT @numberprefixid := EXTRACTVALUE(xmlData,'/trunkmetadata/numberprefixid');
	SELECT @trunknumber := EXTRACTVALUE(xmlData,'/trunkmetadata/trunknumber');
	SELECT @length  := EXTRACTVALUE(xmlData,'/trunkmetadata/length');
	SELECT @weightcapacity := EXTRACTVALUE(xmlData,'/trunkmetadata/weightcapacity');
	SELECT @volume := EXTRACTVALUE(xmlData,'/trunkmetadata/volume');
	SELECT @countycode := EXTRACTVALUE(xmlData,'/trunkmetadata/countycode');
	SELECT @location := EXTRACTVALUE(xmlData,'/trunkmetadata/location');
	SELECT @vantypeid := EXTRACTVALUE(xmlData,'/trunkmetadata/vantypeid');
	SELECT @brand := EXTRACTVALUE(xmlData,'/trunkmetadata/brand');
	SELECT @trunktypeid := EXTRACTVALUE(xmlData,'/trunkmetadata/trunktypeid');
	SELECT @contactpersonname := EXTRACTVALUE(xmlData,'/trunkmetadata/contactpersonname');
	SELECT @contactphone := EXTRACTVALUE(xmlData,'/trunkmetadata/contactphone');
	SELECT @trunkidentifynumber := EXTRACTVALUE(xmlData,'/trunkmetadata/trunkidentifynumber');
	SELECT @vanimageuri := EXTRACTVALUE(xmlData,'/trunkmetadata/vanimageuri');
	SELECT @licenseuri := EXTRACTVALUE(xmlData,'/trunkmetadata/licenseuri');
	
	INSERT INTO trunknumber (prefixid,number,userid,active) VALUES (@numberprefixid,@trunknumber,@userId,0);
	SELECT @trunk_number_id := LAST_INSERT_ID();
	
	INSERt INTO trunkmetadata(numberid,length,weightcapacity,volume,countycode,location,vantypeid,brand,trunktypeid,contactpersonname,
	conatactphone,trunkidentifynumber,vanimageuri,licenseuri,active)
	VALUES (@trunk_number_id,@length,@weightcapacity,@volume,@countycode,@location,@vantypeid,@brand,@trunktypeid,@contactpersonname,
	@contactphone,@trunkidentifynumber,@vanimageuri,@licenseuri,0);
END //