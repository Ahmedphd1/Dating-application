
namespace datingapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userkøn = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userøjenfarve = new System.Windows.Forms.ListBox();
            this.userhårfarve = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.opretbutton = new System.Windows.Forms.Button();
            this.kønlistbox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.øjelistbox = new System.Windows.Forms.ListBox();
            this.hårlistbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.postnummertext = new System.Windows.Forms.TextBox();
            this.bytext = new System.Windows.Forms.TextBox();
            this.navntext = new System.Windows.Forms.TextBox();
            this.kodetext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.postnummer = new System.Windows.Forms.Label();
            this.by = new System.Windows.Forms.Label();
            this.navn = new System.Windows.Forms.Label();
            this.kodeord = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.fødselsdagtext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 279);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(167, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(143, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(176, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fødselsdagtext);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.userkøn);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.userøjenfarve);
            this.tabPage2.Controls.Add(this.userhårfarve);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.opretbutton);
            this.tabPage2.Controls.Add(this.kønlistbox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.øjelistbox);
            this.tabPage2.Controls.Add(this.hårlistbox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.postnummertext);
            this.tabPage2.Controls.Add(this.bytext);
            this.tabPage2.Controls.Add(this.navntext);
            this.tabPage2.Controls.Add(this.kodetext);
            this.tabPage2.Controls.Add(this.emailtext);
            this.tabPage2.Controls.Add(this.postnummer);
            this.tabPage2.Controls.Add(this.by);
            this.tabPage2.Controls.Add(this.navn);
            this.tabPage2.Controls.Add(this.kodeord);
            this.tabPage2.Controls.Add(this.email);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Opret bruger";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // userkøn
            // 
            this.userkøn.FormattingEnabled = true;
            this.userkøn.Items.AddRange(new object[] {
            "Mand",
            "Kvinde"});
            this.userkøn.Location = new System.Drawing.Point(39, 229);
            this.userkøn.Name = "userkøn";
            this.userkøn.Size = new System.Drawing.Size(89, 17);
            this.userkøn.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(7, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Køn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(3, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "øjenfarve";
            // 
            // userøjenfarve
            // 
            this.userøjenfarve.FormattingEnabled = true;
            this.userøjenfarve.Items.AddRange(new object[] {
            "Sort",
            "Blond",
            "Brun",
            "Blå"});
            this.userøjenfarve.Location = new System.Drawing.Point(56, 209);
            this.userøjenfarve.Name = "userøjenfarve";
            this.userøjenfarve.Size = new System.Drawing.Size(89, 17);
            this.userøjenfarve.TabIndex = 20;
            // 
            // userhårfarve
            // 
            this.userhårfarve.FormattingEnabled = true;
            this.userhårfarve.Items.AddRange(new object[] {
            "Sort",
            "Blond",
            "Brun",
            "Blå"});
            this.userhårfarve.Location = new System.Drawing.Point(60, 181);
            this.userhårfarve.Name = "userhårfarve";
            this.userhårfarve.Size = new System.Drawing.Size(89, 17);
            this.userhårfarve.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(6, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hårfarve";
            // 
            // opretbutton
            // 
            this.opretbutton.Location = new System.Drawing.Point(150, 220);
            this.opretbutton.Name = "opretbutton";
            this.opretbutton.Size = new System.Drawing.Size(75, 23);
            this.opretbutton.TabIndex = 17;
            this.opretbutton.Text = "Opret bruger";
            this.opretbutton.UseVisualStyleBackColor = true;
            this.opretbutton.Click += new System.EventHandler(this.opretbutton_Click);
            // 
            // kønlistbox
            // 
            this.kønlistbox.FormattingEnabled = true;
            this.kønlistbox.Items.AddRange(new object[] {
            "Mand",
            "Kvinde"});
            this.kønlistbox.Location = new System.Drawing.Point(269, 150);
            this.kønlistbox.Name = "kønlistbox";
            this.kønlistbox.Size = new System.Drawing.Size(89, 17);
            this.kønlistbox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(290, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Køn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(290, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "øjenfarve";
            // 
            // øjelistbox
            // 
            this.øjelistbox.FormattingEnabled = true;
            this.øjelistbox.Items.AddRange(new object[] {
            "Sort",
            "Blond",
            "Brun",
            "Blå"});
            this.øjelistbox.Location = new System.Drawing.Point(269, 102);
            this.øjelistbox.Name = "øjelistbox";
            this.øjelistbox.Size = new System.Drawing.Size(89, 17);
            this.øjelistbox.TabIndex = 13;
            // 
            // hårlistbox
            // 
            this.hårlistbox.FormattingEnabled = true;
            this.hårlistbox.Items.AddRange(new object[] {
            "Sort",
            "Blond",
            "Brun",
            "Blå"});
            this.hårlistbox.Location = new System.Drawing.Point(269, 59);
            this.hårlistbox.Name = "hårlistbox";
            this.hårlistbox.Size = new System.Drawing.Size(89, 17);
            this.hårlistbox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(290, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hårfarve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(281, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Præferencer";
            // 
            // postnummertext
            // 
            this.postnummertext.Location = new System.Drawing.Point(78, 118);
            this.postnummertext.Name = "postnummertext";
            this.postnummertext.Size = new System.Drawing.Size(100, 20);
            this.postnummertext.TabIndex = 9;
            // 
            // bytext
            // 
            this.bytext.Location = new System.Drawing.Point(32, 88);
            this.bytext.Name = "bytext";
            this.bytext.Size = new System.Drawing.Size(100, 20);
            this.bytext.TabIndex = 8;
            // 
            // navntext
            // 
            this.navntext.Location = new System.Drawing.Point(46, 62);
            this.navntext.Name = "navntext";
            this.navntext.Size = new System.Drawing.Size(100, 20);
            this.navntext.TabIndex = 7;
            // 
            // kodetext
            // 
            this.kodetext.Location = new System.Drawing.Point(60, 36);
            this.kodetext.Name = "kodetext";
            this.kodetext.Size = new System.Drawing.Size(100, 20);
            this.kodetext.TabIndex = 6;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(45, 10);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(100, 20);
            this.emailtext.TabIndex = 5;
            // 
            // postnummer
            // 
            this.postnummer.AutoSize = true;
            this.postnummer.ForeColor = System.Drawing.Color.Red;
            this.postnummer.Location = new System.Drawing.Point(7, 121);
            this.postnummer.Name = "postnummer";
            this.postnummer.Size = new System.Drawing.Size(65, 13);
            this.postnummer.TabIndex = 4;
            this.postnummer.Text = "Postnummer";
            // 
            // by
            // 
            this.by.AutoSize = true;
            this.by.ForeColor = System.Drawing.Color.Red;
            this.by.Location = new System.Drawing.Point(7, 91);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(19, 13);
            this.by.TabIndex = 3;
            this.by.Text = "By";
            // 
            // navn
            // 
            this.navn.AutoSize = true;
            this.navn.ForeColor = System.Drawing.Color.Red;
            this.navn.Location = new System.Drawing.Point(7, 63);
            this.navn.Name = "navn";
            this.navn.Size = new System.Drawing.Size(33, 13);
            this.navn.TabIndex = 2;
            this.navn.Text = "Navn";
            // 
            // kodeord
            // 
            this.kodeord.AutoSize = true;
            this.kodeord.ForeColor = System.Drawing.Color.Red;
            this.kodeord.Location = new System.Drawing.Point(7, 38);
            this.kodeord.Name = "kodeord";
            this.kodeord.Size = new System.Drawing.Size(47, 13);
            this.kodeord.TabIndex = 1;
            this.kodeord.Text = "Kodeord";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.ForeColor = System.Drawing.Color.Red;
            this.email.Location = new System.Drawing.Point(7, 13);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 0;
            this.email.Text = "Email";
            // 
            // fødselsdagtext
            // 
            this.fødselsdagtext.Location = new System.Drawing.Point(78, 150);
            this.fødselsdagtext.Name = "fødselsdagtext";
            this.fødselsdagtext.Size = new System.Drawing.Size(100, 20);
            this.fødselsdagtext.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(7, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fødselsdag";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 280);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label kodeord;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label postnummer;
        private System.Windows.Forms.Label by;
        private System.Windows.Forms.Label navn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox postnummertext;
        private System.Windows.Forms.TextBox bytext;
        private System.Windows.Forms.TextBox navntext;
        private System.Windows.Forms.TextBox kodetext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Button opretbutton;
        private System.Windows.Forms.ListBox kønlistbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox øjelistbox;
        private System.Windows.Forms.ListBox hårlistbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox userkøn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox userøjenfarve;
        private System.Windows.Forms.ListBox userhårfarve;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fødselsdagtext;
        private System.Windows.Forms.Label label10;
    }
}

