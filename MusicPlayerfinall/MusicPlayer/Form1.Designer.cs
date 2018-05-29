namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Playbutton = new System.Windows.Forms.Button();
            this.Loadbutton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.Deleteallbutton = new System.Windows.Forms.Button();
            this.Pasekpozycji = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pasekpozycji)).BeginInit();
            this.SuspendLayout();
            // 
            // Playbutton
            // 
            this.Playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Playbutton.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Playbutton.Image = ((System.Drawing.Image)(resources.GetObject("Playbutton.Image")));
            this.Playbutton.Location = new System.Drawing.Point(269, 271);
            this.Playbutton.Name = "Playbutton";
            this.Playbutton.Size = new System.Drawing.Size(35, 35);
            this.Playbutton.TabIndex = 0;
            this.Playbutton.UseVisualStyleBackColor = true;
            this.Playbutton.Click += new System.EventHandler(this.Playbutton_Click);
            // 
            // Loadbutton
            // 
            this.Loadbutton.Location = new System.Drawing.Point(12, 12);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Size = new System.Drawing.Size(75, 23);
            this.Loadbutton.TabIndex = 1;
            this.Loadbutton.Text = "Load";
            this.Loadbutton.UseVisualStyleBackColor = true;
            this.Loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LemonChiffon;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Track});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Location = new System.Drawing.Point(107, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(522, 253);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // Id
            // 
            this.Id.Text = "";
            this.Id.Width = 38;
            // 
            // Track
            // 
            this.Track.Text = "Track";
            this.Track.Width = 435;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(352, 271);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(90, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 57);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(12, 41);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Update_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 427);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Resetbutton
            // 
            this.Resetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resetbutton.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Resetbutton.Image = ((System.Drawing.Image)(resources.GetObject("Resetbutton.Image")));
            this.Resetbutton.Location = new System.Drawing.Point(310, 271);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(36, 35);
            this.Resetbutton.TabIndex = 10;
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // Deleteallbutton
            // 
            this.Deleteallbutton.Location = new System.Drawing.Point(12, 70);
            this.Deleteallbutton.Name = "Deleteallbutton";
            this.Deleteallbutton.Size = new System.Drawing.Size(75, 23);
            this.Deleteallbutton.TabIndex = 11;
            this.Deleteallbutton.Text = "Delet eall";
            this.Deleteallbutton.UseVisualStyleBackColor = true;
            this.Deleteallbutton.Click += new System.EventHandler(this.Deleteallbutton_Click);
            // 
            // Pasekpozycji
            // 
            this.Pasekpozycji.CausesValidation = false;
            this.Pasekpozycji.Location = new System.Drawing.Point(159, 312);
            this.Pasekpozycji.Name = "Pasekpozycji";
            this.Pasekpozycji.Size = new System.Drawing.Size(366, 45);
            this.Pasekpozycji.TabIndex = 12;
            this.Pasekpozycji.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Pasekpozycji.Scroll += new System.EventHandler(this.Pasekpozycji_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(531, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "00/00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(641, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pasekpozycji);
            this.Controls.Add(this.Deleteallbutton);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Loadbutton);
            this.Controls.Add(this.Playbutton);
            this.Name = "Form1";
            this.Text = "Music Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pasekpozycji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playbutton;
        private System.Windows.Forms.Button Loadbutton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Track;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Button Deleteallbutton;
        private System.Windows.Forms.TrackBar Pasekpozycji;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

