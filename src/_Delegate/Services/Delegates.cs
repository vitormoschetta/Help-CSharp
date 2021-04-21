namespace _Delegate
{    
    public delegate void DelPrint();
    public delegate decimal DelCalc(decimal x, decimal y);
    public delegate dynamic DelCalcGeneric(dynamic x, dynamic y, char operation);  
    public delegate void DelGenericValidate<T>(T item) where T: class;  
}