namespace MiPrimeraAplicacion
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Yellow;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1.Location = new System.Drawing.Point(561, 163);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(101, 36);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "botoncito";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl1.Location = new System.Drawing.Point(315, 163);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(122, 23);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Botoncito: ";
            this.lbl1.MouseLeave += new System.EventHandler(this.lbl1_MouseLeave);
            this.lbl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl1_MouseMove);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl1;
    }
}

