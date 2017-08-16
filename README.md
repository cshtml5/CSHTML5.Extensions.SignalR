# CSHTML5.Extensions.SignalR
A SignalR client library for "C#/XAML for HTML5"



### INTRODUCTION

This is an open-source extension for "C#/XAML for HTML5" that provides support for SignalR. It is based on the open-source JavaScript library available at: https://github.com/DVLP/signalr-no-jquery

"C#/XAML for HTML5" - also known as "CSHTML5" - is a Visual Studio tool that enables developers to create cross-platform HTML5 applications using only C# and XAML. It can be downloaded from: http://www.cshtml5.com

To be able to compile this project using Visual Studio, you need to download and install the latest version of "C#/XAML for HTML5", available from: http://www.cshtml5.com



### GETTING STARTED - Running the sample client/server chat application:

1. Make sure that you have the latest version of "C#/XAML for HTML5" installed. You can download it from: http://www.cshtml5.com

2. Scroll to the top of this page (the GitHub root page for this project), click the green button "Clone or Download", and then click "Download ZIP".

3. Extract the downloaded file into a folder on your computer.

4. Open the Visual Studio solution by double-clicking the file "CSHTML5.Extensions.SignalR.sln".

5. Start the server by right-clicking on the project named "CSHTML5.Extensions.SignalR.Server.Example", and clicking Debug -> "Start new instance".

6. Start the client by right-clicking on the project named "CSHTML5.Extensions.SignalR.Client.Example", and clicking Debug -> "Start new instance".

7. If you get a message that says that you need the "Professional Edition", click "Start the free 60-day trial", and then repeat the Step 6.

8. The "Simulator" window should appear. A message should tell you that the application cannot be run in the Simulator. Wait a few seconds for the generation of the JS/HTML files to complete, and then click the green button "Run in browser".

9. The browser should open with a sample chat application. You can write messages and receive them.

Please note that if you are using Microsoft Edge, you should launch the application from Localhost (http://) instead of the local file system (file://). To do so, repeat step 8 but, instead of clicking "Run in browser", click the green button with the small dots ("..."), and then click "Run from localhost".



### DESCRIPTION OF THE PROJECT STRUCTURE

* **CSHTML5.Extensions.SignalR.Client**: This is the main class library, which you should reference if you want to create a CSHTML5 SignalR client application.

* **CSHTML5.Extensions.SignalR.Client.SLMigration**: This is the same as above, but for CSHTML5 projects of type "Silverlight Migration Edition". You should reference this library if you want to create a CSHTML5 SignalR client application of type "Silverlight Migration Edition".

* **CSHTML5.Extensions.SignalR.Client.Example**: This is the client-side portion of a sample chat application built with CSHTML5 and SignalR.

* **CSHTML5.Extensions.SignalR.Server.Example**: This is the server-side portion of a sample chat application built with CSHTML5 and SignalR.



### RELATED TOPICS

* [How to create a SignalR server-side project?](https://github.com/cshtml5/CSHTML5.Extensions.SignalR/wiki/How-to-create-a-SignalR-server-project)
