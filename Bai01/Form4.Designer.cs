﻿namespace Bai01
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label_cate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox_card = new System.Windows.Forms.PictureBox();
            this.label_card = new System.Windows.Forms.Label();
            this.button_good = new System.Windows.Forms.Button();
            this.button_replay = new System.Windows.Forms.Button();
            this.pictureBox_speaker = new System.Windows.Forms.PictureBox();
            this.label_finish = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speaker)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(24, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 50);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Bai01.Addition.Exit;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(758, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 43);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(78, 119);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(675, 413);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label_cate
            // 
            this.label_cate.CausesValidation = false;
            this.label_cate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cate.ForeColor = System.Drawing.Color.Red;
            this.label_cate.Location = new System.Drawing.Point(257, 9);
            this.label_cate.Name = "label_cate";
            this.label_cate.Size = new System.Drawing.Size(304, 58);
            this.label_cate.TabIndex = 20;
            this.label_cate.Text = "Animals";
            this.label_cate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Bai01.Addition.flashcard;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(411, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Bai01.Addition.grid;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.CadetBlue;
            this.button2.Location = new System.Drawing.Point(330, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox_card
            // 
            this.pictureBox_card.Location = new System.Drawing.Point(178, 119);
            this.pictureBox_card.Name = "pictureBox_card";
            this.pictureBox_card.Size = new System.Drawing.Size(471, 342);
            this.pictureBox_card.TabIndex = 25;
            this.pictureBox_card.TabStop = false;
            // 
            // label_card
            // 
            this.label_card.CausesValidation = false;
            this.label_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_card.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_card.Location = new System.Drawing.Point(178, 478);
            this.label_card.Name = "label_card";
            this.label_card.Size = new System.Drawing.Size(471, 41);
            this.label_card.TabIndex = 26;
            this.label_card.Text = "Animals";
            this.label_card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_good
            // 
            this.button_good.BackgroundImage = global::Bai01.Addition.good;
            this.button_good.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_good.ForeColor = System.Drawing.Color.CadetBlue;
            this.button_good.Location = new System.Drawing.Point(667, 227);
            this.button_good.Name = "button_good";
            this.button_good.Size = new System.Drawing.Size(75, 64);
            this.button_good.TabIndex = 29;
            this.button_good.UseVisualStyleBackColor = true;
            this.button_good.Click += new System.EventHandler(this.button_good_Click);
            // 
            // button_replay
            // 
            this.button_replay.BackgroundImage = global::Bai01.Addition.replay;
            this.button_replay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_replay.ForeColor = System.Drawing.Color.CadetBlue;
            this.button_replay.Location = new System.Drawing.Point(667, 307);
            this.button_replay.Name = "button_replay";
            this.button_replay.Size = new System.Drawing.Size(75, 64);
            this.button_replay.TabIndex = 30;
            this.button_replay.UseVisualStyleBackColor = true;
            this.button_replay.Click += new System.EventHandler(this.button_replay_Click);
            // 
            // pictureBox_speaker
            // 
            this.pictureBox_speaker.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_speaker.BackgroundImage = global::Bai01.Properties.Resources.speaker;
            this.pictureBox_speaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_speaker.InitialImage = null;
            this.pictureBox_speaker.Location = new System.Drawing.Point(744, 69);
            this.pictureBox_speaker.Name = "pictureBox_speaker";
            this.pictureBox_speaker.Size = new System.Drawing.Size(87, 85);
            this.pictureBox_speaker.TabIndex = 32;
            this.pictureBox_speaker.TabStop = false;
            this.pictureBox_speaker.Click += new System.EventHandler(this.pictureBox_speaker_Click);
            // 
            // label_finish
            // 
            this.label_finish.CausesValidation = false;
            this.label_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_finish.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_finish.Location = new System.Drawing.Point(178, 153);
            this.label_finish.Name = "label_finish";
            this.label_finish.Size = new System.Drawing.Size(471, 340);
            this.label_finish.TabIndex = 33;
            this.label_finish.Text = "You have finished this catetory.";
            this.label_finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bai01.Addition.toomanysus;
            this.ClientSize = new System.Drawing.Size(843, 544);
            this.Controls.Add(this.label_finish);
            this.Controls.Add(this.button_replay);
            this.Controls.Add(this.button_good);
            this.Controls.Add(this.label_card);
            this.Controls.Add(this.pictureBox_card);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_cate);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox_speaker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speaker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label_cate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox_card;
        private System.Windows.Forms.Label label_card;
        private System.Windows.Forms.Button button_good;
        private System.Windows.Forms.Button button_replay;
        private System.Windows.Forms.PictureBox pictureBox_speaker;
        private System.Windows.Forms.Label label_finish;
    }
}