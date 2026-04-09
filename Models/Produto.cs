namespace ProjetoBase.Models;

public class Produto
{
    // TODO: declare as propriedades Id (int), Nome (string), Preco (decimal) e Descricao (string)]
    public int Id { get; set; }
    public string ProdutoNome { get; set; }="";
    public string Fabricante { get; set; }="";
    public decimal Preco { get; set; }
    public string Descricao { get; set; }="";
    public int Estoque { get; set; }
}

