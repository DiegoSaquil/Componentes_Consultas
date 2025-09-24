
namespace Capa_Vista_Componente_Consultas
{
    partial class Frm_Consulta_Simple
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
            this.Gpb_Listado = new System.Windows.Forms.GroupBox();
            this.Txt_Consulta = new System.Windows.Forms.TextBox();
            this.lbl_Cadena_Generada = new System.Windows.Forms.Label();
            this.lbl_Query = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Cbo_Query = new System.Windows.Forms.ComboBox();
            this.Dgv_Tabla = new System.Windows.Forms.DataGridView();
            this.Mstp_Consultas = new System.Windows.Forms.MenuStrip();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_min = new System.Windows.Forms.Button();
            this.Btn_max = new System.Windows.Forms.Button();
            this.Gpb_Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Listado
            // 
            this.Gpb_Listado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_Listado.Controls.Add(this.Txt_Consulta);
            this.Gpb_Listado.Controls.Add(this.lbl_Cadena_Generada);
            this.Gpb_Listado.Controls.Add(this.lbl_Query);
            this.Gpb_Listado.Controls.Add(this.Btn_Buscar);
            this.Gpb_Listado.Controls.Add(this.Cbo_Query);
            this.Gpb_Listado.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Listado.Location = new System.Drawing.Point(0, 26);
            this.Gpb_Listado.Name = "Gpb_Listado";
            this.Gpb_Listado.Size = new System.Drawing.Size(752, 115);
            this.Gpb_Listado.TabIndex = 5;
            this.Gpb_Listado.TabStop = false;
            this.Gpb_Listado.Text = "Consulta Simple";
            // 
            // Txt_Consulta
            // 
            this.Txt_Consulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Txt_Consulta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Consulta.Location = new System.Drawing.Point(250, 66);
            this.Txt_Consulta.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Consulta.Name = "Txt_Consulta";
            this.Txt_Consulta.ReadOnly = true;
            this.Txt_Consulta.Size = new System.Drawing.Size(330, 23);
            this.Txt_Consulta.TabIndex = 8;
            // 
            // lbl_Cadena_Generada
            // 
            this.lbl_Cadena_Generada.AutoSize = true;
            this.lbl_Cadena_Generada.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadena_Generada.Location = new System.Drawing.Point(248, 45);
            this.lbl_Cadena_Generada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cadena_Generada.Name = "lbl_Cadena_Generada";
            this.lbl_Cadena_Generada.Size = new System.Drawing.Size(163, 17);
            this.lbl_Cadena_Generada.TabIndex = 7;
            this.lbl_Cadena_Generada.Text = "Nombre de empleado";
            // 
            // lbl_Query
            // 
            this.lbl_Query.AutoSize = true;
            this.lbl_Query.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Query.Location = new System.Drawing.Point(37, 45);
            this.lbl_Query.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Query.Name = "lbl_Query";
            this.lbl_Query.Size = new System.Drawing.Size(145, 17);
            this.lbl_Query.TabIndex = 6;
            this.lbl_Query.Text = "Nombre de la tabla";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_Buscar.Location = new System.Drawing.Point(628, 36);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(70, 60);
            this.Btn_Buscar.TabIndex = 5;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_Buscar.UseCompatibleTextRendering = true;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Cbo_Query
            // 
            this.Cbo_Query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Query.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Query.FormattingEnabled = true;
            this.Cbo_Query.Location = new System.Drawing.Point(40, 65);
            this.Cbo_Query.Name = "Cbo_Query";
            this.Cbo_Query.Size = new System.Drawing.Size(158, 25);
            this.Cbo_Query.TabIndex = 0;
            // 
            // Dgv_Tabla
            // 
            this.Dgv_Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Tabla.Location = new System.Drawing.Point(40, 147);
            this.Dgv_Tabla.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_Tabla.Name = "Dgv_Tabla";
            this.Dgv_Tabla.RowHeadersWidth = 51;
            this.Dgv_Tabla.RowTemplate.Height = 24;
            this.Dgv_Tabla.Size = new System.Drawing.Size(671, 315);
            this.Dgv_Tabla.TabIndex = 6;
            // 
            // Mstp_Consultas
            // 
            this.Mstp_Consultas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mstp_Consultas.Location = new System.Drawing.Point(0, 0);
            this.Mstp_Consultas.Name = "Mstp_Consultas";
            this.Mstp_Consultas.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Mstp_Consultas.Size = new System.Drawing.Size(757, 24);
            this.Mstp_Consultas.TabIndex = 9;
            this.Mstp_Consultas.Text = "menuStrip1";
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Location = new System.Drawing.Point(555, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(50, 23);
            this.Btn_cerrar.TabIndex = 13;
            this.Btn_cerrar.Text = "Cerrar";
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_min
            // 
            this.Btn_min.Location = new System.Drawing.Point(611, 0);
            this.Btn_min.Name = "Btn_min";
            this.Btn_min.Size = new System.Drawing.Size(64, 23);
            this.Btn_min.TabIndex = 14;
            this.Btn_min.Text = "Minimizar";
            this.Btn_min.UseVisualStyleBackColor = true;
            this.Btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // Btn_max
            // 
            this.Btn_max.Location = new System.Drawing.Point(681, 0);
            this.Btn_max.Name = "Btn_max";
            this.Btn_max.Size = new System.Drawing.Size(63, 23);
            this.Btn_max.TabIndex = 15;
            this.Btn_max.Text = "Maximizar";
            this.Btn_max.UseVisualStyleBackColor = true;
            this.Btn_max.Click += new System.EventHandler(this.Btn_max_Click);
            // 
            // Frm_Consulta_Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 472);
            this.Controls.Add(this.Btn_max);
            this.Controls.Add(this.Btn_min);
            this.Controls.Add(this.Btn_cerrar);
            this.Controls.Add(this.Mstp_Consultas);
            this.Controls.Add(this.Dgv_Tabla);
            this.Controls.Add(this.Gpb_Listado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Consulta_Simple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Consultas";
            this.Gpb_Listado.ResumeLayout(false);
            this.Gpb_Listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Listado;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.ComboBox Cbo_Query;
        private System.Windows.Forms.TextBox Txt_Consulta;
        private System.Windows.Forms.Label lbl_Cadena_Generada;
        private System.Windows.Forms.Label lbl_Query;
        private System.Windows.Forms.DataGridView Dgv_Tabla;
        private System.Windows.Forms.MenuStrip Mstp_Consultas;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_min;
        private System.Windows.Forms.Button Btn_max;
    }
}