using System.Speech;
using System.Speech.Synthesis;

namespace Text_To_Speech_Forms
{
    public partial class TextToSpeech : Form
    {
        SpeechSynthesizer reader = new SpeechSynthesizer();

        public TextToSpeech()
        {
            InitializeComponent();

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            Stream str;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((str = openFileDialog.OpenFile()) != null)
                {
                    using (str)
                    {
                        string fname = openFileDialog.FileName;
                        string filetxt = File.ReadAllText(fname);
                        RtbBox.Text = filetxt;
                    }
                }
            }
        }

        private void BtnSpeak_Click(object sender, EventArgs e)
        {
            timer1.Start();
            reader.SpeakAsync(RtbBox.Text);
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                    timer1.Stop();
                }
            }
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                    timer1.Start();
                }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.Dispose();
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RtbBox.ForeColor = Color.Yellow;
        }
    }
}
