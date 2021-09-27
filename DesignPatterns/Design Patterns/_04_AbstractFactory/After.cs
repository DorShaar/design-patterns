using System;
using System.Collections.Generic;
using System.Text;
using _04_AbstractFactory.Controls;

namespace _04_AbstractFactory
{
    public class After
    {
        public static void Run()
        {
            IControlFactory controlsFactory = null;
#if WINXP
            controlsFactory = new ControlFactoryXP();
#else
            controlsFactory = new ControlFactoryWin10();
#endif

            new FormWithControls(controlsFactory).Show();
        }

        public class FormWithControls
        {
            private IControlFactory m_CtrlFactory;
            private Button m_Button;
            private CheckBox m_CheckBox;

            public FormWithControls(
                IControlFactory i_ControlFactory)
            {
                m_CtrlFactory = i_ControlFactory;
            }

            public void Show()
            {
                m_Button =
                    m_CtrlFactory.CreateButton();

                m_CheckBox =
                    m_CtrlFactory.CreateCheckBox();

                Console.WriteLine("I am a form with " +
                    m_CtrlFactory.GetType().Name);

                m_CheckBox.Checked = true;
                m_Button.Text = "button-text";

                m_Button.Draw();
                m_CheckBox.Draw();
            }
        }

        public interface IControlFactory
        {
            Button CreateButton();

            CheckBox CreateCheckBox();
        }

        public class ControlFactoryWin10 : IControlFactory
        {
            public Button CreateButton()
            {
                return new ButtonWin10();
            }

            public CheckBox CreateCheckBox()
            {
                return new CheckBoxWin10();
            }
        }

        public class ControlFactoryXP : IControlFactory
        {
            public Button CreateButton()
            {
                return new ButtonXP();
            }

            public CheckBox CreateCheckBox()
            {
                return new CheckBoxXP();
            }
        }
    }
}
