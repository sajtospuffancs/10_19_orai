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
            List<string> kedvenclista = new List<string>();
            string[] adatok = new string[4];
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                osszesszoveg = File.ReadAllText(openFileDialog.FileName);
                adatok = osszesszoveg.Split(';');
                nev_textbox.Text = adatok[0];
                szuldat_textbox.Text = adatok[1];
                if (adatok[2] == "férfi")
                {
                    ferfi_radiobutton.Checked = true;
                }
                else if (adatok[2] == "nő")
                {
                    no_radiobutton.Checked = true;
                }
                else { }
                string[] lista = adatok[4].Split(',');
                for (int i = 0; i < lista.Length; i++)
                {
                    if (kedvenc_listbox.Items.Contains(lista[i]))
                    {
                    }
                    else
                    {
                        kedvenc_listbox.Items.Add(lista[i]);
                    }
                }
                kedvenc_listbox.SelectedItem = adatok[3];
            }
        }

        private void Mentes(string nev, string szulido, string nem, string kedvenchobbi)
        {
            string listatartalom = "";
            foreach(string szoveg in kedvenc_listbox.Items)
            {
                listatartalom += szoveg + ",";
            }
            saveFileDialog.FileName = "";
            string tartalom = string.Format("{0};{1};{2};{3};{4}", nev, szulido, nem, kedvenchobbi,listatartalom);
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
