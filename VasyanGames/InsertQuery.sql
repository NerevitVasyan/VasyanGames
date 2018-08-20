

/*			SELECT			*/
select * from games

select * from Producers

select * from Genres

select 
Games.Name,Games.Year,Games.Score,Producers.NameProducer,Genres.NameGenre 
from Games 
inner join Producers on Producers.ID = Games.Producer_ID
inner join Genres on Genres.ID = Games.Genre_ID

/*		SOME PREPARATIONS   */

alter table Games
alter column Year int null

alter table Games
alter column Score int null

drop table __MigrationHistory


/*			INSERT			*/

insert into Genres values
('RPG'),
('Platform'),
('Shooter'),
('Strategy'),
('MOBA'),
('Action')

insert into Producers values
('CD Project Red'),
('Bethesda Softworks'),
('Ubisoft'),
('Blizzard'),
('From Software'),
('Moon Studios'),
('Valve'),
('Rockstar Games')


insert into Games values
('The Witcher 3 - Wild Hunt',2015,99,'path','desc',(select ID from Genres where NameGenre = 'RPG'),           (select ID from Producers where NameProducer = 'CD Project Red') ),
('The Witcher 2 - Assassins of Kings',2011,85,'path','desc',(select ID from Genres where NameGenre = 'RPG'),  (select ID from Producers where NameProducer = 'CD Project Red') ),
('The Witcher',2007,90,'path','desc',(select ID from Genres where NameGenre = 'RPG'),                         (select ID from Producers where NameProducer = 'CD Project Red') ),
('The Elder Scrolls III - Morrowind',2002,100,'path','desc',(select ID from Genres where NameGenre = 'RPG'),  (select ID from Producers where NameProducer = 'Bethesda Softworks') ),
('The Elder Scrolls IV - Oblivion',2006,80,'path','desc',(select ID from Genres where NameGenre = 'RPG'),     (select ID from Producers where NameProducer = 'Bethesda Softworks') ),
('The Elder Scrolls V - Skyrim',2011,85,'path','desc',(select ID from Genres where NameGenre = 'RPG'),        (select ID from Producers where NameProducer = 'Bethesda Softworks') ),
('The Elder Scrolls VI',null,null,'path','desc',(select ID from Genres where NameGenre = 'RPG'),              (select ID from Producers where NameProducer = 'Bethesda Softworks') ),
('Dota 2',2012,70,'path','desc',(select ID from Genres where NameGenre = 'MOBA'),                             (select ID from Producers where NameProducer = 'Valve') ),
('Counter-Strike: Global Offensive',2012,50,'path','desc',(select ID from Genres where NameGenre = 'Shooter'),(select ID from Producers where NameProducer = 'Valve') ),
('Portal 2',2011,90,'path','desc',(select ID from Genres where NameGenre = 'Platform'),                       (select ID from Producers where NameProducer = 'Valve') ),
('Warcraft III',2003,95,'path','desc',(select ID from Genres where NameGenre = 'Strategy'),                   (select ID from Producers where NameProducer = 'Blizzard') ),
('Starcraft II',2010,85,'path','desc',(select ID from Genres where NameGenre = 'Strategy'),                   (select ID from Producers where NameProducer = 'Blizzard') ),
('Diablo II',2001,90,'path','desc',(select ID from Genres where NameGenre = 'RPG'),                           (select ID from Producers where NameProducer = 'Blizzard') ),
('Ori and The Blind Forest',2015,100,'path','desc',(select ID from Genres where NameGenre = 'Platform'),      (select ID from Producers where NameProducer = 'Moon Studios') ),
('Ori and Will of The Wisps',null,null,'path','desc',(select ID from Genres where NameGenre = 'Platform'),    (select ID from Producers where NameProducer = 'Moon Studios') ),
('Fallout 3',2008,55,'path','desc',(select ID from Genres where NameGenre = 'Shooter'),                       (select ID from Producers where NameProducer = 'Bethesda Softworks') ),
('Fallout 4',2015,80,'path','desc',(select ID from Genres where NameGenre = 'Shooter'),                       (select ID from Producers where NameProducer = 'Bethesda Softworks') ),
('Dark Souls II',2014,80,'path','desc',(select ID from Genres where NameGenre = 'Action'),                    (select ID from Producers where NameProducer = 'From Software') ),
('Dark Souls III',2016,85,'path','desc',(select ID from Genres where NameGenre = 'Action'),                   (select ID from Producers where NameProducer = 'From Software') ),
('Assassin''s Creed Origins',2017,80,'path','desc',(select ID from Genres where NameGenre = 'RPG'),           (select ID from Producers where NameProducer = 'Ubisoft') ),
('Far Cry 3',2012,85,'path','desc',(select ID from Genres where NameGenre = 'Shooter'),                       (select ID from Producers where NameProducer = 'Ubisoft') ),
('Heroes of Might and Magic V',2006,80,'path','desc',(select ID from Genres where NameGenre = 'Strategy'),    (select ID from Producers where NameProducer = 'Ubisoft') ),
('Grand Theft Auto: Vice City',2002,85,'path','desc',(select ID from Genres where NameGenre = 'Action'),      (select ID from Producers where NameProducer = 'Rockstar Games') ),
('Grand Theft Auto: San Andreas',2004,75,'path','desc',(select ID from Genres where NameGenre = 'Action'),    (select ID from Producers where NameProducer = 'Rockstar Games') ),
('Grand Theft Auto V',2013,95,'path','desc',(select ID from Genres where NameGenre = 'Action'),               (select ID from Producers where NameProducer = 'Rockstar Games') )


/*			DELETE			*/

delete from Games
delete from Genres
delete from Producers
