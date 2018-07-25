# StartAsCurrentUser
A simple .exe to utilize the functionality found in [https://github.com/murrayju/CreateProcessAsUser](https://github.com/murrayju/CreateProcessAsUser) to launch another executable as the currently logged in user in Windows.

This was originally designed to be used with the [Powershell App Deployment Toolkit](http://psappdeploytoolkit.com/) and SCCM but can be used for really anything as long as you are running in the SYSTEM context.  **It will not run if executed by a user or even a local admin - MUST BE SYSTEM.**  

While I realize utilities like ServiceUI.exe ship with Windows, I've found Murrayju's code library to be more reliable.

## Usage
Primarily this is meant to be used via a scheduled task.

*path/to/StartAsCurrentUser.exe (path to .exe to launch)*

Example: *StartAsCurrentUser.exe c:\windows\system32\calc.exe*

## Compiling
The included ProcessExtensions.dll must be added to the solution in Visual Studio.  I also utilized [Costura.Fody](https://stackoverflow.com/questions/189549/embedding-dlls-in-a-compiled-executable) so the build results in a single .exe file with the DLL embedded.

Honestly the entire program is a handful of lines - just download the release from the [Releases](https://github.com/clreinki/StartAsCurrentUser/releases) page.

## Download
Go to [Releases](https://github.com/clreinki/StartAsCurrentUser/releases) page for pre-compiled .exe
