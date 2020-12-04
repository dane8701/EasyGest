CREATE PROCEDURE search_menu
    @nomMenu VARCHAR(255)
AS
SELECT * from MENUS
where nomMenu =  @nomMenu