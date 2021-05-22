using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
namespace BarcodeReaderDecoderProject
{
    public partial class BarcodeEncoderDecoder : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager skinManager;
        public BarcodeEncoderDecoder()
        {
            InitializeComponent();
            skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.EnforceBackcolorOnAllComponents = false;
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue700, Primary.LightBlue700, Accent.LightBlue400, TextShade.WHITE);
        }

        /// <summary>
        /// WRITTING TO BARCODE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Encodebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Encodetxt.Text.Length > 0)
                {
                    BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                    DisplayPictureBox.Image = writer.Write(Encodetxt.Text);
                }
                else
                {
                    Encodetxt.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Decodebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DisplayPictureBox.Image != null)
                {
                    BarcodeReader reader = new BarcodeReader();
                    var results = reader.Decode((Bitmap)DisplayPictureBox.Image);
                    if (results != null)
                    {
                        Decodetxt.Text = results.Text;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
