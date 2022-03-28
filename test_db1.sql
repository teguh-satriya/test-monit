SELECT u.name, u.name, u.departement 
FROM task t
INNER JOIN user_profile u ON t.owner_id = u.id
