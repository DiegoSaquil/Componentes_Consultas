
namespace Capa_Vista_Componente_Consultas
{
    partial class Frm_Principal
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
            this.Btn_ConsultaSimple = new System.Windows.Forms.Button();
            this.Btn_ConsultaCompleja = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Lbl_Bienvenida = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_Instrucciones = new System.Windows.Forms.Label();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ConsultaSimple
            // 
            this.Btn_ConsultaSimple.Location = new System.Drawing.Point(330, 101);
            this.Btn_ConsultaSimple.Name = "Btn_ConsultaSimple";
            this.Btn_ConsultaSimple.Size = new System.Drawing.Size(116, 54);
            this.Btn_ConsultaSimple.TabIndex = 0;
            this.Btn_ConsultaSimple.Text = "Consultas Simples";
            this.Btn_ConsultaSimple.UseVisualStyleBackColor = true;
            this.Btn_ConsultaSimple.Click += new System.EventHandler(this.Btn_ConsultaSimple_Click);
            // 
            // Btn_ConsultaCompleja
            // 
            this.Btn_ConsultaCompleja.Location = new System.Drawing.Point(330, 184);
            this.Btn_ConsultaCompleja.Name = "Btn_ConsultaCompleja";
            this.Btn_ConsultaCompleja.Size = new System.Drawing.Size(116, 56);
            this.Btn_ConsultaCompleja.TabIndex = 1;
            this.Btn_ConsultaCompleja.Text = "Consulta Compleja";
            this.Btn_ConsultaCompleja.UseVisualStyleBackColor = true;
            this.Btn_ConsultaCompleja.Click += new System.EventHandler(this.Btn_ConsultaCompleja_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Location = new System.Drawing.Point(330, 272);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(116, 51);
            this.Btn_Ayuda.TabIndex = 2;
            this.Btn_Ayuda.Text = "Ayuda";
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Lbl_Bienvenida
            // 
            this.Lbl_Bienvenida.AutoSize = true;
            this.Lbl_Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bienvenida.Location = new System.Drawing.Point(316, 23);
            this.Lbl_Bienvenida.Name = "Lbl_Bienvenida";
            this.Lbl_Bienvenida.Size = new System.Drawing.Size(156, 25);
            this.Lbl_Bienvenida.TabIndex = 3;
            this.Lbl_Bienvenida.Text = "BIENVENIDO!";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(723, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cerrar.TabIndex = 4;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Lbl_Instrucciones
            // 
            this.Lbl_Instrucciones.AutoSize = true;
            this.Lbl_Instrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Instrucciones.Location = new System.Drawing.Point(247, 65);
            this.Lbl_Instrucciones.Name = "Lbl_Instrucciones";
            this.Lbl_Instrucciones.Size = new System.Drawing.Size(304, 20);
            this.Lbl_Instrucciones.TabIndex = 5;
            this.Lbl_Instrucciones.Text = "Por favor, selecciona una de las opciones.";
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.logoquantum;
            this.Pic_Logo.Location = new System.Drawing.Point(-2, 0);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(108, 113);
            this.Pic_Logo.TabIndex = 6;
            this.Pic_Logo.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pic_Logo);
            this.Controls.Add(this.Lbl_Instrucciones);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Lbl_Bienvenida);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_ConsultaCompleja);
            this.Controls.Add(this.Btn_ConsultaSimple);
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ConsultaSimple;
        private System.Windows.Forms.Button Btn_ConsultaCompleja;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Label Lbl_Bienvenida;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_Instrucciones;
        private System.Windows.Forms.PictureBox Pic_Logo;
    }
}