# matchesApp
Is an application that takes a single integer input. The application will download the raw data from the website above (https://mach-eight.uc.r.appspot.com) and print a list of all pairs of players whose height in inches adds up to the integer input to the application. If no matches are found, the application will print "No matches found"

I used RestSharp for manage API Rest Resquest and Newtonsoft for serialize and deserialize objects from this response to models in c#.

You only need to have Visual Studio 2019 to run this app and also restore packages (in case of that RestSharp reference generates some issue only).


