# BookLoop
Project for Event Driven Programming

This is a Windows Forms application built with .NET Framework that allows users to rent book , extend renting period, and for administrators to manage books and customers. It features:

- Rent a book , either by pickup or delivery
- Extend book rental easily
- Viewing, adding, and deleting admin records
- Managing book information (title, genre, media, etc.)
- Simple local database integration using SQL Server (LocalDB)

---

## 🚀 Getting Started

### ✅ Prerequisites

- Windows OS
- Visual Studio (any edition that supports WinForms)
- SQL Server LocalDB *(installed with Visual Studio by default)*

---

## ⚙️ Setup Instructions

1. **Clone the Repository**

```bash
git clone https://github.com/your-username/comic-rental-admin.git
cd comic-rental-admin
```

## 🔧 Configuration

Before running the application, make sure to:

1. Set up your database (e.g., SQL Server LocalDB or SQL Server Express).
2. Update the connection string in `YourForm.cs` or `App.config` file.

### 🔁 Example connection string:
```csharp
string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YourDatabaseName;Integrated Security=True;";

* You can find comment
\\ADD YOUR DB SOURCE HERE
to find the connection string variable
```

Note = Data stored inside .mdf file is dummy data , not a real one.




