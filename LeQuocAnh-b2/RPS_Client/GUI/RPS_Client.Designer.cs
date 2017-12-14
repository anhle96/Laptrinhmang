namespace RPS_Client.GUI
{
	partial class RPS_ClientForm
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
			this.btnRock = new System.Windows.Forms.Button();
			this.btnPaper = new System.Windows.Forms.Button();
			this.txtOpponent = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnScissor = new System.Windows.Forms.Button();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.txtSelection = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRock
			// 
			this.btnRock.Location = new System.Drawing.Point(173, 90);
			this.btnRock.Name = "btnRock";
			this.btnRock.Size = new System.Drawing.Size(75, 23);
			this.btnRock.TabIndex = 17;
			this.btnRock.Text = "Rock";
			this.btnRock.UseVisualStyleBackColor = true;
			this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
			// 
			// btnPaper
			// 
			this.btnPaper.Location = new System.Drawing.Point(92, 90);
			this.btnPaper.Name = "btnPaper";
			this.btnPaper.Size = new System.Drawing.Size(75, 23);
			this.btnPaper.TabIndex = 16;
			this.btnPaper.Text = "Paper";
			this.btnPaper.UseVisualStyleBackColor = true;
			this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
			// 
			// txtOpponent
			// 
			this.txtOpponent.Location = new System.Drawing.Point(65, 38);
			this.txtOpponent.Name = "txtOpponent";
			this.txtOpponent.ReadOnly = true;
			this.txtOpponent.Size = new System.Drawing.Size(154, 20);
			this.txtOpponent.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Opponent";
			// 
			// btnScissor
			// 
			this.btnScissor.Location = new System.Drawing.Point(11, 90);
			this.btnScissor.Name = "btnScissor";
			this.btnScissor.Size = new System.Drawing.Size(75, 23);
			this.btnScissor.TabIndex = 13;
			this.btnScissor.Text = "Scissor";
			this.btnScissor.UseVisualStyleBackColor = true;
			this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(65, 64);
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(154, 20);
			this.txtResult.TabIndex = 12;
			// 
			// txtSelection
			// 
			this.txtSelection.Location = new System.Drawing.Point(65, 12);
			this.txtSelection.Name = "txtSelection";
			this.txtSelection.ReadOnly = true;
			this.txtSelection.Size = new System.Drawing.Size(154, 20);
			this.txtSelection.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Result";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Selection";
			// 
			// RPS_ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 133);
			this.Controls.Add(this.btnRock);
			this.Controls.Add(this.btnPaper);
			this.Controls.Add(this.txtOpponent);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnScissor);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtSelection);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "RPS_ClientForm";
			this.Text = "RPS_Client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRock;
		private System.Windows.Forms.Button btnPaper;
		private System.Windows.Forms.TextBox txtOpponent;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnScissor;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.TextBox txtSelection;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}