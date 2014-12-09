using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace Testat2FileServer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //    int portN = 9876;

        //    TcpListener Listener = null;
        //    try
        //    {
        //        Listener = new TcpListener(IPAddress.Any, portN);
        //        Listener.Start();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    byte[] RecData = new byte[BufferSize];
        //    int RecBytes;

        //    for (; ; )
        //    {
        //        TcpClient client = null;
        //        NetworkStream netstream = null;
        //        Status = string.Empty;
        //        try
        //        {
        //            string message = "Accept the Incoming File ";
        //            string caption = "Incoming Connection";
        //            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        //            DialogResult result;

        //            if (Listener.Pending())
        //            {
        //                client = Listener.AcceptTcpClient();
        //                netstream = client.GetStream();
        //                Status = "Connected to a client\n";
        //                result = MessageBox.Show(message, caption, buttons);

        //                if (result == System.Windows.Forms.DialogResult.Yes)
        //                {
        //                    string SaveFileName = string.Empty;
        //                    SaveFileDialog DialogSave = new SaveFileDialog();
        //                    DialogSave.Filter = "All files (*.*)|*.*";
        //                    DialogSave.RestoreDirectory = true;
        //                    DialogSave.Title = "Where do you want to save the file?";
        //                    DialogSave.InitialDirectory = @"C:/";
        //                    if (DialogSave.ShowDialog() == DialogResult.OK)
        //                        SaveFileName = DialogSave.FileName;
        //                    if (SaveFileName != string.Empty)
        //                    {
        //                        int totalrecbytes = 0;
        //                        FileStream Fs = new FileStream(SaveFileName, FileMode.OpenOrCreate, FileAccess.Write);
        //                        while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
        //                        {
        //                            Fs.Write(RecData, 0, RecBytes);
        //                            totalrecbytes += RecBytes;
        //                        }
        //                        Fs.Close();
        //                    }
        //                    netstream.Close();
        //                    client.Close();
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            //netstream.Close();
        //        }
        //    }

        //}
    }
}
