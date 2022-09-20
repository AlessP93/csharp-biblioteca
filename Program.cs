
using System.ComponentModel.Design;
using System.Xml.Schema;

public class Documenti
{   
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public bool Stato { get; set; }
    public int Scaffale { get; set; }
    public string Autore { get; set; }


    public Documenti(string titolo, int anno, string settore, int scaffale, string autore)
    {
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Stato = false;
        Scaffale = scaffale;
        Autore = autore;
    }

}
