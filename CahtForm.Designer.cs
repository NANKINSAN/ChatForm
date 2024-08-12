namespace ChatForm
{
    partial class CahtForm
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
            txtMonitor = new TextBox();
            txtInput = new TextBox();
            btnSend = new Button();
            btnMic = new Button();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            la = new Label();
            txtGetUrl = new TextBox();
            label3 = new Label();
            txtPutUrl = new TextBox();
            label4 = new Label();
            txtPostUrl = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // txtMonitor
            // 
            txtMonitor.Location = new Point(16, 16);
            txtMonitor.Multiline = true;
            txtMonitor.Name = "txtMonitor";
            txtMonitor.ReadOnly = true;
            txtMonitor.Size = new Size(739, 312);
            txtMonitor.TabIndex = 0;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(16, 396);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(458, 23);
            txtInput.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(492, 396);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "送信";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnMic
            // 
            btnMic.Location = new Point(492, 425);
            btnMic.Name = "btnMic";
            btnMic.Size = new Size(75, 23);
            btnMic.TabIndex = 2;
            btnMic.Text = "マイク";
            btnMic.UseVisualStyleBackColor = true;
            btnMic.MouseDown += btnMic_MouseDown;
            btnMic.MouseUp += btnMic_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(573, 429);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 3;
            label1.Text = "クリックしている間き取ります。";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 378);
            label2.Name = "label2";
            label2.Size = new Size(213, 15);
            label2.TabIndex = 4;
            label2.Text = "文字を入力して送信ボタンを押してください。";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 499);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtInput);
            tabPage1.Controls.Add(txtMonitor);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnSend);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnMic);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 471);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "メイン";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtPostUrl);
            tabPage2.Controls.Add(txtPutUrl);
            tabPage2.Controls.Add(txtGetUrl);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(la);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 471);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "メンテナンス";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // la
            // 
            la.AutoSize = true;
            la.Location = new Point(88, 110);
            la.Name = "la";
            la.Size = new Size(43, 15);
            la.TabIndex = 0;
            la.Text = "get_url";
            // 
            // txtGetUrl
            // 
            txtGetUrl.Location = new Point(178, 107);
            txtGetUrl.Name = "txtGetUrl";
            txtGetUrl.Size = new Size(386, 23);
            txtGetUrl.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 152);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "put_url";
            // 
            // txtPutUrl
            // 
            txtPutUrl.Location = new Point(178, 149);
            txtPutUrl.Name = "txtPutUrl";
            txtPutUrl.Size = new Size(386, 23);
            txtPutUrl.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 197);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 0;
            label4.Text = "post_url";
            // 
            // txtPostUrl
            // 
            txtPostUrl.Location = new Point(178, 194);
            txtPostUrl.Name = "txtPostUrl";
            txtPostUrl.Size = new Size(386, 23);
            txtPostUrl.TabIndex = 1;
            // 
            // CahtForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(tabControl1);
            Name = "CahtForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMonitor;
        private TextBox txtInput;
        private Button btnSend;
        private Button btnMic;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtGetUrl;
        private Label la;
        private TextBox txtPostUrl;
        private TextBox txtPutUrl;
        private Label label4;
        private Label label3;
    }
}