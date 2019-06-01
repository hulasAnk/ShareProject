using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FindNumber
{
    
    public partial class MainForm : Form
    {
        GameOperations objGameOperations; // game operation's object

        int language; // for language setting 0:Turkish 1: English

        public MainForm()
        {
            InitializeComponent();

            language = 0;        // Set language Turkish 
            SetFormLanguage();   // Prepare form according selected language

            ClearScreen();       // clearing data on the screen

            gbComputerSide.Enabled = false;  // initializing steps for program
            gbUserSide.Enabled = false;   

        }

        /// <summary>
        /// Prepare form according selected language
        /// </summary>
        private void SetFormLanguage()
        {
            if (language == 0) // Turkish
            {
                //form caption
                this.Text = "Sayı Bulma Oyunu";

                //menu items
                tsmiOperations.Text = "İşlemler";
                tsmiStart.Text = "Oyuna Başla";
                tsmiPlayAgain.Text = "Yeniden Oyna";
                tsmiExit.Text = "Çıkış";

                tsmiLanguageSettings.Text = "Dil Ayarı";
                tsmiTurkish.Text = "Türkçe";
                tsmiEnglish.Text = "İngilizce";

                tsmiRulesAbout.Text = "Yardım";
                tsmiRules.Text = "Oyunun Kuralları";
                tsmiAbout.Text = "Hakkında";

                //Computer Side
                gbComputerSide.Text = "Bilgisayar Bölümü";
                lblCSBasTahmin.Text = "Tahmin :";
                btnCSEnterResult.Text = "Sonucu İşle";
                lblCSResultListCap.Text = "Sonuçlar :";

                //User Side
                gbUserSide.Text = "Kullanıcı Bölümü";
                lblUSBasTahmin.Text = "Tahmin :";
                btnUSCheck.Text = "Kontrol Et";
                lblUSResultListCap.Text = "Sonuçlar :";

 
            }
            else if (language == 1) // English
            {
                //form caption
                this.Text = "Guess My Number";

                //menu items
                tsmiOperations.Text = "Operations";
                tsmiStart.Text = "Start Game";
                tsmiPlayAgain.Text = "Play Again";
                tsmiExit.Text = "Exit";

                tsmiLanguageSettings.Text = "Language Setting";
                tsmiTurkish.Text = "Turkish";
                tsmiEnglish.Text = "English";

                tsmiRulesAbout.Text = "Help";
                tsmiRules.Text = "Rules of the Game";
                tsmiAbout.Text = "About";

                //Computer Side
                gbComputerSide.Text = "Computer Side";
                lblCSBasTahmin.Text = "Guess :";
                btnCSEnterResult.Text = "Enter Results";
                lblCSResultListCap.Text = "Results :";

                //User Side
                gbUserSide.Text = "User Side";
                lblUSBasTahmin.Text = "Guess :";
                btnUSCheck.Text = "Check Guess";
                lblUSResultListCap.Text = "Results :";
 
            }

        }

        /// <summary>
        /// Clearing data on the screen
        /// </summary>
        private void ClearScreen()
        {
            tbCSGuess.Text = "";
            tbCSPos.Text = "";
            tbCSNeg.Text = "";
            rtbCSResult.Clear();

            tbUSGuess.Text = "";
            rtbUSResultList.Clear();
            lblUSResult.Text = "----";
        }

        /// <summary>
        /// Sets the screen in order of the players.
        /// </summary>
        /// <param name="side">Order of the game. 0:Player 1:Computer</param>
        private void ControlSide(int side)
        {
            if (side == 0) // player
            {
                tbCSPos.ReadOnly = true;
                tbCSNeg.ReadOnly = true;
                btnCSEnterResult.Enabled = false;

                tbUSGuess.ReadOnly = false;
                btnUSCheck.Enabled = true;
            }
            else // computer
            {
                tbCSPos.Text = "0";
                tbCSNeg.Text = "0";

                // Get Guess number and show on screen
                tbCSGuess.Text = objGameOperations.FindGuess(); 

                tbCSPos.ReadOnly = false;
                tbCSNeg.ReadOnly = false;
                btnCSEnterResult.Enabled = true;

                tbUSGuess.ReadOnly = true;
                btnUSCheck.Enabled = false;

            }

        }

        /// <summary>
        /// Player click start game button on the menü
        /// </summary>
        private void tsmiStart_Click(object sender, EventArgs e)
        {
            objGameOperations = new GameOperations();  // create object of game operation

            gbComputerSide.Enabled = true;  // initializing for game 
            gbUserSide.Enabled = true;

            ControlSide(0);                 // give order to player

            tsmiStart.Enabled = false;      // start button disable and play again enable
            tsmiPlayAgain.Enabled = true;    
        }

        /// <summary>
        /// Player click play again button on the menü 
        /// </summary>
        private void tsmiPlayAgain_Click(object sender, EventArgs e)
        {
            ClearScreen();    //clearing data on the screen

            objGameOperations.ResetGame(); // reset game operation object and initialize beginning

            gbComputerSide.Enabled = true; // initialize screen for game 
            gbUserSide.Enabled = true;

            ControlSide(0);  //give order to player
        }

        /// <summary>
        /// Player click exit button on the menü  
        /// </summary>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Player click language settings for Turkish button on the menü 
        /// </summary>
        private void tsmiTurkish_Click(object sender, EventArgs e)
        {
            language = 0;        // Set language Turkish
            SetFormLanguage();   // Prepare form according selected language
        }

        /// <summary>
        /// Player click language settings for English button on the menü 
        /// </summary>
        private void tsmiEnglish_Click(object sender, EventArgs e)
        {
            language = 1;        // Set language English
            SetFormLanguage();   // Prepare form according selected language
        }

        /// <summary>
        /// Player click rules of the game button on the menü
        /// </summary>
        private void tsmiRules_Click(object sender, EventArgs e)
        {
            GameRulesForm frmGameRulesForm = new GameRulesForm(language);
            frmGameRulesForm.ShowDialog();

        }
        /// <summary>
        /// Player click about button on the menü
        /// </summary>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutForm frmAboutForm = new AboutForm(language);
            frmAboutForm.ShowDialog();

        }
        /// <summary>
        /// Player click enter result button for send clue to computer
        /// </summary>
        private void btnCSEnterResult_Click(object sender, EventArgs e)
        {
            string result = "";

            if (tbCSPos.Text == "")  //positive clue cannot be empty. give '0' value for block error   
                tbCSPos.Text = "0";

            if (tbCSNeg.Text == "")  //negative clue cannot be empty. give '0' value for block error
                tbCSNeg.Text = "0";

            // sum of positive and negative clue little than 4.
            // if it is bigger than 4 give error message and return.
            if ((Convert.ToInt32(tbCSPos.Text) + Convert.ToInt32(tbCSNeg.Text)) > 4)
            {
                if (language == 0)
                {
                    MessageBox.Show("Hatalı veri girişi yaptınız. Positif ve negatif eşleşme toplamı\n"+
                                    "maksimum 4 olabilir. Lütfen kontrol ederek tekrar deneyiniz.");
                }
                else if (language == 1)
                {
                    MessageBox.Show("You have entered incorrect data. The positive and negative match\n"+
                                    "sum can be a maximum of 4. Please check and try again.");
                }

                tbCSPos.Focus();
                return;
            }

            if (Convert.ToInt32(tbCSPos.Text) > 0)  // if player enter positive clue, add result clue
                result = "+" + tbCSPos.Text;

            if (Convert.ToInt32(tbCSNeg.Text) > 0)  // if player enter positive clue, add result clue
            {
                if (result != "")       
                    result = result + " ";

                result = result + "-" + tbCSNeg.Text;
            }

            if (result == "") // there is no match in number
                result = "0";

            if (result == "+4")    // this means equal guess and player number and game over 
            {
                if (language==0)
                    MessageBox.Show("Üzgünüm oyunu kaybettiniz. Tutulan sayı '" + objGameOperations.GetCSNumber()+"' idi.");
                else if (language == 1)
                    MessageBox.Show("Sorry you lost the game. Computer's number is '" + objGameOperations.GetCSNumber()+ "'");

                gbComputerSide.Enabled = false;   //set screen for game end
                gbUserSide.Enabled = false;
                return;
            }

            objGameOperations.ProcessResult(tbCSGuess.Text, result); //process clue which enter the player 

            if (objGameOperations.GetResultCount() < 1)   //if result  list empty, this means the player enter wrong clue
            {
                if (language == 0)
                    MessageBox.Show("Hatalı veri girişi tesbit edildi. Girdiğiniz verileri kontrol edebilirsiniz.\n"+
                                    "Üzgünüm oyunu kaybettiniz. Tutulan sayı '" + objGameOperations.GetCSNumber() + "' idi.");
                else if (language == 1)

                    MessageBox.Show("Incorrect data entry detected. You can check the data you entered.\n"+
                                    "Sorry you lost the game. Computer's number is '" + objGameOperations.GetCSNumber() + "'");

                gbComputerSide.Enabled = false;      //set screen for game end
                gbUserSide.Enabled = false;
                
                return;
            }

            // add guess and it's clue add result pane on the right computer side group. 
            rtbCSResult.AppendText(tbCSGuess.Text + " " + result + "\n");

            ControlSide(0); //give order to player
        }

        /// <summary>
        /// Player click check guess button for get clue from computer
        /// </summary>
        private void btnUSCheck_Click(object sender, EventArgs e)
        {
            //check player's guess and after result clue show screen
            lblUSResult.Text = objGameOperations.CompareNumbers(tbUSGuess.Text);

            // if the clue '+4' this means equal guess and computer's number. The game over 
            if (lblUSResult.Text == "+4") 
            {
                if (language == 0)
                    MessageBox.Show("Tebrikler oyunu kazandınız.");
                else if (language == 1)
                    MessageBox.Show("Congratulations you won the game.");

                gbComputerSide.Enabled = false;  //set screen for game end
                gbUserSide.Enabled = false;
                return;
            }

            // add guess and it's clue add result pane on the right user side group. 
            rtbUSResultList.AppendText(tbUSGuess.Text + " " + lblUSResult.Text + "\n");

            ControlSide(1); // give order to computer
        }

        /// <summary>
        /// Check key for just entering number
        /// </summary>
        private void tbCSPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Just entering numbers
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != 8))
                e.KeyChar = Convert.ToChar(0);
        }

        /// <summary>
        /// Check key for just entering number
        /// </summary>
        private void tbCSNeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Just entering numbers
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != 8))
                e.KeyChar = Convert.ToChar(0);
        }

        /// <summary>
        /// Check key for just entering number
        /// </summary>
        private void tbUSGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Just entering numbers
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != 8))
                e.KeyChar = Convert.ToChar(0);
        }


    }
}
