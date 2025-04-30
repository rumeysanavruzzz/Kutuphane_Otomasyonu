USE kütüphaneOtomasyonu



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
        adminSifre LIKE '%[A-Z]%' COLLATE Latin1_General_BIN AND 
        adminSifre LIKE '%[a-z]%'
    ),
    CONSTRAINT ck_adminTc CHECK (
        adminTcNo LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
    ),
    CONSTRAINT ck_adminCepTelefon CHECK (
        adminCepTelefon LIKE '5[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
    ),
    CONSTRAINT ck_adminEposta CHECK (
        adminEposta LIKE '%@gmail.com'
    )
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
        personelSifre LIKE '%[A-Z]%' COLLATE Latin1_General_BIN AND 
        personelSifre LIKE '%[a-z]%'
    ),
    CONSTRAINT ck_personelTc CHECK (
        personelTcNo LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
    ),
    CONSTRAINT ck_personelCepTelefon CHECK (
        personelCepTelefon LIKE '5[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
    ),
    CONSTRAINT ck_personelEposta CHECK (
        personelEposta LIKE '%@gmail.com'
    )
);

IF OBJECT_ID('Uye', 'U') IS NULL
CREATE TABLE Uye (
    uyeID INT IDENTITY(1,1) PRIMARY KEY,
    uyeKullaniciAd NVARCHAR(25) NOT NULL,
    uyeKullaniciSoyad NVARCHAR(25) NOT NULL,
    uyeEposta NVARCHAR(45) NOT NULL UNIQUE,
    uyeCepTelefon CHAR(10) NOT NULL UNIQUE,
    uyeTcNo CHAR(11) NOT NULL UNIQUE,
    uyeCeza MONEY NOT NULL DEFAULT 0,
    uyeAdres NVARCHAR(45) NOT NULL,
    CONSTRAINT ck_uyeCepTelefon CHECK (uyeCepTelefon LIKE '5[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
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
    demirbasID INT NULL, -- Nullable hale getirildi
    uyeID INT NULL, -- Nullable hale getirildi
    emanetAlmaTarih SMALLDATETIME DEFAULT GETDATE(),
    iadeTarih SMALLDATETIME DEFAULT GETDATE(),
    islemDurumu BIT NOT NULL DEFAULT 0,
    islemAciklama NVARCHAR(100),
    adminID INT DEFAULT NULL,
    CONSTRAINT fk_personelID FOREIGN KEY (personelID) REFERENCES Personel(personelID) ON DELETE SET NULL,
    CONSTRAINT fk_demirbasID FOREIGN KEY (demirbasID) REFERENCES Kitap(demirbasID) ON DELETE SET NULL,
    CONSTRAINT fk_uyeID FOREIGN KEY (uyeID) REFERENCES Uye(uyeID) ON DELETE SET NULL,
    CONSTRAINT fk_adminID FOREIGN KEY (adminID) REFERENCES Admin(adminID) ON DELETE SET NULL
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
        -- Cep telefonunun 5 ile baþlamadýðýný ve 10 haneli olmadýðýný kontrol et
        IF @adminCepTelefon NOT LIKE '5[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
        BEGIN
            PRINT 'Hata: Cep telefonunun 5 ile baþlamasý ve 10 haneli olmasý gerekmektedir.';
            RETURN;
        END

        -- Þifrenin en az 8 karakter, bir büyük harf, bir küçük harf ve bir rakam içerip içermediðini kontrol et
        IF LEN(@adminSifre) < 8 OR 
           @adminSifre NOT LIKE '%[0-9]%' OR 
           @adminSifre NOT LIKE '%[A-Z]%' OR 
           @adminSifre NOT LIKE '%[a-z]%'
        BEGIN
            PRINT 'Hata: Þifre en az 8 karakter, bir büyük harf, bir küçük harf ve bir rakam içermelidir.';
            RETURN;
        END

        -- TC Kimlik Numarasýnýn 11 haneli ve sadece rakam içerip içermediðini kontrol et
        IF LEN(@adminTcNo) != 11 OR @adminTcNo NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
        BEGIN
            PRINT 'Hata: TC Kimlik Numarasý 11 haneli ve sadece rakamlardan oluþmalýdýr.';
            RETURN;
        END

        -- E-postanýn @gmail.com ile bitip bitmediðini kontrol et
        IF @adminEposta NOT LIKE '%@gmail.com'
        BEGIN
            PRINT 'Hata: E-posta adresi @gmail.com ile bitmelidir.';
            RETURN;
        END

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



IF OBJECT_ID('AdminleriListele', 'P') IS NOT NULL
    DROP PROCEDURE dbo.AdminleriListele;
GO

CREATE PROCEDURE AdminleriListele
AS
BEGIN
    SET NOCOUNT ON;

    -- Admin tablosundaki verileri seç
    SELECT 
        adminID,
        adminAd,
        adminSoyad,
        adminSifre,
        adminTcNo,
        adminEposta,
        adminCepTelefon,
        adminAdres
    FROM 
        Admin;
END;
GO


IF OBJECT_ID('AdminAdSoyadAra', 'P') IS NOT NULL
    DROP PROCEDURE dbo.AdminAdSoyadAra;
GO

CREATE PROCEDURE AdminAdSoyadAra
    @adminAd NVARCHAR(25) = NULL,   -- Aranacak admin adý (varsayýlan NULL)
    @adminSoyad NVARCHAR(45) = NULL  -- Aranacak admin soyadý (varsayýlan NULL)
AS
BEGIN
    BEGIN TRY
        -- Admin adý ve soyadý ile arama
        SELECT 
            adminID,
            adminAd, 
            adminSoyad,
			adminSifre,
            adminEposta, 
            adminCepTelefon, 
            adminTcNo, 
            adminAdres
        FROM Admin
        WHERE 
            (@adminAd IS NULL OR adminAd LIKE '%' + @adminAd + '%') AND
            (@adminSoyad IS NULL OR adminSoyad LIKE '%' + @adminSoyad + '%');

        -- Eþleþen kayýt yoksa
        IF @@ROWCOUNT = 0
            PRINT 'Eþleþen admin bulunamadý.';
    END TRY
    BEGIN CATCH
        -- Hata mesajý
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
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
        -- Cep telefonunun kontrolü: 5 ile baþlamalý ve 10 haneli olmalý
        IF @personelCepTelefon NOT LIKE '5[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
        BEGIN
            THROW 50001, 'Hata: Cep telefonu 5 ile baþlamalý ve 10 haneli olmalýdýr.', 1;
        END

        -- Þifrenin kontrolü: En az 8 karakter, bir büyük harf, bir küçük harf ve bir rakam içermeli
        IF LEN(@personelSifre) < 8 OR 
           @personelSifre NOT LIKE '%[0-9]%' OR 
           @personelSifre NOT LIKE '%[A-Z]%' OR 
           @personelSifre NOT LIKE '%[a-z]%'
        BEGIN
            THROW 50002, 'Hata: Þifre en az 8 karakter, bir büyük harf, bir küçük harf ve bir rakam içermelidir.', 1;
        END

        -- TC Kimlik Numarasý kontrolü: 11 haneli ve sadece rakamlardan oluþmalý
        IF LEN(@personelTcNo) != 11 OR @personelTcNo NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
        BEGIN
            THROW 50003, 'Hata: TC Kimlik Numarasý 11 haneli ve sadece rakamlardan oluþmalýdýr.', 1;
        END

        -- E-posta kontrolü: @gmail.com ile bitmeli
        IF @personelEposta NOT LIKE '%@gmail.com'
        BEGIN
            THROW 50004, 'Hata: E-posta adresi @gmail.com ile bitmelidir.', 1;
        END

        -- personelID ile kayýt var mý kontrolü
        IF EXISTS (SELECT 1 FROM Personel WHERE personelID = @personelID)
        BEGIN
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
        END
        ELSE
        BEGIN
            THROW 50005, 'Hata: Belirtilen personelID ile bir kayýt bulunamadý.', 1;
        END
    END TRY
    BEGIN CATCH
        -- Hata yakalama
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
        -- Personel ID'si ile kayýt var mý kontrol et
        IF EXISTS (SELECT 1 FROM Personel WHERE personelID = @personelID)
        BEGIN
            -- Personeli sil
            DELETE FROM Personel WHERE personelID = @personelID;

            PRINT 'Personel baþarýyla silindi.';
        END
        ELSE
        BEGIN
            PRINT 'Silme iþlemi baþarýsýz: Belirtilen personelID ile bir kayýt bulunamadý.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Hata: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

IF OBJECT_ID('PersonelListele', 'P') IS NOT NULL
    DROP PROCEDURE dbo.PersonelListele;
GO

CREATE PROCEDURE PersonelListele
AS
BEGIN
    SET NOCOUNT ON;

    -- Personel tablosundaki verileri seç
    SELECT 
        personelID,
        personelAd,
        personelSoyad,
        personelSifre,
        personelTcNo,
        personelEposta,
        personelCepTelefon,
        personelAdres
    FROM 
        Personel;
END;
GO


IF OBJECT_ID('PersonelAdSoyadAra', 'P') IS NOT NULL
    DROP PROCEDURE dbo.PersonelAdSoyadAra;
GO

CREATE PROCEDURE PersonelAdSoyadAra
    @personelAd NVARCHAR(25) = NULL,   -- Aranacak personel adý (varsayýlan NULL)
    @personelSoyad NVARCHAR(45) = NULL  -- Aranacak personel soyadý (varsayýlan NULL)
AS
BEGIN
    BEGIN TRY
        -- Personel adý ve soyadý ile arama
        SELECT 
            personelID,
            personelAd, 
            personelSoyad,
            personelSifre,
            personelEposta, 
            personelCepTelefon, 
            personelTcNo, 
            personelAdres
        FROM Personel
        WHERE 
            (@personelAd IS NULL OR personelAd LIKE '%' + @personelAd + '%') AND
            (@personelSoyad IS NULL OR personelSoyad LIKE '%' + @personelSoyad + '%');

        -- Eþleþen kayýt yoksa
        IF @@ROWCOUNT = 0
            PRINT 'Eþleþen personel bulunamadý.';
    END TRY
    BEGIN CATCH
        -- Hata mesajý
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


--üyeler
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


---- Üye silme iþlemi için stored procedure'ü oluþtur
IF OBJECT_ID('sp_UyeSil', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE sp_UyeSil;
END
GO

CREATE PROCEDURE sp_UyeSil
    @uyeID INT
AS
BEGIN
    BEGIN TRY
        -- Sadece silme iþlemini yap
        DELETE FROM Uye
        WHERE uyeID = @uyeID;

        PRINT 'Üye baþarýyla silindi.';
    END TRY
    BEGIN CATCH
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


--UYE AD SOYAD ARAMA PROSEDÜRÜ
IF OBJECT_ID('dbo.UyeAdSoyadAra', 'P') IS NOT NULL
    DROP PROCEDURE dbo.UyeAdSoyadAra;
GO

CREATE PROCEDURE dbo.UyeAdSoyadAra
    @uyeKullaniciAd NVARCHAR(25),  -- Aranacak kullanýcý adý
    @uyeKullaniciSoyad NVARCHAR(25) -- Aranacak kullanýcý soyadý
AS
BEGIN
    BEGIN TRY
        -- Üye adý ve soyadý ile arama
        SELECT 
			uyeID,
            uyeKullaniciAd, 
            uyeKullaniciSoyad, 
            uyeEposta, 
            uyeCepTelefon, 
            uyeTcNo, 
            uyeCeza, 
            uyeAdres
        FROM Uye
        WHERE 
            uyeKullaniciAd LIKE '%' + @uyeKullaniciAd + '%' AND
            uyeKullaniciSoyad LIKE '%' + @uyeKullaniciSoyad + '%';

        -- Eþleþen kayýt yoksa
        IF @@ROWCOUNT = 0
            PRINT 'Eþleþen üye bulunamadý.';
    END TRY
    BEGIN CATCH
        -- Hata mesajý
        PRINT 'Bir hata oluþtu: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


-- Mevcut trigger'ý kontrol et ve sil
IF OBJECT_ID('trg_KitapGeriAlmaCeza', 'TR') IS NOT NULL
    DROP TRIGGER trg_KitapGeriAlmaCeza;
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
IF OBJECT_ID('trg_Uye_Insert', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER trg_Uye_Insert;
END
GO

CREATE TRIGGER trg_Uye_Insert
ON Uye
INSTEAD OF INSERT
AS
BEGIN
    -- E-posta alanýnda '@gmail.com' kontrolü
    IF EXISTS (SELECT 1 FROM INSERTED WHERE uyeEposta NOT LIKE '%@gmail.com')
    BEGIN
        RAISERROR('Hata: E-posta adresi "@gmail.com" içermelidir.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- Kontrol geçilirse kayýt ekle
    INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
    SELECT uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres
    FROM INSERTED;
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



--KÝTAP AD ARAMA PROSEDÜRÜ
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
			raftaDurum,
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

--ÖDÜNÇ VERME ÝÇÝN ÝÞLEM KAYDI YAPACAK PROSEDÜR
GO
-- Eðer prosedür varsa, sil
IF OBJECT_ID('InsertIslemKaydi', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE InsertIslemKaydi;
   
END
GO
-- Yeni prosedür oluþtur
CREATE PROCEDURE InsertIslemKaydi
    @adminID INT = NULL,
    @personelID INT = NULL,
    @demirbasID INT,
    @uyeID INT
AS
BEGIN
    SET NOCOUNT ON;
	  -- Kimlik sýrasýný en yüksek deðere göre düzelt
    DECLARE @maxID INT;
    SELECT @maxID = MAX(islemID) FROM Islem;
    IF @maxID IS NOT NULL
    BEGIN
        DBCC CHECKIDENT ('Islem', RESEED, @maxID);
    END
    ELSE
    BEGIN
        -- Eðer tabloda kayýt yoksa kimlik sýrasýný sýfýrla
        DBCC CHECKIDENT ('Islem', RESEED, 0);
    END



    -- adminID girilmiþse personelID NULL olmalý
    IF @adminID IS NOT NULL AND @personelID IS NOT NULL
    BEGIN
        PRINT 'Hem adminID hem personelID ayný anda dolu olamaz.';
        RETURN;
    END

    -- Ýþlem kaydý ekleme
    INSERT INTO Islem (adminID, personelID, demirbasID, uyeID, emanetAlmaTarih, iadeTarih, islemDurumu, islemAciklama)
    VALUES (@adminID, @personelID, @demirbasID, @uyeID, GETDATE(), DATEADD(DAY, 15, GETDATE()), 1, 'Kitap ödünç verildi');

    PRINT 'Ýþlem kaydý baþarýyla oluþturuldu.';
END;
GO

-- Eðer prosedür varsa, sil
IF OBJECT_ID('OduncVermeIslemKayitlari', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE OduncVermeIslemKayitlari;
    PRINT 'Eski prosedür silindi.';
END
GO

-- Yeni prosedür oluþtur
CREATE PROCEDURE OduncVermeIslemKayitlari
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ISNULL(CAST(i.adminID AS NVARCHAR), 'NULL') AS adminID,  -- adminID NULL ise 'NULL' olarak göster
        ISNULL(CAST(i.personelID AS NVARCHAR), 'NULL') AS personelID, -- personelID NULL ise 'NULL' olarak göster
        i.demirbasID, 
        k.kitapAd, 
        i.uyeID, 
        u.uyeKullaniciAd, 
        u.uyeKullaniciSoyad, 
        i.emanetAlmaTarih 
    FROM 
        Islem i
    INNER JOIN 
        Kitap k ON i.demirbasID = k.demirbasID
    INNER JOIN 
        Uye u ON i.uyeID = u.uyeID
    WHERE 
        i.islemDurumu = 1
		ORDER BY
		i.emanetAlmaTarih;
END;
GO


-- Eðer prosedür varsa, sil
IF OBJECT_ID('UpdateIslemKaydi', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE UpdateIslemKaydi;
    PRINT 'Eski prosedür silindi.';
END
GO
-- Yeni prosedür oluþtur
CREATE PROCEDURE UpdateIslemKaydi
    @adminID INT = NULL,
    @personelID INT = NULL,
    @demirbasID INT,
    @uyeID INT
    
AS
BEGIN
    SET NOCOUNT ON;

    -- adminID girilmiþse personelID NULL olmalý
    IF @adminID IS NOT NULL AND @personelID IS NOT NULL
    BEGIN
        PRINT 'Hem adminID hem personelID ayný anda dolu olamaz.';
        RETURN;
    END

    -- Önceki kayýttan emanetAlmaTarih alýnýyor
    DECLARE @oncekiEmanetAlmaTarih SMALLDATETIME;
    SELECT TOP 1 @oncekiEmanetAlmaTarih = emanetAlmaTarih
    FROM Islem
    WHERE demirbasID = @demirbasID
    ORDER BY iadeTarih DESC;

    -- Yeni iþlem kaydý ekleniyor
    INSERT INTO Islem (adminID, personelID, demirbasID, uyeID, emanetAlmaTarih, iadeTarih, islemDurumu, islemAciklama)
    VALUES (@adminID, @personelID, @demirbasID, @uyeID, @oncekiEmanetAlmaTarih, GETDATE(), 0, 'Kitap iade edildi');

    PRINT 'Yeni iþlem kaydý baþarýyla oluþturuldu.';
END;
GO

GO
-- Eðer prosedür varsa, sil
IF OBJECT_ID('ÝadeListeleIslemKayitlari', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE ÝadeListeleIslemKayitlari;
    PRINT 'Eski prosedür silindi.';
END
GO

-- Yeni prosedür oluþtur
CREATE PROCEDURE ÝadeListeleIslemKayitlari
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ISNULL(CAST(i.adminID AS NVARCHAR), 'NULL') AS adminID,       -- adminID NULL ise 'NULL' olarak göster
        ISNULL(CAST(i.personelID AS NVARCHAR), 'NULL') AS personelID, -- personelID NULL ise 'NULL' olarak göster
        i.uyeID,
        u.uyeKullaniciAd,
        u.uyeKullaniciSoyad,
        i.demirbasID,
        k.kitapAd,
        i.iadeTarih
    FROM 
        Islem i
    LEFT JOIN 
        Kitap k ON i.demirbasID = k.demirbasID
    LEFT JOIN 
        Uye u ON i.uyeID = u.uyeID
    WHERE 
        i.islemDurumu = 0
    ORDER BY 
        i.iadeTarih; -- iade tarihine göre sýralama
END;
GO

-- Mevcut tetikleyiciyi kontrol et ve sil
IF OBJECT_ID('trg_RaftaDurumGuncelle_Durum1', 'TR') IS NOT NULL
    DROP TRIGGER trg_RaftaDurumGuncelle_Durum1;
GO

-- Yeni tetikleyiciyi oluþtur
CREATE TRIGGER trg_RaftaDurumGuncelle_Durum1
ON Islem
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Yeni eklenen iþlem kaydý için demirbaþýn iþlem durumu 1 ise raftaDurum'u 0 yap
    UPDATE Kitap
    SET raftaDurum = 0
    WHERE demirbasID IN (
        SELECT demirbasID
        FROM inserted
        WHERE islemDurumu = 1 -- Ýþlem Durumu 1 olanlarý filtrele
    );
END;
GO


-- Eðer tetikleyici varsa, sil
IF OBJECT_ID('trg_RaftaDurumGuncelle_IslemDurum0', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER trg_RaftaDurumGuncelle_IslemDurum0;
    PRINT 'Eski tetikleyici silindi.';
END

GO
-- Yeni tetikleyiciyi oluþtur
CREATE TRIGGER trg_RaftaDurumGuncelle_IslemDurum0
ON Islem
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Yeni eklenen iþlem kaydý için demirbaþýn iþlem durumu 0 ise raftaDurum'u 1 yap
    UPDATE Kitap
    SET raftaDurum = 1
    WHERE demirbasID IN (
        SELECT demirbasID
        FROM inserted
        WHERE islemDurumu = 0 -- Ýþlem Durumu 0 olanlarý filtrele
    );
END;
GO

-- Kullanýcý Giriþi için Stored Procedure
IF OBJECT_ID('sp_KullaniciGiris', 'P') IS NOT NULL
    DROP PROCEDURE sp_KullaniciGiris;
GO

CREATE PROCEDURE sp_KullaniciGiris
    @KullaniciAd NVARCHAR(25),
    @Sifre NVARCHAR(25),
    @Rol NVARCHAR(20)  -- 'Admin', 'Personel' veya 'Uye' gibi roller
AS
BEGIN
    -- Admin Tablosunda Kullanýcý Giriþi
    IF @Rol = 'Admin'
    BEGIN
        SELECT adminID, adminAd, adminSoyad
        FROM Admin
        WHERE adminEposta = @KullaniciAd AND adminSifre = @Sifre;
    END
    -- Personel Tablosunda Kullanýcý Giriþi
    ELSE IF @Rol = 'Personel'
    BEGIN
        SELECT personelID, personelAd, personelSoyad
        FROM Personel
        WHERE personelEposta = @KullaniciAd AND personelSifre = @Sifre;
    END
    -- Uye Tablosunda Kullanýcý Giriþi
    ELSE IF @Rol = 'Uye'
    BEGIN
        SELECT uyeID, uyeKullaniciAd, uyeKullaniciSoyad
        FROM Uye
        WHERE uyeEposta = @KullaniciAd AND uyeTcNo = @Sifre;
    END
    ELSE
    BEGIN
        RAISERROR('Geçersiz Rol.', 16, 1);
    END
END
GO


--Admin Kayýt
IF NOT EXISTS (SELECT 1 FROM Admin WHERE adminTcNo = '56564567895')
INSERT INTO Admin (adminAd, adminSoyad, adminSifre, adminTcNo, adminEposta, adminCepTelefon, adminAdres)
VALUES ('Sýla', 'Dertli', 'Sila1234', '12345678901', 'sila@gmail.com', '5537305892', 'Düzce, Merkez');


IF NOT EXISTS (SELECT 1 FROM Admin WHERE adminTcNo = '56564567895')
INSERT INTO Admin (adminAd, adminSoyad, adminSifre, adminTcNo, adminEposta, adminCepTelefon, adminAdres)
VALUES ('Dilara', 'Öztürk', 'Dilara1234', '12345678902', 'dilara@gmail.com', '5558796541', 'Düzce, Merkez');

--Personel Kayýt
IF NOT EXISTS (SELECT 1 FROM Personel WHERE personelTcNo = '67890123456')
INSERT INTO Personel (personelAd, personelSoyad, personelSifre, personelTcNo, personelEposta, personelCepTelefon, personelAdres)
VALUES ('Hanife', 'Çilingir', 'Hanife123', '43459952810', 'hanife@gmail.com', '5426235462', 'Sakarya, Hendek');

IF NOT EXISTS (SELECT 1 FROM Personel WHERE personelTcNo = '67890123456')
INSERT INTO Personel (personelAd, personelSoyad, personelSifre, personelTcNo, personelEposta, personelCepTelefon, personelAdres)
VALUES ('Rumeysa', 'Navruz', 'Rumeysa123', '12345678587', 'rumeysa@gmail.com', '5458795632', 'Istanbul, Pendik');


--1.Kütüphane
IF NOT EXISTS (SELECT 1 FROM Kutuphane WHERE kutuphaneID = 1)
INSERT INTO Kutuphane (kutuphaneID, kutuphaneAd, kutuphaneAdres, kutuphaneCepTelefon)
VALUES (1, 'Merkez Kütüphane', 'Ýstanbul, Fatih Mah. No:10', '5321234567');

--2.Kütüphane

IF NOT EXISTS (SELECT 1 FROM Kutuphane WHERE kutuphaneID = 2)
INSERT INTO Kutuphane (kutuphaneID, kutuphaneAd, kutuphaneAdres, kutuphaneCepTelefon)
VALUES (2, 'Ankara Halk Kütüphanesi', 'Ankara, Çankaya Mah. No:5', '5332345678');

--3.Kütüphane
IF NOT EXISTS (SELECT 1 FROM Kutuphane WHERE kutuphaneID = 3)
INSERT INTO Kutuphane (kutuphaneID, kutuphaneAd, kutuphaneAdres, kutuphaneCepTelefon)
VALUES (3, 'Ýzmir Çocuk Kütüphanesi', 'Ýzmir, Konak Mah. No:12', '5343456789');


-- 1. Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '12345678901')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Ahmet', 'Yýlmaz', 'ahmet.yilmaz@gmail.com', '5051234567', '12345678901', 0, 'Ýstanbul, Beþiktaþ');

-- 2. Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '23456789012')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Ayþe', 'Demir', 'ayse.demir@gmail.com', '5062345678', '23456789012', 10, 'Ankara, Çankaya');

-- 3. Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '34567890123')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Mehmet', 'Koç', 'mehmet.koc@gmail.com', '5073456789', '34567890123', 15.5, 'Ýzmir, Karþýyaka');

-- 4. Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '45678901234')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Fatma', 'Kaya', 'fatma.kaya@gmail.com', '5084567890', '45678901234', 0, 'Antalya, Muratpaþa');

-- 5. Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '56789012345')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Ali', 'Çetin', 'ali.cetin@gmail.com', '5095678901', '56789012345', 25, 'Bursa, Nilüfer');

-- 6. Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '67890123456')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Zeynep', 'Öztürk', 'zeynep.ozturk@gmail.com', '5016789012', '67890123456', 0, 'Adana, Seyhan');

-- 7. Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '78901234567')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Can', 'Arslan', 'can.arslan@gmail.com', '5027890123', '78901234567', 0, 'Trabzon, Ortahisar');

-- 8. Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '89012345678')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Elif', 'Çakýr', 'elif.cakir@gmail.com', '5038901234', '89012345678', 0, 'Kayseri, Melikgazi');

-- 9. Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '90123456789')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Emre', 'Yýldýz', 'emre.yildiz@gmail.com', '5049012345', '90123456789', 0, 'Samsun, Atakum');

-- 10. Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '01234567890')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Hale', 'Ekinci', 'hale.ekinci@gmail.com', '5050123456', '01234567890', 0, 'Konya, Selçuklu');

--11.Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '11111111111')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Yusuf', 'Bal', 'yusuf.bal@gmail.com', '5061111111', '11111111111', 0, 'Eskiþehir, Tepebaþý');

--12.Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '22222222222')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Ebru', 'Kurt', 'ebru.kurt@gmail.com', '5072222222', '22222222222', 0, 'Mersin, Mezitli');

--13.Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '33333333333')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Murat', 'Akýn', 'murat.akin@gmail.com', '5083333333', '33333333333', 0, 'Balýkesir, Altýeylül');

--14.Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '44444444444')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Selin', 'Durmaz', 'selin.durmaz@gmail.com', '5094444444', '44444444444', 0, 'Tekirdað, Süleymanpaþa');

--15.Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '55555555555')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Onur', 'Ergin', 'onur.ergin@gmail.com', '5015555555', '55555555555', 0, 'Gaziantep, Þahinbey');

--16.Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '66666666666')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Derya', 'Yýldýrým', 'derya.yildirim@gmail.com', '5026666666', '66666666666', 0, 'Manisa, Yunusemre');

--17.Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '77777777777')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Burak', 'Arý', 'burak.ari@gmail.com', '5037777777', '77777777777', 0, 'Sakarya, Serdivan');

--18.Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '88888888888')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Pelin', 'Çelik', 'pelin.celik@gmail.com', '5048888888', '88888888888', 0, 'Van, Ýpekyolu');

--19.Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '99999999999')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Aliye', 'Þen', 'aliye.sen@gmail.com', '5059999999', '99999999999', 0, 'Diyarbakýr, Kayapýnar');

--20.Üye
IF NOT EXISTS (SELECT 1 FROM Uye WHERE uyeTcNo = '10101010101')
INSERT INTO Uye (uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, uyeTcNo, uyeCeza, uyeAdres)
VALUES ('Furkan', 'Eroðlu', 'furkan.eroglu@gmail.com', '5061010101', '10101010101', 0, 'Hatay, Antakya');


-- 1. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-0-98-765432-1')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Veritabaný Yönetim Sistemleri', 'Bilgisayar Bilimleri', 1, '978-0-98-765432-1', 55.75, 3, 0, 'Mehmet', 'Kaya', '2020-10-10', 400, 'Veri Yayýnlarý');

-- 2. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-0-12-345678-9')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Makine Öðrenmesi', 'Yapay Zeka', 1, '978-0-12-345678-9', 85.50, 1, 1, 'John', 'Smith', '2022-05-22', 350, 'AI Yayýnlarý');

-- 3. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-3-14-159265-3')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Derin Öðrenme', 'Yapay Zeka', 1, '978-3-14-159265-3', 92.40, 2, 0, 'Michael', 'Johnson', '2021-11-18', 400, 'Deep Learning Yayýnlarý');

-- 4. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-1-56-234567-4')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Veritabaný Tasarýmý', 'Bilgisayar Bilimleri', 2, '978-1-56-234567-4', 49.90, 3, 1, 'Sara', 'Lee', '2019-09-30', 320, 'DB Teknolojileri Yayýnlarý');

-- 5. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-4-56-789012-3')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Algoritmalarýn Temelleri', 'Bilgisayar Bilimleri', 1, '978-4-56-789012-3', 60.00, 1, 1, 'Ali', 'Kara', '2018-03-15', 450, 'Kodlama Yayýnlarý');

-- 6. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-5-67-890123-4')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Python ile Veri Bilimi', 'Veri Bilimi', 2, '978-5-67-890123-4', 75.00, 2, 0, 'Ebru', 'Demir', '2020-07-20', 300, 'Data Yayýncýlýk');

-- 7. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-6-78-901234-5')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Yapay Zeka ve Etik', 'Yapay Zeka', 1, '978-6-78-901234-5', 88.20, 3, 1, 'Cem', 'Ekinci', '2021-01-10', 220, 'AI Etik Yayýnlarý');

-- 8. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-7-89-012345-6')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Matematiksel Düþünce', 'Matematik', 2, '978-7-89-012345-6', 45.50, 1, 1, 'Zeynep', 'Aydýn', '2017-09-18', 250, 'Matematik Yayýnlarý');

-- 9. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-8-90-123456-7')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Bilgi Güvenliði', 'Siber Güvenlik', 3, '978-8-90-123456-7', 92.40, 2, 0, 'Fatma', 'Kara', '2022-02-25', 320, 'Cyber Yayýncýlýk');

-- 10. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-9-01-234567-8')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Java Programlama', 'Bilgisayar Bilimleri', 4, '978-9-01-234567-8', 65.00, 3, 1, 'Emre', 'Yýldýrým', '2019-12-01', 500, 'Kodlama Dünyasý Yayýnlarý');

-- 11. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-1-23-456789-0')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Sistem Analizi', 'Mühendislik', 1, '978-1-23-456789-0', 55.00, 1, 1, 'Hakan', 'Güneþ', '2021-03-12', 200, 'Teknik Yayýnlarý');

-- 12. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-2-34-567890-1')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Büyük Veri Analitiði', 'Veri Bilimi', 2, '978-2-34-567890-1', 82.00, 2, 0, 'Ahmet', 'Polat', '2020-06-05', 480, 'Data Science Yayýnlarý');

-- 13. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-3-45-678901-2')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Eðitim Psikolojisi', 'Psikoloji', 1, '978-3-45-678901-2', 45.90, 3, 1, 'Leyla', 'Demir', '2018-11-23', 300, 'Eðitim Yayýnlarý');

-- 14. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-4-56-123789-0')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Programlama Dilleri', 'Bilgisayar Bilimleri', 3, '978-4-56-123789-0', 70.50, 1, 1, 'Selin', 'Öztürk', '2021-05-11', 360, 'Teknoloji Yayýnlarý');

-- 15. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-5-67-890432-1')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Veri Madenciliði', 'Veri Bilimi', 1, '978-5-67-890432-1', 95.00, 2, 0, 'Ayþe', 'Kurt', '2020-09-19', 450, 'Bilim Yayýncýlýk');

-- 16. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-6-78-901876-3')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Bilgisayar Aðlarý', 'Bilgisayar Bilimleri', 2, '978-6-78-901876-3', 80.30, 3, 1, 'Deniz', 'Çelik', '2018-07-28', 390, 'Að Teknolojileri Yayýnlarý');

-- 17. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-7-89-012743-5')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Olasýlýk ve Ýstatistik', 'Matematik', 1, '978-7-89-012743-5', 68.40, 2, 0, 'Murat', 'Gül', '2019-03-14', 310, 'Matematik Yayýnlarý');

-- 18. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-8-90-123459-9')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Web Teknolojileri', 'Bilgisayar Bilimleri', 1, '978-8-90-123459-9', 75.90, 1, 1, 'Hülya', 'Turan', '2022-01-04', 420, 'Kod Dünyasý Yayýnlarý');

-- 19. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-9-01-234786-4')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Robotik ve Otomasyon', 'Mühendislik', 2, '978-9-01-234786-4', 110.50, 3, 1, 'Ahmet', 'Eren', '2021-08-16', 500, 'Teknik Dünya Yayýnlarý');

-- 20. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-1-23-456780-1')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Bilimsel Araþtýrma Yöntemleri', 'Bilim', 1, '978-1-23-456780-1', 55.00, 2, 0, 'Can', 'Bozkurt', '2020-11-30', 280, 'Bilimsel Yayýncýlýk');

-- 21. Kitap Giriþi
IF NOT EXISTS (SELECT 1 FROM Kitap WHERE ISBN = '978-2-34-567890-2')
INSERT INTO Kitap (kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi)
VALUES ('Algoritmalarýn Temelleri', 'Bilgisayar Bilimleri', 1, '978-2-34-567890-2', 65.20, 3, 1, 'Selim', 'Yýlmaz', '2019-06-12', 350, 'Kod Akademi Yayýnlarý');


--1.ÝÞLEM
INSERT INTO Islem (personelID, demirbasID,uyeID, emanetAlmaTarih, iadeTarih, islemDurumu, islemAciklama, adminID)
VALUES (NULL, 2,4, '2024-11-15 00:00:00', '2024-11-30 00:00:00', 1, 'Kitap ödünç alýndý.', 1);

--2.ÝÞLEM
INSERT INTO Islem (personelID, demirbasID,uyeID, emanetAlmaTarih, iadeTarih, islemDurumu, islemAciklama, adminID)
VALUES (1, 4,7, '2024-11-15 00:00:00', '2024-11-30 00:00:00', 1, 'Kitap ödünç alýndý.', NULL);

--3.ÝÞLEM
INSERT INTO Islem (personelID, demirbasID,uyeID, emanetAlmaTarih, iadeTarih, islemDurumu, islemAciklama, adminID)
VALUES (1, 19,6, '2024-11-01 00:00:00', '2024-11-15 00:00:00', 1, 'Kitap ödünç alýndý.', NULL);

--4.ÝÞLEM
INSERT INTO Islem (personelID, demirbasID,uyeID, emanetAlmaTarih, iadeTarih, islemDurumu, islemAciklama, adminID)
VALUES (1, 14,10, '2024-11-01 00:00:00', '2024-11-15 00:00:00', 1, 'Kitap ödünç alýndý.', NULL);

--5.ÝÞLEM
INSERT INTO Islem (personelID, demirbasID,uyeID, emanetAlmaTarih, iadeTarih, islemDurumu, islemAciklama, adminID)
VALUES (NULL, 16,8, '2024-11-10 00:00:00', '2024-11-25 00:00:00', 1, 'Kitap ödünç alýndý.', 1);


--6.ÝÞLEM
INSERT INTO Islem (personelID, demirbasID,uyeID, emanetAlmaTarih, iadeTarih, islemDurumu, islemAciklama, adminID)
VALUES (NULL, 21,9, '2024-11-10 00:00:00', '2024-11-25 00:00:00', 1, 'Kitap ödünç alýndý.', 1);

--1. ÝADE ÝÞLEMÝ
INSERT INTO Islem (personelID, demirbasID,uyeID, emanetAlmaTarih, islemDurumu, islemAciklama, adminID)
VALUES (2, 16,8, '2024-11-10 00:00:00',  0, 'Kitap iade alýndý.', 1);


--2. ÝADE ÝÞLEMÝ
INSERT INTO Islem (personelID, demirbasID,uyeID, emanetAlmaTarih, islemDurumu, islemAciklama, adminID)
VALUES (NULL, 21,9, '2024-11-10 00:00:00',  0, 'Kitap iade alýndý.', 2);


select* from Admin
select * from Personel
select * from Kutuphane
select * from Uye
select * from Kitap
select * from Islem