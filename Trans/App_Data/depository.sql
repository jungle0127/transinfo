USE transinfo;

--
-- �ִ���Ϣ
--

--
-- ��Ӫ��Χ
--

DROP TABLE IF EXISTS `businessscope`;
CREATE TABLE `bussinessscope`(
	`id` bigint(20) auto_increment,
	`scopename` char(8) NOT NULL,
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO bussinessscope(scopename) VALUES('���вֿ�');
INSERT INTO bussinessscope(scopename) VALUES('���òֿ�');

--
-- �ֿ�����
--
DROP TABLE IF EXISTS `depottype`;
CREATE TABLE `depottype`(
	`id` bigint auto_increment,
	`typename` char(6) NOT NULL,
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;


INSERT INTO depottype(typename) VALUES('��ͨ');
INSERT INTO depottype(typename) VALUES('�ۺ�');
INSERT INTO depottype(typename) VALUES('��˰');
INSERT INTO depottype(typename) VALUES('���');
INSERT INTO depottype(typename) VALUES('����');
INSERT INTO depottype(typename) VALUES('Σ��Ʒ');
INSERT INTO depottype(typename) VALUES('����');
INSERT INTO depottype(typename) VALUES('¶��');
INSERT INTO depottype(typename) VALUES('����');
INSERT INTO depottype(typename) VALUES('Һ��');
INSERT INTO depottype(typename) VALUES('�ѳ�');
INSERT INTO depottype(typename) VALUES('����');

--
-- depot information
--

DROP TABLE IF EXISTS `depotinformation`;
CREATE TABLE `depotinformation`(
	`id` bigint auto_increment,
	`userid` bigint NOT NULL,
	`title` varchar(300) NOT NULL,
	`countycode` varchar(6) NOT NULL,
	`address` varchar(500) NOT NULL,
	`bizscopetype` bigint NOT NULL,
	`depottype` bigint NOT NULL,
	`area` int NOT NULL,
	`useablearea` int NOT NULL,
	`price` varchar(20) DEFAULT '����' NOT NULL,
	`contactperson` varchar(25) NOT NULL,
	`cellphone` varchar(25) NOT NULL,
	`validtime` varchar(25) NOT NULL,
	`description` text,
	PRIMARY KEY(`id`),
	FOREIGN KEY(`userid`) REFERENCES users(id),
	FOREIGN KEY(`bizscopetype`) REFERENCES bussinessscope(id),
	FOREIGN KEY(`depottype`) REFERENCES depottype(id) 
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_depotinfo_userid ON depotinformation(userid);
CREATE INDEX IX_depotinfo_title ON depotinformation(title);
CREATE INDEX IX_depotinfo_bizscope ON depotinformation(bizscopetype);
CREATE INDEX IX_depotinfo_depottype ON depotinformation(depottype);
CREATE INDEX IX_depotinfo_area ON depotinformation(area);
CREATE INDEX IX_depotinfo_usearea ON depotinformation(useablearea);
CREATE INDEX IX_depotinfo_county ON depotinformation(countycode);

--
-- Depot information view
--

DROP VIEW IF EXISTS `V_Depotinformation`;
CREATE VIEW `V_Depotinformation`
AS
SELECT
depotinformation.id,
 users.username,
 depotinformation.title,
 V_provincecitycounty.fullname AS regionname,
 V_provincecitycounty.cityname,
 V_provincecitycounty.citycode,
 depotinformation.address,
 depottype.typename AS depottypename,
 depottype.id AS depottypeid,
 bussinessscope.scopename,
 bussinessscope.id AS scopeid,
 depotinformation.area,
 depotinformation.useablearea,
 depotinformation.price,
 depotinformation.contactperson,
 depotinformation.cellphone,
 depotinformation.validtime,
 depotinformation.description 
FROM depotinformation
JOIN V_provincecitycounty ON depotinformation.countycode = V_provincecitycounty.countycode OR depotinformation.countycode = V_provincecitycounty.citycode OR depotinformation.countycode = V_provincecitycounty.provincecode
JOIN users ON users.id = depotinformation.userid
JOIN depottype ON depottype.id = depotinformation.depottype
JOIN bussinessscope ON bussinessscope.id = depotinformation.bizscopetype;


