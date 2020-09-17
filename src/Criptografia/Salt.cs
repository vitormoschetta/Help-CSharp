using System.Security.Cryptography;

namespace CriptografiaHash
{
    public static class Salt
    {
        public static byte[] Create()  
        {  
            byte[] salt = new byte[128 / 8];  
            using (var generator = RandomNumberGenerator.Create())  
            {
                //Retorna o valor aletatorio 'generator' em Bytes:  
                generator.GetBytes(salt);              
                return salt;
            }  
        }  
    }
}