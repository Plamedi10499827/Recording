# Cybersecurity Awareness Chatbot

## Introduction

The Cybersecurity Awareness Chatbot is a C# console application designed to educate users about basic cybersecurity and online safety. The chatbot interacts with the user, provides personalised responses, and offers information about important cybersecurity topics.

The application includes a voice greeting, a cybersecurity-themed ASCII logo, coloured console output, input validation, and a typing effect to improve the user experience.

---

## Features

### Voice Greeting

When the application starts, a recorded `.wav` voice greeting is played to welcome the user.

### Cybersecurity Logo

A cybersecurity-themed ASCII logo is displayed when the application starts.

### Personalised User Interaction

The chatbot asks the user to enter their name and uses their name throughout the conversation to create a personalised experience.

### Cybersecurity Topics

The chatbot can provide information about:

* Password Safety
* Phishing Scams
* Safe Browsing
* General Cybersecurity and Online Safety

### Input Validation

The application handles invalid input by:

* Preventing the user from entering an empty name.
* Detecting empty questions.
* Providing a friendly response when it does not understand a question.
* Validating the user's menu choice when choosing whether to continue or exit.

### Enhanced Console User Interface

The application uses:

* Different console colours.
* Headers and separators.
* A cybersecurity-themed ASCII logo.
* Clear prompts and messages.
* A typing effect for chatbot responses.

---

## Technologies Used

* C#
* .NET 8.0
* Visual Studio
* System.Media
* System.Windows.Extensions

---

## Project Structure

```text
Recording/
│
├── Audio/
│   └── Bope_recording.wav
│
├── Program.cs
├── Logo.cs
├── ChatBot.cs
├── Recording.csproj
└── README.md
```

### Program.cs

This file is responsible for starting the application. It:

* Sets the console title.
* Clears the console.
* Displays the cybersecurity logo.
* Plays the voice greeting.
* Starts the chatbot.

### Logo.cs

This class is responsible for displaying the cybersecurity-themed ASCII logo and application title.

### ChatBot.cs

This class handles the main chatbot functionality, including:

* Asking for the user's name.
* Validating user input.
* Providing personalised responses.
* Responding to cybersecurity-related questions.
* Displaying the available topics.
* Allowing the user to continue or exit.
* Displaying a personalised goodbye message.

---

## Installation and Setup

Follow these steps to run the application:

### 1. Clone the Repository

Clone or download the project from GitHub.

```bash
git clone YOUR-GITHUB-REPOSITORY-URL
```

### 2. Open the Project

Open the project in Visual Studio.

### 3. Restore Dependencies

Visual Studio should automatically restore the required NuGet packages. If necessary, restore the packages manually before running the project.

### 4. Check the Audio File

Make sure the voice recording is located in the following folder:

```text
Audio/Bope_recording.wav
```

### 5. Run the Application

Run the application using Visual Studio by pressing:

```text
Ctrl + F5
```

Alternatively, run the project using the .NET CLI:

```bash
dotnet run
```

---

## How to Use the Chatbot

1. Start the application.
2. The cybersecurity logo will be displayed.
3. Listen to the voice greeting.
4. Enter your name when prompted.
5. Ask the chatbot a cybersecurity-related question.
6. You can ask questions about topics such as:

   * Password safety
   * Phishing
   * Safe browsing
   * General cybersecurity
7. Enter `1` to ask another question.
8. Enter `0` to exit the application.

### Example Questions

You can try asking:

```text
How are you?
```

```text
What is your purpose?
```

```text
What can I ask you about?
```

```text
How can I create a strong password?
```

```text
What is phishing?
```

```text
How can I browse safely?
```

You can also type:

```text
help
```

to view the available topics.

---

## Input Validation

The chatbot validates user input to improve the user experience.

### Empty Name

If the user does not enter a name, the chatbot displays an error message and asks for the name again.

### Empty Question

If the user enters an empty question, the chatbot informs the user and allows them to try again.

### Unknown Questions

If the chatbot does not recognise a question, it provides a friendly response and suggests using `help` to view the available topics.

### Invalid Menu Choice

When the user chooses whether to continue or exit, only the following options are accepted:

```text
1 - Ask another question
0 - Exit
```

Any other input results in an error message.

---

## Example Interaction

```text
Please enter your name: Bope

Welcome, Bope!
I am your Cybersecurity Awareness Chatbot.
I am here to help you learn how to stay safe online.

Bope: What is phishing?
Bot: Phishing is a scam where criminals try to trick you into giving away personal or sensitive information.
Be careful of suspicious emails, messages and links.

Enter 1 to ask another question or 0 to exit: 1
```

---

## Author

**Plamedi Bope**

Student Number: **ST10499827**

Module: **PROG6221**

Assignment: **Cybersecurity Awareness Chatbot**
