using minhaloja.Models;
namespace minhaloja.Data;
public class minhalojaRepository
{
    private static List <Utilitarios> teste = new List<Utilitarios> ();
     
     static minhalojaRepository()
    {
        
    teste.Add(new Utilitarios{nome="Iveco" ,valor=19900, img=""});
    }

}
