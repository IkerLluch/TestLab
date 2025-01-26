using salvemlaprincessa;

namespace TestSalvemLaPrincesa;

public class UnitTest1
{
    [Fact]
        public void CaixaNegra()
        {
            string[] armes = { "Casc", "Llança", "Armadura", "Escut", "Casc", "Espasa", "Escut" };
            var result = Princessa.CountCharacters(armes);
            Assert.Equal(1, result[0]);
            Assert.Equal(1, result[1]); 
            Assert.Equal(0, result[2]); 
        }
    [Fact]
    public void BoundaryTesting()
    {
        string[] armes = { "Llança", "Llança", "Llança" };
        var result = Princessa.CountCharacters(armes);
        Assert.Equal(0, result[0]); 
        Assert.Equal(0, result[1]); 
        Assert.Equal(3, result[2]); 
    }
    [Fact]
    public void CassosExtrems()
    {
        string[] armes = { };
        var result = Princessa.CountCharacters(armes);
        Assert.Equal(0, result[0]); 
        Assert.Equal(0, result[1]); 
        Assert.Equal(0, result[2]); 
    }
    [Fact]
    public void ProbaDeBucles()
    {
        string[] armes = new string[1000];
        for (int i = 0; i < 1000; i++) armes[i] = "Llança";
        var result = Princessa.CountCharacters(armes);
        Assert.Equal(0, result[0]); 
        Assert.Equal(0, result[1]); 
        Assert.Equal(1000, result[2]); 
    }
    [Fact]
    public void ProbaDeCamins()
    {
        
        string[] armes = 
        {
            "Casc", "Escut", "Llança", "Armadura",   
            "Casc", "Escut", "Espasa",              
            "Casc", "Escut", "Espasa",              
            "Llança", "Llança",                     
            "Llança",                               
            "Espasa", "Armadura"                   
        };

        var result = Princessa.CountCharacters(armes);
        
        Assert.Equal(1, result[0]); 
        Assert.Equal(2, result[1]); 
        Assert.Equal(3, result[2]); 
    }
}