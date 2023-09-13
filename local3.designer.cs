
namespace InstallerApp
{
    partial class local3
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
            this.label1 = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.back2 = new System.Windows.Forms.Button();
            this.next2 = new System.Windows.Forms.Button();
            this.FolderName = new System.Windows.Forms.TextBox();
            this.destination = new System.Windows.Forms.ComboBox();
            this.folder = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.direct = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "pleas specify folder information about your application.\r\n";
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information.Location = new System.Drawing.Point(37, 26);
            this.information.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(293, 37);
            this.information.TabIndex = 2;
            this.information.Text = "Application Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Application destination base folder :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Application folder name :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(96, 361);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(347, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Allow userse to change the application folder ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.back2);
            this.panel2.Controls.Add(this.next2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 70);
            this.panel2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(935, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cancel_Click);
            // 
            // back2
            // 
            this.back2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back2.Location = new System.Drawing.Point(599, 12);
            this.back2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(160, 43);
            this.back2.TabIndex = 19;
            this.back2.Text = "Back";
            this.back2.UseVisualStyleBackColor = true;
            this.back2.Click += new System.EventHandler(this.back_Click);
            // 
            // next2
            // 
            this.next2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next2.Location = new System.Drawing.Point(759, 12);
            this.next2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(160, 43);
            this.next2.TabIndex = 18;
            this.next2.Text = "Next";
            this.next2.UseVisualStyleBackColor = true;
            this.next2.Click += new System.EventHandler(this.next_Click);
            // 
            // FolderName
            // 
            this.FolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderName.Location = new System.Drawing.Point(100, 308);
            this.FolderName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FolderName.Name = "FolderName";
            this.FolderName.Size = new System.Drawing.Size(655, 26);
            this.FolderName.TabIndex = 14;
            this.FolderName.Text = "My program";
            this.FolderName.Enter += new System.EventHandler(this.name_Enter);
            this.FolderName.Leave += new System.EventHandler(this.name_Leave);
            // 
            // destination
            // 
            this.destination.AllowDrop = true;
            this.destination.CausesValidation = false;
            this.destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.destination.Items.AddRange(new object[] {
            "DesTop",
            "Other Direct"});
            this.destination.Location = new System.Drawing.Point(100, 175);
            this.destination.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(655, 28);
            this.destination.TabIndex = 12;
            this.destination.Text = "Desktop";
            this.destination.SelectedIndexChanged += new System.EventHandler(this.destination_SelectedIndexChanged);
            // 
            // folder
            // 
            this.folder.AutoSize = true;
            this.folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folder.Location = new System.Drawing.Point(95, 426);
            this.folder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(275, 24);
            this.folder.TabIndex = 15;
            this.folder.Text = "The application dosen\'t need folder";
            this.folder.UseVisualStyleBackColor = true;
            this.folder.CheckedChanged += new System.EventHandler(this.folder_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Other :";
            // 
            // direct
            // 
            this.direct.Enabled = false;
            this.direct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direct.Location = new System.Drawing.Point(100, 210);
            this.direct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.direct.Multiline = true;
            this.direct.Name = "direct";
            this.direct.ReadOnly = true;
            this.direct.Size = new System.Drawing.Size(655, 24);
            this.direct.TabIndex = 13;
            // 
            // local3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 592);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.FolderName);
            this.Controls.Add(this.direct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "local3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox FolderName;
        private System.Windows.Forms.CheckBox folder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox direct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back2;
        private System.Windows.Forms.Button next2;
        private System.Windows.Forms.ComboBox destination;
    }
}