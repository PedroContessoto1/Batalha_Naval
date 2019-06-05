namespace BatalhaNaval
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bstart = new System.Windows.Forms.Button();
            this.bgrid = new System.Windows.Forms.Button();
            this.bmedio = new System.Windows.Forms.Button();
            this.bfacil = new System.Windows.Forms.Button();
            this.bdificil = new System.Windows.Forms.Button();
            this.brestart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lfalta2 = new System.Windows.Forms.Label();
            this.lfalta1 = new System.Windows.Forms.Label();
            this.Lunidades = new System.Windows.Forms.Label();
            this.bcontratorpedeiro = new System.Windows.Forms.Button();
            this.bsubmarino = new System.Windows.Forms.Button();
            this.bcruzador = new System.Windows.Forms.Button();
            this.bcouraçado = new System.Windows.Forms.Button();
            this.porta_aviões = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bstart
            // 
            this.bstart.BackColor = System.Drawing.Color.SlateBlue;
            this.bstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bstart.Location = new System.Drawing.Point(471, 429);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(113, 36);
            this.bstart.TabIndex = 0;
            this.bstart.Text = "Start";
            this.bstart.UseVisualStyleBackColor = false;
            this.bstart.Click += new System.EventHandler(this.Bstart_Click);
            // 
            // bgrid
            // 
            this.bgrid.BackColor = System.Drawing.Color.SlateBlue;
            this.bgrid.BackgroundImage = global::BatalhaNaval.Properties.Resources.mar_azul_vista_de_cima_1401_1061;
            this.bgrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgrid.Location = new System.Drawing.Point(471, 431);
            this.bgrid.Name = "bgrid";
            this.bgrid.Size = new System.Drawing.Size(113, 36);
            this.bgrid.TabIndex = 15;
            this.bgrid.Text = "Grid";
            this.bgrid.UseVisualStyleBackColor = false;
            this.bgrid.Click += new System.EventHandler(this.Bgrid_Click);
            // 
            // bmedio
            // 
            this.bmedio.BackColor = System.Drawing.Color.SlateBlue;
            this.bmedio.BackgroundImage = global::BatalhaNaval.Properties.Resources.mar_azul_vista_de_cima_1401_1061;
            this.bmedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmedio.Location = new System.Drawing.Point(432, 428);
            this.bmedio.Name = "bmedio";
            this.bmedio.Size = new System.Drawing.Size(205, 37);
            this.bmedio.TabIndex = 14;
            this.bmedio.Text = "Medio";
            this.bmedio.UseVisualStyleBackColor = false;
            this.bmedio.Click += new System.EventHandler(this.Bmedio_Click);
            // 
            // bfacil
            // 
            this.bfacil.BackColor = System.Drawing.Color.SlateBlue;
            this.bfacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfacil.Image = global::BatalhaNaval.Properties.Resources.sonhar_com_mar_agitado_587335907;
            this.bfacil.Location = new System.Drawing.Point(72, 429);
            this.bfacil.Name = "bfacil";
            this.bfacil.Size = new System.Drawing.Size(205, 37);
            this.bfacil.TabIndex = 13;
            this.bfacil.Text = "Facil";
            this.bfacil.UseVisualStyleBackColor = false;
            this.bfacil.Click += new System.EventHandler(this.Bfacil_Click);
            // 
            // bdificil
            // 
            this.bdificil.BackColor = System.Drawing.Color.Red;
            this.bdificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdificil.Image = global::BatalhaNaval.Properties.Resources.fogo_forte;
            this.bdificil.Location = new System.Drawing.Point(738, 429);
            this.bdificil.Name = "bdificil";
            this.bdificil.Size = new System.Drawing.Size(205, 37);
            this.bdificil.TabIndex = 12;
            this.bdificil.Text = "☠☠ Impossível ☠☠";
            this.bdificil.UseVisualStyleBackColor = false;
            this.bdificil.Click += new System.EventHandler(this.Bdificil_Click);
            // 
            // brestart
            // 
            this.brestart.BackColor = System.Drawing.Color.SlateBlue;
            this.brestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brestart.Image = global::BatalhaNaval.Properties.Resources.mar_azul_vista_de_cima_1401_1061;
            this.brestart.Location = new System.Drawing.Point(441, 430);
            this.brestart.Name = "brestart";
            this.brestart.Size = new System.Drawing.Size(113, 36);
            this.brestart.TabIndex = 11;
            this.brestart.Text = "Restart";
            this.brestart.UseVisualStyleBackColor = false;
            this.brestart.Click += new System.EventHandler(this.Brestart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::BatalhaNaval.Properties.Resources.sonhar_com_mar_agitado_587335907;
            this.label2.Location = new System.Drawing.Point(220, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 91);
            this.label2.TabIndex = 10;
            this.label2.Text = "Você Perdeu : (";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::BatalhaNaval.Properties.Resources.sonhar_com_mar_agitado_587335907;
            this.label1.Location = new System.Drawing.Point(220, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 91);
            this.label1.TabIndex = 9;
            this.label1.Text = "Você Venceu !!!";
            // 
            // lfalta2
            // 
            this.lfalta2.AutoSize = true;
            this.lfalta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfalta2.Image = global::BatalhaNaval.Properties.Resources.mar_azul;
            this.lfalta2.Location = new System.Drawing.Point(698, 9);
            this.lfalta2.Name = "lfalta2";
            this.lfalta2.Size = new System.Drawing.Size(103, 25);
            this.lfalta2.TabIndex = 8;
            this.lfalta2.Text = "Falta : 17";
            // 
            // lfalta1
            // 
            this.lfalta1.AutoSize = true;
            this.lfalta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfalta1.Image = global::BatalhaNaval.Properties.Resources.mar_azul;
            this.lfalta1.Location = new System.Drawing.Point(174, 9);
            this.lfalta1.Name = "lfalta1";
            this.lfalta1.Size = new System.Drawing.Size(103, 25);
            this.lfalta1.TabIndex = 7;
            this.lfalta1.Text = "Falta : 17";
            // 
            // Lunidades
            // 
            this.Lunidades.AutoSize = true;
            this.Lunidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunidades.Image = global::BatalhaNaval.Properties.Resources.mar_azul_vista_de_cima_1401_1061;
            this.Lunidades.Location = new System.Drawing.Point(127, 9);
            this.Lunidades.Name = "Lunidades";
            this.Lunidades.Size = new System.Drawing.Size(242, 25);
            this.Lunidades.TabIndex = 6;
            this.Lunidades.Text = "Numero de unidades : 0";
            this.Lunidades.Click += new System.EventHandler(this.Lunidades_Click);
            // 
            // bcontratorpedeiro
            // 
            this.bcontratorpedeiro.BackColor = System.Drawing.Color.SlateBlue;
            this.bcontratorpedeiro.BackgroundImage = global::BatalhaNaval.Properties.Resources.mar_azul;
            this.bcontratorpedeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcontratorpedeiro.Location = new System.Drawing.Point(452, 279);
            this.bcontratorpedeiro.Name = "bcontratorpedeiro";
            this.bcontratorpedeiro.Size = new System.Drawing.Size(205, 37);
            this.bcontratorpedeiro.TabIndex = 5;
            this.bcontratorpedeiro.Text = "Contratorpedeiro";
            this.bcontratorpedeiro.UseVisualStyleBackColor = false;
            this.bcontratorpedeiro.Click += new System.EventHandler(this.Bcontratorpedeiro_Click);
            // 
            // bsubmarino
            // 
            this.bsubmarino.BackColor = System.Drawing.Color.SlateBlue;
            this.bsubmarino.BackgroundImage = global::BatalhaNaval.Properties.Resources.mar_azul;
            this.bsubmarino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsubmarino.Location = new System.Drawing.Point(452, 234);
            this.bsubmarino.Name = "bsubmarino";
            this.bsubmarino.Size = new System.Drawing.Size(205, 37);
            this.bsubmarino.TabIndex = 4;
            this.bsubmarino.Text = "Submarino";
            this.bsubmarino.UseVisualStyleBackColor = false;
            this.bsubmarino.Click += new System.EventHandler(this.Bsubmarino_Click);
            // 
            // bcruzador
            // 
            this.bcruzador.BackColor = System.Drawing.Color.SlateBlue;
            this.bcruzador.BackgroundImage = global::BatalhaNaval.Properties.Resources.mar_azul;
            this.bcruzador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcruzador.Location = new System.Drawing.Point(452, 189);
            this.bcruzador.Name = "bcruzador";
            this.bcruzador.Size = new System.Drawing.Size(205, 37);
            this.bcruzador.TabIndex = 3;
            this.bcruzador.Text = " Cruzador";
            this.bcruzador.UseVisualStyleBackColor = false;
            this.bcruzador.Click += new System.EventHandler(this.Bcruzador_Click);
            // 
            // bcouraçado
            // 
            this.bcouraçado.BackColor = System.Drawing.Color.SlateBlue;
            this.bcouraçado.BackgroundImage = global::BatalhaNaval.Properties.Resources.mar_azul;
            this.bcouraçado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcouraçado.Location = new System.Drawing.Point(452, 144);
            this.bcouraçado.Name = "bcouraçado";
            this.bcouraçado.Size = new System.Drawing.Size(205, 37);
            this.bcouraçado.TabIndex = 2;
            this.bcouraçado.Text = "Couraçado";
            this.bcouraçado.UseVisualStyleBackColor = false;
            this.bcouraçado.Click += new System.EventHandler(this.Bcouraçado_Click);
            // 
            // porta_aviões
            // 
            this.porta_aviões.BackColor = System.Drawing.Color.SlateBlue;
            this.porta_aviões.BackgroundImage = global::BatalhaNaval.Properties.Resources.mar_azul;
            this.porta_aviões.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porta_aviões.Location = new System.Drawing.Point(452, 99);
            this.porta_aviões.Name = "porta_aviões";
            this.porta_aviões.Size = new System.Drawing.Size(205, 37);
            this.porta_aviões.TabIndex = 1;
            this.porta_aviões.Text = "Porta aviões";
            this.porta_aviões.UseVisualStyleBackColor = false;
            this.porta_aviões.Click += new System.EventHandler(this.Porta_aviões_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::BatalhaNaval.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1001, 478);
            this.Controls.Add(this.bgrid);
            this.Controls.Add(this.bmedio);
            this.Controls.Add(this.bfacil);
            this.Controls.Add(this.bdificil);
            this.Controls.Add(this.brestart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lfalta2);
            this.Controls.Add(this.lfalta1);
            this.Controls.Add(this.Lunidades);
            this.Controls.Add(this.bcontratorpedeiro);
            this.Controls.Add(this.bsubmarino);
            this.Controls.Add(this.bcruzador);
            this.Controls.Add(this.bcouraçado);
            this.Controls.Add(this.porta_aviões);
            this.Controls.Add(this.bstart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Batalha_Naval_1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bstart;
        private System.Windows.Forms.Button porta_aviões;
        private System.Windows.Forms.Button bcouraçado;
        private System.Windows.Forms.Button bcruzador;
        private System.Windows.Forms.Button bsubmarino;
        private System.Windows.Forms.Button bcontratorpedeiro;
        private System.Windows.Forms.Label Lunidades;
        private System.Windows.Forms.Label lfalta1;
        private System.Windows.Forms.Label lfalta2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button brestart;
        private System.Windows.Forms.Button bdificil;
        private System.Windows.Forms.Button bfacil;
        private System.Windows.Forms.Button bmedio;
        private System.Windows.Forms.Button bgrid;
    }
}

