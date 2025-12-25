# 🎓 Advanced Student Management System (OOP + SOLID)

[![GitHub Repository](https://img.shields.io/badge/GitHub-Student--Management--System-blue?style=flat-square&logo=github)](https://github.com/shreef-rekaby/Student-Management-System)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
![OOP](https://img.shields.io/badge/Programming-OOP-green)
![SOLID](https://img.shields.io/badge/Design-SOLID-red)

A professional console-based application designed to manage student academic records and course enrollments. This project demonstrates the practical application of **Object-Oriented Programming (OOP)** and **SOLID Design Principles** to build a scalable and maintainable software architecture.

---

## 🚀 Features

- **Unique Student Registration:** Ensures no duplicate Student IDs can exist in the system.
- **Secure Authentication:** Students must log in with their ID and Password to view details, enroll in courses, or delete their profile.
- **Course Management:** 
    - 5 Pre-defined courses available at startup.
    - Prevents duplicate enrollment in the same course.
    - Validation to ensure courses exist before registration.
- **Student Profile Management:** Display comprehensive info including enrolled courses and total credits.
- **Account Deletion:** Secure deletion process requiring credentials and user confirmation.
- **Robust Error Handling:** Graceful management of invalid inputs and unauthorized access attempts.

---

## 🛠 SOLID Principles Implementation

| Principle | Implementation in this Project |
|:--- |:--- |
| **S - Single Responsibility** | Separate classes for `Student` (data), `Course` (data), `AuthService` (logic), and `ConsoleUI` (presentation). |
| **O - Open/Closed** | The system uses interfaces for data storage and services, allowing new features (like SQL saving) to be added without changing core code. |
| **L - Liskov Substitution** | Base classes (like `Person`) can be replaced by their subclasses (`Student`) without breaking the program functionality. |
| **I - Interface Segregation** | Small, specific interfaces (e.g., `IAuthService`, `IRepository`) ensure classes only implement necessary methods. |
| **D - Dependency Inversion** | High-level modules depend on abstractions (interfaces) rather than concrete implementations. |

---

## 🧩 OOP Concepts Applied

- **Encapsulation:** All student and course data members are `private`. Access is granted only through public properties and validated methods.
- **Inheritance:** A base `Person` class provides core attributes (ID, Name), which is inherited and extende
