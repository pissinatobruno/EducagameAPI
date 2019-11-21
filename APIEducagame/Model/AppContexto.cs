using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEducagame.Model
{
    public class AppContexto : DbContext
    {

        public AppContexto(DbContextOptions<AppContexto> options) : base(options)
        {

        }

        public DbSet<tbl_alunos> tbl_Alunos { get; set; }
        public DbSet<tbl_desafio1> tbl_Desafio1 { get; set; }
        public DbSet<tbl_desafio2> tbl_Desafio2 { get; set; }
        public DbSet<tbl_desafio3> tbl_Desafio3 { get; set; }
        public DbSet<tbl_desafio4> tbl_Desafio4 { get; set; }
        public DbSet<tbl_desafio5> tbl_Desafio5 { get; set; }
        public DbSet<tbl_desafio6> tbl_Desafio6 { get; set; }
        public DbSet<tbl_desafio7> tbl_Desafio7 { get; set; }
        public DbSet<tbl_salas> tbl_Salas { get; set; }
        public DbSet<tbl_aluno_salas> tbl_Aluno_Salas { get; set; }

    }
}
