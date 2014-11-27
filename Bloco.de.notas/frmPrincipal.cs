using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notepad
{
    public partial class frmPrincipal : Form
    {
        Fonte f = new Fonte();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)              //Salvar
        {
            save.Filter = "txt files (*.txt)|*.txt";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
            { txttexto.SaveFile(save.FileName, RichTextBoxStreamType.PlainText); }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)             //Abrir
        {
            load.Filter = "txt files (*.txt)|*.txt";
            if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                System.IO.StreamReader file = new System.IO.StreamReader(@load.FileName);
                txttexto.Text = file.ReadToEnd();}
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)           //Mudar fonte
        {
            font.ShowDialog();
            txttexto.Font = font.Font;
        }

        private void quebraDeLinhaToolStripMenuItem_Click(object sender, EventArgs e)   //Altera código fonte
        {
            if (menuquebraDeLinha.Checked == true)
            {  txttexto.WordWrap = true; }
            else 
            {  txttexto.WordWrap = false; }
        }

        private void carregarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        { f.lerfonte(txttexto); }
        private void salvarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        { f.salvarfonte(txttexto); }






    }
}
