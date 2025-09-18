
namespace Capa_Vista_Componente_Consultas
{
    partial class Frm_editar
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
            this.Mstp_Consultas = new System.Windows.Forms.MenuStrip();
            this.creaciònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Gpb_Form = new System.Windows.Forms.GroupBox();
            this.Lbl_Campo_Seleccionado = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Agregar2 = new System.Windows.Forms.Button();
            this.Txt_Campo_selec = new System.Windows.Forms.TextBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Txt_representativo = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Repre = new System.Windows.Forms.Label();
            this.Chk_Campos = new System.Windows.Forms.CheckBox();
            this.Cbo_campo = new System.Windows.Forms.ComboBox();
            this.Cbo_Query = new System.Windows.Forms.ComboBox();
            this.Lbl_Campos = new System.Windows.Forms.Label();
            this.Lbl_Tabla = new System.Windows.Forms.Label();
            this.Txt_ValorCond = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_consulta = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Consulta = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Mstp_Consultas.SuspendLayout();
            this.Gpb_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mstp_Consultas
            // 
            this.Mstp_Consultas.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Mstp_Consultas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mstp_Consultas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaciònToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.Mstp_Consultas.Location = new System.Drawing.Point(0, 0);
            this.Mstp_Consultas.Name = "Mstp_Consultas";
            this.Mstp_Consultas.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.Mstp_Consultas.Size = new System.Drawing.Size(1340, 35);
            this.Mstp_Consultas.TabIndex = 10;
            this.Mstp_Consultas.Text = "menuStrip1";
            // 
            // creaciònToolStripMenuItem
            // 
            this.creaciònToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creaciònToolStripMenuItem.Name = "creaciònToolStripMenuItem";
            this.creaciònToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.creaciònToolStripMenuItem.Text = "Creación";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(185, 29);
            this.editarToolStripMenuItem.Text = "Editar/Eliminar";
            // 
            // Gpb_Form
            // 
            this.Gpb_Form.Controls.Add(this.Lbl_Campo_Seleccionado);
            this.Gpb_Form.Controls.Add(this.Btn_Cancelar);
            this.Gpb_Form.Controls.Add(this.Btn_Agregar2);
            this.Gpb_Form.Controls.Add(this.Txt_Campo_selec);
            this.Gpb_Form.Controls.Add(this.Btn_Agregar);
            this.Gpb_Form.Controls.Add(this.Txt_representativo);
            this.Gpb_Form.Controls.Add(this.Lbl_Nombre_Repre);
            this.Gpb_Form.Controls.Add(this.Chk_Campos);
            this.Gpb_Form.Controls.Add(this.Cbo_campo);
            this.Gpb_Form.Controls.Add(this.Cbo_Query);
            this.Gpb_Form.Controls.Add(this.Lbl_Campos);
            this.Gpb_Form.Controls.Add(this.Lbl_Tabla);
            this.Gpb_Form.Controls.Add(this.Txt_ValorCond);
            this.Gpb_Form.Controls.Add(this.Lbl_Nombre);
            this.Gpb_Form.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Gpb_Form.Location = new System.Drawing.Point(18, 131);
            this.Gpb_Form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gpb_Form.Name = "Gpb_Form";
            this.Gpb_Form.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gpb_Form.Size = new System.Drawing.Size(1304, 377);
            this.Gpb_Form.TabIndex = 11;
            this.Gpb_Form.TabStop = false;
            this.Gpb_Form.Text = "General/Simple";
            this.Gpb_Form.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Lbl_Campo_Seleccionado
            // 
            this.Lbl_Campo_Seleccionado.AutoSize = true;
            this.Lbl_Campo_Seleccionado.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Campo_Seleccionado.Location = new System.Drawing.Point(736, 63);
            this.Lbl_Campo_Seleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Campo_Seleccionado.Name = "Lbl_Campo_Seleccionado";
            this.Lbl_Campo_Seleccionado.Size = new System.Drawing.Size(239, 25);
            this.Lbl_Campo_Seleccionado.TabIndex = 19;
            this.Lbl_Campo_Seleccionado.Text = "Campos Selecionados";
            this.Lbl_Campo_Seleccionado.Click += new System.EventHandler(this.label5_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.icons8_cancel_50;
            this.Btn_Cancelar.Location = new System.Drawing.Point(1152, 209);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(112, 115);
            this.Btn_Cancelar.TabIndex = 18;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Cancelar.UseCompatibleTextRendering = true;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar2
            // 
            this.Btn_Agregar2.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar2.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.icons8_add_50;
            this.Btn_Agregar2.Location = new System.Drawing.Point(1152, 63);
            this.Btn_Agregar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Agregar2.Name = "Btn_Agregar2";
            this.Btn_Agregar2.Size = new System.Drawing.Size(112, 115);
            this.Btn_Agregar2.TabIndex = 17;
            this.Btn_Agregar2.Text = "Agregar";
            this.Btn_Agregar2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Agregar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Agregar2.UseCompatibleTextRendering = true;
            this.Btn_Agregar2.UseVisualStyleBackColor = true;
            // 
            // Txt_Campo_selec
            // 
            this.Txt_Campo_selec.Location = new System.Drawing.Point(741, 108);
            this.Txt_Campo_selec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Campo_selec.Multiline = true;
            this.Txt_Campo_selec.Name = "Txt_Campo_selec";
            this.Txt_Campo_selec.Size = new System.Drawing.Size(366, 155);
            this.Txt_Campo_selec.TabIndex = 16;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.icons8_add_50;
            this.Btn_Agregar.Location = new System.Drawing.Point(576, 98);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(112, 115);
            this.Btn_Agregar.TabIndex = 15;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Agregar.UseCompatibleTextRendering = true;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.btnQuitarCampo_Click);
            // 
            // Txt_representativo
            // 
            this.Txt_representativo.Location = new System.Drawing.Point(303, 294);
            this.Txt_representativo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_representativo.Name = "Txt_representativo";
            this.Txt_representativo.Size = new System.Drawing.Size(274, 33);
            this.Txt_representativo.TabIndex = 14;
            // 
            // Lbl_Nombre_Repre
            // 
            this.Lbl_Nombre_Repre.AutoSize = true;
            this.Lbl_Nombre_Repre.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_Repre.Location = new System.Drawing.Point(28, 298);
            this.Lbl_Nombre_Repre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre_Repre.Name = "Lbl_Nombre_Repre";
            this.Lbl_Nombre_Repre.Size = new System.Drawing.Size(257, 25);
            this.Lbl_Nombre_Repre.TabIndex = 13;
            this.Lbl_Nombre_Repre.Text = "Nombre Representativo";
            // 
            // Chk_Campos
            // 
            this.Chk_Campos.AutoSize = true;
            this.Chk_Campos.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Campos.Location = new System.Drawing.Point(237, 232);
            this.Chk_Campos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Chk_Campos.Name = "Chk_Campos";
            this.Chk_Campos.Size = new System.Drawing.Size(227, 29);
            this.Chk_Campos.TabIndex = 12;
            this.Chk_Campos.Text = "Todos los Campos";
            this.Chk_Campos.UseVisualStyleBackColor = true;
            // 
            // Cbo_campo
            // 
            this.Cbo_campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_campo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_campo.FormattingEnabled = true;
            this.Cbo_campo.Location = new System.Drawing.Point(237, 175);
            this.Cbo_campo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_campo.Name = "Cbo_campo";
            this.Cbo_campo.Size = new System.Drawing.Size(235, 30);
            this.Cbo_campo.TabIndex = 11;
            // 
            // Cbo_Query
            // 
            this.Cbo_Query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Query.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Query.FormattingEnabled = true;
            this.Cbo_Query.Location = new System.Drawing.Point(237, 122);
            this.Cbo_Query.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_Query.Name = "Cbo_Query";
            this.Cbo_Query.Size = new System.Drawing.Size(235, 30);
            this.Cbo_Query.TabIndex = 10;
            // 
            // Lbl_Campos
            // 
            this.Lbl_Campos.AutoSize = true;
            this.Lbl_Campos.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Campos.Location = new System.Drawing.Point(28, 175);
            this.Lbl_Campos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Campos.Name = "Lbl_Campos";
            this.Lbl_Campos.Size = new System.Drawing.Size(97, 25);
            this.Lbl_Campos.TabIndex = 9;
            this.Lbl_Campos.Text = "Campos";
            // 
            // Lbl_Tabla
            // 
            this.Lbl_Tabla.AutoSize = true;
            this.Lbl_Tabla.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tabla.Location = new System.Drawing.Point(28, 126);
            this.Lbl_Tabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Tabla.Name = "Lbl_Tabla";
            this.Lbl_Tabla.Size = new System.Drawing.Size(69, 25);
            this.Lbl_Tabla.TabIndex = 8;
            this.Lbl_Tabla.Text = "Tabla";
            // 
            // Txt_ValorCond
            // 
            this.Txt_ValorCond.Location = new System.Drawing.Point(237, 65);
            this.Txt_ValorCond.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_ValorCond.Name = "Txt_ValorCond";
            this.Txt_ValorCond.Size = new System.Drawing.Size(274, 33);
            this.Txt_ValorCond.TabIndex = 7;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(28, 69);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(192, 25);
            this.Lbl_Nombre.TabIndex = 0;
            this.Lbl_Nombre.Text = "Nombre Consulta";
            this.Lbl_Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_consulta
            // 
            this.Txt_consulta.Location = new System.Drawing.Point(522, 68);
            this.Txt_consulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_consulta.Name = "Txt_consulta";
            this.Txt_consulta.Size = new System.Drawing.Size(402, 26);
            this.Txt_consulta.TabIndex = 12;
            // 
            // Lbl_Nombre_Consulta
            // 
            this.Lbl_Nombre_Consulta.AutoSize = true;
            this.Lbl_Nombre_Consulta.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Lbl_Nombre_Consulta.Location = new System.Drawing.Point(286, 72);
            this.Lbl_Nombre_Consulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre_Consulta.Name = "Lbl_Nombre_Consulta";
            this.Lbl_Nombre_Consulta.Size = new System.Drawing.Size(198, 25);
            this.Lbl_Nombre_Consulta.TabIndex = 13;
            this.Lbl_Nombre_Consulta.Text = "Nombre Consulta:";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_Buscar.Location = new System.Drawing.Point(984, 43);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(105, 92);
            this.Btn_Buscar.TabIndex = 14;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_Buscar.UseCompatibleTextRendering = true;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Frm_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 829);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Nombre_Consulta);
            this.Controls.Add(this.Txt_consulta);
            this.Controls.Add(this.Gpb_Form);
            this.Controls.Add(this.Mstp_Consultas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_editar";
            this.Text = "Frm_editar";
            this.Load += new System.EventHandler(this.Frm_editar_Load);
            this.Mstp_Consultas.ResumeLayout(false);
            this.Mstp_Consultas.PerformLayout();
            this.Gpb_Form.ResumeLayout(false);
            this.Gpb_Form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mstp_Consultas;
        private System.Windows.Forms.ToolStripMenuItem creaciònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.GroupBox Gpb_Form;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Campos;
        private System.Windows.Forms.Label Lbl_Tabla;
        private System.Windows.Forms.TextBox Txt_ValorCond;
        private System.Windows.Forms.TextBox Txt_representativo;
        private System.Windows.Forms.Label Lbl_Nombre_Repre;
        private System.Windows.Forms.CheckBox Chk_Campos;
        private System.Windows.Forms.ComboBox Cbo_campo;
        private System.Windows.Forms.ComboBox Cbo_Query;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Agregar2;
        private System.Windows.Forms.TextBox Txt_Campo_selec;
        private System.Windows.Forms.Label Lbl_Campo_Seleccionado;
        private System.Windows.Forms.TextBox Txt_consulta;
        private System.Windows.Forms.Label Lbl_Nombre_Consulta;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}