# Creating ASP NET MVC Sites

The purpose of this project is three fold: 
1.  Provide a checklist for creating a new MVC website.  
2.  Demonstrate how to create a website without using the Entity Framework.  Many people like myself don't believe completely abstracting the database is a good idea for building true enterprise caliber systems.  
3.  Provide me a place to tinker around with different web page concepts.  

Project Creation:
1.  Create a new ASP.NET Web application using .NET Framework
2.  Choose the MVC template.

Nugent Packages:
1.  Bootbox
2.  Jquery.datatables
3.  Dapper

Bootstrap:
First, find a bootstrap framework you want to use. I used Bootswatch.com
1.  Download the bootstrap file and rename it bootstrap-<theme name>.min.css
2.  Import the file to the project's Content folder.  

Create following project folders:
1.  ViewModels
2.  Helper 
3.  DataAccess  

Make code updates to:
1.  Shared Views.  Breakout navbar to a seperate file than _Layout.cshtml.
2.  In App_Start, reorganize code in BundleConifg.cs.
