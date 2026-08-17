# Horizon Student Management System (BIT)

A comprehensive desktop-based Student Management System built using C# and Windows Forms (.NET Framework). This application is designed to streamline administrative tasks in an educational institution, providing a user-friendly interface for managing student records, attendance, payments, and syllabi.

## Features

- **User Authentication & Security**: Secure login system with role-based access, including specific Admin and Security modules (`AdminAccess`, `Security`).
- **Dashboard**: A central hub (`homepage`, `Dashboard`) to navigate through different modules of the system.
- **Student Registration**: Add and manage student details efficiently (`Register`).
- **Attendance Management**: Track and record student attendance (`Attenance`).
- **Payment Processing**: Manage student fees and payment records (`Payment`).
- **Syllabus Management**: Organize and view course syllabi (`Syllabus`).
- **Custom UI Elements**: Custom message boxes (`MsgBox`, `Msgbox(Home)`, `homeclose`) for an enhanced and consistent user experience.

## Technologies Used

- **Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **IDE**: Microsoft Visual Studio

## Getting Started

### Prerequisites

- Microsoft Visual Studio (2019 or later recommended)
- .NET Framework installed on your Windows machine

### Installation & Setup

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Suganth-U/Student-Management-system.git
   ```

2. **Open the project:**
   - Launch Visual Studio.
   - Click on **Open a project or solution**.
   - Navigate to the cloned folder and select the `Horizon Student Management System(BIT).sln` file.

3. **Build and Run:**
   - Press `F5` or click on the **Start** button in Visual Studio to build and run the application.

## Project Structure Overview

- `Horizon Student Management System(BIT).sln`: The main Visual Studio solution file.
- `Form1.cs`: The initial entry point of the application (Login Screen).
- `Register.cs`: Module for handling new student registrations.
- `Attenance.cs`: Module for taking and viewing attendance.
- `Payment.cs`: Module for handling financial transactions and fees.
- `Syllabus.cs`: Module for managing course outlines.

## Contributing

Contributions are welcome! If you would like to contribute to this project, please fork the repository and submit a pull request with your changes.

## License

This project is open-source and available under the MIT License.
