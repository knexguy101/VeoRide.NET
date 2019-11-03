# VeoRide.NET

VeoRide.NET is an unofficial wrapper that allows .NET users to interface with the VeoRide app API.

  - This API is NOT official
  - This project is for educational use only (please don't come after me)

# Features

  - Login
  - Get Profile Information
  - Get all Rides near a set of coordinates
  - Set your location in the app
 
# TODO
  - Unlock and Lock Bikes (Just need to scrape the request in the next couple days)

# Installation

Download the packages then compile the .csproj file, look in the Debug folder for the .dll

# Documentation
  - TODO
  
# Usage
```c
using VeoRide.NET.Models;
using VeoRide.NET.Functions;
using VeoRide.NET;
using System.Threading; //for cancel tokens
using System.NET //for webproxy

//Initialize your Login Client
var cancellationToken = new CancellationToken();
var SMS = "12345678"
var Proxy = new WebProxy($"ProxyHere")

//Make some sort of async input so user or program can set sms code
var messageBoxForm = new MessageBoxForm();
messageBoxForm.Show();
messageBoxForm.CodeEntered += delegate (object sender, EventArgs e)
{
    veoRideClient.SetVerificationCode(e.SMSCode);
};

//Load our client with our data
var veoRideClient = new VeoRide.NET.VeoRideClient(cancellationToken, SMS, Proxy)

//We can check if the login worked
if(veoRideclient.IsClientValid())
{
    //we are all logged in, so lets get the info on the account
    var accountData = Functions.GET.Me(veoRideClient);
    
    //read the response data, will be in jobject format
    if(accountData.IsSuccessStatusCode)
        Console.WriteLine(accountData.Content.ReadAsStringAsync().Result);
    else
        Console.WriteLine("Error: " + accountData.Content.ReadAsStringAsync().Result);
}
```
