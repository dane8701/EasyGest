
CREATE PROCEDURE update_menu
  @idMenu INT,
    @nomMenu VARCHAR(255),
    @montantMenu INT,
    @platsidPlat INT,
    @boissonsidBoisson INT,
    @TypeMenuidTypeMenu INT
AS
UPDATE 
MENUS
SET
      nomMenu=@nomMenu,
      montantMenu=@montantMenu,
      platsidPlat=@platsidPlat,
      boissonsidBoisson=@boissonsidBoisson,
      TypeMenuidTypeMenu=@TypeMenuidTypeMenu
WHERE       idMenu = @idMenu;