# Scripture Memorization Program
LUKE MOFFAT

## Project Structure

### Classes
- **Program.cs**: Main program loop and user interaction
- **Scripture.cs**: Manages scripture text, word hiding, and display
- **Word.cs**: Represents individual words and their hidden/visible state
- **Reference.cs**: Stores and formats scripture references (book, chapter, verse)
- **ScriptureLibrary.cs**: Loads and manages multiple scriptures from file

### When running:
Use the debugger and it should work. If you hit the play button then the library file won't read correctly and it might break. 

## Creative Part:

### Data Files
- **library.txt**: Pipe-delimited file containing scriptures
  - Format: `Book|Chapter|StartVerse|EndVerse|Text`

- Added **ScriptureLibrary** class to load multiple scriptures from a file
- Implemented automatic scripture rotation when one is fully memorized
- Configurable difficulty (number of words hidden per iteration)
- Support for both single verses and verse ranges

### Things to work on:
- Only hide word from only avaible scriptures
- Expand library
- Word wrapp in terminal to not cut of words. 