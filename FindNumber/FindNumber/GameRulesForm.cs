using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FindNumber
{
    public partial class GameRulesForm : Form
    {
        public GameRulesForm(int language)
        {
            InitializeComponent();

            SetLanguge(language); //Prepare form according selected language
        }

        private void SetLanguge(int language)
        {
            if (language == 0) // Turkish
            {
                // form caption
                this.Text = "Oyunun Kuralları";

                // rules
                rtbRules.AppendText("Genel Oyun Tanımı\n"+
                    "     Sayı bulma oyunu, iki oyuncu arasında oynanan bir oyundur. Her iki oyuncu\n"+
                    "kendilerine rakamları birbirinden farklı 4 basamaklı birer sayı tutarlar. Tutulan sayı\n"+
                    "rakip oyuncuya kesinlikle söylenmez. Karşılıklı olarak sıra ile tahminlerde bulunarak\n"+
                    "bu sayıyı bulmaya çalışırlar. Oyuncular sayı tahminlerini rastgele yapmazlar. Tahminleri\n"+
                    "sonucunda rakip oyuncudan gelen ipuçlarına göre sayı tahminlerini geliştirirler. Rakibin\n"+
                    "sayısını ilk bilen oyunu kazanır.\n\n"+
                    "Sayı Tutmanın Kuralları\n"+
                    "   1. Rakamları birbirinden farklı olmak zorundadır. Tutulan sayı içinde aynı rakam\n"+
                    "      birden fazla kullanılamaz. Örneğin “1158” yanlıştır çünkü 1 rakamı iki defa\n"+
                    "kullanılmıştır. “2546” ise doğrudur.\n"+
                    "   2. Sayı 4 basamaklı olmak zorundadır. Bu sebepten dolayı ilk basamak “0” olamaz.\n"+
                    "      İlk rakam “0” olursa sayı 4 basamaklı olmaz.\n\n"+
                    "İpucu Nasıl Oluşturulur\n"+
                    "   1. Rakip oyuncudan gelen sayının rakamları oyuncunun kendi tuttuğu sayının rakamları\n"+
                    "      ile tek tek kıyaslanır. Gelen sayının rakamı oyuncunun tuttuğu sayıda varsa ve\n"+
                    "      doğru basamakta ise ipucunun + kısmına 1 eklenir. Eğer rakam varsa ama yanlış\n"+
                    "      basamakta ise ipucunun – kısmına 1 eklenir. Örneğin kullanıcının tuttuğu sayı \n"+
                    "      '3065' olsun. Rakip oyuncunun tahmini de '3056' olsun. Burada ipucu '+2 -2' olacaktır.\n"+
                    "      İpucunda '+2' nin olmasının sebebi  '0' ve '3”rakamları tutulan sayı içinde var ve doğru\n"+
                    "      basamaktalar. İpucunda “-2” nin olmasının sebebi ise “5” ve “6” rakamları tutulan sayıda\n"+
                    "      var ama basamakları yanlış.\n"+
                    "   2. Tahmin edilen sayıda aynı rakam birden fazla kullanılmış ise eğer + bir eşleşme var ise\n"+
                    "      (rakam var ve doğru basmak değerinde) sadece ipucunun + kısmına eklenir. Örneğin tutulan\n"+
                    "      sayı '3065' rakip oyuncunun tahmini '3378' olsun. Bu durumda ipucu '+1' olur. '3' rakamı\n"+
                    "      için ayrıca ipucuna '-1' eklenmez. Rakip oyuncunun tahmini '7833' olsa idi ipucu '-1' olur.\n");

                rtbRules.Select(0, 0);  // set cursor position at up
                btnClose.Text = "Kapat";
            }
            else if (language == 1) // English
            {
                // form caption
                this.Text = "Rules of the Game";

                rtbRules.AppendText("Game Info\n" +
                     "     The game called 'Guess My Number' is played between two people. Players will pick\n" +
                     "a random four-digit number in their mind of which all digits are different than each other\n" +
                     "and ask the other player to guess it. After having numbers picked, both players start guessing\n" +
                     "the other player’s number and after each guess taken, the corresponding player must give a\n" +
                     "clue so that the process is based on educated guesses rather than random.\n\n" +
                     "The rules of picking a number\n" +
                     "     The numbers players pick should be four-digit number and all digits should be different.\n" +
                     "For instance, the player can’t pick 1158 since 1 is repetitive digit.\n" +
                     "     The first digit shouldn’t be 0 because the number must be a 4-digit and the number starting\n" +
                     "with 0 can’t be 4-digit\n\n" +
                     "How to give a clue \n" +
                     "     Player A should check any guess taken by the player B with the picked number whether or not\n" +
                     "there is any same number/digit between the guessed number and picked number. If both the number\n" +
                     "and the digit placement are matched, a '+1' is added under pro clues. However, if the number is\n" +
                     "included but in different digit, then a '-1' is added under con clues. For example, player A picks\n" +
                     "'3065’ and player B guesses '3056'. In this case, the clue player A should give would be '+2, -2'.\n" +
                     "It is because '3' and '0' are a match for both the number and the digit, however, '5' and '6' are\n" +
                     "correct numbers but in different digit.\n" +
                     "     When a player guesses a number that has a repetitive number in it and if that number is a '+'\n" +
                     "match (meaning both number and digit placement are correct), then only '+1' is added under pro clues.\n" +
                     "For instance, player A picks '3065' and player B guesses '3378' where '3' is the repetitive number.\n" +
                     "In this case, the clue player A should give should be only '+1' for the number '3' that is in the right\n" +
                     "place even though second number '3' qualifies for '-1' clue.");

                rtbRules.Select(0, 0);  // set cursor position at up
                btnClose.Text = "Close";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
