# BloodBankSystem

BloodBankSystem is a C# application designed for managing blood bank operations.  
The system allows management of blood donors, employees, blood donations, and laboratory tests.

## Project Overview

The application is intended for blood bank centers that collect, store, and distribute blood.  
It provides a simple graphical interface for managing donors, employees, donations, and blood records.

The system supports three different types of users:

- Administrator
- Employee
- Donor

Each user role has different permissions and functionality within the system.

## Technologies Used

- C#
- .NET
- Windows Forms
- SQL Database

## Features

### User Authentication

Users can log into the system using their username and password.  
The login screen allows selecting the user role:

- Administrator
- Employee
- Donor

The application also supports:

- Language switching (English / Serbian)
- Theme customization

### Administrator

The administrator has full access to system management features:

- View number of donors by blood type
- Manage employees
- Manage donors

Administrator can perform the following actions:

- Add new records
- Update existing records
- Delete records
- Clear input fields
- Load data from the database

### Employee

Employees manage operational blood bank data.

They can:

- Manage blood donations
- Manage blood tests

Available actions include:

- Add donation/test
- Update donation/test
- Delete records
- Clear input fields
- Load data from the database

### Donor

Donors have limited access within the system.

They can only:

- View the number of donors by blood group

## Application Screenshots

Below are some screenshots of the application interface.

![Login Screen](images/login.png)

![Administrator Dashboard](images/admin.png)

![Donation Management](images/donations.png)

## Installation

1. Clone the repository from GitHub
2. Open the project in Visual Studio
3. Build and run the application

## Author

**Nevena Dačević**  
Faculty project – Blood Bank Management System
