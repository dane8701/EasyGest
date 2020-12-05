CREATE PROCEDURE search_utilisateur
    @nomUtilisateur VARCHAR(255)

AS
SELECT * from UTILISATEURS
where nomUtilisateur =  @nomUtilisateur