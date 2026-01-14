namespace aspnet_core_mvc_scaffold.Models
{
    public class Produto
    {
        public Guid ProdutoID { get; set; }
        public string? Nome { get; set; }
        public int Estoque { get; set; }
        public Guid CategoriaID { get; set; }
        public Categoria? Categorias { get; set; }
    }
}