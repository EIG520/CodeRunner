// See https://aka.ms/new-console-template for more information

// TAKE OUT FROM GAME

Line line1 = new InitStr("foo", "var");
Line line2 = new WriteVar("foo");

InternalProgram program = new InternalProgram();

program.addLine(line1);
program.addLine(line2);

program.run();
