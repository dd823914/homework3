using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Init();
		}

		private void Init()
		{
			this.lblYear.Checked = true;
			this.lblCar.SelectedIndex = 0;
			this.lblMotor.SelectedIndex = 0;
			//清除groupboxresult.text的內容，回到原本的試算結果
			this.GroupBoxresult.Text = "試算結果";		
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			//執行void int的內容
			this.Init();
		}
		
		private void lblMotor_SelectedIndexChanged(object sender, EventArgs e)
		{
			//沒用不小心點到的
		}

		//==============================================================================
		private int GetTaxPercentage()
		{
			//取得排氣量選單對應的價格
			string taxType1 = this.lblMotor.Text;
			switch (taxType1)
			{
				case "150cc以下":					
					return 100;
				case "151cc~250cc":					
					return 800;
				case "251cc~500cc":			
					return 1620;
				case "501cc~600cc":
					return 2160;
				case "601cc~1200cc":
					return 4320;
				case "1201cc~1800cc":
					return 7120;
				case "1801cc或以上":
					return 11230;
				default:
					return 0;
			}
			

		}
		private int GetTaxPercentage2()
		{
			//取得排氣量選單對應的價格
			string taxType1 = this.lblMotor.Text;
			switch (taxType1)
			{
				case "500cc以下":
					return 1620;
				case "501cc~600cc":
					return 2160;
				case "601cc~1200cc":
					return 4320;
				case "1201cc - 1800cc":
					return 7120;
				case "1801cc - 2400cc":
					return 11230;
				case "2401cc - 3000cc":
					return 15210;
				case "3001cc - 4200cc":
					return 28220;
				case "4201cc - 5400cc":
					return 46170;
				case "5401cc - 6600cc":
					return 69690;
				case "6601cc - 7800cc":
					return 117000;
				case "7801cc 以上":
					return 151200;
				default:
					return 0;
			}


		}
		private int GetTaxPercentage3()
		{
			//取得排氣量選單對應的價格
			string taxType1 = this.lblMotor.Text;
			switch (taxType1)
			{
				case "500cc以下":
					return 900;
				case "501cc~600cc":
					return 1260;
				case "601cc~1200cc":
					return 2160;
				case "1201cc - 1800cc":
					return 3060;
				case "1801cc - 2400cc":
					return 6480;
				case "2401cc - 3000cc":
					return 9900;
				case "3001cc - 4200cc":
					return 16380;
				case "4201cc - 5400cc":
					return 24300;
				case "5401cc - 6600cc":
					return 33660;
				case "6601cc - 7800cc":
					return 44460;
				case "7801cc 以上":
					return 56700;
				default:
					return 0;
			}
		}
		private int GetTaxPercentage4()
		{
			//取得排氣量選單對應的價格
			string taxType1 = this.lblMotor.Text;
			switch (taxType1)
			{
				case "500cc以下":
					return 0;
				case "501cc~600cc":
					return 1080;
				case "601cc~1200cc":
					return 1800;
				case "1201cc - 1800cc":
					return 2700;
				case "1801cc - 2400cc":
					return 3600;
				case "2401cc - 3000cc":
					return 4500;
				case "3001cc - 3600cc":
					return 5400;
				case "3601cc - 4200cc":
					return 6300;
				case "4201cc - 4800cc":
					return 7200;
				case "4801cc - 5400cc":
					return 8100;
				case "5401cc - 6000cc":
					return 9000;
				case "6001cc - 6600cc":
					return 9900;
				case "6601cc~7200cc":
					return 10800;
				case "7201cc~7800cc":
					return 11700;
				case "7801cc~8400cc":
					return 12600;
				case "8401cc~9000cc":
					return 13500;
				case "9001cc~9600cc":
					return 14400;
				case "9601cc~10200cc":
					return 15300;
				case "10201cc以上":
					return 16200;
				default:
					return 0;
			}
		}

		private string GetTaxPercentageCAR()
		{

			//取得車種
			string taxType2 = this.lblCar.Text;
			switch (taxType2)
			{
				case "機車":
					return "機車";
				case "貨車":
					return "貨車";
				case "大客車":
					return "大客車";
				case "自用小客車":
					return "自用小客車";
				case "營業用小客車":
					return "營業用小客車";
				default:
					return "CAR?";
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			GroupBoxresult.Text += Environment.NewLine;
			//取得日期天數，把日期選單選好的日期丟到date1 /date2存起來，用nian儲存兩個日期之間的差距天數，把資訊透過textbox show出來
			int nian ,result;
			DateTime date2 = dtpChoose2.Value;
			DateTime date1 = dtpChoose.Value;
			nian = (date2 - date1).Days + 1;
			GroupBoxresult.Text += "使用期間:" + dtpChoose.Value + "到" + dtpChoose2.Value  + Environment.NewLine;
			GroupBoxresult.Text += "計算天數:" + nian + Environment.NewLine;
			//取得排氣量對應的價格
			string carnumber = (string)this.GetTaxPercentageCAR();
			GroupBoxresult.Text += "用途:" + carnumber + Environment.NewLine;

			//取得車種，(可優化的方案:選擇車種跳出對應的排氣量選單)
			int ccnumber = (int)this.GetTaxPercentage();
			GroupBoxresult.Text += "汽缸CC數:" + ccnumber + Environment.NewLine;

			//result儲存需繳納金額
			result = ccnumber * nian / 365;
			//下面show出公式
			GroupBoxresult.Text += "計算公式:" + ccnumber + "*" + nian + "/365="+ result + Environment.NewLine;
			GroupBoxresult.Text += "應納稅額: 共" + result +"元" + Environment.NewLine;			
		}

		private void lblMonth_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}














