


namespace BrunoAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AutoStart_CheckedChanged(object sender, EventArgs e)
        {
            //AutorunEnabled from config file
            if (AutoStart_box.Checked == false)
            {
                DialogResult result = MessageBox.Show("Confirmation Message", "Confirm",
                                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    AutoStart_box.Checked = true;
                }

            }
            else
            {
                AutoStart_box.Checked = false;
            }
        }
    }
}
