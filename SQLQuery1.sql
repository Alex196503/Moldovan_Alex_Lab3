-- Creazã tabelul Categories
CREATE TABLE Categories (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- Cheia primarã auto-incrementalã
    Name NVARCHAR(100) NOT NULL         -- Numele categoriei, nu poate fi NULL
);

-- Insereazã câteva categorii
INSERT INTO Categories (Name) VALUES 
('Fiction'), 
('Non-Fiction'), 
('Science Fiction'), 
('Fantasy'), 
('Biography'), 
('Mystery'), 
('Self-Help');
