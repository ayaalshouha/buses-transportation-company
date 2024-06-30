# buses-transportation-company

## Overview
This application is designed to manage daily and monthly financial transactions for a transportation company. It records various types of expenditures and calculates net amounts on a daily and monthly basis. Additionally, it allows users to query specific financial data for analysis.

## Features
*Daily Exchange Data*:
- Record daily financial transactions, including:
  * Total amount
  * Repair amount
  * Worker pay amount
  * Fuel amount
  * Company pay amount
  * Bus's Number
- Compute net amount for the day.

*Monthly Exchange Data*:
  - Calculate the monthly net amount (which is sum of the daily net amounts).
  - Adjust monthly net amount by subtracting worker salary and a backup amount (user enter a backup amount every month).
  - Distribute the adjusted net amount among users based on their percentage share.
  - Compute total backup amount from monthly backup amounts.
   
  *Data Querying*:
  
  - Users can query total amounts for specific categories (e.g., total fuel amount) over a specified period and bus number. 
  - Support for querying all fields in the system.
   
## Technology Stack
  - Frontend: C# Windows Forms
  - Backend:
    * Business Logic Layer (BLL)
    * Data Access Layer (DAL)
    * Database: SQL Server
    
## Architecture

The application follows an N-tier architecture:

**Presentation Layer**: C# Windows Forms application providing the user interface.

**Business Logic Layer**: Handles business rules and data processing.

**Data Access Layer**: Manages database interactions.

**Datatype Layer**: Holds user-defined data types that are used across all layers.

**Database**: SQL Server storing all application data.

## Screenshots 

**main form**

![main](https://github.com/ayaalshouha/buses-transportation-company/assets/129595827/f8ab340e-ac89-472b-8998-e32b461399bc)

**add daily exchnage** 

![daily](https://github.com/ayaalshouha/buses-transportation-company/assets/129595827/26efebf5-69f4-4c8c-b014-119a4be1801c)

**add monthly exchnage** 

![month](https://github.com/ayaalshouha/buses-transportation-company/assets/129595827/3b29c162-88a4-4f14-8334-cb4f2e134ead)

**total daily exchnages**

![dailyy](https://github.com/ayaalshouha/buses-transportation-company/assets/129595827/626bca0e-4211-4587-b364-c3927a9ca117)

**queries section**

![Screenshot 2024-06-30 180742](https://github.com/ayaalshouha/buses-transportation-company/assets/129595827/81db85b6-c772-4238-aa13-5ea535533200)


**single form to retrieve the total backup amount directly**

![Screenshot 2024-06-30 180803](https://github.com/ayaalshouha/buses-transportation-company/assets/129595827/b7c57eb4-44fa-4ba3-955f-650704d7d0aa)







