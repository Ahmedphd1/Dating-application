using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datingapp
{
    public partial class Form1 : Form
    {

        public static Dictionary<string, dynamic> mydictval { get; set; }
        public Form1()
        {
            InitializeComponent();

            sqlclass newsql = new sqlclass(@"Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True");
            newsql.conndb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text.Length > 2 && textBox3.Text.Length > 2)
                {
                    sqlclass newsql = new sqlclass(@"Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True");
                    newsql.conndb();

                    if(newsql.checkdatabase("email", textBox4.Text, textBox4.Text, "email", "account") == true && newsql.checkdatabase("passwords", textBox3.Text, textBox3.Text, "passwords", "account") == true)
                    {
                        this.Hide();
                        mydictval = newsql.getperson("email", textBox4.Text);
                        datingform myform = new datingform();
                        myform.Show();
                    } else
                    {
                        MessageBox.Show("Wrong email or password.. Please try again");
                    }
                }
            } catch
            {
                MessageBox.Show("Email or password cannot be empty.. Please write email and password in correct format");
            }
        }

        private void opretbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (emailtext.Text.Length > 2 && kodeord.Text.Length > 2 && navntext.Text.Length > 2 && postnummertext.Text.Length > 2)
                {
                    sqlclass newsql = new sqlclass(@"Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True");
                    newsql.conndb();

                    Dictionary<string, dynamic> table1 = new Dictionary<string, dynamic>();
                    Dictionary<string, dynamic> table2 = new Dictionary<string, dynamic>();

                    table1.Add("@email", emailtext.Text);
                    table1.Add("@passwords", kodetext.Text);

                    table2.Add("@alias", navntext.Text);
                    table2.Add("@birthsday", fødselsdagtext.Text);
                    table2.Add("@køn", userkøn.Text);
                    table2.Add("@hårfarve", userhårfarve.Text);
                    table2.Add("@øjefarve", userøjenfarve.Text);
                    table2.Add("@postnummer", postnummertext.Text);
                    table2.Add("@bydel", bytext.Text);
                    table2.Add("@matchhårfarve", hårlistbox.Text);
                    table2.Add("@matchøjefarve", øjelistbox.Text);
                try
                    {
                        if (newsql.writetodatabase(@"insert into account(email, passwords) values (@email, @passwords);", @"insert into profil(alias, birthsday, køn, hårfarve, øjefarve, matchhårfarve, matchøjefarve, idaccount, postnummer, bydel) values (@alias, @birthsday, @køn, @hårfarve, @øjefarve, @matchhårfarve, @matchøjefarve, @idaccount, @postnummer, @bydel);", table1, table2))
                        {
                            this.Hide();
                            mydictval = newsql.getperson("email", table1["@email"]);
                            datingform myform = new datingform();
                            myform.Show();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Please try again");
                        }
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } else
                {
                    MessageBox.Show("Email or password cannot be empty.. Please write email and password in correct format");
                }
            }
            catch
            {
                MessageBox.Show("Email or password cannot be empty.. Please write email and password in correct format");
            }
        }
    }
}
