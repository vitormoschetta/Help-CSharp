namespace AccessModifiers.Private
{
    public class PrivateProduct // <-- pode instanciar um objeto 
    {
        private string Name;    // <-- mas não acessa a propriedade
    }

    public class PrivateProductB
    {
        private string Name;    // <-- acessível pelos métodos públicos
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name.Trim()))
                Name = name;
        }
        public string GetName()
        {
            return Name;
        }
    }

    public class PrivateProductC
    {
        public PrivateProductC(string name)
        {
            Name = name;
        }
        private string Name;

        public string GetName()
        {
            return Name;
        }
    }

}