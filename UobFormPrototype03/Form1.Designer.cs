namespace UobFormPrototype03
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
            this.ServerSelectionPanel = new System.Windows.Forms.Panel();
            this.ServerAccessButton = new System.Windows.Forms.Button();
            this.ServerDisplayTextBox = new System.Windows.Forms.TextBox();
            this.ServerSelectionLabel = new System.Windows.Forms.Label();
            this.ServerListView = new System.Windows.Forms.ListView();
            this.ServerControlPanel = new System.Windows.Forms.TabControl();
            this.SystemInformationTab = new System.Windows.Forms.TabPage();
            this.SystemInformationLoadButton = new System.Windows.Forms.Button();
            this.SystemInformationBackButton = new System.Windows.Forms.Button();
            this.SystemInformationListView = new System.Windows.Forms.ListView();
            this.ProcessesTab = new System.Windows.Forms.TabPage();
            this.ProcessBackButton = new System.Windows.Forms.Button();
            this.ProcessesLoadButton = new System.Windows.Forms.Button();
            this.ProcessesStopButton = new System.Windows.Forms.Button();
            this.ProcessesLabel = new System.Windows.Forms.Label();
            this.ProcessesTextBox = new System.Windows.Forms.TextBox();
            this.ProcessInformationListView = new System.Windows.Forms.ListView();
            this.ServicesTab = new System.Windows.Forms.TabPage();
            this.ServicesBackButton = new System.Windows.Forms.Button();
            this.ServicesStartButton = new System.Windows.Forms.Button();
            this.ServicesLoadButton = new System.Windows.Forms.Button();
            this.ServicesStopButton = new System.Windows.Forms.Button();
            this.ServicesLabel = new System.Windows.Forms.Label();
            this.ServicesTextBox = new System.Windows.Forms.TextBox();
            this.ServiceInformationListView = new System.Windows.Forms.ListView();
            this.OperatorAssistantTextBox = new System.Windows.Forms.RichTextBox();
            this.ServerListRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServerSelectionPanel.SuspendLayout();
            this.ServerControlPanel.SuspendLayout();
            this.SystemInformationTab.SuspendLayout();
            this.ProcessesTab.SuspendLayout();
            this.ServicesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerSelectionPanel
            // 
            this.ServerSelectionPanel.Controls.Add(this.ServerListRichTextBox);
            this.ServerSelectionPanel.Controls.Add(this.ServerAccessButton);
            this.ServerSelectionPanel.Controls.Add(this.ServerDisplayTextBox);
            this.ServerSelectionPanel.Controls.Add(this.ServerSelectionLabel);
            this.ServerSelectionPanel.Controls.Add(this.ServerListView);
            this.ServerSelectionPanel.Location = new System.Drawing.Point(153, 24);
            this.ServerSelectionPanel.Name = "ServerSelectionPanel";
            this.ServerSelectionPanel.Size = new System.Drawing.Size(612, 374);
            this.ServerSelectionPanel.TabIndex = 0;
            this.ServerSelectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ServerSelectionPanel_Paint);
            // 
            // ServerAccessButton
            // 
            this.ServerAccessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerAccessButton.Location = new System.Drawing.Point(40, 122);
            this.ServerAccessButton.Name = "ServerAccessButton";
            this.ServerAccessButton.Size = new System.Drawing.Size(105, 29);
            this.ServerAccessButton.TabIndex = 3;
            this.ServerAccessButton.Text = "Access";
            this.ServerAccessButton.UseVisualStyleBackColor = true;
            this.ServerAccessButton.Click += new System.EventHandler(this.ServerAccessButton_Click);
            // 
            // ServerDisplayTextBox
            // 
            this.ServerDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerDisplayTextBox.Location = new System.Drawing.Point(40, 68);
            this.ServerDisplayTextBox.Name = "ServerDisplayTextBox";
            this.ServerDisplayTextBox.Size = new System.Drawing.Size(180, 22);
            this.ServerDisplayTextBox.TabIndex = 2;
            // 
            // ServerSelectionLabel
            // 
            this.ServerSelectionLabel.AutoSize = true;
            this.ServerSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerSelectionLabel.Location = new System.Drawing.Point(36, 45);
            this.ServerSelectionLabel.Name = "ServerSelectionLabel";
            this.ServerSelectionLabel.Size = new System.Drawing.Size(129, 20);
            this.ServerSelectionLabel.TabIndex = 1;
            this.ServerSelectionLabel.Text = "Server to Access";
            // 
            // ServerListView
            // 
            this.ServerListView.FullRowSelect = true;
            this.ServerListView.Location = new System.Drawing.Point(239, 45);
            this.ServerListView.MultiSelect = false;
            this.ServerListView.Name = "ServerListView";
            this.ServerListView.Size = new System.Drawing.Size(353, 212);
            this.ServerListView.TabIndex = 0;
            this.ServerListView.UseCompatibleStateImageBehavior = false;
            this.ServerListView.View = System.Windows.Forms.View.Details;
            this.ServerListView.SelectedIndexChanged += new System.EventHandler(this.ServerListView_SelectedIndexChanged);
            // 
            // ServerControlPanel
            // 
            this.ServerControlPanel.Controls.Add(this.SystemInformationTab);
            this.ServerControlPanel.Controls.Add(this.ProcessesTab);
            this.ServerControlPanel.Controls.Add(this.ServicesTab);
            this.ServerControlPanel.Location = new System.Drawing.Point(168, 24);
            this.ServerControlPanel.Name = "ServerControlPanel";
            this.ServerControlPanel.SelectedIndex = 0;
            this.ServerControlPanel.Size = new System.Drawing.Size(608, 434);
            this.ServerControlPanel.TabIndex = 1;
            this.ServerControlPanel.SelectedIndexChanged += new System.EventHandler(this.ServerControlPanel_SelectedIndexChanged);
            // 
            // SystemInformationTab
            // 
            this.SystemInformationTab.Controls.Add(this.SystemInformationLoadButton);
            this.SystemInformationTab.Controls.Add(this.SystemInformationBackButton);
            this.SystemInformationTab.Controls.Add(this.SystemInformationListView);
            this.SystemInformationTab.Location = new System.Drawing.Point(4, 22);
            this.SystemInformationTab.Name = "SystemInformationTab";
            this.SystemInformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.SystemInformationTab.Size = new System.Drawing.Size(600, 408);
            this.SystemInformationTab.TabIndex = 0;
            this.SystemInformationTab.Text = "System Information";
            this.SystemInformationTab.UseVisualStyleBackColor = true;
            // 
            // SystemInformationLoadButton
            // 
            this.SystemInformationLoadButton.Location = new System.Drawing.Point(216, 16);
            this.SystemInformationLoadButton.Name = "SystemInformationLoadButton";
            this.SystemInformationLoadButton.Size = new System.Drawing.Size(164, 23);
            this.SystemInformationLoadButton.TabIndex = 2;
            this.SystemInformationLoadButton.Text = "Load System Information";
            this.SystemInformationLoadButton.UseVisualStyleBackColor = true;
            this.SystemInformationLoadButton.Click += new System.EventHandler(this.SystemInformationLoadButton_Click);
            // 
            // SystemInformationBackButton
            // 
            this.SystemInformationBackButton.Location = new System.Drawing.Point(266, 358);
            this.SystemInformationBackButton.Name = "SystemInformationBackButton";
            this.SystemInformationBackButton.Size = new System.Drawing.Size(75, 23);
            this.SystemInformationBackButton.TabIndex = 1;
            this.SystemInformationBackButton.Text = "Back";
            this.SystemInformationBackButton.UseVisualStyleBackColor = true;
            this.SystemInformationBackButton.Click += new System.EventHandler(this.SystemInformationBackButton_Click);
            // 
            // SystemInformationListView
            // 
            this.SystemInformationListView.Location = new System.Drawing.Point(59, 45);
            this.SystemInformationListView.Name = "SystemInformationListView";
            this.SystemInformationListView.Size = new System.Drawing.Size(494, 285);
            this.SystemInformationListView.TabIndex = 0;
            this.SystemInformationListView.UseCompatibleStateImageBehavior = false;
            this.SystemInformationListView.View = System.Windows.Forms.View.Details;
            // 
            // ProcessesTab
            // 
            this.ProcessesTab.Controls.Add(this.ProcessBackButton);
            this.ProcessesTab.Controls.Add(this.ProcessesLoadButton);
            this.ProcessesTab.Controls.Add(this.ProcessesStopButton);
            this.ProcessesTab.Controls.Add(this.ProcessesLabel);
            this.ProcessesTab.Controls.Add(this.ProcessesTextBox);
            this.ProcessesTab.Controls.Add(this.ProcessInformationListView);
            this.ProcessesTab.Location = new System.Drawing.Point(4, 22);
            this.ProcessesTab.Name = "ProcessesTab";
            this.ProcessesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProcessesTab.Size = new System.Drawing.Size(600, 408);
            this.ProcessesTab.TabIndex = 1;
            this.ProcessesTab.Text = "Processes";
            this.ProcessesTab.UseVisualStyleBackColor = true;
            // 
            // ProcessBackButton
            // 
            this.ProcessBackButton.Location = new System.Drawing.Point(327, 359);
            this.ProcessBackButton.Name = "ProcessBackButton";
            this.ProcessBackButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessBackButton.TabIndex = 6;
            this.ProcessBackButton.Text = "Back";
            this.ProcessBackButton.UseVisualStyleBackColor = true;
            this.ProcessBackButton.Click += new System.EventHandler(this.ProcessBackButton_Click);
            // 
            // ProcessesLoadButton
            // 
            this.ProcessesLoadButton.Location = new System.Drawing.Point(278, 16);
            this.ProcessesLoadButton.Name = "ProcessesLoadButton";
            this.ProcessesLoadButton.Size = new System.Drawing.Size(163, 23);
            this.ProcessesLoadButton.TabIndex = 5;
            this.ProcessesLoadButton.Text = "Load Processes";
            this.ProcessesLoadButton.UseVisualStyleBackColor = true;
            this.ProcessesLoadButton.Click += new System.EventHandler(this.ProcessesLoadButton_Click);
            // 
            // ProcessesStopButton
            // 
            this.ProcessesStopButton.Location = new System.Drawing.Point(40, 102);
            this.ProcessesStopButton.Name = "ProcessesStopButton";
            this.ProcessesStopButton.Size = new System.Drawing.Size(77, 23);
            this.ProcessesStopButton.TabIndex = 4;
            this.ProcessesStopButton.Text = "Stop";
            this.ProcessesStopButton.UseVisualStyleBackColor = true;
            this.ProcessesStopButton.Click += new System.EventHandler(this.ProcessesStopButton_Click);
            // 
            // ProcessesLabel
            // 
            this.ProcessesLabel.AutoSize = true;
            this.ProcessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessesLabel.Location = new System.Drawing.Point(13, 60);
            this.ProcessesLabel.Name = "ProcessesLabel";
            this.ProcessesLabel.Size = new System.Drawing.Size(118, 16);
            this.ProcessesLabel.TabIndex = 2;
            this.ProcessesLabel.Text = "Process Selected:";
            // 
            // ProcessesTextBox
            // 
            this.ProcessesTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProcessesTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProcessesTextBox.Location = new System.Drawing.Point(16, 76);
            this.ProcessesTextBox.Name = "ProcessesTextBox";
            this.ProcessesTextBox.Size = new System.Drawing.Size(124, 20);
            this.ProcessesTextBox.TabIndex = 1;
            // 
            // ProcessInformationListView
            // 
            this.ProcessInformationListView.FullRowSelect = true;
            this.ProcessInformationListView.Location = new System.Drawing.Point(161, 45);
            this.ProcessInformationListView.Name = "ProcessInformationListView";
            this.ProcessInformationListView.Size = new System.Drawing.Size(409, 296);
            this.ProcessInformationListView.TabIndex = 0;
            this.ProcessInformationListView.UseCompatibleStateImageBehavior = false;
            this.ProcessInformationListView.View = System.Windows.Forms.View.Details;
            this.ProcessInformationListView.SelectedIndexChanged += new System.EventHandler(this.ProcessInformationListView_SelectedIndexChanged);
            // 
            // ServicesTab
            // 
            this.ServicesTab.Controls.Add(this.ServicesBackButton);
            this.ServicesTab.Controls.Add(this.ServicesStartButton);
            this.ServicesTab.Controls.Add(this.ServicesLoadButton);
            this.ServicesTab.Controls.Add(this.ServicesStopButton);
            this.ServicesTab.Controls.Add(this.ServicesLabel);
            this.ServicesTab.Controls.Add(this.ServicesTextBox);
            this.ServicesTab.Controls.Add(this.ServiceInformationListView);
            this.ServicesTab.Location = new System.Drawing.Point(4, 22);
            this.ServicesTab.Name = "ServicesTab";
            this.ServicesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServicesTab.Size = new System.Drawing.Size(600, 408);
            this.ServicesTab.TabIndex = 2;
            this.ServicesTab.Text = "Services";
            this.ServicesTab.UseVisualStyleBackColor = true;
            // 
            // ServicesBackButton
            // 
            this.ServicesBackButton.Location = new System.Drawing.Point(326, 370);
            this.ServicesBackButton.Name = "ServicesBackButton";
            this.ServicesBackButton.Size = new System.Drawing.Size(75, 23);
            this.ServicesBackButton.TabIndex = 12;
            this.ServicesBackButton.Text = "Back";
            this.ServicesBackButton.UseVisualStyleBackColor = true;
            this.ServicesBackButton.Click += new System.EventHandler(this.ServicesBackButton_Click);
            // 
            // ServicesStartButton
            // 
            this.ServicesStartButton.Location = new System.Drawing.Point(49, 145);
            this.ServicesStartButton.Name = "ServicesStartButton";
            this.ServicesStartButton.Size = new System.Drawing.Size(77, 23);
            this.ServicesStartButton.TabIndex = 11;
            this.ServicesStartButton.Text = "Start";
            this.ServicesStartButton.UseVisualStyleBackColor = true;
            this.ServicesStartButton.Click += new System.EventHandler(this.ServicesStartButton_Click);
            // 
            // ServicesLoadButton
            // 
            this.ServicesLoadButton.Location = new System.Drawing.Point(287, 30);
            this.ServicesLoadButton.Name = "ServicesLoadButton";
            this.ServicesLoadButton.Size = new System.Drawing.Size(163, 23);
            this.ServicesLoadButton.TabIndex = 10;
            this.ServicesLoadButton.Text = "Load Services";
            this.ServicesLoadButton.UseVisualStyleBackColor = true;
            this.ServicesLoadButton.Click += new System.EventHandler(this.ServicesLoadButton_Click);
            // 
            // ServicesStopButton
            // 
            this.ServicesStopButton.Location = new System.Drawing.Point(49, 116);
            this.ServicesStopButton.Name = "ServicesStopButton";
            this.ServicesStopButton.Size = new System.Drawing.Size(77, 23);
            this.ServicesStopButton.TabIndex = 9;
            this.ServicesStopButton.Text = "Stop";
            this.ServicesStopButton.UseVisualStyleBackColor = true;
            this.ServicesStopButton.Click += new System.EventHandler(this.ServicesStopButton_Click);
            // 
            // ServicesLabel
            // 
            this.ServicesLabel.AutoSize = true;
            this.ServicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesLabel.Location = new System.Drawing.Point(22, 74);
            this.ServicesLabel.Name = "ServicesLabel";
            this.ServicesLabel.Size = new System.Drawing.Size(114, 16);
            this.ServicesLabel.TabIndex = 8;
            this.ServicesLabel.Text = "Service Selected:";
            // 
            // ServicesTextBox
            // 
            this.ServicesTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ServicesTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ServicesTextBox.Location = new System.Drawing.Point(25, 90);
            this.ServicesTextBox.Name = "ServicesTextBox";
            this.ServicesTextBox.Size = new System.Drawing.Size(124, 20);
            this.ServicesTextBox.TabIndex = 7;
            // 
            // ServiceInformationListView
            // 
            this.ServiceInformationListView.FullRowSelect = true;
            this.ServiceInformationListView.Location = new System.Drawing.Point(170, 59);
            this.ServiceInformationListView.Name = "ServiceInformationListView";
            this.ServiceInformationListView.Size = new System.Drawing.Size(409, 296);
            this.ServiceInformationListView.TabIndex = 6;
            this.ServiceInformationListView.UseCompatibleStateImageBehavior = false;
            this.ServiceInformationListView.View = System.Windows.Forms.View.Details;
            this.ServiceInformationListView.SelectedIndexChanged += new System.EventHandler(this.ServiceInformationListView_SelectedIndexChanged);
            // 
            // OperatorAssistantTextBox
            // 
            this.OperatorAssistantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorAssistantTextBox.Location = new System.Drawing.Point(12, 62);
            this.OperatorAssistantTextBox.Name = "OperatorAssistantTextBox";
            this.OperatorAssistantTextBox.Size = new System.Drawing.Size(135, 131);
            this.OperatorAssistantTextBox.TabIndex = 2;
            this.OperatorAssistantTextBox.Text = "";
            // 
            // ServerListRichTextBox
            // 
            this.ServerListRichTextBox.Location = new System.Drawing.Point(3, 161);
            this.ServerListRichTextBox.Name = "ServerListRichTextBox";
            this.ServerListRichTextBox.Size = new System.Drawing.Size(230, 210);
            this.ServerListRichTextBox.TabIndex = 4;
            this.ServerListRichTextBox.Text = "";
            this.ServerListRichTextBox.TextChanged += new System.EventHandler(this.ServerListRichTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.ServerSelectionPanel);
            this.Controls.Add(this.OperatorAssistantTextBox);
            this.Controls.Add(this.ServerControlPanel);
            this.Name = "Form1";
            this.Text = "Server Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ServerSelectionPanel.ResumeLayout(false);
            this.ServerSelectionPanel.PerformLayout();
            this.ServerControlPanel.ResumeLayout(false);
            this.SystemInformationTab.ResumeLayout(false);
            this.ProcessesTab.ResumeLayout(false);
            this.ProcessesTab.PerformLayout();
            this.ServicesTab.ResumeLayout(false);
            this.ServicesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ServerSelectionPanel;
        private System.Windows.Forms.Label ServerSelectionLabel;
        private System.Windows.Forms.ListView ServerListView;
        private System.Windows.Forms.Button ServerAccessButton;
        private System.Windows.Forms.TextBox ServerDisplayTextBox;
        private System.Windows.Forms.TabControl ServerControlPanel;
        private System.Windows.Forms.TabPage SystemInformationTab;
        private System.Windows.Forms.ListView SystemInformationListView;
        private System.Windows.Forms.TabPage ProcessesTab;
        private System.Windows.Forms.Button SystemInformationBackButton;
        private System.Windows.Forms.ListView ProcessInformationListView;
        private System.Windows.Forms.RichTextBox OperatorAssistantTextBox;
        private System.Windows.Forms.TabPage ServicesTab;
        private System.Windows.Forms.Button ProcessesStopButton;
        private System.Windows.Forms.Label ProcessesLabel;
        private System.Windows.Forms.TextBox ProcessesTextBox;
        private System.Windows.Forms.Button ProcessesLoadButton;
        private System.Windows.Forms.Button SystemInformationLoadButton;
        private System.Windows.Forms.Button ProcessBackButton;
        private System.Windows.Forms.Button ServicesStartButton;
        private System.Windows.Forms.Button ServicesLoadButton;
        private System.Windows.Forms.Button ServicesStopButton;
        private System.Windows.Forms.Label ServicesLabel;
        private System.Windows.Forms.TextBox ServicesTextBox;
        private System.Windows.Forms.ListView ServiceInformationListView;
        private System.Windows.Forms.Button ServicesBackButton;
        private System.Windows.Forms.RichTextBox ServerListRichTextBox;
    }
}

