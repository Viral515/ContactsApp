namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContactsPanel = new System.Windows.Forms.Panel();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveContactButton = new System.Windows.Forms.PictureBox();
            this.EditContactButton = new System.Windows.Forms.PictureBox();
            this.AddContactButton = new System.Windows.Forms.PictureBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ContactInfoPanel = new System.Windows.Forms.Panel();
            this.DateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanelCloseButton = new System.Windows.Forms.Button();
            this.BirthdaySurnamesLabel = new System.Windows.Forms.Label();
            this.TodayBirthdayLabel = new System.Windows.Forms.Label();
            this.InfoPicture = new System.Windows.Forms.PictureBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.ContactsPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).BeginInit();
            this.ContactInfoPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.ContactsPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ContactInfoPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // ContactsPanel
            // 
            this.ContactsPanel.Controls.Add(this.ContactsListBox);
            this.ContactsPanel.Controls.Add(this.ButtonsTableLayoutPanel);
            this.ContactsPanel.Controls.Add(this.FindLabel);
            this.ContactsPanel.Controls.Add(this.FindTextBox);
            this.ContactsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsPanel.Location = new System.Drawing.Point(3, 3);
            this.ContactsPanel.Name = "ContactsPanel";
            this.ContactsPanel.Size = new System.Drawing.Size(244, 444);
            this.ContactsPanel.TabIndex = 0;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.ItemHeight = 15;
            this.ContactsListBox.Location = new System.Drawing.Point(3, 32);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(238, 374);
            this.ContactsListBox.TabIndex = 4;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveContactButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditContactButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddContactButton, 0, 0);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 404);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(238, 35);
            this.ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.RemoveContactButton.Location = new System.Drawing.Point(158, 0);
            this.RemoveContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(80, 35);
            this.RemoveContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveContactButton.TabIndex = 2;
            this.RemoveContactButton.TabStop = false;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            this.RemoveContactButton.MouseEnter += new System.EventHandler(this.RemoveContactButton_MouseEnter);
            this.RemoveContactButton.MouseLeave += new System.EventHandler(this.RemoveContactButton_MouseLeave);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditContactButton.Location = new System.Drawing.Point(79, 0);
            this.EditContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(79, 35);
            this.EditContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EditContactButton.TabIndex = 3;
            this.EditContactButton.TabStop = false;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            this.EditContactButton.MouseEnter += new System.EventHandler(this.EditContactButton_MouseEnter);
            this.EditContactButton.MouseLeave += new System.EventHandler(this.EditContactButton_MouseLeave);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddContactButton.Location = new System.Drawing.Point(0, 0);
            this.AddContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(79, 35);
            this.AddContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddContactButton.TabIndex = 4;
            this.AddContactButton.TabStop = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            this.AddContactButton.MouseEnter += new System.EventHandler(this.AddContactButton_MouseEnter);
            this.AddContactButton.MouseLeave += new System.EventHandler(this.AddContactButton_MouseLeave);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindLabel.Location = new System.Drawing.Point(3, 6);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(33, 15);
            this.FindLabel.TabIndex = 2;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindTextBox.Location = new System.Drawing.Point(45, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(196, 23);
            this.FindTextBox.TabIndex = 1;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // ContactInfoPanel
            // 
            this.ContactInfoPanel.Controls.Add(this.DateOfBirthTimePicker);
            this.ContactInfoPanel.Controls.Add(this.BirthdayPanel);
            this.ContactInfoPanel.Controls.Add(this.VKTextBox);
            this.ContactInfoPanel.Controls.Add(this.VKLabel);
            this.ContactInfoPanel.Controls.Add(this.DateOfBirthLabel);
            this.ContactInfoPanel.Controls.Add(this.PhoneNumberTextBox);
            this.ContactInfoPanel.Controls.Add(this.PhoneNumberLabel);
            this.ContactInfoPanel.Controls.Add(this.EmailTextBox);
            this.ContactInfoPanel.Controls.Add(this.EmailLabel);
            this.ContactInfoPanel.Controls.Add(this.FullNameTextBox);
            this.ContactInfoPanel.Controls.Add(this.FullNameLabel);
            this.ContactInfoPanel.Controls.Add(this.PhotoPictureBox);
            this.ContactInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactInfoPanel.Location = new System.Drawing.Point(253, 3);
            this.ContactInfoPanel.Name = "ContactInfoPanel";
            this.ContactInfoPanel.Size = new System.Drawing.Size(544, 444);
            this.ContactInfoPanel.TabIndex = 1;
            // 
            // DateOfBirthTimePicker
            // 
            this.DateOfBirthTimePicker.Location = new System.Drawing.Point(109, 191);
            this.DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            this.DateOfBirthTimePicker.Size = new System.Drawing.Size(175, 20);
            this.DateOfBirthTimePicker.TabIndex = 12;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BirthdayPanel.Controls.Add(this.BirthdayPanelCloseButton);
            this.BirthdayPanel.Controls.Add(this.BirthdaySurnamesLabel);
            this.BirthdayPanel.Controls.Add(this.TodayBirthdayLabel);
            this.BirthdayPanel.Controls.Add(this.InfoPicture);
            this.BirthdayPanel.Location = new System.Drawing.Point(3, 364);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(538, 76);
            this.BirthdayPanel.TabIndex = 11;
            // 
            // BirthdayPanelCloseButton
            // 
            this.BirthdayPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanelCloseButton.FlatAppearance.BorderSize = 0;
            this.BirthdayPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BirthdayPanelCloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.BirthdayPanelCloseButton.Location = new System.Drawing.Point(503, 3);
            this.BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            this.BirthdayPanelCloseButton.Size = new System.Drawing.Size(32, 32);
            this.BirthdayPanelCloseButton.TabIndex = 14;
            this.BirthdayPanelCloseButton.UseVisualStyleBackColor = true;
            this.BirthdayPanelCloseButton.Click += new System.EventHandler(this.BirthdayPanelCloseButton_Click);
            // 
            // BirthdaySurnamesLabel
            // 
            this.BirthdaySurnamesLabel.AutoSize = true;
            this.BirthdaySurnamesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdaySurnamesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdaySurnamesLabel.Location = new System.Drawing.Point(78, 42);
            this.BirthdaySurnamesLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.BirthdaySurnamesLabel.Name = "BirthdaySurnamesLabel";
            this.BirthdaySurnamesLabel.Size = new System.Drawing.Size(221, 15);
            this.BirthdaySurnamesLabel.TabIndex = 13;
            this.BirthdaySurnamesLabel.Text = "Абакумов, Бондарева, Смирнов и др.";
            // 
            // TodayBirthdayLabel
            // 
            this.TodayBirthdayLabel.AutoSize = true;
            this.TodayBirthdayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TodayBirthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.TodayBirthdayLabel.Location = new System.Drawing.Point(78, 23);
            this.TodayBirthdayLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.TodayBirthdayLabel.Name = "TodayBirthdayLabel";
            this.TodayBirthdayLabel.Size = new System.Drawing.Size(118, 15);
            this.TodayBirthdayLabel.TabIndex = 12;
            this.TodayBirthdayLabel.Text = "Today is Birthday of:";
            // 
            // InfoPicture
            // 
            this.InfoPicture.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.InfoPicture.Location = new System.Drawing.Point(3, 3);
            this.InfoPicture.Name = "InfoPicture";
            this.InfoPicture.Size = new System.Drawing.Size(69, 70);
            this.InfoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InfoPicture.TabIndex = 0;
            this.InfoPicture.TabStop = false;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VKTextBox.Location = new System.Drawing.Point(109, 242);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(175, 23);
            this.VKTextBox.TabIndex = 10;
            this.VKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VKTextBox_KeyPress);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VKLabel.Location = new System.Drawing.Point(109, 224);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 15);
            this.VKLabel.TabIndex = 9;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthLabel.Location = new System.Drawing.Point(109, 170);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(76, 15);
            this.DateOfBirthLabel.TabIndex = 7;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(109, 134);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(175, 23);
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(109, 116);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(88, 15);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(109, 80);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(432, 23);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(109, 60);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 15);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameTextBox.Location = new System.Drawing.Point(109, 24);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(432, 23);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(109, 6);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.ContactsPanel.ResumeLayout(false);
            this.ContactsPanel.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).EndInit();
            this.ContactInfoPanel.ResumeLayout(false);
            this.ContactInfoPanel.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Panel ContactsPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Panel ContactInfoPanel;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.PictureBox InfoPicture;
        private System.Windows.Forms.Label TodayBirthdayLabel;
        private System.Windows.Forms.Label BirthdaySurnamesLabel;
        private System.Windows.Forms.Button BirthdayPanelCloseButton;
        private System.Windows.Forms.PictureBox RemoveContactButton;
        private System.Windows.Forms.PictureBox EditContactButton;
        private System.Windows.Forms.PictureBox AddContactButton;
        private System.Windows.Forms.DateTimePicker DateOfBirthTimePicker;
    }
}

