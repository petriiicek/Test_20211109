namespace Test_20211109
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.vyber = new System.Windows.Forms.Button();
            this.vklad = new System.Windows.Forms.Button();
            this.stav = new System.Windows.Forms.Button();
            this.castka = new System.Windows.Forms.Label();
            this.platba = new System.Windows.Forms.Button();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.label_limit_vyber = new System.Windows.Forms.Label();
            this.label_limit_vklad = new System.Windows.Forms.Label();
            this.label_limit_platba = new System.Windows.Forms.Label();
            this.LimitVyber = new System.Windows.Forms.TextBox();
            this.LimitVklad = new System.Windows.Forms.TextBox();
            this.LimitPlatba = new System.Windows.Forms.TextBox();
            this.texbox_castka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka";
            // 
            // vyber
            // 
            this.vyber.Location = new System.Drawing.Point(39, 167);
            this.vyber.Name = "vyber";
            this.vyber.Size = new System.Drawing.Size(75, 23);
            this.vyber.TabIndex = 1;
            this.vyber.Text = "Výběr";
            this.vyber.UseVisualStyleBackColor = true;
            this.vyber.Click += new System.EventHandler(this.vyber_Click);
            // 
            // vklad
            // 
            this.vklad.Location = new System.Drawing.Point(139, 167);
            this.vklad.Name = "vklad";
            this.vklad.Size = new System.Drawing.Size(75, 23);
            this.vklad.TabIndex = 1;
            this.vklad.Text = "Vklad";
            this.vklad.UseVisualStyleBackColor = true;
            this.vklad.Click += new System.EventHandler(this.vklad_Click);
            // 
            // stav
            // 
            this.stav.Location = new System.Drawing.Point(238, 167);
            this.stav.Name = "stav";
            this.stav.Size = new System.Drawing.Size(75, 23);
            this.stav.TabIndex = 1;
            this.stav.Text = "Stav";
            this.stav.UseVisualStyleBackColor = true;
            this.stav.Click += new System.EventHandler(this.stav_Click);
            // 
            // castka
            // 
            this.castka.AutoSize = true;
            this.castka.Location = new System.Drawing.Point(39, 101);
            this.castka.Name = "castka";
            this.castka.Size = new System.Drawing.Size(42, 15);
            this.castka.TabIndex = 3;
            this.castka.Text = "Částka";
            // 
            // platba
            // 
            this.platba.Location = new System.Drawing.Point(335, 167);
            this.platba.Name = "platba";
            this.platba.Size = new System.Drawing.Size(75, 23);
            this.platba.TabIndex = 1;
            this.platba.Text = "Platba";
            this.platba.UseVisualStyleBackColor = true;
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Location = new System.Drawing.Point(39, 63);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(98, 15);
            this.labelJmeno.TabIndex = 3;
            this.labelJmeno.Text = "Jméno a přijmení";
            // 
            // label_limit_vyber
            // 
            this.label_limit_vyber.AutoSize = true;
            this.label_limit_vyber.Location = new System.Drawing.Point(39, 250);
            this.label_limit_vyber.Name = "label_limit_vyber";
            this.label_limit_vyber.Size = new System.Drawing.Size(73, 15);
            this.label_limit_vyber.TabIndex = 3;
            this.label_limit_vyber.Text = "Limit výběru";
            // 
            // label_limit_vklad
            // 
            this.label_limit_vklad.AutoSize = true;
            this.label_limit_vklad.Location = new System.Drawing.Point(39, 282);
            this.label_limit_vklad.Name = "label_limit_vklad";
            this.label_limit_vklad.Size = new System.Drawing.Size(72, 15);
            this.label_limit_vklad.TabIndex = 3;
            this.label_limit_vklad.Text = "Limit vkladu";
            // 
            // label_limit_platba
            // 
            this.label_limit_platba.AutoSize = true;
            this.label_limit_platba.Location = new System.Drawing.Point(39, 313);
            this.label_limit_platba.Name = "label_limit_platba";
            this.label_limit_platba.Size = new System.Drawing.Size(70, 15);
            this.label_limit_platba.TabIndex = 3;
            this.label_limit_platba.Text = "Limit platby";
            // 
            // LimitVyber
            // 
            this.LimitVyber.Location = new System.Drawing.Point(139, 247);
            this.LimitVyber.Name = "LimitVyber";
            this.LimitVyber.Size = new System.Drawing.Size(100, 23);
            this.LimitVyber.TabIndex = 2;
            this.LimitVyber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LimitVklad
            // 
            this.LimitVklad.Location = new System.Drawing.Point(139, 282);
            this.LimitVklad.Name = "LimitVklad";
            this.LimitVklad.Size = new System.Drawing.Size(100, 23);
            this.LimitVklad.TabIndex = 2;
            this.LimitVklad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LimitPlatba
            // 
            this.LimitPlatba.Location = new System.Drawing.Point(139, 313);
            this.LimitPlatba.Name = "LimitPlatba";
            this.LimitPlatba.Size = new System.Drawing.Size(100, 23);
            this.LimitPlatba.TabIndex = 2;
            this.LimitPlatba.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // texbox_castka
            // 
            this.texbox_castka.Location = new System.Drawing.Point(139, 98);
            this.texbox_castka.Name = "texbox_castka";
            this.texbox_castka.Size = new System.Drawing.Size(100, 23);
            this.texbox_castka.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.texbox_castka);
            this.Controls.Add(this.LimitPlatba);
            this.Controls.Add(this.LimitVklad);
            this.Controls.Add(this.LimitVyber);
            this.Controls.Add(this.label_limit_platba);
            this.Controls.Add(this.label_limit_vklad);
            this.Controls.Add(this.label_limit_vyber);
            this.Controls.Add(this.labelJmeno);
            this.Controls.Add(this.platba);
            this.Controls.Add(this.castka);
            this.Controls.Add(this.stav);
            this.Controls.Add(this.vklad);
            this.Controls.Add(this.vyber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vyber;
        private System.Windows.Forms.Button vklad;
        private System.Windows.Forms.Button stav;
        private System.Windows.Forms.Label castka;
        private System.Windows.Forms.Button platba;
        private System.Windows.Forms.Label labelJmeno;
        private System.Windows.Forms.Label label_limit_vyber;
        private System.Windows.Forms.Label label_limit_vklad;
        private System.Windows.Forms.Label label_limit_platba;
        private System.Windows.Forms.TextBox textBoxPlatebniLimit;
        private System.Windows.Forms.TextBox LimitVklad;
        private System.Windows.Forms.TextBox LimitPlatba;
        private System.Windows.Forms.TextBox LimitVyber;
        private System.Windows.Forms.TextBox textBoxcastka;
        private System.Windows.Forms.TextBox texbox_castka;
    }
}

