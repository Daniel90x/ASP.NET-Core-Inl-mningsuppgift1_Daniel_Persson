# ASP.NET-Core-Inl-mningsuppgift1_Daniel_Persson

ASP .NET Core: Är ett ramverk som Microsoft skapat, som underlättar utvecklandet av webbapplikationer, API:er och microservices. 
Det erbjuder olika sätt att strukturera en webserver, Razor Pages och MVC. 
Hosting system som bestämmer vilka klasser som man behöver för att skapa en Http-request (Dependency Injection) och så skapas alla objekt automatiskt.
ASP :NET Core är snabbt, valanvänt och säkert. 

Startup: I Startup så konfiguerar vi den kod som påverkar vilka inställningar våran webbapplikation ska ha och hur de ska fungera. 

wwwroot: Man ska lägga alla sina statiska HTML, js och CSS i wwwroot. Det är filer som man inte vill ska påverkas av användaren.

Razor språket: Är en syntax som är skapat för ASP .NET Core som gör det möjligt att bygga dynamiska webbsidor. 
Det används både av Razor Pages och MVC.
Razor underlättar så att det är enklare att visa värden på en webbsida som tillhör variabler på serversidan.


Razor Pages: En Razor Page innehåller två delar, Content Page och Page Model. Razor Pages är litesmidigare med mindre projekt.

Content Page: Ligger i Razor Pages är en .cshtml-fil som är uppbyggd med det som ska kallas för Razor. Content Page bryr sig endast om UI:n.
Har Razor kod som oftast har en referens som kallas Model som pekar på PageModel objektet.

Page Model: Har publika metoder som kallas Page Handlers, (OnGet, OnPost, etc) för att kunna reagera på olika http anrop.


MVC: Är ett design mönster för att bygga webbappar men också en templete i ASP .NET Core. Som är mer advancerad struktur än Razor Pages.

Model: Beskriver den del av omgivningen som applikationen ska hjälpa till att hantera. Det beskriver också de olika egenskaperna som sakerna har. 
T.ex. för en "attgöralista/TodoList" så vill vi lagra alla uppgifter om items. 
Den reglerar också regler och logik för applikationer. 

View: Är det som användaren ser och kan interera med i en applikation. När du som användare loggar in på en webbsida så integrerar du med View.

Controller: Tar emot inputs från en webbsidas View och gör något med inputen eller skickar den vidare till en Model. 
Controller fungerar lite som en kommunikationskanal mellan Model och View.
Razor Pages har INTE Controllers.



