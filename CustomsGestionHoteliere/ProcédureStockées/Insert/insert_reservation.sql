CREATE PROCEDURE insert_reservation
    @FACTURESidFacture INT,
    @CLIENTSidClient INT,
    @TABLESidTable INT
AS
INSERT INTO [RESERVATIONS]
(
    [FACTURESidFacture],
    [CLIENTSidClient],
    [TABLESidTable]
)
VALUES
(
    @FACTURESidFacture,
    @CLIENTSidClient,
    @TABLESidTable
);