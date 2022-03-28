SELECT u.name, count(t.id) as count
FROM user_profile u
LEFT JOIN task t ON t.owner_id = u.id
where t.done = false
group by u.name
