CREATE USER 'BTGFRM'@'%' IDENTIFIED BY 'Qr0@94BTG#7';

GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, DROP, RELOAD, REFERENCES, INDEX, ALTER, SHOW DATABASES, CREATE TEMPORARY TABLES, LOCK TABLES ON *.* TO 'BTGFRM'@'%';

FLUSH PRIVILEGES;