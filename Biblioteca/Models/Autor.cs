namespace Biblioteca.Models;

/// <summary>
/// Representa a tabela de autor do Banco de dados.
/// Armazena dados básico sobre um autor referenciado ao banco.
/// </summary>
public class Autor
{
    /// <summary>
    /// Identificador único da classe autor.
    /// </summary>
    public int Id {get;set;}
    /// <summary>
    /// Nome completo do autor.
    /// </summary>
    public string? Nome {get;set;}
    /// <summary>
    /// Descrição breve sobre o autor.
    /// </summary>
    public string? Descricao {get;set;}
    /// <summary>
    /// Nome do arquivo da imagem do autor com sua extensão.
    /// Ex: "MachadoDeAssis.jpg"
    /// </summary>
    public string? ImageName {get;set;}

}