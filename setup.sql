CREATE TABLE IF NOT EXISTS recipes(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT "primary key",
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT "create time",
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT "update time",
  title VARCHAR(255) COMMENT "recipe title",
  description VARCHAR(255) COMMENT "recipe description",
  imgUrl VARCHAR(255) COMMENT  "image",
  steps INT COMMENT "recipe steps",
  ingredients INT COMMENT "ingredients",
  creator VARCHAR(255) COMMENT "creator name",
  creatorId VARCHAR(255) COMMENT "creator ID"
) default charset utf8 comment '';

