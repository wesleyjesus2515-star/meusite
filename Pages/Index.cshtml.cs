using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using minhaloja.Models;
using minhaloja.Data;

namespace minhaloja.Pages;

public class IndexModel : PageModel
{ 
    private readonly  minhalojaRepository _repositorio;

    public List<Utilitarios> produtos {get;set;} =  new();
    public IndexModel(minhalojaRepository repositorio)
    {
        _repositorio = repositorio;
    }
    
    public void OnGet()
    { 
        produtos = _repositorio.puxaProduto();
    }
}
