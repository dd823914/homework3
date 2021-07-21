
namespace WindowsFormsApp2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblYear = new System.Windows.Forms.RadioButton();
			this.lblMonth = new System.Windows.Forms.RadioButton();
			this.lblCar = new System.Windows.Forms.ComboBox();
			this.lblMotor = new System.Windows.Forms.ComboBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpChoose2 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpChoose = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.GroupBoxresult = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.GroupBoxresult.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Location = new System.Drawing.Point(18, 39);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(76, 19);
			this.lblYear.TabIndex = 1;
			this.lblYear.Text = "全年度";
			this.lblYear.UseVisualStyleBackColor = true;
			// 
			// lblMonth
			// 
			this.lblMonth.AutoSize = true;
			this.lblMonth.Location = new System.Drawing.Point(97, 39);
			this.lblMonth.Name = "lblMonth";
			this.lblMonth.Size = new System.Drawing.Size(76, 19);
			this.lblMonth.TabIndex = 1;
			this.lblMonth.Text = "依期間";
			this.lblMonth.UseVisualStyleBackColor = true;
			this.lblMonth.CheckedChanged += new System.EventHandler(this.lblMonth_CheckedChanged);
			// 
			// lblCar
			// 
			this.lblCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lblCar.FormattingEnabled = true;
			this.lblCar.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
			this.lblCar.Location = new System.Drawing.Point(49, 34);
			this.lblCar.Name = "lblCar";
			this.lblCar.Size = new System.Drawing.Size(121, 23);
			this.lblCar.TabIndex = 2;
			// 
			// lblMotor
			// 
			this.lblMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lblMotor.FormattingEnabled = true;
			this.lblMotor.Items.AddRange(new object[] {
            "0-150cc",
            "150cc~250cc",
            "251cc~500cc",
            "501cc~600cc",
            "601cc~1200cc",
            "1201cc~1800cc",
            "1801cc~2400cc",
            "2401cc~3000cc",
            "3001cc~3600cc",
            "3601cc~4200cc",
            "4201cc~4800cc",
            "4801cc~5400cc",
            "5401cc~6000cc",
            "6001cc~6600cc",
            "6601cc~7200cc",
            "7201cc~7800cc",
            "7801cc~8400cc",
            "8401cc~9000cc",
            "9001cc~9600cc",
            "9601cc~10200cc",
            "10201cc以上"});
			this.lblMotor.Location = new System.Drawing.Point(6, 34);
			this.lblMotor.Name = "lblMotor";
			this.lblMotor.Size = new System.Drawing.Size(252, 23);
			this.lblMotor.TabIndex = 2;
			this.lblMotor.SelectedIndexChanged += new System.EventHandler(this.lblMotor_SelectedIndexChanged);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(259, 39);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(15, 15);
			this.lblResult.TabIndex = 3;
			this.lblResult.Text = "-";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.groupBox1.Controls.Add(this.dtpChoose2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dtpChoose);
			this.groupBox1.Controls.Add(this.lblYear);
			this.groupBox1.Controls.Add(this.lblMonth);
			this.groupBox1.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox1.Location = new System.Drawing.Point(201, 138);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(557, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "使用期間";
			// 
			// dtpChoose2
			// 
			this.dtpChoose2.Location = new System.Drawing.Point(404, 34);
			this.dtpChoose2.Name = "dtpChoose2";
			this.dtpChoose2.Size = new System.Drawing.Size(147, 25);
			this.dtpChoose2.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(365, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "至";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(176, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 15);
			this.label6.TabIndex = 6;
			this.label6.Text = "從";
			// 
			// dtpChoose
			// 
			this.dtpChoose.Location = new System.Drawing.Point(204, 34);
			this.dtpChoose.Name = "dtpChoose";
			this.dtpChoose.Size = new System.Drawing.Size(146, 25);
			this.dtpChoose.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Azure;
			this.groupBox2.Controls.Add(this.lblCar);
			this.groupBox2.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox2.Location = new System.Drawing.Point(201, 244);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(276, 78);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "用途";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Azure;
			this.groupBox3.Controls.Add(this.lblMotor);
			this.groupBox3.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox3.Location = new System.Drawing.Point(483, 244);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(275, 78);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "汽缸CC數/馬達馬力";
			// 
			// GroupBoxresult
			// 
			this.GroupBoxresult.BackColor = System.Drawing.Color.White;
			this.GroupBoxresult.Controls.Add(this.lblResult);
			this.GroupBoxresult.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.GroupBoxresult.Location = new System.Drawing.Point(201, 328);
			this.GroupBoxresult.Name = "GroupBoxresult";
			this.GroupBoxresult.Size = new System.Drawing.Size(557, 120);
			this.GroupBoxresult.TabIndex = 7;
			this.GroupBoxresult.TabStop = false;
			this.GroupBoxresult.Text = "試算結果";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(292, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(320, 28);
			this.label2.TabIndex = 8;
			this.label2.Text = "使用牌照稅應納稅額試算";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(155, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(647, 45);
			this.label3.TabIndex = 9;
			this.label3.Text = "\r\n1.本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。\r\n2.使用牌照稅稅額對照表及電動車應納稅額表。\r\n";
			// 
			// btnSubmit
			// 
			this.btnSubmit.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnSubmit.Location = new System.Drawing.Point(340, 454);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(83, 30);
			this.btnSubmit.TabIndex = 10;
			this.btnSubmit.Text = "確定送出";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnCancle.Location = new System.Drawing.Point(483, 454);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(86, 30);
			this.btnCancle.TabIndex = 10;
			this.btnCancle.Text = "取消重填";
			this.btnCancle.UseVisualStyleBackColor = true;
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(157, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "貼心小叮嚀:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(920, 516);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.GroupBoxresult);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.GroupBoxresult.ResumeLayout(false);
			this.GroupBoxresult.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RadioButton lblYear;
		private System.Windows.Forms.RadioButton lblMonth;
		private System.Windows.Forms.ComboBox lblCar;
		private System.Windows.Forms.ComboBox lblMotor;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpChoose2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpChoose;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox GroupBoxresult;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Label label4;
	}
}

