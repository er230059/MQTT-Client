namespace MQTT_Client
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.SubTopicTextBox = new System.Windows.Forms.TextBox();
            this.PublishButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.PubMessageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PubTopicTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.QosComboBox = new System.Windows.Forms.ComboBox();
            this.SubListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UnsubscribeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.RetainCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(66, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(-1, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Topic for sub:";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HostTextBox.Location = new System.Drawing.Point(125, 11);
            this.HostTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HostTextBox.MaxLength = 40;
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(332, 23);
            this.HostTextBox.TabIndex = 2;
            // 
            // SubTopicTextBox
            // 
            this.SubTopicTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SubTopicTextBox.Location = new System.Drawing.Point(125, 88);
            this.SubTopicTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubTopicTextBox.MaxLength = 35;
            this.SubTopicTextBox.Name = "SubTopicTextBox";
            this.SubTopicTextBox.Size = new System.Drawing.Size(332, 23);
            this.SubTopicTextBox.TabIndex = 6;
            // 
            // PublishButton
            // 
            this.PublishButton.Enabled = false;
            this.PublishButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PublishButton.Location = new System.Drawing.Point(19, 197);
            this.PublishButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(555, 31);
            this.PublishButton.TabIndex = 9;
            this.PublishButton.Text = "Publish";
            this.PublishButton.UseVisualStyleBackColor = true;
            this.PublishButton.Click += new System.EventHandler(this.PublishButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConnectButton.Location = new System.Drawing.Point(464, 8);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(110, 31);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearButton.Location = new System.Drawing.Point(13, 632);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(559, 31);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MessageTextBox.Location = new System.Drawing.Point(13, 239);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessageTextBox.Size = new System.Drawing.Size(558, 381);
            this.MessageTextBox.TabIndex = 11;
            // 
            // PubMessageTextBox
            // 
            this.PubMessageTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PubMessageTextBox.Location = new System.Drawing.Point(125, 163);
            this.PubMessageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PubMessageTextBox.MaxLength = 50;
            this.PubMessageTextBox.Name = "PubMessageTextBox";
            this.PubMessageTextBox.Size = new System.Drawing.Size(448, 23);
            this.PubMessageTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(34, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Message:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 668);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 10;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DisconnectButton.Location = new System.Drawing.Point(464, 47);
            this.DisconnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(110, 31);
            this.DisconnectButton.TabIndex = 12;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(125, 49);
            this.PortTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortTextBox.MaxLength = 4;
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(52, 23);
            this.PortTextBox.TabIndex = 3;
            this.PortTextBox.Text = "1883";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(70, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Port:";
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Enabled = false;
            this.SubscribeButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SubscribeButton.Location = new System.Drawing.Point(464, 88);
            this.SubscribeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(110, 31);
            this.SubscribeButton.TabIndex = 7;
            this.SubscribeButton.Text = "Subscribe";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(-3, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Topic for pub:";
            // 
            // PubTopicTextBox
            // 
            this.PubTopicTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PubTopicTextBox.Location = new System.Drawing.Point(125, 125);
            this.PubTopicTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PubTopicTextBox.MaxLength = 35;
            this.PubTopicTextBox.Name = "PubTopicTextBox";
            this.PubTopicTextBox.Size = new System.Drawing.Size(448, 23);
            this.PubTopicTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(196, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "QoS:";
            // 
            // QosComboBox
            // 
            this.QosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QosComboBox.FormattingEnabled = true;
            this.QosComboBox.Items.AddRange(new object[] {
            "0 At most once",
            "1 At least once",
            "2 Exactly once"});
            this.QosComboBox.Location = new System.Drawing.Point(244, 48);
            this.QosComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QosComboBox.MaxDropDownItems = 3;
            this.QosComboBox.Name = "QosComboBox";
            this.QosComboBox.Size = new System.Drawing.Size(92, 24);
            this.QosComboBox.TabIndex = 17;
            // 
            // SubListBox
            // 
            this.SubListBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SubListBox.FormattingEnabled = true;
            this.SubListBox.ItemHeight = 16;
            this.SubListBox.Location = new System.Drawing.Point(586, 40);
            this.SubListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubListBox.Name = "SubListBox";
            this.SubListBox.Size = new System.Drawing.Size(179, 580);
            this.SubListBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(582, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Subscriptions topic:";
            // 
            // UnsubscribeButton
            // 
            this.UnsubscribeButton.Enabled = false;
            this.UnsubscribeButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UnsubscribeButton.Location = new System.Drawing.Point(586, 632);
            this.UnsubscribeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UnsubscribeButton.Name = "UnsubscribeButton";
            this.UnsubscribeButton.Size = new System.Drawing.Size(179, 31);
            this.UnsubscribeButton.TabIndex = 20;
            this.UnsubscribeButton.Text = "Unsubscribe";
            this.UnsubscribeButton.UseVisualStyleBackColor = true;
            this.UnsubscribeButton.Click += new System.EventHandler(this.UnsubscribeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(350, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Retain:";
            // 
            // RetainCheckBox
            // 
            this.RetainCheckBox.AutoSize = true;
            this.RetainCheckBox.Location = new System.Drawing.Point(412, 57);
            this.RetainCheckBox.Name = "RetainCheckBox";
            this.RetainCheckBox.Size = new System.Drawing.Size(15, 14);
            this.RetainCheckBox.TabIndex = 22;
            this.RetainCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 701);
            this.Controls.Add(this.RetainCheckBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UnsubscribeButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SubListBox);
            this.Controls.Add(this.QosComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PubTopicTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubscribeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PubMessageTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PublishButton);
            this.Controls.Add(this.SubTopicTextBox);
            this.Controls.Add(this.HostTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = " MQTT Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.TextBox SubTopicTextBox;
        private System.Windows.Forms.Button PublishButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox PubMessageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubscribeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PubTopicTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox QosComboBox;
        private System.Windows.Forms.ListBox SubListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button UnsubscribeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox RetainCheckBox;
    }
}

