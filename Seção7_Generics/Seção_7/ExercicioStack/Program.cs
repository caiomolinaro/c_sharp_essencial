using ExercicioStack_Undo;

EditorTexto editor = new EditorTexto();
Console.WriteLine("Digitando...");

editor.DigitarChar('S');
editor.DigitarChar('t');
editor.DigitarChar('a');
editor.DigitarChar('c');
editor.DigitarChar('q');

Console.WriteLine("fazendo o undo");
editor.Undo();
editor.Undo();

Console.WriteLine("Redigitando");
editor.DigitarChar('c');
editor.DigitarChar('k');
editor.DigitarChar('!');