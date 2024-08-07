Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. (Behavioral)

In a factory, there is a need to monitor and manage requests for truck entries. The requests have to be approved. A service running in the server monitors database and if it found a request pending it changes the subject state that will notify all services that are registered.

Solution with Observer Pattern:

1. Subject (Observable): The service that monitors the database. This service maintains a list of observers and notifies them.

2. Observer: An interface for services that need to be notified of changes in the request status. Each observer implements an update method to handle the notification.

3. Concrete Subject: The specific implementation of the monitoring service that checks the database for status changes and notifies the observers.

4. Concrete Observers: Specific services that need to be notified of status changes. These include:

• Email Notification Service: 

• WhatsApp Messaging Service: 

• SMS Messaging Service: 

• Push Notification Service: 

• Gate Control Service: 

• Security Notification Service: Notifies security with the driver's photo and vehicle license plate when a request is approved.

Workflow:

1. Monitoring Service: Continuously monitors the database 

2. Request Status Change: the monitoring service notifies all registered observers.

3. Observers React: Each observer performs its specific operation.

Benefits:

• Decoupling: The monitoring service and the various notification services are loosely coupled. The monitoring service does not need to know the details of each notification service.

• Flexibility: New notification services can be added without modifying the monitoring service.

• Scalability: Multiple services can be notified efficiently, ensuring that all necessary actions are taken when a request's status changes.
