# Portfolio Starter Kit for Umbraco v9

This is a simple starter kit for Umbraco v9

It gives you an alternative starter kit to use instead of the default starter kit from Umbraco.

It is supposed to be a Portfolio / CV site. 

## If you want a really quick way to get it installed and test it out
Make sure you have downloaded the latest [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0), then copy and paste this into Command Prompt or Windows Terminal or whatever you use:

```
# Ensure we have the latest Umbraco templates
dotnet new -i Umbraco.Templates::9.0.0-rc004

# Create solution/project
dotnet new sln --name MySolution
dotnet new umbraco -n MyProject --friendly-name "Admin User" --email "admin@admin.com" --password "1234567890" --connection-string "Data Source=|DataDirectory|\Umbraco.sdf;Flush Interval=1" -ce
dotnet sln add MyProject
dotnet add MyProject package Portfolio --prerelease

# Run
dotnet run --project MyProject

```

When I originally built this, I was using the new ViewComponents which are part of .NET 5 but I was unable to include them in the starter kit due to the models needing to be altered by the end user and my core project can't know about the models up front.

**In this starter kit you can see examples of:**

- Block List Editor on the Home Page - with hidden blocks (I was inspired by how uSkinned hid blocks in their themes.) 
- Nested Content on the CV page
- Simple Contact Form - You can see how to send emails now if you look at the ContactSurfaceController in the Portfolio.Core project

I'm sure there are other things too, but have a play anyway.

Also I'm proud to say it gets 100 scores for Accessibility, SEO and Best Practices. It is almost at 100 for performance too but there are some things you can do to improve that yourself.
