drop database if exists GameLeaderboard
drop table if exists MainLeaderboard
CREATE DATABASE GameLeaderboard

go

use GameLeaderboard
CREATE TABLE MainLeaderboard (playername varchar(50) NOT NULL ,
							 Wins int,
							 Losses int)
go

DELETE FROM MainLeaderboard Where playername = 'Sam'
INSERT INTO MainLeaderboard (playername) Values ('Sam')

select*from MainLeaderboard
