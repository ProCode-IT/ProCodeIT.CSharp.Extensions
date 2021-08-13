namespace ProCodeIT.Extensions.String
{
    public static class StringExtensions
    {
        /// <summary>
        /// Retorna uma nova string que alinha os caracteres ao centro nesta instância, preenchendo-os com caractere Unicode especificado à esquerda e à direita, por um comprimento total especificado.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="length">Comprimento total</param>
        /// <param name="paddingChar">Caractere Unicode para preenchimento. Default: ' '</param>
        /// <returns></returns>
        public static string PadBoth(this string source, int length, char paddingChar = (char)32)
        {
            int spaces = length - source.Length;
            int padLeft = spaces / 2 + source.Length;

            return source.PadLeft(padLeft, paddingChar).PadRight(length, paddingChar);
        }
    }
}
