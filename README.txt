Use the mouse to control the player character.

press q, w, e, and r to fire.


Currently this code only uses Type object design pattern.  I wrote a state machine but it isn't currently being used.
I have now added an L-System to the game for generating the level.  Currently the L-System is randomize.  In future versions i plan to make it so that the player can enter data to customize the L-System.


VERSION LOG:

December 2, 2017:
I did not have time to do very much work on this during the last week do do spending a lot of time working on projects in other classes.
I have made improvements for the code that creates the bullet paterns and i also edited the bullets to be able to trigger when they touch each other.
I also made some changes to the file structure.
Currently the only bullets that react to each other are fire bullets and water bullets.
There also currently is a glitch that is stopping enemies from firing.
In the next version I am going to include a observer / event design patter.

December 15, 2017:
Added an L-System to the game to the game to generate enemies in a recursive pattern.
Currently the seed and number of recursions are random.  In future versions the player will be able to customize it.
I also fixed several glitches and made it so that ememies move to a random place when they first appear.