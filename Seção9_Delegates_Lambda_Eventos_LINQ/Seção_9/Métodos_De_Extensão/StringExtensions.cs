namespace Métodos_De_Extensão
{
    public static class StringExtensios
    {
        public static string InverteString(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
