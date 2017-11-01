using Microsoft.EntityFrameworkCore;
using rafi.Models;

namespace rafi.Persistance
{
    public  class RafiDbContext : DbContext
    {
        public RafiDbContext( DbContextOptions <RafiDbContext> options)    
   : base(options){

   }
   public DbSet<Make> Makes { get; set; }
      public DbSet<Model> Models { get; set; }
   
    }
}