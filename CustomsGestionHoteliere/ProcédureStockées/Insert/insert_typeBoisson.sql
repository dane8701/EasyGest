CREATE PROCEDURE insert_typeBoisson
    @idTypeBoisson INT,
    @BOISSONSidBoisson VARCHAR(255)
AS
INSERT INTO [TypeBoissons]
(
    [idTypeBoisson],
    [BOISSONSidBoisson]
)
VALUES
(
    @idTypeBoisson,
    @BOISSONSidBoisson
);