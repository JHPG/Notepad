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
    public class Fonte
    {
        
        public void salvarfonte(RichTextBox tx)                    //Font[1], Tamanho[2], Cor[3]
        {
            string[] strlines; strlines = new string[2];

            strlines[0] = tx.Font.Name.ToString();
            strlines[1] = tx.Font.Size.ToString();
            strlines[2] = tx.ForeColor.ToString();

            System.IO.File.WriteAllLines(@"config.cf", strlines);
        }

        public void lerfonte(RichTextBox tx)
        {
            string[] fonte; fonte = new string[3];    //Font[1], Tamanho[2], Cor[3]

            tx.Font = (System.Drawing.Font)new FontConverter().ConvertFromString(lertxt("config.cf", 1));
            //tx.Size = (System.Drawing.Size)new SizeConverter().ConvertFromString(lertxt("config.cf", 2));

        }

        public string lertxt(string arquivo, int linha)
        {
            int counter = 1;
            string line;
            string valorfinal = "0";

            // Lê o txt e mostra linha por linha.
            System.IO.StreamReader file = new System.IO.StreamReader(@arquivo);
            while ((line = file.ReadLine()) != null)
            {
                if (counter == linha)  { valorfinal = line; }
                counter++;
            }
            file.Close();
            return valorfinal;
        }
    }
}
