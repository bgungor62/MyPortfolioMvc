-- CREATE TABLE komutları
-- INDEX oluşturma komutları
-- CONSTRAINT ekleme komutları

-- SERIAL: otomatik artan integer değerleri için kullanılır
-- RETURNING: INSERT, UPDATE gibi komutların ardından etkilenen satırları döndürmek için kullanılır
-- TEXT :sınırsız uzunlukta metin verisi için kullanılır
-- BOOLEAN: true/false değerleri için kullanılır
-- About Tablosu: Hakkımda bilgilerini tutar
CREATE TABLE IF NOT EXISTS About(
	Id SERIAL PRIMARY KEY,
	Title VARCHAR(200) NOT NULL,
	Description TEXT,
	ImageUrl VARCHAR(500),
	CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	UpdatedAt TIMESTAMP 
)
-- Skills Tablosu: Yetenek bilgilerini tutar
CREATE TABLE IF NOT EXISTS Skill(
	Id SERIAL PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
	Percentange INTEGER NOT NULL CHECK (Percentange >= 0 AND Percentange <= 100),
	DisplayOrder INTEGER NOT NULL DEFAULT 0,
	CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
)
-- Projects Tablosu: Yetenek bilgilerini tutar
CREATE TABLE IF NOT EXISTS Projects (
    Id SERIAL PRIMARY KEY,
    Title       VARCHAR(200) NOT NULL,
    Description TEXT,
    ImageUrl    VARCHAR(500),
    ProjectUrl  VARCHAR(500),
    GithubUrl   VARCHAR(500),
    CreatedAt   TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    IsActive    BOOLEAN NOT NULL DEFAULT TRUE
);
-- Testimonials Tablosu: Proje bilgilerini içerir
CREATE TABLE IF NOT EXISTS Projects (
    Id SERIAL PRIMARY KEY,
    Title VARCHAR(200) NOT NULL,
    Description TEXT,
    ImageUrl VARCHAR(500),
    ProjectUrl VARCHAR(500),
    GithubUrl VARCHAR(500),
    CreatedAt TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    IsActive  BOOLEAN NOT NULL DEFAULT TRUE
);
-- Testimonials Tablosu: Müşteri referanslarını içerir
CREATE TABLE IF NOT EXISTS Testimonials (
    Id SERIAL PRIMARY KEY,
    ClientName VARCHAR(100) NOT NULL,
    ClientPosition VARCHAR(100),
    ImageUrl VARCHAR(500),
    Comment TEXT NOT NULL,
    ClientImageUrl VARCHAR(500),
	Rating INTEGER NOT NULL CHECK (Rating>=1 AND Rating<=5)
    CreatedAt TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    IsActive BOOLEAN NOT NULL DEFAULT TRUE
);
-- Contact Tablosu: iletişim formu mesajlarını içerir
CREATE TABLE IF NOT EXISTS Contacts (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(500) NOT NULL,
    Subject VARCHAR(200),
    Message TEXT NOT NULL,
    ClientImageUrl VARCHAR(500),
    CreatedAt TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    IsRead BOOLEAN NOT NULL DEFAULT TRUE
);




