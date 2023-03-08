# rammonitor
This program is a .NET Console Application designed to list all running processes on a cross system and their corresponding memory usage. It uses the System.Diagnostics library to get a list of running processes and loops through each process to retrieve its details.

The program displays the name, ID, and memory usage (in kilobytes) for each process. It also attempts to retrieve the base address and size of the main module for each process, and lists the name, base address, and size of all modules in the process.

If there is an exception while retrieving the main module details for a process, the program catches the exception and displays an error message.

This program can be useful for monitoring memory usage and identifying processes that are using excessive amounts of memory. It also provides detailed information about each process and its modules.

To run the program, simply compile and execute it. The program will display the results in the console window.
