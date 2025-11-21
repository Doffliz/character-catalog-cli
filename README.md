Character Catalog CLI

Console-based character catalog application with CLI, Strategy pattern and modular architecture.

Project description

This application provides a simple console interface for managing a catalog of characters.
It is used as a training project for practicing object-oriented design, patterns and basic CLI architecture.

Main responsibilities:

store and display characters;

show detailed information about each character;

create new characters via interactive dialog;

prepare infrastructure for future GUI.

CLI Commands
list

Displays a formatted table of all characters stored in the catalog.

show <id>

Shows detailed information about a specific character by its ID.
If the ID does not exist, an error message is displayed.

create

Launches an interactive dialog to create a new character.
You will be prompted to enter:

Name

Race

Class

Image path

Description (optional)

The created character is automatically added to the catalog.

save

(Stub / optional) Saves the character catalog to a file for future extension.

exit

Terminates the application.

How to run

Install .NET SDK
.

Clone this repository:

git clone https://github.com/Doflliz/character-catalog-cli.git
cd "character-catalog-cli/Console app char"
dotnet run
