# CSharp-Data-Management-System
Windows Forms application built with C# using OOP, collections, and file handling.

# Project Overview
This is a Windows Forms application developed in C# that implements a matchmaking system. The application reads data about men and women from text files, matches them based on their last names, and manages the results through an interactive GUI.

# Features

# Core Functionality
Data Loading: Automatically reads men and women data from text files on startup
Queue-Based Processing: Women are stored in a Queue (FIFO), men are stored in a List
Matchmaking Algorithm: Matches couples based on identical last names
Real-time Display: Shows women waiting to be matched in the main display
Result Management: Organizes matched couples, single women, and single men

# User Interface
Display of all women in the queue
"Find a match" button for processing one woman at a time
Separate display areas for:
Matched couples
Single women (with number of children)
Single men (with distance from work)
Save functionality with radio button options

# Project Structure

# Classes:

Women.cs
Represents a woman with the following properties:
FirstName: First name
LastName: Last name (used for matching)
City: City of residence
Kids: Number of children

Men.cs
Represents a man with the following properties:
FirstName: First name
LastName: Last name (used for matching)
City: City of residence
Distance: Distance from work in kilometers

Couples.cs
Represents a matched couple:
ManName: Full name of the man
WomanName: Full name of the woman
Implements ToString() for display formatting

StoreData.cs
Handles data loading and storage:
Reads from men.txt and women.txt files
Stores men in a List<Men>
Stores women in a Queue<Women>
Parses file data according to the specified format

Form1.cs
Main form containing the application logic:
Manages the matchmaking process
Updates UI displays
Handles sorting of couples by last name
Implements save functionality
