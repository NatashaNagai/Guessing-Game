namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {

        Random randomNum = new Random(); // created an object 

        int number = 0;
        int guesses = 0;

        public Form1()
        {
            InitializeComponent();

            guessNum();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtInputNum.Text); // i is converting the string into an int
            guesses += 1; // this is our counter 
            lblGuesses.Text = "You've guessed " + guesses + " times"; 

            if (i == number)
            {
                MessageBox.Show("Awesome! You guess it! Play again!");
                guessNum();
                txtInputNum.Text = ""; // it empties the text box 
                guesses = 0; // reset the box to generate a new game
                lblGuesses.Text = " You guesses " + guesses + " times"; // resetting it to zero again
                Form.ActiveForm.BackColor = Color.LightBlue; // changes form color after the first try 
            }
            else if (i < number)
            {
                MessageBox.Show("Too low");
            }
            else
                MessageBox.Show("Too high");

            
        }

        private void guessNum () // creating a function to generate random number 
        {
            number = randomNum.Next(0, 15); // next will generate a number between two numbers 
            lblInstructions.Text = "I am thinking of a number between: 0 and 15";
        }

        private void reset () // creating a function to reset the board 
        {

        }
    }
}