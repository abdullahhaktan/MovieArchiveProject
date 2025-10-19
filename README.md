# MovieArchiveProject

**C# ve SQL Server ile Film ve Dizi Arşiv Yönetimi Uygulaması (Windows Forms)**

Bu proje, temel veritabanı işlemlerini, kullanıcı arayüzü yönetimini ve modern web içeriği görüntülemeyi içeren, Windows Forms (.NET Framework) ile geliştirilmiş bir film/dizi arşiv uygulamasıdır.

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-green.svg)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netframework-4.8)
[![Database](https://img.shields.io/badge/Database-SQL%20Server-red.svg)](https://www.microsoft.com/en-us/sql-server)
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/MovieArchiveProject)](https://github.com/abdullahhaktan/MovieArchiveProject)
[![Lisans](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 💻 Proje Hakkında

Bu uygulama, kullanıcıların filmlerini ve dizilerini SQL Server veritabanında saklamalarına, yönetmelerine ve ilgili fragman/linkleri doğrudan uygulama içinde **WebView2** kontrolü aracılığıyla izlemelerine olanak tanır. Proje, temel **ADO.NET** işlemlerini (Insert, Select) ve Windows Forms bileşenlerinin dinamik yönetimini gösterir.

### Öne Çıkan Özellikler ✨

| Kategori | Açıklama | Uygulanan Teknolojiler/Desenler |
| :--- | :--- | :--- |
| **Veritabanı** | Filmlerin ad, kategori ve link bilgilerini kalıcı olarak saklama. | **SQL Server**, ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`) |
| **Arşiv Yönetimi** | Film/Dizi kayıtlarını ekleme, listeleme ve izleme. | Temel **CRUD** operasyonlarından `Create` ve `Read` (Ekleme ve Listeleme). |
| **Görsel Arayüz** | Kullanıcı dostu ve dinamik bir arayüz. | **Windows Forms Application**, `DataGridView`, `GroupBox`, `Button` |
| **Video Görüntüleme** | Kayıtlı linkler aracılığıyla web içeriği (fragmanlar vb.) oynatma. | **Microsoft Edge WebView2 Control** |
| **Dinamik UI** | Uygulama içinde tam ekran modu ve renk değiştirme seçenekleri. | `FormWindowState.Maximized`, `FormBorderStyle.None`, `Random` renk seçimi. |
| **Kullanıcı Bilgisi** | Geliştirici hakkında bilgi veren `Hakkımızda` butonu. | `MessageBox` kullanımı. |

---

## 🛠️ Kurulum ve Çalıştırma

Projenin yerel makinenizde çalıştırılması için aşağıdaki adımları izleyin:

### Gereksinimler

* **Visual Studio** (C# Windows Forms uygulamalarını destekleyen bir sürüm)
* **SQL Server**
* **Microsoft Edge WebView2 Runtime** (WebView2 kontrolü için gereklidir)

### Veritabanı Kurulumu

1.  SQL Server üzerinde `DbFilm` adında bir veritabanı oluşturun.
2.  Bu veritabanı içinde aşağıdaki sütunlara sahip bir `TBL_FILMLER` tablosu oluşturun:
    * `ID` (Primary Key, Identity)
    * `AD` (Film Adı)
    * `KATEGORI` (Film Kategorisi)
    * `LINK` (Fragman veya Video Linki)

3.  Projenin C# kodunda belirtilen bağlantı dizesini kendi SQL Server yapınıza göre güncelleyin. **Önemli:**
    ```csharp
    // Bu kısmı kendi sunucu adınıza göre güncelleyin:
    SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbFilm;Integrated Security=True;Encrypt=False;"); 
    ```

### Uygulamayı Çalıştırma

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/abdullahhaktan/MovieArchiveProject.git](https://github.com/abdullahhaktan/MovieArchiveProject.git)
    ```
2.  Visual Studio'da çözümü açın.
3.  Proje bağımlılıklarını yükleyin (Gerekirse NuGet paketlerini kontrol edin).
4.  Uygulamayı çalıştırın (`F5`).

---

## 🖼️ Ekran Görüntüsü

Uygulamanın arayüzüne ait görsel:

<img width="928" height="467" alt="Ekran görüntüsü 2025-10-04 114642" src="https://github.com/user-attachments/assets/ca8b9ca3-a8b2-4665-abd3-8bd651d10f91" />
