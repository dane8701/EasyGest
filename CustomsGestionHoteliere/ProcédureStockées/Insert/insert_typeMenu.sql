CREATE PROCEDURE insert_typeMenu
    @idTypeMenu INT,
    @nomTypeMenu VARCHAR(255)
AS
INSERT INTO [TypeMenus]
(
    [idTypeMenu],
    [nomTypeMenu]
)
VALUES
(
    @idTypeMenu,
    @nomTypeMenu
);