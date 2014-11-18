namespace Signal_Block_Design_Tool.Forms
{
     partial class ProgressBoxForm
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
               this.progressBar1 = new System.Windows.Forms.ProgressBar();
               this.CurCircuit = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // progressBar1
               // 
               this.progressBar1.Location = new System.Drawing.Point(12, 76);
               this.progressBar1.Name = "progressBar1";
               this.progressBar1.Size = new System.Drawing.Size(362, 23);
               this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
               this.progressBar1.TabIndex = 0;
               // 
               // CurCircuit
               // 
               this.CurCircuit.AutoSize = true;
               this.CurCircuit.Location = new System.Drawing.Point(49, 29);
               this.CurCircuit.Name = "CurCircuit";
               this.CurCircuit.Size = new System.Drawing.Size(35, 13);
               this.CurCircuit.TabIndex = 1;
               this.CurCircuit.Text = "label1";
               // 
               // ProgressBoxForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(386, 113);
               this.Controls.Add(this.CurCircuit);
               this.Controls.Add(this.progressBar1);
               this.Name = "ProgressBoxForm";
               this.Text = "Importing...";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          public System.Windows.Forms.ProgressBar progressBar1;
          public System.Windows.Forms.Label CurCircuit;
     }
}