drop database if exists GameLeaderboard
drop table if exists MainLeaderboard
CREATE DATABASE GameLeaderboard

go

use GameLeaderboard
CREATE TABLE MainLeaderboard (playername varchar(50) NOT NULL ,
							 Wins int not null,
							 Losses int not null)
go

DELETE FROM MainLeaderboard Where playername = 'Sam'
INSERT INTO MainLeaderboard (playername,Wins,Losses) Values ('Sam', 0, 0)

select*from MainLeaderboard
