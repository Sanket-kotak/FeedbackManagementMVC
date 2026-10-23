# Feedback Management MVC

A beginner-friendly ASP.NET Core MVC project for the lab exercise: **MVC Layout, Partial View, HTML Helpers, and Validation**.

## Requirements
- Visual Studio 2022 with the **ASP.NET and web development** workload
- .NET 8 SDK

## Run in Visual Studio
1. Extract the ZIP file.
2. Open `FeedbackManagementMVC.csproj` in Visual Studio.
3. Wait for restore to finish.
4. Select the project as the startup project.
5. Press **Ctrl+F5** (or click Run).
6. The browser opens the Feedback Management page. If it does not, open the localhost URL shown by Visual Studio.

## Run from terminal
Open a terminal in the folder containing `FeedbackManagementMVC.csproj` and run:
```bash
dotnet restore
dotnet run
```
Open the localhost URL printed in the terminal.

## Features demonstrated
- **MVC:** `FeedbackController` handles requests; `Feedback` is the model; Razor files are views.
- **Layout:** `Views/Shared/_Layout.cshtml` provides common header, navigation, and footer.
- **Partial View:** `Views/Shared/_FeedbackForm.cshtml` reuses the form fields.
- **HTML Helpers:** `LabelFor`, `TextBoxFor`, `DropDownListFor`, `TextAreaFor`, and `ValidationMessageFor`.
- **Validation:** Data annotations (`Required`, `StringLength`, `EmailAddress`, `Range`) in `Models/Feedback.cs`; `ModelState.IsValid` in the controller.
- **CRUD basics:** List, create, view details, and delete feedback.
- **Security:** POST actions use anti-forgery tokens.

## Important note
This project stores feedback in memory, so data resets when the app restarts. A database is not required for this exercise. The validation is enforced on the server; client-side validation scripts are included from a CDN, so an internet connection is needed for client-side validation. Do not use real personal data in a lab demo.

## Suggested screenshots for the report
1. Feedback list page with sample feedback.
2. Submit Feedback form.
3. Validation messages after submitting an empty or invalid form.
4. Details page for a submitted feedback record.
5. Feedback list showing the newly submitted record.
