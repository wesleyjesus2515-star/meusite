

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.RazorPages;
using minhaloja.Models;

using minhaloja.Data;
using Microsoft.Extensions.Options;

public class Cadastromodel(minhalojaRepository Repositorio): PageModel

    {
    public IActionResult onPost( int Id,string Nome,int Valor, string Img )
    {var produto = new Utilitarios
    {
        Id = Id,
        nome=Nome,
        valor=Valor,
        img = Img

    };
    Repositorio.Adicionar(produto);
    return RedirectToPage("/index");

    }
    }