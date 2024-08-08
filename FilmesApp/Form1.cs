using FilmesApp.Models;

namespace FilmesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Contexto db;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            this.db.Database.EnsureCreated();
        
            Ator ator = new Ator();
            ator.Nome = "Felipe Rosa";
            ator.Idade = 18;

            this.db.Ator.Add(ator);
            this.db.SaveChanges();

            Filme f = new Filme();
            f.Nome = "Vingadores Ultimato";
            f.AnoLancamento = 2019;
            f.Atores.Add(ator);

            this.db.Filme.Add(f);
            this.db.SaveChanges();

            List<Ator> atores = this.db.Ator.ToList();
            dgvAtores.DataSource = atores;
        }
    }
}
