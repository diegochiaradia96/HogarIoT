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
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Modo> Modos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;DataBase=HogarDB;Trusted_Connection=true");

        }

        //METODO ONMODEL CREATING
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ENUM ESTADO
            modelBuilder.Entity<Estado>().HasData(
                new Estado
                {
                    IdEstado = 1,
                    DescripcionEstado = "ENCENDIDO"
                },

                new Estado
                {
                    IdEstado = 2,
                    DescripcionEstado = "APAGADO"
                },

                new Estado
                {
                    IdEstado = 3,
                    DescripcionEstado = "SIN_CONEXION"
                });

            //ENUM MODO
            modelBuilder.Entity<Modo>().HasData(
               new Modo
               {
                   IdModo = 1,
                   DescripcionModo = "AUTO"
               },

               new Modo
               {
                   IdModo = 2,
                   DescripcionModo = "CALOR"
               },

               new Modo
               {
                   IdModo = 3,
                   DescripcionModo = "FRIO"
               },

               new Modo
               {
                   IdModo = 4,
                   DescripcionModo = "VENTILACION"
               });
        }
    }    
}






