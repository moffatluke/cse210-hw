# Scripture Memorizer 
# AI README FROM DIAGRAM I BUILT

## Overview
The Scripture Memorizer is a C# console application designed to help users memorize scriptures by progressively hiding words each time they press Enter. The program follows object-oriented programming principles, with a focus on encapsulation, separation of concerns, and clear class responsibilities.

This project was built as part of **CSE 210 – Programming with Classes**, Unit 03.

---

## Program Features
- Displays a scripture reference and full text
- Hides a random selection of words each time the user presses Enter
- Continues until all words are hidden or the user types `quit`
- Allows the user to select which scripture to memorize from a menu

---

## Program Flow
1. The program displays a menu of available scriptures
2. The user selects a scripture to memorize
3. The memorization loop begins:
   - The console is cleared
   - The scripture is displayed
   - The user presses Enter to hide more words or types `quit`
4. The program ends when all words are hidden or the user quits

---

## Class Design

### Program
**Responsibility:**
- Handles user input and output
- Displays the menu
- Controls the main program flow

The `Program` class does not contain scripture logic. It orchestrates the application by calling methods on other classes.

---

### ScriptureLibrary
**Responsibility:**
- Stores all available scriptures
- Returns a `Scripture` object based on user selection

**Key Concepts:**
- Encapsulates the collection of scriptures
- Keeps scripture data out of `Program`

---

### Scripture
**Responsibility:**
- Stores a scripture reference and its words
- Controls word hiding logic
- Produces the full display text

**Methods:**
- `HideRandomWords(int count)`
- `GetDisplayText()`
- `IsCompletelyHidden()`

The `Scripture` class owns the collection of `Word` objects and manages their state.

---

### Reference
**Responsibility:**
- Represents where a scripture is found (book, chapter, verse or verse range)

**Examples:**
- John 3:16
- Proverbs 3:5–6

---

### Word
**Responsibility:**
- Represents a single word in the scripture
- Tracks whether the word is hidden
- Renders itself appropriately when displayed

Each `Word` object knows only about its own text and visibility state.

---

## Object-Oriented Principles Used

- **Encapsulation:**  
  Each class owns its data and behavior. Internal details are hidden from other classes.

- **Single Responsibility Principle:**  
  Each class has one clear job.

- **Separation of Concerns:**  
  User interaction, data storage, and business logic are handled in different classes.


---

## How to Run
1. Open the project in Visual Studio Code
2. Build and run the program
3. Select a scripture from the menu
4. Press Enter to hide words or type `quit` to exit

---

## Author
Luke Moffat
