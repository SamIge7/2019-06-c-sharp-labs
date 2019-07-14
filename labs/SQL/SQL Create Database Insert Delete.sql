drop database test02
drop TABLE table_02
create database test02

go

use test02
create TABLE table_02 (id int NOT NULL IDENTITY,
						name VARCHAR(50) NOT NULL,
						date_of_birth DATETIME NULL,
						is_happy BIT)

go

INSERT INTO table_02 VALUES('BOB', '2019-01-01 05:22:01.123', 'true')
/* new record no name */

INSERT INTO table_02 (name, date_of_birth) VALUES ('Sam', '2019-01-01 05:22:01.123')
INSERT INTO table_02 (name) VALUES ('Jen')

select*from table_02

UPDATE table_02 set is_happy = 'false' where id = 3

select*from table_02