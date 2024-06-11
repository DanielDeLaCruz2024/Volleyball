namespace WindowsFormsApp1
{
    partial class FormPuntaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPuntaje));
            this.btMenosPuntoA = new System.Windows.Forms.Button();
            this.btMasPuntoA = new System.Windows.Forms.Button();
            this.lbPunto1A = new System.Windows.Forms.Label();
            this.lbPunto1B = new System.Windows.Forms.Label();
            this.btMasPuntoB = new System.Windows.Forms.Button();
            this.btMenosPuntoB = new System.Windows.Forms.Button();
            this.lbPuntajeA = new System.Windows.Forms.Label();
            this.lbPuntajeB = new System.Windows.Forms.Label();
            this.lbPuntosGanar = new System.Windows.Forms.Label();
            this.lbPuntosGanar2 = new System.Windows.Forms.Label();
            this.lbSetsGanar = new System.Windows.Forms.Label();
            this.lbSetsGanar2 = new System.Windows.Forms.Label();
            this.lbSetsA = new System.Windows.Forms.Label();
            this.lbSetsA2 = new System.Windows.Forms.Label();
            this.lbSetsB = new System.Windows.Forms.Label();
            this.lbSetsB2 = new System.Windows.Forms.Label();
            this.lbEquipoA = new System.Windows.Forms.Label();
            this.lbEquipoB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btMenosPuntoA
            // 
            this.btMenosPuntoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenosPuntoA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMenosPuntoA.Location = new System.Drawing.Point(82, 431);
            this.btMenosPuntoA.Margin = new System.Windows.Forms.Padding(4);
            this.btMenosPuntoA.Name = "btMenosPuntoA";
            this.btMenosPuntoA.Size = new System.Drawing.Size(54, 52);
            this.btMenosPuntoA.TabIndex = 0;
            this.btMenosPuntoA.Text = "-";
            this.btMenosPuntoA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMenosPuntoA.UseVisualStyleBackColor = true;
            this.btMenosPuntoA.Click += new System.EventHandler(this.MenosPuntoA_Click);
            // 
            // btMasPuntoA
            // 
            this.btMasPuntoA.Location = new System.Drawing.Point(254, 431);
            this.btMasPuntoA.Margin = new System.Windows.Forms.Padding(4);
            this.btMasPuntoA.Name = "btMasPuntoA";
            this.btMasPuntoA.Size = new System.Drawing.Size(52, 52);
            this.btMasPuntoA.TabIndex = 1;
            this.btMasPuntoA.Text = "+";
            this.btMasPuntoA.UseVisualStyleBackColor = true;
            this.btMasPuntoA.Click += new System.EventHandler(this.btMasPuntoA_Click);
            // 
            // lbPunto1A
            // 
            this.lbPunto1A.AutoSize = true;
            this.lbPunto1A.Location = new System.Drawing.Point(154, 446);
            this.lbPunto1A.Name = "lbPunto1A";
            this.lbPunto1A.Size = new System.Drawing.Size(77, 23);
            this.lbPunto1A.TabIndex = 2;
            this.lbPunto1A.Text = "1 Punto";
            // 
            // lbPunto1B
            // 
            this.lbPunto1B.AutoSize = true;
            this.lbPunto1B.Location = new System.Drawing.Point(802, 446);
            this.lbPunto1B.Name = "lbPunto1B";
            this.lbPunto1B.Size = new System.Drawing.Size(77, 23);
            this.lbPunto1B.TabIndex = 5;
            this.lbPunto1B.Text = "1 Punto";
            // 
            // btMasPuntoB
            // 
            this.btMasPuntoB.Location = new System.Drawing.Point(902, 431);
            this.btMasPuntoB.Margin = new System.Windows.Forms.Padding(4);
            this.btMasPuntoB.Name = "btMasPuntoB";
            this.btMasPuntoB.Size = new System.Drawing.Size(52, 52);
            this.btMasPuntoB.TabIndex = 4;
            this.btMasPuntoB.Text = "+";
            this.btMasPuntoB.UseVisualStyleBackColor = true;
            this.btMasPuntoB.Click += new System.EventHandler(this.btMasPuntoB_Click);
            // 
            // btMenosPuntoB
            // 
            this.btMenosPuntoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenosPuntoB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMenosPuntoB.Location = new System.Drawing.Point(730, 431);
            this.btMenosPuntoB.Margin = new System.Windows.Forms.Padding(4);
            this.btMenosPuntoB.Name = "btMenosPuntoB";
            this.btMenosPuntoB.Size = new System.Drawing.Size(54, 52);
            this.btMenosPuntoB.TabIndex = 3;
            this.btMenosPuntoB.Text = "-";
            this.btMenosPuntoB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMenosPuntoB.UseVisualStyleBackColor = true;
            this.btMenosPuntoB.Click += new System.EventHandler(this.menosPuntoB_Click);
            // 
            // lbPuntajeA
            // 
            this.lbPuntajeA.AutoSize = true;
            this.lbPuntajeA.Font = new System.Drawing.Font("Arial", 36F);
            this.lbPuntajeA.Location = new System.Drawing.Point(124, 200);
            this.lbPuntajeA.Name = "lbPuntajeA";
            this.lbPuntajeA.Size = new System.Drawing.Size(62, 67);
            this.lbPuntajeA.TabIndex = 6;
            this.lbPuntajeA.Text = "0";
            // 
            // lbPuntajeB
            // 
            this.lbPuntajeB.AutoSize = true;
            this.lbPuntajeB.Font = new System.Drawing.Font("Arial", 36F);
            this.lbPuntajeB.Location = new System.Drawing.Point(739, 200);
            this.lbPuntajeB.Name = "lbPuntajeB";
            this.lbPuntajeB.Size = new System.Drawing.Size(62, 67);
            this.lbPuntajeB.TabIndex = 7;
            this.lbPuntajeB.Text = "0";
            // 
            // lbPuntosGanar
            // 
            this.lbPuntosGanar.AutoSize = true;
            this.lbPuntosGanar.Location = new System.Drawing.Point(452, 217);
            this.lbPuntosGanar.Name = "lbPuntosGanar";
            this.lbPuntosGanar.Size = new System.Drawing.Size(185, 23);
            this.lbPuntosGanar.TabIndex = 8;
            this.lbPuntosGanar.Text = "Puntos Para Ganar:";
            // 
            // lbPuntosGanar2
            // 
            this.lbPuntosGanar2.AutoSize = true;
            this.lbPuntosGanar2.Location = new System.Drawing.Point(506, 237);
            this.lbPuntosGanar2.Name = "lbPuntosGanar2";
            this.lbPuntosGanar2.Size = new System.Drawing.Size(32, 23);
            this.lbPuntosGanar2.TabIndex = 9;
            this.lbPuntosGanar2.Text = "25";
            // 
            // lbSetsGanar
            // 
            this.lbSetsGanar.AutoSize = true;
            this.lbSetsGanar.Location = new System.Drawing.Point(452, 319);
            this.lbSetsGanar.Name = "lbSetsGanar";
            this.lbSetsGanar.Size = new System.Drawing.Size(165, 23);
            this.lbSetsGanar.TabIndex = 10;
            this.lbSetsGanar.Text = "Sets Para Ganar:";
            // 
            // lbSetsGanar2
            // 
            this.lbSetsGanar2.AutoSize = true;
            this.lbSetsGanar2.Location = new System.Drawing.Point(506, 347);
            this.lbSetsGanar2.Name = "lbSetsGanar2";
            this.lbSetsGanar2.Size = new System.Drawing.Size(21, 23);
            this.lbSetsGanar2.TabIndex = 11;
            this.lbSetsGanar2.Text = "2";
            // 
            // lbSetsA
            // 
            this.lbSetsA.AutoSize = true;
            this.lbSetsA.Location = new System.Drawing.Point(119, 363);
            this.lbSetsA.Name = "lbSetsA";
            this.lbSetsA.Size = new System.Drawing.Size(142, 23);
            this.lbSetsA.TabIndex = 12;
            this.lbSetsA.Text = "Sets Ganados:";
            // 
            // lbSetsA2
            // 
            this.lbSetsA2.AutoSize = true;
            this.lbSetsA2.Location = new System.Drawing.Point(228, 363);
            this.lbSetsA2.Name = "lbSetsA2";
            this.lbSetsA2.Size = new System.Drawing.Size(21, 23);
            this.lbSetsA2.TabIndex = 13;
            this.lbSetsA2.Text = "0";
            // 
            // lbSetsB
            // 
            this.lbSetsB.AutoSize = true;
            this.lbSetsB.Location = new System.Drawing.Point(751, 363);
            this.lbSetsB.Name = "lbSetsB";
            this.lbSetsB.Size = new System.Drawing.Size(142, 23);
            this.lbSetsB.TabIndex = 14;
            this.lbSetsB.Text = "Sets Ganados:";
            // 
            // lbSetsB2
            // 
            this.lbSetsB2.AutoSize = true;
            this.lbSetsB2.Location = new System.Drawing.Point(858, 363);
            this.lbSetsB2.Name = "lbSetsB2";
            this.lbSetsB2.Size = new System.Drawing.Size(21, 23);
            this.lbSetsB2.TabIndex = 15;
            this.lbSetsB2.Text = "0";
            // 
            // lbEquipoA
            // 
            this.lbEquipoA.AutoSize = true;
            this.lbEquipoA.Font = new System.Drawing.Font("Arial", 24F);
            this.lbEquipoA.Location = new System.Drawing.Point(119, 70);
            this.lbEquipoA.Name = "lbEquipoA";
            this.lbEquipoA.Size = new System.Drawing.Size(169, 45);
            this.lbEquipoA.TabIndex = 16;
            this.lbEquipoA.Text = "EquipoA";
            // 
            // lbEquipoB
            // 
            this.lbEquipoB.AutoSize = true;
            this.lbEquipoB.Font = new System.Drawing.Font("Arial", 24F);
            this.lbEquipoB.Location = new System.Drawing.Point(719, 70);
            this.lbEquipoB.Name = "lbEquipoB";
            this.lbEquipoB.Size = new System.Drawing.Size(169, 45);
            this.lbEquipoB.TabIndex = 17;
            this.lbEquipoB.Text = "EquipoB";
            // 
            // FormPuntaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 647);
            this.Controls.Add(this.lbEquipoB);
            this.Controls.Add(this.lbEquipoA);
            this.Controls.Add(this.lbSetsB2);
            this.Controls.Add(this.lbSetsB);
            this.Controls.Add(this.lbSetsA2);
            this.Controls.Add(this.lbSetsA);
            this.Controls.Add(this.lbSetsGanar2);
            this.Controls.Add(this.lbSetsGanar);
            this.Controls.Add(this.lbPuntosGanar2);
            this.Controls.Add(this.lbPuntosGanar);
            this.Controls.Add(this.lbPuntajeB);
            this.Controls.Add(this.lbPuntajeA);
            this.Controls.Add(this.lbPunto1B);
            this.Controls.Add(this.btMasPuntoB);
            this.Controls.Add(this.btMenosPuntoB);
            this.Controls.Add(this.lbPunto1A);
            this.Controls.Add(this.btMasPuntoA);
            this.Controls.Add(this.btMenosPuntoA);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPuntaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPuntaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMenosPuntoA;
        private System.Windows.Forms.Button btMasPuntoA;
        private System.Windows.Forms.Label lbPunto1A;
        private System.Windows.Forms.Label lbPunto1B;
        private System.Windows.Forms.Button btMasPuntoB;
        private System.Windows.Forms.Button btMenosPuntoB;
        private System.Windows.Forms.Label lbPuntajeA;
        private System.Windows.Forms.Label lbPuntajeB;
        private System.Windows.Forms.Label lbPuntosGanar;
        private System.Windows.Forms.Label lbPuntosGanar2;
        private System.Windows.Forms.Label lbSetsGanar;
        private System.Windows.Forms.Label lbSetsGanar2;
        private System.Windows.Forms.Label lbSetsA;
        private System.Windows.Forms.Label lbSetsA2;
        private System.Windows.Forms.Label lbSetsB;
        private System.Windows.Forms.Label lbSetsB2;
        private System.Windows.Forms.Label lbEquipoA;
        private System.Windows.Forms.Label lbEquipoB;
    }
}

