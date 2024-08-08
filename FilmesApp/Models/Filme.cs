using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesApp.Models
{
    [Table("filmes")]
    public class Filme
    {
        private int id;
        private string nome;
        private int anoLancamento;

        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }
        [Column("ano_lancamento")]
        public int AnoLancamento { get => anoLancamento; set => anoLancamento = value; }

        public virtual List<Ator> Atores { get; set; }

        public Filme() 
        {
            nome = "";
            Atores = new List<Ator>();
        }  

    }
}
