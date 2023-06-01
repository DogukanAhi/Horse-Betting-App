namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text= "At yarýþý 18 yaþýndan büyüklerin oynayabileceði bir kumar türüdür. \nEðer 18 yaþýndan küçükseniz, oynamanýz kesinlike yasal deðildir. \n At yarýþý bir kumar türü olduðundan kazanç saðlanabileceði gibi çok büyük kayýplar da yaþanabilir.\nLütfen kendi riskinizi alarak oynayýnýz.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }
    }
}