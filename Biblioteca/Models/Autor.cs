namespace Biblioteca.Models;

public class Autor
{
    public int Id {get;set;}
    public string? Nome {get;set;}

    public Autor(int id,string Nome)
    {   
        this.Id =id;
        this.Nome= Nome;
    }
}