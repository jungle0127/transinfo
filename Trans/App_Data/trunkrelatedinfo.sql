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

INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('ԥ');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('³');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');

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


INSERT INTO vantype (typename ) VALUES ('����');
INSERT INTO vantype (typename ) VALUES ('��ж��');
INSERT INTO vantype (typename ) VALUES ('��س�');
INSERT INTO vantype (typename ) VALUES ('���³�');
INSERT INTO vantype (typename ) VALUES ('�͹޳�');
INSERT INTO vantype (typename ) VALUES ('���س�');
INSERT INTO vantype (typename ) VALUES ('���͹޳�');
INSERT INTO vantype (typename ) VALUES ('���׳�');
INSERT INTO vantype (typename ) VALUES ('�������ұ���');
INSERT INTO vantype (typename ) VALUES ('����ִ�۹޳�');

--
-- create table trunktype 
--
DROP TABLE IF EXISTS `trunktype`;
CREATE TABLE `trunktype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;


INSERT INTO trunktype (typename ) VALUES ('��ʽ');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('ƽ��');
INSERT INTO trunktype (typename ) VALUES ('���');
INSERT INTO trunktype (typename ) VALUES ('ȫ��');
INSERT INTO trunktype (typename ) VALUES ('�ӳ���');
INSERT INTO trunktype (typename ) VALUES ('�����');
INSERT INTO trunktype (typename ) VALUES ('ǰ�ĺ��');
INSERT INTO trunktype (typename ) VALUES ('����');    

--
-- create table trunkmetadata
--
DROP TABLE IF EXISTS `trunkmetadata`;
CREATE TABLE `trunkmetadata`(
	`id` bigint(20) auto_increment,
	`numberid` bigint NOT NULL, -- �����ƺţ�
	`length` varchar(10) NOT NULL, -- �������ף�
	`weightcapacity` varchar(10) NOT NULL, -- ���أ��֣�
	`volume` varchar(10) NULL, -- �ݻ�
	`countycode` varchar(6) NOT NULL, -- ����פ��
	`location` varchar(200) NULL, -- ������ͣ��λ�ã��磺XX����԰����	
	`vantypeid` bigint NOT NULL, -- ��������
	`brand` varchar(45) NULL, -- Ʒ���ͺ�
	`trunktypeid` bigint NOT NULL, -- ��������
	`contactpersonname` varchar(45) NOT NULL, -- �泵��ϵ��
	`conatactphone` varchar(15) NOT NULL, -- �泵�绰
	`trunkidentifynumber` varchar(100) NULL, -- ����ʶ����ţ�����
	`vanimageuri` varchar(200) NULL, -- ����ͼƬ
	`licenseuri` varchar(200) NULL, -- �г�֤ͼƬ
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

INSERT INTO trunkroutetype(typename) VALUES('���س�'),('���̳�');

--
-- trunk time type 
--

DROP TABLE IF EXISTS `trunktimetype`;
CREATE TABLE `trunktimetype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO trunktimetype(typename) VALUES('��ʱ��Դ'),('���ڳ�Դ');

--
-- trunk return type
--
DROP TABLE IF EXISTS `trunkreturntype`;
CREATE TABLE `trunkreturntype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO trunkreturntype(typename) VALUES('����'),('����');

--
-- Trunk information ��Դ��Ϣ
--
DROP TABLE IF EXISTS `trunkinformation`;
CREATE TABLE `trunkinformation`(
	`id` bigint(20) auto_increment,
	`trunkid` bigint NOT NULL, -- ��ػ���
	`routetypeid` bigint NOT NULL, -- 0:  ���س���1:���̳�
	`srccountycode` varchar(6) NOT NULL, -- ������
	`dstcountycode` varchar(6) NOT NULL, -- Ŀ�ĵ�
	`router` varchar(200) , -- ;������
	`takeofftime` datetime  , -- ����ʱ��
	`marketprice` varchar(40) DEFAULT '����' NULL, -- �г��˼�
	`negotiateprice` varchar(40) NULL, -- Э���˼�
	`timetypeid` bigint NOT NULL, -- 0: ��ʱ��Դ 1�� ���ڳ�Դ
	`description` varchar(2000) DEFAULT '���Դ', -- ��Ϣ˵��
	`returntypeid` bigint NOT NULL, -- 0:���� 1�� ����
	`userid` bigint NOT NULL, -- ������Ϣ�û�
	`title` varchar (350) NOT NULL, -- ��Ϣ����	
	`releasedate` datetime DEFAULT NOW() NOT NULL, -- ����ʱ��
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
-- ---------------------------��Դ��Ϣ-----------------------------------------------
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

INSERT INTO goodstype(typename) VALUES ('�豸');
INSERT INTO goodstype(typename) VALUES ('ú̿');
INSERT INTO goodstype(typename) VALUES ('���'),
('�ֲ�'),
('����'),
('����'),
('ľ��'),
('��ʳ'),
('ʳƷ'),
('����'),
('�߲�'),
('����'),
('������Ʒ'),
('���Ʒ');

--
-- ��������
--
DROP TABLE IF EXISTS `transporttype`;
CREATE TABLE `transporttype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(8) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO transporttype(typename) VALUES('����'),
('������˾'),
('�������'),
('�㵣���');

--
-- ע������
--
DROP TABLE IF EXISTS `cautiontype`;
CREATE TABLE `cautiontype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(8) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
INSERT INTO cautiontype (typename) VALUES('����'),('����'),('����'),('Σ��Ʒ'),('��');

--
-- ��Դ��Ϣ
--
DROP TABLE IF EXISTS `goodssourceinformation`;
CREATE TABLE `goodssourceinformation`(
	`id` bigint(20) auto_increment,
	`userid` bigint NOT NULL,
	`srccountycode` varchar(6) NOT NULL, -- ���˵�
	`dstcountycode` varchar(6) NOT NULL, -- Ŀ�ĵ�
	`deadline` datetime NULL, -- Ĭ��ʮ��
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
-- ---------------------------ר����Ϣ-----------------------------------------------
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

INSERT INTO speciallinetype (typename) VALUES ('����'),('����');

--
-- table departuretype
--
DROP TABLE IF EXISTS `departuretype`;
CREATE TABLE `departuretype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20),
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO departuretype(typename) VALUES('���̶�'),
('ÿ��1��һ��'),
('ÿ��2��һ��'),
('ÿ��3��һ��'),
('ÿ��4��һ��'),
('ÿ��5��һ��');

--
-- �ص���Ϣ
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
--  ר����Ϣ
--

DROP TABLE IF EXISTS `speciallineinfo`;
CREATE TABLE `speciallineinfo`(
	`id` bigint(20) auto_increment,
	`userid` bigint NOT NULL,
	`title` varchar(200) NOT NULL,
	`sourceplaceinfoid` bigint NOT NULL,
	`destinationplaceinfoid` bigint NOT NULL,
	`weightprice` int, -- �ػ��۸�
	`volumeprice` int, -- �ݻ��۸�
	`departuretypeid` bigint,
	`speciallinetypeid` bigint,
	`description` text, -- ר��˵��
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