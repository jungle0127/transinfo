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
	`vanimageuri` varchar(200) NOT NULL, -- 车辆图片
	`licenseuri` varchar(200) NOT NULL, -- 行车证图片
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
SELECT trunknumber.id,trunknumberprefix.prefixname,trunknumber.number FROM trunknumber
JOIN trunknumberprefix ON trunknumber.prefixid = trunknumberprefix.id
WHERE trunknumber.active = 1;
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
county.name, -- uncomplete
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
JOIN county ON county.code = trunkmetadata.countycode
WHERE trunkmetadata.active = 1;

-- --------------------------------------------------------------------------------------------
-- ------------------------------Trunk publish information---------------------------------------------
-- --------------------------------------------------------------------------------------------


--
-- Trunk information 车源信息
--
DROP TABLE IF EXISTS `trunkinformation`;
CREATE TABLE `trunkinformation`(
	`id` bigint(20) auto_increment,
	`trunkid` bigint NOT NULL, -- 相关货车
	`routetype` tinyint NOT NULL, -- 0:  本地车，1:返程车
	`srccountycode` varchar(6) NOT NULL, -- 出发地
	`dstcountycode` varchar(6) NOT NULL, -- 目的地
	`router` varchar(200) , -- 途经地名
	`takeofftime` datetime  , -- 发车时间
	`marketprice` varchar(40) DEFAULT '面议' NULL, -- 市场运价
	`negotiateprice` varchar(40) NULL, -- 协议运价
	`timetype` tinyint NOT NULL, -- 0: 即时车源 1： 长期车源
	`description` varchar(2000) DEFAULT '求货源', -- 信息说明
	`returntype` tinyint NOT NULL, -- 0:单程 1： 往返
	`userid` bigint NOT NULL, -- 发布信息用户
	`title` varchar (350) NOT NULL, -- 信息标题	
	`releasedate` datetime DEFAULT NOW() NOT NULL, -- 发布时间
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(userid) REFERENCES users(id),
	FOREIGN KEY(trunkid) REFERENCES trunkmetadata(id),
	FOREIGN KEY(srccountycode) REFERENCES county(code),
	FOREIGN KEY(dstcountycode) REFERENCES county(code)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;


CREATE INDEX IX_trunkinfo_userid ON trunkinformation (userid);
CREATE INDEX IX_trunkinfo_title ON trunkinformation (title);
CREATE INDEX IX_trunkinfo_routetype ON trunkinformation (routetype);
CREATE INDEX IX_trunkinfo_src ON trunkinformation (srccountycode);
CREATE INDEX IX_trunkinfo_dst ON trunkinformation (dstcountycode);
CREATE INDEX IX_trunkinfo_timetype ON trunkinformation (timetype);
CREATE INDEX IX_trunkinfo_returntype ON trunkinformation (returntype);

GO

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
 