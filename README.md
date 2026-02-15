# GeniusPark_ParkingLot-Management
GeniusPark is a enterprise desktop program designed for companies to manage parking lot. 
The program simulates a real-world parkinglot attendant workflow with licence plate detecting by taken car image and auto pricing by park time.
Made on simple user interface for ease of use.
Developed with C#, Python and different ml models.
---
## Author: Hakan Kocaman  ! Currently Working On ! 
---

## Features
- Licence Plate Detecting With ML
- Auto Pricing By Park Time And Pricings
- Data Movements Between Files With APIS
- Window Interface
- Real-Time UI Updates
- SQL Server Database Integration

---

## Technologies Used
- C#
- WPF - User Interface
- ASP.NET Core - C# API
- Python
- Yolo &(mls) - License Plate Detection
- FastAPI - Python API
- Uvicorn - Python API Server
- SQL Server - Database Management

---

 ## Program Flow
 - Image Uploading via Button(.png and .jpeg)
 - Image Sent To Python For License Plate Detection
 - Plate Returns To C#
 - Check Database If Car Have Been Inside
 - If It Been Inside Database Updates Exit Date And Calculates Price
 - Else Insert New Bill Into Database
 - Display Bills In The Stack Panel (Active/non-Active)


 
