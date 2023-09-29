namespace ProjetoUnip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Game = new TabPage();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            label3 = new Label();
            txtNameGame = new TextBox();
            label1 = new Label();
            txtIdGame = new TextBox();
            dataGridView2 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            GenreId = new DataGridViewTextBoxColumn();
            GameName = new DataGridViewTextBoxColumn();
            Platform = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtNomePlat = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            Game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Platform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Game
            // 
            Game.BackColor = Color.SteelBlue;
            Game.Controls.Add(button6);
            Game.Controls.Add(button5);
            Game.Controls.Add(button4);
            Game.Controls.Add(label3);
            Game.Controls.Add(txtNameGame);
            Game.Controls.Add(label1);
            Game.Controls.Add(txtIdGame);
            Game.Controls.Add(dataGridView2);
            Game.Location = new Point(4, 24);
            Game.Name = "Game";
            Game.Padding = new Padding(3);
            Game.Size = new Size(809, 556);
            Game.TabIndex = 1;
            Game.Text = "Game";
            Game.Click += Game_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(130, 338);
            button6.Name = "button6";
            button6.Size = new Size(97, 27);
            button6.TabIndex = 7;
            button6.Text = "DELETAR";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(187, 305);
            button5.Name = "button5";
            button5.Size = new Size(97, 27);
            button5.TabIndex = 6;
            button5.Text = "ATUALIZAR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(84, 305);
            button4.Name = "button4";
            button4.Size = new Size(97, 27);
            button4.TabIndex = 5;
            button4.Text = "INSERIR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(46, 219);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 4;
            label3.Text = "Nome do Jogo";
            // 
            // txtNameGame
            // 
            txtNameGame.Location = new Point(46, 237);
            txtNameGame.Name = "txtNameGame";
            txtNameGame.Size = new Size(269, 23);
            txtNameGame.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(46, 145);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 2;
            label1.Text = "ID Gênero";
            label1.Click += label1_Click;
            // 
            // txtIdGame
            // 
            txtIdGame.Location = new Point(46, 163);
            txtIdGame.Name = "txtIdGame";
            txtIdGame.Size = new Size(269, 23);
            txtIdGame.TabIndex = 1;
            txtIdGame.TextChanged += txtIdGame_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column3, GenreId, GameName });
            dataGridView2.Location = new Point(348, 18);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(445, 521);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Id";
            Column3.HeaderText = "ID";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // GenreId
            // 
            GenreId.DataPropertyName = "GenreId";
            GenreId.HeaderText = "ID Gênero";
            GenreId.MinimumWidth = 6;
            GenreId.Name = "GenreId";
            GenreId.ReadOnly = true;
            GenreId.Width = 125;
            // 
            // GameName
            // 
            GameName.DataPropertyName = "GameName";
            GameName.HeaderText = "Nome do Jogo";
            GameName.MinimumWidth = 6;
            GameName.Name = "GameName";
            GameName.ReadOnly = true;
            GameName.Width = 125;
            // 
            // Platform
            // 
            Platform.BackColor = Color.SteelBlue;
            Platform.Controls.Add(button3);
            Platform.Controls.Add(button2);
            Platform.Controls.Add(button1);
            Platform.Controls.Add(txtNomePlat);
            Platform.Controls.Add(label2);
            Platform.Controls.Add(dataGridView1);
            Platform.ForeColor = Color.Black;
            Platform.Location = new Point(4, 24);
            Platform.Name = "Platform";
            Platform.Padding = new Padding(3);
            Platform.Size = new Size(809, 556);
            Platform.TabIndex = 0;
            Platform.Text = "Platform";
            Platform.Click += Platform_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(162, 291);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(95, 27);
            button3.TabIndex = 17;
            button3.Text = "DELETAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(208, 260);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(95, 27);
            button2.TabIndex = 16;
            button2.Text = "ATUALIZAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(107, 260);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 27);
            button1.TabIndex = 15;
            button1.Text = "INSERIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtNomePlat
            // 
            txtNomePlat.Location = new Point(72, 196);
            txtNomePlat.Margin = new Padding(3, 2, 3, 2);
            txtNomePlat.Name = "txtNomePlat";
            txtNomePlat.Size = new Size(275, 23);
            txtNomePlat.TabIndex = 14;
            txtNomePlat.TextChanged += txtNomePlat_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(72, 177);
            label2.Name = "label2";
            label2.Size = new Size(130, 17);
            label2.TabIndex = 13;
            label2.Text = "Nome da Plataforma";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            dataGridView1.Location = new Point(415, 15);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(367, 526);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Id";
            Column2.HeaderText = "Id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "PlatformName";
            Column1.HeaderText = "Nome ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(Platform);
            tabControl1.Controls.Add(Game);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(817, 584);
            tabControl1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(841, 608);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Game.ResumeLayout(false);
            Game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Platform.ResumeLayout(false);
            Platform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage Game;
        private Label label3;
        private TextBox txtNameGame;
        private Label label1;
        private TextBox txtIdGame;
        private DataGridView dataGridView2;
        private TabPage Platform;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtNomePlat;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private TabControl tabControl1;
        private Button button4;
        private Button button6;
        private Button button5;
        private DataGridViewTextBoxColumn GenreId;
        private DataGridViewTextBoxColumn GameName;
        private DataGridViewTextBoxColumn Column3;
    }
}