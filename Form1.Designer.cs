namespace Web_Form_Project
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			button2 = new Button();
			txtUser = new TextBox();
			txtPass = new TextBox();
			label1 = new Label();
			label2 = new Label();
			checkBox1 = new CheckBox();
			linkLabel1 = new LinkLabel();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(244, 182);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(359, 182);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 1;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// txtUser
			// 
			txtUser.Location = new Point(359, 48);
			txtUser.Name = "txtUser";
			txtUser.Size = new Size(210, 23);
			txtUser.TabIndex = 2;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(359, 97);
			txtPass.Name = "txtPass";
			txtPass.PasswordChar = '*';
			txtPass.Size = new Size(210, 23);
			txtPass.TabIndex = 3;
			txtPass.TextChanged += textBox2_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(193, 48);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 4;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(196, 97);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 5;
			label2.Text = "Password";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			checkBox1.Location = new Point(389, 142);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(138, 25);
			checkBox1.TabIndex = 6;
			checkBox1.Text = "Show Password";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			linkLabel1.Location = new Point(402, 208);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(113, 17);
			linkLabel1.TabIndex = 7;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Forgot Password?";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonFace;
			ClientSize = new Size(800, 450);
			Controls.Add(linkLabel1);
			Controls.Add(checkBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtPass);
			Controls.Add(txtUser);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Login Form";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private TextBox txtUser;
		private TextBox txtPass;
		private Label label1;
		private Label label2;
		private CheckBox checkBox1;
		private LinkLabel linkLabel1;
	}
}
