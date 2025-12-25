
# Student Management System

A simple, robust C# Console Application designed to manage student records using Object-Oriented Programming (OOP) principles. This project demonstrates the use of classes, enums, composition, and list management in .NET.

## 🚀 Features

*   **Add Students**: Capture detailed information including ID, Name, Grade, Department, and full Address.
*   **View Students**: Display all registered students in a formatted layout.
*   **Delete Students**: Remove students from the system using their unique Student ID.
*   **Address Composition**: Uses a dedicated `Address` class to demonstrate "Has-A" relationships.
*   **Department Enum**: Categorizes students into specific departments (IT, CS, IS, SE).

## 🛠️ Technical Implementation

This project utilizes several core C# concepts:
- **Encapsulation**: Properties with getters and setters.
- **Constructor Chaining**: Default constructors that call parameterized constructors using the `this` keyword.
- **Enums**: Used for strict typing of Departments.
- **LINQ/Lambda Expressions**: Used in `students.RemoveAll(st => st.Id == id)` for efficient record deletion.
- **Composition**: The `Student` class contains an instance of the `Address` class.

## 📂 Project Structure

| File | Description |
| :--- | :--- |
| `Address.cs` | Defines the `Address` class (Street, City, Postal Code). |
| `Student.cs` | Defines the `Student` class and the `Department` Enum. |
| `Program.cs` | Contains the `Main` method, menu logic, and the list management functions. |

## 💻 How to Run

1.  **Clone the repository**:
    ```bash
    git clone https://github.com/your-username/student-management-system.git
    ```
2.  **Open in IDE**: Open the folder in Visual Studio or VS Code.
3.  **Build and Run**:
    - In Visual Studio: Press `F5`.
    - In Terminal: 
      ```bash
      dotnet run
      ```

## 📖 Usage Guide

When you run the application, you will be presented with a menu:
1. **Add Students**: Enter the required details. Note that for Departments, you enter a number:
   - `0` for IT
   - `1` for CS
   - `2` for IS
   - `3` for SE
2. **View Students**: See a list of all students currently in the session memory.
3. **Delete Students**: Enter the ID of the student you wish to remove.
4. **Exit**: Closes the application.

## 📝 Example Output

```text
ID: 1
Name: Ahmed Mohamed
Department: CS
Grade: 95.5
Address: 123 Main St, Cairo, 11511
-----------------------------------
```

## 👤 Author
**Shreef Rekaby**  
[GitHub Profile](https://github.com/shreef-rekaby) | [LinkedIn](https://www.linkedin.com/in/shreef-rekaby)
