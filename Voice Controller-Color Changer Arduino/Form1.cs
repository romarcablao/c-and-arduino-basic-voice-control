using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;



namespace Voice_Controller_Color_Changer_Arduino
{
    public partial class frmMain : Form
    {

        //Speech Recog Var
        SpeechSynthesizer synth = new SpeechSynthesizer();
        SpeechRecognizer recognizer = new SpeechRecognizer();

        //Move Panel Var
        bool move;
        int mX, mY;

        public frmMain()
        {
            InitializeComponent();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoiceByHints(VoiceGender.Female);

            try
            {
                serialPortArduino.Open();
            }
            catch (Exception)
            {
                synth.Speak("Not Connected to Arduino!");
            }

            synth.Speak("This example demonstrates a basic voice control with the use of C# and Arduino.");
            synth.Speak("Say 'RED', to change L-E-D light to red. Say 'YELLOW', to change L-E-D light to yellow. Say 'GREEN', to change L-E-D light to green.");
            synth.Speak("Say 'EXIT', to close the application. Let's Start!");

            Listen();
        }

        private void Listen()
        {
            
            Choices colors = new Choices();
            colors.Add(new string[] { "red", "yellow", "green","exit" });

            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(colors);
            
            Grammar g = new Grammar(gb);
            recognizer.LoadGrammar(g);
            
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
          
        }

        private void bntColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.Top = Cursor.Position.Y - mY;
                this.Left = Cursor.Position.X - mX;
            }
        }

        private void bntColor_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void bntColor_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mX = Cursor.Position.X - this.Left;
            mY = Cursor.Position.Y - this.Top;
        }

        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.ToUpper() == "RED")
            {
                this.bntColor.BackColor = Color.Red;
                this.bntColor.Text = "RED";
                synth.Speak("Turning red on!");

                try
                {
                    serialPortArduino.Write("red");
                }
                catch (Exception)
                {
                   // synth.Speak("Not Connected to Arduino!");
                }
                
            }
            else if (e.Result.Text.ToUpper() == "YELLOW")
            {
                this.bntColor.BackColor = Color.Yellow;
                this.bntColor.Text = "YELLOW";
                synth.Speak("Turning yellow on!");

                try
                {
                    serialPortArduino.Write("yellow");
                }
                catch (Exception)
                {
                   // synth.Speak("Not Connected to Arduino!");
                }

            }
            else if (e.Result.Text.ToUpper() == "GREEN")
            {
                this.bntColor.BackColor = Color.Green;
                this.bntColor.Text = "GREEN";
                synth.Speak("Turning green on!");

                try
                {
                    serialPortArduino.Write("green");
                }
                catch (Exception)
                {
                   // synth.Speak("Not Connected to Arduino!");
                }

            }
            else if(e.Result.Text.ToUpper() == "EXIT")
            {
                synth.Speak("Thank you for testing me out! See you! Exiting Application...");
                recognizer.Dispose();
                serialPortArduino.Close();
                this.Close();
            }
           
        }

    }
}
