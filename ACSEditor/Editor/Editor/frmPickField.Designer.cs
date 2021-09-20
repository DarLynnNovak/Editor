
using Aptify.Framework.Application;
using Aptify.Framework.DataServices;
using System.Windows.Forms;

namespace ACSEditor
{
    partial class frmPickField
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
            this._tvwMain = new System.Windows.Forms.TreeView();
            this._cmdSelectField = new System.Windows.Forms.Button();
            this._cmdHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _tvwMain
            // 
            this._tvwMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tvwMain.Location = new System.Drawing.Point(0, 0);
            this._tvwMain.Name = "_tvwMain";
            this._tvwMain.Size = new System.Drawing.Size(231, 200);
            this._tvwMain.TabIndex = 0;
            this._tvwMain.DoubleClick += new System.EventHandler(this.tvwMain_DblClick);
            // 
            // _cmdSelectField
            // 
            this._cmdSelectField.Location = new System.Drawing.Point(37, 177);
            this._cmdSelectField.Name = "_cmdSelectField";
            this._cmdSelectField.Size = new System.Drawing.Size(75, 23);
            this._cmdSelectField.TabIndex = 1;
            this._cmdSelectField.Text = "Select Field";
            this._cmdSelectField.UseVisualStyleBackColor = true;
            this._cmdSelectField.Click += new System.EventHandler(this._cmdSelectField_Click);
            // 
            // _cmdHide
            // 
            this._cmdHide.Location = new System.Drawing.Point(118, 177);
            this._cmdHide.Name = "_cmdHide";
            this._cmdHide.Size = new System.Drawing.Size(75, 23);
            this._cmdHide.TabIndex = 2;
            this._cmdHide.Text = "Hide";
            this._cmdHide.UseVisualStyleBackColor = true;
            this._cmdHide.Click += new System.EventHandler(this._cmdHide_Click);
            // 
            // frmPickField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 200);
            this.Controls.Add(this._cmdHide);
            this.Controls.Add(this._cmdSelectField);
            this.Controls.Add(this._tvwMain);
            this.Name = "frmPickField";
            this.Text = "frmPickField";
            this.Load += new System.EventHandler(this.frmPickField_Load);
            this.ResumeLayout(false);

        }
       
        #endregion
       

        private System.Windows.Forms.TreeView _tvwMain;
        private Button _cmdSelectField;
        private Button _cmdHide;
    }
}