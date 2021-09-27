namespace Assignment6
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
            this.components = new System.ComponentModel.Container();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cboxPriority = new System.Windows.Forms.ComboBox();
            this.lblToDo = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboxToDo = new System.Windows.Forms.GroupBox();
            this.lboxToDo = new System.Windows.Forms.ListBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblListPriority = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gboxToDo.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Location = new System.Drawing.Point(35, 48);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(77, 13);
            this.lblDateAndTime.TabIndex = 0;
            this.lblDateAndTime.Text = "Date and Time";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(149, 48);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dateTimePicker, "Click on the calender to pick a date, then type in time in HH:mm");
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(432, 48);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(38, 13);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "Priority";
            // 
            // cboxPriority
            // 
            this.cboxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPriority.FormattingEnabled = true;
            this.cboxPriority.Location = new System.Drawing.Point(496, 48);
            this.cboxPriority.Name = "cboxPriority";
            this.cboxPriority.Size = new System.Drawing.Size(121, 21);
            this.cboxPriority.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboxPriority, "Select a priority for your task");
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Location = new System.Drawing.Point(35, 104);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(37, 13);
            this.lblToDo.TabIndex = 4;
            this.lblToDo.Text = "To Do";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 101);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(520, 20);
            this.txtDescription.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDescription, "Add description of your task here");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(323, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Click here to add a user after entering information");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gboxToDo
            // 
            this.gboxToDo.Controls.Add(this.lboxToDo);
            this.gboxToDo.Controls.Add(this.lblDescription);
            this.gboxToDo.Controls.Add(this.lblListPriority);
            this.gboxToDo.Controls.Add(this.lblHour);
            this.gboxToDo.Controls.Add(this.lblDate);
            this.gboxToDo.ForeColor = System.Drawing.Color.ForestGreen;
            this.gboxToDo.Location = new System.Drawing.Point(35, 207);
            this.gboxToDo.Name = "gboxToDo";
            this.gboxToDo.Size = new System.Drawing.Size(729, 209);
            this.gboxToDo.TabIndex = 7;
            this.gboxToDo.TabStop = false;
            this.gboxToDo.Text = "To Do";
            // 
            // lboxToDo
            // 
            this.lboxToDo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxToDo.FormattingEnabled = true;
            this.lboxToDo.ItemHeight = 14;
            this.lboxToDo.Location = new System.Drawing.Point(8, 36);
            this.lboxToDo.Name = "lboxToDo";
            this.lboxToDo.Size = new System.Drawing.Size(720, 158);
            this.lboxToDo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.lboxToDo, "Select an item to enable the Change and Delete buttons");
            this.lboxToDo.SelectedIndexChanged += new System.EventHandler(this.lboxToDo_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(509, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblListPriority
            // 
            this.lblListPriority.AutoSize = true;
            this.lblListPriority.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListPriority.Location = new System.Drawing.Point(304, 16);
            this.lblListPriority.Name = "lblListPriority";
            this.lblListPriority.Size = new System.Drawing.Size(38, 13);
            this.lblListPriority.TabIndex = 2;
            this.lblListPriority.Text = "Priority";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHour.Location = new System.Drawing.Point(157, 16);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(30, 13);
            this.lblHour.TabIndex = 1;
            this.lblHour.Text = "Hour";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(7, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(97, 422);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(115, 29);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Change";
            this.toolTip1.SetToolTip(this.btnChange, "Click here to change the selected task to the new information");
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(283, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnDelete, "Click here to delete the selected item");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(709, 431);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 13);
            this.lblClock.TabIndex = 10;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 11;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openDataFileToolStripMenuItem,
            this.saveDataFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openDataFileToolStripMenuItem
            // 
            this.openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            this.openDataFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openDataFileToolStripMenuItem.Text = "Open data file";
            this.openDataFileToolStripMenuItem.Click += new System.EventHandler(this.openDataFileToolStripMenuItem_Click);
            // 
            // saveDataFileToolStripMenuItem
            // 
            this.saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            this.saveDataFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveDataFileToolStripMenuItem.Text = "Save data file";
            this.saveDataFileToolStripMenuItem.Click += new System.EventHandler(this.saveDataFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit           Alt+F4";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.gboxToDo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.cboxPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "ToDo Reminder by Patrik Österljung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.gboxToDo.ResumeLayout(false);
            this.gboxToDo.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cboxPriority;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gboxToDo;
        private System.Windows.Forms.ListBox lboxToDo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblListPriority;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

