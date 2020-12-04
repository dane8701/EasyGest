CREATE PROCEDURE insert_boisson
    @idBoisson INT,
    @nomBoisson VARCHAR(255),
    @prix INT
AS
INSERT INTO [BOISSONS]
(
    [idBoisson],
    [nomBoisson],
    [prix]
)
VALUES
(
    @idBoisson,
    @nomBoisson,
    @prix
);