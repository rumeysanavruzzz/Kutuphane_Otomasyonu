IF OBJECT_ID('Admin', 'U') IS NULL
CREATE TABLE Admin (
    adminID INT IDENTITY(1,1) PRIMARY KEY,
    adminAd NVARCHAR(25) NOT NULL,
    adminSoyad NVARCHAR(45) NOT NULL,
    adminSifre NVARCHAR(25) NOT NULL,
    adminTcNo CHAR(11) NOT NULL UNIQUE,
    adminEposta NVARCHAR(45) NOT NULL UNIQUE,
    adminCepTelefon CHAR(10) NOT NULL UNIQUE,
    adminAdres NVARCHAR(45) NOT NULL,
    CONSTRAINT ck_adminSifre CHECK (
        LEN(adminSifre) >= 8 AND 
        adminSifre LIKE '%[0-9]%' AND 
        adminSifre LIKE '%[A-Z]%' AND 
        adminSifre LIKE '%[a-z]%'
    ),
    CONSTRAINT ck_adminTc CHECK (adminTcNo LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    CONSTRAINT ck_adminCeptelefon CHECK (adminCepTelefon LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);

IF OBJECT_ID('Personel', 'U') IS NULL
CREATE TABLE Personel (
    personelID INT IDENTITY(1,1) PRIMARY KEY,
    personelAd NVARCHAR(25) NOT NULL,
    personelSoyad NVARCHAR(45) NOT NULL,
    personelSifre NVARCHAR(25) NOT NULL,
    personelTcNo CHAR(11) NOT NULL UNIQUE,
    personelEposta NVARCHAR(45) NOT NULL UNIQUE,
    personelCepTelefon CHAR(10) NOT NULL UNIQUE,
    personelAdres NVARCHAR(45) NOT NULL,
    CONSTRAINT ck_personelSifre CHECK (
        LEN(personelSifre) >= 8 AND 
        personelSifre LIKE '%[0-9]%' AND 
        personelSifre LIKE '%[A-Z]%' AND 
        personelSifre LIKE '%[a-z]%'
    ),
    CONSTRAINT ck_personelTc CHECK (personelTcNo LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    CONSTRAINT ck_personelCeptelefon CHECK (personelCepTelefon LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);

IF OBJECT_ID('Uye', 'U') IS NULL
CREATE TABLE Uye (
    uyeID INT IDENTITY(1,1) PRIMARY KEY,
    uyeKullaniciAd NVARCHAR(25) NOT NULL,
    uyeKullaniciSoyad NVARCHAR(25) NOT NULL,
    uyeEposta NVARCHAR(45) NOT NULL UNIQUE,
    uyeCepTelefon CHAR(10) NOT NULL,
    uyeTcNo CHAR(11) NOT NULL UNIQUE,
    uyeCeza MONEY NOT NULL DEFAULT 0,
    uyeAdres NVARCHAR(45) NOT NULL,
    CONSTRAINT ck_uyeCepTelefon CHECK (uyeCepTelefon LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    CONSTRAINT ck_uyeTcNo CHECK (uyeTcNo LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);

IF OBJECT_ID('Kutuphane', 'U') IS NULL
CREATE TABLE Kutuphane (
    kutuphaneID TINYINT NOT NULL PRIMARY KEY,
    kutuphaneAd NVARCHAR(30) NOT NULL,
    kutuphaneAdres NVARCHAR(60) NOT NULL,
    kutuphaneCepTelefon CHAR(10) NOT NULL,
    CONSTRAINT ck_kutuphaneCepTelefon CHECK (kutuphaneCepTelefon LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);

IF OBJECT_ID('Kitap', 'U') IS NULL
CREATE TABLE Kitap (
    demirbasID INT IDENTITY(1,1) PRIMARY KEY,
    kitapAd NVARCHAR(50) NOT NULL,
    kategoriAd NVARCHAR(50) NOT NULL,
    baskiNo SMALLINT,
    ISBN CHAR(17) NOT NULL UNIQUE,
    gelisFiyat MONEY NOT NULL,
    girisTarih DATETIME DEFAULT GETDATE(),
    kutuphaneID TINYINT NOT NULL,
    CONSTRAINT fk_kutuphane FOREIGN KEY (kutuphaneID) REFERENCES Kutuphane(kutuphaneID),
    CONSTRAINT ck_ISBN CHECK (ISBN LIKE '[0-9][0-9][0-9]-[0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'),
    raftaDurum BIT NOT NULL CONSTRAINT ck_raftaDurum CHECK (raftaDurum IN (0, 1)),
    yazarAd NVARCHAR(25) NOT NULL,
    yazarSoyad NVARCHAR(25) NOT NULL,
    basimYil DATE NOT NULL,
    sayfaSayi INT NOT NULL,
    yayinEvi NVARCHAR(50) NOT NULL,

);

IF OBJECT_ID('Islem', 'U') IS NULL
CREATE TABLE Islem (
    islemID INT IDENTITY(1,1) PRIMARY KEY,
    personelID INT DEFAULT NULL,
    demirbasID INT NOT NULL,
    uyeID INT NOT NULL,
    emanetAlmaTarih SMALLDATETIME DEFAULT GETDATE(),
    iadeTarih SMALLDATETIME DEFAULT GETDATE(),
    islemDurumu BIT NOT NULL DEFAULT 0,
    islemAciklama NVARCHAR(100),
    adminID INT DEFAULT NULL,
    CONSTRAINT fk_personelID FOREIGN KEY (personelID) REFERENCES Personel(personelID),
    CONSTRAINT fk_demirbasID FOREIGN KEY (demirbasID) REFERENCES Kitap(demirbasID),
    CONSTRAINT fk_uyeID FOREIGN KEY (uyeID) REFERENCES Uye(uyeID) ON DELETE CASCADE,
    CONSTRAINT fk_adminID FOREIGN KEY (adminID) REFERENCES Admin(adminID)
);

IF OBJECT_ID('SilinmisUyeKayitlari', 'U') IS NULL
CREATE TABLE SilinmisUyeKayitlari (
    silinmisUyeID INT IDENTITY(1,1) PRIMARY KEY,
    uyeID INT NOT NULL,
    uyeKullaniciAd NVARCHAR(25) NOT NULL,
    uyeKullaniciSoyad NVARCHAR(25) NOT NULL,
    uyeEposta NVARCHAR(45) NOT NULL,
    uyeCepTelefon CHAR(10) NOT NULL,
    uyeTcNo CHAR(11) NOT NULL,
    uyeAdres NVARCHAR(45) NOT NULL,
    uyeCeza MONEY NOT NULL DEFAULT 0,
    silinmeTarihi DATETIME NOT NULL DEFAULT GETDATE()
);


IF OBJECT_ID('trg_Uye_Delete', 'TR') IS NOT NULL
BEGIN
    PRINT 'Trigger trg_Uye_Delete mevcut. Önce kaldýrýlýyor.';
    DROP TRIGGER trg_Uye_Delete;
END
GO  -- Bu satýr batch'leri ayýrýr

-- Burada yeni bir batch baþlatýyoruz
CREATE TRIGGER trg_Uye_Delete
ON Uye
AFTER DELETE
AS
BEGIN
    -- Silinen üyeyi SilinmisUyeKayitlari tablosuna ekle
    INSERT INTO SilinmisUyeKayitlari (
        uyeID, 
        uyeKullaniciAd, 
        uyeKullaniciSoyad, 
        uyeEposta, 
        uyeCepTelefon, 
        uyeTcNo, 
        uyeAdres, 
        uyeCeza, 
        silinmeTarihi
    )
    SELECT 
        uyeID, 
        uyeKullaniciAd, 
        uyeKullaniciSoyad, 
        uyeEposta, 
        uyeCepTelefon, 
        uyeTcNo, 
        uyeAdres, 
        uyeCeza, 
        GETDATE() -- Silinme tarihi olarak mevcut tarihi ekle
    FROM DELETED;
END;

GO
-- Eðer tetikleyici varsa, sil
IF OBJECT_ID('trg_RaftaDurumGuncelle_0', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER trg_RaftaDurumGuncelle_0;
    PRINT 'Eski tetikleyici silindi.';
END


GO
-- Yeni tetikleyiciyi oluþtur
CREATE TRIGGER trg_RaftaDurumGuncelle_0
ON Islem
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Yeni eklenen iþlem kaydý için demirbaþýn raftaDurum'unu 0 yap
    UPDATE Kitap
    SET raftaDurum = 0
    WHERE demirbasID IN (SELECT demirbasID FROM inserted);
END;
GO

GO
-- Eðer trigger varsa, sil
IF OBJECT_ID('trg_RaftaDurumGuncelle_1', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER trg_RaftaDurumGuncelle_1;
    PRINT 'Eski trigger silindi.';
END
GO

-- Yeni trigger oluþtur
CREATE TRIGGER trg_RaftaDurumGuncelle_1
ON Islem
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Yeni eklenen iþlem kaydý için demirbaþýn raftaDurum'unu 1 yap
    UPDATE Kitap
    SET raftaDurum = 1
    WHERE demirbasID IN (SELECT demirbasID FROM inserted);
END;
GO

IF OBJECT_ID('dbo.trg_KitapGeriAlmaCeza', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER dbo.trg_KitapGeriAlmaCeza;
    PRINT 'Trigger trg_KitapGeriAlmaCeza silindi.';
END;
GO

-- Yeni trigger oluþtur
CREATE TRIGGER trg_KitapGeriAlmaCeza
ON Kitap
AFTER UPDATE
AS
BEGIN
    -- Trigger içinde kullanýlan deðiþkenler
    DECLARE @demirbasID INT, @uyeID INT, @emanetAlmaTarih DATETIME, @iadeTarih DATETIME;
    DECLARE @gecikmeSuresi INT, @ceza MONEY, @cezaKatsayisi MONEY;

    -- Güncellenen kitap bilgilerini al
    SELECT @demirbasID = demirbasID FROM INSERTED;

    -- Eðer raftaDurum 1 olarak güncellenmiþse (kitap geri alýnmýþ demek)
    IF EXISTS (SELECT 1 FROM INSERTED WHERE raftaDurum = 1)
    BEGIN
        -- Ýlgili iþlem kaydýný al
        SELECT @uyeID = uyeID, @emanetAlmaTarih = emanetAlmaTarih, @iadeTarih = iadeTarih
        FROM Islem
        WHERE demirbasID = @demirbasID AND islemDurumu = 1;

        -- Veriþ tarihi boþsa iþlem tamamlanmamýþ demektir
        IF @iadeTarih IS NULL
        BEGIN
            UPDATE Islem
            SET iadeTarih = GETDATE()
            WHERE demirbasID = @demirbasID AND islemDurumu = 1;
        END;

        -- Gecikme süresini hesapla
        SET @gecikmeSuresi = DATEDIFF(DAY, @emanetAlmaTarih, GETDATE());

        -- Gecikme süresi 15 günden fazla ise ceza hesapla
        IF @gecikmeSuresi > 15
        BEGIN
            SET @cezaKatsayisi = 5; -- Günlük ceza oraný
            SET @ceza = (@gecikmeSuresi - 15) * @cezaKatsayisi;

            -- Üyenin cezasýný güncelle
            UPDATE Uye
            SET uyeCeza = uyeCeza + @ceza
            WHERE uyeID = @uyeID;
        END;
    END;
END;
GO

IF OBJECT_ID('IslemEkle', 'P') IS NOT NULL
    DROP PROCEDURE IslemEkle;
GO

CREATE PROCEDURE IslemEkle
    @personelID INT = NULL,     -- Ýþlem yapan personel (opsiyonel)
    @demirbasID INT,            -- Ýþlemde kullanýlan kitap (demirbaþID)
    @uyeID INT,                 -- Ýþlemde yer alan üye
    @islemDurumu BIT = 0,       -- Ýþlem durumu (varsayýlan 0: aktif)
    @islemAciklama NVARCHAR(100) = NULL, -- Ýþlem açýklamasý (opsiyonel)
    @adminID INT = NULL         -- Ýþlemde yer alan admin (opsiyonel)
AS
BEGIN
    BEGIN TRY
        INSERT INTO Islem
            (personelID, demirbasID, uyeID, emanetAlmaTarih, iadeTarih, islemDurumu, islemAciklama, adminID)
        VALUES
            (@personelID, @demirbasID, @uyeID, GETDATE(), GETDATE(), @islemDurumu, @islemAciklama, @adminID);
        
        PRINT 'Ýþlem baþarýyla eklendi.';
    END TRY
    BEGIN CATCH
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('dbo.IslemGuncelle', 'P') IS NOT NULL
    DROP PROCEDURE dbo.IslemGuncelle;
GO  -- 'GO' komutu burada olmalý

CREATE PROCEDURE dbo.IslemGuncelle
    @islemID INT,              -- Güncellenecek iþlemin ID'si
    @personelID INT = NULL,    -- Ýþlem yapan personel (opsiyonel)
    @demirbasID INT = NULL,    -- Ýþlemdeki kitap (opsiyonel)
    @uyeID INT = NULL,         -- Ýþlemdeki üye (opsiyonel)
    @islemDurumu BIT = NULL,   -- Ýþlem durumu (opsiyonel)
    @islemAciklama NVARCHAR(100) = NULL, -- Ýþlem açýklamasý (opsiyonel)
    @adminID INT = NULL        -- Admin (opsiyonel)
AS
BEGIN
    BEGIN TRY
        -- Ýþlem kaydýnýn var olup olmadýðýný kontrol et
        IF NOT EXISTS (SELECT 1 FROM Islem WHERE islemID = @islemID)
        BEGIN
            RAISERROR('Belirtilen iþlem ID ile bir kayýt bulunamadý.', 16, 1);
            RETURN;
        END;

        -- Ýþlem kaydýný güncelle
        UPDATE Islem
        SET 
            personelID = ISNULL(@personelID, personelID),
            demirbasID = ISNULL(@demirbasID, demirbasID),
            uyeID = ISNULL(@uyeID, uyeID),
            islemDurumu = ISNULL(@islemDurumu, islemDurumu),
            islemAciklama = ISNULL(@islemAciklama, islemAciklama),
            adminID = ISNULL(@adminID, adminID)
        WHERE islemID = @islemID;

        -- Baþarý mesajý
        PRINT 'Ýþlem baþarýyla güncellendi.';
    END TRY
    BEGIN CATCH
        -- Hata detaylarýný yakala ve kullanýcýya göster
        DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT;
        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END;
GO


IF OBJECT_ID('IslemSil', 'P') IS NOT NULL
    DROP PROCEDURE IslemSil;
GO

CREATE PROCEDURE IslemSil
    @islemID INT  -- Silinecek iþlemin ID'si
AS
BEGIN
    BEGIN TRY
        -- Silinen iþlemi loglamak için bir iþlem kaydýný log tablosuna aktarabilirsiniz. Ancak bu örnekte sadece silme iþlemi yapýlacak.
        
        DELETE FROM Islem
        WHERE islemID = @islemID;
        
        PRINT 'Ýþlem baþarýyla silindi.';
    END TRY
    BEGIN CATCH
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('UyeEkle', 'P') IS NOT NULL
    DROP PROCEDURE UyeEkle;
GO

CREATE PROCEDURE UyeEkle
    @uyeKullaniciAd NVARCHAR(25),
    @uyeKullaniciSoyad NVARCHAR(25),
    @uyeEposta NVARCHAR(45),
    @uyeCepTelefon CHAR(10),
    @uyeTcNo CHAR(11),
    @uyeAdres NVARCHAR(45),
    @uyeCeza MONEY = 0 -- Ceza parametresi opsiyonel, varsayýlan deðeri 0
AS
BEGIN
    BEGIN TRY
        INSERT INTO Uye
            (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeAdres, uyeCeza)
        VALUES
            (@uyeKullaniciAd, @uyeKullaniciSoyad, @uyeEposta, @uyeCepTelefon, @uyeTcNo, @uyeAdres, @uyeCeza);
        
        PRINT 'Üye baþarýyla eklendi.';
    END TRY
    BEGIN CATCH
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


IF OBJECT_ID('sp_UyeGuncelle', 'P') IS NOT NULL
    DROP PROCEDURE sp_UyeGuncelle;
GO

-- Üye bilgilerini güncelleyen stored procedure'ü oluþtur
CREATE PROCEDURE sp_UyeGuncelle
    @uyeID INT,                  -- Güncellenecek üyenin ID'si
    @uyeKullaniciAd NVARCHAR(25) = NULL,
    @uyeKullaniciSoyad NVARCHAR(25) = NULL,
    @uyeEposta NVARCHAR(45) = NULL,
    @uyeCepTelefon CHAR(10) = NULL,
    @uyeTcNo CHAR(11) = NULL,
    @uyeAdres NVARCHAR(45) = NULL,
    @uyeCeza MONEY = NULL
AS
BEGIN
    BEGIN TRY
        -- @uyeID ile mevcut bir üye var mý kontrolü
        IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeID = @uyeID)
        BEGIN
            PRINT 'Belirtilen ID ile üye bulunamadý.';
            RETURN;
        END

        -- Üye bilgilerini güncelle
        UPDATE Uye
        SET
            uyeKullaniciAd = COALESCE(@uyeKullaniciAd, uyeKullaniciAd),
            uyeKullaniciSoyad = COALESCE(@uyeKullaniciSoyad, uyeKullaniciSoyad),
            uyeEposta = COALESCE(@uyeEposta, uyeEposta),
            uyeCepTelefon = COALESCE(@uyeCepTelefon, uyeCepTelefon),
            uyeTcNo = COALESCE(@uyeTcNo, uyeTcNo),
            uyeAdres = COALESCE(@uyeAdres, uyeAdres),
            uyeCeza = COALESCE(@uyeCeza, uyeCeza)
        WHERE uyeID = @uyeID;

        PRINT 'Üye bilgileri baþarýyla güncellendi.';
    END TRY
    BEGIN CATCH
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('sp_UyeSil', 'P') IS NOT NULL
    DROP PROCEDURE sp_UyeSil;
GO

-- Üye silme iþlemi için stored procedure'ü oluþtur
CREATE PROCEDURE sp_UyeSil
    @uyeID INT  -- Silinecek üyenin ID'si
AS
BEGIN
    BEGIN TRY
        -- Silinen üyenin bilgilerini SilinmisUyeKayitlari tablosuna ekleyelim
        INSERT INTO SilinmisUyeKayitlari
            (uyeID, uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeAdres, uyeCeza)
        SELECT uyeID, uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeAdres, uyeCeza
        FROM Uye
        WHERE uyeID = @uyeID;

        -- Üyeyi Uye tablosundan silelim
        DELETE FROM Uye
        WHERE uyeID = @uyeID;

        PRINT 'Üye baþarýyla silindi.';
    END TRY
    BEGIN CATCH
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('KitapEkle', 'P') IS NOT NULL
    DROP PROCEDURE KitapEkle;
GO

CREATE PROCEDURE KitapEkle
    @kitapAd NVARCHAR(50),
    @kategoriAd NVARCHAR(50),
    @baskiNo SMALLINT,
    @ISBN CHAR(17),
    @gelisFiyat MONEY,
    @kutuphaneID TINYINT,
    @raftaDurum BIT,
    @yazarAd NVARCHAR(25),
    @yazarSoyad NVARCHAR(25),
    @basimYil DATE,
    @sayfaSayi INT,
    @yayinEvi NVARCHAR(50)
AS
BEGIN
    BEGIN TRY
        INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
        VALUES (@kitapAd, @kategoriAd, @baskiNo, @ISBN, @gelisFiyat, @kutuphaneID, @raftaDurum, @yazarAd, @yazarSoyad, @basimYil, @sayfaSayi, @yayinEvi);
        
        PRINT 'Kitap baþarýyla eklendi.';
    END TRY
    BEGIN CATCH
        PRINT 'Hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


IF OBJECT_ID('KitapGuncelle', 'P') IS NOT NULL
    DROP PROCEDURE KitapGuncelle;
GO

CREATE PROCEDURE KitapGuncelle
    @demirbasID INT,
    @kitapAd NVARCHAR(50),
    @kategoriAd NVARCHAR(50),
    @baskiNo SMALLINT,
    @ISBN CHAR(17),
    @gelisFiyat MONEY,
    @kutuphaneID TINYINT,
    @yazarAd NVARCHAR(25),
    @yazarSoyad NVARCHAR(25),
    @basimYil DATE,
    @sayfaSayi INT,
    @yayinEvi NVARCHAR(50),
    @toplamKitap SMALLINT,
    @raftaDurum BIT
AS
BEGIN
    BEGIN TRY
        -- Kitap var mý kontrolü
        IF NOT EXISTS (SELECT 1 FROM Kitap WHERE demirbasID = @demirbasID)
        BEGIN
            PRINT 'Belirtilen demirbaþ ID ile eþleþen kitap bulunamadý.';
            RETURN;
        END

        -- Kitap bilgilerini güncelle
        UPDATE Kitap
        SET 
            kitapAd = @kitapAd,
            kategoriAd = @kategoriAd,
            baskiNo = @baskiNo,
            ISBN = @ISBN,
            gelisFiyat = @gelisFiyat,
            kutuphaneID = @kutuphaneID,
            yazarAd = @yazarAd,
            yazarSoyad = @yazarSoyad,
            basimYil = @basimYil,
            sayfaSayi = @sayfaSayi,
            yayinEvi = @yayinEvi,
            raftaDurum = @raftaDurum
        WHERE demirbasID = @demirbasID;

        PRINT 'Kitap baþarýyla güncellendi.';
    END TRY
    BEGIN CATCH
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('KitapSil', 'P') IS NOT NULL
    DROP PROCEDURE KitapSil;
GO

CREATE PROCEDURE KitapSil
    @demirbasID INT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Kitap WHERE demirbasID = @demirbasID)
        BEGIN
            DELETE FROM Kitap WHERE demirbasID = @demirbasID;
            PRINT 'Kitap baþarýyla silindi.';
        END
        ELSE
        BEGIN
            PRINT 'Silinmek istenen kitap bulunamadý.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


IF OBJECT_ID('AdminEkle', 'P') IS NOT NULL
    DROP PROCEDURE AdminEkle;
GO

CREATE PROCEDURE AdminEkle
    @adminAd NVARCHAR(25),
    @adminSoyad NVARCHAR(45),
    @adminSifre NVARCHAR(25),
    @adminTcNo CHAR(11),
    @adminEposta NVARCHAR(45),
    @adminCepTelefon CHAR(10),
    @adminAdres NVARCHAR(45)
AS
BEGIN
    BEGIN TRY
        -- Ayný TC veya e-posta adresine sahip bir admin var mý kontrol et
        IF EXISTS (SELECT 1 FROM Admin WHERE adminTcNo = @adminTcNo OR adminEposta = @adminEposta)
        BEGIN
            PRINT 'Bu TC kimlik numarasý veya e-posta ile bir kayýt zaten mevcut.';
        END
        ELSE
        BEGIN
            -- Yeni admin ekle
            INSERT INTO Admin (adminAd, adminSoyad, adminSifre, adminTcNo, adminEposta, adminCepTelefon, adminAdres)
            VALUES (@adminAd, @adminSoyad, @adminSifre, @adminTcNo, @adminEposta, @adminCepTelefon, @adminAdres);

            PRINT 'Admin baþarýyla eklendi.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Hata: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('AdminGuncelle', 'P') IS NOT NULL
    DROP PROCEDURE AdminGuncelle;
GO

CREATE PROCEDURE AdminGuncelle
    @adminID INT,
    @adminAd NVARCHAR(25),
    @adminSoyad NVARCHAR(45),
    @adminSifre NVARCHAR(25),
    @adminTcNo CHAR(11),
    @adminEposta NVARCHAR(45),
    @adminCepTelefon CHAR(10),
    @adminAdres NVARCHAR(45)
AS
BEGIN
    BEGIN TRY
        -- Admin ID'si ile kayýt var mý kontrol et
        IF EXISTS (SELECT 1 FROM Admin WHERE adminID = @adminID)
        BEGIN
            -- Admin bilgilerini güncelle
            UPDATE Admin
            SET
                adminAd = @adminAd,
                adminSoyad = @adminSoyad,
                adminSifre = @adminSifre,
                adminTcNo = @adminTcNo,
                adminEposta = @adminEposta,
                adminCepTelefon = @adminCepTelefon,
                adminAdres = @adminAdres
            WHERE adminID = @adminID;

            PRINT 'Admin bilgileri baþarýyla güncellendi.';
        END
        ELSE
        BEGIN
            PRINT 'Güncelleme baþarýsýz: Belirtilen adminID ile bir kayýt bulunamadý.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Hata: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('AdminSil', 'P') IS NOT NULL
    DROP PROCEDURE AdminSil;
GO

CREATE PROCEDURE AdminSil
    @adminID INT
AS
BEGIN
    BEGIN TRY
        -- Admin ID'si ile kayýt var mý kontrol et
        IF EXISTS (SELECT 1 FROM Admin WHERE adminID = @adminID)
        BEGIN
            -- Admin'i sil
            DELETE FROM Admin WHERE adminID = @adminID;

            PRINT 'Admin baþarýyla silindi.';
        END
        ELSE
        BEGIN
            PRINT 'Silme iþlemi baþarýsýz: Belirtilen adminID ile bir kayýt bulunamadý.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Hata: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('PersonelEkle', 'P') IS NOT NULL
    DROP PROCEDURE PersonelEkle;
GO

CREATE PROCEDURE PersonelEkle
    @personelAd NVARCHAR(25),
    @personelSoyad NVARCHAR(45),
    @personelSifre NVARCHAR(25),
    @personelTcNo CHAR(11),
    @personelEposta NVARCHAR(45),
    @personelCepTelefon CHAR(10),
    @personelAdres NVARCHAR(45)
AS
BEGIN
    BEGIN TRY
        -- Personel TC No veya E-posta adresi ile daha önce bir kayýt olup olmadýðýný kontrol et
        IF EXISTS (SELECT 1 FROM Personel WHERE personelTcNo = @personelTcNo)
        BEGIN
            PRINT 'Bu TC No ile zaten bir personel kaydý bulunmaktadýr.';
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM Personel WHERE personelEposta = @personelEposta)
        BEGIN
            PRINT 'Bu e-posta ile zaten bir personel kaydý bulunmaktadýr.';
            RETURN;
        END

        -- Personel ekleme iþlemi
        INSERT INTO Personel (
            personelAd, personelSoyad, personelSifre, personelTcNo, 
            personelEposta, personelCepTelefon, personelAdres
        )
        VALUES (
            @personelAd, @personelSoyad, @personelSifre, @personelTcNo, 
            @personelEposta, @personelCepTelefon, @personelAdres
        );

        PRINT 'Personel baþarýyla eklendi.';
    END TRY
    BEGIN CATCH
        PRINT 'Hata: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('PersonelGuncelle', 'P') IS NOT NULL
    DROP PROCEDURE PersonelGuncelle;
GO

CREATE PROCEDURE PersonelGuncelle
    @personelID INT,
    @personelAd NVARCHAR(25),
    @personelSoyad NVARCHAR(45),
    @personelSifre NVARCHAR(25),
    @personelTcNo CHAR(11),
    @personelEposta NVARCHAR(45),
    @personelCepTelefon CHAR(10),
    @personelAdres NVARCHAR(45)
AS
BEGIN
    BEGIN TRY
        -- Mevcut TC No ve E-posta adresi ile baþka bir kaydýn olup olmadýðýný kontrol et
        IF EXISTS (SELECT 1 FROM Personel WHERE personelTcNo = @personelTcNo AND personelID != @personelID)
        BEGIN
            PRINT 'Bu TC No ile baþka bir personel kaydý bulunmaktadýr.';
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM Personel WHERE personelEposta = @personelEposta AND personelID != @personelID)
        BEGIN
            PRINT 'Bu e-posta ile baþka bir personel kaydý bulunmaktadýr.';
            RETURN;
        END

        -- Personel bilgilerini güncelle
        UPDATE Personel
        SET
            personelAd = @personelAd,
            personelSoyad = @personelSoyad,
            personelSifre = @personelSifre,
            personelTcNo = @personelTcNo,
            personelEposta = @personelEposta,
            personelCepTelefon = @personelCepTelefon,
            personelAdres = @personelAdres
        WHERE personelID = @personelID;

        PRINT 'Personel bilgileri baþarýyla güncellendi.';
    END TRY
    BEGIN CATCH
        PRINT 'Hata: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('PersonelSil', 'P') IS NOT NULL
    DROP PROCEDURE PersonelSil;
GO

CREATE PROCEDURE PersonelSil
    @personelID INT
AS
BEGIN
    BEGIN TRY
        -- Personelin herhangi bir iþlem kaydýna baðlý olup olmadýðýný kontrol et
        IF EXISTS (SELECT 1 FROM Islem WHERE personelID = @personelID)
        BEGIN
            PRINT 'Bu personel kaydý, iþlem kayýtlarýna baðlý olduðu için silinemez.';
            RETURN;
        END

        -- Personel kaydýný sil
        DELETE FROM Personel WHERE personelID = @personelID;

        PRINT 'Personel baþarýyla silindi.';
    END TRY
    BEGIN CATCH
        PRINT 'Hata: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('KitapAdAra', 'P') IS NOT NULL
    DROP PROCEDURE KitapAdAra;
GO

CREATE PROCEDURE KitapAdAra
    @kitapAd NVARCHAR(50)  -- Aranacak kitap adý
AS
BEGIN
    BEGIN TRY
        -- Kitap adýyla arama
        SELECT 
            demirbasID, 
            kitapAd, 
            kategoriAd, 
            baskiNo, 
            ISBN, 
            gelisFiyat, 
            girisTarih, 
            kutuphaneID, 
            yazarAd, 
            yazarSoyad, 
            basimYil, 
            sayfaSayi, 
            yayinEvi
        FROM Kitap
        WHERE kitapAd LIKE '%' + @kitapAd + '%';  -- Kitap adý içinde arama
    END TRY
    BEGIN CATCH
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();  -- Hata mesajý
    END CATCH
END;
GO


IF OBJECT_ID('dbo.KitapYazarAra', 'P') IS NOT NULL
    DROP PROCEDURE dbo.KitapYazarAra;
GO

CREATE PROCEDURE dbo.KitapYazarAra
    @yazarAdi NVARCHAR(50)  -- Aranacak yazar adý
AS
BEGIN
    BEGIN TRY
        -- Kitaplarda yazar adýyla arama
        SELECT 
            demirbasID, 
            kitapAd, 
            kategoriAd, 
            baskiNo, 
            ISBN, 
            gelisFiyat, 
            girisTarih, 
            kutuphaneID, 
            yazarAd, 
            yazarSoyad, 
            basimYil, 
            sayfaSayi, 
            yayinEvi
        FROM 
            Kitap
        WHERE 
            yazarAd LIKE '%' + @yazarAdi + '%';  -- Yazar adý içinde arama

        -- Eðer eþleþen sonuç yoksa, bilgilendirme mesajý
        IF @@ROWCOUNT = 0
            PRINT 'Eþleþen kayýt bulunamadý.';
    END TRY
    BEGIN CATCH
        -- Hata mesajý
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO



IF OBJECT_ID('dbo.KitapYazarSoyadAra', 'P') IS NOT NULL
    DROP PROCEDURE dbo.KitapYazarSoyadAra;
GO

CREATE PROCEDURE dbo.KitapYazarSoyadAra
    @yazarSoyad NVARCHAR(50)  -- Aranacak yazar soyadý
AS
BEGIN
    BEGIN TRY
        -- Kitaplarda yazar soyadýyla arama
        SELECT 
            demirbasID, 
            kitapAd, 
            kategoriAd, 
            baskiNo, 
            ISBN, 
            gelisFiyat, 
            girisTarih, 
            kutuphaneID, 
            yazarAd, 
            yazarSoyad, 
            basimYil, 
            sayfaSayi, 
            yayinEvi
        FROM 
            Kitap
        WHERE 
            yazarSoyad LIKE '%' + @yazarSoyad + '%';  -- Yazar soyadý içinde arama

        -- Eðer eþleþen sonuç yoksa, bilgilendirme mesajý
        IF @@ROWCOUNT = 0
            PRINT 'Eþleþen kayýt bulunamadý.';
    END TRY
    BEGIN CATCH
        -- Hata mesajý
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


IF OBJECT_ID('dbo.KategoriAdAra', 'P') IS NOT NULL
    DROP PROCEDURE dbo.KategoriAdAra;
GO

IF OBJECT_ID('dbo.KategoriAdAra', 'P') IS NOT NULL
    DROP PROCEDURE dbo.KategoriAdAra;
GO

CREATE PROCEDURE dbo.KategoriAdAra
    @kategoriAd NVARCHAR(50) -- Arama yapýlacak kategori adý
AS
BEGIN
    BEGIN TRY
        -- Kategori adý ile kitaplarý arama
        SELECT 
            demirbasID, 
            kitapAd, 
            kategoriAd, 
            baskiNo, 
            ISBN, 
            gelisFiyat, 
            girisTarih, 
            kutuphaneID, 
            raftaDurum, 
            yazarAd, 
            yazarSoyad, 
            basimYil, 
            sayfaSayi, 
            yayinEvi
        FROM 
            Kitap
        WHERE 
            kategoriAd LIKE '%' + @kategoriAd + '%';  -- Kategori adý içinde arama

        -- Sonuç kontrolü
        IF @@ROWCOUNT = 0
            PRINT 'Eþleþen kategori bulunamadý.';
    END TRY
    BEGIN CATCH
        -- Hata mesajý
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


IF OBJECT_ID('dbo.YayinEviAra', 'P') IS NOT NULL
    DROP PROCEDURE dbo.YayinEviAra;
GO

CREATE PROCEDURE dbo.YayinEviAra
    @yayinEvi NVARCHAR(50) -- Arama yapýlacak yayýnevi adý
AS
BEGIN
    BEGIN TRY
        -- Yayýnevi adý ile kitaplarý arama
        SELECT 
            demirbasID, 
            kitapAd, 
            kategoriAd, 
            baskiNo, 
            ISBN, 
            gelisFiyat, 
            girisTarih, 
            kutuphaneID, 
            raftaDurum, 
            yazarAd, 
            yazarSoyad, 
            basimYil, 
            sayfaSayi, 
            yayinEvi
        FROM Kitap
        WHERE yayinEvi LIKE '%' + @yayinEvi + '%';  -- Yayýnevi adý içinde arama

        -- Sonuç kontrolü
        IF @@ROWCOUNT = 0
            PRINT 'Eþleþen yayýnevi bulunamadý.';
    END TRY
    BEGIN CATCH
        -- Hata mesajý
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


