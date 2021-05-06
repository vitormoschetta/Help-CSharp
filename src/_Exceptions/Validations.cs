using System;

namespace _Exceptions
{
    public static class Validations
    {
        public static void NuloOuVazio(string value, string mensagem)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidOperationException(mensagem);
        }

        public static void ValorMinimo(decimal value, decimal valorMinimo, string mensagem)
        {
            if (value < valorMinimo)
                throw new InvalidOperationException(mensagem);
        }

        public static void QuantidadeMinimaCaracteres(string value, int quantidadeEsperada)
        {
            if (value.Length < quantidadeEsperada)
                throw new Exception("Quantidade mínima de caracteres é " + quantidadeEsperada);
        }

        public static void ObjetoNul(object objeto, string mensagem)
        {
            if (objeto == null)
                throw new Exception(mensagem);
        }
    }
}