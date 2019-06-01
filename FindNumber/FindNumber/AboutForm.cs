using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FindNumber
{
    public partial class AboutForm : Form
    {
        public AboutForm(int language)
        {
            InitializeComponent();

            SetLanguge(language);  //Prepare form according selected language
        }
        
        private void SetLanguge(int language)
        {
            if (language == 0) // Turkish
            {
                // form caption
                this.Text = "Yazılım Hakkında";
                lblMesage.Text = "Bu oyun CS-TECH şirketinin isteği üzerine\n"+
                                 "Hüseyin ULAŞ tarafından yazılmıştır.";
                
                btnClose.Text = "Kapat";
            }
            else if (language == 1) // english
            {
                // form caption
                this.Text = "About Software";
                                     
                lblMesage.Text = "This game was developed by Hüseyin ULAŞ\n"+
                                 "at the request of CS-TECH.";

                btnClose.Text = "Close";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
