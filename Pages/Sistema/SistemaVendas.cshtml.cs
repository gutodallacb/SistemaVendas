using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaVendas.Data;
using SistemaVendas.Model;

namespace SistemaVendas.Pages
{
    public class SistemaVendasModel : PageModel
{
    private readonly AppDbContext _context;

    public SistemaVendasModel(AppDbContext context)
    {
        _context = context;
    }

    public List<SistemaVendas_Modelo> ListaSistemaVendas { get; set; }

    public void OnGet()
    {
			ListaSistemaVendas = _context.Modelo_DB_Projeto.ToList();
    }
}

}
