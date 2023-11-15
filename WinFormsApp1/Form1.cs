using System.Globalization;
using System.Resources;
using WinFormsApp1.Resources;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ResourceManager ResourceManager = new ResourceManager(typeof(Resources.Resources));
        void SetText()
        {
            label1.Text = ResourceManager.GetString("txt");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("zh");
            SetText();
        }
    }
}