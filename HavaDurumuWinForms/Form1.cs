using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavaDurumuWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCityPanel();
        }

        private void CreateCityPanel()
        {
            // Adana
            Panel panelAdana = new Panel();
            panelAdana.Size = new Size(20, 20);
            panelAdana.Location = new Point(360, 285);
            panelAdana.BackColor = Color.Transparent;
            panelAdana.Cursor = Cursors.Hand;
            panelAdana.Click += async (sender, e) => await GetirHavaDurumu("Adana");
            panel1.Controls.Add(panelAdana);



            // Adıyaman
            Panel panelAdiyaman = new Panel();
            panelAdiyaman.Size = new Size(20, 20);
            panelAdiyaman.Location = new Point(470, 230);
            panelAdiyaman.BackColor = Color.Transparent;
            panelAdiyaman.Cursor = Cursors.Hand;
            panelAdiyaman.Click += async (sender, e) => await GetirHavaDurumu("Adiyaman");
            panel1.Controls.Add(panelAdiyaman);



            // Afyonkarahisar
            Panel panelAfyon = new Panel();
            panelAfyon.Size = new Size(20, 20);
            panelAfyon.Location = new Point(180, 180);
            panelAfyon.BackColor = Color.Transparent;
            panelAfyon.Cursor = Cursors.Hand;
            panelAfyon.Click += async (sender, e) => await GetirHavaDurumu("Afyonkarahisar");
            panel1.Controls.Add(panelAfyon);


            // Ağrı
            Panel panelAgri = new Panel();
            panelAgri.Size = new Size(20, 20);
            panelAgri.Location = new Point(649, 116);
            panelAgri.BackColor = Color.Transparent;
            panelAgri.Cursor = Cursors.Hand;
            panelAgri.Click += async (sender, e) => await GetirHavaDurumu("Agri");
            panel1.Controls.Add(panelAgri);

            // Aksaray
            Panel panelAksaray = new Panel();
            panelAksaray.Size = new Size(20, 20);
            panelAksaray.Location = new Point(305, 210);
            panelAksaray.BackColor = Color.Transparent;
            panelAksaray.Cursor = Cursors.Hand;
            panelAksaray.Click += async (sender, e) => await GetirHavaDurumu("Aksaray");
            panel1.Controls.Add(panelAksaray);


            // Amasya
            Panel panelAmasya = new Panel();
            panelAmasya.Size = new Size(20, 20);
            panelAmasya.Location = new Point(375, 85);
            panelAmasya.BackColor = Color.Transparent;
            panelAmasya.Cursor = Cursors.Hand;
            panelAmasya.Click += async (sender, e) => await GetirHavaDurumu("Amasya");
            panel1.Controls.Add(panelAmasya);

            // Antalya
            Panel panelAntalya = new Panel();
            panelAntalya.Size = new Size(20, 20);
            panelAntalya.Location = new Point(180, 270);
            panelAntalya.BackColor = Color.Transparent;
            panelAntalya.Cursor = Cursors.Hand;
            panelAntalya.Click += async (sender, e) => await GetirHavaDurumu("Antalya");
            panel1.Controls.Add(panelAntalya);

            // Artvin
            Panel panelArtvin = new Panel();
            panelArtvin.Size = new Size(20, 20);
            panelArtvin.Location = new Point(600, 45);
            panelArtvin.BackColor = Color.Transparent;
            panelArtvin.Cursor = Cursors.Hand;
            panelArtvin.Click += async (sender, e) => await GetirHavaDurumu("Artvin");
            panel1.Controls.Add(panelArtvin);


            // Aydın 
            Panel panelAydin = new Panel();
            panelAydin.Size = new Size(20, 20);
            panelAydin.Location = new Point(75, 230);
            panelAydin.BackColor = Color.Transparent;
            panelAydin.Cursor = Cursors.Hand;
            panelAydin.Click += async (sender, e) => await GetirHavaDurumu("Aydin");
            panel1.Controls.Add(panelAydin);


            // İzmir
            Panel panelIzmir = new Panel();
            panelIzmir.Size = new Size(20, 20);
            panelIzmir.Location = new Point(60, 200);
            panelIzmir.BackColor = Color.Transparent;
            panelIzmir.Cursor = Cursors.Hand;
            panelIzmir.Click += async (sender, e) => await GetirHavaDurumu("Izmir");
            panel1.Controls.Add(panelIzmir);

            // Bursa
            Panel panelBursa = new Panel();
            panelBursa.Size = new Size(20, 20);
            panelBursa.Location = new Point(125, 110);
            panelBursa.BackColor = Color.Transparent;
            panelBursa.Cursor = Cursors.Hand;
            panelBursa.Click += async (sender, e) => await GetirHavaDurumu("Bursa");
            panel1.Controls.Add(panelBursa);

            // Trabzon
            Panel panelTrabzon = new Panel();
            panelTrabzon.Size = new Size(20, 20);
            panelTrabzon.Location = new Point(515, 70);
            panelTrabzon.BackColor = Color.Transparent;
            panelTrabzon.Cursor = Cursors.Hand;
            panelTrabzon.Click += async (sender, e) => await GetirHavaDurumu("Trabzon");
            panel1.Controls.Add(panelTrabzon);

            // Rize
            Panel panelRize = new Panel();
            panelRize.Size = new Size(20, 20);
            panelRize.Location = new Point(545, 65);
            panelRize.BackColor = Color.Transparent;
            panelRize.Cursor = Cursors.Hand;
            panelRize.Click += async (sender, e) => await GetirHavaDurumu("Rize");
            panel1.Controls.Add(panelRize);


            // Erzurum
            Panel panelErzurum = new Panel();
            panelErzurum.Size = new Size(20, 20);
            panelErzurum.Location = new Point(575, 110);
            panelErzurum.BackColor = Color.Transparent;
            panelErzurum.Cursor = Cursors.Hand;
            panelErzurum.Click += async (sender, e) => await GetirHavaDurumu("Erzurum");
            panel1.Controls.Add(panelErzurum);

            // Van
            Panel panelVan = new Panel();
            panelVan.Size = new Size(20, 20);
            panelVan.Location = new Point(665, 180);
            panelVan.BackColor = Color.Transparent;
            panelVan.Cursor = Cursors.Hand;
            panelVan.Click += async (sender, e) => await GetirHavaDurumu("Van");
            panel1.Controls.Add(panelVan);

            // Diyarbakır
            Panel panelDiyarbakir = new Panel();
            panelDiyarbakir.Size = new Size(20, 20);
            panelDiyarbakir.Location = new Point(540, 220);
            panelDiyarbakir.BackColor = Color.Transparent;
            panelDiyarbakir.Cursor = Cursors.Hand;
            panelDiyarbakir.Click += async (sender, e) => await GetirHavaDurumu("Diyarbakir");
            panel1.Controls.Add(panelDiyarbakir);

            // Konya
            Panel panelKonya = new Panel();
            panelKonya.Size = new Size(20, 20);
            panelKonya.Location = new Point(250, 220);
            panelKonya.BackColor = Color.Transparent;
            panelKonya.Cursor = Cursors.Hand;
            panelKonya.Click += async (sender, e) => await GetirHavaDurumu("Konya");
            panel1.Controls.Add(panelKonya);


            // Samsun
            Panel panelSamsun = new Panel();
            panelSamsun.Size = new Size(20, 20);
            panelSamsun.Location = new Point(390, 60);
            panelSamsun.BackColor = Color.Transparent;
            panelSamsun.Cursor = Cursors.Hand;
            panelSamsun.Click += async (sender, e) => await GetirHavaDurumu("Samsun");
            panel1.Controls.Add(panelSamsun);

            // Eskişehir
            Panel panelEskisehir = new Panel();
            panelEskisehir.Size = new Size(20, 20);
            panelEskisehir.Location = new Point(190, 130);
            panelEskisehir.BackColor = Color.Transparent;
            panelEskisehir.Cursor = Cursors.Hand;
            panelEskisehir.Click += async (sender, e) => await GetirHavaDurumu("Eskisehir");
            panel1.Controls.Add(panelEskisehir);

            // Kayseri
            Panel panelKayseri = new Panel();
            panelKayseri.Size = new Size(20, 20);
            panelKayseri.Location = new Point(360, 190);
            panelKayseri.BackColor = Color.Transparent;
            panelKayseri.Cursor = Cursors.Hand;
            panelKayseri.Click += async (sender, e) => await GetirHavaDurumu("Kayseri");
            panel1.Controls.Add(panelKayseri);


            // Gaziantep
            Panel panelGaziantep = new Panel();
            panelGaziantep.Size = new Size(20, 20);
            panelGaziantep.Location = new Point(440, 270);
            panelGaziantep.BackColor = Color.Transparent;
            panelGaziantep.Cursor = Cursors.Hand;
            panelGaziantep.Click += async (sender, e) => await GetirHavaDurumu("Gaziantep");
            panel1.Controls.Add(panelGaziantep);


            // Mersin
            Panel panelMersin = new Panel();
            panelMersin.Size = new Size(20, 20);
            panelMersin.Location = new Point(330, 272);
            panelMersin.BackColor = Color.Transparent;
            panelMersin.Cursor = Cursors.Hand;
            panelMersin.Click += async (sender, e) => await GetirHavaDurumu("Mersin");
            panel1.Controls.Add(panelMersin);

            // Şanlıurfa
            Panel panelSanliurfa = new Panel();
            panelSanliurfa.Size = new Size(20, 20);
            panelSanliurfa.Location = new Point(490, 260);
            panelSanliurfa.BackColor = Color.Transparent;
            panelSanliurfa.Cursor = Cursors.Hand;
            panelSanliurfa.Click += async (sender, e) => await GetirHavaDurumu("Sanliurfa");
            panel1.Controls.Add(panelSanliurfa);

            // İstanbul (yaklaşık sol üst kısımda)
            Panel panelIstanbul = new Panel();
            panelIstanbul.Size = new Size(20, 20);
            panelIstanbul.Location = new Point(108, 57); // Yeni konum
            panelIstanbul.BackColor = Color.Transparent;
            panelIstanbul.Cursor = Cursors.Hand;
            panelIstanbul.Click += async (sender, e) => await GetirHavaDurumu("Istanbul");
            panel1.Controls.Add(panelIstanbul);


            // Malatya
            Panel panelMalatya = new Panel();
            panelMalatya.Size = new Size(20, 20);
            panelMalatya.Location = new Point(460, 200);
            panelMalatya.BackColor = Color.Transparent;
            panelMalatya.Cursor = Cursors.Hand;
            panelMalatya.Click += async (sender, e) => await GetirHavaDurumu("Malatya");
            panel1.Controls.Add(panelMalatya);

            // Erzincan
            Panel panelErzincan = new Panel();
            panelErzincan.Size = new Size(20, 20);
            panelErzincan.Location = new Point(510, 130);
            panelErzincan.BackColor = Color.Transparent;
            panelErzincan.Cursor = Cursors.Hand;
            panelErzincan.Click += async (sender, e) => await GetirHavaDurumu("Erzincan");
            panel1.Controls.Add(panelErzincan);

            // Kars
            Panel panelKars = new Panel();
            panelKars.Size = new Size(20, 20);
            panelKars.Location = new Point(640, 75);
            panelKars.BackColor = Color.Transparent;
            panelKars.Cursor = Cursors.Hand;
            panelKars.Click += async (sender, e) => await GetirHavaDurumu("Kars");
            panel1.Controls.Add(panelKars);

            // Sivas
            Panel panelSivas = new Panel();
            panelSivas.Size = new Size(20, 20);
            panelSivas.Location = new Point(415, 130);
            panelSivas.BackColor = Color.Transparent;
            panelSivas.Cursor = Cursors.Hand;
            panelSivas.Click += async (sender, e) => await GetirHavaDurumu("Sivas");
            panel1.Controls.Add(panelSivas);


            // Hatay
            Panel panelHatay = new Panel();
            panelHatay.Size = new Size(20, 20);
            panelHatay.Location = new Point(395, 310);
            panelHatay.BackColor = Color.Transparent;
            panelHatay.Cursor = Cursors.Hand;
            panelHatay.Click += async (sender, e) => await GetirHavaDurumu("Hatay");
            panel1.Controls.Add(panelHatay);

            // Balıkesir
            Panel panelBalikesir = new Panel();
            panelBalikesir.Size = new Size(20, 20);
            panelBalikesir.Location = new Point(80, 130);
            panelBalikesir.BackColor = Color.Transparent;
            panelBalikesir.Cursor = Cursors.Hand;
            panelBalikesir.Click += async (sender, e) => await GetirHavaDurumu("Balikesir");
            panel1.Controls.Add(panelBalikesir);

            // Bartın
            Panel panelBartin = new Panel();
            panelBartin.Size = new Size(20, 20);
            panelBartin.Location = new Point(250, 35);
            panelBartin.BackColor = Color.Transparent;
            panelBartin.Cursor = Cursors.Hand;
            panelBartin.Click += async (sender, e) => await GetirHavaDurumu("Bartin");
            panel1.Controls.Add(panelBartin);

            // Ankara (orta kısımda)
            Panel panelAnkara = new Panel();
            panelAnkara.Size = new Size(20, 20);
            panelAnkara.Location = new Point(260, 120); // Yeni konum
            panelAnkara.BackColor = Color.Transparent;
            panelAnkara.Cursor = Cursors.Hand;
            panelAnkara.Click += async (sender, e) => await GetirHavaDurumu("Ankara");
            panel1.Controls.Add(panelAnkara);

            // Batman
            Panel panelBatman = new Panel();
            panelBatman.Size = new Size(20, 20);
            panelBatman.Location = new Point(585, 210);
            panelBatman.BackColor = Color.Transparent;
            panelBatman.Cursor = Cursors.Hand;
            panelBatman.Click += async (sender, e) => await GetirHavaDurumu("Batman");
            panel1.Controls.Add(panelBatman);

            // Bayburt
            Panel panelBayburt = new Panel();
            panelBayburt.Size = new Size(20, 20);
            panelBayburt.Location = new Point(540, 100);
            panelBayburt.BackColor = Color.Transparent;
            panelBayburt.Cursor = Cursors.Hand;
            panelBayburt.Click += async (sender, e) => await GetirHavaDurumu("Bayburt");
            panel1.Controls.Add(panelBayburt);


            // Bilecik
            Panel panelBilecik = new Panel();
            panelBilecik.Size = new Size(20, 20);
            panelBilecik.Location = new Point(160, 120);
            panelBilecik.BackColor = Color.Transparent;
            panelBilecik.Cursor = Cursors.Hand;
            panelBilecik.Click += async (sender, e) => await GetirHavaDurumu("Bilecik");
            panel1.Controls.Add(panelBilecik);

            // Bingöl
            Panel panelBingol = new Panel();
            panelBingol.Size = new Size(20, 20);
            panelBingol.Location = new Point(560, 160);
            panelBingol.BackColor = Color.Transparent;
            panelBingol.Cursor = Cursors.Hand;
            panelBingol.Click += async (sender, e) => await GetirHavaDurumu("Bingol");
            panel1.Controls.Add(panelBingol);

            // Bitlis
            Panel panelBitlis = new Panel();
            panelBitlis.Size = new Size(20, 20);
            panelBitlis.Location = new Point(620, 190);
            panelBitlis.BackColor = Color.Transparent;
            panelBitlis.Cursor = Cursors.Hand;
            panelBitlis.Click += async (sender, e) => await GetirHavaDurumu("Bitlis");
            panel1.Controls.Add(panelBitlis);


            // Bolu
            Panel panelBolu = new Panel();
            panelBolu.Size = new Size(20, 20);
            panelBolu.Location = new Point(220, 90);
            panelBolu.BackColor = Color.Transparent;
            panelBolu.Cursor = Cursors.Hand;
            panelBolu.Click += async (sender, e) => await GetirHavaDurumu("Bolu");
            panel1.Controls.Add(panelBolu);

            // Çanakkale
            Panel panelCanakkale = new Panel();
            panelCanakkale.Size = new Size(20, 20);
            panelCanakkale.Location = new Point(40, 110);
            panelCanakkale.BackColor = Color.Transparent;
            panelCanakkale.Cursor = Cursors.Hand;
            panelCanakkale.Click += async (sender, e) => await GetirHavaDurumu("Canakkale");
            panel1.Controls.Add(panelCanakkale);


            // Çankırı
            Panel panelCankiri = new Panel();
            panelCankiri.Size = new Size(20, 20);
            panelCankiri.Location = new Point(290, 90);
            panelCankiri.BackColor = Color.Transparent;
            panelCankiri.Cursor = Cursors.Hand;
            panelCankiri.Click += async (sender, e) => await GetirHavaDurumu("Cankiri");
            panel1.Controls.Add(panelCankiri);

            // Çorum
            Panel panelCorum = new Panel();
            panelCorum.Size = new Size(20, 20);
            panelCorum.Location = new Point(335, 90);
            panelCorum.BackColor = Color.Transparent;
            panelCorum.Cursor = Cursors.Hand;
            panelCorum.Click += async (sender, e) => await GetirHavaDurumu("Corum");
            panel1.Controls.Add(panelCorum);

            // Denizli
            Panel panelDenizli = new Panel();
            panelDenizli.Size = new Size(20, 20);
            panelDenizli.Location = new Point(120, 230);
            panelDenizli.BackColor = Color.Transparent;
            panelDenizli.Cursor = Cursors.Hand;
            panelDenizli.Click += async (sender, e) => await GetirHavaDurumu("Denizli");
            panel1.Controls.Add(panelDenizli);

            // Düzce
            Panel panelDuzce = new Panel();
            panelDuzce.Size = new Size(20, 20);
            panelDuzce.Location = new Point(202, 75);
            panelDuzce.BackColor = Color.Transparent;
            panelDuzce.Cursor = Cursors.Hand;
            panelDuzce.Click += async (sender, e) => await GetirHavaDurumu("Duzce");
            panel1.Controls.Add(panelDuzce);

            // Edirne
            Panel panelEdirne = new Panel();
            panelEdirne.Size = new Size(20, 20);
            panelEdirne.Location = new Point(40, 20);
            panelEdirne.BackColor = Color.Transparent;
            panelEdirne.Cursor = Cursors.Hand;
            panelEdirne.Click += async (sender, e) => await GetirHavaDurumu("Edirne");
            panel1.Controls.Add(panelEdirne);

            // Elazığ
            Panel panelElazig = new Panel();
            panelElazig.Size = new Size(20, 20);
            panelElazig.Location = new Point(500, 180);
            panelElazig.BackColor = Color.Transparent;
            panelElazig.Cursor = Cursors.Hand;
            panelElazig.Click += async (sender, e) => await GetirHavaDurumu("Elazig");
            panel1.Controls.Add(panelElazig);


            // Giresun
            Panel panelGiresun = new Panel();
            panelGiresun.Size = new Size(20, 20);
            panelGiresun.Location = new Point(470, 70);
            panelGiresun.BackColor = Color.Transparent;
            panelGiresun.Cursor = Cursors.Hand;
            panelGiresun.Click += async (sender, e) => await GetirHavaDurumu("Giresun");
            panel1.Controls.Add(panelGiresun);

            // Gümüşhane *****
            Panel panelGumushane = new Panel();
            panelGumushane.Size = new Size(20, 20);
            panelGumushane.Location = new Point(505, 92);
            panelGumushane.BackColor = Color.Transparent;
            panelGumushane.Cursor = Cursors.Hand;
            panelGumushane.Click += async (sender, e) => await GetirHavaDurumu("Gümüşhane");
            panel1.Controls.Add(panelGumushane);

            // Hakkari
            Panel panelHakkari = new Panel();
            panelHakkari.Size = new Size(20, 20);
            panelHakkari.Location = new Point(680, 230);
            panelHakkari.BackColor = Color.Transparent;
            panelHakkari.Cursor = Cursors.Hand;
            panelHakkari.Click += async (sender, e) => await GetirHavaDurumu("Hakkari");
            panel1.Controls.Add(panelHakkari);


            // Iğdır
            Panel panelIgdir = new Panel();
            panelIgdir.Size = new Size(20, 20);
            panelIgdir.Location = new Point(675, 100);
            panelIgdir.BackColor = Color.Transparent;
            panelIgdir.Cursor = Cursors.Hand;
            panelIgdir.Click += async (sender, e) => await GetirHavaDurumu("Igdir");
            panel1.Controls.Add(panelIgdir);

            // Isparta
            Panel panelIsparta = new Panel();
            panelIsparta.Size = new Size(20, 20);
            panelIsparta.Location = new Point(190, 230);
            panelIsparta.BackColor = Color.Transparent;
            panelIsparta.Cursor = Cursors.Hand;
            panelIsparta.Click += async (sender, e) => await GetirHavaDurumu("Isparta");
            panel1.Controls.Add(panelIsparta);

            // Kırklareli
            Panel panelKirklareli = new Panel();
            panelKirklareli.Size = new Size(20, 20);
            panelKirklareli.Location = new Point(70, 23);
            panelKirklareli.BackColor = Color.Transparent;
            panelKirklareli.Cursor = Cursors.Hand;
            panelKirklareli.Click += async (s, e) => await GetirHavaDurumu("Kirklareli");
            panel1.Controls.Add(panelKirklareli);

            // Tekirdağ
            Panel panelTekirdag = new Panel();
            panelTekirdag.Size = new Size(20, 20);
            panelTekirdag.Location = new Point(70, 60);
            panelTekirdag.BackColor = Color.Transparent;
            panelTekirdag.Cursor = Cursors.Hand;
            panelTekirdag.Click += async (s, e) => await GetirHavaDurumu("Tekirdag");
            panel1.Controls.Add(panelTekirdag);

            // Manisa
            Panel panelManisa = new Panel();
            panelManisa.Size = new Size(20, 20);
            panelManisa.Location = new Point(70, 180);
            panelManisa.BackColor = Color.Transparent;
            panelManisa.Cursor = Cursors.Hand;
            panelManisa.Click += async (s, e) => await GetirHavaDurumu("Manisa");
            panel1.Controls.Add(panelManisa);

            // Kütahya
            Panel panelKutahya = new Panel();
            panelKutahya.Size = new Size(20, 20);
            panelKutahya.Location = new Point(150, 150);
            panelKutahya.BackColor = Color.Transparent;
            panelKutahya.Cursor = Cursors.Hand;
            panelKutahya.Click += async (s, e) => await GetirHavaDurumu("Kutahya");
            panel1.Controls.Add(panelKutahya);

            // Muğla
            Panel panelMugla = new Panel();
            panelMugla.Size = new Size(20, 20);
            panelMugla.Location = new Point(83, 255);
            panelMugla.BackColor = Color.Transparent;
            panelMugla.Cursor = Cursors.Hand;
            panelMugla.Click += async (s, e) => await GetirHavaDurumu("Mugla");
            panel1.Controls.Add(panelMugla);

            // Kocaeli
            Panel panelKocaeli = new Panel();
            panelKocaeli.Size = new Size(20, 20);
            panelKocaeli.Location = new Point(148, 70);
            panelKocaeli.BackColor = Color.Transparent;
            panelKocaeli.Cursor = Cursors.Hand;
            panelKocaeli.Click += async (s, e) => await GetirHavaDurumu("Kocaeli");
            panel1.Controls.Add(panelKocaeli);

            // Sakarya
            Panel panelSakarya = new Panel();
            panelSakarya.Size = new Size(20, 20);
            panelSakarya.Location = new Point(177, 80);
            panelSakarya.BackColor = Color.Transparent;
            panelSakarya.Cursor = Cursors.Hand;
            panelSakarya.Click += async (s, e) => await GetirHavaDurumu("Sakarya");
            panel1.Controls.Add(panelSakarya);

            // Uşak
            Panel panelUsak = new Panel();
            panelUsak.Size = new Size(20, 20);
            panelUsak.Location = new Point(130, 183);
            panelUsak.BackColor = Color.Transparent;
            panelUsak.Cursor = Cursors.Hand;
            panelUsak.Click += async (s, e) => await GetirHavaDurumu("Usak");
            panel1.Controls.Add(panelUsak);

            // Burdur
            Panel panelBurdur = new Panel();
            panelBurdur.Size = new Size(20, 20);
            panelBurdur.Location = new Point(157, 240);
            panelBurdur.BackColor = Color.Transparent;
            panelBurdur.Cursor = Cursors.Hand;
            panelBurdur.Click += async (s, e) => await GetirHavaDurumu("Burdur");
            panel1.Controls.Add(panelBurdur);

            // Zonguldak
            Panel panelZonguldak = new Panel();
            panelZonguldak.Size = new Size(20, 20);
            panelZonguldak.Location = new Point(223, 50);
            panelZonguldak.BackColor = Color.Transparent;
            panelZonguldak.Cursor = Cursors.Hand;
            panelZonguldak.Click += async (s, e) => await GetirHavaDurumu("Zonguldak");
            panel1.Controls.Add(panelZonguldak);

            // Karabük
            Panel panelKarabuk = new Panel();
            panelKarabuk.Size = new Size(20, 20);
            panelKarabuk.Location = new Point(250, 60);
            panelKarabuk.BackColor = Color.Transparent;
            panelKarabuk.Cursor = Cursors.Hand;
            panelKarabuk.Click += async (s, e) => await GetirHavaDurumu("Karabuk");
            panel1.Controls.Add(panelKarabuk);

            // Kastamonu
            Panel panelKastamonu = new Panel();
            panelKastamonu.Size = new Size(20, 20);
            panelKastamonu.Location = new Point(300, 50);
            panelKastamonu.BackColor = Color.Transparent;
            panelKastamonu.Cursor = Cursors.Hand;
            panelKastamonu.Click += async (s, e) => await GetirHavaDurumu("Kastamonu");
            panel1.Controls.Add(panelKastamonu);

            // Sinop
            Panel panelSinop = new Panel();
            panelSinop.Size = new Size(20, 20);
            panelSinop.Location = new Point(330, 30);
            panelSinop.BackColor = Color.Transparent;
            panelSinop.Cursor = Cursors.Hand;
            panelSinop.Click += async (s, e) => await GetirHavaDurumu("Sinop");
            panel1.Controls.Add(panelSinop);

            // Kırıkkale
            Panel panelKirikkale = new Panel();
            panelKirikkale.Size = new Size(20, 20);
            panelKirikkale.Location = new Point(295, 120);
            panelKirikkale.BackColor = Color.Transparent;
            panelKirikkale.Cursor = Cursors.Hand;
            panelKirikkale.Click += async (s, e) => await GetirHavaDurumu("Kirikkale");
            panel1.Controls.Add(panelKirikkale);

            // Yozgat
            Panel panelYozgat = new Panel();
            panelYozgat.Size = new Size(20, 20);
            panelYozgat.Location = new Point(340, 135);
            panelYozgat.BackColor = Color.Transparent;
            panelYozgat.Cursor = Cursors.Hand;
            panelYozgat.Click += async (s, e) => await GetirHavaDurumu("Yozgat");
            panel1.Controls.Add(panelYozgat);

            // Kırşehir
            Panel panelKirsehir = new Panel();
            panelKirsehir.Size = new Size(20, 20);
            panelKirsehir.Location = new Point(310, 160);
            panelKirsehir.BackColor = Color.Transparent;
            panelKirsehir.Cursor = Cursors.Hand;
            panelKirsehir.Click += async (s, e) => await GetirHavaDurumu("Kirsehir");
            panel1.Controls.Add(panelKirsehir);


            // Nevşehir
            Panel panelNevsehir = new Panel();
            panelNevsehir.Size = new Size(20, 20);
            panelNevsehir.Location = new Point(330, 185);
            panelNevsehir.BackColor = Color.Transparent;
            panelNevsehir.Cursor = Cursors.Hand;
            panelNevsehir.Click += async (s, e) => await GetirHavaDurumu("Nevsehir");
            panel1.Controls.Add(panelNevsehir);

            // Niğde
            Panel panelNigde = new Panel();
            panelNigde.Size = new Size(20, 20);
            panelNigde.Location = new Point(330, 220);
            panelNigde.BackColor = Color.Transparent;
            panelNigde.Cursor = Cursors.Hand;
            panelNigde.Click += async (s, e) => await GetirHavaDurumu("Nigde");
            panel1.Controls.Add(panelNigde);

            // Karaman
            Panel panelKaraman = new Panel();
            panelKaraman.Size = new Size(20, 20);
            panelKaraman.Location = new Point(275, 260);
            panelKaraman.BackColor = Color.Transparent;
            panelKaraman.Cursor = Cursors.Hand;
            panelKaraman.Click += async (s, e) => await GetirHavaDurumu("Karaman");
            panel1.Controls.Add(panelKaraman);

            // Tokat
            Panel panelTokat = new Panel();
            panelTokat.Size = new Size(20, 20);
            panelTokat.Location = new Point(400, 100);
            panelTokat.BackColor = Color.Transparent;
            panelTokat.Cursor = Cursors.Hand;
            panelTokat.Click += async (s, e) => await GetirHavaDurumu("Tokat");
            panel1.Controls.Add(panelTokat);

            // Ordu
            Panel panelOrdu = new Panel();
            panelOrdu.Size = new Size(20, 20);
            panelOrdu.Location = new Point(440, 80);
            panelOrdu.BackColor = Color.Transparent;
            panelOrdu.Cursor = Cursors.Hand;
            panelOrdu.Click += async (s, e) => await GetirHavaDurumu("Ordu");
            panel1.Controls.Add(panelOrdu);

            // Kahramanmaraş
            Panel panelKahramanmaras = new Panel();
            panelKahramanmaras.Size = new Size(20, 20);
            panelKahramanmaras.Location = new Point(425, 240);
            panelKahramanmaras.BackColor = Color.Transparent;
            panelKahramanmaras.Cursor = Cursors.Hand;
            panelKahramanmaras.Click += async (s, e) => await GetirHavaDurumu("Kahramanmaras");
            panel1.Controls.Add(panelKahramanmaras);

            // Osmaniye
            Panel panelOsmaniye = new Panel();
            panelOsmaniye.Size = new Size(20, 20);
            panelOsmaniye.Location = new Point(400, 270);
            panelOsmaniye.BackColor = Color.Transparent;
            panelOsmaniye.Cursor = Cursors.Hand;
            panelOsmaniye.Click += async (s, e) => await GetirHavaDurumu("Osmaniye");
            panel1.Controls.Add(panelOsmaniye);

            // Kilis
            Panel panelKilis = new Panel();
            panelKilis.Size = new Size(12, 12);
            panelKilis.Location = new Point(430, 285);
            panelKilis.BackColor = Color.Transparent;
            panelKilis.Cursor = Cursors.Hand;
            panelKilis.Click += async (s, e) => await GetirHavaDurumu("Kilis");
            panel1.Controls.Add(panelKilis);

            // Mardin
            Panel panelMardin = new Panel();
            panelMardin.Size = new Size(20, 20);
            panelMardin.Location = new Point(567, 248);
            panelMardin.BackColor = Color.Transparent;
            panelMardin.Cursor = Cursors.Hand;
            panelMardin.Click += async (s, e) => await GetirHavaDurumu("Mardin");
            panel1.Controls.Add(panelMardin);

            // Muş
            Panel panelMus = new Panel();
            panelMus.Size = new Size(20, 20);
            panelMus.Location = new Point(595, 170);
            panelMus.BackColor = Color.Transparent;
            panelMus.Cursor = Cursors.Hand;
            panelMus.Click += async (s, e) => await GetirHavaDurumu("Mus");
            panel1.Controls.Add(panelMus);

            // Tunceli
            Panel panelTunceli = new Panel();
            panelTunceli.Size = new Size(20, 20);
            panelTunceli.Location = new Point(510, 155);
            panelTunceli.BackColor = Color.Transparent;
            panelTunceli.Cursor = Cursors.Hand;
            panelTunceli.Click += async (s, e) => await GetirHavaDurumu("Tunceli");
            panel1.Controls.Add(panelTunceli);

            // Şırnak
            Panel panelSirnak = new Panel();
            panelSirnak.Size = new Size(20, 20);
            panelSirnak.Location = new Point(625, 240);
            panelSirnak.BackColor = Color.Transparent;
            panelSirnak.Cursor = Cursors.Hand;
            panelSirnak.Click += async (s, e) => await GetirHavaDurumu("Sirnak");
            panel1.Controls.Add(panelSirnak);

            // Siirt
            Panel panelSiirt = new Panel();
            panelSiirt.Size = new Size(20, 20);
            panelSiirt.Location = new Point(615, 210);
            panelSiirt.BackColor = Color.Transparent;
            panelSiirt.Cursor = Cursors.Hand;
            panelSiirt.Click += async (s, e) => await GetirHavaDurumu("Siirt");
            panel1.Controls.Add(panelSiirt);
        }

        private async Task GetirHavaDurumu(string sehir)
        {
            string apiKey = "9e3c9222e7938c80dbb406c9da344297"; // OpenWeatherMap API Key
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={sehir}&appid={apiKey}&units=metric&lang=tr";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        JObject veri = JObject.Parse(json);

                        string durum = veri["weather"][0]["description"].ToString();
                        string derece = veri["main"]["temp"].ToString();
                        string nem = veri["main"]["humidity"].ToString();
                        string ruzgar = veri["wind"]["speed"].ToString();
                        string ulke = veri["sys"]["country"].ToString();

                        MessageBox.Show(
                            $"🗺️ Şehir: {sehir}, {ulke}\n🌤️ Hava Durumu: {durum}\n🌡️ Sıcaklık: {derece}°C\n💧 Nem: {nem}%\n🌬️ Rüzgar: {ruzgar} m/s",
                            "Hava Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("❌ Hava durumu verisi alınamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠️ Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
