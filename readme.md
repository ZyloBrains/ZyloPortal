## Overview
ZyloPortal is a comprehensive training and workforce management platform built with ASP.NET Core Blazor (MudBlazor UI) that manages corporate training plans, trainees, instructors, and project assignments.

## Technical Stack
- Framework: ASP.NET Core 10.0 (Blazor)
- UI Library: MudBlazor 8.x
- Database: SQL Server (EF Core)
- Authentication: ASP.NET Identity
- Rich Text Editor: Spillgebees.Blazor.RichTextEditor
- Deployment: Azure App Service (GitHub Actions)

## To do list (2026 Apr onwards):
- [x] Applicants Screen - applicants can be added on existing batch in one go
- [x] Load colleges from organization table and remove college entity altogether
- [ ] Display NPT timezones on UI components
- [ ] Add more user info (Fullname etc.) on User table
- [ ] Add Employment table and link to User table
- [ ] Load users (Fullname) on free text user fields e.g. PaidBy etc.


## Trainee Enrollment Flow
Public User visits site => Enroll Page (public) => Fills Application Form => Admin reviews & Approves => User registered as Trainee 
=> Assigned to Batch => Access Trainee Dashboard => Access Training Materials, Assignments, Projects, Timesheet