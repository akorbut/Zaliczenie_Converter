namespace ExchangeLesson
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
            this.from = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StartAmount = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.ResultWallet = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.FormattingEnabled = true;
            this.from.Location = new System.Drawing.Point(7, 73);
            this.from.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(332, 21);
            this.from.TabIndex = 0;
            this.from.SelectionChangeCommitted += new System.EventHandler(this.FromComBox_SelectedValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsJSONToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveAsJson);
            // 
            // saveAsJSONToolStripMenuItem
            // 
            this.saveAsJSONToolStripMenuItem.Name = "saveAsJSONToolStripMenuItem";
            this.saveAsJSONToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveAsJSONToolStripMenuItem.Text = "Save as JSON";
            this.saveAsJSONToolStripMenuItem.Click += new System.EventHandler(this.SaveAsJson);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz walute bazową";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(341, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz walute docelową";
            // 
            // to
            // 
            this.to.FormattingEnabled = true;
            this.to.Location = new System.Drawing.Point(352, 73);
            this.to.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(332, 21);
            this.to.TabIndex = 3;
            this.to.SelectionChangeCommitted += new System.EventHandler(this.ToComBox_SelectedValueChanged);
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(6, 118);
            this.Start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(50, 25);
            this.Start.TabIndex = 5;
            this.Start.Text = "PLN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(140, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "do";
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.End.Location = new System.Drawing.Point(178, 118);
            this.End.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(50, 25);
            this.End.TabIndex = 7;
            this.End.Text = "PLN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(232, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "otrzymasz";
            // 
            // StartAmount
            // 
            this.StartAmount.Location = new System.Drawing.Point(60, 123);
            this.StartAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartAmount.Name = "StartAmount";
            this.StartAmount.Size = new System.Drawing.Size(76, 20);
            this.StartAmount.TabIndex = 9;
            this.StartAmount.Text = "0";
            this.StartAmount.WordWrap = false;
            this.StartAmount.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(341, 122);
            this.Result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(350, 20);
            this.Result.TabIndex = 11;
            // 
            // ResultWallet
            // 
            this.ResultWallet.AutoSize = true;
            this.ResultWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ResultWallet.Location = new System.Drawing.Point(695, 119);
            this.ResultWallet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultWallet.Name = "ResultWallet";
            this.ResultWallet.Size = new System.Drawing.Size(50, 25);
            this.ResultWallet.TabIndex = 12;
            this.ResultWallet.Text = "PLN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 162);
            this.Controls.Add(this.ResultWallet);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.StartAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.End);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Currency exchanger";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label End;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StartAmount;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label ResultWallet;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAsJSONToolStripMenuItem;
    }
}

