
namespace GigdiPuller
{
    partial class instancepuller
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instancepuller));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.Label();
            this.Watermark = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentIP = new System.Windows.Forms.Label();
            this.instance = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.InstanceID = new System.Windows.Forms.Label();
            this.user2timestamp = new System.Windows.Forms.Label();
            this.user2ID = new System.Windows.Forms.Label();
            this.user2ip = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Watermark)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(240, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pull";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(48, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instance Puller Hub";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 63);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(144, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pulled Info";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(356, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(319, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox9
            // 
            this.textBox9.AutoSize = true;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(330, 14);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(6, 2);
            this.textBox9.TabIndex = 21;
            this.textBox9.Text = "label4";
            // 
            // Watermark
            // 
            this.Watermark.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Watermark.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.Watermark.AutoScrollMinSize = new System.Drawing.Size(987, 14);
            this.Watermark.BackBrush = null;
            this.Watermark.CharHeight = 14;
            this.Watermark.CharWidth = 8;
            this.Watermark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Watermark.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Watermark.IsReplaceMode = false;
            this.Watermark.Location = new System.Drawing.Point(334, 299);
            this.Watermark.Name = "Watermark";
            this.Watermark.Paddings = new System.Windows.Forms.Padding(0);
            this.Watermark.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Watermark.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Watermark.ServiceColors")));
            this.Watermark.Size = new System.Drawing.Size(0, 0);
            this.Watermark.TabIndex = 6;
            this.Watermark.Text = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/SgtGigdi/SgtGigdi-Laun" +
    "cher-Roblox/main/Watermark/script\"))();";
            this.Watermark.Zoom = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Developed By SgtGigdi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CurrentIP
            // 
            this.CurrentIP.AutoSize = true;
            this.CurrentIP.Location = new System.Drawing.Point(267, 272);
            this.CurrentIP.Name = "CurrentIP";
            this.CurrentIP.Size = new System.Drawing.Size(65, 13);
            this.CurrentIP.TabIndex = 21;
            this.CurrentIP.Text = "PlaceHolder";
            // 
            // instance
            // 
            this.instance.AllowDrop = true;
            this.instance.BorderColor = System.Drawing.Color.Red;
            this.instance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.instance.DefaultText = "Instance ID";
            this.instance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.instance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.instance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.instance.DisabledState.Parent = this.instance;
            this.instance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.instance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.instance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.instance.FocusedState.Parent = this.instance;
            this.instance.ForeColor = System.Drawing.Color.White;
            this.instance.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.instance.HoveredState.Parent = this.instance;
            this.instance.Location = new System.Drawing.Point(3, 255);
            this.instance.Margin = new System.Windows.Forms.Padding(4);
            this.instance.Name = "instance";
            this.instance.PasswordChar = '\0';
            this.instance.PlaceholderForeColor = System.Drawing.Color.White;
            this.instance.PlaceholderText = "";
            this.instance.SelectedText = "";
            this.instance.ShadowDecoration.Parent = this.instance;
            this.instance.Size = new System.Drawing.Size(238, 43);
            this.instance.TabIndex = 57;
            this.instance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.instance.TextChanged += new System.EventHandler(this.method_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(374, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 176);
            this.button1.TabIndex = 62;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // InstanceID
            // 
            this.InstanceID.AutoSize = true;
            this.InstanceID.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstanceID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.InstanceID.Location = new System.Drawing.Point(29, 77);
            this.InstanceID.Name = "InstanceID";
            this.InstanceID.Size = new System.Drawing.Size(64, 14);
            this.InstanceID.TabIndex = 63;
            this.InstanceID.Text = "Instance ID";
            // 
            // user2timestamp
            // 
            this.user2timestamp.AutoSize = true;
            this.user2timestamp.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2timestamp.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.user2timestamp.Location = new System.Drawing.Point(29, 101);
            this.user2timestamp.Name = "user2timestamp";
            this.user2timestamp.Size = new System.Drawing.Size(64, 14);
            this.user2timestamp.TabIndex = 66;
            this.user2timestamp.Text = "Timestamp";
            // 
            // user2ID
            // 
            this.user2ID.AutoSize = true;
            this.user2ID.Font = new System.Drawing.Font("Microsoft Tai Le", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2ID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.user2ID.Location = new System.Drawing.Point(30, 124);
            this.user2ID.Name = "user2ID";
            this.user2ID.Size = new System.Drawing.Size(33, 10);
            this.user2ID.TabIndex = 67;
            this.user2ID.Text = "USERID";
            // 
            // user2ip
            // 
            this.user2ip.AutoSize = true;
            this.user2ip.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2ip.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.user2ip.Location = new System.Drawing.Point(29, 143);
            this.user2ip.Name = "user2ip";
            this.user2ip.Size = new System.Drawing.Size(48, 16);
            this.user2ip.TabIndex = 69;
            this.user2ip.Text = "USERIP";
            this.user2ip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(32, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 26);
            this.button3.TabIndex = 70;
            this.button3.Text = "Copy IP";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // instancepuller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(397, 319);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.user2ip);
            this.Controls.Add(this.user2ID);
            this.Controls.Add(this.user2timestamp);
            this.Controls.Add(this.InstanceID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.instance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Watermark);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CurrentIP);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "instancepuller";
            this.Tag = "ScriptHub";
            this.Text = "ScriptHub";
            this.Load += new System.EventHandler(this.ScriptHub_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Watermark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private FastColoredTextBoxNS.FastColoredTextBox Watermark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textBox9;
        private System.Windows.Forms.Label CurrentIP;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox instance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label InstanceID;
        private System.Windows.Forms.Label user2timestamp;
        private System.Windows.Forms.Label user2ID;
        private System.Windows.Forms.Label user2ip;
        private System.Windows.Forms.Button button3;
    }
}