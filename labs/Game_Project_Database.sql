drop database if exists GameLeaderboard
drop table if exists MainLeaderboard
CREATE DATABASE GameLeaderboard

go

use GameLeaderboard
CREATE TABLE MainLeaderboard (ID INT NOT NULL PRIMARY KEY,
							 playername varchar(50) NOT NULL ,
							 Wins int not null,
							 Losses int not null)
go

DELETE FROM MainLeaderboard Where playername = 'Sam'


select*from MainLeaderboard
