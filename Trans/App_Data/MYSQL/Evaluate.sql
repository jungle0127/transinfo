USE transinfo;

-- ----------------------------------------------------------------------------------
-- --------------------------- Evaluate & Transaction Related------------------------
-- ----------------------------------------------------------------------------------

--
-- Create table for evaluate
--

DROP TABLE IF EXISTS `evaluatetype`;
CREATE TABLE `evaluatetype`(
	`id` bigint(20) auto_increment,
	`name` varchar(20) NOT NULL,
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO evaluatetype(name) VALUES('∫√∆¿');
INSERT INTO evaluatetype(name) VALUES('÷–∆¿');
INSERT INTO evaluatetype(name) VALUES('≤Ó∆¿');

--
-- test procedure
-- 

DROP PROCEDURE IF EXISTS `uspTest`;

DELIMITER //
CREATE PROCEDURE uspTest(IN xml_doc varchar(1000))
BEGIN 
SELECT @initial_data := EXTRACTVALUE(xml_doc,'/book/author/initial') AS initial_value;
CREATE TEMPORARY TABLE t_t(
	xml_value varchar(1000) NOT NULL
);
INSERT INTO t_t(xml_value) VALUES(@initial_data);
select * from t_t;
DROP TABLE t_t;

END//
DELIMITER ;
-- call uspTest('<book><title>SQL:1999</title><author><initial>J</initial><surname>Melton</surname></author></book>');