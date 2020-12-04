CREATE PROCEDURE insert_client
    @idClient INT,
    @nomClient VARCHAR(255),
    @prenomClient VARCHAR(255),
    @telephone INT,
    @adresse VARCHAR(255),
    @TABLESidTable INT,
    @COMMANDESidComande INT
AS
INSERT INTO [CLIENTS]
(
    [idClient],
    [nomClient],
    [prenomClient],
    [telephone],
    [adresse],
    [TABLESidTable],
    [COMMANDESidComande]
)
VALUES
(
    @idClient,
    @nomClient,
    @prenomClient,
    @telephone,
    @adresse,
    @TABLESidTable,
    @COMMANDESidComande
);
