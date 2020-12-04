CREATE PROCEDURE insert_typePlat
    @idPlat INT,
    @nomPlat VARCHAR(255)
AS
INSERT INTO [TypePlats]
(
    [idPlat],
    [nomPlat]
)
VALUES
(
    @idPlat,
    @nomPlat
);