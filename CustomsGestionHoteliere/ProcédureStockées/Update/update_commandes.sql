
CREATE PROCEDURE update_commandes
  @idComande INT  , 
  @dateComande date, 
   @quantiter INT, 
    @montantUnitaire INT, 
    @montantGlobal INT
AS
UPDATE 
COMMANDES
SET
    dateComande = @dateComande,
    quantiter = @quantiter,
    montantUnitaire = @montantUnitaire,
    montantGlobal = @montantGlobal 
WHERE     idComande =@idComande;


