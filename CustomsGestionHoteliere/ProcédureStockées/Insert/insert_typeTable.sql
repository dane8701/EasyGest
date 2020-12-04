CREATE PROCEDURE insert_typeTable
    @idTypeTable INT,
    @nomTypeTable VARCHAR(255)
AS
INSERT INTO [TypeTables]
(
    [idTypeTable],
    [nomTypeTable]
)
VALUES
(
    @idTypeTable,
    @nomTypeTable
);