Event Management System
Project Overview
The Event Management System is an application designed to streamline the management of events, venues, attendees, and bookings. It utilizes object-oriented programming concepts like classes, interfaces, inheritance, and a modern graphical user interface built with .NET MAUI.

This system solves common event management challenges, such as tracking bookings, ensuring venue capacity compliance, and organizing attendee data, all while providing a seamless user experience.

Key Features
-Event and Venue Management: Organize events and link them to suitable venues with details like location, capacity, and availability.
-Attendee Tracking: Store and manage attendee information, including contact details and event participation.
-Booking System: Handle attendee registrations and validate bookings to prevent scheduling conflicts or overbooking.
-Database Integration: Persistent data storage is powered by Entity Framework Core using DbSet properties for core entities.
-User Interface: A modern, cross-platform GUI developed with .NET MAUI ensures accessibility and ease of use.
-Error Handling: Robust exception handling ensures a smooth and error-free experience for users.

Technologies Used
Language: C#
Framework: .NET MAUI
Database: Entity Framework Core
Design Patterns: Object-Oriented Programming with Classes, Interfaces, and Inheritance

Core Classes
-Event: Represents an event with attributes like name, description, date, and a reference to its venue.
-Venue: Stores venue information, including name, location, and capacity.
-Attendee: Tracks attendee details such as name, email, and phone number.
-Booking: Links attendees to events and ensures proper tracking of registrations.

Problem Solved
Managing events manually is often inefficient and error-prone due to overlapping schedules, venue capacity limits, and scattered attendee information.

The Event Management System addresses these problems by:

-Centralizing data for easy access and organization.
-Automating conflict resolution for venue bookings and attendee registrations.
-Providing an intuitive GUI to streamline event setup and management processes.

Contributors
-Jesse Umweni
-Abel Fekadu
-Adlin Firdaus