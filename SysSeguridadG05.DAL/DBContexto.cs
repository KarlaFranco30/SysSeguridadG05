﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using Microsoft.EntityFrameworkCore;
using SysSeguridadG05.EN;

namespace SysSeguridadG05.DAL
{
    public class DBContexto : DbContext
    {
        public DbSet<Rol> Rol {  get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-E62T3UJ\SQLEXPRESS;Initial Catalog=DBSeguridadG05;Integrated Security=True");
        }
    }
}
