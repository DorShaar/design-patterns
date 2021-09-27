using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;
using _04_AbstractFactory.Controls;

namespace _04_AbstractFactory
{
    public class Before
    {
        public static void Run()
        {
            Button button;
            CheckBox checkBox;
#if WINXP
            Console.WriteLine("I am a form with winXP controls");
			button = new ButtonXP();
			checkBox = new CheckBoxXP();
#else
            Console.WriteLine("I am a form with win10 controls");
            button = new ButtonWin10();
            checkBox = new CheckBoxWin10();
#endif
            button.Text = "button text";
            checkBox.Checked = true;

            button.Draw();
            checkBox.Draw();

            button.Click();
        }
    }
}