-- Insert sample admin user
INSERT INTO Users (Username, Email, PasswordHash, Role)
VALUES ('adminuser', 'admin@example.com', '$2y$12$D4cfN5Hd/sN0ZZNRZ/qw0u3G2DqNQrqhtahzFmuKzj9lBtpF1YuFi', 'Admin');

-- Insert sample regular user
INSERT INTO Users (Username, Email, PasswordHash, Role)
VALUES ('regularuser', 'user@example.com', '$2y$12$B6cfN8Hd/oS2ZHMSN/u1rzG3AopNQyqgtahzSmwKlj1mCzpM1YuA1', 'User');

-- Insert more test users if needed
INSERT INTO Users (Username, Email, PasswordHash, Role)
VALUES ('testuser', 'test@example.com', '$2y$12$A3cfN7Hd/pP0ZZLRF/qv0r3G5YpnQrqktaazDmxLpj9yBppF1LuPi', 'User');
