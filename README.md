Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered)
Conceptual Understanding:
 
  1. Onion Architecture: (Yes/No) 
    Have you heard of the Onion Architecture principle in software design?
 
    > No
 
  2. MVC Pattern: (Yes/No) 
    Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?

    >Yes
 
  4. Web API: (Yes/No) 
    Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?
 
     >Yes (some basic knowledge only)

Application & Bottlenecks:
Onion Architecture:
 
 
  1.Benefits: (1-3 keywords)
    Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
    
     > Decoupling
     > Testability
     > Clean Code
 
 
 
  2. Bottlenecks (Encountered): (Yes/No and Briefly Explain) 
     Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar  with the pattern)
 
     > Challenges yes, because it is our first encountering with the Onion Architecture so it makes it really challenging for me.
       One bottleneck that can occur with Onion Architecture is increased complexity, especially for smaller or simpler projects. The layers and abstractions involved in Onion Architecture may be overkill for projects with straightforward requirements, leading to unnecessary overhead in terms of development time and maintenance.
       And as for me who is not really familiar with the pattern makes it really challenging for me. I have limited experience with architectural patterns in general.
 

MVC:
 
 
  1. Components: (1-3 keywords each)
     Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
 
     > Model: Data, Business Logic, Persistence
     > View: User Interface, Presentation
     > Controller: Request Handling, Business Logic Coordination
 
 
  2. Bottlenecks (Encountered): (Yes/No and Briefly Explain) 
     Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)
 
     > Yes
     > Controller is tricky because its in isolation, Controller relies heavily on the model for data and logic, and it became hard to test controller
 

Web API:
 
 
  1. Differences from MVC: (Yes/No and Briefly Explain)
     Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
 
     > Yes
     > In traditional MVC (Model-View-Controller) applications, the focus is on delivering dynamic web pages to users. The Model represents the data and business logic, the View represents the presentation layer (HTML pages), and the                 Controller handles user interactions and updates the Model accordingly. The primary goal is to generate HTML responses that are rendered by the browser to create the user interface.
    > Web APIs (Application Programming Interfaces) are primarily used for communication between different software systems over the internet. Web APIs expose endpoints that allow clients to interact with the server and perform operations such       as retrieving data, updating resources, or executing specific tasks.
 
 
  2. Bottlenecks (Encountered): (Yes/No and Briefly Explain)
    Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If      so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange            requiring a more lightweight approach)

    > No
    > However, in scenarios where frequent page refreshes occur, traditional MVC applications may experience performance overhead due to the need to generate and render HTML pages dynamically. Conversely, Web APIs typically handle data               exchange in a more lightweight manner, which can be advantageous for scenarios involving complex data exchange or when optimizing for performance in client-server communication.
    
