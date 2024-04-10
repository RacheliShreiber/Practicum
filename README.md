# Employee Management Application

This application is designed for managing the employee list of an organization. The client-side is developed using React, while the server-side is implemented using .NET 6.

## Client-Side (React)

The client-side interface includes a table displaying the details of employees, with options to add, update, and delete employees. Each employee entry includes a field for a list of roles, and during the addition of a new employee, there's the flexibility to dynamically add roles.

### Features:
- **Employee Table**: Displays a comprehensive list of employee details.
- **Add Employee**: Enables adding new employees to the list.
- **Update Employee**: Allows updating employee information.
- **Delete Employee**: Supports logical deletion of employees to maintain data integrity.
- **Roles**: Each employee can have multiple roles, and roles can be dynamically added during employee addition.
- **Export to Excel**: Provides functionality to export the employee list to an Excel file for download.

#### Additional Feature:
- **Role Addition**: Administrators can add new roles to the system.

## Server-Side (.NET 6)

The server-side is implemented using .NET 6, featuring an API for storing employee data. Data is stored in an SQL database, following a layered project structure.

### Features:
- **API Endpoints**: Implements endpoints for handling CRUD operations on employee data.
- **Logical Deletion**: Utilizes logical deletion when removing employees to maintain data consistency.

---
This application streamlines the management of an organization's employee list, offering flexibility in role management and efficient data storage and retrieval. The client-side React interface provides a user-friendly experience, while the robust .NET 6 backend ensures secure and reliable data handling.
