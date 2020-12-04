CREATE PROCEDURE insert_facture
    @idFacture INT,
    @dataFacturation date,
    @montantTotal INT,
    @commandeidComande INT,
    @reservationidReservation INT,
    @detailleCommandeidDcomande INT
AS
INSERT INTO [FACTURES]
(
    [idFacture],
    [dataFacturation],
    [montantTotal],
    [commandeidComande],
    [reservationidReservation],
    [detailleCommandeidDcomande]
)
VALUES
(
    @idFacture,
    @dataFacturation,
    @montantTotal,
    @commandeidComande,
    @reservationidReservation,
    @detailleCommandeidDcomande
);