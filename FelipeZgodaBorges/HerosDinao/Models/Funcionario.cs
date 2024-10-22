namespace HerosDinao.Models;

public class Funcionario
{
    public Funcionario()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    public string Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Cargo { get; set; }
    public DateTime CriadoEm { get; set; }
}
