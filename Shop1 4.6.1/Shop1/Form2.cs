using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop1
{
    public partial class Form2 : Form
    {
       
        bool Shesternya;
        bool katalog;
        bool admin;
        bool man;
        bool woman;
        bool kid;
        bool dude;
        bool admin1;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void label1_MouseHover(object sender, EventArgs e)
        {
                timer7.Enabled = true;
                label2.Visible = true;
                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
                linkLabel3.Visible = true;
                linkLabel4.Visible = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Location = new Point(0, 0);
            dataGridView1.Columns[0].HeaderText = "Товар";
            dataGridView1.Columns[1].HeaderText = "цена";
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/zaruten");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/dina_fear");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id242773652");
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id567816757");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Черные зауженные джинсы с рваными коленями Only & Sons Plus", "3090р");
          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Рубашка в в зеленую шотландскую клетку Sixth June", "4790p");
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Розовая рубашка навыпуск с молнией ASOS DESIGN", "3090p");
           

        }
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Кремовая рубашка узкого кроя с воротником и логотипом из окрашенной ткани чинос Polo Ralph Lauren player", "8460p");
           
        }
        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Рубашка в красно-синюю клетку Jack & Jones Essentials", "2399р");
           
        }
        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Черная рубашка навыпуск в клетку ASOS DESIGN Tall", "3390p");
           
        }
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Visible = true;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Visible = true;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            label5.Visible = true;
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            label6.Visible = true;
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            label7.Visible = true;
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            label8.Visible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
          if (dataGridView1.Rows.Count != 0 && dataGridView1.Rows != null)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = true;
                timer5.Enabled = true;
                timer6.Enabled = true;
            }    
          else
            {
                MessageBox.Show("Выберите товар прежде чем оплатить");
            }
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            if (Shesternya)
            {
                button18.Visible = false;
                button16.Visible = false;
                Shesternya = false;
            }
           else
            {
                button18.Visible = true;
                button16.Visible = true;
                Shesternya = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            if (katalog)
            {
                button1.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                katalog = false;
           
            }
            else
            {
                button1.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                katalog = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                
                button12.Visible = true;
               
                admin = false;

            }
            else
            {
               
                button12.Visible = false;
                
                admin = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            button8.Enabled = true;
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            button8.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Светло-коричневые джинсы из искусственной кожи с завышенной талией ASOS DESIGN", "3890р");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Темно - синие мягкие джинсы Karl Kani OG", "6790р");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Синие выбеленные классические джинсы ASOS DESIGN", "1990р");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Светло-серые джинсы скинни с разрезами на коленях ASOS DESIGN Plus", "3090р");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Черная рубашка в клетку с добавлением шерсти ASOS DESIGN", "3390р");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Рубашка с начесом в черно-красную клетку Only & Sons", "2490р");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (man)
            {
                button6.Visible = true;
                button3.Visible = true;
                button5.Visible = true;
                button4.Visible = true;
                button22.Visible = true;
                button21.Visible = true;
                button7.Visible = true;
                button2.Visible = true;
                button23.Visible = true;
                button24.Visible = true;
                button25.Visible = true;
                button26.Visible = true;

                button34.Visible = false; //woman
                button37.Visible = false;
                button33.Visible = false;
                button36.Visible = false;
                button31.Visible = false;
                button32.Visible = false;
                button35.Visible = false;
                button38.Visible = false;
                button29.Visible = false;
                button30.Visible = false;
                button27.Visible = false;
                button28.Visible = false;

                button46.Visible = false; //kid
                button49.Visible = false;
                button45.Visible = false;
                button48.Visible = false;
                button43.Visible = false;
                button44.Visible = false;
                button47.Visible = false;
                button50.Visible = false;
                button41.Visible = false;
                button42.Visible = false;
                button39.Visible = false;
                button40.Visible = false;


                man = false;

            }
            else
            {
                button6.Visible = false;
                button3.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
                button22.Visible = false;
                button21.Visible = false;
                button7.Visible = false;
                button2.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
                button26.Visible = false;
                man = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (woman)
            {
                button34.Visible = true;
                button37.Visible = true;
                button33.Visible = true;
                button36.Visible = true;
                button31.Visible = true;
                button32.Visible = true;
                button35.Visible = true;
                button38.Visible = true;
                button29.Visible = true;
                button30.Visible = true;
                button27.Visible = true;
                button28.Visible = true;

                button6.Visible = false; //man
                button3.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
                button22.Visible = false;
                button21.Visible = false;
                button7.Visible = false;
                button2.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
                button26.Visible = false;

                button46.Visible = false; //kid
                button49.Visible = false;
                button45.Visible = false;
                button48.Visible = false;
                button43.Visible = false;
                button44.Visible = false;
                button47.Visible = false;
                button50.Visible = false;
                button41.Visible = false;
                button42.Visible = false;
                button39.Visible = false;
                button40.Visible = false;
                woman = false;
            }
            else
            {
                button34.Visible = false;
                button37.Visible = false;
                button33.Visible = false;
                button36.Visible = false;
                button31.Visible = false;
                button32.Visible = false;
                button35.Visible = false;
                button38.Visible = false;
                button29.Visible = false;
                button30.Visible = false;
                button27.Visible = false;
                button28.Visible = false;
                woman = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (kid)
            {
                button46.Visible = true;
                button49.Visible = true;
                button45.Visible = true;
                button48.Visible = true;
                button43.Visible = true;
                button44.Visible = true;
                button47.Visible = true;
                button50.Visible = true;
                button41.Visible = true;
                button42.Visible = true;
                button39.Visible = true;
                button40.Visible = true;

                button34.Visible = false; //woman
                button37.Visible = false;
                button33.Visible = false;
                button36.Visible = false;
                button31.Visible = false;
                button32.Visible = false;
                button35.Visible = false;
                button38.Visible = false;
                button29.Visible = false;
                button30.Visible = false;
                button27.Visible = false;
                button28.Visible = false;

                button6.Visible = false; //man
                button3.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
                button22.Visible = false;
                button21.Visible = false;
                button7.Visible = false;
                button2.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
                button26.Visible = false;

                kid = false;
            }
            else
            {
                button46.Visible = false;
                button49.Visible = false;
                button45.Visible = false;
                button48.Visible = false;
                button43.Visible = false;
                button44.Visible = false;
                button47.Visible = false;
                button50.Visible = false;
                button41.Visible = false;
                button42.Visible = false;
                button39.Visible = false;
                button40.Visible = false;
                kid = true;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Стеганый oversized-свитшот цвета хаки ASOS DESIGN, от комплекта", "2690р");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("ASOS DESIGN knitted hoody and wide leg trouser co - ord in cream", "2890р");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Розовый свитшот от комплекта Miss Selfridge", "3890р");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Бежевый меланжевый спортивный костюм премиум-класса, состоящий из свитшота с шалевым воротником и джоггеров ASOS DESIGN", "4890р");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Стеганые спортивные брюки от комплекта цвета высветленного хаки ASOS DESIGN", "2390р");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Худи бойфренда в стиле oversized черного цвета ASOS DESIGN", "1993р");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Очень мягкий комплект для дома из свитшота и джоггеров ASOS DESIGN Curve", "3213р");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Новогодний джемпер с выложенной пайетками надписью Let it snow ASOS DESIGN для ASOS Foundation", "3193р");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Синий трикотажный комбинезон для дома на пуговицах спереди с длинными рукавами и завязками на талии ASOS DESIGN", "2693р");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Серый худи с декоративной прострочкой от комплекта River Island " ,"3693р");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Красные фланелевые джоггеры Hollister ", "2393р");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Трикотажное платье цвета хаки с завязкой на спине Miss Selfridge ", "2693р");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Гребень Дино ", "3293р");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Кигуруми Человек Паук ", "1373р");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Bossa Nova ", "890р");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Кигуруми для девочек и мальчиков Летучая Мышь с молнией на попе", "3890р");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Платье Сьюзи Sc", "4290р");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(" Платье Angry Birdc", "555р");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Quiksilver / Куртка сноубордическая", "7550р");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("PlayToday / Пижама: лонгслив, брюки", "1274р");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("STANDART / Кигуруми Пикачу на пуговицах | Кигуруми для взрослых | Пижама", "1294р");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Marvel / Футболка с длинным рукавом MARVEL Spider man", "400р");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("HandyWear / Кигуруми для девочек Единорог с молнией на попе В подарочной упаковке", "3400р");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("ROXY / Куртка сноубордическая", "6400р");
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
         if(dude)
            {
                pictureBox2.Visible = true;
                dude = false;
            }
         else
            {
                pictureBox2.Visible = false;
                dude = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (admin1)
            {
                dataGridView1.Columns[0].HeaderText = "Логин";
                dataGridView1.Columns[1].HeaderText = "Пароль";
                dataGridView1.Rows.Add("Dragon", "13512");
                dataGridView1.Rows.Add("Imposter", "42134");
                dataGridView1.Rows.Add("dodik", "32155");
                dataGridView1.Rows.Add("lesya", "3215612");
                dataGridView1.Rows.Add("ilusha", "1521621");
                dataGridView1.Rows.Add("mangol", "6343423");
                dataGridView1.Rows.Add("Oleg", "6136321");
                dataGridView1.Rows.Add("dina", "3351212");
                dataGridView1.Rows.Add("kirill", "32132512");
                dataGridView1.Rows.Add("popka", "32152141");
                dataGridView1.Rows.Add("popfeel", "321312315521");
                dataGridView1.Rows.Add("miki", "125212321321");
                admin1 = false;
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns[0].HeaderText = "Товар";
                dataGridView1.Columns[1].HeaderText = "цена";
                admin1 = true;
            }


        }
    }
}
