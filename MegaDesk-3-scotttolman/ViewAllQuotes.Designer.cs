﻿namespace MegaDesk_3_scotttolman
{
    partial class ViewAllQuotes
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
            this.viewCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewCancel
            // 
            this.viewCancel.Location = new System.Drawing.Point(505, 298);
            this.viewCancel.Name = "viewCancel";
            this.viewCancel.Size = new System.Drawing.Size(75, 23);
            this.viewCancel.TabIndex = 0;
            this.viewCancel.Text = "Cancel";
            this.viewCancel.UseVisualStyleBackColor = true;
            this.viewCancel.Click += new System.EventHandler(this.viewCancel_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.viewCancel);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewCancel;
    }
}