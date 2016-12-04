using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Project1
{
    public partial class Form1 : Form

    {
       
        

        public Form1()
        {
            InitializeComponent();

            
        }
        



        public void oper()
        {


            if (comboBox1.SelectedItem == "นายพีระพงษ์ เทียบแสง")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410305-9";
                label5.Text = comboBox1.Text;
                label6.Text = "Peerapong Thiabsaeng";
                label7.Text = "088-3123205";
                label9.Text = "593410305-9";
                

            }
            else if (comboBox1.SelectedItem == "นายแผ่นดินทอง ถุงแก้ว")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410055-6";
                label5.Text = comboBox1.Text;
                label6.Text = "Maxga Maxshin";
                label7.Text = "0637980290";
                label9.Text = "593410055-6";

            }
            else if (comboBox1.SelectedItem == "นายพงศธร กิตติเคนา")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410056-4";
                label5.Text = comboBox1.Text;
                label6.Text = "Robiń Hood";
                label7.Text = "088-0587092";
                label9.Text = "593410056-4";

            }
            else if (comboBox1.SelectedItem == "นายธนพล เสนารักษ์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410351-2";
                label5.Text = comboBox1.Text;
                label6.Text = "Tong Thanaphon Senarak";
                label7.Text = "096-4452272";
                label9.Text = "593410351-2";

            }
            else if (comboBox1.SelectedItem == "นายชยังกูร โตนา")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410002-7";
                label5.Text = comboBox1.Text;
                label6.Text = "Chayangkoon Tona";
                label7.Text = "082-8524859";
                label9.Text = "593410002-7";

            }
            else if (comboBox1.SelectedItem == "นางสาวจารุชา คณะศิริวงค์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410036-0";
                label5.Text = comboBox1.Text;
                label6.Text = "Algorith'm Eyes";
                label7.Text = "091-3526073";
                label9.Text = "593410036-0";

            }
            else if (comboBox1.SelectedItem == "นายจิรเมธ ทองชุม")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410037-8";
                label5.Text = comboBox1.Text;
                label6.Text = ".....";
                label7.Text = "....";
                label9.Text = "593410037-8";

            }
            else if (comboBox1.SelectedItem == "นายฉัตรชัย ประธรรมเต")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410038-6";
                label5.Text = comboBox1.Text;
                label6.Text = "Singto Chatchai";
                label7.Text = "093-5213009";
                label9.Text = "593410038-6";

            }
            else if (comboBox1.SelectedItem == "นายวัชรากร อานามวงษ์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410307-5";
                label5.Text = comboBox1.Text;
                label6.Text = " ตรีรัชฎากร อานามวงษ์";
                label7.Text = "0959758832";
                label9.Text = "593410307-5";

            }
            else if (comboBox1.SelectedItem == "นางสาวจันทิมา เยาวรัตน์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410269-7";
                label5.Text = comboBox1.Text;
                label6.Text = "Namwan Muay'z";
                label7.Text = "0935269071";
                label9.Text = "593410269-7";

            }
            else if (comboBox1.SelectedItem == "นางสาวชลรัตน์ มาทา")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410304-1";
                label5.Text = comboBox1.Text;
                label6.Text = "จุ้ยเเจง แก๊งค์ขาบ๊วย";
                label7.Text = "0933948090";
                label9.Text = "593410304-1";

            }
            else if (comboBox1.SelectedItem == "นางสาวประภาพร สุนทรพิช")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410239-6";
                label5.Text = comboBox1.Text;
                label6.Text = "จุ๊บแจง ประภาพร";
                label7.Text = "0966750239";
                label9.Text = "593410239-6";

            }
            else if (comboBox1.SelectedItem == "นายสิทธิโชค ฟุ้งเจนโชคเจริญ")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410078-4";
                label5.Text = comboBox1.Text;
                label6.Text = "Aern Jang";
                label7.Text = "0885115187";
                label9.Text = "593410078-4";

            }
            else if (comboBox1.SelectedItem == "นายโชคชัย ชะคู")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410041-7";
                label5.Text = comboBox1.Text;
                label6.Text = "P'Rock Chokchai";
                label7.Text = "0921457577";
                label9.Text = "593410041-7";

            }
            else if (comboBox1.SelectedItem == "นายธีระศาสตร์ ยามี")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410049-1";
                label5.Text = comboBox1.Text;
                label6.Text = "Offe Ghostsweet";
                label7.Text = "0892733770";
                label9.Text = "593410049-1";

            }
            else if (comboBox1.SelectedItem == "นายชยานันท์ รักษาชัฎ")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410303-3";
                label5.Text = comboBox1.Text;
                label6.Text = "chayanan ragsachat";
                label7.Text = "0807500936";
                label9.Text = "593410303-3";

            }
            else if (comboBox1.SelectedItem == "นายณัฎฐกฤตย์ จันอินทร์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410042-5";
                label5.Text = comboBox1.Text;
                label6.Text = "nattakirt chanint";
                label7.Text = "0986615027";
                label9.Text = "593410042-5";

            }
            else if (comboBox1.SelectedItem == "นางสาวพรนัชชา ธนโรชากุล")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410240-1";
                label5.Text = comboBox1.Text;
                label6.Text = "แบม แบม";
                label7.Text = "0934243800";
                label9.Text = "593410240-1";

            }
            else if (comboBox1.SelectedItem == "นางสาวอัญชลีพร จันทร์สุเทพ")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410274-4";
                label5.Text = comboBox1.Text;
                label6.Text = "Anchaleeporn Chansutap";
                label7.Text = "0610620400";
                label9.Text = "593410274-4";

            }
            else if (comboBox1.SelectedItem == "นางสาวจิรนุช สิงห์อินทร์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410270-2";
                label5.Text = comboBox1.Text;
                label6.Text = "ivy cis";
                label7.Text = "0934155993";
                label9.Text = "593410270-2";

            }
            else if (comboBox1.SelectedItem == "นายกรวิชญ์ เหมือนตา")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410301-7";
                label5.Text = comboBox1.Text;
                label6.Text = "-";
                label7.Text = "0619744574";
                label9.Text = "593410301-7";

            }
            else if (comboBox1.SelectedItem == "นายศิริชัย อุลมาร")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410076-8";
                label5.Text = comboBox1.Text;
                label6.Text = "Arm Gallantry";
                label7.Text = "0944745213";
                label9.Text = "593410076-8";
                MessageBox.Show("มีข้อมูลในระบบ : " + comboBox1.Text, "ผลการค้นหา");
            }
            else if (comboBox1.SelectedItem == "นางสาวกิตติยา วรีฤทธิ์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410302-5";
                label5.Text = comboBox1.Text;
                label6.Text = "Kittiya Wareerit";
                label7.Text = "0942638998";
                label9.Text = "593410302-5";

            }
            else if (comboBox1.SelectedItem == "นางสาวรัชนีกร คร่อมชัยภูมิ")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410306-7";
                label5.Text = comboBox1.Text;
                label6.Text = "รัชนีกร คร่อมชัยภูมิ";
                label7.Text = "0611403629";
                label9.Text = "593410306-7";

            }
            else if (comboBox1.SelectedItem == "นางสาวอาริสา ผดุงศรี")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410308-3";
                label5.Text = comboBox1.Text;
                label6.Text = "นู๋ เบบี๋";
                label7.Text = "0981127682";
                label9.Text = "593410308-3";

            }
            else if (comboBox1.SelectedItem == "นางสาวอิศราวดี ชินบุตร")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410309-1";
                label5.Text = comboBox1.Text;
                label6.Text = "พี เอที";
                label7.Text = "0981862359";
                label9.Text = "593410309-1";

            }
            else if (comboBox1.SelectedItem == "นางสาวจักรีวรรณ เหลืองาม")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410350-4";
                label5.Text = comboBox1.Text;
                label6.Text = "Nan Chakkreewan";
                label7.Text = "0917341471";
                label9.Text = "593410350-4";

            }
            else if (comboBox1.SelectedItem == "นางสาวปวีณา นาสูงชน")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410356-2";
                label5.Text = comboBox1.Text;
                label6.Text = "Paweena Nasoongchon";
                label7.Text = "0954467180";
                label9.Text = "593410356-2";

            }
            else if (comboBox1.SelectedItem == "นายพรเทพ จันทร์เวช")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=";
                label5.Text = comboBox1.Text;
                label6.Text = "Phonthep Chanwet";
                label7.Text = "0823832807";
                label9.Text = "593410273-6";

            }
            else if (comboBox1.SelectedItem == "นายนพัทธ์ ศรีจันทพงศ์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410051-4";
                label5.Text = comboBox1.Text;
                label6.Text = "Napat Srichanatapong";
                label7.Text = "0828662279";
                label9.Text = "593410051-4";

            }
            else if (comboBox1.SelectedItem == "นายวัชรินทร์ สารฤทธิ์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410069-5";
                label5.Text = comboBox1.Text;
                label6.Text = "";
                label7.Text = "0933693132";
                label9.Text = "593410069-5";

            }
            else if (comboBox1.SelectedItem == "นายวันจุติ สกุลคู")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410070-0";
                label5.Text = comboBox1.Text;
                label6.Text = "Kao Sakulkhoo";
                label7.Text = "0973188282";
                label9.Text = "593410070-0";

            }
            else if (comboBox1.SelectedItem == "นางสาวสุธิดา แสนศรี")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410080-7";
                label5.Text = comboBox1.Text;
                label6.Text = "Suthida Sansri";
                label7.Text = "0611465138";
                label9.Text = "593410080-7";

            }
            else if (comboBox1.SelectedItem == "นางสาวอักษราภัค มีแสง")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410086-5";
                label5.Text = comboBox1.Text;
                label6.Text = "พลอย ยยยยย";
                label7.Text = "0896199936";
                label9.Text = "593410086-5";

            }
            else if (comboBox1.SelectedItem == "นางสาวอิศราภรณ์ ศรีภิรมย์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410089-9";
                label5.Text = comboBox1.Text;
                label6.Text = "Isaraporn Deer";
                label7.Text = "0979827240";
                label9.Text = "593410089-9";

            }
            else if (comboBox1.SelectedItem == "นางสาวชลธิชา ทิศนอก")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410039-4";
                label5.Text = comboBox1.Text;
                label6.Text = "ชลธิชา ทิศนอก";
                label7.Text = "0981218674";
                label9.Text = "593410039-4";

            }
            else if (comboBox1.SelectedItem == "นางสาวทัศนีย์ คุณเมือง")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410045-9";
                label5.Text = comboBox1.Text;
                label6.Text = "Tassanee Kunmuang";
                label7.Text = "0900390219";
                label9.Text = "593410045-9";

            }
            else if (comboBox1.SelectedItem == "นางสาวธัญญลักษณ์ ทองเที่ยง")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410048-3";
                label5.Text = comboBox1.Text;
                label6.Text = "Baifern Thunyalak";
                label7.Text = "0981784474";
                label9.Text = "593410048-3";

            }
            else if (comboBox1.SelectedItem == "นางสาวนุชวรา เพ็ชรกิ่ง")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410053-0";
                label5.Text = comboBox1.Text;
                label6.Text = "Ice'z Ky";
                label7.Text = "0981013074";
                label9.Text = "593410053-0";

            }
            else if (comboBox1.SelectedItem == "นางสาวภัสนภา มีรัตน์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410057-2";
                label5.Text = comboBox1.Text;
                label6.Text = "กอ แก้ว 'ว";
                label7.Text = "0610281072";
                label9.Text = "593410057-2";

            }
            else if (comboBox1.SelectedItem == "นางสาวเพียงนภา อุชชิน")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410061-1";
                label5.Text = comboBox1.Text;
                label6.Text = "Boing Bpu";
                label7.Text = "0849529091";
                label9.Text = "593410061-1";

            }
            else if (comboBox1.SelectedItem == "นายภูรี สิทธิพูนอนุภาพ")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410065-3";
                label5.Text = comboBox1.Text;
                label6.Text = "----";
                label7.Text = "0959146394";
                label9.Text = "593410065-3";

            }
            else if (comboBox1.SelectedItem == "นางสาววราภรณ์ ภูมิทัศน์")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410067-9";
                label5.Text = comboBox1.Text;
                label6.Text = "Biw Waraporn Phoommitut";
                label7.Text = "0981808202";
                label9.Text = "593410067-9";

            }
            else if (comboBox1.SelectedItem == "นางสาวอุมาพร ซ้ายมี")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410090-4";
                label5.Text = comboBox1.Text;
                label6.Text = "Benz Umaporn";
                label7.Text = "0902368452";
                label9.Text = "593410090-4";

            }
            else if (comboBox1.SelectedItem == "นายเอกรัตน์ จันทร์อุบ")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410091-2";
                label5.Text = comboBox1.Text;
                label6.Text = "Ert Ekkarut";
                label7.Text = "0933984986";
                label9.Text = "593410091-2";

            }
            else if (comboBox1.SelectedItem == "นางสาวนุชนาฏ สุวรรณรังษี")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410238-8";
                label5.Text = comboBox1.Text;
                label6.Text = "ฟร้องค์' เก้าแปด";
                label7.Text = "0637372723";
                label9.Text = "593410238-8";

            }
            else if (comboBox1.SelectedItem == "นายก่อเกียรติ สุปัญญา")
            {
                pictureBox1.ImageLocation = "http://reg1.kku.ac.th/ephoto/getstudentimage.asp?id=593410268-9";
                label5.Text = comboBox1.Text;
                label6.Text = "บิ๊ก โต";
                label7.Text = "0908893763";
                label9.Text = "593410268-9";

            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูล", "ผลการค้นหา");
            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {

            oper();
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
