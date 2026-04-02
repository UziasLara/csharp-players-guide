// Write a program that allows you to play the game of Tic-Tac-Toe
// Main method for the game.
TicTacToeGame game = new (new Player('O'), new Player('X'), new GameBoard(), new Renderer());
game.Run();