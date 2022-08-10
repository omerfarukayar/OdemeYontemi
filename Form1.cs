using OdemeYontemi.Interface;
using System.Reflection;

namespace OdemeYontemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] dirs = Directory.GetFiles(@"C:\Users\HP\Desktop\CSHARP\3.GUN\OdemeYontemi\OdemeYontemleri\");
            List<string> files = new List<string>();

            for (int i = 0; i < dirs.Length; i++)
            {
                string[] splitted = dirs[i].Split("\\");
                files.Add(splitted[splitted.Length - 1].Split(".")[0]);
            }
            comboOdemeYontem.DataSource = files;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            var  odemeClass = Assembly.GetAssembly(typeof(Form1)).CreateInstance("OdemeYontemi.OdemeYontemleri."+comboOdemeYontem.Text);
            IOdemeYontem odemeClass2 = (IOdemeYontem)odemeClass;
            Odeme odeme = new Odeme(odemeClass2);
            string message = odeme.odemeYap(Convert.ToInt32(textTutar.Text));
            label3.Text = message;
        }

        private void comboOdemeYontem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}