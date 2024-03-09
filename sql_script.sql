-- drop database gestor_enfermeria;
create database if not exists vb_proyect_joyfe default character set utf8mb4 collate utf8mb4_unicode_ci;
use vb_proyect_joyfe;


-- *************************************************************************
-- *                                                                       *
-- *                             TABLE DEFINITIONS                        *
-- *                                                                       *
-- *************************************************************************

-- Drop tables if they exist
DROP TABLE IF EXISTS `vb_proyect_joyfe`.`roles`;
DROP TABLE IF EXISTS `vb_proyect_joyfe`.`permissions`;
DROP TABLE IF EXISTS `vb_proyect_joyfe`.`role_permissions`;
DROP TABLE IF EXISTS `vb_proyect_joyfe`.`users`;


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
  `first_login` TINYINT NOT NULL DEFAULT 0,
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
    
    



-- *************************************************************************
-- *                                                                       *
-- *                             INSERTS FOR ROLES AND PERMINSIONS       *
-- *                                                                       *
-- *************************************************************************
    
    
-- Inserts para crear los permisos para cada acción en cada recurso
INSERT INTO permissions (action, resource) VALUES
('CREATE', 'USERS'), ('UPDATE', 'USERS'), ('READ', 'USERS'), ('DELETE', 'USERS'),
('CREATE', 'ROLES'), ('UPDATE', 'ROLES'), ('READ', 'ROLES'), ('DELETE', 'ROLES'),
('CREATE', 'PERMISSIONS'), ('UPDATE', 'PERMISSIONS'), ('READ', 'PERMISSIONS'), ('DELETE', 'PERMISSIONS'),
('CREATE', 'DELETED_USERS'), ('UPDATE', 'DELETED_USERS'), ('READ', 'DELETED_USERS'), ('DELETE', 'DELETED_USERS');

-- Obtener los IDs de los roles
SET @adminRoleId = (SELECT id FROM roles WHERE name = 'admin');
SET @moderatorRoleId = (SELECT id FROM roles WHERE name = 'moderator');
SET @userRoleId = (SELECT id FROM roles WHERE name = 'user');

-- Obtener los IDs de los permisos
SET @createPermissionId = (SELECT id FROM permissions WHERE action = 'CREATE');
SET @updatePermissionId = (SELECT id FROM permissions WHERE action = 'UPDATE');
SET @readPermissionId = (SELECT id FROM permissions WHERE action = 'READ');
SET @deletePermissionId = (SELECT id FROM permissions WHERE action = 'DELETE');

-- Establecer las relaciones entre los roles y los permisos en la tabla intermedia
-- Para el admin: todos los permisos para todos los recursos, incluido DELETE
INSERT INTO role_permissions (role_id, permission_id) VALUES
(@adminRoleId, @createPermissionId), (@adminRoleId, @updatePermissionId), (@adminRoleId, @readPermissionId), (@adminRoleId, @deletePermissionId);

-- Para el moderador: permisos de lectura y actualización de todos los recursos
INSERT INTO role_permissions (role_id, permission_id) VALUES
(@moderatorRoleId, @readPermissionId), (@moderatorRoleId, @updatePermissionId);

-- Para el usuario: permiso de lectura de todos los recursos
INSERT INTO role_permissions (role_id, permission_id) VALUES
(@userRoleId, @readPermissionId);


INSERT INTO `vb_proyect_joyfe`.`users` (`name`, `email`, `password`, `role_id`, `created_at`)
VALUES ('admin', 'admin@example.com', 'password123', 
        (SELECT id FROM `vb_proyect_joyfe`.`roles` WHERE `name` = 'admin'), 
        CURRENT_TIMESTAMP);



