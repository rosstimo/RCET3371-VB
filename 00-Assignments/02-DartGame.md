# Assignment: Dart Game Simulation (WinForms)

## Objective
Create a VB.NET Windows Forms application that simulates a dart game. The program will allow users to throw darts at a target by pressing the space bar, log each round to a sequential file, and review past rounds. The application will reinforce skills in event handling, graphics, file I/O, and user interface design.

---

## Requirements

### 1. Game Play
- The main form must include a PictureBox representing the dartboard.
- When the space bar is pressed, a "dart" is thrown:
  - Use a function to generate random X, Y coordinates within the bounds of the PictureBox.
  - Display a circle with a center mark at the dart position using the Graphics class.
- Each round consists of three dart throws.
- The program must allow the user to start a new round and quit the game.
- After each round, log the round number and the X, Y coordinates of all three darts to a sequential file (e.g., text file).

### 2. Review Mode
- The application must provide a way to review past rounds:
  - Display a list of previous rounds (from the sequential file).
  - When a round is selected, display the three dart positions for that round on the PictureBox.
- Play mode and review mode are mutually exclusive; only one can be active at a time.

### 3. User Interface
- Use meaningful names for all controls (e.g., `DartboardPictureBox`, `StartRoundButton`, `ReviewButton`, `QuitButton`).
- Provide tooltips for all buttons and interactive controls.
- Set proper tab order and access keys.
- Use a descriptive form title (e.g., "Dart Game Simulator").
- Display the current round number and dart throw count.
- Indicate whether the application is in play or review mode.

### 4. Graphics
- Use the Graphics class to draw each dart as a circle with a center mark.
- Clear the PictureBox between rounds and when switching modes.
- Ensure darts are always drawn within the bounds of the PictureBox.

### 5. File I/O
- Log each round to a sequential file (e.g., `DartGameLog.txt`).
- Each entry must include the round number and the X, Y coordinates for all three darts.
- Implement error handling for file read/write operations.

### 6. Code Quality
- Use meaningful names for all variables, functions, and classes.
- Organize code with comments and proper indentation.
- Handle errors gracefully (e.g., file access issues, invalid coordinates).

### 7. Testing
- Test dart throws to ensure all are within the PictureBox.
- Test logging and review functionality for accuracy.
- Test switching between play and review modes.
- Ensure the program runs without errors or warnings.

### 8. Extra Credit (Optional)
- Add scoring based on dart position (e.g., closer to center = higher score).
- Display a running score for each round.
- Allow saving and loading logs from different files.
- Add sound effects for dart throws.

---

## Submission
- Submit your complete project folder and log file to Canvas.
- Include a brief README describing your implementation, features, and any extra credit.

## Grading
- Functionality: 60 pts
- Code quality & comments: 20 pts
- User interface: 10 pts
- Extra credit features: 10 pts

---

**Questions?** Ask in class or on Canvas.

---

## Clarification Points
- What format should the sequential file use for logging rounds? (e.g., CSV, plain text)
- Should the dartboard have a visual target (e.g., rings, bullseye) or just a blank area?
- Should the review mode allow editing or only viewing past rounds?
- Is there a maximum number of rounds to display/review?
- Should the program display scores or just dart positions?
- Should the log file be overwritten each session or append new rounds?

Please clarify these points as needed.