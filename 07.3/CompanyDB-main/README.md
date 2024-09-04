# CompanyDB CDB

> CDB a Programming course mini project

### what is it

Company database program that features a GUI with multiple forms and screens to read and write to said database of company employees.

##### Demo Photo:
![Demo picture](https://raw.githubusercontent.com/karimkohel/CompanyDB/main/examplepic.PNG "Demo")

##### Demo Video:
[![Demo](http://img.youtube.com/vi/S5bzzSTNCdY/0.jpg)](http://www.youtube.com/watch?v=S5bzzSTNCdY "Demo")

---

### Usage

##### Requirements
The app requires a database consisting of 2 csv files that can be created or loaded from home page and must be present for the app to continue working as intended.

##### Function
The app can create new employees and departments to the database, search and edit them while keeping data in the csv files in the same directory they are intended to be.

Searching employees can be done through the search bar at the home page with the employee name, social security number or address.

Refreshing the database is necessary for newly created employees or departments to show so a refresh button appears at home page when database is loaded.

About button shows options to get to know more about the app, get help or know more about the developer.

All options and functions should be accessible from menu strip in home page.

#### Structure
The structer of the app internally is made up of 2 components:
- The back end as a C# code library that is written seperate from the UI project and can be re-used with any other front end structure.
- The front end is comprised of a basic Winforms App using the .Net Framework and houses all UI related logic like:
    - form validation for all user entry forms
    - form structure and design
    - xml comments to help with code readability when needed


---

###  TO DO:

- [X] Documentation
- [X] Rigorous and random testing
    - [X] Resolve multiple names in departmentemployees (globalconn -> loadempsindep -> check emp duplication)
    - [X] Update employee acting funny (wromg department number)
    - [X] wrong names in departmentemployees
- [x] Back end
    - [X] Employees class
        - [X] Base class
        - [x] User input filteration
        - [x] Birthday logic
        - [X] Serialization
    - [X] Department class
        - [X] Base Class
        - [X] User input filtration
        - [X] Serialization
    - [X] Load Database implementation (Text files)
    - [X] Create new database
    - [X] Add data in employee list box
    - [X] Single employee lookup logic
    - [X] Search logic
    - [X] Reload home list boxes
    - [X] Salary Summation Logic
    - [X] Exception handling for file reading and writing
- [X] Front end
    - [X] Home Page
    - [X] Add employee page
    - [X] Add department page
    - [X] Single Employee sheet page
    - [X] Employee search
    - [X] Salary summation and other stats page
    - [X] Form for all departments and their respected employees
    - [X] Add refresh both dbs in file strip menu
    - [X] Remove connecting database succes msg
    - [X] Make enter key submit forms
    - [X] Include more details in emp and dep list boxes in all forms
    - [X] About Buttons (With web-browser)


### License 
> This is my private work for my second midterm evaluation that is now open as documentation
