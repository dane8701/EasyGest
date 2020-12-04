CREATE PROCEDURE insert_table
    @idTable INT,
    @nombrePlace INT,
    @TypeTableidTypeTable INT
AS
INSERT INTO [TABLES]
(
    [idTable],
    [nombrePlace],
    [TypeTableidTypeTable]
)
VALUES
(
    @idTable,
    @nombrePlace,
    @TypeTableidTypeTable
);