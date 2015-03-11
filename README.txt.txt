-----------------------------------------
CITIES SKYLINES MODDING SKELETON CODE
Author: reddit user "SkylinesModEngineer";
Date: 11/03/2015
------------------------------------------

How to setup skeleton code. (Beginners) ADVANCED/Experienced modders go to step 6

1. go to the user mod folder.
On Windows C:\Users\<username>\AppData\Local\Colossal Order\Cities_Skylines\Addons\Mods
On Mac /Users/<username>/Library/Application Support/Colossal Order/Cities_Skylines/Addons/Mods
On Linux /home/<username>/.local/share/Colossal Order/Cities_Skylines/Addons/Mods/

2. Create new folder in ../Mods.  Best practice is to have the same name as your Mod. eg MyModName

3. Open CSSkeletonCode and copy "Source" folder into your mod folder... -> .../Mods/MyModName/Source
   Source folder is where you should place all your Source files(.cs)   

4. Open IUserMod.cs that's in the Source folder
   Rename namespace to one of your choosing
   Rename class name
   Set your own title and description.

5. You should now see your mod title and desc in the modding menu in Cities Skylines.
6. Choosing SkeletonSource:  

The "SkeletonSource" folder contains all the source files implementing the method
signatures from the Modding API wiki
http://www.skylineswiki.com/Modding_API
 
You can choose which source files you need and copy them to your source folder, then implement the methods
HOWEVER you will notice that for each C# interface there is 2 .cs(Source file) that extends an interface
eg. MyIEconomy and MyIEconomyBase, choosing which one is important.
There is a Base interface and a Non base interface. The Non base interface will force you to implement every method
but the Base interface will allow you to choose which mehtods you want to override using the "override" C# keyword

All method signatures can be found on the CitiesSkylines API wiki here:
http://www.skylineswiki.com/Modding_API



NOTES:
- Make sure all you .cp(Source files) in the "Source" folder have the same "namespace"  but different classnames.
If another mod has the same namespace and classname you will get an error.
- All files contained within skeleton code compile without errors, any errors are a result of any modification
- If using the BASE interface you must use the "override" keyword.
- If using a non base interface source file you must implement every method