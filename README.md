# Multiplication.Unity3d.Android
The mobile game part of the app I made for my nephew for multiplication practice.

<img src="http://i.imgur.com/Yb1ZW9k.png"></img>

Find and replace YOURURL with the url of your deployed web api project and it's ready to go. Here is that web api project: https://github.com/erhanalankus/Multiplication.WebAPI

There are four different coins to be earned in the game. Wood, copper, silver and gold. More difficult questions earn more precious coins.
Admin user enters the values for scores using the admin panel at URL/admin. Default values are, "Wood:5 Copper:10 Silver:15 Gold:20"

Player requests a question by selecting coin type. If the player requested a question to earn a silver coin, two random numbers between 2 and 15 will be generated for the player to multiply.
When the player enters the correct answer, player will earn the coin and the question will be archived in the database with the solve time in seconds. Admin should be checking solve times to help prevent cheating.

The game is created for a 240x320 screen, but it should scale semi-decently since I used UI anchors with screen percentages but it needs more work for the game to scale nicely for different screens. 



