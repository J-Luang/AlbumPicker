Welcome to the read me where you will look at the pretty words of an album and its title!

A few things before things get running, this is created in Visual Studio 2019 and a few items may be needed.

Assumptions: 

* The person running the code knows how to install the following:
1. NuGet Package Manager from Visual Studio extentions
2. Newtonsoft.Json from the Nuget Package Manager

* The user has cloned the repository.

Running in Debugger:
After everything is installed, open up Visual Studio and open a Project/Solution open the "AlbumPickerConsole.sln" -> navigate to "Program.cs" -> Run the application by clicking the play button or hit F5 while the code. A few
prompts will show up and will ask you a few questions which is about the app.

Publishing/Running Executable:
Because no one wants to run an unknown executable on their computer for the internet bad guys heres how to publish and run.
1. Open up the .sln file similar to above.
2. Right-click on "AlbumPickerConsole" with the c# logo next to it.
3. Under configuration click the edit icon
4. Change deployment mode to self-contained
5. Change target location to desirable location (preferably a folder)
6. Save then hit publish
7. Locate and open where the pubish was stored
8. Open the "AlbumPickerConsole.exe" file and enjoy messing around and breaking it.


Notes about the code: 
1. ContinueQuestion() could be changed to if statement but it made it so there had to be 2 inputs to continue, chose switch for a "quick fix".
2. Would be optimal if the person "accidently" opened the app and did not know how to exit, and that would mean needing a quit option right from the first prompt.
