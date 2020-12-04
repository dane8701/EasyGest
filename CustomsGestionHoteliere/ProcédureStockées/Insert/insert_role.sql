CREATE PROCEDURE insert_role
    @idRole INT,
    @nomRole VARCHAR(255)
AS
INSERT INTO [ROLES]
(
    [idRole],
    [nomRole]
)
VALUES
(
    @idRole,
    @nomRole
);