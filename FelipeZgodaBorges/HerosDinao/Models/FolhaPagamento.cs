namespace HerosDinao.Models;

public class FolhaPagamento
{
    public FolhaPagamento()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    public string Id { get; set; }
    public string CPF { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public int HorasTrabalhadas { get; set; }
    public decimal ValorHora { get; set; }
    public decimal SalarioBruto { get; set; }
    public DateTime CriadoEm { get; set; }
}
