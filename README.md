# matchesApp
Is an application that takes a single integer input. The application will download the raw data from the website above (https://mach-eight.uc.r.appspot.com) and print a list of all pairs of players whose height in inches adds up to the integer input to the application. If no matches are found, the application will print "No matches found"

You only need to have Visual Studio 2019 to run this app and also restore packages (in case of that RestSharp reference generates some issue only).

If you want also you can download the code and then you could go to "/app/bin/Release/netcoreapp3.0" and then from this folder open a CMD window and execute the app with the command "app.exe" and you'll see the application functionality witount open and rebuild code on visual studio. (Only for Testing Purposes) 

If you have questions or comments to do please let a comment or send an email to my javieraugustoalba@gmail.com, and I kindly resolve things or questions that yoy may have about this code.

OTHER THECNICAL ANNOTATIONS AND SPECIFICATIONS:

- Solution based on .NET Core 3.0 (Console Application that can be used on Linux, mac or windows).
- Implemented Repository service pattern for request and serialize Json info.
- Used Rest Sharp for manage API Request from NBA Data.
- Visual Studio 2019 (Mostly recommended because has .NET Core 3.0 installed and you don't need to install frameworks or other things).
