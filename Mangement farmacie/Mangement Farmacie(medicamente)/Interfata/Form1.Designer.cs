
namespace UI_WindowsForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.button_cauta = new System.Windows.Forms.Button();
            this.button_modifica = new System.Windows.Forms.Button();
            this.button_adauga = new System.Windows.Forms.Button();
            this.button_afisare = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label_titlu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_afisare = new System.Windows.Forms.Panel();
            this.panelMeniu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeniu
            // 
            this.panelMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.panelMeniu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMeniu.Controls.Add(this.button_cauta);
            this.panelMeniu.Controls.Add(this.button_modifica);
            this.panelMeniu.Controls.Add(this.button_adauga);
            this.panelMeniu.Controls.Add(this.button_afisare);
            this.panelMeniu.Controls.Add(this.panel_logo);
            this.panelMeniu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeniu.Location = new System.Drawing.Point(0, 0);
            this.panelMeniu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMeniu.Name = "panelMeniu";
            this.panelMeniu.Size = new System.Drawing.Size(262, 647);
            this.panelMeniu.TabIndex = 0;
            this.panelMeniu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMeniu_Paint);
            // 
            // button_cauta
            // 
            this.button_cauta.AutoSize = true;
            this.button_cauta.BackColor = System.Drawing.Color.Teal;
            this.button_cauta.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_cauta.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cauta.Image = ((System.Drawing.Image)(resources.GetObject("button_cauta.Image")));
            this.button_cauta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cauta.Location = new System.Drawing.Point(0, 513);
            this.button_cauta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cauta.Name = "button_cauta";
            this.button_cauta.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_cauta.Size = new System.Drawing.Size(258, 131);
            this.button_cauta.TabIndex = 3;
            this.button_cauta.Text = "     Cauta medicament";
            this.button_cauta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_cauta.UseVisualStyleBackColor = false;
            this.button_cauta.Click += new System.EventHandler(this.button3_Click);
            this.button_cauta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_cauta_MouseClick);
            this.button_cauta.MouseLeave += new System.EventHandler(this.button_cauta_MouseLeave);
            this.button_cauta.MouseHover += new System.EventHandler(this.button_cauta_MouseHover);
            // 
            // button_modifica
            // 
            this.button_modifica.AutoSize = true;
            this.button_modifica.BackColor = System.Drawing.Color.Teal;
            this.button_modifica.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_modifica.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifica.Image = ((System.Drawing.Image)(resources.GetObject("button_modifica.Image")));
            this.button_modifica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modifica.Location = new System.Drawing.Point(0, 382);
            this.button_modifica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_modifica.Name = "button_modifica";
            this.button_modifica.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_modifica.Size = new System.Drawing.Size(258, 131);
            this.button_modifica.TabIndex = 4;
            this.button_modifica.Text = "     Modifica informatii medicamente";
            this.button_modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_modifica.UseVisualStyleBackColor = false;
            this.button_modifica.Click += new System.EventHandler(this.button4_Click);
            this.button_modifica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_modifica_MouseClick);
            this.button_modifica.MouseLeave += new System.EventHandler(this.button_modifica_MouseLeave);
            this.button_modifica.MouseHover += new System.EventHandler(this.button_modifica_MouseHover);
            // 
            // button_adauga
            // 
            this.button_adauga.AutoSize = true;
            this.button_adauga.BackColor = System.Drawing.Color.Teal;
            this.button_adauga.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_adauga.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adauga.Image = ((System.Drawing.Image)(resources.GetObject("button_adauga.Image")));
            this.button_adauga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_adauga.Location = new System.Drawing.Point(0, 251);
            this.button_adauga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_adauga.Size = new System.Drawing.Size(258, 131);
            this.button_adauga.TabIndex = 2;
            this.button_adauga.Text = "     Adauga   medicamente";
            this.button_adauga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_adauga.UseVisualStyleBackColor = false;
            this.button_adauga.Click += new System.EventHandler(this.button1_MouseHover);
            this.button_adauga.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_adauga_MouseClick);
            this.button_adauga.MouseLeave += new System.EventHandler(this.button_adauga_MouseLeave);
            this.button_adauga.MouseHover += new System.EventHandler(this.button_adauga_MouseHover);
            // 
            // button_afisare
            // 
            this.button_afisare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_afisare.BackColor = System.Drawing.Color.Teal;
            this.button_afisare.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_afisare.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_afisare.Image = ((System.Drawing.Image)(resources.GetObject("button_afisare.Image")));
            this.button_afisare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_afisare.Location = new System.Drawing.Point(0, 120);
            this.button_afisare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_afisare.Name = "button_afisare";
            this.button_afisare.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_afisare.Size = new System.Drawing.Size(258, 131);
            this.button_afisare.TabIndex = 1;
            this.button_afisare.Text = "     Stoc Farmacie";
            this.button_afisare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_afisare.UseVisualStyleBackColor = false;
            this.button_afisare.Click += new System.EventHandler(this.button1_Click);
            this.button_afisare.MouseLeave += new System.EventHandler(this.button_afisare_MouseLeave);
            this.button_afisare.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(39)))));
            this.panel_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(258, 120);
            this.panel_logo.TabIndex = 5;
            // 
            // label_titlu
            // 
            this.label_titlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_titlu.AutoSize = true;
            this.label_titlu.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titlu.ForeColor = System.Drawing.Color.Snow;
            this.label_titlu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_titlu.Location = new System.Drawing.Point(427, 19);
            this.label_titlu.Name = "label_titlu";
            this.label_titlu.Size = new System.Drawing.Size(323, 66);
            this.label_titlu.TabIndex = 0;
            this.label_titlu.Text = "Farmacie";
            this.label_titlu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_titlu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(262, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 120);
            this.panel1.TabIndex = 1;
            // 
            // panel_afisare
            // 
            this.panel_afisare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_afisare.Location = new System.Drawing.Point(262, 120);
            this.panel_afisare.Name = "panel_afisare";
            this.panel_afisare.Size = new System.Drawing.Size(1097, 527);
            this.panel_afisare.TabIndex = 2;
            this.panel_afisare.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_afisare_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1359, 647);
            this.Controls.Add(this.panel_afisare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMeniu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMeniu.ResumeLayout(false);
            this.panelMeniu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.Button button_modifica;
        private System.Windows.Forms.Button button_cauta;
        private System.Windows.Forms.Button button_afisare;
        private System.Windows.Forms.Button button_adauga;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Label label_titlu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_afisare;
    }
}
