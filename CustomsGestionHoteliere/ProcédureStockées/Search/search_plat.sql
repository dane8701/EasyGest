CREATE PROCEDURE search_plat
    @nomPlat VARCHAR(255)
AS
SELECT * from PLATS
where nomPlat =  @nomPlat