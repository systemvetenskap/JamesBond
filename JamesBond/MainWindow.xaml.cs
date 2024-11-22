using System.Windows;

namespace JamesBond
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            /*
             * vi vill skriva: My name is Bond, James Bond
             * 
             * vi kan göra en metod för detta på något sätt
             * 
             * Indata: Namnet, Erik Öberg
             * Utdata: Öberg, Erik Öberg
             * 
             * My name is Öberg, Erik Öberg
             */
            string name = "Eva Ek";
            string agentName = Bondifier(name);

            /*
             * Nu vill vi ta reda på om en person är vän eller fiende
             * friend or foo
             * 
             * foo
             * 
             * om personen har minst ett F och minst två O i namnet
             * då är man en fiende -> foo
             * annars är man en vän
             * 
             * James Bond Jj
             * Erik Öberg
             * Foley Bond
             * Molly Moore
             * */

            bool isEnemy = IsFoo(name);
        }
        /// <summary>
        /// Ta reda på om en person är vän eller fiende.
        /// 
        ///
        /// </summary>
        /// <param name="name">namnet</param>
        /// <returns>true om personen är fiende
        /// false om personen inte är fiende</returns>
        private bool IsFoo(string name)
        {
            name = name.ToLower();
            // returnera true om det är en person med minst ett f och två o

            return false;
        }

        private string FuskBondifier(string name)
        {
            /* vi behöver hitta vad som är förnamn 
             * och vad som är efternamn
             */

            // Plan
            // leta upp om det går att splitta en sträng?

            // alternativ. Vi har en variabel förnamn, en efternamn
            string firstName, lastName;
            // strängar --> " "
            // tecken, chars --> ''

            string[] parts = name.Split(" ");
            firstName = parts[0];
            lastName = parts[1];
            string message = firstName + ", " + firstName + " " + lastName;
            return $"{lastName}, {firstName} {lastName}";
        }
        private string Bondifier(string name)
        {
            /* vi behöver hitta vad som är förnamn 
             * och vad som är efternamn
             * 
             * tricket är att leta efter mellanslaget
             * 
             * skulle vi kunna loopa och leta
             * Erik --> E r i k
             */


            // alternativ. Vi har en variabel förnamn, en efternamn
            string firstName = string.Empty, lastName = string.Empty;

            bool isLastname = false;
            foreach (char letter in name)
            {
                if (letter == ' ')
                {
                    isLastname = true;
                    //continue;
                }
                else if (!isLastname)
                {
                    firstName += letter;
                }
                else
                {
                    lastName += letter;
                }

            }

            return $"{lastName}, {firstName} {lastName}";
        }
    }
}