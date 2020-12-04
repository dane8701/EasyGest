CREATE PROCEDURE search_facture
    @idFacture INT
AS
SELECT * from FACTURES
where idFacture =  @idFacture