/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 15.04.2019
 * Время: 14:30
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Раскраска
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ПредыдущееЗаданиеToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm f1 = new MainForm();
			f1.Show();
			Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			 if(radioButton1.Checked)
                button2.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button2.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button2.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button2.BackColor = Color.Black;
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button14.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button14.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button14.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button14.BackColor = Color.Black;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button1.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button1.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button1.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button1.BackColor = Color.Black;
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button5.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button5.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button5.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button5.BackColor = Color.Black;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
		if(radioButton1.Checked)
                button3.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button3.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button3.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button3.BackColor = Color.Black;	
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button4.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button4.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button4.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button4.BackColor = Color.Black;
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button6.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button6.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button6.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button6.BackColor = Color.Black;
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button15.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button15.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button15.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button15.BackColor = Color.Black;
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button16.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button16.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button16.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button16.BackColor = Color.Black;
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button7.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button7.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button7.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button7.BackColor = Color.Black;
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button8.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button8.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button8.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button8.BackColor = Color.Black;
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button10.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button10.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button10.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button10.BackColor = Color.Black;
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button9.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button9.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button9.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button9.BackColor = Color.Black;
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button11.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button11.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button11.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button11.BackColor = Color.Black;
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
                button12.BackColor = Color.Tomato;
            if(radioButton2.Checked)
                button12.BackColor = Color.Yellow;
            if(radioButton3.Checked)
                button12.BackColor =Color.Teal; 
            if(radioButton4.Checked)
            	button12.BackColor = Color.Black;
		}

        private void Button17_Click(object sender, EventArgs e)
        {
               if (button3.BackColor == Color.Yellow)
                    if (button5.BackColor == Color.Yellow)
                        if (button1.BackColor == Color.Black)
                            if (button2.BackColor == Color.Black)
                                if (button4.BackColor == Color.Black)
                                    if (button6.BackColor == Color.Black)
                                        if (button7.BackColor == Color.Black)
                                            if (button8.BackColor == Color.Black)
                                                if (button9.BackColor == Color.Black)
                                                    if (button10.BackColor == Color.Black)
                                                        if (button11.BackColor == Color.Black)
                                                            if (button12.BackColor == Color.Black)

                                                                if (button14.BackColor == Color.Black)
                                                                    if (button15.BackColor == Color.Black)
                                                                    {
                                                                    MainForm f1 = new MainForm();
                                                                    f1.Show();
                                                                    Hide();                                                                
                                                                }
            }

        private void Button13_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
            button10.BackColor = Color.Gainsboro;
            button11.BackColor = Color.Gainsboro;
            button12.BackColor = Color.Gainsboro;
            button14.BackColor = Color.Gainsboro;
            button15.BackColor = Color.Gainsboro;
            button16.BackColor = Color.Gainsboro;
        }

        private void ИгратьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
            button10.BackColor = Color.Gainsboro;
            button11.BackColor = Color.Gainsboro;
            button12.BackColor = Color.Gainsboro;
            button14.BackColor = Color.Gainsboro;
            button15.BackColor = Color.Gainsboro;
            button16.BackColor = Color.Gainsboro;
        }
    }
}

