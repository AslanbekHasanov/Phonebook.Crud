# Phonebook.Crud
In the Phone book project, you can see a 
CRUD operation using an Array in the C# programming language along with the members that make up a Class.

## **0.0 Initial view of the project**
The project will write, delete, read and 
update the Phone Book data to the array.

<br>

##### **Image**
![Home-Page](/Images/home-page.png)
<br>

### **0.1 There are 5 different situations in the program.**
1. Create new phone book
2. Update phone book
3. Delete one phone book
4. Get one phone book
5. Get all phone book information

<br>

## **1.0 Create new phone book**
When creating a new phone book, 
it will create if the phone information 
is not in the database, otherwise it will
warn that this information is available.


### **1.1 If this information is available in the database**
Warns that this information exists and returns false.

<br>

#### **Run Code**
![Created-Before](/Images/Gif/created-before.gif)

<br>

### **1.2 if the name and phone are not in the database**
In this process, the incoming data will not be available 
in the main database, and the data will be written to the
overhead location.

<br>

#### **Run Code**
![Creat](/Images/Gif/creat.gif)

<br>

## **2.0 Update phone book**
If there is information in this section, 
it will update, if not, it will warn that 
the information is loaded.

### **2.1 If this information is in the database**
Replaces the data by the given id with the new data if
it exists in the database and returns true.
<br>

#### **Run Code**
![Update](/Images/Gif/update-one.gif)

<br>

### **2.2 If this information is not available in the database**
If the specified id does not exist in the database, the program
warns about the absence of information and returns a value of false

<br>

#### **Run Code**
![Update](/Images/Gif/update-two.gif)

<br>

## **3.0 Delete one phone book**
Opens data by the given id and returns 
true if data exists otherwise false

### **3.1 if there is data at the given id** 
The program deletes the data if the given id 
exists in the database.

<br>

#### **Run Code**
![Delete](/Images/Gif/delete-one.gif)

<br>

### **3.2 If there is no information on the given id in the database** 
If there is no data at the given id, the program will warn that the
data was not found

<br>

#### **Run Code**
![Delete](/Images/Gif/delete-two.gif)

<br>

## **4.0 Get one phone book**
If the given id contains data,
the program returns the data,
otherwise, it warns that it was not found

### **4.1 if there is data at the given id**
The program returns information if there is 
information in the database for the given id.

<br>

#### **Run Code**
![Read](/Images/Gif/read-one.gif)

<br>

### **4.2 If there is no information in the database for the given id**
If there is no information on the given id, the program will warn 
about the absence of information

<br>

#### **Run Code**
![Read](/Images/Gif/read-two.gif)

<br>

## **5.0 Get all phone book information**
If there is information in the database, 
it returns all information, otherwise the 
program warns that there is no information

### **5.1 If a member has information**
The program prints non-null data in the
database to the console.

<br>

#### **Run Code**
![Read](/Images/Gif/read-all-one.gif)

<br>

### **5.1 If there is no information in the database at all**
The program warns that all data in the database is null, 
and no data is output to the console

<br>








