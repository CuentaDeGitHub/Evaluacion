namespace Evaluacion
{
    partial class Form1
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
            this.btnMostrarPersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarEstudiante = new System.Windows.Forms.Button();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListView();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btnVector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarPersona
            // 
            this.btnMostrarPersona.Location = new System.Drawing.Point(251, 12);
            this.btnMostrarPersona.Name = "btnMostrarPersona";
            this.btnMostrarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarPersona.TabIndex = 0;
            this.btnMostrarPersona.Text = "Mostrar";
            this.btnMostrarPersona.UseVisualStyleBackColor = true;
            this.btnMostrarPersona.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrar datos de clase Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mostrar datos de clase Estudiante";
            // 
            // btnMostrarEstudiante
            // 
            this.btnMostrarEstudiante.Location = new System.Drawing.Point(269, 93);
            this.btnMostrarEstudiante.Name = "btnMostrarEstudiante";
            this.btnMostrarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarEstudiante.TabIndex = 3;
            this.btnMostrarEstudiante.Text = "Mostrar";
            this.btnMostrarEstudiante.UseVisualStyleBackColor = true;
            this.btnMostrarEstudiante.Click += new System.EventHandler(this.btnMostrarEstudiante_Click);
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(20, 124);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(35, 13);
            this.lblEstudiante.TabIndex = 5;
            this.lblEstudiante.Text = "label3";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(20, 45);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(35, 13);
            this.lblPersona.TabIndex = 6;
            this.lblPersona.Text = "label4";
            // 
            // listBox1
            // 
            this.listBox1.HideSelection = false;
            this.listBox1.Location = new System.Drawing.Point(16, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 211);
            this.listBox1.TabIndex = 4;
            this.listBox1.UseCompatibleStateImageBehavior = false;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(251, 415);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(342, 415);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnVector
            // 
            this.btnVector.Location = new System.Drawing.Point(23, 387);
            this.btnVector.Name = "btnVector";
            this.btnVector.Size = new System.Drawing.Size(75, 23);
            this.btnVector.TabIndex = 9;
            this.btnVector.Text = "Vector";
            this.btnVector.UseVisualStyleBackColor = true;
            this.btnVector.Click += new System.EventHandler(this.btnVector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.btnVector);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMostrarEstudiante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrarEstudiante;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.ListView listBox1;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btnVector;
    }
}

