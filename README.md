# 🎓 Student Management System (.NET)

A database-driven Student Management System built using **C#**, **.NET**, **Entity Framework Core**, and **SQL Server**. The project demonstrates database design, Entity Framework Core features, and relationship mapping in a real-world academic management scenario.

---

## 📌 Features

- Manage Students
- Manage Courses
- Manage Resources
- Manage Homework
- Define Content Types
- Student-Course Enrollment (Many-to-Many Relationship)
- Database Migrations using Entity Framework Core
- LINQ-based data operations

---

## 🛠️ Technologies Used

- C#
- .NET
- Entity Framework Core
- SQL Server
- LINQ
- Fluent API

---

## 🗄️ Database Design

The project includes the following entities:

- Student
- Course
- StudentCourse
- Homework
- Resource
- ContentType

### Relationships

- One-to-Many
- Many-to-Many

---

## 📂 Project Structure

```
Data/
 ├── ModelConfiguration/
 └── StudentSystemContext.cs

Models/
 ├── Student.cs
 ├── Course.cs
 ├── Homework.cs
 ├── Resource.cs
 ├── ContentType.cs
 └── StudentCourse.cs

Migrations/

Program.cs
```

---

## 🚀 Getting Started

### Clone the repository

```bash
git clone https://github.com/maher6468/EF_StudentSystem_project.git
```

### Navigate to the project

```bash
cd EF_StudentSystem_project
```

### Restore packages

```bash
dotnet restore
```

### Update the database

```bash
dotnet ef database update
```

### Run the project

```bash
dotnet run
```

---

## 🎯 Learning Outcomes

This project helped me gain practical experience with:

- Entity Framework Core
- Database Migrations
- Fluent API Configuration
- Relational Database Design
- LINQ Queries
- One-to-Many Relationships
- Many-to-Many Relationships
- SQL Server Integration

---

## 👨‍💻 Author

**Mohamed Ahmed Mohamed Maher**

- LinkedIn: https://linkedin.com/in/mohamed-el-maher-49a025320
- GitHub: https://github.com/maher6468
