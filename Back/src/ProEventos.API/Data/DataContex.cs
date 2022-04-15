using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class DataContex : DbContext 
    {
        public DataContex(DbContextOptions<DataContex> options) : base(options) 
        {

        }
        public DbSet<Evento> Eventos { get; set; }
    }
}