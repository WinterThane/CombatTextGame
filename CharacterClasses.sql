-- Script Date: 07.08.2018 11:29  - ErikEJ.SqlCeScripting version 3.5.2.75
CREATE TABLE [CharacterClasses] (
  [Id] INTEGER NOT NULL
, [Name] TEXT NOT NULL
, [Strength] INTEGER NOT NULL
, [Constitution] INTEGER NOT NULL
, [Vitality] INTEGER NOT NULL
, [Dexterity] INTEGER NOT NULL
, [Intelligence] INTEGER NOT NULL
, [Wisdom] INTEGER NOT NULL
, [Charisma] INTEGER NOT NULL
, [Speed] INTEGER NOT NULL
, [Initiation] INTEGER NOT NULL
, [Luck] INTEGER NOT NULL
, CONSTRAINT [PK_CharacterClasses] PRIMARY KEY ([Id])
);
