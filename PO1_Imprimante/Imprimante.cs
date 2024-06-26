﻿using QRCoder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Imprimante
{
    public class Imprimante
    {

        Font printFont;
        Vente vente;
        public void Imprimer(Vente venteImprimer)
        {
            try
            {
                try
                {
                    printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            //logo
            //toute la representation
            // + nb billet enfant + nb billet general + CodeQR
            List<string> linesAImprimer = vente.GenererBillet(); 
            foreach(string LigneAImprimer in linesAImprimer)
            {
                yPos = topMargin + (count *
             printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
            }
            Bitmap codeQR = vente.GenererCodeQR();
            ev.Graphics.DrawImage(codeQR, leftMargin, yPos, 180, 180);
          



        }

    }
}
