namespace Assignment_4
{
    partial class MainForm
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
            this.guestListBox = new System.Windows.Forms.ListBox();
            this.guestListLabel = new System.Windows.Forms.Label();
            this.newPartyGroupBox = new System.Windows.Forms.GroupBox();
            this.inviteGuestGroupBox = new System.Windows.Forms.GroupBox();
            this.numofGuestLabel = new System.Windows.Forms.Label();
            this.numOfGuestOutputLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.totalFeesLabel = new System.Windows.Forms.Label();
            this.totalFeesOutputLabel = new System.Windows.Forms.Label();
            this.surplusDefLabel = new System.Windows.Forms.Label();
            this.surPlusDefOutputLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guestListBox
            // 
            this.guestListBox.FormattingEnabled = true;
            this.guestListBox.ItemHeight = 25;
            this.guestListBox.Location = new System.Drawing.Point(970, 89);
            this.guestListBox.Name = "guestListBox";
            this.guestListBox.Size = new System.Drawing.Size(661, 729);
            this.guestListBox.TabIndex = 0;
            // 
            // guestListLabel
            // 
            this.guestListLabel.AutoSize = true;
            this.guestListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestListLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.guestListLabel.Location = new System.Drawing.Point(1196, 23);
            this.guestListLabel.Name = "guestListLabel";
            this.guestListLabel.Size = new System.Drawing.Size(196, 42);
            this.guestListLabel.TabIndex = 1;
            this.guestListLabel.Text = "Guest List";
            // 
            // newPartyGroupBox
            // 
            this.newPartyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPartyGroupBox.ForeColor = System.Drawing.SystemColors.Info;
            this.newPartyGroupBox.Location = new System.Drawing.Point(56, 57);
            this.newPartyGroupBox.Name = "newPartyGroupBox";
            this.newPartyGroupBox.Size = new System.Drawing.Size(832, 271);
            this.newPartyGroupBox.TabIndex = 2;
            this.newPartyGroupBox.TabStop = false;
            this.newPartyGroupBox.Text = "New Party";
            // 
            // inviteGuestGroupBox
            // 
            this.inviteGuestGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inviteGuestGroupBox.ForeColor = System.Drawing.SystemColors.Info;
            this.inviteGuestGroupBox.Location = new System.Drawing.Point(56, 371);
            this.inviteGuestGroupBox.Name = "inviteGuestGroupBox";
            this.inviteGuestGroupBox.Size = new System.Drawing.Size(832, 290);
            this.inviteGuestGroupBox.TabIndex = 0;
            this.inviteGuestGroupBox.TabStop = false;
            this.inviteGuestGroupBox.Text = "Invite Guest";
            // 
            // numofGuestLabel
            // 
            this.numofGuestLabel.AutoSize = true;
            this.numofGuestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numofGuestLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.numofGuestLabel.Location = new System.Drawing.Point(49, 699);
            this.numofGuestLabel.Name = "numofGuestLabel";
            this.numofGuestLabel.Size = new System.Drawing.Size(287, 37);
            this.numofGuestLabel.TabIndex = 3;
            this.numofGuestLabel.Text = "Number of guests";
            // 
            // numOfGuestOutputLabel
            // 
            this.numOfGuestOutputLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.numOfGuestOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numOfGuestOutputLabel.Location = new System.Drawing.Point(466, 693);
            this.numOfGuestOutputLabel.Name = "numOfGuestOutputLabel";
            this.numOfGuestOutputLabel.Size = new System.Drawing.Size(410, 43);
            this.numOfGuestOutputLabel.TabIndex = 4;
            this.numOfGuestOutputLabel.Text = "\r\n";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.totalCostLabel.Location = new System.Drawing.Point(49, 774);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(174, 37);
            this.totalCostLabel.TabIndex = 5;
            this.totalCostLabel.Text = "Total Cost";
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(466, 768);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(410, 43);
            this.totalCostOutputLabel.TabIndex = 6;
            this.totalCostOutputLabel.Text = "\r\n";
            // 
            // totalFeesLabel
            // 
            this.totalFeesLabel.AutoSize = true;
            this.totalFeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeesLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.totalFeesLabel.Location = new System.Drawing.Point(49, 844);
            this.totalFeesLabel.Name = "totalFeesLabel";
            this.totalFeesLabel.Size = new System.Drawing.Size(267, 59);
            this.totalFeesLabel.TabIndex = 7;
            this.totalFeesLabel.Text = "Total fees";
            // 
            // totalFeesOutputLabel
            // 
            this.totalFeesOutputLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.totalFeesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFeesOutputLabel.Location = new System.Drawing.Point(466, 834);
            this.totalFeesOutputLabel.Name = "totalFeesOutputLabel";
            this.totalFeesOutputLabel.Size = new System.Drawing.Size(410, 43);
            this.totalFeesOutputLabel.TabIndex = 8;
            this.totalFeesOutputLabel.Text = "\r\n";
            // 
            // surplusDefLabel
            // 
            this.surplusDefLabel.AutoSize = true;
            this.surplusDefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surplusDefLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.surplusDefLabel.Location = new System.Drawing.Point(56, 913);
            this.surplusDefLabel.Name = "surplusDefLabel";
            this.surplusDefLabel.Size = new System.Drawing.Size(373, 59);
            this.surplusDefLabel.TabIndex = 9;
            this.surplusDefLabel.Text = "Surplus/deficit";
            // 
            // surPlusDefOutputLabel
            // 
            this.surPlusDefOutputLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.surPlusDefOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.surPlusDefOutputLabel.Location = new System.Drawing.Point(466, 913);
            this.surPlusDefOutputLabel.Name = "surPlusDefOutputLabel";
            this.surPlusDefOutputLabel.Size = new System.Drawing.Size(410, 43);
            this.surPlusDefOutputLabel.TabIndex = 10;
            this.surPlusDefOutputLabel.Text = "\r\n";
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.MediumPurple;
            this.changeButton.Location = new System.Drawing.Point(1054, 869);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(203, 62);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.MediumPurple;
            this.deleteButton.Location = new System.Drawing.Point(1364, 869);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(203, 62);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1676, 990);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.surPlusDefOutputLabel);
            this.Controls.Add(this.surplusDefLabel);
            this.Controls.Add(this.totalFeesOutputLabel);
            this.Controls.Add(this.totalFeesLabel);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.numOfGuestOutputLabel);
            this.Controls.Add(this.numofGuestLabel);
            this.Controls.Add(this.inviteGuestGroupBox);
            this.Controls.Add(this.newPartyGroupBox);
            this.Controls.Add(this.guestListLabel);
            this.Controls.Add(this.guestListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Party Organizer by Ploypailin Junker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox guestListBox;
        private System.Windows.Forms.Label guestListLabel;
        private System.Windows.Forms.GroupBox newPartyGroupBox;
        private System.Windows.Forms.GroupBox inviteGuestGroupBox;
        private System.Windows.Forms.Label numofGuestLabel;
        private System.Windows.Forms.Label numOfGuestOutputLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.Label totalFeesLabel;
        private System.Windows.Forms.Label totalFeesOutputLabel;
        private System.Windows.Forms.Label surplusDefLabel;
        private System.Windows.Forms.Label surPlusDefOutputLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

