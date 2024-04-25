using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail_SMPT
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Manage());
            
        }
        public static void closeAll()
        {
            // Tạo một danh sách tạm thời chứa các form cần đóng
            List<Form> formsToClose = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form != Application.OpenForms[0]) // Form ban đầu được giữ lại
                {
                    formsToClose.Add(form);
                }
            }

            // Duyệt qua danh sách tạm thời và đóng các form
            foreach (Form form in formsToClose)
            {
                form.Close();
            }
        }
    }
}
