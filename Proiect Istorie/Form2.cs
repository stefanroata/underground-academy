using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect_Istorie
{
    public partial class Form2 : Proiect_Istorie.Form1
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        string[] a = { "Gheorghe Gheorghiu-Dej s-a născut pe data de 8 noiembrie 1901 in Bârlad şi s-a stins din viaţă pe 19 martie 1965 la Bucureşti. El a fost electrician şi om politic comunist; şef al statului ca preşedinte al Consiliului de Stat în perioada 21 martie 1961-19 martie 1965); secretar general din 1 octombrie 1955, prim-secretar al CC al PCR/PMR (21 octombrie 1945- l9 martie 1965); preşedinte al Consiliului de Miniştri (2 iunie 1952- 3 octombrie 1955).  Născut în familia unui muncitor sărac, urmează cursuri elementare, apoi profesionale, devenind electrician. In 1922 se angajează ca tehnician electric la Atelierele CFR din Galaţi. Din cauza propagandei comuniste pe care o desfăşoară după intrarea sa în PCR (1930), este transferat, în perioada 15 august 1931-9 aprilie 1932, în oraşul ardelean Dej, toponim adăugat numelui său, mai târziu. ",
        "In 1933, când devine membru al CC al PCdR, este arestat pentru implicarea în organizarea grevei de la Atelierele Griviţa. Condamnat la 12 ani de muncă silnică, execută 11 ani în închisorile Jilava, Văcăreşti, Craiova, Ocnele Mari, Aiud, Doftana, Caransebeş şi în lagărul de la Târgu-Jiu, unde devine liderul deţinuţilor comunişti. La Târgu-Jiu este închis în aceeaşi celulă cu Nicolae Ceauşescu, al cărui mentor politic va fi. Cu două săptămâni înainte de 23 august 1944 reuşeşte să evadeze (8/9 august), cu sprijinul avocatului comunist Ion Gheorghe Maurer, devenit ulterior colaborator apropiat. Ajunge în Bucureşti la 26 august 1944, când îşi începe ascensiunea politică, beneficiind din plin de alianţa dintre România şi URSS, inaugurată la 23 august 1944. Participă la mitingul sindicatelor (24 septembrie 1944), unde se pronunţă pentru demisia guvernului Sănătescu, apoi se numără printre principalii iniţiatori ai campaniei de răsturnare a guvernului Rădescu, deşi se afla printre membrii acestuia (ministru al Comunicaţiilor, 4 noiembrie 1944-28 februarie 1945). Este ales secretar general al PCR la 21 octombrie 1945, unii istorici punând acest succes pe seama faptului că era singurul etnic român din CC. ",
        "Până în 1952 împarte puterea în partid cu membrii facţiunii moscovite în frunte cu Ana Pauker, liderul neoficial al partidului, care s-a bucurat multă vreme de sprijinul lui Stalin. In 1952, profitând de căderea în dizgraţie a evreilor în faţa liderului sovietic (în urma aşa-numitului complot al halatelor albe), înlătură (1952) de la conducerea partidului, apoi din partid, pe membrii facţiunii moscovite (Ana Pauker, Vaşsle Luca, Teohari Georgescu ş.a.), majoritatea evrei, şi grupul Miron Constantinescu - Iosif Chisinevschi (partizan al liniei Hruşciov) in 1957, rămânând liderul de necontestat al partidului. Are o contribuţie esenţială la sovietizarea României, atât ca lider al partidului, cât şi ca demnitar: ministru al Comunicaţiilor şi Lucrărilor Publice (6 martie 1945-29 noiembrie 1946), al Industriei şi Comerţului (29 noiembrie 1946-13 aprilie 1948) în guvernul Petru Groza; preşedinte al Consiliului Economic Superior (13 aprilie 1948-21 iunie 1952), al Comisiei pentru Redresare Economică şi Stabilizare Monetară (1947-1948) şi al Comitetului de Stat al Planificării (9 martie 1948-22 aprilie 1949); deputat de Bucureşti (1946-1965). Simţind că guvernul oferă pârghii importante pentru controlul puterii, preia preşedinţia Consiliului de Miniştri (1952-1955). Membru al Prezidiului MAN (4 octombrie 1955-25 martie 1961) şi preşedinte al Consiliului de Stat din 1961 până la moartea sa, funcţie ce echivala cu aceea de şef al statului.",
        "Joacă un rol esenţial în toate marile evenimente care au dus la instituirea regimului comunist: declanşarea campaniei de lichidare a elitei sociale interbelice, falsificarea alegerilor din 1946, abdicarea regelui Mihai (30 decembrie 1947), epurările din Administraţie Justiţie, Poliţie, Armată, naţionalizările din 1948, colectivizarea agriculturii (1949-1962), repreşiunea împotriva liderilor partidelor politice, foştilor demnitari, ţăranilor care s-au opus colectivizării, grupurilor armate din munţi este iniţiatorul industrializării socialiste şi al planurilor cincinale. In politica externă porneşte de la o obedienţă totală faţă de URSS, dar începe, la puţin timp după destalinizarea iniţiată de N.S. Hruşciov (1956) şi Revoluţia anticomunistă din Ungaria (1956), să-şi dea seama că menţinerea sa la putere trebuie să devină independentă de voinţa liderilor sovietici.Evită cu abilitate destalinizarea declanşată în URSS, susţinând că aceasta a avut loc în România încă din 1952, când au fost îndepărtaţi deviaţioniştii. Incepe un proces de desprindere de sub influenţa Moscovei, marcat prin retragerea trupelor sovietice (1958), în care a avut un rol esenţial, continuat apoi prin Declaraţia din aprilie 1964 cu privire la problemele mişcării comuniste şi muncitoreşti internaţionale, documentul programatic al distanţării faţă de Moscova.",
        "Acesta afirma principiul egalităţii între partidele comuniste (nu de subordonare faţă de PCUS, ca până atunci) şi al neamestecului în treburile interne ale fiecărui stat comunist. Alte gesturi sugestive sunt supervizarea publicării unor scrieri istorice în care se făcea referire la Basarabia şi publicarea textelor lui Marx despre imperialismul ţarist, cenzurate până atunci. Respinge Planul Valev, care urmărea specializarea economică a statelor din CAER. In acelaşi timp cu desprinderea de URSS, la îndemnul şi cu susţinerea lui I.Gh. Maurer, face paşi spre Occident: sunt semnate acorduri comerciale cu SUA, contracte de producţie şi pentru obţinerea unor licenţe. Autorităţile guvernamentale decid (august 1963) încetarea bruierii emisiunilor în limba română ale posturilor de radio occidentale şi promovează o înviorare a schimburilor culturale cu Occidentul (filme, expoziţii, cărţi, piese de teatru, ziare, turism).Totodată, In 1963 şi 1964 are loc eliberarea deţinuţilor politici din România. In faţa deschiderii României, Casa Albă aprobă (februarie 1964) documentul Program de acţiune pentru România, prin care se recomanda ca România să fie utilizată ca taste case privind noua politică a SUA faţă de statele blocului sovietic."
        ,"Toate acestea nu au dus deloc la o schimbare a caracterului totalitar al regimului care dădea semne de toleranţă tocmai pentru că se şimţea stăpân pe situaţie. Moare în 1965 din cauza unui cancer la ficat. Trupul, îmbălsămat după modelul Lenin, i-a fost depus în mausoleul din Parcul Libertăţii din Bucureşti, iar după 1989 osemintele i-au fost reînhumate în Cimitirul Bellu-Numele său a fost purtat o perioadă de către Universitatea Politehnică dm Bucureşti şi de oraşul Oneşti. "};
        public int index = 0;
        string chivu_stoica = "Născut în 7 august 1908, Smeeni, judeţul Buzău , Chivu Stoica s-a sinucis cu pușca de vânătoare, aparent în urma unui moment de depresiune, pe 18 februarie 1975. La vremea aceea era doar membru supleant al Comitetului Executiv, fusese practic marginalizat politic.Dar avusese momentele sale de glorie, fusese unul dintre baronii lui Dej, ajunsese în vârful Olimpului totalitar din România, tăiase și spânzurase după voie vreme de două decenii.A fost un comunist român, prim-ministru al României în perioada 1955-1961, Preşedinte al Consiliului de Stat al Republicii Socialiste România în perioada 24 martie 1965 - 9 decembrie 1967; a fost înlocuit în această funcţie de către Nicolae Ceauşescu.Colectivizarea forțată a agriculturii, parte a strategiei staliniste imitată orbește de Dej și grupul sau, s-a petrecut in timpul mandatului de premier al lui Chivu Stoica. Asemeni celorlalți membri ai Biroului Politic, mai târziu ai Comitetului Executiv, a fost responsabil pentru acțiunile regimului ilegitim și criminal. Ca președinte al Consiliului de Stat, a semnat Decretul din 1966 privind interzicerea avorturilor. În anul 1931 a devenit membru al Partidului Comunist din România. În anul 1933 a fost condamnat la închisoare pentru participare la greva de la Atelierele CFR Griviţa. A fost închis şi la penitenciarul din Ocnele Mari în anul 1936. ";
        public void get_index_for_buttons()
        {
            if (index == 0)
            {
                back_button.Enabled = false;
                front_button.Enabled = true;
            }
            if (index == 1)
            {
                back_button.Enabled = true;
                front_button.Enabled = true;
            }
            if (index == 2)
            {
                back_button.Enabled = true;
                front_button.Enabled = true;
            }
            if (index == 3)
            {
                back_button.Enabled = true;
                front_button.Enabled = true;
            }
            if(index==4)
            {
                back_button.Enabled = true;
                front_button.Enabled = true;
            }
            if(index==5)
            {
                back_button.Enabled = true;
                front_button.Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button7.BackColor = Color.GreenYellow;
            change2();
            get_index_for_buttons();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Transparent;
            button9.BackColor = Color.GreenYellow;
            pictureBox1.Image = imageList1.Images[1];
            pictureBox2.Image = imageList1.Images[0];
            label10.Text = a[0];
        }

        private void front_button_Click(object sender, EventArgs e)
        {
            if (index < 5)
            {
                index++;
                get_index_for_buttons();
                label10.Text = a[index];
            }
            else
                get_index_for_buttons();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                get_index_for_buttons();
                
                label10.Text = a[index];
            }
            else
                get_index_for_buttons();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.GreenYellow;
            button9.BackColor = Color.Transparent;
            label10.Text = chivu_stoica;
            pictureBox2.Visible = false;
            pictureBox1.Image = imageList1.Images[2];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form15 F15 = new Proiect_Istorie.Form15();
            this.Hide();
            F15.ShowDialog();
            this.Show();
        }
    }
}
