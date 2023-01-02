using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Final_Proje
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            this.Text = string.Empty;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MysqlBaglantı baglantı = new MysqlBaglantı();
            baglantı.BaglantıAc();
            kur();
        }
        private void AktifButton(Object btnSender ,Color color)
        {
            
            if (btnSender != null)
            {
                if (currentButton !=(Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel3.BackColor = color;
                    panel2.BackColor = color;
                    panel1.BackColor = color;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 120, 215, 255);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
           
            activeForm = childForm;
            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void tikla(object sender, EventArgs e)
        {
            MessageBox.Show(sender.GetType().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AktifButton(button1, Color.FromArgb(0, 168, 204));
            OpenChildForm(new Formlar.Musteriler(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AktifButton(button2, Color.FromArgb(12, 123, 147));
            OpenChildForm(new Formlar.Araclar(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AktifButton(button3, Color.FromArgb(39, 73, 109));
            OpenChildForm(new Formlar.Sigortalar(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AktifButton(button4, Color.FromArgb(20, 40, 80));
            OpenChildForm(new Formlar.Filolar(), sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AktifButton(button5, Color.FromArgb(20, 40, 60));
            OpenChildForm(new Formlar.Grafikler(), sender);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            AktifButton(button5, Color.FromArgb(20, 40, 40));
            OpenChildForm(new Formlar.İslem(), sender);
        }
        public void kur()
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            label3.Text = string.Format("Tarih {0} USD Satış; {1}", tarih.ToShortDateString(), USD);

            string EURO2 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteBuying").InnerXml;
            label4.Text = string.Format("Tarih {0} EURO Alış; {1}", tarih.ToShortDateString(), EURO2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AktifButton(button5, Color.FromArgb(20, 40, 30));
            OpenChildForm(new Formlar.parcaislem(), sender);
        }
    }
}
