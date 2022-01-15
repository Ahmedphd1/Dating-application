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

    public partial class datingform : Form
    {

        public List<personclass> objlist { get; set; }

        public personclass currentuser { get; set; }

        public matchfound mypublisher { get; set; }

        public bool nextperson()
        {
            Random rnd = new Random();

            int randomnumber = rnd.Next(10);

            if (objlist[randomnumber].hårfarve.ToString().ToLower() == Convert.ToString(Form1.mydictval["matchhårfarve"]).ToLower() || objlist[randomnumber].øjefarve.ToString().ToLower() == Form1.mydictval["matchøjefarve"].ToString().ToLower())
            {
                navnsøg.Text = objlist[randomnumber].alias;
                emailsøg.Text = objlist[randomnumber].email;
                bysøg.Text = objlist[randomnumber].bydel;
                postnummersøg.Text = objlist[randomnumber].postnummer;
                kønsøg.Text = objlist[randomnumber].køn;
                hårsøg.Text = objlist[randomnumber].hårfarve;
                øjesøg.Text = objlist[randomnumber].øjefarve;
                currentuser = objlist[randomnumber];
                return true;
            }
            else
            {
                return false;
            }
        }

        public void nextpersonmatch()
        {
            Random rnd = new Random();

            int randomnumber = rnd.Next(10);

            navnmatch.Text = objlist[randomnumber].alias;
            emailmatch.Text = objlist[randomnumber].email;
            bymatch.Text = objlist[randomnumber].bydel;
            postnummermatch.Text = objlist[randomnumber].postnummer;
            kønmatch.Text = objlist[randomnumber].køn;
            hårfarvematch.Text = objlist[randomnumber].hårfarve;
            øjefarvematch.Text = objlist[randomnumber].øjefarve;
            currentuser = objlist[randomnumber];
        }

        public datingform()
        {
            InitializeComponent();

            mypublisher = new matchfound(); // publisher

            mypublisher.matchfoundhandler += onmatchfound; // subscribe the event handler to the delegate

            likedlabel.Hide();

            try
            {
                navntext.Text = Form1.mydictval["alias"];
                emailtext.Text = Form1.mydictval["email"];
                bytext.Text = Form1.mydictval["bydel"];
                postnummertext.Text = Form1.mydictval["postnummer"];
                køntext.Text = Form1.mydictval["køn"];
                hårfarvetext.Text = Form1.mydictval["hårfarve"];
                øjefarvetext.Text = Form1.mydictval["øjefarve"];

                List<personclass> personobj = new List<personclass>();

                for (var i = 0; i < 10; i++)
                {
                    personobj.Add(new personclass {email = $"someemail{i}@hotmail.com", passwords = $"mypassword{i}", alias = $"name{i}", birthsday="23/03/1994", køn="kvinde", hårfarve="sort", øjefarve="sort", matchhårfarve="sort", matchøjefarve="sort", postnummer="2610", bydel="københavn" });

                    sqlclass mysql = new sqlclass(@"Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True");
                    mysql.conndb();

                    Dictionary<string, dynamic> table1 = new Dictionary<string, dynamic>();
                    Dictionary<string, dynamic> table2 = new Dictionary<string, dynamic>();

                    table1.Add("@email", personobj[i].email);
                    table1.Add("@passwords", personobj[i].passwords);

                    table2.Add("@alias", personobj[i].alias);
                    table2.Add("@birthsday", personobj[i].birthsday);
                    table2.Add("@køn", personobj[i].køn);
                    table2.Add("@hårfarve", personobj[i].hårfarve);
                    table2.Add("@øjefarve", personobj[i].øjefarve);
                    table2.Add("@postnummer", personobj[i].postnummer);
                    table2.Add("@bydel", personobj[i].bydel);
                    table2.Add("@matchhårfarve", personobj[i].matchhårfarve);
                    table2.Add("@matchøjefarve", personobj[i].matchøjefarve);

                    if (mysql.checkdatabase("email", table1["@email"], table1["@email"], "email", "account"))
                    {

                    } else
                    {
                        mysql.writetodatabase(@"insert into account(email, passwords) values (@email, @passwords);", @"insert into profil(alias, birthsday, køn, hårfarve, øjefarve, matchhårfarve, matchøjefarve, idaccount, postnummer, bydel) values (@alias, @birthsday, @køn, @hårfarve, @øjefarve, @matchhårfarve, @matchøjefarve, @idaccount, @postnummer, @bydel);", table1, table2);
                    }
                }

                objlist = personobj;

                Console.WriteLine(objlist);

                currentuser = objlist[0];

                sqlclass myclass = new sqlclass(@"Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True");
                myclass.conndb();

                personclass myperson = new personclass();

                List<Interfaceclass> mylist = new List<Interfaceclass>();

                mylist.Add(myclass);
                mylist.Add(myperson);

                foreach (personclass myobj in objlist)
                {
                    mylist[0].checkinitiate();
                    mylist[1].checkinitiate();

                    var thisuser = (string)myclass.getid("email", Form1.mydictval["email"]);
                    var otheruser = (string)myclass.getid("email", myobj.email);

                    if (myclass.checkmatch(thisuser, otheruser))
                    {
                        listBox1.Items.Add(myobj.alias);
                    }
                }

            } catch
            {

            }

        }

        private void logout_Click(object sender, EventArgs e)
        {
            sqlclass mysql = new sqlclass(@"Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True");
            mysql.conndb();

            System.Windows.Forms.Application.Exit();
        }

         public void onmatchfound(object source, EventArgs e)
        {
            MessageBox.Show($"You matched with: {currentuser.alias}");
        }

        private void sletbutton_Click(object sender, EventArgs e)
        {
            // delete table

            try
            {
                sqlclass mysql = new sqlclass(@"Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True");
                mysql.conndb();

                mysql.deletetable("accountid", mysql.getid("email", Form1.mydictval["email"]), "account");
            } catch
            {
                MessageBox.Show("cannot delete account");
            }


        }

        private void næsteknap_Click(object sender, EventArgs e)
        {
            if (nextperson())
            {

            } else
            {
                nextperson();
            }
        }

        private void sendlikesøg_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("sendlike button pressed");

                sqlclass mysql = new sqlclass(@"Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True");
                mysql.conndb();

                var thisuser = (string)mysql.getid("email", Form1.mydictval["email"]);
                var otheruser = (string)mysql.getid("email", currentuser.email);

                if (mysql.checkmatch(thisuser, otheruser))
                {
                    MessageBox.Show("you already matched with the person");
                } else
                {
                    string resultstring = mysql.sendlike(thisuser, otheruser, otheruser);

                    Console.WriteLine($"this is result string {resultstring}");

                    if (resultstring == "signmatch")
                    {
                        if (mysql.signmatch(thisuser, otheruser))
                        {
                            mypublisher.triggermatch();
                        }
                    } else if (resultstring == "addedlike")
                    {
                        MessageBox.Show($"You sent a like to {currentuser.alias}");
                    } else if (resultstring == "false")
                    {
                        MessageBox.Show("something went wrong");
                    }
                }

            } catch
            {

            }
        }

        private void næstematch_Click(object sender, EventArgs e)
        {
            likedlabel.Hide();

            nextpersonmatch();

            sqlclass mysql = new sqlclass(@"Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True");
            mysql.conndb();

            var thisuser = Convert.ToString(mysql.getid("email", Form1.mydictval["email"]));
            var otheruser = Convert.ToString(mysql.getid("email", currentuser.email));

            if (mysql.checklike(thisuser, otheruser))
            {
                likedlabel.Show();
            }
        }

        private void sendlikematch_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("sendlike button pressed");

                sqlclass mysql = new sqlclass(@"Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True");
                mysql.conndb();

                var thisuser = (string)mysql.getid("email", Form1.mydictval["email"]);
                var otheruser = (string)mysql.getid("email", currentuser.email);

                if (mysql.checkmatch(thisuser, otheruser))
                {
                    MessageBox.Show("you already matched with the person");
                }
                else
                {
                    string resultstring = mysql.sendlike(thisuser, otheruser, otheruser);

                    Console.WriteLine($"this is result string {resultstring}");

                    if (resultstring == "signmatch")
                    {
                        if (mysql.signmatch(thisuser, otheruser))
                        {
                            mypublisher.triggermatch();
                        }
                    }
                    else if (resultstring == "addedlike")
                    {
                        MessageBox.Show($"You sent a like to {currentuser.alias}");
                    }
                    else if (resultstring == "false")
                    {
                        MessageBox.Show("something went wrong");
                    }
                }

            }
            catch
            {

            }
        }
    }
}
