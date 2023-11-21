namespace calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Number1 = new Button();
            Number2 = new Button();
            Number3 = new Button();
            Number4 = new Button();
            Number5 = new Button();
            Number6 = new Button();
            Number7 = new Button();
            Number8 = new Button();
            Number9 = new Button();
            mosavi = new Button();
            plus = new Button();
            menha = new Button();
            zarb = new Button();
            taghsim = new Button();
            Number0 = new Button();
            display = new Label();
            oneClick = new Button();
            fullclear = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Number1
            // 
            Number1.BackColor = SystemColors.ButtonHighlight;
            Number1.Location = new Point(46, 371);
            Number1.Name = "Number1";
            Number1.Size = new Size(75, 23);
            Number1.TabIndex = 0;
            Number1.Text = "1";
            Number1.UseVisualStyleBackColor = false;
            Number1.Click += HandleNumberClick;
            // 
            // Number2
            // 
            Number2.BackColor = SystemColors.ButtonHighlight;
            Number2.Location = new Point(142, 371);
            Number2.Name = "Number2";
            Number2.Size = new Size(75, 23);
            Number2.TabIndex = 1;
            Number2.Text = "2";
            Number2.UseVisualStyleBackColor = false;
            Number2.Click += HandleNumberClick;
            // 
            // Number3
            // 
            Number3.BackColor = SystemColors.ButtonHighlight;
            Number3.Location = new Point(232, 371);
            Number3.Name = "Number3";
            Number3.Size = new Size(75, 23);
            Number3.TabIndex = 2;
            Number3.Text = "3";
            Number3.UseVisualStyleBackColor = false;
            Number3.Click += HandleNumberClick;
            // 
            // Number4
            // 
            Number4.BackColor = SystemColors.ButtonHighlight;
            Number4.Location = new Point(46, 329);
            Number4.Name = "Number4";
            Number4.Size = new Size(75, 23);
            Number4.TabIndex = 3;
            Number4.Text = "4";
            Number4.UseVisualStyleBackColor = false;
            Number4.Click += HandleNumberClick;
            // 
            // Number5
            // 
            Number5.BackColor = SystemColors.ButtonHighlight;
            Number5.Location = new Point(142, 329);
            Number5.Name = "Number5";
            Number5.Size = new Size(75, 23);
            Number5.TabIndex = 4;
            Number5.Text = "5";
            Number5.UseVisualStyleBackColor = false;
            Number5.Click += HandleNumberClick;
            // 
            // Number6
            // 
            Number6.BackColor = SystemColors.ButtonHighlight;
            Number6.Location = new Point(232, 329);
            Number6.Name = "Number6";
            Number6.Size = new Size(75, 23);
            Number6.TabIndex = 5;
            Number6.Text = "6";
            Number6.UseVisualStyleBackColor = false;
            Number6.Click += HandleNumberClick;
            // 
            // Number7
            // 
            Number7.BackColor = SystemColors.ButtonHighlight;
            Number7.Location = new Point(46, 281);
            Number7.Name = "Number7";
            Number7.Size = new Size(75, 23);
            Number7.TabIndex = 6;
            Number7.Text = "7";
            Number7.UseVisualStyleBackColor = false;
            Number7.Click += HandleNumberClick;
            // 
            // Number8
            // 
            Number8.BackColor = SystemColors.ButtonHighlight;
            Number8.Location = new Point(142, 281);
            Number8.Name = "Number8";
            Number8.Size = new Size(75, 23);
            Number8.TabIndex = 7;
            Number8.Text = "8";
            Number8.UseVisualStyleBackColor = false;
            Number8.Click += HandleNumberClick;
            // 
            // Number9
            // 
            Number9.BackColor = SystemColors.ButtonHighlight;
            Number9.Location = new Point(232, 281);
            Number9.Name = "Number9";
            Number9.Size = new Size(75, 23);
            Number9.TabIndex = 8;
            Number9.Text = "9";
            Number9.UseVisualStyleBackColor = false;
            Number9.Click += HandleNumberClick;
            // 
            // mosavi
            // 
            mosavi.BackColor = Color.FromArgb(0, 192, 0);
            mosavi.Location = new Point(332, 371);
            mosavi.Name = "mosavi";
            mosavi.Size = new Size(75, 37);
            mosavi.TabIndex = 9;
            mosavi.Tag = "";
            mosavi.Text = "=";
            mosavi.UseVisualStyleBackColor = false;
            mosavi.Click += mosavi_Click;
            // 
            // plus
            // 
            plus.BackColor = Color.FromArgb(0, 192, 0);
            plus.Location = new Point(332, 329);
            plus.Name = "plus";
            plus.Size = new Size(75, 36);
            plus.TabIndex = 10;
            plus.Tag = "";
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += HandleOptr;
            // 
            // menha
            // 
            menha.BackColor = Color.FromArgb(0, 192, 0);
            menha.Location = new Point(332, 281);
            menha.Name = "menha";
            menha.Size = new Size(75, 42);
            menha.TabIndex = 11;
            menha.Tag = "";
            menha.Text = "-";
            menha.UseVisualStyleBackColor = false;
            menha.Click += HandleOptr;
            // 
            // zarb
            // 
            zarb.BackColor = Color.FromArgb(0, 192, 0);
            zarb.Location = new Point(332, 234);
            zarb.Name = "zarb";
            zarb.Size = new Size(75, 41);
            zarb.TabIndex = 12;
            zarb.Tag = "";
            zarb.Text = "*";
            zarb.UseVisualStyleBackColor = false;
            zarb.Click += HandleOptr;
            // 
            // taghsim
            // 
            taghsim.BackColor = Color.FromArgb(0, 192, 0);
            taghsim.Location = new Point(332, 187);
            taghsim.Name = "taghsim";
            taghsim.Size = new Size(75, 41);
            taghsim.TabIndex = 13;
            taghsim.Tag = "";
            taghsim.Text = "/";
            taghsim.UseVisualStyleBackColor = false;
            taghsim.Click += HandleOptr;
            // 
            // Number0
            // 
            Number0.BackColor = SystemColors.ButtonHighlight;
            Number0.Location = new Point(142, 415);
            Number0.Name = "Number0";
            Number0.Size = new Size(75, 23);
            Number0.TabIndex = 14;
            Number0.Text = "0";
            Number0.UseVisualStyleBackColor = false;
            Number0.Click += HandleNumberClick;
            // 
            // display
            // 
            display.AutoSize = true;
            display.BackColor = Color.White;
            display.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            display.Location = new Point(56, 140);
            display.Name = "display";
            display.Size = new Size(23, 28);
            display.TabIndex = 15;
            display.Text = "0";
            display.PreviewKeyDown += keyDown;
            // 
            // oneClick
            // 
            oneClick.BackColor = SystemColors.HotTrack;
            oneClick.Location = new Point(232, 187);
            oneClick.Name = "oneClick";
            oneClick.Size = new Size(75, 41);
            oneClick.TabIndex = 16;
            oneClick.Text = "<-";
            oneClick.UseVisualStyleBackColor = false;
            oneClick.Click += backspaceClick;
            // 
            // fullclear
            // 
            fullclear.BackColor = SystemColors.HotTrack;
            fullclear.Location = new Point(142, 187);
            fullclear.Name = "fullclear";
            fullclear.Size = new Size(75, 41);
            fullclear.TabIndex = 17;
            fullclear.Text = "C";
            fullclear.UseVisualStyleBackColor = false;
            fullclear.Click += FullClear;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(46, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "+/-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ChangeSign;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(174, 105);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 19;
            label1.Text = "CALCULATOR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(419, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(fullclear);
            Controls.Add(oneClick);
            Controls.Add(display);
            Controls.Add(Number0);
            Controls.Add(taghsim);
            Controls.Add(zarb);
            Controls.Add(menha);
            Controls.Add(plus);
            Controls.Add(mosavi);
            Controls.Add(Number9);
            Controls.Add(Number8);
            Controls.Add(Number7);
            Controls.Add(Number6);
            Controls.Add(Number5);
            Controls.Add(Number4);
            Controls.Add(Number3);
            Controls.Add(Number2);
            Controls.Add(Number1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Number1;
        private Button Number2;
        private Button Number3;
        private Button Number4;
        private Button Number5;
        private Button Number6;
        private Button Number7;
        private Button Number8;
        private Button Number9;
        private Button mosavi;
        private Button plus;
        private Button menha;
        private Button zarb;
        private Button taghsim;
        private Button Number0;
        private Label display;
        private Button oneClick;
        private Button fullclear;
        private Button button1;
        private Label label1;
    }
}