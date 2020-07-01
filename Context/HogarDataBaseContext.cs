using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HogarIoT.Models;
using System.Text;

namespace HogarIoT.Context

{
    public class HogarDataBaseContext : DbContext
    {

        //Metodo constructor de la clase.
        public HogarDataBaseContext(DbContextOptions<HogarDataBaseContext> options) : base(options)
        {
        }
        public DbSet<Dispositivo> dispositivos { get; set; }
        public DbSet<AireAcondicionado> AA { get; set; }
        public DbSet<Camara> Camaras { get; set; }
        public DbSet<Heladera> Heladeras { get; set; }
        public DbSet<Luz> Luces { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;DataBase=HogarDB;Trusted_Connection=true");

        }

       

      
    }
}