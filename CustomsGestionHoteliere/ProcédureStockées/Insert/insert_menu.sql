CREATE PROCEDURE insert_menu
    @idMenu INT,
    @nomMenu VARCHAR(255),
    @montantMenu INT,
    @platsidPlat INT,
    @boissonsidBoisson INT,
    @TypeMenuidTypeMenu INT
AS
INSERT INTO [MENUS]
    (
    [idMenu],
    [nomMenu],
    [montantMenu],
    [platsidPlat],
    [boissonsidBoisson],
    [TypeMenuidTypeMenu]
    )
VALUES
    (
        @idMenu,
        @nomMenu,
        @montantMenu,
        @platsidPlat,
        @boissonsidBoisson,
        @TypeMenuidTypeMenu
);