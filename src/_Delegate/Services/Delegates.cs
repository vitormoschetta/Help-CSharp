// Delegate é uma expressão que contém a assinatura de um método.
// Uma variável delegate pode então receber um método compatível com sua assinatura.
// Essa variável pode ser invocada de qualquer lugar, executando o método que encapsula.

namespace _Delegate
{    
    public delegate void DelPrint();
    public delegate decimal DelCalc(decimal x, decimal y);
    public delegate dynamic DelCalcGeneric(dynamic x, dynamic y, char operation);  
    public delegate void DelGenericValidate<T>(T item) where T: class;  
}