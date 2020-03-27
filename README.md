# _C# Tamagotchi_

#### _Tamagotchi Game in C#, 03.11.2020_

#### By _**Tiffany Siu and Jack Dunning**_

<!-- [![Project Status: Inactive – The project has reached a stable, usable state but is no longer being actively developed; support/maintenance will be provided as time allows.](https://www.repostatus.org/badges/latest/inactive.svg)](https://www.repostatus.org/#inactive) -->
[![Project Status: WIP – Initial development is in progress, but there has not yet been a stable, usable release suitable for the public.](https://www.repostatus.org/badges/latest/wip.svg)](https://www.repostatus.org/#wip)
![LastCommit](https://img.shields.io/github/last-commit/tsiu88/Csharp-Tamagotchi)
![Languages](https://img.shields.io/github/languages/top/tsiu88/Csharp-Tamagotchi)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

---
## Table of Contents
1. [Description](#description)
2. [Setup/Installation Requirements](#setup/installation-requirements)
    - [Requirements to Run](#requirements-to-run)
    - [Instructions](#instructions)
    - [Other Technologies Used](#other-technologies-used)
3. [Specifications](#specifications)
4. [Known Bugs](#known-bugs)
5. [Support and Contact Details](#support-and-contact-details)
6. [License](#license)
---
## Description

#### 3/11 Work from Home Summary
- Places You've Been
- Packer Tracker
  - Some CSS styling to make sure able to get it to display
- Tamagotchi (C#)
  - Only finished specs, testing, and basic structure
- Struggles: Git Mob not always working/visible, Live share sync issues

This project is unfinished and is supposed to be a tamagotchi game that you can feed, play, and put to bed a tamagotchi pet to keep it alive.

## Setup/Installation Requirements

_This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10 from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)._ 

### Requirements to Run
* _.NET Core_
* _ASP.NET Core MVC_
* _Command Prompt_
* _Web Browser_

### Instructions

*This page may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Clone the [repository](https://github.com/TSiu88/Csharp-Tamagotchi.git) from my [GitHub page](https://github.com/TSiu88)
3. Use a command line interface to move to the repository's directory with `cd project-directory`
4. Run `dotnet restore` and `dotnet build` in command line interface of the repository's directory
5. Run `dotnet run` to start up the program in the command line interface
6. Type the URL listed under "Now listening on:" into a web browser 

## Other Technologies Used
* _C#_
* _MSTest_
* _Razor_
* _Markdown_

## Specifications

* _The program has a homepage that introduces Tamagotchi and has a link to create a new Tamagotchi to play_
  * _Example Input: Program starts_
  * _Example Output: Home page displayed with route to fill in form_
* _The program creates a Game object with properties of food, happiness, and rest for Tamagotchi from user input of a name._
  * _Example Input: User inputs name_
  * _Example Output: Game object with properties of food, happiness, and rest created_
* _The program decreases levels of all properties when user ends turn and causes time to pass._
  * _Example Input: User presses "End Turn"_
  * _Example Output: Food, happiness, and rest levels decrease_
* _The program shows buttons for a Game that allows user to interact with the Tamagotchi with feed, play, or rest._
  * _Example Input: Game running_
  * _Example Output: Buttons visible and can interact with them_
* _User pressing buttons for a Game will increase that stat._
  * _Example Input: User presses "Feed"_
  * _Example Output: Food level for Game increases_
* _The program only allows one action per Game per Turn._
  * _Example Input: User pressed "Play"_
  * _Example Output: User unable to interact with any more buttons and must End Turn_
* _The program displays a "Game Over" view when the Game has died_
  * _Example Input: Two out of the three: food, happiness, or rest levels, drops to 0_
  * _Example Output: Display "Game Over"_
* _Can click button and add more Tamagotchi games to play at the same time._
  * _Example Input: User clicks link to add more Tamagotchis_
  * _Example Output: User inputs another name and creates a new Tamagotchi_

## Known Bugs

_There are currently no known bugs in this program_

## Support and contact details

_If there are any question or concerns please contact us at our emails: [Tiffany Siu](mailto:tsiu88@gmail.com) or [Jack Dunning](mailto:JackStunning9001@gmail.com). Thank you._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Tiffany Siu, Jack Dunning_**
