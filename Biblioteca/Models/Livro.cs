namespace Biblioteca.Models;

/// <summary>
/// Representa a tabela livro dentro do banco de dado.
/// Armazena dados básico sobre um livro referenciado ao banco.
/// </summary>
public class Livro {
    /// <summary>
    /// Identificador único do livro.
    /// </summary>
    public int Id {get;set;}
    /// <summary>
    /// Título completo do livro.
    /// </summary>
    public string? Titulo {get;set;}
    /// <summary>
    /// Número de páginas do livro.
    /// </summary>
    public int NumPaginas {get;set;}
    /// <summary>
    /// Identificador (Id) do autor de livro.
    /// </summary>
    public int AutorId {get;set;}
    /// <summary>
    /// Objeto de referência do autor do livro, incluindo todos seus dados.
    /// </summary>
    public Autor? Autor {get;set;}
    /// <summary>
    /// Genero do livro especificado.
    /// Representado por um ENUM (valor que recebe apenas valores predefinidos).
    /// </summary>
    public Genero Genero {get;set;}
    /// <summary>
    /// Data de publicação do livro.
    /// </summary>
    public DateOnly DataPublicacao {get;set;}
    /// <summary>
    /// Nome do arquivo da imagem do livro com sua extensão incluída.
    /// Ex: "Hamlet.jpg".
    /// </summary>
    public string? ImageName {get;set;}

}