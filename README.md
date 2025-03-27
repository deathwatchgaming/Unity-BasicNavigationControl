# Unity-BasicNavigationControl

 
Description:
------------


 Create Basic Navigations Control by Example(s) for your Unity Projects. IE: (Compass, Minimap, Minimap Tactical Marker)


![Preview](https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/Previews/BasicNavigationControl-Preview.png)


 The "Compass" and or "Minimap" need some sort of "Player Controller" to work
 and are reliant on such, thus one would not be able to test such if they do
 not already have one to test stufff with. As such provided is just a
 simple "FirstPersonController" for testing stuff if the end-user needs such
 and does not already have something.


REPO NOTE: The purpose of this new repository was decided upon recently when
revisiting the several individual repositories in the past that I had with a
variant of each part of this as individual repositories (ie: Compass repo,
Minimap repo, Test Stuff Controller repo) and opting now that was not as
optimal as say now just cleaning up those old repos & files and then such
remove such and now instead decide to simply just opt to have one repo with
such in it as such makes more sense for organizational / management purposes.
As such this will be the new repository for such simply provided as a
starting point for users whom wish to use such in their projects and then
improve upon such as they desire.

NOTE: This currently still uses the Old Input System, so as such depending on
what version of Unity you may be using it may be necessary to make sure such
or both is enabled in project settings.


Player Controls: 
----------------


  Note: The following found below are related to the provided playercontrol script for usage example.


Old_Input_System Variant:

* Player Forward:   W
* Player Reverse:   S
* Player Left:      A
* Player Right:     D
* Player Jump:      Space
* Player Sprint:    Left Shift
* Look:             Mouse

If minimap tactical markers is used / added:

* Tactical Marker:  T


New_Input_System Variant:

* Player Forward:   W [Keyboard] / Left Stick [Gamepad]
* Player Reverse:   S [Keyboard] / Left Stick [Gamepad]
* Player Left:      A [Keyboard] / Left Stick [Gamepad]
* Player Right:     D [Keyboard] / Left Stick [Gamepad]
* Player Jump:      Space [Keyboard] / Button South [Gamepad] 
* Player Sprint:    Shift [Keyboard] / Left Shoulder [Gamepad]
* Look:             Delta [Mouse] / Right Stick [Gamepad]


If minimap tactical markers is used / added:

* Tactical Marker:  T [Keyboard] / D-pad Up [Gamepad]


Manual Setup Instruction:
-------------------------


Simply follow the documentation instruction linkages for manual setups found below.


PlayerControl:
--------------


Old_Input_System Variant:


* Example player control documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/Old_Input_System/Assets/PlayerControl/Documentation/PlayerControl-Documentation.txt


New_Input_System Variant: 


* Example player control documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/New_Input_System/Assets/PlayerControl/Documentation/PlayerControl-Documentation.txt


Compass:
--------


Old_Input_System Variant:


* Compass documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/Old_Input_System/Assets/NavigationControl/Compass/Documentation/Compass-Documentation.txt


New_Input_System Variant: 


* Compass documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/New_Input_System/Assets/NavigationControl/Compass/Documentation/Compass-Documentation.txt


Cursor:
-------


Old_Input_System Variant:


* Cursor documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/Old_Input_System/Assets/NavigationControl/Cursor/Documentation/Cursor-Documentation.txt


New_Input_System Variant: 


* Cursor documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/New_Input_System/Assets/NavigationControl/Cursor/Documentation/Cursor-Documentation.txt


Minimap:
--------


Old_Input_System Variant:


* Minimap Follow documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/Old_Input_System/Assets/NavigationControl/Minimap/Documentation/MinimapFollow-Documentation.txt


* Minimap Tactical Marker documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/Old_Input_System/Assets/NavigationControl/Minimap/Documentation/MinimapTacticalMarker-Documentation.txt


New_Input_System Variant:


* Minimap Follow documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/New_Input_System/Assets/NavigationControl/Minimap/Documentation/MinimapFollow-Documentation.txt


* Minimap Tactical Marker documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/New_Input_System/Assets/NavigationControl/Minimap/Documentation/MinimapTacticalMarker-Documentation.txt



All Combined Documentation:
---------------------------


Old_Input_System Variant:


* All combined documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/Old_Input_System/Assets/NavigationControl/Documentation/NavigationControl-Documentation.txt


New_Input_System Variant:


* All combined documentation: https://github.com/deathwatchgaming/Unity-BasicNavigationControl/blob/main/New_Input_System/Assets/NavigationControl/Documentation/NavigationControl-Documentation.txt



