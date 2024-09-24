# DatestampEditor

DatestampEditor is a command-line utility for modifying file timestamps in Windows. It allows users to change the creation date, last modified date, and last accessed date of files.

## Features

- Change the creation date of a file.
- Change the last modified date of a file.
- Change the last accessed date of a file.
- Support for multiple commands in a single execution.

## Usage

To use DatestampEditor, open the command prompt and navigate to the directory containing the executable. The basic syntax for running the program is:

```
datestamp.exe "path\to\your\file.txt" [command] YYYY-MM-DD HH:MM
```

### Commands

- `creationdate`: Set the creation date of the file.
- `editdate`: Set the last modified date of the file.
- `opendate`: Set the last accessed date of the file.

### Examples

1. Change the creation date of a file:
   ```
   datestamp.exe "file.txt" creationdate 2024-01-01 00:00
   ```

2. Change the last modified date of a file:
   ```
   datestamp.exe "file.txt" editdate 2024-01-02 12:00
   ```

3. Change the last accessed date of a file:
   ```
   datestamp.exe "file.txt" opendate 2024-01-03 15:45
   ```

4. Change multiple dates in one command:
   ```
   datestamp.exe "file.txt" creationdate 2024-01-01 00:00 editdate 2024-01-02 12:00 opendate 2024-01-03 15:45
   ```

## Requirements

- Windows operating system.
- .NET runtime (version compatible with the compiled executable).

## Compilation

To compile the source code, use Visual Studio 17

## License

This project is open-source. Feel free to use, modify, and distribute as needed.
