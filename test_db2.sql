SELECT u.name, count(t.id) as count
FROM user_profile u
LEFT JOIN task t ON t.owner_id = u.id
group by u.name
