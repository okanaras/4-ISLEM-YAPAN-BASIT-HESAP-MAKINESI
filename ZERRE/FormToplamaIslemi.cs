namespace ZERRE
{
	public partial class FormToplamaIslemi : Form
	{
		public FormToplamaIslemi()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			labelToplam.Text = "";
			decimal sayi1, sayi2;
			sayi1 = Convert.ToDecimal(textBoxSayi1.Text);
			sayi2 = Convert.ToDecimal(textBoxSayi2.Text);

			decimal toplam = sayi1 + sayi2;
			//labelToplam.Text = "Toplam= " + toplam;
			textBoxSayi1.Text = "";
			textBoxSayi2.Text = "";
			MessageBox.Show("Ýnsan Ne Ýle Yaþar?             \n\nTOPLAM = " + toplam);
		}

		private void buttonTemizle_Click(object sender, EventArgs e)
		{
			textBoxSayi1.Text = " ";
			textBoxSayi2.Text = " ";
		}

		private void btnCikar_Click(object sender, EventArgs e)
		{

			labelToplam.Text = "";
			decimal sayi1, sayi2;
			sayi1 = Convert.ToDecimal(textBoxSayi1.Text);
			sayi2 = Convert.ToDecimal(textBoxSayi2.Text);

			decimal fark = sayi1 - sayi2;
			//labelToplam.Text = "Toplam= " + toplam;
			textBoxSayi1.Text = "";
			textBoxSayi2.Text = "";
			MessageBox.Show("Ýnsan Ne Ýle Yaþar?             \n\nFARK = " + fark);
		}

		private void btnCarp_Click(object sender, EventArgs e)
		{

			labelToplam.Text = "";
			decimal sayi1, sayi2;
			sayi1 = Convert.ToDecimal(textBoxSayi1.Text);
			sayi2 = Convert.ToDecimal(textBoxSayi2.Text);

			decimal carpim = sayi1 * sayi2;
			//labelToplam.Text = "Toplam= " + toplam;
			textBoxSayi1.Text = "";
			textBoxSayi2.Text = "";
			MessageBox.Show("Ýnsan Ne Ýle Yaþar?             \n\nCARPIM= " + carpim);
		}

		private void btnBol_Click(object sender, EventArgs e)
		{

			labelToplam.Text = "";
			decimal sayi1, sayi2;
			sayi1 = Convert.ToDecimal(textBoxSayi1.Text);
			sayi2 = Convert.ToDecimal(textBoxSayi2.Text);

			decimal bolum = sayi1 / sayi2;
			//labelToplam.Text = "Toplam= " + toplam;
			textBoxSayi1.Text = "";
			textBoxSayi2.Text = "";
			MessageBox.Show("Ýnsan Ne Ýle Yaþar?             \n\nBOLUM = " + bolum);
		}
	}
}


