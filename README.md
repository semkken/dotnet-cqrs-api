# BookingRoomAPI By Kasemsan

## Overview
BookingRoomAPI by Kasemsan is a **.NET Core Web API** built with **Clean Architecture**, **CQRS**, and **MediatR**, using **PostgreSQL** as the database.

### ✅ Features:
- **CQRS Implementation** (Commands for writes, Queries for reads)
- **MediatR for Loose Coupling**
- **Repository Pattern for Data Access**
- **EF Core with PostgreSQL Database**
- **Swagger API Documentation**
- **Dependency Injection (DI) Configuration**
- **Aggregate Root for Entity Management**
- **Infrastructure Layer for Database and Services**

## 📂 Project Structure:
```
BookingRoomAPI/
│── API/
│   ├── Controllers/
│   │   ├── AppointmentController.cs  
│
│── Application/
│   │── CQRS/
│   │   ├── Commands/
│   │   │   ├── CreateAppointmentCommand.cs  
│   │   │   ├── CreateAppointmentHandler.cs  
│   │   ├── Queries/
│   │   │   ├── GetAppointmentsQuery.cs      
│   │   │   ├── GetAppointmentsHandler.cs    
│
│── Core/
│   ├── Aggregates/
│   │   ├── Appointment.cs  
│
│── Infrastructure/
│   ├── Data/
│   │   ├── AppDbContext.cs  
│   │   ├── IAppointmentRepository.cs  
│   │   ├── AppointmentRepository.cs  
│
│── Program.cs  
│── BookingRoomAPI.csproj  
│── README.md  
```

## 🚀 Getting Started

### 1️⃣ Prerequisites
- .NET 7 SDK
- PostgreSQL Database

### 2️⃣ Setup Database Connection
Modify `appsettings.json` in the API project:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=booking_db;Username=postgres;Password=yourpassword"
  }
}
```

### 3️⃣ Install Dependencies
Run the following command in the project root:
```sh
dotnet restore
```

### 4️⃣ Apply Database Migrations
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 5️⃣ Run the API
```sh
dotnet run
```

## 📖 API Endpoints

### Create an Appointment
**POST** `/api/appointment/create`
```json
{
  "customerId": 1,
  "locationId": 2,
  "serviceId": 3,
  "staffId": 4,
  "name": "John Doe",
  "email": "johndoe@example.com",
  "contact": "+123456789",
  "date": "2025-03-30",
  "time": "10:00 AM",
  "notes": "Special request",
  "paymentType": "Credit Card",
  "appointmentStatus": "Confirmed",
  "businessId": 5,
  "createdBy": 1
}
```

### Get All Appointments
**GET** `/api/appointment/list`


