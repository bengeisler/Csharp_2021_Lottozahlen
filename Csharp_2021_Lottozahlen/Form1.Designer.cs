
namespace Csharp_2021_Lottozahlen
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnZiehung = new System.Windows.Forms.Button();
			this.lstLottozahlen = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtZusatzzahl = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnZiehung
			// 
			this.btnZiehung.Location = new System.Drawing.Point(54, 21);
			this.btnZiehung.Name = "btnZiehung";
			this.btnZiehung.Size = new System.Drawing.Size(75, 23);
			this.btnZiehung.TabIndex = 0;
			this.btnZiehung.Text = "Ziehung";
			this.btnZiehung.UseVisualStyleBackColor = true;
			this.btnZiehung.Click += new System.EventHandler(this.btnZiehung_Click);
			// 
			// lstLottozahlen
			// 
			this.lstLottozahlen.FormattingEnabled = true;
			this.lstLottozahlen.Location = new System.Drawing.Point(44, 50);
			this.lstLottozahlen.Name = "lstLottozahlen";
			this.lstLottozahlen.Size = new System.Drawing.Size(97, 173);
			this.lstLottozahlen.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(47, 235);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Zusatzzahl:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtZusatzzahl
			// 
			this.txtZusatzzahl.Location = new System.Drawing.Point(47, 261);
			this.txtZusatzzahl.Name = "txtZusatzzahl";
			this.txtZusatzzahl.Size = new System.Drawing.Size(94, 20);
			this.txtZusatzzahl.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(188, 310);
			this.Controls.Add(this.txtZusatzzahl);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstLottozahlen);
			this.Controls.Add(this.btnZiehung);
			this.Name = "Form1";
			this.Text = "Lottozahlen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnZiehung;
		private System.Windows.Forms.ListBox lstLottozahlen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtZusatzzahl;
	}
}

