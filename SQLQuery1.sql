-- Creaz� tabelul Categories
CREATE TABLE Categories (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- Cheia primar� auto-incremental�
    Name NVARCHAR(100) NOT NULL         -- Numele categoriei, nu poate fi NULL
);

-- Insereaz� c�teva categorii
INSERT INTO Categories (Name) VALUES 
('Fiction'), 
('Non-Fiction'), 
('Science Fiction'), 
('Fantasy'), 
('Biography'), 
('Mystery'), 
('Self-Help');
