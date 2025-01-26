using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1;

public class CarreraTest
{
    [Fact]
    public void TestCaixaNegra()
    {
        
        int[,] carrera = {
            { 1, 9, 8, 7, 1 },
            { 2, 5, 6, 7, 2 },
            { 3, 3, 4, 5, 3 },
            { 4, 7, 8, 9, 4 }
        };
        var cr = new Carrera.Carrera();

        int result = cr.ConsegueixElGuanyador(carrera);

        Assert.Equal(1, result); 
    }
    [Fact]
    public void TestBoundaryTesting()
    {
        int[,] carrera = {
            { 1, 1, 1, 1, 1 },
            { 2, 1, 1, 1, 1 },
            { 3, 1, 1, 1, 1 },
            { 4, 1, 1, 1, 1 }
        };
        var cr = new Carrera.Carrera();

        int result = cr.ConsegueixElGuanyador(carrera);

        Assert.Equal(1, result); 
    }
    [Fact]
    public void Test_Bucles()
    {
        int[,] carrera = {
            { 1, 5, 6, 7, 8 },
            { 2, 1, 2, 3, 4 },
            { 3, 8, 7, 6, 5 },
            { 4, 2, 3, 4, 5 }
        };
        var cr = new Carrera.Carrera();

        int result = cr.ConsegueixElGuanyador(carrera);

        Assert.Equal(1, result); 
    }
    [Fact]
    public void TestCamins()
    {
        int[,] carrera = {
            { 1, 1, 5, 3, 7 },
            { 2, 2, 8, 6, 4 },
            { 3, 3, 7, 9, 2 },
            { 4, 9, 5, 1, 4 }
        };
        var cr = new Carrera.Carrera();

        int result = cr.ConsegueixElGuanyador(carrera);

        Assert.Equal(4, result); 
    }
    [Fact]
    public void Test_CasosExtremos()
    {
        int[,] carrera = new int[0, 0];
        var cr = new Carrera.Carrera();

        Assert.Throws<IndexOutOfRangeException>(() => cr.ConsegueixElGuanyador(carrera));
    }

}
