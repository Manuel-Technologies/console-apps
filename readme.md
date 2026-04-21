# TaskFlow Console App

TaskFlow is a simple C# console application for managing tasks from the terminal.
You can add tasks, view all tasks, and delete tasks by title.

## Features

- Add a task with:
  - Title
  - Body/description
  - Status
  - Due date
  - Priority
  - Category
  - Created date (auto-set)
  - Updated date (auto-set)
- View all tasks currently stored in memory.
- Delete a task by its title.
- Menu-driven CLI flow.

## Tech Stack

- C#
- .NET `net10.0`
- Console application

## Project Structure

```text
.
|- Program.cs                    # App entry point and menu loop
|- TaskManager.cs                # Core task operations: add, view, delete
|- Tasks.cs                      # Task model with constructor and properties
|- simple console apps.csproj
|- simple console apps.sln
`- readme.md
```

## How It Works

The app starts a loop with 4 options:

1. Add Task
2. View Tasks
3. Delete Task
4. Exit

When adding a task, the app asks for all task fields, creates a `Tasks` object, then stores it through `TaskManager`.

## Build Status

Latest check:

- `dotnet build` completed successfully
- 0 errors
- 0 warnings

## Getting Started

### Prerequisites

- Install a .NET SDK that supports `net10.0`.

### Run locally

```bash
dotnet restore
dotnet build
dotnet run
```

## Usage Example

1. Run the app.
2. Select `1` to add a task.
3. Enter task details when prompted.
4. Select `2` to list tasks.
5. Select `3` and enter a title to delete a task.
6. Select `4` to exit.

## Current Limitation

- Tasks are stored in memory only (no file/database persistence).
- In the current implementation, `TaskManager` is created inside the menu loop, so tasks are reset each iteration.
  To keep tasks during the full app session, instantiate `TaskManager` once before the loop.

## Suggested Improvements

1. Create one `TaskManager` instance outside the `while` loop.
2. Add input validation for date parsing and required fields.
3. Use enums for `TaskStatus` and `TaskPriority`.
4. Add edit/update task functionality.
5. Persist tasks to JSON so data survives app restarts.
6. Add unit tests for `TaskManager`.

## Contributing

1. Create a feature branch.
2. Make focused changes.
3. Run `dotnet build` and verify it passes.
4. Open a pull request with a short description.

## License

No license file is currently included. Add a `LICENSE` file if you plan to distribute this project.
