namespace ExercicioStack_Undo
{
    public class EditorTexto
    {
        private Stack<char> undoStack = new Stack<char>();
        private string texto = "";

        public void DigitarChar(char c)
        {
            texto += c;
            undoStack.Push(c);
            Console.WriteLine($"Texto digitado: {texto}");
        }

        //desfaz a ultima operacao (undo)
        public void Undo()
        {
            if(undoStack.Count > 0) 
            { 
                char ultimoChar = undoStack.Pop();
                texto = texto.Substring(0, texto.Length - 1);
                Console.WriteLine($"Texto digitado: {texto}");
            }
        }

    }
}
