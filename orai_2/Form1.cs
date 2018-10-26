using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace orai_2
{
    public partial class regisztracio_form : Form
    {
        public regisztracio_form()
        {
            InitializeComponent();

            hozzaad_button.Click += (EventArgs, e) =>
            {
                Hozzaad();
            };

            betoltes_button.Click += (EventArgs, e) =>
            {
                Betoltes();
            };

            mentes_button.Click += (EventArgs, e) =>
            {
                Mentes(nev_textbox.Text,szuldat_textbox.Text,ferfino(),kedvenc_listbox.SelectedItem.ToString());
            };

        }

        private void Hozzaad()
        {
            kedvenc_listbox.Items.Add(hozzaad_textbox.Text);
        }

        private void Betoltes()
        {
            openFileDialog.FileName = "";
            string osszesszoveg = "";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                osszesszoveg = File.ReadAllText(openFileDialog.FileName);
            }
            
        }

        private void Mentes(string nev, string szulido, string nem, string kedvenchobbi)
        {
            string tartalom = string.Format("{0}\n{1}\n{2}\n{3}", nev, szulido, nem, kedvenchobbi);
            saveFileDialog.FileName = "";
            var eredmeny = saveFileDialog.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string fileNev = saveFileDialog.FileName;
                File.WriteAllText(fileNev, tartalom);
            }
        }

        private string ferfino()
        {
            string ferfino = "";
            if (ferfi_radiobutton.Checked)
            {
                 ferfino = "férfi";
            } 
            else if (no_radiobutton.Checked)
            {
                 ferfino = "nő";
            }
            else
            {
                 ferfino = "nem pipált be nemet";
            }
            return ferfino;
        }

    }
}
