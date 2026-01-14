namespace aspnet_core_mvc_scaffold.Models
{
    public class Cliente
    {
        public Guid ClienteID { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}