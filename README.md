<h1>Rubik's Cube Simulator </h1>

This is a simple 2D version of Rubik's Cube.  It simulates the moves on a Rubik's cube. The user types in the moves and moves are done on the cube and a new cube is displayed
on the screen.  The application is Console-Mode only.  The moves are F(ront), B(ack), L(eft), R(ight), (U)p and (D)own.  The clockwise moves are uppercase and the 
counter-clockwise moves are lowercase.

<h3>Why Write This?</h3>

This project was a warmup project, before I write a 3D version of Rubik's cube. It's very simple code, not flashy or exciting, but it works.  It accurately models a real
rubik's cube.  There are unit tests to prove this.

<h3>To End Program</h3>

The main program is a simple loop which reads the moves typed in by the user, executes the moves and display results.  To quit the program, press ENTER, sending an empty line.

<h3>How It Works</h3>

The moves are a series of swaps on the cube positions.  Each face has a clockwise move and a counter clockwise move.  Each cube has a position (0-53) has a color
(Blue, Orange, Yellow, Red, Green and White) which moves from one position to another.

<h3>No Solver</h3>

There is no solver.  I'll wait for the 3D version to write a solver.  The solver would be some type of tree search or graph search.  Somthing like DFS, A* or a Hueristic-based search.  Perhaps, a multi-step search algorithm.  It will take a few seconds to solve the cube.





