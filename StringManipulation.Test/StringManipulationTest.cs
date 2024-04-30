using Xunit;
using Moq;
using Microsoft.Extensions.Logging;
using StringManipulation; 

public class StringManipulationTest
{
    [Fact]
    //Basicamente ac� vamos a crear dos strings en las cuales se les pondr�n dos textos
    //Y con el Assert, vamos a corroborar de que el resultado del m�todo sea el mismo
    public void TestConcatenateStrings()
    {
        var stringOperations = new StringOperations();
        string str1 = "Hola";
        string str2 = "Gente";

        string resultado = stringOperations.ConcatenateStrings(str1, str2);
        
        Assert.Equal("Hola Gente", resultado);
    }

    [Fact]
    //Aqu� vamos a crear un string el cual lo que le pongamos se va a poner a la reversa
    public void TestReverseString()
    {
        
        var stringOperations = new StringOperations();
        string x = "hola";

        string resultado = stringOperations.ReverseString(x);

        Assert.Equal("aloh", resultado);
    }

    [Fact]
    //Aqu� crearemos una string con un texto, el cual el m�todo nos va a sacar el n�mero de caracteres
    public void TestGetStringLength()
    {
        var stringOperations = new StringOperations();
        string x = "Hola";

        int tamano = stringOperations.GetStringLength(x);

        Assert.Equal(4, tamano);
    }

    [Fact]
    //Crearemos una string para eliminar los espacios que hayan en la misma
    public void TestRemoveWhitespace()
    {
        var stringOperations = new StringOperations();
        string x = "Liliana Hola";

        string resultado = stringOperations.RemoveWhitespace(x);

        Assert.Equal("LilianaHola", resultado);
    }

    [Fact]
    //Crearemos un string y le daremos un valor en especifico para que la
    //longitud de la misma se comporte acorde a nuestro interes
    public void TestTruncateString()
    {
        var stringOperations = new StringOperations();
        string x = "Maria Hola";

        string resultado = stringOperations.TruncateString(x, 5);

        Assert.Equal("Maria", resultado);
    }

    [Fact]
    //Aqu� se crean dos string, los cuales se corrobora si son Palindromos
    //Esto quiere decir, que si se leen de igual manera de atr�s para adelate y viceversa
    public void TestIsPalindrome()
    {
        var stringOperations = new StringOperations();
        string Palindromo = "Oso";
        string NoPalindromo = "Maria";


        Assert.True(stringOperations.IsPalindrome(Palindromo));
        Assert.False(stringOperations.IsPalindrome(NoPalindromo));
    }

    [Fact]
    //Se crea un string,y se somete para saber la cantidad de caracteres que hay en el mismo
    public void TestCountOccurrences()
    {
        var stringOperations = new StringOperations();
        string x = "Hola";

        int resultado = stringOperations.CountOccurrences(x, 'l');

        Assert.Equal(1, resultado);
        
    }


    [Fact]
    //Pondremos una palabra en singular, y el m�todo la pondr� en plural
    public void TestPluralize()
    {
        var stringOperations = new StringOperations();
        string Singular = "apple";

        string resultadoSingular = stringOperations.Pluralize(Singular);

        Assert.Equal("apples", resultadoSingular);
    
    }

    [Fact]
    //Aqu� crearemos un string y un entero, este entero se va a convertir en palabras
    public void TestQuantintyInWords()
    {

        var stringOperations = new StringOperations();
        string x = "apples";
        int cantidad = 2;

        string resultado = stringOperations.QuantintyInWords(x, cantidad);

        Assert.Equal("two apples", resultado);
    }

    [Fact]
    //Aqu� simplemente se crea un string, el cual tiene un n�mero en Romano, y se convertir� a Entero
    public void TestFromRomanToNumber()
    {
        var stringOperations = new StringOperations();
        string x = "XIV";

        int resultado = stringOperations.FromRomanToNumber(x);

        Assert.Equal(14, resultado);
    }
}