using System.Windows.Forms;

namespace Volleyball
{
    partial class PantallaDeInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDeInicio));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btIniciarJuego = new System.Windows.Forms.Button();
            this.btRegistrarEquipos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(829, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btIniciarJuego
            // 
            this.btIniciarJuego.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btIniciarJuego.Location = new System.Drawing.Point(191, 347);
            this.btIniciarJuego.Name = "btIniciarJuego";
            this.btIniciarJuego.Size = new System.Drawing.Size(179, 53);
            this.btIniciarJuego.TabIndex = 2;
            this.btIniciarJuego.Text = "Iniciar Juego";
            this.btIniciarJuego.UseVisualStyleBackColor = true;
            this.btIniciarJuego.Click += new System.EventHandler(this.btIniciarJuego_Click);
            // 
            // btRegistrarEquipos
            // 
            this.btRegistrarEquipos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRegistrarEquipos.Location = new System.Drawing.Point(479, 347);
            this.btRegistrarEquipos.Name = "btRegistrarEquipos";
            this.btRegistrarEquipos.Size = new System.Drawing.Size(179, 53);
            this.btRegistrarEquipos.TabIndex = 3;
            this.btRegistrarEquipos.Text = "Registrar Equipos";
            this.btRegistrarEquipos.UseVisualStyleBackColor = true;
            this.btRegistrarEquipos.Click += new System.EventHandler(this.btRegistrarEquipos_Click);
            // 
            // PantallaDeInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.btRegistrarEquipos);
            this.Controls.Add(this.btIniciarJuego);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaDeInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.PantallaDeInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private Button btIniciarJuego;
        private Button btRegistrarEquipos;
    }
}