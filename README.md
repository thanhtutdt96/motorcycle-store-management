# Motorcycle Store Management app
An easy-to-use tool help manage your store and administer staff, motorbike categories, products, suppliers, customers, orders, with a Office 2010 inpsired theme.

## Prerequisite
- DevExpress
- MSSQL Server
- .NET v4.8 or higher
- Microsoft SQL Management Studio
- Microsoft Visual Studio

## Installation
- Open `Microsoft SQL Management Studio`, execute the sql files in `Database` folder.
- Connect Visual Studio with SQL Server in `Data Sources`, reference to the created database. Then collect the connection string like the following
```
Data Source=XXX;Initial Catalog=QuanLyBanXe;Integrated Security=True
```
- Update the `Source/QuanLyBanXe.DAO/DataProvider.cs` connection string with the collected one.
```
conn = new SqlConnection(@"Data Source=XXX;Initial Catalog=QuanLyBanXe;Integrated Security=True");
```
