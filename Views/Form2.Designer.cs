namespace _04Biblioteca.Views
{
    partial class Form2
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
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnModificarLibro = new System.Windows.Forms.Button();
            this.txt_librosid = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.lstlibros = new System.Windows.Forms.ListBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(84, 354);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(126, 71);
            this.btnAgregarLibro.TabIndex = 0;
            this.btnAgregarLibro.Text = "AgregarLibro";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click_1);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(225, 354);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(149, 71);
            this.btnEliminarLibro.TabIndex = 1;
            this.btnEliminarLibro.Text = "EliminarLibro";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarMiembro_Click);
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.Location = new System.Drawing.Point(400, 353);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(161, 72);
            this.btnModificarLibro.TabIndex = 2;
            this.btnModificarLibro.Text = "ModificarLibro";
            this.btnModificarLibro.UseVisualStyleBackColor = true;
            this.btnModificarLibro.Click += new System.EventHandler(this.btnModificarMiembro_Click);
            // 
            // txt_librosid
            // 
            this.txt_librosid.Location = new System.Drawing.Point(168, 81);
            this.txt_librosid.Name = "txt_librosid";
            this.txt_librosid.Size = new System.Drawing.Size(100, 26);
            this.txt_librosid.TabIndex = 3;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(168, 124);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(100, 26);
            this.txt_titulo.TabIndex = 4;
            // 
            // lstlibros
            // 
            this.lstlibros.FormattingEnabled = true;
            this.lstlibros.ItemHeight = 20;
            this.lstlibros.Location = new System.Drawing.Point(410, 97);
            this.lstlibros.Name = "lstlibros";
            this.lstlibros.Size = new System.Drawing.Size(245, 204);
            this.lstlibros.TabIndex = 5;
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(168, 170);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(100, 26);
            this.txt_autor.TabIndex = 6;
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(168, 228);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(100, 26);
            this.txt_genero.TabIndex = 7;
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(168, 289);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(100, 26);
            this.txt_año.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Año Publicacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "DATOS DE LIBRO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "LISTA DE LIBROS ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_año);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.lstlibros);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_librosid);
            this.Controls.Add(this.btnModificarLibro);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.btnAgregarLibro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnModificarLibro;
        private System.Windows.Forms.TextBox txt_librosid;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.ListBox lstlibros;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}