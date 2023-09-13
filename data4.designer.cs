
namespace InstallerApp
{
    partial class data4
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
            this.label1 = new System.Windows.Forms.Label();
            this.datta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.back2 = new System.Windows.Forms.Button();
            this.next2 = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.have = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.files = new System.Windows.Forms.ListView();
            this.addfiile = new System.Windows.Forms.Button();
            this.addfolder = new System.Windows.Forms.Button();
            this.edite = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.label1.Size = new System.Drawing.Size(431, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "pleas specify files that are part of your application";
            // 
            // datta
            // 
            this.datta.AutoSize = true;
            this.datta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datta.Location = new System.Drawing.Point(37, 26);
            this.datta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.datta.Name = "datta";
            this.datta.Size = new System.Drawing.Size(268, 37);
            this.datta.TabIndex = 2;
            this.datta.Text = "Application Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Application main executable file:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(135, 208);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(397, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Allow users start application after Setup has finished";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.back2);
            this.panel2.Controls.Add(this.next2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 70);
            this.panel2.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(935, 12);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 43);
            this.button6.TabIndex = 20;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.cancel_Click);
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
            // browse
            // 
            this.browse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(744, 175);
            this.browse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(122, 25);
            this.browse.TabIndex = 12;
            this.browse.Text = "Browse..";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.selectmainfile_Click);
            // 
            // path
            // 
            this.path.Enabled = false;
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.Location = new System.Drawing.Point(100, 175);
            this.path.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(636, 25);
            this.path.TabIndex = 13;
            this.path.Text = "D:/YourPath/Exemple/YourProgram.exe";
            // 
            // have
            // 
            this.have.AutoSize = true;
            this.have.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.have.Location = new System.Drawing.Point(135, 240);
            this.have.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.have.Name = "have";
            this.have.Size = new System.Drawing.Size(372, 24);
            this.have.TabIndex = 15;
            this.have.Text = "The application dosen\'t have main executable file";
            this.have.UseVisualStyleBackColor = true;
            this.have.CheckedChanged += new System.EventHandler(this.have_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Other application files:";
            // 
            // files
            // 
            this.files.Enabled = false;
            this.files.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.files.HideSelection = false;
            this.files.Location = new System.Drawing.Point(100, 290);
            this.files.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(655, 192);
            this.files.TabIndex = 14;
            this.files.UseCompatibleStateImageBehavior = false;
            // 
            // addfiile
            // 
            this.addfiile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addfiile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfiile.Location = new System.Drawing.Point(852, 290);
            this.addfiile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addfiile.Name = "addfiile";
            this.addfiile.Size = new System.Drawing.Size(30, 30);
            this.addfiile.TabIndex = 17;
            this.addfiile.UseVisualStyleBackColor = false;
            this.addfiile.Click += new System.EventHandler(this.selectfile_Click);
            // 
            // addfolder
            // 
            this.addfolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfolder.Location = new System.Drawing.Point(824, 290);
            this.addfolder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addfolder.Name = "addfolder";
            this.addfolder.Size = new System.Drawing.Size(30, 30);
            this.addfolder.TabIndex = 18;
            this.addfolder.UseVisualStyleBackColor = false;
            this.addfolder.Click += new System.EventHandler(this.selectfolder_Click);
            // 
            // edite
            // 
            this.edite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.edite.Enabled = false;
            this.edite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edite.Location = new System.Drawing.Point(759, 417);
            this.edite.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edite.Name = "edite";
            this.edite.Size = new System.Drawing.Size(149, 28);
            this.edite.TabIndex = 19;
            this.edite.Text = "Edit";
            this.edite.UseVisualStyleBackColor = false;
            this.edite.Click += new System.EventHandler(this.edite_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.delete.Enabled = false;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(759, 453);
            this.delete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(149, 28);
            this.delete.TabIndex = 20;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // data4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 592);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edite);
            this.Controls.Add(this.addfolder);
            this.Controls.Add(this.addfiile);
            this.Controls.Add(this.files);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.have);
            this.Controls.Add(this.path);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "data4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.CheckBox have;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView files;
        private System.Windows.Forms.Button addfiile;
        private System.Windows.Forms.Button addfolder;
        private System.Windows.Forms.Button edite;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button back2;
        private System.Windows.Forms.Button next2;
        private System.Windows.Forms.ImageList imageList1;
    }
}