# FPS Creator Game Launcher

A custom game launcher for FPSC / BIM / BIMA Games by Pavaris Pobhirun. 

In summary of the license: You can use the launcher in commercial projects and give credits to the original author, but if you distribute the launcher, you must release the corresponding source code, including all your changes, under the GPL v3 license. **(Only the launcher, NOT the game itself)**

# FYI
I'm beginner in coding and this is my first ever program I created so it still have rooms for improvements. I'll try make the code more easy to read in the incoming updates. But at this time, there are many projects I'm current working on in my full-time job so I decide to release this early for the community to use.

# How to use Source Code
Requirements
- C# knowledge
- Basic knowledge of Visual Studio 2022

Clone this directory
> git clone https://github.com/PavarisP/FPS-Creator-Game-Launcher.git

1. Open the FPS Creator Game Launcher.csproj with Visual Studio 2022.
2. There are some lines in **Forms1.cs** you need to edit before compiling as follows:
- Line 18: Change to path to your game root directory
- Line 31: Change this to the number of levels of your game
- Line 34: Change this to the language of your game (if not English)
- Line 37: Change uniquegamecode to the uniquegamecode of your game, this is requires for multiplayer
- Line 51: Change to path to your game root directory
- Line 503 - 513: Change the key if you have to.


# Library Used
- Solaris Config Parser https://github.com/salaros/config-parser
