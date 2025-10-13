
**Assignment Instructions: VB.NET Datalogger Application**

**Objective:**
Develop a VB.NET framework form application to collect and visualize analog input data from a PIC microcontroller.

**Requirements:**

1. **User Interface:**
   - Create a form with the following buttons, menus, and status strip:
     - **Top Menu**: Include a top menu for file operations and settings.
     - **Context Menu**: Provide a right-click context menu for convenient access to common actions.
     - **Start Button**: Begins data sampling from the PIC microcontroller.
     - **Stop Button**: Ends data sampling.
     - **Save Button**: Saves sampled data to a text file. Use a **Status Strip** to display the current log file path, providing users with clarity on where data is being saved.
   - Ensure that control names are **meaningful**, using **Pascal Case** with a type suffix (e.g., `StartButton`, `StopButton`).
   - Set up proper **tab order** and **tab stops** to allow intuitive navigation through the form.
   - Add **access keys** and **tool tips** for all buttons to enhance usability. The **form title** should also be descriptive.

2. **Sampling Configuration:**
   - The application should collect analog data from the PIC microcontroller at a rate of **10 samples per second**.
   - Add an option to allow users to set a **variable sampling rate**. Form 1 to 100 samples per second. The default sampling rate should be 10 samples per second.
   - Implement **input validation** for the sampling rate to ensure the user does not enter invalid values.

3. **Data Visualization:**
   - Use a **Picture Box** control to display the sampled data in the form of a graph.
   - Provide options to view:
     - The **entire history** of sampled data file.
     - **Only the last 30 seconds** of sampled data.
   - The graph must update in **real time** as new data is collected.
   - Ensure the **output format** is accurate and the graph is easy to understand.
   - The Graph must be resizable with the form and display the data in a clear and readable manner.

4. **Saving Sampled Data:**
   - When the **Save Button** is clicked, save the sampled data to a text file in the **same directory** as the application.
   - Format of the text file:
     ```
     "$$AN1",<HighByte>,<LowByte>,<timestamp>
     "$$AN1",<HighByte>,<LowByte>,<timestamp>
     ```
   - **Explanation of Fields:**
     - `$$`: Denotes the start of a sample.
     - `$$ANn`: Represents the analog input channel.
     - `<HighByte>` and `<LowByte>`: The high and low byte values of the sampled data.
     - `<timestamp>`: Time the sample was taken, formatted as **YYMMDDHHMMSSmm** (Year, Month, Day, Hour, Minute, Second, Millisecond).
   - Ensure the file is named properly and includes a descriptive **assignment header**.

5. **Log File Management:**
   - Include an option for the user to **open** and **save** log files containing sampled data. The open and save file dialogues should have their filters set to `.log` files. The default filename should be `log_YYMMDDHH.log` to reflect the hour of data collection, as the data logger creates a new file every hour and each file contains data for only that hour.

6. **Code Quality Requirements:**
   - Use **meaningful names** for all classes, subs, and functions, using **Pascal Case**.
   - Use **Camel Case** for variable names, and ensure variable scope is properly managed.
   - Include **informative comments** throughout the code. Proper **indentation, line spacing, and line length** are required for readability.
   - Enable **Option Explicit** and **Option Strict** to enforce variable declarations and type safety.
   - Implement **error handling** to manage issues such as PIC disconnections or invalid sampling rates, providing user-friendly messages.

7. **Testing and Functionality:**
   - Test the real-time graph update to ensure it performs well at different sampling rates.
   - Ensure the application meets all specified requirements: starting/stopping sampling, graphing data, and saving data to a file.
   - The program must **compile without errors or warnings** and **function according to the specifications**.

**Additional Notes:**
- Ensure the application interface is intuitive, allowing users to easily start/stop sampling and view/save the collected data.
- Award extra credit for implementing additional creative features or optimizations, such as using more than one analog input (up to 4 channels).
- Pay attention to error handling, especially in cases where the PIC microcontroller may disconnect or the sampling rate is incorrectly configured.
