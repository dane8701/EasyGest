CREATE PROCEDURE insert_commande
    @idComande INT,
    @dateComande date,
    @quantiter INT,
    @montantUnitaire INT,
    @montantGlobal INT,
    @MenuidMenu INT
AS
INSERT INTO [COMMANDES]
(
    [idComande],
    [dateComande],
    [quantiter],
    [montantUnitaire],
    [montantGlobal],
    [MenuidMenu]
)
VALUES
(
    @idComande,
    @dateComande,
    @quantiter,
    @montantUnitaire,
    @montantGlobal,
    @MenuidMenu
);