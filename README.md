# DotNet_Basic_Web_Project
 This repository contains codes for a simple .net MVC web project.

## Overview
In this project, I embed a ready-made html template in my project and made some parts dynamic. So I have a website belonging to a travel company, and I was able to dynamically pulling hotel information.

Firstly i needed to include entity framework in my mvc project. So I downloaded the entity framework.

Then I downloaded a ready-made template from the internet.

Then I added this template's file to my project. Then I added a default controller to the controller section. I opened a view here. I copied the html tags I downloaded from the ready template and pasted them on the index html cs side.

Since files like css js image stay at different addresses, I edited them. Then i opened an entity folder under the models folder. I opened a class named Hotels in the entity folder. This class will be required for our tables in our database. I entered the id, detail, percentdata information to the class.

The class named context will provide the connection between this class and the database. And I established the connection between my context class and my database.After creating the migration, I created the database by clicking update database on the SQL side.

In the database section, I entered the data we wanted in our table. Finally, I edited the data I received from the database on the html side.

