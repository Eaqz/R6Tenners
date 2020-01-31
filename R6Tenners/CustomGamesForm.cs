using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace R6Tenners
{
    public partial class CustomGamesForm : MetroForm
    {
        List<Tuple<string, bool, bool, bool, bool>> players = new List<Tuple<string, bool, bool, bool, bool>>(); // Username, DLC1, DLC2, DLC3, DLC4
        List<string> operatorsATK = new List<string>();
        List<string> operatorsDEF = new List<string>();
        List<string> maps = new List<string>();
        List<string> time = new List<string>();
        string oldMAP, currentMAP, currentTIME;
        string[] allATKop;
        string[] allDEFop;

        public CustomGamesForm()
        {
            InitializeComponent();
        }
        private void CustomGamesForm_Load(object sender, EventArgs e)
        {
            version_Lb.Text = "Current Version : " + this.ProductVersion;
            themecolour_Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            allATKop = Properties.Resources.ATK.Split('|');
            allDEFop = Properties.Resources.DEF.Split('|');

            string[] allMaps = Properties.Resources.MAPS.Split('|');
            int mapCount = 0;

            while (allMaps[mapCount] != "NULL")
            {
                maps.Add(allMaps[mapCount]);
                mapCount++;
            }

            string[] allTimes = Properties.Resources.TIMES.Split('|');
            int timeCount = 0;

            while (allTimes[timeCount] != "NULL")
            {
                time.Add(allTimes[timeCount]);
                timeCount++;
            }
        }
        private void CustomGamesForm_Close(object sender, FormClosingEventArgs e)
        {
        }

        private string rename_map(string mapName)
        {
            if (mapName == "bank")
                mapName = "Bank";

            if (mapName == "border")
                mapName = "Border";

            if (mapName == "chalet")
                mapName = "Chalet";

            if (mapName == "clubhouse")
                mapName = "Club House";

            if (mapName == "coastline")
                mapName = "Coastline";

            if (mapName == "consulate")
                mapName = "Consulate";

            if (mapName == "favela")
                mapName = "Favela";

            if (mapName == "fortress")
                mapName = "Fortress";

            if (mapName == "hereford")
                mapName = "Hereford Base";

            if (mapName == "house")
                mapName = "House";

            if (mapName == "kafe")
                mapName = "Kafe Dostoyevsky";

            if (mapName == "kanal")
                mapName = "Kanal";

            if (mapName == "oregon")
                mapName = "Oregon";

            if (mapName == "outback")
                mapName = "Outback";

            if (mapName == "plane")
                mapName = "Presidential Plane";

            if (mapName == "skyscraper")
                mapName = "Skyscraper";

            if (mapName == "themepark")
                mapName = "Theme Park";

            if (mapName == "tower")
                mapName = "Tower";

            if (mapName == "villa")
                mapName = "Villa";

            if (mapName == "yatch")
                mapName = "Yatch";

            return mapName;
        }

        private void themecolour_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroTextBox[] Usernames = { player1_tb, player2_tb, player3_tb, player4_tb, player5_tb, player6_tb, player7_tb, player8_tb, player9_tb, player10_tb };
            MetroCheckBox[] DLCs = { dlc1_cb1, dlc1_cb2, dlc1_cb3, dlc1_cb4, dlc1_cb5, dlc1_cb6, dlc1_cb7, dlc1_cb8, dlc1_cb9, dlc1_cb10,
                               dlc2_cb1, dlc2_cb2, dlc2_cb3, dlc2_cb4, dlc2_cb5, dlc2_cb6, dlc2_cb7, dlc2_cb8, dlc2_cb9, dlc2_cb10,
                               dlc3_cb1, dlc3_cb2, dlc3_cb3, dlc3_cb4, dlc3_cb5, dlc3_cb6, dlc3_cb7, dlc3_cb8, dlc3_cb9, dlc3_cb10,
                               dlc4_cb1, dlc4_cb2, dlc4_cb3, dlc4_cb4, dlc4_cb5, dlc4_cb6, dlc4_cb7, dlc4_cb8, dlc4_cb9, dlc4_cb10 };

            switch (themecolour_Cb.Text)
            {
                case "Black":
                    this.Style = MetroFramework.MetroColorStyle.Black;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Black;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Black;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Black;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Black;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Black;
                    }
                    break;

                case "White":
                    this.Style = MetroFramework.MetroColorStyle.White;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.White;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.White;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.White;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.White;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.White;
                    }
                    break;

                case "Silver":
                    this.Style = MetroFramework.MetroColorStyle.Silver;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Silver;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Silver;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Silver;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Silver;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Silver;
                    }
                    break;

                case "Blue":
                    this.Style = MetroFramework.MetroColorStyle.Blue;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Blue;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Blue;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Blue;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Blue;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Blue;
                    }
                    break;

                case "Green":
                    this.Style = MetroFramework.MetroColorStyle.Green;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Green;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Green;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Green;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Green;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Green;
                    }
                    break;

                case "Lime":
                    this.Style = MetroFramework.MetroColorStyle.Lime;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Lime;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Lime;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Lime;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Lime;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Lime;
                    }
                    break;

                case "Teal":
                    this.Style = MetroFramework.MetroColorStyle.Teal;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Teal;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Teal;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Teal;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Teal;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Teal;
                    }
                    break;

                case "Orange":
                    this.Style = MetroFramework.MetroColorStyle.Orange;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Orange;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Orange;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Orange;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Orange;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Orange;
                    }
                    break;

                case "Brown":
                    this.Style = MetroFramework.MetroColorStyle.Brown;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Brown;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Brown;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Brown;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Brown;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Brown;
                    }
                    break;

                case "Pink":
                    this.Style = MetroFramework.MetroColorStyle.Pink;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Pink;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Pink;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Pink;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Pink;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Pink;
                    }
                    break;

                case "Magenta":
                    this.Style = MetroFramework.MetroColorStyle.Magenta;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Magenta;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Magenta;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Magenta;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Magenta;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Magenta;
                    }
                    break;

                case "Purple":
                    this.Style = MetroFramework.MetroColorStyle.Purple;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Purple;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Purple;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Purple;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Purple;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Purple;
                    }
                    break;

                case "Red":
                    this.Style = MetroFramework.MetroColorStyle.Red;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Red;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Red;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Red;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Red;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Red;
                    }
                    break;

                case "Yellow":
                    this.Style = MetroFramework.MetroColorStyle.Yellow;
                    esl_Cb.Style = MetroFramework.MetroColorStyle.Yellow;
                    mapRoll_Cb.Style = MetroFramework.MetroColorStyle.Yellow;
                    randomOP_Cb.Style = MetroFramework.MetroColorStyle.Yellow;
                    foreach (MetroTextBox MTB in Usernames)
                    {
                        MTB.Style = MetroFramework.MetroColorStyle.Yellow;
                    }
                    foreach (MetroCheckBox DCB in DLCs)
                    {
                        DCB.Style = MetroFramework.MetroColorStyle.Yellow;
                    }
                    break;
            }

            this.Refresh();
        }

        private void changeserver_Btn_Click(object sender, EventArgs e)
        {
            ServerSwitchForm switchform = new ServerSwitchForm();
            switchform.Show();
        }

        private void resetnames_btn_Click(object sender, EventArgs e)
        {
            MetroTextBox[] Usernames = { player1_tb, player2_tb, player3_tb, player4_tb, player5_tb, player6_tb, player7_tb, player8_tb, player9_tb, player10_tb };
            Label[] Labels = { orange1_Lb, orange2_Lb, orange3_Lb, orange4_Lb, orange5_Lb, blue1_Lb, blue2_Lb, blue3_Lb, blue4_Lb, blue5_Lb };
            PictureBox[] OperatorsATK = { orangeATK1_Pb, orangeATK2_Pb, orangeATK3_Pb, orangeATK4_Pb, orangeATK5_Pb, blueATK1_Pb, blueATK2_Pb, blueATK3_Pb, blueATK4_Pb, blueATK5_Pb };
            PictureBox[] OperatorsDEF = { orangeDEF1_Pb, orangeDEF2_Pb, orangeDEF3_Pb, orangeDEF4_Pb, orangeDEF5_Pb, blueDEF1_Pb, blueDEF2_Pb, blueDEF3_Pb, blueDEF4_Pb, blueDEF5_Pb };
            CheckBox[] DLC1 = { dlc1_cb1, dlc1_cb2, dlc1_cb3, dlc1_cb4, dlc1_cb5, dlc1_cb6, dlc1_cb7, dlc1_cb8, dlc1_cb9, dlc1_cb10 };
            CheckBox[] DLC2 = { dlc2_cb1, dlc2_cb2, dlc2_cb3, dlc2_cb4, dlc2_cb5, dlc2_cb6, dlc2_cb7, dlc2_cb8, dlc2_cb9, dlc2_cb10 };
            CheckBox[] DLC3 = { dlc3_cb1, dlc3_cb2, dlc3_cb3, dlc3_cb4, dlc3_cb5, dlc3_cb6, dlc3_cb7, dlc3_cb8, dlc3_cb9, dlc3_cb10 };
            CheckBox[] DLC4 = { dlc4_cb1, dlc4_cb2, dlc4_cb3, dlc4_cb4, dlc4_cb5, dlc4_cb6, dlc4_cb7, dlc4_cb8, dlc4_cb9, dlc4_cb10 };

            Label[] opLabels = { atkLb1, atkLb2, atkLb3, atkLb4, atkLb5, atkLb6, atkLb7, atkLb8, atkLb9, atkLb10, defLb1, defLb2, defLb3, defLb4, defLb5, defLb6, defLb7, defLb8, defLb9, defLb10 };

            foreach (Label opLabel in opLabels)
                opLabel.Visible = false;

            for (int i = 0; i < 10; i++)
            {
                Usernames[i].Text = String.Empty;
                OperatorsATK[i].Image = null;
                OperatorsDEF[i].Image = null;
                Labels[i].Text = "**TBD**";
                Labels[i].Visible = false;
                DLC1[i].Checked = true;
                DLC2[i].Checked = true;
                DLC3[i].Checked = true;
                DLC4[i].Checked = true;
            }

            map_Pb.Image = null;
            map_Lb.Visible = false;
            map_Lb.Text = "";
            time_Lb.Visible = false;
            time_Lb.Text = "";
            players.Clear();
        }

        private void randomize_btn_Click(object sender, EventArgs e)
        {
            bool letsgo = true;

            MetroTextBox[] Username = { player1_tb, player2_tb, player3_tb, player4_tb, player5_tb, player6_tb, player7_tb, player8_tb, player9_tb, player10_tb };
            CheckBox[] DLC1 = { dlc1_cb1, dlc1_cb2, dlc1_cb3, dlc1_cb4, dlc1_cb5, dlc1_cb6, dlc1_cb7, dlc1_cb8, dlc1_cb9, dlc1_cb10 };
            CheckBox[] DLC2 = { dlc2_cb1, dlc2_cb2, dlc2_cb3, dlc2_cb4, dlc2_cb5, dlc2_cb6, dlc2_cb7, dlc2_cb8, dlc2_cb9, dlc2_cb10 };
            CheckBox[] DLC3 = { dlc3_cb1, dlc3_cb2, dlc3_cb3, dlc3_cb4, dlc3_cb5, dlc3_cb6, dlc3_cb7, dlc3_cb8, dlc3_cb9, dlc3_cb10 };
            CheckBox[] DLC4 = { dlc4_cb1, dlc4_cb2, dlc4_cb3, dlc4_cb4, dlc4_cb5, dlc4_cb6, dlc4_cb7, dlc4_cb8, dlc4_cb9, dlc4_cb10 };

            for (int i = 0; i < 10; i++)
            {
                if (String.IsNullOrEmpty(Username[i].Text))
                    letsgo = false;
            }

            if (letsgo)
            {
                Label[] Labels = { orange1_Lb, orange2_Lb, orange3_Lb, orange4_Lb, orange5_Lb, blue1_Lb, blue2_Lb, blue3_Lb, blue4_Lb, blue5_Lb };
                PictureBox[] OperatorsATK = { orangeATK1_Pb, orangeATK2_Pb, orangeATK3_Pb, orangeATK4_Pb, orangeATK5_Pb, blueATK1_Pb, blueATK2_Pb, blueATK3_Pb, blueATK4_Pb, blueATK5_Pb };
                PictureBox[] OperatorsDEF = { orangeDEF1_Pb, orangeDEF2_Pb, orangeDEF3_Pb, orangeDEF4_Pb, orangeDEF5_Pb, blueDEF1_Pb, blueDEF2_Pb, blueDEF3_Pb, blueDEF4_Pb, blueDEF5_Pb };
                Label[] opLabels = { atkLb1, atkLb2, atkLb3, atkLb4, atkLb5, atkLb6, atkLb7, atkLb8, atkLb9, atkLb10, defLb1, defLb2, defLb3, defLb4, defLb5, defLb6, defLb7, defLb8, defLb9, defLb10 };

                if (randomOP_Cb.Checked)
                {
                    for (int i = 0; i < 20; i++)
                        opLabels[i].Visible = true;
                }
                else
                {
                    for (int i = 0; i < 20; i++)
                        opLabels[i].Visible = false;
                }

                for (int i = 0; i < 10; i++)
                    Labels[i].Visible = true;

                map_Lb.Visible = true;
                time_Lb.Visible = true;

                for (int i = 0; i < 10; i++)
                    players.Add(new Tuple<string, bool, bool, bool, bool>(Username[i].Text, DLC1[i].Checked, DLC2[i].Checked, DLC3[i].Checked, DLC4[i].Checked ));

                int allATKCount = 0, allDEFCount = 0;

                while (allATKop[allATKCount] != "NULL")
                {
                    operatorsATK.Add(allATKop[allATKCount]);
                    allATKCount++;
                }

                while (allDEFop[allDEFCount] != "NULL")
                {
                    operatorsDEF.Add(allDEFop[allDEFCount]);
                    allDEFCount++;
                }

                Random randNumMIX = new Random();

                int aRandomPosMIX = randNumMIX.Next(100);

                for (int i = 0; i < aRandomPosMIX; i++)
                {
                    players.Shuffle();
                    operatorsATK.Shuffle();
                    operatorsDEF.Shuffle();
                    maps.Shuffle();
                    time.Shuffle();
                }

                for (int i = 0; i < 5; i++)
                {
                    Random randNumGT = new Random();

                    int aRandomPosGT = randNumGT.Next(players.Count);

                    Labels[i].Text = players[aRandomPosGT].Item1;

                    if (randomOP_Cb.Checked)
                    {
                        bool opretry = false;
                        string opNameATK;
                        string opNameDEF;

                        for (int j = 0; j < 100; j++)
                        {
                            opretry = false;
                            Random randNumATK = new Random();
                            Random randNumDEF = new Random();

                            int aRandomPosATK = randNumATK.Next(operatorsATK.Count);
                            int aRandomPosDEF = randNumDEF.Next(operatorsDEF.Count);

                            if (!players[aRandomPosGT].Item2)
                            {
                                if (operatorsATK[aRandomPosATK].Contains("dlc1") || operatorsDEF[aRandomPosDEF].Contains("dlc1"))
                                {
                                    operatorsATK.Shuffle();
                                    operatorsDEF.Shuffle();
                                    opretry = true;
                                }
                            }
                            if (!players[aRandomPosGT].Item3)
                            {
                                if (operatorsATK[aRandomPosATK].Contains("dlc2") || operatorsDEF[aRandomPosDEF].Contains("dlc2"))
                                {
                                    operatorsATK.Shuffle();
                                    operatorsDEF.Shuffle();
                                    opretry = true;
                                }
                            }
                             
                            if (!players[aRandomPosGT].Item4)
                            {
                                if (operatorsATK[aRandomPosATK].Contains("dlc3") || operatorsDEF[aRandomPosDEF].Contains("dlc3"))
                                {
                                    operatorsATK.Shuffle();
                                    operatorsDEF.Shuffle();
                                    opretry = true;
                                }
                            }
                            if (!players[aRandomPosGT].Item5)
                            {
                                if (operatorsATK[aRandomPosATK].Contains("dlc4") || operatorsDEF[aRandomPosDEF].Contains("dlc4"))
                                {
                                    operatorsATK.Shuffle();
                                    operatorsDEF.Shuffle();
                                    opretry = true;
                                }
                            }

                            if (!opretry)
                            {
                                opNameATK = operatorsATK[aRandomPosATK];
                                opNameDEF = operatorsDEF[aRandomPosDEF];

                                if (opNameATK.Contains("_dlc"))
                                    opNameATK = opNameATK.Substring(0, opNameATK.Length - 5);
                                if (opNameDEF.Contains("_dlc"))
                                    opNameDEF = opNameDEF.Substring(0, opNameDEF.Length - 5);

                                object objATK = Properties.Resources.ResourceManager.GetObject(opNameATK);
                                object objDEF = Properties.Resources.ResourceManager.GetObject(opNameDEF);
                                OperatorsATK[i].SizeMode = PictureBoxSizeMode.Zoom;
                                OperatorsDEF[i].SizeMode = PictureBoxSizeMode.Zoom;
                                OperatorsATK[i].Image = ((System.Drawing.Bitmap)(objATK));
                                OperatorsDEF[i].Image = ((System.Drawing.Bitmap)(objDEF));

                                string opATK = operatorsATK[aRandomPosATK], opDEF = operatorsDEF[aRandomPosDEF];

                                operatorsATK.Remove(opATK);
                                operatorsDEF.Remove(opDEF);
                                break;
                            }
                        }
                    }
                    else
                    {
                        OperatorsATK[i].Image = null;
                        OperatorsDEF[i].Image = null;
                    }

                    string opGT = players[aRandomPosGT].Item1;
                    bool opDLC1 = players[aRandomPosGT].Item2, opDLC2 = players[aRandomPosGT].Item3, opDLC3 = players[aRandomPosGT].Item4, opDLC4 = players[aRandomPosGT].Item5;
                    players.Remove(new Tuple<string, bool, bool, bool, bool>(opGT, opDLC1, opDLC2, opDLC3, opDLC4));
                }

                operatorsATK.Clear();
                operatorsDEF.Clear();

                allATKCount = 0;
                allDEFCount = 0;

                while (allATKop[allATKCount] != "NULL")
                {
                    operatorsATK.Add(allATKop[allATKCount]);
                    allATKCount++;
                }

                while (allDEFop[allDEFCount] != "NULL")
                {
                    operatorsDEF.Add(allDEFop[allDEFCount]);
                    allDEFCount++;
                }

                Random randNumMIX2 = new Random();

                int aRandomPosMIX2 = randNumMIX2.Next(75);

                for (int i = 0; i < aRandomPosMIX2; i++)
                {
                    operatorsATK.Shuffle();
                    operatorsDEF.Shuffle();
                }

                for (int i = 5; i < 10; i++)
                {
                    Random randNumGT = new Random();

                    int aRandomPosGT = randNumGT.Next(players.Count);

                    Labels[i].Text = players[aRandomPosGT].Item1;

                    if (randomOP_Cb.Checked)
                    {
                        bool opretry = false;
                        string opNameATK;
                        string opNameDEF;

                        for (int j = 0; j < 100; j++)
                        {
                            opretry = false;
                            Random randNumATK = new Random();
                            Random randNumDEF = new Random();

                            int aRandomPosATK = randNumATK.Next(operatorsATK.Count);
                            int aRandomPosDEF = randNumDEF.Next(operatorsDEF.Count);

                            if (!players[aRandomPosGT].Item2)
                            {
                                if (operatorsATK[aRandomPosATK].Contains("dlc1") || operatorsDEF[aRandomPosDEF].Contains("dlc1"))
                                {
                                    operatorsATK.Shuffle();
                                    operatorsDEF.Shuffle();
                                    opretry = true;
                                }
                            }
                            if (!players[aRandomPosGT].Item3)
                            {
                                if (operatorsATK[aRandomPosATK].Contains("dlc2") || operatorsDEF[aRandomPosDEF].Contains("dlc2"))
                                {
                                    operatorsATK.Shuffle();
                                    operatorsDEF.Shuffle();
                                    opretry = true;
                                }
                            }
                            if (!players[aRandomPosGT].Item4)
                            {
                                if (operatorsATK[aRandomPosATK].Contains("dlc3") || operatorsDEF[aRandomPosDEF].Contains("dlc3"))
                                {
                                    operatorsATK.Shuffle();
                                    operatorsDEF.Shuffle();
                                    opretry = true;
                                }
                            }
                            if (!players[aRandomPosGT].Item5)
                            {
                                if (operatorsATK[aRandomPosATK].Contains("dlc4") || operatorsDEF[aRandomPosDEF].Contains("dlc4"))
                                {
                                    operatorsATK.Shuffle();
                                    operatorsDEF.Shuffle();
                                    opretry = true;
                                }
                            }

                            if (!opretry)
                            {
                                opNameATK = operatorsATK[aRandomPosATK];
                                opNameDEF = operatorsDEF[aRandomPosDEF];

                                if (opNameATK.Contains("dlc"))
                                    opNameATK = opNameATK.Substring(0, opNameATK.Length - 5);
                                if (opNameDEF.Contains("dlc"))
                                    opNameDEF = opNameDEF.Substring(0, opNameDEF.Length - 5);

                                object objATK = Properties.Resources.ResourceManager.GetObject(opNameATK);
                                object objDEF = Properties.Resources.ResourceManager.GetObject(opNameDEF);
                                OperatorsATK[i].SizeMode = PictureBoxSizeMode.Zoom;
                                OperatorsDEF[i].SizeMode = PictureBoxSizeMode.Zoom;
                                OperatorsATK[i].Image = ((System.Drawing.Bitmap)(objATK));
                                OperatorsDEF[i].Image = ((System.Drawing.Bitmap)(objDEF));

                                string opATK = operatorsATK[aRandomPosATK], opDEF = operatorsDEF[aRandomPosDEF];

                                operatorsATK.Remove(opATK);
                                operatorsDEF.Remove(opDEF);
                                break;
                            }
                        }
                    }
                    else
                    {
                        OperatorsATK[i].Image = null;
                        OperatorsDEF[i].Image = null;
                    }

                    string opGT = players[aRandomPosGT].Item1;
                    bool opDLC1 = players[aRandomPosGT].Item2, opDLC2 = players[aRandomPosGT].Item3, opDLC3 = players[aRandomPosGT].Item4, opDLC4 = players[aRandomPosGT].Item5;
                    players.Remove(new Tuple<string, bool, bool, bool, bool>(opGT, opDLC1, opDLC2, opDLC3, opDLC4));
                }

                Random randNumTIME = new Random();
                int aRandomPosTIME = randNumTIME.Next(time.Count - 1);
                string mapName;
                bool retry = false;

                for (int i = 0; i < 100; i++)
                {
                    retry = false;
                    Random randNumMAP = new Random();
                    int aRandomPosMAP = randNumMAP.Next(maps.Count - 1);

                    if (mapRoll_Cb.Checked)
                    {
                        if (esl_Cb.Checked)
                        {
                            if (maps[aRandomPosMAP].Contains("_esl"))
                            {
                                if (maps[aRandomPosMAP] == oldMAP)
                                {
                                    maps.Shuffle();
                                    retry = true;
                                }
                            }
                            else
                            {
                                maps.Shuffle();
                                retry = true;
                            }
                        }
                        else
                        {
                            if (maps[aRandomPosMAP] == oldMAP)
                            {
                                maps.Shuffle();
                                retry = true;
                            }
                        }
                    }

                    if (!retry)
                    {
                        if (esl_Cb.Checked)
                        {
                            if (maps[aRandomPosMAP].Contains("_esl"))
                            {
                                mapName = maps[aRandomPosMAP];
                                mapName = mapName.Substring(0, mapName.Length - 4);
                                object objMAP = Properties.Resources.ResourceManager.GetObject(mapName);
                                map_Pb.SizeMode = PictureBoxSizeMode.Zoom;
                                map_Pb.Image = ((System.Drawing.Bitmap)(objMAP));
                                currentMAP = mapName;

                                mapName = rename_map(mapName);

                                map_Lb.Text = "Map : " + mapName;
                                time_Lb.Text = "Time : Day";
                                oldMAP = maps[aRandomPosMAP];
                                break;
                            }
                        }
                        else
                        {
                            if (maps[aRandomPosMAP].Contains("_esl"))
                            {
                                mapName = maps[aRandomPosMAP];
                                mapName = mapName.Substring(0, mapName.Length - 4);

                                object objMAP = Properties.Resources.ResourceManager.GetObject(mapName);
                                map_Pb.SizeMode = PictureBoxSizeMode.Zoom;
                                map_Pb.Image = ((System.Drawing.Bitmap)(objMAP));
                                currentMAP = mapName;

                                mapName = rename_map(mapName);

                                map_Lb.Text = "Map : " + mapName;
                                time_Lb.Text = "Time : " + time[aRandomPosTIME];
                                oldMAP = maps[aRandomPosMAP];
                                break;
                            }
                            else
                            {
                                mapName = maps[aRandomPosMAP];

                                object objMAP = Properties.Resources.ResourceManager.GetObject(mapName);
                                map_Pb.SizeMode = PictureBoxSizeMode.Zoom;
                                map_Pb.Image = ((System.Drawing.Bitmap)(objMAP));
                                currentMAP = mapName;

                                mapName = rename_map(mapName);

                                map_Lb.Text = "Map : " + mapName;
                                time_Lb.Text = "Time : " + time[aRandomPosTIME];
                                oldMAP = maps[aRandomPosMAP];
                                break;
                            }
                        }
                    }
                }

                currentTIME = time[aRandomPosTIME];

                operatorsATK.Clear();
                operatorsDEF.Clear();
                players.Clear();
            }
            else MessageBox.Show("Empty Fields, please enter 10 Usernames.", "Yikes Boomer");
        }
    }
}
