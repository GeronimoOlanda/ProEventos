using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext
    {
    
        // Base() passa para o elemento pai
        // constructor
        public DataContext(DbContextOptions<DataContext> options): base(options){

        }
        public DbSet<Evento> Eventos { get; set; }
    }
}