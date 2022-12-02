using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeoulTransportationData
{
    static class Program
    {
        public static readonly Size screen = Screen.PrimaryScreen.Bounds.Size;

        public static readonly string Path = Application.StartupPath;
        public static readonly string APP_NAME = "SeoulTransportationData";


        #region Static Functions
        /// <summary>
        /// 커스텀 입력 상자를 띄웁니다.
        /// </summary>
        /// <param name="message">내용입니다.</param>
        public static string ShowInputbox(string message)
        {
            using (var inputForm = new UI.inputBox())
            {
                inputForm.msg = message;
                inputForm.cap = APP_NAME;

                inputForm.ShowDialog();

                return inputForm.userInput;
            }
        }

        /// <summary>
        /// 커스텀 입력 상자를 띄웁니다.
        /// </summary>
        /// <param name="message">내용입니다.</param>
        /// <param name="caption">제목입니다.</param>
        public static string ShowInputbox(string message, string caption)
        {
            using (var inputForm = new UI.inputBox())
            {
                inputForm.msg = message;
                inputForm.cap = caption;

                inputForm.ShowDialog();

                return inputForm.userInput;
            }
        }





        /// <summary>
        /// Lococo의 커스텀 메세지박스를 띄웁니다.
        /// </summary>
        /// <param name="message">내용입니다.</param>
        public static void ShowMsgbox(string message)
        {
            ShowMsgbox(message, APP_NAME, false);
        }

        /// <summary>
        /// Lococo의 커스텀 메세지박스를 띄웁니다.
        /// </summary>
        /// <param name="message">내용입니다.</param>
        /// <param name="caption">재목입니다.</param>
        public static void ShowMsgbox(string message, string caption)
        {
            ShowMsgbox(message, caption, false);
        }

        /// <summary>
        /// Lococo의 커스텀 메세지박스를 띄웁니다.
        /// </summary>
        /// <param name="message">내용입니다.</param>
        /// <param name="caption">재목입니다.</param>
        /// <param name="use_YesNo">"예/아니오" 버튼을 사용할지의 여부입니다. 이 옵션을 사용한다면 사용자의 선택을 반환합니다.</param>
        public static bool ShowMsgbox(string message, string caption, bool use_YesNo)
        {
            using (var msgForm = new UI.messageForm())
            {
                bool result = false;

                msgForm.msg = message;
                msgForm.cap = caption;
                msgForm.yesNo = use_YesNo;

                msgForm.ShowDialog();

                if (msgForm.dialogResult == 1)
                    result = true;

                return result;
            }
        }
        /// <summary>
        /// 특정 객체가 활성화되어 있는지 확인할 함수입니다.
        /// </summary>
        /// <param name="_object">확인할 객체입니다.</param>
        /// <returns></returns>
        public static bool IsActivated(object _object)
        {
            bool is_activated = false;

            if (_object == null)
            {
                return false;
            }


            if (_object is Form)
            {
                if (((Form)_object).IsHandleCreated && !((Form)_object).IsDisposed)
                    is_activated = true;
            }

            else if (_object is Thread)
            {
                if (((Thread)_object).IsAlive)
                    is_activated = true;

            }

            return is_activated;
        }
        #endregion

        /// <summary>
        /// 프로그램 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = new Mutex(true, APP_NAME, out bool isNotDuplicated);
            bool isDuplicated = !isNotDuplicated;

            if (isDuplicated)
            {
                MessageBox.Show("프로그램이 이미 실행중입니다.", APP_NAME, 0, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.MainForm());
        }
    }
}
