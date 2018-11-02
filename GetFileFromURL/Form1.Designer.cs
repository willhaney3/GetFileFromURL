namespace GetFileFromURL
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtURL = new System.Windows.Forms.TextBox();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnFolder = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "URL:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Path:";
      // 
      // txtURL
      // 
      this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtURL.Location = new System.Drawing.Point(41, 12);
      this.txtURL.Name = "txtURL";
      this.txtURL.Size = new System.Drawing.Size(561, 20);
      this.txtURL.TabIndex = 2;
      // 
      // txtPath
      // 
      this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPath.Location = new System.Drawing.Point(41, 38);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(531, 20);
      this.txtPath.TabIndex = 3;
      // 
      // btnExecute
      // 
      this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExecute.Location = new System.Drawing.Point(530, 70);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(75, 23);
      this.btnExecute.TabIndex = 4;
      this.btnExecute.Text = "E&xecute";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // btnFolder
      // 
      this.btnFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFolder.Location = new System.Drawing.Point(577, 35);
      this.btnFolder.Name = "btnFolder";
      this.btnFolder.Size = new System.Drawing.Size(25, 23);
      this.btnFolder.TabIndex = 5;
      this.btnFolder.Text = "...";
      this.btnFolder.UseVisualStyleBackColor = true;
      this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(449, 70);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.btnExecute;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(617, 105);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnFolder);
      this.Controls.Add(this.btnExecute);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.txtURL);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Copy file from URL";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtURL;
    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnFolder;
    private System.Windows.Forms.Button btnCancel;
  }
}

