namespace orai_2
{
    partial class regisztracio_form
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
            this.nev_textbox = new System.Windows.Forms.TextBox();
            this.szuldat_textbox = new System.Windows.Forms.TextBox();
            this.kerdes1_label = new System.Windows.Forms.Label();
            this.szuldat_label = new System.Windows.Forms.Label();
            this.nem_label = new System.Windows.Forms.Label();
            this.kedvenc_label = new System.Windows.Forms.Label();
            this.ferfi_radiobutton = new System.Windows.Forms.RadioButton();
            this.no_radiobutton = new System.Windows.Forms.RadioButton();
            this.kedvenc_listbox = new System.Windows.Forms.ListBox();
            this.hozzaad_textbox = new System.Windows.Forms.TextBox();
            this.hozzaad_label = new System.Windows.Forms.Label();
            this.mentes_button = new System.Windows.Forms.Button();
            this.betoltes_button = new System.Windows.Forms.Button();
            this.hozzaad_button = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // nev_textbox
            // 
            this.nev_textbox.Location = new System.Drawing.Point(70, 15);
            this.nev_textbox.Name = "nev_textbox";
            this.nev_textbox.Size = new System.Drawing.Size(100, 20);
            this.nev_textbox.TabIndex = 0;
            // 
            // szuldat_textbox
            // 
            this.szuldat_textbox.Location = new System.Drawing.Point(266, 15);
            this.szuldat_textbox.Name = "szuldat_textbox";
            this.szuldat_textbox.Size = new System.Drawing.Size(100, 20);
            this.szuldat_textbox.TabIndex = 1;
            // 
            // kerdes1_label
            // 
            this.kerdes1_label.AutoSize = true;
            this.kerdes1_label.Location = new System.Drawing.Point(19, 18);
            this.kerdes1_label.Name = "kerdes1_label";
            this.kerdes1_label.Size = new System.Drawing.Size(30, 13);
            this.kerdes1_label.TabIndex = 2;
            this.kerdes1_label.Text = "Név:";
            // 
            // szuldat_label
            // 
            this.szuldat_label.AutoSize = true;
            this.szuldat_label.Location = new System.Drawing.Point(191, 18);
            this.szuldat_label.Name = "szuldat_label";
            this.szuldat_label.Size = new System.Drawing.Size(67, 13);
            this.szuldat_label.TabIndex = 3;
            this.szuldat_label.Text = "Szül. Dátum:";
            // 
            // nem_label
            // 
            this.nem_label.AutoSize = true;
            this.nem_label.Location = new System.Drawing.Point(110, 53);
            this.nem_label.Name = "nem_label";
            this.nem_label.Size = new System.Drawing.Size(32, 13);
            this.nem_label.TabIndex = 4;
            this.nem_label.Text = "Nem:";
            // 
            // kedvenc_label
            // 
            this.kedvenc_label.AutoSize = true;
            this.kedvenc_label.Location = new System.Drawing.Point(30, 93);
            this.kedvenc_label.Name = "kedvenc_label";
            this.kedvenc_label.Size = new System.Drawing.Size(82, 13);
            this.kedvenc_label.TabIndex = 5;
            this.kedvenc_label.Text = "Kedvenc hobbi:";
            // 
            // ferfi_radiobutton
            // 
            this.ferfi_radiobutton.AutoSize = true;
            this.ferfi_radiobutton.Location = new System.Drawing.Point(160, 51);
            this.ferfi_radiobutton.Name = "ferfi_radiobutton";
            this.ferfi_radiobutton.Size = new System.Drawing.Size(45, 17);
            this.ferfi_radiobutton.TabIndex = 6;
            this.ferfi_radiobutton.TabStop = true;
            this.ferfi_radiobutton.Text = "Férfi";
            this.ferfi_radiobutton.UseVisualStyleBackColor = true;
            // 
            // no_radiobutton
            // 
            this.no_radiobutton.AutoSize = true;
            this.no_radiobutton.Location = new System.Drawing.Point(219, 51);
            this.no_radiobutton.Name = "no_radiobutton";
            this.no_radiobutton.Size = new System.Drawing.Size(39, 17);
            this.no_radiobutton.TabIndex = 7;
            this.no_radiobutton.TabStop = true;
            this.no_radiobutton.Text = "Nő";
            this.no_radiobutton.UseVisualStyleBackColor = true;
            // 
            // kedvenc_listbox
            // 
            this.kedvenc_listbox.FormattingEnabled = true;
            this.kedvenc_listbox.Items.AddRange(new object[] {
            "Számítógépezés",
            "Pankráció",
            "Focizás"});
            this.kedvenc_listbox.Location = new System.Drawing.Point(12, 118);
            this.kedvenc_listbox.Name = "kedvenc_listbox";
            this.kedvenc_listbox.Size = new System.Drawing.Size(120, 95);
            this.kedvenc_listbox.TabIndex = 8;
            // 
            // hozzaad_textbox
            // 
            this.hozzaad_textbox.Location = new System.Drawing.Point(150, 149);
            this.hozzaad_textbox.Name = "hozzaad_textbox";
            this.hozzaad_textbox.Size = new System.Drawing.Size(100, 20);
            this.hozzaad_textbox.TabIndex = 9;
            // 
            // hozzaad_label
            // 
            this.hozzaad_label.AutoSize = true;
            this.hozzaad_label.Location = new System.Drawing.Point(150, 133);
            this.hozzaad_label.Name = "hozzaad_label";
            this.hozzaad_label.Size = new System.Drawing.Size(98, 13);
            this.hozzaad_label.TabIndex = 10;
            this.hozzaad_label.Text = "Hobbi hozzáadása:";
            // 
            // mentes_button
            // 
            this.mentes_button.Location = new System.Drawing.Point(291, 162);
            this.mentes_button.Name = "mentes_button";
            this.mentes_button.Size = new System.Drawing.Size(75, 23);
            this.mentes_button.TabIndex = 11;
            this.mentes_button.Text = "Mentés";
            this.mentes_button.UseVisualStyleBackColor = true;
            // 
            // betoltes_button
            // 
            this.betoltes_button.Location = new System.Drawing.Point(291, 109);
            this.betoltes_button.Name = "betoltes_button";
            this.betoltes_button.Size = new System.Drawing.Size(75, 23);
            this.betoltes_button.TabIndex = 12;
            this.betoltes_button.Text = "Betöltés";
            this.betoltes_button.UseVisualStyleBackColor = true;
            // 
            // hozzaad_button
            // 
            this.hozzaad_button.Location = new System.Drawing.Point(163, 175);
            this.hozzaad_button.Name = "hozzaad_button";
            this.hozzaad_button.Size = new System.Drawing.Size(75, 23);
            this.hozzaad_button.TabIndex = 13;
            this.hozzaad_button.Text = "Hozzáad";
            this.hozzaad_button.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // regisztracio_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 225);
            this.Controls.Add(this.hozzaad_button);
            this.Controls.Add(this.betoltes_button);
            this.Controls.Add(this.mentes_button);
            this.Controls.Add(this.hozzaad_label);
            this.Controls.Add(this.hozzaad_textbox);
            this.Controls.Add(this.kedvenc_listbox);
            this.Controls.Add(this.no_radiobutton);
            this.Controls.Add(this.ferfi_radiobutton);
            this.Controls.Add(this.kedvenc_label);
            this.Controls.Add(this.nem_label);
            this.Controls.Add(this.szuldat_label);
            this.Controls.Add(this.kerdes1_label);
            this.Controls.Add(this.szuldat_textbox);
            this.Controls.Add(this.nev_textbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "regisztracio_form";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev_textbox;
        private System.Windows.Forms.TextBox szuldat_textbox;
        private System.Windows.Forms.Label kerdes1_label;
        private System.Windows.Forms.Label szuldat_label;
        private System.Windows.Forms.Label nem_label;
        private System.Windows.Forms.Label kedvenc_label;
        private System.Windows.Forms.RadioButton ferfi_radiobutton;
        private System.Windows.Forms.RadioButton no_radiobutton;
        private System.Windows.Forms.ListBox kedvenc_listbox;
        private System.Windows.Forms.TextBox hozzaad_textbox;
        private System.Windows.Forms.Label hozzaad_label;
        private System.Windows.Forms.Button mentes_button;
        private System.Windows.Forms.Button betoltes_button;
        private System.Windows.Forms.Button hozzaad_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

