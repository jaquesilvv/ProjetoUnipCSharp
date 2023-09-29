using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProjetoUnip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarPlataformas();
            AtualizarGames();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ////INSERT
        //private void button1_Click(object sender, EventArgs e)

        //{
        //    var ctx = new VideoGamesContext();

        //    Platform platform = new Platform();
        //    platform.PlatformName = txtNomePlat.Text;
        //    ctx.Platforms.Add(platform);
        //    var i = ctx.SaveChanges();

        //    AtualizarPlataformas();
        //}

        //UPDATE
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

        //    var ctx = new VideoGamesContext();
        //    var model = ctx.Platforms.FirstOrDefault(w => w.Id == id);

        //    model.PlatformName = txtNomePlat.Text;
        //    ctx.Platforms.Update(model);
        //    ctx.SaveChanges();

        //    AtualizarPlataformas();
        //}

        //DELETE
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

        //    var ctx = new VideoGamesContext();
        //    var model = ctx.Platforms.FirstOrDefault(w => w.Id == id);

        //    ctx.Platforms.Remove(model);
        //    ctx.SaveChanges();

        //    AtualizarPlataformas();
        //}

        //REFRESH NO DATAGRID1
        private void AtualizarPlataformas()
        {
            using (VideoGamesContext db = new VideoGamesContext())
            {
                var dados = db.Platforms.ToList();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dados;


            }
        }

        //REFRESH NO DATAGRID2
        private void AtualizarGames()
        {
            using (VideoGamesContext db = new VideoGamesContext())
            {
                var dados = db.Games.ToList();
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dados;


            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Game_Click(object sender, EventArgs e)
        {
            AtualizarGames();
        }

        private void txtNomePlat_TextChanged(object sender, EventArgs e)
        {

        }

        //INSERT PLATFORM
        private void button1_Click_1(object sender, EventArgs e)
        {
            var ctx = new VideoGamesContext();

            Platform platform = new Platform();
            platform.PlatformName = txtNomePlat.Text;
            ctx.Platforms.Add(platform);
            var i = ctx.SaveChanges();

            AtualizarPlataformas();
        }

        //UPDATE PLATFORM
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                var ctx = new VideoGamesContext();
                var model = ctx.Platforms.FirstOrDefault(w => w.Id == id);

                model.PlatformName = txtNomePlat.Text;
                ctx.Platforms.Update(model);
                ctx.SaveChanges();

                AtualizarPlataformas();
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DELETE PLATFORM
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                var ctx = new VideoGamesContext();
                var model = ctx.Platforms.FirstOrDefault(w => w.Id == id);

                ctx.Platforms.Remove(model);
                ctx.SaveChanges();

                AtualizarPlataformas();
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIdGame_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Platform_Click(object sender, EventArgs e)
        {

        }

        //INSERT GAMES
        private void button4_Click(object sender, EventArgs e)
        {
            var ctx = new VideoGamesContext();

            Game game = new Game();
            game.GameName = txtNameGame.Text;
            game.GenreId = (int.Parse(txtIdGame.Text));
            ctx.Games.Add(game);
            var i = ctx.SaveChanges();

            AtualizarGames();
        }

        //DELETE GAMES
        private void button6_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {
                var id = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());

                var ctx = new VideoGamesContext();
                var model = ctx.Games.FirstOrDefault(w => w.Id == id);

                ctx.Games.Remove(model);
                ctx.SaveChanges();

                AtualizarGames();
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //UPDATE GAMES
        private void button5_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {

                var id = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());

                var ctx = new VideoGamesContext();
                var model = ctx.Games.FirstOrDefault(w => w.Id == id);

                model.GameName = txtNameGame.Text;
                model.GenreId = (int.Parse(txtIdGame.Text));
                ctx.Games.Update(model);
                ctx.SaveChanges();

                AtualizarGames();
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}