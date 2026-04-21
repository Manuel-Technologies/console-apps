# TaskFlow Console App

TaskFlow is a C# console-based task management app intended to help users create, view, edit, and manage personal tasks from the terminal.

This project is currently in an early development state. The core menu flow and a task model are started, while some parts are still being implemented.

## Project Goals

- Provide a simple command-line task manager.
- Support task creation, viewing, editing, and deletion.
- Add task metadata such as:
  - Title and description
  - Status
  - Priority
  - Category
  - Due date
  - Created/updated timestamps

## Current Status

Current implementation includes:

- A console entry point (`Main`) with a menu loop.
- A `Tasks` model class with properties for common task fields.
- Placeholder files for planned architecture:
  - `TaskManager.cs`
  - `TaskStatus.cs`
  - `PriorityLevel.cs`

Current limitations:

- The project does **not compile yet**.
- `Program.cs` has a `switch` syntax issue (`case "4"` missing `:`).
- `AddTask(...)` and `ViewTasks(...)` are called but not implemented.
- `List<Task>` is used in `Program.cs`, but the model class is named `Tasks`, creating a type mismatch.
- Menu option labels and behavior are inconsistent (`"3. Delete task"` currently exits the app).

## Tech Stack

- Language: C#
- Runtime/SDK target: `.NET 10.0` (`net10.0`)
- Project type: Console application

## Project Structure

```text
.
├── Program.cs             # Entry point and menu loop
├── Tasks.cs               # Task data model
├── TaskManager.cs         # Planned task service/manager (currently empty)
├── TaskStatus.cs          # Planned status enum/constants (currently empty)
├── PriorityLevel.cs       # Planned priority enum/constants (currently empty)
├── simple console apps.csproj
└── simple console apps.sln
```

## Build and Run

### Prerequisites

- Install .NET SDK compatible with `net10.0`.

### Commands

```bash
dotnet restore
dotnet build
dotnet run
```

## Known Build Error (Current)

As of the latest check, running `dotnet build` returns:

- `CS1003: Syntax error, ':' expected` in `Program.cs`

Fixing this, plus implementing missing methods and aligning the task type name, is required before successful execution.

## Suggested Next Milestones

1. Fix `switch` syntax in `Program.cs`.
2. Rename `Tasks` to `Task` (or update usage) so types are consistent.
3. Implement:
   - `AddTask(List<Task> tasks)`
   - `ViewTasks(List<Task> tasks)`
4. Correct menu behavior for delete/edit/exit options.
5. Move business logic into `TaskManager`.
6. Add enums in:
   - `TaskStatus.cs`
   - `PriorityLevel.cs`
7. Add input validation and friendly error handling.

## Example Future Features

- Search tasks by status/category/priority.
- Mark task as completed.
- Save tasks to a local file (JSON) so tasks persist between runs.
- Sort by due date or priority.

## Contributing

If you are contributing:

1. Create a branch.
2. Make focused changes.
3. Run `dotnet build` before pushing.
4. Open a pull request with a short summary of what changed.

## License

No license has been added yet. Add a `LICENSE` file to define usage terms.
