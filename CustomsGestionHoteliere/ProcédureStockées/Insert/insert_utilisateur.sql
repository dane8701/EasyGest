
CREATE PROCEDURE insert_utilisateur
    @idUtilisateur INT,
    @nomUtilisateur VARCHAR(255),
    @motDePasse VARCHAR(255),
    @telephone INT,
    @adresse VARCHAR(255),
    @statutidStatut INT
AS
INSERT INTO [UTILISATEURS]
(
    [idUtilisateur],
    [nomUtilisateur],
    [motDePasse],
    [telephone],
    [adresse],
    [statutidStatut]
)
VALUES
(
    @idUtilisateur,
    @nomUtilisateur,
    @motDePasse,
    @telephone,
    @adresse,
    @statutidStatut
);