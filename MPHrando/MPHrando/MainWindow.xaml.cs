using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace MPHrandomizer
{
    static class FilePath
    {
        public static string pathEntityFldr;
        public static string fileName;
    }

    public partial class MainWindow : Window
    {
        byte[] valueIn = new byte[] {};
        int location;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void randomize_click(object sender, RoutedEventArgs e)
        {
            if (FilePath.pathEntityFldr != null)
            {
                switch (locationSelector.SelectedIndex)
                {
                    case 0:
                        FilePath.fileName = "\\Unit2_RM2_Ent.bin";
                        location = 4844;
                        break;
                    case 1:
                        FilePath.fileName = "\\Unit2_RM6_Ent.bin";
                        location = 1168;
                        break;
                    case 2:
                        FilePath.fileName = "\\Unit2_RM1_Ent.bin";
                        location = 8324;
                        break;
                    case 3:
                        FilePath.fileName = "\\Unit2_C7_Ent.bin";
                        location = 11216;
                        break;
                    case 4:
                        FilePath.fileName = "\\Unit2_RM2_Ent.bin";
                        location = 5212;
                        break;
                    case 5:
                        FilePath.fileName = "\\Unit2_RM7_Ent.bin";
                        location = 988;
                        break;
                    case 6:
                        FilePath.fileName = "\\Unit2_Land_Ent.bin";
                        location = 4372;
                        break;
                    case 7:
                        FilePath.fileName = "\\Unit2_RM2_Ent.bin";
                        location = 9668;
                        break;
                    case 8:
                        FilePath.fileName = "\\Unit2_RM4_Ent.bin";
                        location = 17360;
                        break;
                    case 9:
                        FilePath.fileName = "\\Unit2_RM8_Ent.bin";
                        location = 7324;
                        break;
                    case 10:
                        FilePath.fileName = "\\unit1_rm3_Ent.bin";
                        location = 4192;
                        break;
                    case 11:
                        FilePath.fileName = "\\Unit1_C0_Ent.bin";
                        location = 3444;
                        break;
                    case 12:
                        FilePath.fileName = "\\unit1_rm3_Ent.bin";
                        location = 4048;
                        break;
                    case 13:
                        FilePath.fileName = "\\Unit1_Land_Ent.bin";
                        location = 2068;
                        break;
                    case 14:
                        FilePath.fileName = "\\unit1_RM1_Ent.bin";
                        location = 15916;
                        break;
                    case 15:
                        FilePath.fileName = "\\unit1_RM2_Ent.bin";
                        location = 4272;
                        break;
                    case 16:
                        FilePath.fileName = "\\Unit1_C4_Ent.bin";
                        location = 3308;
                        break;
                    case 17:
                        FilePath.fileName = "\\unit1_rm5_Ent.bin";
                        location = 4932;
                        break;
                    case 18:
                        FilePath.fileName = "\\Unit3_C2_Ent.bin";
                        location = 2119;
                        break;
                    case 19:
                        FilePath.fileName = "\\Unit3_C2_Ent.bin";
                        location = 5872;
                        break;
                    case 20:
                        FilePath.fileName = "\\Unit3_RM2_Ent.bin";
                        location = 17812;
                        break;
                    case 21:
                        FilePath.fileName = "\\Unit3_rm4_Ent.bin";
                        location = 6412;
                        break;
                    case 22:
                        FilePath.fileName = "\\Unit3_RM3_Ent.bin";
                        location = 19848;
                        break;
                    case 23:
                        FilePath.fileName = "\\Unit4_RM1_Ent.bin";
                        location = 10276;
                        break;
                    case 24:
                        FilePath.fileName = "\\Unit4_RM5_Ent.bin";
                        location = 4332;
                        break;
                    case 25:
                        FilePath.fileName = "\\unit4_rm3_Ent.bin";
                        location = 5112;
                        break;
                    case 26:
                        FilePath.fileName = "\\Unit4_C0_Ent.bin";
                        location = 8764;
                        break;
                    case 27:
                        FilePath.fileName = "\\Unit4_RM1_Ent.bin";
                        location = 24556;
                        break;
                    case 28:
                        FilePath.fileName = "\\Unit4_RM2_Ent.bin";
                        location = 7848;
                        break;
                    case 29:
                        FilePath.fileName = "\\Unit4_RM1_Ent.bin";
                        location = 11160;
                        break;
                    case 30:
                        FilePath.fileName = "\\Unit4_RM1_Ent.bin";
                        location = 52732;
                        break;
                    case 31:
                        FilePath.fileName = "\\unit4_rm4_Ent.bin";
                        location = 12220;
                        break;
                    case 32:
                        FilePath.fileName = "\\unit4_C1_Ent.bin";
                        location = 23840;
                        break;
                    case 33:
                        FilePath.fileName = "\\Gorea_Peek_Ent.bin";
                        location = 312;
                        break;
                }
                string fullPath = FilePath.pathEntityFldr + FilePath.fileName;
                textblock.Text = "Wrote to: " + fullPath;
                //these two lines set up the writing
                FileStream ws = new FileStream(fullPath, FileMode.Open, FileAccess.Write);
                StreamWriter writeStream = new StreamWriter(ws);
                //this line tells the stream writer where to go
                writeStream.BaseStream.Seek(location, SeekOrigin.Current);
                //this variable is the byte that you want to write into the file
                switch (itemSelector.SelectedIndex)
                {
                    //none
                    case 0:
                        valueIn = new byte[] { 0xFF };
                        break;
                    //HealthMedium
                    case 1:
                        valueIn = new byte[] { 0x00 };
                        break;
                    //HealthSmall
                    case 2:
                        valueIn = new byte[] { 0x01 };
                        break;
                    //HealthBig
                    case 3:
                        valueIn = new byte[] { 0x02 };
                        break;
                    //DoubleDamage
                    case 4:
                        valueIn = new byte[] { 0x03 };
                        break;
                    //EnergyTank
                    case 5:
                        valueIn = new byte[] { 0x04 };
                        break;
                    //VoltDriver
                    case 6:
                        valueIn = new byte[] { 0x05 };
                        break;
                    //MissileExpansion
                    case 7:
                        valueIn = new byte[] { 0x06 };
                        break;
                    //Battlehammer
                    case 8:
                        valueIn = new byte[] { 0x07 };
                        break;
                    //Imperialist
                    case 9:
                        valueIn = new byte[] { 0x08 };
                        break;
                    //Judicator
                    case 10:
                        valueIn = new byte[] { 0x09 };
                        break;
                    //Magmaul
                    case 11:
                        valueIn = new byte[] { 0x0A };
                        break;
                    //ShockCoil
                    case 12:
                        valueIn = new byte[] { 0x0B };
                        break;
                    //OmegaCannon
                    case 13:
                        valueIn = new byte[] { 0x0C };
                        break;
                    //UASmall
                    case 14:
                        valueIn = new byte[] { 0x0D };
                        break;
                    //UABig
                    case 15:
                        valueIn = new byte[] { 0x0E };
                        break;
                    //MissileSmall
                    case 16:
                        valueIn = new byte[] { 0x0F };
                        break;
                    //MissileBig
                    case 17:
                        valueIn = new byte[] { 0x10 };
                        break;
                    //Cloak
                    case 18:
                        valueIn = new byte[] { 0x11 };
                        break;
                    //UAExpansion
                    case 19:
                        valueIn = new byte[] { 0x12 };
                        break;
                    //ArtifactKey
                    case 20:
                        valueIn = new byte[] { 0x13 };
                        break;
                    //Deathalt
                    case 21:
                        valueIn = new byte[] { 0x14 };
                        break;
                    //AffinityWeapon
                    case 22:
                        valueIn = new byte[] { 0x15 };
                        break;
                    //PickWpnMissile
                    case 23:
                        valueIn = new byte[] { 0x16 };
                        break;
                }
                writeStream.BaseStream.Write(valueIn, 0, 1);
                writeStream.Close();
            }
        }

        public void fileSelect_click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = System.Windows.Forms.Application.StartupPath;
            DialogResult result = fbd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                FilePath.pathEntityFldr = fbd.SelectedPath;
            }
        }
    }
}