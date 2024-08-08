using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesApp.Models
{
    [Table("atores")]
    public class Ator
    {
        private int id;
        private string nome;
        private int idade;

        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }
        [Column("idade")]
        public int Idade { get => idade; set => idade = value; }

        public virtual List<Filme> Filmes { get; set; }

        public Ator() 
        {
            nome = "";
            Filmes = new List<Filme>();
        }

    }
}
