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
-- ¥Ê¥¢π˝≥Ã≤‚ ‘
--

-- DROP PROCEDURE IF EXISTS uspTestParam;
-- DELIMITER //
-- CREATE PROCEDURE (IN param1 text,IN param2 varchar(20),OUT param3 bigint)
-- BEGIN
-- select * from users;
-- END //
-- DELIMITER ;