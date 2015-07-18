USE transinfo;

--
-- Logistic corporation audit
--

DROP TABLE IF EXISTS `LogisticsCor`;
CREATE TABLE LogisticsCor(
	`id` bigint auto_increment,
    `userid` bigint NOT NULL,
    `corporationname` varchar(200) NOT NULL,
    `address` varchar(450) NOT NULL,
    `contactperson` varchar(50) NOT NULL, 
    `telephone` varchar(20) NOT NULL,
    `licenseurl` varchar(400) NOT NULL,
    `active` tinyint DEFAULT 0 NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(userid) REFERENCES users(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_LogisticsCor_userid ON LogisticsCor(userid);

--
-- metadata of corporation
--

DROP TABLE IF EXISTS `CorporationMetadata`;
CREATE TABLE CorporationMetadata(
	`id` bigint auto_increment,
    `userid` bigint NOT NULL,
    `corporationname` varchar(200) NOT NULL,
    `address` varchar(450) NOT NULL,
    `postcode` varchar(10) NOT NULL,
    `bizcontactperson` varchar(50) NOT NULL,
    `biztelephone` varchar(20) NOT NULL,
    `url` varchar(400),
    `logourl` varchar(400) NOT NULL,
    `customerQQ` varchar(20),
    `customerEmail` varchar(200),
    `introduction` text,
	`active` tinyint DEFAULT 1 NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(userid) REFERENCES users(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_CorporationMetadata_users ON CorporationMetadata(userid);

--
-- Corporation Hornor information
--
DROP TABLE IF EXISTS `CorporationHonor`;
CREATE TABLE CorporationHonor(
	`id` bigint auto_increment,
    `corporationid` bigint NOT NULL,
    `honortitle` varchar(200) NOT NULL,
    `honorimageurl` varchar(400) NOT NULL,
    `active` tinyint DEFAULT 1 NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(corporationid) REFERENCES CorporationMetadata(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_CorporationHonor_metadata ON CorporationHonor(corporationid);

