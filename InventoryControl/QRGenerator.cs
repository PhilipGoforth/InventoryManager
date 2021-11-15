using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControl
{
    public partial class QRGenerator : Form
    {
        public QRGenerator()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(textQRCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pic.Image = code.GetGraphic(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(textQRCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pic.Image = code.GetGraphic(5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventoryControl userPage = new InventoryControl();
            userPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += myPrintPage;
            pd.Document = doc;
            if(pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }            
        }
        private void myPrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pic.Width, pic.Height);
            pic.DrawToBitmap(bm, new Rectangle(0, 0, pic.Width, pic.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}
