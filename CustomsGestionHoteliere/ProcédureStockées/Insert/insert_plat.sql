CREATE PROCEDURE insert_plat
    @idPlat INT,
    @nomPlat VARCHAR(255),
    @prix INT,
    @TypePlatidTypePlat INT
AS
INSERT INTO [PLATS]
(
    [idPlat],
    [nomPlat],
    [prix],
    [TypePlatidTypePlat]
)
VALUES
(
    @idPlat,
    @nomPlat,
    @prix,
    @TypePlatidTypePlat
);