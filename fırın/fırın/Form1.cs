namespace fırın
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        olustur urunolustur = new olustur();
        int secilen_index = 0;

        public object G_txtSahibi { get; private set; }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kayıtlar urun = new kayıtlar();
            urun.ismi = textBox1.Text;
            urun.numarası = textBox2.Text;
            urun.dukkan_ismi = textBox3.Text;
            urun.turu = textBox4.Text;
            urun.adet = Convert.ToInt32(textBox5.Text);
            urun.fiyat = Convert.ToInt32(textBox6.Text);
            urun.tarih = textBox7.Text;


            urunolustur.yeniKayit(urun);
            var source = new BindingSource();
            source.DataSource = urunolustur.ekmek;
            dataGridView1.DataSource = source;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            urunolustur.kayitSil(secilen_index);
            dataGridView1.Refresh();
            var source = new BindingSource();
            source.DataSource = urunolustur.ekmek;
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            groupBox1.Enabled = true;



            secilen_index = e.RowIndex;
            kayıtlar secilenUrun = urunolustur.ekmek[secilen_index];
            textBox8.Text = secilenUrun.ismi.ToString();
            textBox9.Text = secilenUrun.numarası.ToString();
            textBox10.Text = secilenUrun.dukkan_ismi;
            textBox11.Text = secilenUrun.turu;
            textBox12.Text = secilenUrun.adet.ToString();
            textBox12.Text = secilenUrun.fiyat.ToString();
            textBox14.Text = secilenUrun.tarih.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kayıtlar urungüncelleme = new kayıtlar();
            urungüncelleme.ismi = textBox8.Text;
            urungüncelleme.numarası = textBox9.Text;
            urungüncelleme.dukkan_ismi = textBox10.Text;
            urungüncelleme.turu = textBox11.Text;
            urungüncelleme.adet = Int32.Parse(textBox12.Text);
            urungüncelleme.fiyat = Convert.ToInt32(textBox12.Text);

            urungüncelleme.tarih = textBox14.Text;


            urunolustur.kayitGüncelleme(secilen_index, urungüncelleme);
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(textBox15.Text);
            sayi2 = Convert.ToInt32(textBox16.Text);
            toplam = sayi1 + sayi2;
            label16.Text = " " + toplam;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, cıkar;
            sayi1 = Convert.ToInt32(textBox15.Text);
            sayi2 = Convert.ToInt32(textBox16.Text);
            cıkar = sayi1 - sayi2;
            label16.Text = " " + cıkar;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, carp;
            sayi1 = Convert.ToInt32(textBox15.Text);
            sayi2 = Convert.ToInt32(textBox16.Text);
            carp = sayi1 * sayi2;
            label16.Text = " " + carp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, bol;
            sayi1 = Convert.ToInt32(textBox15.Text);
            sayi2 = Convert.ToInt32(textBox16.Text);
            bol = sayi1 / sayi2;
            label16.Text = " " + bol;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
