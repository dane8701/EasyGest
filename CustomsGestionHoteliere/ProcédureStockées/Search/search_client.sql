CREATE PROCEDURE search_client
    @nomClient VARCHAR(255)
AS
SELECT * from CLIENTS
where nomClient =  @nomClient