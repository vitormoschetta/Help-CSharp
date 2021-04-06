using System;
using System.Globalization;
using System.IO;

namespace Disposable
{
    /*
    Para a maioria dos objetos que seu aplicativo cria, você pode contar com o coletor de lixo do .net para 
    lidar com o gerenciamento de memória. No entanto, ao criar objetos que incluem recursos não gerenciados, 
    você deve liberar explicitamente esses recursos quando terminar de usá-los. Os tipos mais comuns de 
    recursos não gerenciados são objetos que encapsulam recursos do sistema operacional, como arquivos, 
    Windows, conexões de rede ou conexões de banco de dados. Embora o coletor de lixo consiga controlar 
    o tempo de vida de um objeto que encapsula um recurso não gerenciado, ele não sabe como liberar e 
    limpar o recurso não gerenciado.

    O método Dispose libera imediatamente os recursos não gerenciados.

    */

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader? streamReader = null;
            try
            {
                streamReader = new StreamReader("file1.txt");
                string contents = streamReader.ReadToEnd();
                var info = new StringInfo(contents);
                Console.WriteLine($"The file has {info.LengthInTextElements} text elements.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file cannot be found.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error has occurred.");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("There is insufficient memory to read the file.");
            }
            finally
            {
                streamReader?.Dispose();                
            }
        }
        
    }  
}
