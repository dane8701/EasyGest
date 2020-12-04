CREATE PROCEDURE search_commande
    @idComande INT
AS
SELECT * from COMMANDES
where idComande =  @idComande