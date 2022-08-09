/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/15/2021
 * Time: 5:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Machine_Problem_Radiobutton
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radFirstYear;
		private System.Windows.Forms.RadioButton radSecondYear;
		private System.Windows.Forms.RadioButton radThirdYear;
		private System.Windows.Forms.RadioButton radFourthYear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Clearbutton;
		private System.Windows.Forms.Button Exit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.radFirstYear = new System.Windows.Forms.RadioButton();
			this.radSecondYear = new System.Windows.Forms.RadioButton();
			this.radThirdYear = new System.Windows.Forms.RadioButton();
			this.radFourthYear = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Clearbutton = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "High School Level:";
			// 
			// radFirstYear
			// 
			this.radFirstYear.Location = new System.Drawing.Point(28, 71);
			this.radFirstYear.Name = "radFirstYear";
			this.radFirstYear.Size = new System.Drawing.Size(104, 26);
			this.radFirstYear.TabIndex = 1;
			this.radFirstYear.TabStop = true;
			this.radFirstYear.Text = "First Year";
			this.radFirstYear.UseVisualStyleBackColor = true;
			this.radFirstYear.CheckedChanged += new System.EventHandler(this.RadFirstYearCheckedChanged);
			// 
			// radSecondYear
			// 
			this.radSecondYear.Location = new System.Drawing.Point(28, 117);
			this.radSecondYear.Name = "radSecondYear";
			this.radSecondYear.Size = new System.Drawing.Size(166, 26);
			this.radSecondYear.TabIndex = 2;
			this.radSecondYear.TabStop = true;
			this.radSecondYear.Text = "Second Year";
			this.radSecondYear.UseVisualStyleBackColor = true;
			this.radSecondYear.CheckedChanged += new System.EventHandler(this.RadSecondYearCheckedChanged);
			// 
			// radThirdYear
			// 
			this.radThirdYear.Location = new System.Drawing.Point(28, 163);
			this.radThirdYear.Name = "radThirdYear";
			this.radThirdYear.Size = new System.Drawing.Size(104, 26);
			this.radThirdYear.TabIndex = 3;
			this.radThirdYear.TabStop = true;
			this.radThirdYear.Text = "Third Year";
			this.radThirdYear.UseVisualStyleBackColor = true;
			this.radThirdYear.CheckedChanged += new System.EventHandler(this.RadThirdYearCheckedChanged);
			// 
			// radFourthYear
			// 
			this.radFourthYear.Location = new System.Drawing.Point(28, 209);
			this.radFourthYear.Name = "radFourthYear";
			this.radFourthYear.Size = new System.Drawing.Size(148, 26);
			this.radFourthYear.TabIndex = 4;
			this.radFourthYear.TabStop = true;
			this.radFourthYear.Text = "Fourth Year";
			this.radFourthYear.UseVisualStyleBackColor = true;
			this.radFourthYear.CheckedChanged += new System.EventHandler(this.RadFourthYearCheckedChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(28, 259);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "is also called:";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(143, 256);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(137, 23);
			this.textBox1.TabIndex = 6;
			// 
			// Clearbutton
			// 
			this.Clearbutton.Location = new System.Drawing.Point(76, 316);
			this.Clearbutton.Name = "Clearbutton";
			this.Clearbutton.Size = new System.Drawing.Size(75, 33);
			this.Clearbutton.TabIndex = 7;
			this.Clearbutton.Text = "Clear";
			this.Clearbutton.UseVisualStyleBackColor = true;
			this.Clearbutton.Click += new System.EventHandler(this.ClearbuttonClick);
			// 
			// Exit
			// 
			this.Exit.Location = new System.Drawing.Point(228, 316);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 33);
			this.Exit.TabIndex = 8;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(377, 391);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.Clearbutton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.radFourthYear);
			this.Controls.Add(this.radThirdYear);
			this.Controls.Add(this.radSecondYear);
			this.Controls.Add(this.radFirstYear);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Text = "Machine Problem Radiobutton";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
