namespace WinFrmFile1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExist = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnAppendAllText = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnReadAndWrite = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCreatText = new System.Windows.Forms.Button();
            this.btnOpenWrite = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExist);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(3, 14);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(98, 23);
            this.btnExist.TabIndex = 1;
            this.btnExist.Text = "Is Exist a File?";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(127, 16);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(373, 20);
            this.txtPath.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtDelete);
            this.panel2.Location = new System.Drawing.Point(12, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 46);
            this.panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(127, 16);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(373, 20);
            this.txtDelete.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtDest);
            this.panel3.Controls.Add(this.btnMove);
            this.panel3.Controls.Add(this.btnCopy);
            this.panel3.Controls.Add(this.txtSource);
            this.panel3.Location = new System.Drawing.Point(12, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 105);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source File";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(100, 47);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(400, 20);
            this.txtDest.TabIndex = 2;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(115, 73);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(98, 23);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(11, 73);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(98, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(100, 21);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(400, 20);
            this.txtSource.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtDisplay);
            this.panel4.Controls.Add(this.btnAppendAllText);
            this.panel4.Controls.Add(this.btnAppend);
            this.panel4.Controls.Add(this.btnReadAndWrite);
            this.panel4.Controls.Add(this.btnOpen);
            this.panel4.Controls.Add(this.btnCreatText);
            this.panel4.Controls.Add(this.btnOpenWrite);
            this.panel4.Controls.Add(this.btnCreate);
            this.panel4.Location = new System.Drawing.Point(12, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(509, 238);
            this.panel4.TabIndex = 3;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(32, 17);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(443, 110);
            this.txtDisplay.TabIndex = 2;
            // 
            // btnAppendAllText
            // 
            this.btnAppendAllText.Location = new System.Drawing.Point(344, 138);
            this.btnAppendAllText.Name = "btnAppendAllText";
            this.btnAppendAllText.Size = new System.Drawing.Size(98, 23);
            this.btnAppendAllText.TabIndex = 1;
            this.btnAppendAllText.Text = "Append All Text";
            this.btnAppendAllText.UseVisualStyleBackColor = true;
            this.btnAppendAllText.Click += new System.EventHandler(this.btnAppendAllText_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(240, 138);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(98, 23);
            this.btnAppend.TabIndex = 1;
            this.btnAppend.Text = "Append Text";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnReadAndWrite
            // 
            this.btnReadAndWrite.Location = new System.Drawing.Point(240, 183);
            this.btnReadAndWrite.Name = "btnReadAndWrite";
            this.btnReadAndWrite.Size = new System.Drawing.Size(98, 23);
            this.btnReadAndWrite.TabIndex = 1;
            this.btnReadAndWrite.Text = "Read && write";
            this.btnReadAndWrite.UseVisualStyleBackColor = true;
            this.btnReadAndWrite.Click += new System.EventHandler(this.btnReadAndWrite_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(136, 183);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(98, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCreatText
            // 
            this.btnCreatText.Location = new System.Drawing.Point(136, 138);
            this.btnCreatText.Name = "btnCreatText";
            this.btnCreatText.Size = new System.Drawing.Size(98, 23);
            this.btnCreatText.TabIndex = 1;
            this.btnCreatText.Text = "Create Text";
            this.btnCreatText.UseVisualStyleBackColor = true;
            this.btnCreatText.Click += new System.EventHandler(this.btnCreatText_Click);
            // 
            // btnOpenWrite
            // 
            this.btnOpenWrite.Location = new System.Drawing.Point(32, 183);
            this.btnOpenWrite.Name = "btnOpenWrite";
            this.btnOpenWrite.Size = new System.Drawing.Size(98, 23);
            this.btnOpenWrite.TabIndex = 1;
            this.btnOpenWrite.Text = "Open Write";
            this.btnOpenWrite.UseVisualStyleBackColor = true;
            this.btnOpenWrite.Click += new System.EventHandler(this.btnOpenWrite_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(32, 138);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 479);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCreatText;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnAppendAllText;
        private System.Windows.Forms.Button btnOpenWrite;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnReadAndWrite;
    }
}

