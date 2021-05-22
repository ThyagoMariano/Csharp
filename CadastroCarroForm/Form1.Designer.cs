
namespace CadastroCarroForm
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDono = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.mtbMarca = new System.Windows.Forms.MaskedTextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.mtbDono = new System.Windows.Forms.MaskedTextBox();
            this.mtbAno = new System.Windows.Forms.MaskedTextBox();
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btProcurar = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.txtListar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.DarkCyan;
            this.lblPlaca.ForeColor = System.Drawing.Color.White;
            this.lblPlaca.Location = new System.Drawing.Point(75, 23);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(37, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.DarkCyan;
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(67, 53);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.DarkCyan;
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(72, 90);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblDono
            // 
            this.lblDono.AutoSize = true;
            this.lblDono.BackColor = System.Drawing.Color.DarkCyan;
            this.lblDono.ForeColor = System.Drawing.Color.White;
            this.lblDono.Location = new System.Drawing.Point(72, 116);
            this.lblDono.Name = "lblDono";
            this.lblDono.Size = new System.Drawing.Size(36, 13);
            this.lblDono.TabIndex = 3;
            this.lblDono.Text = "Dono:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.DarkCyan;
            this.lblAno.ForeColor = System.Drawing.Color.White;
            this.lblAno.Location = new System.Drawing.Point(72, 146);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano:";
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.BackColor = System.Drawing.Color.DarkCyan;
            this.lblDataCompra.ForeColor = System.Drawing.Color.White;
            this.lblDataCompra.Location = new System.Drawing.Point(72, 189);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(69, 13);
            this.lblDataCompra.TabIndex = 5;
            this.lblDataCompra.Text = "DataCompra:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(126, 20);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(256, 20);
            this.tbPlaca.TabIndex = 6;
            this.tbPlaca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mtbMarca
            // 
            this.mtbMarca.Location = new System.Drawing.Point(126, 87);
            this.mtbMarca.Mask = "????????????????????";
            this.mtbMarca.Name = "mtbMarca";
            this.mtbMarca.Size = new System.Drawing.Size(133, 20);
            this.mtbMarca.TabIndex = 7;
            this.mtbMarca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(126, 50);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(256, 20);
            this.tbModelo.TabIndex = 8;
            // 
            // mtbDono
            // 
            this.mtbDono.Location = new System.Drawing.Point(126, 113);
            this.mtbDono.Mask = "????????????????????????????????????????";
            this.mtbDono.Name = "mtbDono";
            this.mtbDono.Size = new System.Drawing.Size(256, 20);
            this.mtbDono.TabIndex = 9;
            this.mtbDono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // mtbAno
            // 
            this.mtbAno.Location = new System.Drawing.Point(126, 143);
            this.mtbAno.Mask = "0000";
            this.mtbAno.Name = "mtbAno";
            this.mtbAno.Size = new System.Drawing.Size(38, 20);
            this.mtbAno.TabIndex = 10;
            // 
            // dtpCompra
            // 
            this.dtpCompra.Location = new System.Drawing.Point(153, 183);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.Size = new System.Drawing.Size(221, 20);
            this.dtpCompra.TabIndex = 11;
            // 
            // btRegistrar
            // 
            this.btRegistrar.BackColor = System.Drawing.Color.Blue;
            this.btRegistrar.Location = new System.Drawing.Point(78, 258);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 12;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = false;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btProcurar
            // 
            this.btProcurar.BackColor = System.Drawing.Color.Blue;
            this.btProcurar.Location = new System.Drawing.Point(259, 258);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(75, 23);
            this.btProcurar.TabIndex = 13;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = false;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.Blue;
            this.btListar.Location = new System.Drawing.Point(563, 134);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(75, 23);
            this.btListar.TabIndex = 14;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // txtListar
            // 
            this.txtListar.Location = new System.Drawing.Point(439, 163);
            this.txtListar.Multiline = true;
            this.txtListar.Name = "txtListar";
            this.txtListar.ReadOnly = true;
            this.txtListar.Size = new System.Drawing.Size(311, 243);
            this.txtListar.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtListar);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.dtpCompra);
            this.Controls.Add(this.mtbAno);
            this.Controls.Add(this.mtbDono);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.mtbMarca);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDono);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.Name = "Form1";
            this.Text = "Cadastro de Carro";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDono;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.MaskedTextBox mtbMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.MaskedTextBox mtbDono;
        private System.Windows.Forms.MaskedTextBox mtbAno;
        private System.Windows.Forms.DateTimePicker dtpCompra;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.TextBox txtListar;
    }
}

