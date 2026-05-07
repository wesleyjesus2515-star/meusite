using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;
using minhaloja.Models;
namespace minhaloja.Data;
public class minhalojaRepository
{
    

private readonly AppBdContext _context;
public minhalojaRepository(AppBdContext context)
{
_context = context;
}


public List<Utilitarios> puxaProduto()
{
return _context.Produtos.ToList();
}


public void Adicionar(Utilitarios produto)
{
_context.Produtos.Add(produto); 
_context.SaveChanges(); 
}
}
