# Report System Management

A Windows Forms application for managing student academic integrity and conduct reports. This system provides role-based access for administrators/faculty and students to create, view, edit, and delete case reports.

## Overview

The Report System Management application is designed as a demo for TRU to manage academic conduct reports and violations in a structured, secure manner. The system supports multiple user roles with different levels of access and permissions.

## Features

### Authentication System
- **Role-based Login**: Two user types:
  - **Admin/Faculty Members**: Full access to all reports
  - **Students**: Access to their own reports only
- Secure authentication via username and password
- Test account functionality for demo purposes

### Core Functionality

#### For Faculty/Administrators:
- **View All Reports**: Access complete list of all student case reports
- **Edit Reports**: Modify existing case report details
- **Delete Reports**: Remove reports from the system
- **Manage Student Conduct**: Oversee academic integrity violations and conduct issues

#### For Students:
- **View Personal Reports**: Access only reports related to them
- **Create Reports**: Submit new case reports
- **Edit Reports**: Update their own report submissions
- **Delete Reports**: Remove their own reports from the system

### Report Management
Reports contain comprehensive case information including:
- Student details (name, number, email)
- Faculty information and signatures
- Course and assignment details
- Violation descriptions
- Student statements and acknowledgments
- Multiple signature and date fields for workflow tracking
- Support notices and declarations
- Comments from all parties involved

## Technical Architecture

### Frontend
- **Language**: C# (WinForms)
- **UI Framework**: Windows Forms
- **Entry Point**: `Program.cs`

### Backend
- **Language**: Python
- **Functions**:
  - `login.py`: Handles user authentication (admin vs. student verification)
  - `main.py`: Manages CRUD operations for case reports
  - `Record.cs`: Handles individual report creation/editing interface

### Local Data Storage
- **login_accounts.txt**: User credentials and role information (Dummy records)
- **report_records.txt**: All case report records (Also dummy records)
- **Delimiter**: `|||` (pipe-separated format)

## User Flow

1. **Login**: User launches application and enters credentials
2. **Authentication**: Python backend validates credentials against login_accounts.txt
3. **Role-Based Dashboard**: 
   - Faculty sees all reports
   - Students see only their reports
4. **CRUD Operations**: Users can create, view, edit, or delete reports based on their role
5. **Logout**: Users can return to login screen at any time

## Navigation

- **Main Dashboard**: View all accessible reports in table format
- **Record Details**: Edit individual report information
- **Create/Edit Interface**: Comprehensive form for report data entry


## Technologies Used

- **C# / .NET Framework** - Windows Forms desktop application
- **Python** - Backend logic
- **File-based Storage** - Text file database with pipe delimiters
- **Windows Forms** - UI framework for Windows desktop
