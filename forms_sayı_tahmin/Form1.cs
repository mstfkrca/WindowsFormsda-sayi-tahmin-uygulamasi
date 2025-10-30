using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace forms_sayı_tahmin
{
    public partial class Form1 : Form
    {
        int tahminsırası = 1; //listbox için tahmin sırası
        int rastgelesayi; //rastgele sayı
        int kalanhak = 10; //başlangıç hakkı
        Random rnd = new Random(); //rastgele sayı üretiyoruz
        public Form1()
        {
            InitializeComponent();



        }

        private void txtboxtahmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btntahminet_Click(object sender, EventArgs e)
        {
            //Kullanıcının tahminini alıyoruz
            string tahmin = txtboxtahmin.Text;

            //tahmin kontrolü
            if (tahmin.Length != 3 || !int.TryParse(tahmin, out int sayi))
            {
                MessageBox.Show("Lütfen 3 haneli bir sayı giriniz.");
                return; //geçersiz giriş
            }

            //karakter karşılaştırmak için rastgele sayıyı stringe çevirmemiz gerekir
            string rastgele = rastgelesayi.ToString();





            // 0 kullanılmadı 1 kullanıldı demek
            int[] rastgeleKullanildi = new int[3] { 0, 0, 0 };
            int[] tahminKullanildi = new int[3] { 0, 0, 0 };

            // sonuç renklerini saklamak için bir dizi
            // başlangıçta hepsini beyaz olarak ayarlıyoruz
            Color[] etiketRenkleri = new Color[3] { Color.White, Color.White, Color.White };

            // rakam ve yeri doğru olanları (YEŞİL) bulma
            for (int i = 0; i < 3; i++)
            {
                if (tahmin[i] == rastgele[i])
                {
                    etiketRenkleri[i] = Color.Green;
                    rastgeleKullanildi[i] = 1;   // 1 olarak işaretle
                    tahminKullanildi[i] = 1;     // 1 olarak işaretle
                }
            }

            // rakam doğru yeri yanlış olanları (TURUNCU) bulma
            for (int i = 0; i < 3; i++)
            {
                // Bu rakam zaten yeşil olarak bulunduysa bu adımı atla
                if (tahminKullanildi[i] == 1) continue;

                for (int j = 0; j < 3; j++) // rastgele sayıdaki her rakam için 
                {
                    // zaten yeşilse veya rakamlar eşleşmiyorsa j döngüsüne devam et

                    if (rastgeleKullanildi[j] == 1 || tahmin[i] != rastgele[j])
                    {
                        continue;
                    }

                    // eşleşme bulundu ve ikisi de daha önce kullanılmadı
                    etiketRenkleri[i] = Color.Orange;
                    rastgeleKullanildi[j] = 1; // 1 olarak işaretle

                    // bu tahmin rakamı i için bir eşleşme bulduk
                    break;
                }
            }

            // labellara yansıtıyoruz   
            label1.BackColor = etiketRenkleri[0];
            label2.BackColor = etiketRenkleri[1];
            label3.BackColor = etiketRenkleri[2];




            //listboxa geçmişi ekle
            listboxgeçmiş.Items.Add(tahminsırası + ". tahmin: " + tahmin);
            tahminsırası++;

            kalanhak--; //hakkı azalt
            lblkalanhak.Text = "Kalan Hak: " + kalanhak.ToString(); //label güncelle

            if (tahmin == rastgele)
            {
                MessageBox.Show("Tebrikler! Doğru tahmin ettiniz: " + rastgelesayi.ToString());
                btntahminet.Enabled = false; //butonu devre dışı bırak
            }
            else if (kalanhak == 0)
            {
                MessageBox.Show("Hakkınız bitti! Doğru sayı: " + rastgelesayi.ToString());
                btntahminet.Enabled = false; //butonu devre dışı bırak
            }

            txtboxtahmin.Clear(); //tahmin kutusunu boşalt

            // imleci tekrar tahmin kutusuna getirir
            txtboxtahmin.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rastgelesayi = rnd.Next(100, 1000); //100-999 arası rastgele sayı üretir
            lblkalanhak.Text = "Kalan Hak: " + kalanhak.ToString(); //başlangıç hakkını göster

        }

        private void lblkalanhak_Click(object sender, EventArgs e)
        {

        }
    }
}







