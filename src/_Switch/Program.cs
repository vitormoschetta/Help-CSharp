using System;

namespace _Switch
{
    class Program
    {
        public enum EStatus
        {
            created = 1,
            updated = 2,
            deleted = 3
        }
        static void Main(string[] args)
        {
            var status = EStatus.deleted;
            Console.WriteLine(ReturnStatusMessage(status));
        }

        static string ReturnStatusMessage(EStatus status)
        {
            return status switch
            {
                EStatus.created => "Estatus de cadastrado",
                EStatus.updated => "Estatus de alterado",
                EStatus.deleted => "Estatus de excluído"                
            };
        }
    }
}
