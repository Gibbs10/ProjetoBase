using ProjetoBase.Models;

namespace ProjetoBase.Data;

public class ProdutoRepository
{
    private static Produto produto = new Produto {Id=1033, ProdutoNome= "CAFÉ", Fabricante = "Nestlé", Preco= 29.99m, Descricao= " Café Pilão - Pacote de embalagem a vácuo - 500g - Tradicional", Estoque = 100};
   


    public Produto GetProduto()
    {
        return produto;
    }
}

