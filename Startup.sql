use realmcommander10;

-- DROP TABLE knightsquests;

-- CREATE TABLE knights (

-- id int NOT NULL AUTO_INCREMENT,
-- name VARCHAR(255) NOT NULL,
-- armorType VARCHAR(255) NOT NULL,
-- weaponType VARCHAR(255) DEFAULT "Sword",
-- knightClass VARCHAR(255) NOT NULL,
-- PRIMARY KEY(id)
-- );


  -- CREATE TABLE quests(
  --   id int NOT NULL AUTO_INCREMENT,
  --   title VARCHAR(255) NOT NULL,
  --   description VARCHAR(255) NOT NULL,
  --   completed tinyint NOT NULL DEFAULT 0,
  --   PRIMARY KEY(id)
  -- );

  -- CREATE TABLE knightsquests(
  --   id int NOT NULL AUTO_INCREMENT,
  --   knightId int NOT NULL,
  --   questId int NOT NULL,
  --   PRIMARY KEY(id),

  --   FOREIGN KEY(knightId)
  --   REFERENCES knights(id)
  --   ON DELETE CASCADE,

  --   FOREIGN KEY(questId)
  --   REFERENCES quests(id)
  --   ON DELETE CASCADE
  -- );

  -- INSERT INTO knightsquests(knightId, questId) VALUES (1, 1)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (1, 2)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (1, 4)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (3, 2)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (3, 2)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (4, 1)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (4, 4)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (6, 1)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (7, 1)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (7, 2)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (7, 4)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (9, 1)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (11, 2)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (11, 4)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (12, 1)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (12, 2)
  -- INSERT INTO knightsquests(knightId, questId) VALUES (12, 4)




-- INSERT INTO knights (name, armorType, weaponType, knightClass) VALUES ("Sir Wright", "Leather", "Bow", "Elf");
-- INSERT INTO knights (name, armorType, weaponType, knightClass) VALUES ("Dancelot", "Chains", "Sword", "Knight");
-- INSERT INTO knights (name, armorType, weaponType, knightClass) VALUES ("Hamalot", "Iron", "Dagger", "Knight");
-- INSERT INTO knights (name, armorType, weaponType, knightClass) VALUES ("Shanalynn", "Leather", "Mace", "Cleric");
-- INSERT INTO knights (name, armorType, weaponType, knightClass) VALUES ("Sir Coldervere", "Cloth", "Books", "Mage");
-- INSERT INTO knights (name, armorType, weaponType, knightClass) VALUES ("Sir Foldervere", "Clothes", "Spells", "Mage");
-- INSERT INTO knights (name, armorType, weaponType, knightClass) VALUES ("Sir Rendevere", "Chains", "Spear", "Knight");
-- INSERT INTO knights (name, armorType, weaponType, knightClass) VALUES ("Sir Pumpkin", "Cloth", "Maces", "Cleric");
-- INSERT INTO knights (name, armorType, weaponType, knightClass) VALUES ("Sir Swelldervere", "Hoodie", "Paper", "Messenger");
-- INSERT INTO knights (name, armorType, weaponType, knightClass) VALUES ("Sir Meldervere", "Leather", "LongBow", "Ranger");

-- INSERT INTO quests (title, description) VALUES ("Welcome!", "Up the road you will see a lady dressed in black. Talk to her to head to your next quest");
-- INSERT INTO quests (title, description) VALUES ("Moving Along!", "After talking to Lady Baralook, you realize that there is an older gentlement that is in need of help with porgs in his farm.");





-- SELECT * FROM knights;
-- SELECT * FROM quests;
-- SELECT * FROM knightsquests;