# SafeVault
This is a project for Microsoft Back-End Developer Professional Certificate
SafeVault is a secure application designed to manage sensitive user data. It includes features such as authentication, authorization, and protection against common vulnerabilities (e.g., SQL injection, XSS).

## Features
- User authentication with hashed passwords.
- Role-based access control.
- SQL injection and XSS prevention.

## Setup
1. Execute `Database/database.sql` to set up the database.
2. Configure the connection string in `Config/appsettings.json`.
3. Build the project: `dotnet build`.
4. Run the application: `dotnet run`.

## Testing
Execute tests using:
```bash
dotnet test
