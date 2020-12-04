CREATE PROCEDURE search_boisson
    @nomBoisson VARCHAR(255)
AS
SELECT * from BOISSONS
where nomBoisson =  @nomBoisson