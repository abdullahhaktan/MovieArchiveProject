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

# MovieArchiveProject

**Movie and TV Series Archive Management Application with C# and SQL Server (Windows Forms)**

This project is a movie/series archive application developed with Windows Forms (.NET Framework) that includes basic database operations, user interface management, and modern web content display capabilities.

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-green.svg)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netframework-4.8)
[![Database](https://img.shields.io/badge/Database-SQL%20Server-red.svg)](https://www.microsoft.com/en-us/sql-server)
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/MovieArchiveProject)](https://github.com/abdullahhaktan/MovieArchiveProject)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 💻 About the Project

This application allows users to store and manage their movies and series in an SQL Server database, as well as watch related trailers/links directly within the app via the **WebView2** control.  
The project demonstrates basic **ADO.NET** operations (Insert, Select) and dynamic management of Windows Forms components.

### Key Features ✨

| Category | Description | Applied Technologies / Patterns |
| :--- | :--- | :--- |
| **Database** | Permanently stores movie name, category, and link information. | **SQL Server**, ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`) |
| **Archive Management** | Add, list, and view movie/series records. | Basic **CRUD** operations — `Create` and `Read`. |
| **Visual Interface** | User-friendly and dynamic UI. | **Windows Forms Application**, `DataGridView`, `GroupBox`, `Button` |
| **Video Playback** | Plays web content (e.g., trailers) via stored links. | **Microsoft Edge WebView2 Control** |
| **Dynamic UI** | Full-screen mode and color-changing options within the app. | `FormWindowState.Maximized`, `FormBorderStyle.None`, `Random` color selection. |
| **User Info** | “About” button that displays developer information. | Uses `MessageBox`. |

---

## 🛠️ Setup and Run

Follow the steps below to run the project locally:

### Requirements

* **Visual Studio** (a version that supports C# Windows Forms applications)
* **SQL Server**
* **Microsoft Edge WebView2 Runtime** (required for the WebView2 control)

### Database Setup

1. Create a database named `DbFilm` in SQL Server.  
2. Inside this database, create a table named `TBL_FILMLER` with the following columns:
   * `ID` (Primary Key, Identity)
   * `AD` (Movie Name)
   * `KATEGORI` (Movie Category)
   * `LINK` (Trailer or Video Link)

3. Update the connection string in the C# code according to your SQL Server configuration. **Example:**
    ```csharp
    // Update this with your own server name:
    SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbFilm;Integrated Security=True;Encrypt=False;");
    ```

### Running the Application

1. **Clone the Repository:**
    ```bash
    git clone https://github.com/abdullahhaktan/MovieArchiveProject.git
    ```
2. Open the solution in Visual Studio.
3. Restore project dependencies (check NuGet packages if necessary).
4. Run the application (`F5`).

---

## 🖼️

<img width="928" height="467" alt="Ekran görüntüsü 2025-10-04 114642" src="https://github.com/user-attachments/assets/ca8b9ca3-a8b2-4665-abd3-8bd651d10f91" />
