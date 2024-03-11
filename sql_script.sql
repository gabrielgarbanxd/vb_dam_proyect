-- drop database gestor_enfermeria;
create database if not exists vb_proyect_joyfe default character set utf8mb4 collate utf8mb4_unicode_ci;
use vb_proyect_joyfe;


-- *************************************************************************
-- *                                                                       *
-- *                             TABLE DEFINITIONS                        *
-- *                                                                       *
-- *************************************************************************

-- Drop tables if they exist
DROP TABLE IF EXISTS `vb_proyect_joyfe`.`users`;
DROP TABLE IF EXISTS `vb_proyect_joyfe`.`role_permissions`;
DROP TABLE IF EXISTS `vb_proyect_joyfe`.`roles`;
DROP TABLE IF EXISTS `vb_proyect_joyfe`.`permissions`;
DROP TABLE IF EXISTS `vb_proyect_joyfe`.`deleted_users`;


-- creates tables

CREATE TABLE `vb_proyect_joyfe`.`permissions` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `action` ENUM('CREATE', 'UPDATE', 'READ', 'DELETE') NOT NULL,
  `resource` ENUM('USERS', 'ROLES', 'PERMISSIONS', 'DELETED_USERS') NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE);
  
  
CREATE TABLE `vb_proyect_joyfe`.`roles` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `description` VARCHAR(255) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  UNIQUE INDEX `name_UNIQUE` (`name` ASC) VISIBLE);
  
CREATE TABLE `vb_proyect_joyfe`.`role_permissions` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `role_id` INT UNSIGNED NOT NULL,
  `permission_id` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  INDEX `fk_role_permisions_role_idx` (`role_id` ASC) VISIBLE,
  INDEX `fk_role_permissions_permission_idx` (`permission_id` ASC) VISIBLE,
  CONSTRAINT `fk_role_permisions_role`
    FOREIGN KEY (`role_id`)
    REFERENCES `vb_proyect_joyfe`.`roles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_role_permissions_permission`
    FOREIGN KEY (`permission_id`)
    REFERENCES `vb_proyect_joyfe`.`permissions` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

  
  
CREATE TABLE `vb_proyect_joyfe`.`users` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `email` VARCHAR(255) NOT NULL,
  `password` VARCHAR(255) NOT NULL,
  `payment` DATETIME NULL,
  `last_connection` DATETIME NULL,
  `first_login` TINYINT NOT NULL DEFAULT 1,
  `role_id` INT UNSIGNED NOT NULL,
  `created_at` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  UNIQUE INDEX `name_UNIQUE` (`name` ASC) VISIBLE,
  INDEX `fk_user_role_idx` (`role_id` ASC) VISIBLE,
  CONSTRAINT `fk_user_role`
    FOREIGN KEY (`role_id`)
    REFERENCES `vb_proyect_joyfe`.`roles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- Tabla de usuarios eliminados
CREATE TABLE `vb_proyect_joyfe`.`deleted_users` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `email` VARCHAR(255) NOT NULL,
  `role_id` INT UNSIGNED NOT NULL,
  `created_at` DATETIME NOT NULL,
  `deleted_at` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  UNIQUE INDEX `name_UNIQUE` (`name` ASC) VISIBLE
);



-- *************************************************************************
-- *                                                                       *
-- *                             INSERTS FOR ROLES AND PERMINSIONS       *
-- *                                                                       *
-- *************************************************************************

-- Inserts para crear los roles
INSERT INTO roles (name, description) VALUES
('admin', 'Administrador del sistema'),
('moderator', 'Moderador del sistema'),
('user', 'Usuario del sistema');


-- Inserts para crear los permisos para cada acción en cada recurso
INSERT INTO permissions (action, resource) VALUES
('CREATE', 'USERS'), ('UPDATE', 'USERS'), ('READ', 'USERS'), ('DELETE', 'USERS'),
('CREATE', 'ROLES'), ('UPDATE', 'ROLES'), ('READ', 'ROLES'), ('DELETE', 'ROLES'),
('CREATE', 'PERMISSIONS'), ('UPDATE', 'PERMISSIONS'), ('READ', 'PERMISSIONS'), ('DELETE', 'PERMISSIONS'),
('CREATE', 'DELETED_USERS'), ('UPDATE', 'DELETED_USERS'), ('READ', 'DELETED_USERS'), ('DELETE', 'DELETED_USERS');


-- Inserts para asignar permisos a los roles
-- El rol admin tiene todos los permisos
INSERT INTO role_permissions (role_id, permission_id) VALUES
(1, 1), (1, 2), (1, 3), (1, 4), (1, 5), (1, 6), (1, 7), (1, 8), (1, 9), (1, 10), (1, 11), (1, 12), (1, 13), (1, 14), (1, 15), (1, 16),

-- El rol moderator tiene permisos para crear, leer y actualizar usuarios
(2, 1), (2, 2), (2, 3), (2, 5), (2, 6), (2, 7), (2, 9), (2, 10), (2, 11), (2, 13), (2, 14), (2, 15),

-- El rol user tiene permisos para leer usuarios
(3, 3), (3, 7), (3, 11), (3, 15);


-- Usuario administrador
INSERT INTO `vb_proyect_joyfe`.`users` (`name`, `email`, `password`, `role_id`, `created_at`)
VALUES ('admin', 'globezno2004@gmail.com', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 
        (SELECT id FROM `vb_proyect_joyfe`.`roles` WHERE `name` = 'admin'), 
        CURRENT_TIMESTAMP);

-- Usuario moderador
INSERT INTO `vb_proyect_joyfe`.`users` (`name`, `email`, `password`, `role_id`, `created_at`)
VALUES ('moderator', 'moderator@example.com', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 
        (SELECT id FROM `vb_proyect_joyfe`.`roles` WHERE `name` = 'moderator'), 
        CURRENT_TIMESTAMP);


-- Usuario usuario
INSERT INTO `vb_proyect_joyfe`.`users` (`name`, `email`, `password`, `role_id`, `created_at`)
VALUES ('user', 'user@example.com', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 
        (SELECT id FROM `vb_proyect_joyfe`.`roles` WHERE `name` = 'user'), 
        CURRENT_TIMESTAMP);
INSERT INTO `vb_proyect_joyfe`.`users` (`name`, `email`, `password`, `role_id`, `created_at`)
VALUES ('user2', 'user@example.com', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 
        (SELECT id FROM `vb_proyect_joyfe`.`roles` WHERE `name` = 'user'), 
        CURRENT_TIMESTAMP);
INSERT INTO `vb_proyect_joyfe`.`users` (`name`, `email`, `password`, `role_id`, `created_at`)
VALUES ('user3', 'user@example.com', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 
        (SELECT id FROM `vb_proyect_joyfe`.`roles` WHERE `name` = 'user'), 
        CURRENT_TIMESTAMP);


-- -- Query to join the tables and verify the assignments
-- SELECT u.name, r.name, p.action, p.resource
-- FROM users u
-- JOIN roles r ON u.role_id = r.id
-- JOIN role_permissions rp ON r.id = rp.role_id
-- JOIN permissions p ON rp.permission_id = p.id;



-- *************************************************************************
-- *                                                                       *
-- *                           STORED PROCEDURES                          *
-- *                                                                       *
-- *************************************************************************

-- ==================================
-- ========>>    USERS    <<=========
-- ==================================

-- //===>> GetAllUsersProcedure users procedure <<===//
DROP PROCEDURE IF EXISTS `GetAllUsersProcedure`;

DELIMITER $$
CREATE PROCEDURE `GetAllUsersProcedure`()
BEGIN
    SELECT * FROM users;
END$$

DELIMITER ;

-- //===>> GetUserByIdProcedure users procedure <<===//
DROP PROCEDURE IF EXISTS `GetUserByIdProcedure`;

DELIMITER $$
CREATE PROCEDURE `GetUserByIdProcedure`(IN p_id INT)
BEGIN
    SELECT * FROM users WHERE id = p_id;
END$$

DELIMITER ;

-- //===>> SearchUsersByNameProcedure users procedure <<===//
DROP PROCEDURE IF EXISTS `SearchUsersByNameProcedure`;

DELIMITER $$
CREATE PROCEDURE `SearchUsersByNameProcedure`(IN p_name VARCHAR(255))
BEGIN
    SELECT * FROM users WHERE name LIKE p_name;
END$$

DELIMITER ;

-- //===>> SearchUsersByEmailProcedure users procedure <<===//
DROP PROCEDURE IF EXISTS `SearchUsersByEmailProcedure`;

DELIMITER $$
CREATE PROCEDURE `SearchUsersByEmailProcedure`(IN p_email VARCHAR(255))
BEGIN
    SELECT * FROM users WHERE email LIKE CONCAT('%', p_email, '%');
END$$

DELIMITER ;

-- //===>> CreateUserProcedure users procedure <<===//
DROP PROCEDURE IF EXISTS `CreateUserProcedure`;

DELIMITER $$
CREATE PROCEDURE `CreateUserProcedure`(
  IN p_name VARCHAR(255),
  IN p_email VARCHAR(255),
  IN p_password VARCHAR(255),
  IN p_payment VARCHAR(255),
  IN p_lastConnection DATETIME,
  IN p_firstLogin TINYINT,
  IN p_roleId INT,
  IN p_createdAt DATETIME,
  OUT p_Result INT
)
BEGIN
  INSERT INTO users (name, email, password, payment, last_connection, first_login, role_id, created_at)
  VALUES (p_name, p_email, p_password, p_payment, p_lastConnection, p_firstLogin, p_roleId, p_createdAt);
  
  SET p_Result = LAST_INSERT_ID();
  
  IF p_Result = 0 THEN
    SET p_Result = -1;
  END IF;
END$$

DELIMITER ;

-- //===>> UpdateUserProcedure users procedure <<===//
DROP PROCEDURE IF EXISTS `UpdateUserProcedure`;

DELIMITER $$
CREATE PROCEDURE `UpdateUserProcedure`(
  IN p_id INT,
  IN p_name VARCHAR(255),
  IN p_email VARCHAR(255),
  IN p_password VARCHAR(255),
  IN p_payment VARCHAR(255),
  IN p_lastConnection DATETIME,
  IN p_firstLogin TINYINT,
  IN p_roleId INT,
  IN p_createdAt DATETIME,
  OUT p_Result INT
)
BEGIN
  UPDATE users
  SET name = p_name, email = p_email, password = p_password, payment = p_payment, last_connection = p_lastConnection, first_login = p_firstLogin, role_id = p_roleId, created_at = p_createdAt
  WHERE id = p_id;

  SET p_Result = ROW_COUNT();

  IF p_Result = 0 THEN
    SET p_Result = -1;
  END IF;

END$$

DELIMITER ;

-- //===>> DeleteUserProcedure users procedure <<===//
DROP PROCEDURE IF EXISTS `DeleteUserProcedure`;

DELIMITER $$
CREATE PROCEDURE `DeleteUserProcedure`(IN p_id INT, OUT p_Result INT)
BEGIN
  DELETE FROM users WHERE id = p_id;

  SET p_Result = ROW_COUNT();

  IF p_Result = 0 THEN
    SET p_Result = -1;
  END IF;
END$$

DELIMITER ;

-- ==================================
-- ========>>    ROLES    <<=========
-- ==================================

-- //===>> GetAllRolesProcedure roles procedure <<===//
DROP PROCEDURE IF EXISTS `GetAllRolesProcedure`;

DELIMITER $$
CREATE PROCEDURE `GetAllRolesProcedure`()
BEGIN
    SELECT * FROM roles;
END$$

DELIMITER ;

-- //===>> FindRoleByIdProcedure roles procedure <<===//
DROP PROCEDURE IF EXISTS `FindRoleByIdProcedure`;

DELIMITER $$
CREATE PROCEDURE `FindRoleByIdProcedure`(IN p_id INT)
BEGIN
  SELECT * FROM roles WHERE id = p_id;
END$$

DELIMITER ;

-- //===>> SearchRoleByNameProcedure roles procedure <<===//
DROP PROCEDURE IF EXISTS `SearchRoleByNameProcedure`;

DELIMITER $$
CREATE PROCEDURE `SearchRoleByNameProcedure`(IN p_name VARCHAR(255))
BEGIN
  SELECT * FROM roles WHERE name LIKE p_name;
END$$

DELIMITER ;

-- //===>> CreateRoleProcedure roles procedure <<===//
DROP PROCEDURE IF EXISTS `CreateRoleProcedure`;

DELIMITER $$
CREATE PROCEDURE `CreateRoleProcedure`(
  IN p_name VARCHAR(255),
  IN p_description VARCHAR(255),
  OUT p_Result INT
)
BEGIN
  INSERT INTO roles (name, description)
  VALUES (p_name, p_description);

  SET p_Result = LAST_INSERT_ID();


  IF p_Result = 0 THEN
    SET p_Result = -1;
  END IF;
END$$

DELIMITER ;

-- //===>> UpdateRoleProcedure roles procedure <<===//
DROP PROCEDURE IF EXISTS `UpdateRoleProcedure`;

DELIMITER $$
CREATE PROCEDURE `UpdateRoleProcedure`(
  IN p_id INT,
  IN p_name VARCHAR(255),
  IN p_description VARCHAR(255),
  OUT p_Result INT
)
BEGIN
  UPDATE roles
  SET name = p_name, description = p_description
  WHERE id = p_id;

  SET p_Result = ROW_COUNT();

  IF p_Result = 0 THEN
    SET p_Result = -1;
  END IF;
END$$

DELIMITER ;

-- /===>> DeleteRoleProcedure roles procedure <<===//
DROP PROCEDURE IF EXISTS `DeleteRoleProcedure`;

DELIMITER $$
CREATE PROCEDURE `DeleteRoleProcedure`(IN p_id INT, OUT p_Result INT)
BEGIN
  DELETE FROM roles WHERE id = p_id;

  SELECT id INTO p_Result FROM roles WHERE id = p_id;

  -- Verificar si la eliminación fue exitosa
  IF p_Result > 0 THEN
    SET p_Result = 0; -- Código de error para eliminación no exitosa
  ELSE
    SET p_Result = p_id; -- Código de éxito
    END IF;

  
END$$

DELIMITER ;


-- //===>> AssignPermissionToRoleProcedure permissions procedure <<===//
DROP PROCEDURE IF EXISTS `AssignPermissionToRoleProcedure`;

DELIMITER $$
CREATE PROCEDURE `AssignPermissionToRoleProcedure`(IN p_role_id INT, IN p_permission_id INT)
BEGIN
  INSERT INTO role_permissions (role_id, permission_id)
  VALUES (p_role_id, p_permission_id);
END$$

DELIMITER ;


-- //===>> UnassignPermissionToRoleProcedure permissions procedure <<===//
DROP PROCEDURE IF EXISTS `UnassignPermissionToRoleProcedure`;

DELIMITER $$
CREATE PROCEDURE `UnassignPermissionToRoleProcedure`(IN p_role_id INT, IN p_permission_id INT)
BEGIN
  DELETE FROM role_permissions WHERE role_id = p_role_id AND permission_id = p_permission_id;
END$$

DELIMITER ;



-- ==================================
-- ========>>    PERMISSIONS    <<=========
-- ==================================

-- //===>> GetAllPermissionsProcedure permissions procedure <<===//
DROP PROCEDURE IF EXISTS `GetAllPermissionsProcedure`;

DELIMITER $$
CREATE PROCEDURE `GetAllPermissionsProcedure`()
BEGIN
    SELECT * FROM permissions;
END$$

DELIMITER ;

-- //===>> GetPermissionByIdProcedure permissions procedure <<===//
DROP PROCEDURE IF EXISTS `GetPermissionByIdProcedure`;

DELIMITER $$
CREATE PROCEDURE `GetPermissionByIdProcedure`(IN p_id INT)
BEGIN
  SELECT * FROM permissions WHERE id = p_id;
END$$

DELIMITER ;

-- //===>> SearchPermissionsByNameProcedure permissions procedure <<===//
DROP PROCEDURE IF EXISTS `SearchPermissionsByNameProcedure`;

DELIMITER $$
CREATE PROCEDURE `SearchPermissionsByNameProcedure`(IN p_name VARCHAR(255))
BEGIN
  SELECT * FROM permissions WHERE name LIKE p_name;
END$$

DELIMITER ;

-- //===>> SearchPermissionsByRoleProcedure permissions procedure <<===//
DROP PROCEDURE IF EXISTS `SearchPermissionsByRoleProcedure`;

DELIMITER $$
CREATE PROCEDURE `SearchPermissionsByRoleProcedure`(IN p_role_id VARCHAR(255))
BEGIN

  SELECT p.id, p.action, p.resource
  FROM permissions p
  JOIN role_permissions rp ON p.id = rp.permission_id
  JOIN roles r ON rp.role_id = r.id
  WHERE r.name = p_role_id;
END$$

DELIMITER ;

-- //===>> CreatePermissionProcedure permissions procedure <<===//
DROP PROCEDURE IF EXISTS `CreatePermissionProcedure`;

DELIMITER $$
CREATE PROCEDURE `CreatePermissionProcedure`(
  IN p_name VARCHAR(255),
  IN p_role VARCHAR(255),
  IN p_description VARCHAR(255),
  OUT p_Result INT
)
BEGIN
  INSERT INTO permissions (name, role, description)
  VALUES (p_name, p_role, p_description);

  SET p_Result = LAST_INSERT_ID();

  IF p_Result = 0 THEN
    SET p_Result = -1;
  END IF;
END$$

DELIMITER ;

-- //===>> UpdatePermissionProcedure permissions procedure <<===//
DROP PROCEDURE IF EXISTS `UpdatePermissionProcedure`;

DELIMITER $$
CREATE PROCEDURE `UpdatePermissionProcedure`(
  IN p_id INT,
  IN p_name VARCHAR(255),
  IN p_role VARCHAR(255),
  IN p_description VARCHAR(255),
  OUT p_Result INT
)
BEGIN
  UPDATE permissions
  SET name = p_name, role = p_role, description = p_description
  WHERE id = p_id;

  SET p_Result = ROW_COUNT();

  IF p_Result = 0 THEN
    SET p_Result = -1;
  END IF;

END$$

DELIMITER ;

-- //===>> DeletePermissionProcedure permissions procedure <<===//
DROP PROCEDURE IF EXISTS `DeletePermissionProcedure`;

DELIMITER $$
CREATE PROCEDURE `DeletePermissionProcedure`(IN p_id INT, OUT p_Result INT)
BEGIN
  DELETE FROM permissions WHERE id = p_id;

  SET p_Result = ROW_COUNT();

  IF p_Result = 0 THEN
    SET p_Result = -1;
  END IF;
END$$

DELIMITER ;



-- ==================================
-- ========>>   DELETED USERS    <<=========
-- ==================================

-- //===>> GetAllDeletedUsersProcedure deleted_users procedure <<===//
DROP PROCEDURE IF EXISTS `GetAllDeletedUsersProcedure`;

DELIMITER $$
CREATE PROCEDURE `GetAllDeletedUsersProcedure`()
BEGIN
    SELECT * FROM deleted_users;
END$$

DELIMITER ;

-- //===>> GetDeletedUserByIdProcedure deleted_users procedure <<===//
DROP PROCEDURE IF EXISTS `GetDeletedUserByIdProcedure`;

DELIMITER $$
CREATE PROCEDURE `GetDeletedUserByIdProcedure`(IN p_id INT)
BEGIN
  SELECT * FROM deleted_users WHERE id = p_id;
END$$

DELIMITER ;


-- //===>> SearchDeletedUsersByNameProcedure deleted_users procedure <<===//
DROP PROCEDURE IF EXISTS `SearchDeletedUsersByNameProcedure`;

DELIMITER $$
CREATE PROCEDURE `SearchDeletedUsersByNameProcedure`(IN p_name VARCHAR(255))
BEGIN
  SELECT * FROM deleted_users WHERE name LIKE p_name;
END$$

DELIMITER ;

-- //===>> CreateDeletedUserProcedure deleted_users procedure <<===//
DROP PROCEDURE IF EXISTS `CreateDeletedUserProcedure`;

DELIMITER $$
CREATE PROCEDURE `CreateDeletedUserProcedure`(
  IN p_name VARCHAR(255),
  IN p_email VARCHAR(255),
  IN p_role_id INT,
  IN p_created_at DATETIME,
  IN p_deleted_at DATETIME,
  OUT p_Result INT
)
BEGIN
  INSERT INTO deleted_users (name, email, role_id, created_at, deleted_at)
  VALUES (p_name, p_email, p_role_id, p_created_at, p_deleted_at);

  SET p_Result = LAST_INSERT_ID();

  IF p_Result = 0 THEN
    SET p_Result = -1;
  END IF;
END$$

DELIMITER ;

-- //===>> DeleteDeletedUserProcedure deleted_users procedure <<===//
DROP PROCEDURE IF EXISTS `DeleteDeletedUserProcedure`;

DELIMITER $$
CREATE PROCEDURE `DeleteDeletedUserProcedure`(IN p_id INT, OUT p_Result INT)
BEGIN
  DELETE FROM deleted_users WHERE id = p_id;

  SET p_Result = ROW_COUNT();

  IF p_Result = 0 THEN
    SET p_Result = -1;
  END IF;
END$$

DELIMITER ;








