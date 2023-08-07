# TokenManagementSystem
## Description
I have halfway done the project and will consider customer management part and report generation part

## Table of Contents
- [Technologies Used](#technologies-used)
- [Database Schema](#database-schema)

## Technologies Used
MS SQL
.Net Core 7 (MVC)

## Database Schema

### Tokens Table
| Column Name       | Data Type   | Description                        |
|-------------------|-------------|------------------------------------|
| TokenID           | varchar(50) | Unique identifier for the token.   |
| CustomerID        | varchar(50) | Identifier for the customer.       |
| ServiceCounter    | varchar(50) | Identifier for the service counter.|
| ResolutionStatus  | varchar(50) | Status of the resolution.          |
| CreatedAt         | datetime    | Timestamp of token creation.       |
| CategoryID        | varchar(50) | Identifier for the category.       |

### Locations Table
| Column Name       | Data Type   | Description                        |
|-------------------|-------------|------------------------------------|
| Id                | int         | Unique identifier for the location.|
| Name              | nvarchar(50)| Name of the location.              |


