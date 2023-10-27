using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace PROJECT_NetGameVN_STINGDAU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());






            ///////////////////////////////////////////////


            int port = 20; // Số cổng lắng nghe

            TcpListener listener = new TcpListener(IPAddress.Any, port);
            listener.Start();

            Console.WriteLine("Đang lắng nghe kết nối...");
            TcpClient client = listener.AcceptTcpClient();

            NetworkStream stream = client.GetStream();
            byte[] data = new byte[1024];
            int bytesRead = stream.Read(data, 0, data.Length);
            string command = Encoding.UTF8.GetString(data, 0, bytesRead);

            if (command.ToLower() == "shutdown")
            {
                Console.WriteLine("Nhận lệnh tắt máy. Đang tắt máy...");
                System.Diagnostics.Process.Start("shutdown", "/s /t 0"); // Tắt máy
            }

            client.Close();
            listener.Stop();

            /////////////////////////////////////////////////
        }
    }
}
