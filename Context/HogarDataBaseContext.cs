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
    }
        //AQUI PONER EL METODO ONMODEL CREATING

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Estado>().HasData(
        //        new Estado
        //        {
        //            EstadoID = 1,
        //            DescripcionEstado = "ENCENDIDO"

        //        },
        //        new Photo
        //        {
        //            PhotoID = 2,
        //            Title = "Orchard",
        //            Description = "This was taken on a sunny fall day.",
        //            PhotoFileName = "orchard.jpg",
        //            ImageMimeType = "image/jpeg",
        //            CreatedDate = DateTime.Today
        //        },
        //        new Photo
        //        {
        //            PhotoID = 3,
        //            Title = "Blackberries",
        //            Description = "This was late for blackberries so they are a little past their best.",
        //            PhotoFileName = "blackberries.jpg",
        //            ImageMimeType = "image/jpeg",
        //            CreatedDate = DateTime.Today
        //        },
        //        new Photo
        //        {
        //            PhotoID = 4,
        //            Title = "Ripples",
        //            Description = "Interesting reflections and colors in this marine shot.",
        //            PhotoFileName = "ripples.jpg",
        //            ImageMimeType = "image/jpeg",
        //            CreatedDate = DateTime.Today
        //        },
        //        new Photo
        //        {
        //            PhotoID = 5,
        //            Title = "View Along a Path",
        //            Description = "The light was great through the trees so I had to stop and take this.",
        //            PhotoFileName = "path.jpg",
        //            ImageMimeType = "image/jpeg",
        //            CreatedDate = DateTime.Today
        //        },
        //        new Photo
        //        {
        //            PhotoID = 6,
        //            Title = "Headland View",
        //            Description = "A beautiful view on a beautiful day.",
        //            PhotoFileName = "headland.jpg",
        //            ImageMimeType = "image/jpeg",
        //            CreatedDate = DateTime.Today
        //        },
        //        new Photo
        //        {
        //            PhotoID = 7,
        //            Title = "Fungi",
        //            Description = "Found a fugi During a walk in the forest.",
        //            PhotoFileName = "fungi.jpg",
        //            ImageMimeType = "image/jpeg",
        //            CreatedDate = DateTime.Today
        //        });
//        }
//    }
//}
//    }
//}



        


