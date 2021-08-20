using projetoFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace projetoFinal.Servicos
{
  public class DbContexto : DbContext
  {
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }
    
  }
}