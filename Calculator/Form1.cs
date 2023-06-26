using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Calculator
{
    public partial class frmcalculator : Form
    {
        public frmcalculator()
        {
            InitializeComponent();
        }
        double num1, num2, result;  /**///*دو متغیر برای ورودی های کاربر تعریف شد و یک ریزالت برای نشان دادن نتیجه */*/
        string op;            //متغیری از نوع رشته برای 4 عمل اصلی
        bool flag_op=false;       //وضعیت عملگر    

        private void Get_result()
        {
            num2 = Convert.ToDouble(txtdisplay1.Text); //تبدیل استیرینگ به دابل
            switch (op)       // تشخیص می دهد کدام یک از عملگرها فشرده شده
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "×":
                    result = num1 * num2;
                    break;
                case "÷":
                    result = num1 / num2;
                    break;
            }
            op = null; //وقتی تشخیص داد کدام یک از عملیات فشرده شده ، محاسبه را انجام میدهد و متغییر مخصوص 4 عمل اصلی را خالی میکند 
        }

        private void frmcalculator_KeyPress(object sender, KeyPressEventArgs e)  //هنگامی که کاربر یک کلید را  در کیبورد فشار می دهد این تابع فراخوانده می شود
        {
            //برای هر دکمه در دکمه های داخل پنل اگر متن یا تکست دکمه با کاراکتر فشرده شده برابر باشد دکمه مورد نشر فعال می شود 
            //سپس برای کاراکتر فشرده شده تابع مربوطه را فراخوانی می کند

            foreach (Button b in pnlbuttons.Controls)
                if (b.Text == e.KeyChar.ToString())
                    b.Focus();
            Button btn = new Button();
            if (e.KeyChar == '*')
            {
                btnmultiply.Focus();
                btn.Text = "×";
            }
            else if (e.KeyChar == '/')
            {
                btndivision.Focus();
                btn.Text = "÷";
            }
            else if (e.KeyChar == '\b')   //بک اسلش بی کد مربوط به بک اسپیس روی کیبورده
                btnbackspace.Focus();
            else
                btn.Text = e.KeyChar.ToString();

            if (e.KeyChar >= '0' && e.KeyChar <= '9')   //مربوط به اعدادو بعدش مربوطه به اعمال روی اعداد توضیحش همون بالا هست
                Numbers_MouseClick(btn, null);
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                Operators_MouseClick(btn, null);
            else if (e.KeyChar == '=')
                btnequal_MouseClick(null, null);
            else if (e.KeyChar == '.')
                btndot_MouseClick(null, null);
            else if (e.KeyChar == '\b')
                btnbackspace_MouseClick(null, null);
            else if (e.KeyChar == '%')
                btnpercentage_MouseClick(null, null);
        }

        private void frmcalculator_KeyUp(object sender, KeyEventArgs e) //در اینجا باعث میشود که کاربر با فشردن کلید و رها کردنش  جواب نمایش داده شود
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnequal.Focus();
                btnequal_MouseClick(null,null);
            }
        }

        private void Operators_MouseClick(object sender, MouseEventArgs e) 
        {
            //مربوط به عملگرها می باشد که وقتی کاربر عملگری را می فشارد ان عملگر فعال شده و ذخیره می شود تا در محاسبه بعدی استفاده شود

            if (op != null && flag_op == false)
            {
                //اگر عملگر از قبل فشرده شده باشد نتیجه عملیات  قبلی را در تکست 1 نمایش می دهد
                Get_result();
                txtdisplay1.Text = result.ToString();
            }
          //مقدار را که حساب کرد  اپراتور را خالی میکند
          //عدد فعلی را که در تکسباکس 1 بوده را در عدد اول ذخیره می کند
            num1 = Convert.ToDouble(txtdisplay1.Text);
            op = ((Button)sender).Text;//عملگر جدید را از دکمه ای که کلیل شده است بدست می اورد
            txtdisplay2.Text = txtdisplay1.Text + " " + op; //عدد فعلی را به همراه عملگر جدید ویک فاصله به تکست باکس2 میدهد برای هیستوری
            flag_op = true; //  برای اینکه بداند عملگری فشرده شده و با کلیک ب روی یک عملگر نتیجه قبلی را محاسبه کند نمیدونم متوجه شدی یا ن توضیح این سخته  
        }

        private void btnequal_MouseClick(object sender, MouseEventArgs e)
        {
            //بر اساس عملگر ذخیره شده، عملیات ریاضی مربوطه بر روی دو عدد ورودی انجام می‌شود
            Get_result();
            txtdisplay2.Text += " " + txtdisplay1.Text + " =";
            txtdisplay1.Text = result.ToString();
        }

        private void btnonoff_MouseClick(object sender, MouseEventArgs e)
        {
            //کنترل روشن و خاموش ماشین حساب 
            pnlbuttons.Enabled = !pnlbuttons.Enabled; //وضعیت پنل دکمه ها را عوض می کند
            btnclear_MouseClick(null, null); //محتوای صفحه نمایش ماشین حساب را پاک می کند
            if (btnonoff.Text == "ON") //اگر متن دکمه آن باشد آف می کند و بلعکس
            {
                btnonoff.Text = "OFF";
                this.KeyPreview = true; //کلیدها رو فعال می کند
            }
            else
            {
                btnonoff.Text = "ON";
                this.KeyPreview = false;
            }
        }

        private void btnpercentage_MouseClick(object sender, MouseEventArgs e)
        {
            //محاسبه درصد 
            if (op == null) //اگر هیچ عملگری فشرده نشده باشد از تابع خارج می شود
            {
                txtdisplay1.Text = "0";
                txtdisplay2.Text = "0";
                return;
            }

            num2 = Convert.ToDouble(txtdisplay1.Text);
            switch (op) //بسته به عملگر انتخاب شده، محاسبه‌ی درصد را انجام می‌دهد
            {
                case "+":
                case "-":
                    num2 = (num1 * num2) / 100;
                    break;
                case "×":
                case "÷":
                    num2 /= 100;
                    break;
            }
            txtdisplay1.Text = num2.ToString();
        }

        private void btnbackspace_MouseClick(object sender, MouseEventArgs e) //مربوط به کد بک اسپیسه
        {
            //این تابع وقتی کلیک موس روی دکمه‌ی بک اسپیس فشرده می شود فراخوانی می‌شود. این تابع چک می‌کند که علامت منفی در عدد موجود است یا نه. اگر علامت منفی در عدد موجود باشد و طول عدد برابر 2 باشد، عدد به 0 تغییر می‌کند. در غیر این صورت، آخرین رقم عدد حذف می‌شود. اگر علامت منفی موجود نباشد و طول عدد برابر 1 باشد، عدد به 0 تغییر می‌کند. در غیر این صورت، آخرین رقم عدد حذف می‌شود.
            if (flag_op == true)
                return;
            int l = txtdisplay1.Text.Length;
            if (txtdisplay1.Text.Contains("-"))
                if (l == 2)
                    txtdisplay1.Text = "0";
                else
                    txtdisplay1.Text = txtdisplay1.Text.Remove(l - 1);
            else  if (l == 1)
                txtdisplay1.Text = "0";
            else
                txtdisplay1.Text = txtdisplay1.Text.Remove(l - 1);
        }

        private void btnclear_MouseClick(object sender, MouseEventArgs e) // این دیگه بدیهیه
        {
            txtdisplay1.Text = "0";
            txtdisplay2.Text = "";
            flag_op = false;
            op = null;
        }

        private void btnsign_MouseClick(object sender, MouseEventArgs e)
        {
            //این تابع وقتی کلیک موس روی دکمه‌ی علامت مثبت و منفی فشرده می شود  فراخوانی می‌شود. این تابع چک می‌کند که علامت منفی در عدد موجود است یا نه. اگر علامت منفی موجود باشد، آن را حذف می‌کند. در غیر این صورت، اگر عدد برابر 0 نباشد، علامت منفی اضافه می‌کند
            if (txtdisplay1.Text.Contains("-"))
                txtdisplay1.Text = txtdisplay1.Text.Remove(0, 1);
            else if (txtdisplay1.Text != "0")
                txtdisplay1.Text = txtdisplay1.Text.Insert(0, "-");
        }


        private void btndot_MouseClick(object sender, MouseEventArgs e)
        {
            //این تابع وقتی کلیک موس روی دکمه‌ی دات فشرده می شود  فراخوانی می‌شود. این تابع چک می‌کند که نقطه‌ای در عدد نمایش داده شده موجود است یا نه. اگر نقطه‌ای موجود نباشد، یک نقطه به انتهای عدد اضافه می‌کند
            if (!txtdisplay1.Text.Contains("."))
                txtdisplay1.Text += ".";
        }

        private void Numbers_MouseClick(object sender, MouseEventArgs e)  //این تابع وقتی کلیک موس روی هر یک از دکمه‌های اعداد (0 تا 9) اتفاق می‌افتد فراخوانی می‌شود.
        {
            if (txtdisplay1.Text == "0" || flag_op == true)
            {
                txtdisplay1.Text = ((Button)sender).Text;
                flag_op = false;
            }
            else
                txtdisplay1.Text += ((Button)sender).Text;
        }

    }
}
