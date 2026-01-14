namespace aspnet_core_mvc_scaffold.Models
{
    public class Categoria
    {
        public Guid CategoriaID { get; set; }
        public string? Nome { get; set; }
        public IEnumerable<Produto>? Produtos { get; set; }
    }
}