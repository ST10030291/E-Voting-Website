# Election Platform - Prototype System (PSystem) - Avish Judnarain - JDNAVI001

## 1. Overview
This E-Voting Platform is a versatile and interactive online voting platform designed to enhance inclusivity, transparency, and security in the electoral process. The system facilitates seamless voter registration, real-time polling, and live election result tracking. It supports role-based access (Admin/Voter) and ensures data integrity through secure authentication, robust verification, and scalable performance optimizations. 
#### IMPORTANT 
I added the following parties: ANC, DA, EFF, NationalOnly and ProvincialOnly. The last two are to compare the difference between parties registered with juridiction level National or Provincial and the reminder are recorded as Both.  
All party vote counts where populated to simulate similar recent elections. For example there are ONLY 4 valid votes in the database BUT I added votes manually in firebase by editing the field column value for ANC-DA-EFF Nationally by adding 5-4-1 votes respectively and the same ratios of vote provincially for DA-ANC-EFF. This was to give a more realistic look of the graphs in the stats section however the system does allow voters to vote only once and reflects accurately any new votes. The current ongoing election that I have added and you will see in the database will end on 1 Dec so the website can be viewed while an election is in progress.

The App makes use of international coding standards by using references, comments and error handling. I decided not to use a template and code the website from stracth as it would be easier to find my css code etc. I choose to make an unofficial IEC voting platform
and the color pallete is consistent with the IEC brand and a modern and simple approach was taken, it was crucial not to over complicate annimations, voting rules etc as an important factor of this website is accessibility especially for all age groups.
##### YouTube Link (Application Demonstration) 

#### Election Platform Link

#### GitHub Link

#### LinkedIn 
https://www.linkedin.com/in/avish-judnarain-5b8430251/

---

## 2. Table of Contents
- [Overview](#1-overview)
- - [Features](#3-technologies-used)
- [Getting Started](#4-features)
- [Class Diagram](#5-class-diagram)
- [Conclusion](#6-conclusion)
---

## 3. Technologies Used
- FrontEnd Design
I chose to design the application myself without a template as this was easier than clashing with css from a template, I used a C# Web App with the .NET framework.

- BackEnd Design
I incorporated the MVC Framework by creating my models in C# which were saved to Firebase, my views were designed with html and css, and my controller was Javascript to handle all the logic of the application. I used OOP principles to structure the application into modular, reusable classes such as User, Vote, Election, and Party. Each class encapsulates its properties to handle specific behaviors like validation or saving data to Firestore. Inheritance allows shared functionality, such as a base class for common properties across models like Id and timestamps. Polymorphism enables flexible handling of different role-based user actions.

- Database
My chosen database is Firebase as iv worked with firebase for many android apps especially in my degree. Working with JavaScript and firebase was new to me however as I was used to using Kotlin but I have worked alot with JS in my degree and personally before for hackathons etc so adding the database functions was just youtube video away. I chose to save users in the Realtime Database and other data (like elections, parties, and votes) in Cloud Firestore based on their specific needs for performance, scalability, and real-time synchronization. The Realtime Database is well-suited for handling simple, real-time user data, such as an authenticated users details like ID Number and Province. Storing users in Realtime Database allows for efficient real-time updates and synchronization across all connected devices. When users log in, their data can be quickly retrieved, and any updates, such as user roles or vote status, can be instantly reflected on all connected clients.

For more complex, structured data like elections, parties, and votes, Firestore is a better choice because it supports richer querying capabilities, better scalability, and more efficient handling of larger datasets. Firestore’s document-model allows for flexible, hierarchical data storage, making it easier to scale as the number of users, parties, and votes increases. Additionally, Firestore's real-time capabilities allow for synchronized updates across clients, ensuring that users always see the latest election results and data. By saving votes in Firestore, I can take advantage of its ability to scale efficiently. Firestore can handle large volumes of reads and writes, allowing many users to vote simultaneously without performance degradation. As votes are saved in Firestore, the system automatically updates in real-time, ensuring that votes are counted accurately and simultaneously without delay, which is crucial for large elections with a high number of voters.

- Verification of registered voters
All users emails will be checked by mailcheck.ai when registered and the system will detect a disposable email, unfortunetly due to the cost I couldnt implement the verifyid api but I am sure it would take 15min to implement. The system also checks a users ID to make sure it is 13 Digits long which is the length of all SA ID numbers.

- Authentication
The system makes use of Firebase Authentication as well as email-based account verification. Firebase Auth is integrated seamlessly with both Realtime Database and Firestore, it allows me to scale the application and manage user access effectively across different platforms

- Version Control
GitHub was my version control of choice. The application was created and pushed initially to github and completed afterwards over incremental commits which were descriptive via the CMD.

- Asynchronus Programming
I used JavaScript's async/await syntax for handling asynchronous operations, such as fetching data from Firestore (e.g., election data, party details) and submitting votes. For instance, when a user casts a vote, the app asynchronously sends the vote to Firestore, updates the vote count, and reflects the changes in real-time. By using Promises and async/await, I avoid UI freezing or delays during critical actions like vote submission or data retrieval. This keeps the platform responsive and fast, especially when interacting with Firebase or processing user input.

- Responsivness
To ensure that the app is accessible and user-friendly across different devices (desktops, tablets, and smartphones), I used CSS media queries. These queries allow the platform’s layout to adapt to various screen sizes and orientations. The HTML structure of the app is built with semantic HTML elements and proper CSS classes to ensure that the app scales well across devices. I used a flexible layout model, such as CSS Grid and Flexbox, for the layout of various sections. 

- Bonus Features Added
Color Palette was Blue and Gray and kept with the IEC brand. The Design was a minimalistic approach with a modern feel.
Provincial voting and poll results were added as a feature into the application. You can filter the provincial results of each province and the ranking table will update for that province (ps not every province has voters from there because I couldnt make accounts for all provinces but KZN and Gauteng are some of the provinces with provincial data already saved but this will populate as intended as voters cast their votes).
---
  
## 4. Features
- Role Based Access
Admins and Voters have different features. An admin can add partys or even delete them with a single click and can also start elections. Voters can view the rules of voting and how to vote and then proceed to vote once for a national and provincial party, currently there is the same provincial partys for all provinces but this can definetly be specific to a province with future updates.
- Authentication
MailCheck.ai was successfully implement to detect disposable emails. The verifyid API can definetly be implemented but I didnt include this due to costs but the app does input validate the ID number to make sure its exactly 13 digits as a valid SA ID number.
Admins can only be entered into the system via the backend so it is not possible for users to register as admins. Firebase Auth was used.
- Live Poll Results
Guests that are not yet registered can still view the current polls on the home page along with all the other stats , news and social media posts etc.
- About Page
Gives more info about the brand and the history and importance of elections.
- Engagement Features
Small animations and changing quotes have been put around the app to keep the spirit and importance of elections. Progress bars have also been included in some forms.
- Voting Rules Page
Gives users a break down of the rules and procedure to follow when casting their vote online.
- Home Page Statistics
Apart from the normal polls and rankings Nationally and Provincially, stats in the form of a pie chart displayed the percetage of votes for a specific party , a bar graph displaying the amount of voters from each province and a line graph displaying the current trend in votes for the top 3 parties nationally only displays the projected winner. 
---

## 5. Class Diagram
---
## 6. Conclusion
