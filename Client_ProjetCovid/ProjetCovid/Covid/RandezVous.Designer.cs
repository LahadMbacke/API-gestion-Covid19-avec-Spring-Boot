namespace ProjetCovid.Covid
{
    partial class RandezVous
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Combox_structure_Nom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateRv = new System.Windows.Forms.DateTimePicker();
            this.TypeRV = new System.Windows.Forms.ComboBox();
            this.button_ValiderRv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Combox_structure_Nom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DateRv);
            this.panel2.Controls.Add(this.TypeRV);
            this.panel2.Controls.Add(this.button_ValiderRv);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(34, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 337);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Structure:";
            // 
            // Combox_structure_Nom
            // 
            this.Combox_structure_Nom.FormattingEnabled = true;
            this.Combox_structure_Nom.Location = new System.Drawing.Point(144, 207);
            this.Combox_structure_Nom.Margin = new System.Windows.Forms.Padding(2);
            this.Combox_structure_Nom.MaxLength = 100;
            this.Combox_structure_Nom.Name = "Combox_structure_Nom";
            this.Combox_structure_Nom.Size = new System.Drawing.Size(131, 21);
            this.Combox_structure_Nom.TabIndex = 17;
            this.Combox_structure_Nom.SelectedIndexChanged += new System.EventHandler(this.Combox_structure_Nom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Type de  Rendez-vous:";
            // 
            // DateRv
            // 
            this.DateRv.Location = new System.Drawing.Point(139, 63);
            this.DateRv.Margin = new System.Windows.Forms.Padding(2);
            this.DateRv.Name = "DateRv";
            this.DateRv.Size = new System.Drawing.Size(135, 20);
            this.DateRv.TabIndex = 15;
            // 
            // TypeRV
            // 
            this.TypeRV.FormattingEnabled = true;
            this.TypeRV.Items.AddRange(new object[] {
            "Vaccin",
            "Test covid",
            "hospitalisation"});
            this.TypeRV.Location = new System.Drawing.Point(145, 131);
            this.TypeRV.Margin = new System.Windows.Forms.Padding(2);
            this.TypeRV.MaxLength = 20;
            this.TypeRV.Name = "TypeRV";
            this.TypeRV.Size = new System.Drawing.Size(130, 21);
            this.TypeRV.TabIndex = 13;
            // 
            // button_ValiderRv
            // 
            this.button_ValiderRv.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_ValiderRv.FlatAppearance.BorderSize = 0;
            this.button_ValiderRv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ValiderRv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ValiderRv.ForeColor = System.Drawing.Color.White;
            this.button_ValiderRv.Location = new System.Drawing.Point(142, 252);
            this.button_ValiderRv.Margin = new System.Windows.Forms.Padding(2);
            this.button_ValiderRv.Name = "button_ValiderRv";
            this.button_ValiderRv.Size = new System.Drawing.Size(133, 29);
            this.button_ValiderRv.TabIndex = 0;
            this.button_ValiderRv.Text = "Enregistrer";
            this.button_ValiderRv.UseVisualStyleBackColor = false;
            this.button_ValiderRv.Click += new System.EventHandler(this.button_ValiderRv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date Rendez-vous:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 87);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulaire de prise de rendz-vous";
            // 
            // RandezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RandezVous";
            this.Text = "RandezVous";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Combox_structure_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateRv;
        private System.Windows.Forms.ComboBox TypeRV;
        private System.Windows.Forms.Button button_ValiderRv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}