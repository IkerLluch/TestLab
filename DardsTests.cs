using DardsDigitals;

namespace DardsTests;

public class UnitTest1
{
    [Fact]
    public void TestCaixaNegra()
    {
        Random random = new Random();
        int puntstotals1 = 0;
        int puntstotals2 = 0;
        
        var result = JocDards.LanzarDardos(random, puntstotals1, puntstotals2);
       
        Assert.IsType<(int, int)>(result);  
        Assert.InRange(result.Item1, 0, 50); 
        Assert.InRange(result.Item2, 0, 50);
    }
    [Fact]
    public void TestBoundaryTesting()
    {
        Random random = new Random();
        int puntstotals1 = 49;  
        int puntstotals2 = 50;  
        
        var result = JocDards.LanzarDardos(random, puntstotals1, puntstotals2);
       
        Assert.InRange(result.Item1, 0, 50); 
        Assert.InRange(result.Item2, 0, 50); 
    }
    [Fact]
    public void TestProbaDeCamins()
    {
        
        Random random = new Random();
        int puntstotals1 = 30;
        int puntstotals2 = 45;

        
        var result = JocDards.LanzarDardos(random, puntstotals1, puntstotals2);

        
        Assert.True(result.Item1 > puntstotals1);  
        Assert.True(result.Item2 > puntstotals2);  
    }
    [Fact]
    public void TestBucle()
    {
       
        Random random = new Random();
        int puntstotals1 = 20;
        int puntstotals2 = 20;
        
        while (puntstotals1 < 50 && puntstotals2 < 50)
        {
            var result = JocDards.LanzarDardos(random, puntstotals1, puntstotals2);
            puntstotals1 = result.Item1;
            puntstotals2 = result.Item2;
        }
        
        Assert.True(puntstotals1 >= 50 || puntstotals2 >= 50);  
    }
    [Fact]
    public void TestCasosExtrems()
    {
        Random random = new Random();
        int puntstotals1 = 48;  
        int puntstotals2 = 2;   
        
        var result = JocDards.LanzarDardos(random, puntstotals1, puntstotals2);
        
        Assert.InRange(result.Item1, 0, 50); 
        Assert.InRange(result.Item2, 0, 50); 
        Assert.True(result.Item1 > puntstotals1 || result.Item2 > puntstotals2);  
    }
    
    
}