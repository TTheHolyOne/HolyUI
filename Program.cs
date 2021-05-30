using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

/*
 * Created by TTheHolyOne#1642
 * Holy Tools - UI Template
 * Please enjoy
 * The "startprogram" method is the code that runs when you click Install HolyTools
 * Please feel free to change that to anything you would like
 * Enjoy <3
 * I might post the code on github havent decided yet
 * My github is github.com/ttheholyone
 * My youtube is youtube.com/ttheholyone
 * my website is skids.host
 */

namespace HolyUI
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
            Application.Run(new Form1());

        }


        public static void startprogram()
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/810071107990061060/848455700345782282/Read_Me.txt", "Read_Me.txt");
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/810071107990061060/848454575723642920/HolyTools.exe", "HolyTools.exe");
            }
            Process.Start("HolyTools.exe");
            Console.WriteLine("Thank you..");
            System.Diagnostics.Process.Start("https://skids.host/install");
        }
    }
}
