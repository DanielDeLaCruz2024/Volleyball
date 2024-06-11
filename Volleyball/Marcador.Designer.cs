namespace WindowsFormsApp1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        // Control declarations
        private System.Windows.Forms.Label lbGanador2;
        private System.Windows.Forms.Label lbPuntajeA;
        private System.Windows.Forms.Label lbPuntajeB;
        private System.Windows.Forms.Label lbSetsA;
        private System.Windows.Forms.Label lbSetsB;
        private System.Windows.Forms.Button btSigJuego;

        // Dispose method to clean up the component list
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Method for Windows Form Designer support
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbGanador2 = new System.Windows.Forms.Label();
            this.lbPuntajeA = new System.Windows.Forms.Label();
            this.lbPuntajeB = new System.Windows.Forms.Label();
            this.lbSetsA = new System.Windows.Forms.Label();
            this.lbSetsB = new System.Windows.Forms.Label();
            this.btSigJuego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGanador2
            // 
            this.lbGanador2.AutoSize = true;
            this.lbGanador2.Location = new System.Drawing.Point(150, 50);
            this.lbGanador2.Name = "lbGanador2";
            this.lbGanador2.Size = new System.Drawing.Size(60, 16);
            this.lbGanador2.TabIndex = 0;
            this.lbGanador2.Text = "Ganador";
            // 
            // lbPuntajeA
            // 
            this.lbPuntajeA.AutoSize = true;
            this.lbPuntajeA.Location = new System.Drawing.Point(100, 100);
            this.lbPuntajeA.Name = "lbPuntajeA";
            this.lbPuntajeA.Size = new System.Drawing.Size(64, 16);
            this.lbPuntajeA.TabIndex = 1;
            this.lbPuntajeA.Text = "Puntaje A";
            // 
            // lbPuntajeB
            // 
            this.lbPuntajeB.AutoSize = true;
            this.lbPuntajeB.Location = new System.Drawing.Point(300, 100);
            this.lbPuntajeB.Name = "lbPuntajeB";
            this.lbPuntajeB.Size = new System.Drawing.Size(64, 16);
            this.lbPuntajeB.TabIndex = 2;
            this.lbPuntajeB.Text = "Puntaje B";
            // 
            // lbSetsA
            // 
            this.lbSetsA.AutoSize = true;
            this.lbSetsA.Location = new System.Drawing.Point(100, 150);
            this.lbSetsA.Name = "lbSetsA";
            this.lbSetsA.Size = new System.Drawing.Size(46, 16);
            this.lbSetsA.TabIndex = 3;
            this.lbSetsA.Text = "Sets A";
            // 
            // lbSetsB
            // 
            this.lbSetsB.AutoSize = true;
            this.lbSetsB.Location = new System.Drawing.Point(300, 150);
            this.lbSetsB.Name = "lbSetsB";
            this.lbSetsB.Size = new System.Drawing.Size(46, 16);
            this.lbSetsB.TabIndex = 4;
            this.lbSetsB.Text = "Sets B";
            // 
            // btSigJuego
            // 
            this.btSigJuego.Location = new System.Drawing.Point(175, 200);
            this.btSigJuego.Name = "btSigJuego";
            this.btSigJuego.Size = new System.Drawing.Size(150, 30);
            this.btSigJuego.TabIndex = 5;
            this.btSigJuego.Text = "Siguiente Juego";
            this.btSigJuego.UseVisualStyleBackColor = true;
            this.btSigJuego.Click += new System.EventHandler(this.btSigJuego_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.btSigJuego);
            this.Controls.Add(this.lbSetsB);
            this.Controls.Add(this.lbSetsA);
            this.Controls.Add(this.lbPuntajeB);
            this.Controls.Add(this.lbPuntajeA);
            this.Controls.Add(this.lbGanador2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcador";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
