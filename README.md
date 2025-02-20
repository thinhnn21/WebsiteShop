MINISTRY OF EDUCATION & TRAINING
HO CHI MINH CITY UNIVERSITY OF ECONOMICS AND FINANCE

 

FINAL PROJECT
Course: Web Application Development
Course code: 232.ITE1265E.B02E


ONLINE SHOPPING WEB APPLICATION


	
	
	Lê Phước Vinh - 215050283
	Nguyễn Ngọc Thịnh - 215101362	





Ho Chi Minh city -   
MINISTRY OF EDUCATION & TRAINING
HO CHI MINH CITY UNIVERSITY OF ECONOMICS AND FINANCE

 

FINAL PROJECT
Course: Web Application Development
Course code: 232.ITE1265E.B02E


ONLINE SHOPPING WEB APPLICATION


	
	
	Lê Phước Vinh - 215050283
Nguyễn Ngọc Thịnh - 215101362


	Instructor: Ms.Phạm Thị Kim Ngôn

Ho Chi Minh city -   

TABLE OF CONTENTS
TABLE OF CONTENTS	i
LIST OF ABBREVIATIONS	ii
LIST OF FIGURES	iii
Chapter 1 . DECRIPTION	2
1.1 Project Overview	2
1.2 Objectives	2
1.3 Key Features	2
1.3.1 Home Page:	2
1.3.2 Product Page by Category:	2
1.3.3 Product Detail Page:	3
1.3.4 User Authentication:	3
1.3.5 Shopping Cart:	3
1.3.6 Category Management (Admin):	3
1.3.7 Order Management (Admin):	3
1.3.8 Customer Management (Admin):	3
Chapter 2 . SYSTEM DESIGN	4
2.1 USE CASE DIAGRAM	4
2.1.1 Usecase diagram for customer function	4
2.2 Database design	4
2.2.1 Attendence table	4
Chapter 3 . ERD	5
Chapter 4 . VIEW	6
CONCLUSIONS	7
 

LIST OF FIGURES
Figure 1 1 Usecase diagram for all functions of BrewMaster	3
Figure 1 2 All tables from db	4
Figure 2 1 Login view	8
Figure 2 2 Product menu view	9
Figure 2 3 Confirm order by staff view	10
Figure 2 4 Branch manager view	10
Figure 2 5 Brand manager view	11
Figure 2 6 Customer sequence diagram	11
Figure 2 7 Staff sequence diagram	12
Figure 2 8 Branch manager sequence diagram	13
Figure 2 9 Brand manager sequence diagram	14


 
 
Chapter 1 .	DECRIPTION
1.1	PROJECT OVERVIEW
Online shopping web applications are online platforms that allow users to browse and purchase products and services from different vendors through the internet. It is an integral part of today's e-commerce market and has become one of the most popular business models globally.

1.2	OBJECTIVES
•	Optimize user experience
•	Diversify products and services
•	Quality and trustworthy
•	SEO Optimization
•	Integrate useful features
•	Security and safe payment
•	Professional customer care
•	Sustainable development and expansion
•	Continuous innovation and upgrading
1.3	KEY FEATURES
1.3.1	Home Page:
1.	Displays a list of product categories.
2.	Showcases two groups of products (e.g., best sellers, hot products).
1.3.2	Product Page by Category:
1.	Displays products filtered by selected categories.
1.3.3	Product Detail Page:
1.	Provides detailed information about a selected product, including images, description, price, and stock availability.
2.	Allows users to add the product to their shopping cart.
1.3.4	User Authentication:
1.	Register: Users can create a new account.
2.	Login: Registered users can log in to access their account.
3.	Logout: Users can log out of their account.
1.3.5	Shopping Cart:
1.	Users can add products to their cart.
2.	Users can update the quantities of products in their cart.
3.	Users can remove products from their cart.
4.	Users can proceed to checkout and place orders.
5.	The cart is saved to the database for persistent storage.
1.3.6	Category Management (Admin):
1.	Admins can view a list of product categories.
2.	Admins can add, update, and delete categories.
1.3.7	Order Management (Admin):
1.	Admins can view a list of orders.
2.	Admins can view details of each order.
3.	Admins can update the status of orders.
1.3.8	Customer Management (Admin):
1.	Admins can view a list of customers.
2.	Admins can view orders placed by each customer.
Chapter 2 .	SYSTEM DESIGN 
2.1	USE CASE DIAGRAM

Figure 2 1 Usecase diagram 

2.1.1	Usecase diagram for customer function
 Customer can interact with the web application to Browse, Search Products, View Product Details, Purchase and Manage Products
2.1.2	Usecase diagram for admin function
The Admin can manages the Categories, Products, Orders and manage Customers
2.2	DATABASE DESIGN

Figure 2 2 All tables from db

2.2.1	Product table
Include 8 properties: ID, Name, Price, Quantity, Image, Description, CategoryID, SaleOff and ID is the primary key.
2.2.2	Category table
Include 3 properties: CategoryID, Name, Description and CategoryID is the primary key.
2.2.3	Cart table
Include 3 properties: ID, TotalPrice, CustomerID and ID is the primary key.
2.2.4	CartItem table
Include 4 properties: ID, CartID, ProductID,Quantity and ID is the primary key.
2.2.5	Invoice table
Include 7 properties: ID, CusID, ShipAdd, ShipPhone, Status, Total, Date and ID is the primary key.
2.2.6	InvoiceDetail table
Include 5 properties: ID, InvoiceID, ProductID, Quantity, Price and ID is the primary key.
2.2.7	Customer table
Include 7 properties: ID, Name, Phone, Address, Mail, Pass,Salt and ID is the primary key.

 

Chapter 3 .	ERD
 


Chapter 4 .	VIEW


Figure 2 1 Register view
 

Figure 2 2 Login view
 

Figure 2 3 Home page view
 
Figure 2 4 List Category view
 
 
Figure 2 5 Featured  Products view
 

Figure 2 6 Recent  Products view
 
Figure 2 7   Products Detail view
  
CONCLUSIONS
The Online Shopping Web Application project successfully achieved its primary objectives by providing a fully functional platform for online shopping. The following key features were implemented and thoroughly tested:

1. User Authentication:
   - Secure registration, login, and logout functionalities were implemented using JSON Web Tokens (JWT) to ensure user data security and privacy.

2. Product Management:
   - A comprehensive product management system was created, allowing products to be categorized, viewed in detail, and managed through an intuitive admin interface.

3. Shopping Cart:
   - Users can add products to their shopping cart, update quantities, remove items, and proceed to checkout. The shopping cart's state is preserved between sessions through database storage.

4. Order Management:
   - A complete order management system was built for users to place and track orders. Admins can view, update, and manage orders effectively.

5. Customer Management:
   - Admin functionalities were developed to manage customer information and view their order history, enhancing customer service and support capabilities.

6. Category Management:
   - Admins can efficiently manage product categories, including adding, updating, and deleting categories.

7.Technical Achievements
- Frontend Development:
  The frontend was developed using React.js, ensuring a responsive and user-friendly interface. State management was handled with Redux to maintain a consistent and scalable state throughout the application.
- Backend Development:
  The backend was built using Node.js and Express.js, providing a robust and scalable API for handling all necessary operations. MongoDB was used for database management, ensuring efficient data storage and retrieval.
 Challenges and Solutions
- Security:
  - Implementing JWT for authentication secured the application against common vulnerabilities such as session hijacking and cross-site scripting (XSS).
- Performance Optimization:
  Database queries were optimized, and indexes were used in MongoDB to ensure quick data retrieval and efficient performance under load.
- User Experience:
  A focus on intuitive design and responsive layout ensured a positive user experience, making the application accessible on various devices and screen sizes.

 Future Work and Enhancements
- Advanced Search and Filtering:
  Implementing search functionality and advanced filtering options will enhance the user’s ability to find products quickly and efficiently.
- Payment Integration:
  Integrating payment gateways like PayPal or Stripe to facilitate online transactions will provide a complete e-commerce experience.
- Enhanced Analytics:
  Adding analytics for tracking user behavior, sales trends, and inventory management will provide valuable insights for business improvements.
- Improved Security Measures:
  Continuously updating security practices and performing regular audits will ensure the application remains secure against evolving threats.
- Scalability:
  Planning for horizontal scaling of the backend and database replication will prepare the application for increased traffic and data loads in the future.

The Online Shopping Web Application project successfully met its goals by providing a robust platform for online shopping, equipped with essential features for both users and administrators. The project demonstrated a comprehensive understanding of full-stack development, from frontend user interfaces to backend server logic and database management. By overcoming various technical challenges and implementing a wide range of functionalities, the team has created a solid foundation for future growth and enhancements in the e-commerce domain. The application not only serves its intended purpose but also offers ample opportunities for further development and scaling to meet more advanced requirements and larger user bases.

