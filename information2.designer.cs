
namespace InstallerApp
{
    partial class information2
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
            this.Form2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.back2 = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.publ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.appvers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.web = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.ver = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.Form2.AutoSize = true;
            this.Form2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form2.Location = new System.Drawing.Point(36, 26);
            this.Form2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(377, 37);
            this.Form2.TabIndex = 0;
            this.Form2.Text = "Application information ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "pleas specify some basic information about your application.\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Controls.Add(this.back2);
            this.panel2.Controls.Add(this.next);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 70);
            this.panel2.TabIndex = 2;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(935, 12);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(160, 43);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // back2
            // 
            this.back2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back2.Location = new System.Drawing.Point(599, 12);
            this.back2.Margin = new System.Windows.Forms.Padding(4);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(160, 43);
            this.back2.TabIndex = 19;
            this.back2.Text = "Back";
            this.back2.UseVisualStyleBackColor = true;
            this.back2.Click += new System.EventHandler(this.Back_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(759, 12);
            this.next.Margin = new System.Windows.Forms.Padding(4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(160, 43);
            this.next.TabIndex = 18;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // publ
            // 
            this.publ.AccessibleName = "input";
            this.publ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publ.Location = new System.Drawing.Point(104, 372);
            this.publ.Margin = new System.Windows.Forms.Padding(4);
            this.publ.Name = "publ";
            this.publ.Size = new System.Drawing.Size(568, 26);
            this.publ.TabIndex = 6;
            this.publ.Text = "My company,inc";
            this.publ.Enter += new System.EventHandler(this.publ_Enter);
            this.publ.Leave += new System.EventHandler(this.publ_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Application name :";
            // 
            // appvers
            // 
            this.appvers.AutoSize = true;
            this.appvers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appvers.Location = new System.Drawing.Point(100, 220);
            this.appvers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appvers.Name = "appvers";
            this.appvers.Size = new System.Drawing.Size(212, 25);
            this.appvers.TabIndex = 8;
            this.appvers.Text = "Application Version :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "application publisher:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "application Websit:\r\n";
            // 
            // web
            // 
            this.web.AccessibleName = "input";
            this.web.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.web.Location = new System.Drawing.Point(104, 447);
            this.web.Margin = new System.Windows.Forms.Padding(4);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(568, 26);
            this.web.TabIndex = 5;
            this.web.Text = "http://www.example.com/";
            this.web.Enter += new System.EventHandler(this.web_Enter);
            this.web.Leave += new System.EventHandler(this.web_Leave);
            // 
            // name
            // 
            this.name.AccessibleName = "input";
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(100, 175);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(572, 26);
            this.name.TabIndex = 3;
            this.name.Text = "My Program";
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // ver
            // 
            this.ver.AccessibleName = "input";
            this.ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver.Location = new System.Drawing.Point(105, 245);
            this.ver.Margin = new System.Windows.Forms.Padding(4);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(567, 26);
            this.ver.TabIndex = 11;
            this.ver.Text = "1.0";
            this.ver.Enter += new System.EventHandler(this.ver_Enter);
            this.ver.Leave += new System.EventHandler(this.ver_Leave);
            // 
            // information2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 592);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appvers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publ);
            this.Controls.Add(this.web);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Form2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "information2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "setup";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Form2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox publ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label appvers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox web;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox ver;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button back2;
        private System.Windows.Forms.Button next;
    }
}