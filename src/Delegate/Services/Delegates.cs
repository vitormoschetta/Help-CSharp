namespace Delegate
{    
    public delegate void DelPrint();
    public delegate decimal DelCalc(decimal x, decimal y);
    public delegate dynamic DelCalcGeneric(dynamic x, dynamic y, char operation);  
    public delegate void DelGeneric<T>(T item);  
}