namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text= "At yar��� 18 ya��ndan b�y�klerin oynayabilece�i bir kumar t�r�d�r. \nE�er 18 ya��ndan k���kseniz, oynaman�z kesinlike yasal de�ildir. \n At yar��� bir kumar t�r� oldu�undan kazan� sa�lanabilece�i gibi �ok b�y�k kay�plar da ya�anabilir.\nL�tfen kendi riskinizi alarak oynay�n�z.";
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