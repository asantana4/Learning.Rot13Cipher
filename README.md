# Rot13 Cipher


A simple C# application that encodes and decodes text (as a String) using the ROT13 substitution cipher.

---
## About the project

This project is based on the simple letter substitution cipher Rot13 that replaces letters with the 13th letter after it
in the latin alphabet (after letter Z, the count continues from letter A). It represents my own implementation of the problem.

### Background

ROT13 ("rotate by 13 places") is a simple letter substitution cipher that replaces a letter with the 13th letter after it in the alphabet.

It is a specific variation of the Caesar cipher. Because the basic Latin alphabet has exactly 26 letters, ROT13 is its own inverse. 
This means the same action can be used for encoding and decoding.

This program demonstrates how both, a plain text and a cipher text (an obfuscated message) can be processed using the exact same ROT13 
sequence.


### Alphabet

Standard English Alphabet: `A-Z`, `a-z`

Numbers, symbols, and whitespace are not shifted and remain unchanged.


### Rotation rules

#### First half of the alphabet (A-M)

A ↔ N
B ↔ O
C ↔ P
D ↔ Q
E ↔ R
F ↔ S
G ↔ T
H ↔ U
I ↔ V
J ↔ W
K ↔ X
L ↔ Y
M ↔ Z


#### Second half of the alphabet (N-Z)

N ↔ A
O ↔ B
P ↔ C
Q ↔ D
R ↔ E
S ↔ F
T ↔ G
U ↔ H
V ↔ I
W ↔ J
X ↔ K
Y ↔ L
Z ↔ M

---
## Built with

- .NET 10.0 (or your targeted .NET version)
- xUnit (for unit testing)

---

## Development environment

- Visual Studio / JetBrains Rider / VS Code (used during development)

---

## Getting started

### Prerequisites

- .NET SDK 10.0 or later

### Getting the Project 

1. Clone the repository:
```bash
git clone https://github.com/asantana4/Learning.Rot13Cipher.git
cd Learning.Rot13Cipher
```

2. Alternatively, download the repository as a ZIP file and extract it


### Running the project

You can run the tests or execute the program from the command line using the .NET CLI.


#### Run tests
```bash
dotnet test
```

This will build the project and run all unit tests located in the test project. 


#### Run the program
```bash
dotnet run
```
This will launch the interactive console application where you can enter your text.

---
## Usage

When you start the program, it will prompt you to enter a message. After entering the message, you will enter 
an interactive loop where you can press `T` to apply the ROT13 cipher to the current text. Because ROT13 is its own 
inverse, pressing `T` again will revert the text to its original state.

### Example

#### Initial Prompt:

When you run the application, you are greeted with:

```
Rot13 Cipher    

Type in the message to transform:
```

#### First Transformation (Encoding):

After typing in "Hello, World!" and pressing `Enter`, the screen clears and shows your original message:

```
Rot13 Cipher    

========================================
Hello, World!
========================================
Press 'T' to transform the message. Press any other key to end the program:
```

If you press `T`, the program updates the screen with the cipher text:

```
Rot13 Cipher    

========================================
Uryyb, Jbeyq!
========================================
Press 'T' to transform the message. Press any other key to end the program:
```

#### Second Transformation (Decoding):

If you press `T` again, the same ROT13 logic is applied, restoring your original message:

```
Rot13 Cipher    

========================================
Hello, World!
========================================
Press 'T' to transform the message. Press any other key to end the program:
```

Pressing any key other than `T` will exit the application.

## Learning goals

This project is a small C# program created to practice core programming and problem-solving skills. 
It focuses on string manipulation, core logic, and basic interactive console I/O using loops and key 
interception. The project is intended as a learning exercise rather than a production-ready application.

---
## Feedback

Open to suggestions and improvements.

---