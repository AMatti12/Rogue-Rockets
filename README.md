# Rogue-Rockets
# April 6, 2022


# Game Purpose and Function

### Players will be prompted to control a rocket travelling through space at very high speeds while being tasked with avoiding asteroids and collecting coins to add to a score.
### Rocket health boosts will also be available to heal the rocket in case of any collisions. A health bar, detailing and showcasing the rockets current health will also be present.
### Health boosts, Asteroids, and Coins will also spawn at random locations.
### The game includes three different difficulty levels (Normal, Easy, Difficult) which players can choose from. The "Difficult" level will include less health boosts and larger asteroids which the rocket (user) will have to avoid.
### A screen shake function has also been implemented, where the screen will unctrollably shake when the rocket faces a collision.
### A movable flame has also been designed trailing the rocket wherever it goes.


## Known issues or problems

### There seems to be some sort of delay as levels progress where asteroids will be destroyed but the game will only register thi after a given amount of time.
### this was confusing because the hierarchy isn't beeing clogged up as the game objects destroy themselves automatically.


## Potential Future enhancements

### I would have liked to added a set of visual damage levels to the asteroid prefabs every time they got into a collision to provide more affordance to the user.


# Self Evaluation

## What went wrong and how would you do it differently next time?

### One of my biggest challenges was learning how to troubleshoot issues. There where many times where a asteroids, boosts, and coins were not being destroyed and there was alot of confusion between whether certain items should have been triggers or colliders.
### When designing future games, I will make sure to troubleshoot functions on my own by effectively using "Debug.Log" to display data values.


## If you fell behind schedule, why? What would you do differently next time?

### I fell a little bit short of delivering the game that I had planned to design. There were still many cool functions I could have added but didn't have the time to.
### A part of the reason I fell behind was because I changed my game design from a basketball bounce game to a rocket- space-themed game. I had to change my overall planning and goals completely.
### In the future, I will ensure that I am less indecisive about game designs and will work more efficiently. It is also important to point out that I have been occupied with math work de to my diploma, so working in advance will be strongly considered when making future games.


## What problems did you run into that surprised you and how did you overcome them?

### I ran into a very large problem with limiting the rockets ability to move within the screen. It took many hours but eventually after discussing with the teacher, we decided that it would be best to limit
### the rockets movement through code. Using transform.position, I was able to limit the rocket objects' position programatically, effectively limiting it to a set of certain boundaries I chose.


## If you were doing it this app all over again, what do you wish you knew that you didn't?

### I wish I had known more aboutthe use of coroutines. I used coroutines multiple times in order to effectiverly carry out many tasks throughout several frames.
### I also wish that I would have known more about game layers and differentiating between the canvas and camera, as I wasted alot of time trying to sort layers when I could have just used the camera instead. 
