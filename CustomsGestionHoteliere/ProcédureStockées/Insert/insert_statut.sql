CREATE PROCEDURE insert_statut
    @idStatut INT,
    @nomStatut VARCHAR(255)
AS
INSERT INTO [STATUTS]
(
    [idStatut],
    [nomStatut]
)
VALUES
(
    @idStatut,
    @nomStatut
);