# FPS Creator Game Launcher

![Screenshot](https://github.com/PavarisP/FPS-Creator-Game-Launcher/blob/78f126335715fb356d31716e8f0c8d69937764a4/Resources/Screenshot1.png)

A custom game launcher for FPSC / BIM / BIMA Games by Pavaris Pobhirun. It is designed to be used for [FPS Creator Classic](https://github.com/Dark-Basic-Software-Limited/FPS-Creator-Classic) and [Black Ice Mod](https://www.blackicemod.org/).

In summary of the license: You can use the launcher in commercial projects and give credits to the original author, but if you distribute the launcher, you must release the corresponding source code, including all your changes, under the GPL v3 license. **(Only the launcher, NOT the game itself)**


# How to use Source Code
Requirements:
- C# knowledge
- Basic knowledge of Visual Studio 2022

Clone this directory
> git clone https://github.com/PavarisP/FPS-Creator-Game-Launcher.git

1. Open the FPS Creator Game Launcher.csproj with Visual Studio 2022.
2. Configure the launcher for your game (see below).

# Configuring for your game

Before building, edit these values so the launcher points at your own game.

### 1. `AppPaths.cs` — game folder and executable

Set these two values to match the game that sits next to the launcher `.exe`:

| Value | What it is | Example |
| --- | --- | --- |
| `GameFolderName` | Name of the folder containing your game (relative to the launcher `.exe`). Also used for the save folder in **Documents**. | `"Horror"` |
| `GameExeName` | File name of your game's executable inside that folder. | `"Horror.exe"` |

```csharp
public static readonly string GameFolderName = "Horror";   // <-- your game folder
public static readonly string GameExeName    = "Horror.exe"; // <-- your game .exe
```

### 2. `Launcher.DefaultConfig.cs` — level count and unique game code

Set the maximum number of levels to match your game. This tells the default config how many `levelfpm`/`levelfpi` entries to generate.

```csharp
private const int LevelMax = 1; // <-- number of levels in your game
```

If your game uses a multiplayer unique game code, set it here. Leave it as an empty string `""` if you don't have one.

```csharp
private const string UniqueGameCode = ""; // <-- your multiplayer code, or "" if none
```

> **How settings are stored:** the launcher keeps the player's saved settings in
> `Documents\<GameFolderName>\setup.ini` (this persists between sessions). On save/launch
> it copies that file into `<launcher folder>\<GameFolderName>\setup.ini`, which is the
> file the game engine actually reads. This lets the launcher work even when the game
> folder is extracted and deleted on each run (e.g. when packed with the Vishnu launcher).

### 3. Launcher image

Replace the launcher's side image (`pictureBox1`) with your own artwork:

1. Open `Launcher.cs` in the Visual Studio Windows Forms designer.
2. Click the large image on the right of the form.
3. In the **Properties** panel, set the **Image** property to your own picture.

**Default image resolution: 523 px wide × 525 px high.** Use this size by default so the
image fits cleanly. You can change the dimensions if you like — the picture box uses
`StretchImage`, so your image is scaled to fill the box regardless of its own resolution
(just keep a matching aspect ratio to avoid stretching/distortion).

# Library Used
- Solaris Config Parser https://github.com/salaros/config-parser
