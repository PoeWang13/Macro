using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;
using System.Drawing.Imaging;
namespace Macro
{
    public partial class Macrom : Form
    {
        // Genel
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private int mouseKoorX = 0;
        private int mouseKoorY = 0;
        private int clickStartStopKey = 0;
        private int clickMousePosKey = 1;
        private ClickButton clickButton = new ClickButton();
        public Macrom()
        {
            InitializeComponent();

            ComboStartStop.Text = ((Keys)(clickStartStopKey + 112)).ToString();
            ComboMousePos.Text = ((Keys)(clickMousePosKey + 112)).ToString();
            clickButton.hookedKeys.Add(Keys.F1);
            clickButton.hookedKeys.Add(Keys.F2);
            clickButton.KeyDown += new KeyEventHandler(KullanilanTuslar);

            player.URL = "Alarm.mp3";
            player.controls.stop();

            AddPos_Time();

            AddMacros();

            TextRepeat.Text = "24";

            ComboMacro.Text = "Gold";
            TextMacroRepeat.Text = "23";

            TextUretimLimitOdun1.Text = "5";
            TextUretimLimitOdun2.Text = "5";
            TextUretimLimitDemir.Text = "4";
            TextUretimLimitTas.Text = "4";
        }

        #region Genel
        private void AddPos_Time()
        {
            uretimTime[0] = 1800;
            uretimTime[1] = 1800;
            uretimTime[2] = 4200;
            uretimTime[3] = 3000;

            TextUretimOdun1X.Text = 924.ToString();
            TextUretimOdun1Y.Text = 429.ToString();
            TextUretimOdun2X.Text = 835.ToString();
            TextUretimOdun2Y.Text = 372.ToString();
            TextUretimDemirX.Text = 834.ToString();
            TextUretimDemirY.Text = 472.ToString();
            TextUretimTasX.Text = 744.ToString();
            TextUretimTasY.Text = 432.ToString();

            TextBalik1X.Text = 642.ToString();
            TextBalik1Y.Text = 608.ToString();
            TextBalik2X.Text = 551.ToString();
            TextBalik2Y.Text = 568.ToString();
            TextBalik3X.Text = 472.ToString();
            TextBalik3Y.Text = 524.ToString();
            TextBalik4X.Text = 396.ToString();
            TextBalik4Y.Text = 471.ToString();
            TextBalik5X.Text = 307.ToString();
            TextBalik5Y.Text = 431.ToString();
        }
        private void AddMacros()
        {
            // Gold
            AddMacro("Gold"
                , 472, 304, "Ödülü Al"
                , 498, 304, "Gemi Seç"
                , 529, 479, "Şehri Seç"
                , 908, 598, "Şehri Onayla");

            // Odun
            AddMacro("Odun"
                , 472, 304, "Ödülü Al"
                , 498, 304, "Gemi Seç"
                , 808, 356, "Şehri Seç"
                , 607, 595, "Şehri Onayla");

            // Demir
            AddMacro("Demir"
                , 472, 304, "Ödülü Al"
                , 498, 304, "Gemi Seç"
                , 672, 607, "Şehri Seç"
                , 472, 595, "Şehri Onayla");

            // Balik
            AddMacro("Balik"
                , 472, 304, "Ödülü Al"
                , 498, 304, "Gemi Seç"
                , 982, 561, "Şehri Seç"
                , 779, 598, "Şehri Onayla");

            // Tas
            AddMacro("Tas"
                , 472, 304, "Ödülü Al"
                , 498, 304, "Gemi Seç"
                , 583, 365, "Şehri Seç"
                , 967, 596, "Şehri Onayla");

            // Small Gold
            AddMacro("Small Gold"
                , 472, 304, "Ödülü Al"
                , 498, 304, "Gemi Seç"
                , 790, 557, "Şehri Seç"
                , 592, 597, "Şehri Onayla");
        }
        private void AddMacro(string gorevName
            , int act1KoorX, int act1KoorY, string act1Desc
            , int act2KoorX, int act2KoorY, string act2Desc
            , int act3KoorX, int act3KoorY, string act3Desc
            , int act4KoorX, int act4KoorY, string act4Desc)
        {
            // Gold
            Gorevler gorevim = new Gorevler();
            gorevim.gorevName = gorevName;
            ComboMacro.Items.Add(gorevim.gorevName);
            Actionlar action1 = new Actionlar();
            action1.koorX = act1KoorX;
            action1.koorY = act1KoorY;
            action1.actionTime = 1;
            action1.actionDesc = act1Desc;
            Actionlar action2 = new Actionlar();
            action2.koorX = act2KoorX;
            action2.koorY = act2KoorY;
            action2.actionTime = 1;
            action2.actionDesc = act2Desc;
            Actionlar action3 = new Actionlar();
            action3.koorX = act3KoorX;
            action3.koorY = act3KoorY;
            action3.actionTime = 1;
            action3.actionDesc = act3Desc;
            Actionlar action4 = new Actionlar();
            action4.koorX = act4KoorX;
            action4.koorY = act4KoorY;
            action4.actionTime = 1;
            action4.actionDesc = act4Desc;
            gorevim.actionlar.Add(action1);
            gorevim.actionlar.Add(action2);
            gorevim.actionlar.Add(action3);
            gorevim.actionlar.Add(action4);
            gorevler.Add(gorevim);
        }
        private int RakamAta(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int deger))
            {
                return deger;
            }
            else
            {
                MessageBox.Show("Lütfen rakam giriniz.");
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                return 0;
            }
        }
        private void RakamAtandi(TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out int deger))
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                MessageBox.Show("Lütfen rakam giriniz.");
            }
        }
        #endregion

        #region Dinlenecek Tuslar
        private void KullanilanTuslar(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode == (Keys)(clickStartStopKey + 112))
            {
                ScriptStart();
            }
            if (keyEventArgs.KeyCode == (Keys)(clickMousePosKey + 112))
            {
                mouseKoorX = Cursor.Position.X;
                mouseKoorY = Cursor.Position.Y;
                LabelMousePos.Text = mouseKoorX + " - " + mouseKoorY;
            }
        }
        private void ComboStartStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboStartStop.SelectedIndex != clickMousePosKey)
            {
                clickButton.hookedKeys.Remove((Keys)(clickStartStopKey + 112));
                clickStartStopKey = ComboStartStop.SelectedIndex;
                clickButton.hookedKeys.Add((Keys)(clickStartStopKey + 112));

            }
            else
            {
                ComboStartStop.Text = ((Keys)(clickStartStopKey + 112)).ToString();
                MessageBox.Show("You can't choose same F with Mouse Pos.");
            }
        }
        private void ComboMousePos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboMousePos.SelectedIndex != clickStartStopKey)
            {
                clickButton.hookedKeys.Remove((Keys)(clickMousePosKey + 112));
                clickMousePosKey = ComboMousePos.SelectedIndex;
                clickButton.hookedKeys.Add((Keys)(clickMousePosKey + 112));

            }
            else
            {
                ComboMousePos.Text = ((Keys)(clickMousePosKey + 112)).ToString();
                MessageBox.Show("You can't choose same F with Start-Stop.");
            }
        }
        #endregion

        #region Alarm
        private bool alarmStart;
        private int timeLocation;
        private int timeLocationNext;
        private int timeOdun;
        private int timeOdunNext;
        private int timeDemir;
        private int timeDemirNext;
        private int timeTas;
        private int timeTasNext;
        private int timeFish;
        private int timeFishNext;
        private void TextTimeLocation_TextChanged(object sender, EventArgs e)
        {
            timeLocation = RakamAta(TextTimeLocation);
        }
        private void TextTimeOdun_TextChanged(object sender, EventArgs e)
        {
            timeOdun = RakamAta(TextTimeOdun);
        }
        private void TextTimeDemir_TextChanged(object sender, EventArgs e)
        {
            timeDemir = RakamAta(TextTimeDemir);
        }
        private void TextTimeTas_TextChanged(object sender, EventArgs e)
        {
            timeTas = RakamAta(TextTimeTas);
        }
        private void TextTimeBalik_TextChanged(object sender, EventArgs e)
        {
            timeFish = RakamAta(TextTimeBalik);
        }
        private void CheckAlarmLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAlarmLocation.Checked)
            {
                timeLocationNext = 0;
            }
            else
            {
                AlarmKontrol();
            }
        }
        private void CheckAlarmOdun_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAlarmOdun.Checked)
            {
                timeOdunNext = 0;
            }
            else
            {
                AlarmKontrol();
            }
        }
        private void CheckAlarmDemir_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAlarmDemir.Checked)
            {
                timeDemirNext = 0;
            }
            else
            {
                AlarmKontrol();
            }
        }
        private void CheckAlarmTas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAlarmTas.Checked)
            {
                timeTasNext = 0;
            }
            else
            {
                AlarmKontrol();
            }
        }
        private void CheckAlarmBalik_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAlarmBalik.Checked)
            {
                timeFishNext = 0;
            }
            else
            {
                AlarmKontrol();
            }
        }
        private void ButtonAlarmKur_Click(object sender, EventArgs e)
        {
            AlarmTetiklendi();
        }
        private void TimerAlarm_Tick(object sender, EventArgs e)
        {
            if (CheckAlarmLocation.Checked)
            {
                timeLocationNext++;
                if (timeLocationNext >= timeLocation)
                {
                    AlarmResetle(ref timeLocationNext, ref CheckAlarmLocation);
                }
            }
            if (CheckAlarmOdun.Checked)
            {
                timeOdunNext++;
                if (timeOdunNext >= timeOdun)
                {
                    AlarmResetle(ref timeOdunNext, ref CheckAlarmOdun);
                }
            }
            if (CheckAlarmDemir.Checked)
            {
                timeDemirNext++;
                if (timeDemirNext >= timeDemir)
                {
                    AlarmResetle(ref timeDemirNext, ref CheckAlarmDemir);
                }
            }
            if (CheckAlarmTas.Checked)
            {
                timeTasNext++;
                if (timeTasNext >= timeTas)
                {
                    AlarmResetle(ref timeTasNext, ref CheckAlarmTas);
                }
            }
            if (CheckAlarmBalik.Checked)
            {
                timeFishNext++;
                if (timeFishNext >= timeFish)
                {
                    AlarmResetle(ref timeFishNext, ref CheckAlarmBalik);
                }
            }
            AlarmKontrol();
        }
        private void AlarmResetle(ref int rakam, ref CheckBox check)
        {
            rakam = 0;
            check.Checked = false;
            player.controls.play();
        }
        private void AlarmTetiklendi()
        {
            alarmStart = !alarmStart;
            if (alarmStart)
            {
                ButtonAlarmKur.Enabled = false;
                TimerAlarm.Start();
            }
            else
            {
                ButtonAlarmKur.Enabled = true;
                TimerAlarm.Stop();
            }
        }
        private void AlarmKontrol()
        {
            if (!CheckAlarmLocation.Checked ||
                !CheckAlarmOdun.Checked ||
                !CheckAlarmDemir.Checked ||
                !CheckAlarmTas.Checked ||
                !CheckAlarmBalik.Checked)
            {
                AlarmTetiklendi();
            }
        }
        #endregion

        #region Balik Pozisyonlari
        private List<int> balikPos = new List<int>()
        { 0,1,2,3,4,5,6,7,8,9};
        private void TextBalik1X_TextChanged(object sender, EventArgs e)
        {
            balikPos[0] = RakamAta(TextBalik1X);
        }
        private void TextBalik1Y_TextChanged(object sender, EventArgs e)
        {
            balikPos[1] = RakamAta(TextBalik1Y);
        }
        private void TextBalik2X_TextChanged(object sender, EventArgs e)
        {
            balikPos[2] = RakamAta(TextBalik2X);
        }
        private void TextBalik2Y_TextChanged(object sender, EventArgs e)
        {
            balikPos[3] = RakamAta(TextBalik2Y);
        }
        private void TextBalik3X_TextChanged(object sender, EventArgs e)
        {
            balikPos[4] = RakamAta(TextBalik3X);
        }
        private void TextBalik3Y_TextChanged(object sender, EventArgs e)
        {
            balikPos[5] = RakamAta(TextBalik3Y);
        }
        private void TextBalik4X_TextChanged(object sender, EventArgs e)
        {
            balikPos[6] = RakamAta(TextBalik4X);
        }
        private void TextBalik4Y_TextChanged(object sender, EventArgs e)
        {
            balikPos[7] = RakamAta(TextBalik4Y);
        }
        private void TextBalik5X_TextChanged(object sender, EventArgs e)
        {
            balikPos[8] = RakamAta(TextBalik5X);
        }
        private void TextBalik5Y_TextChanged(object sender, EventArgs e)
        {
            balikPos[9] = RakamAta(TextBalik5Y);
        }
        #endregion

        #region Uretim Pozisyonlari
        private List<int> uretimTime = new List<int>()
        { 0,0,0,0};
        private List<int> uretimPos = new List<int>()
        { 0,0,0,0,0,0,0,0};

        private void TextUretimOdun1X_TextChanged(object sender, EventArgs e)
        {
            uretimPos[0] = RakamAta(TextUretimOdun1X);
        }
        private void TextUretimOdun1Y_TextChanged(object sender, EventArgs e)
        {
            uretimPos[1] = RakamAta(TextUretimOdun1Y);
        }
        private void TextUretimOdun2X_TextChanged(object sender, EventArgs e)
        {
            uretimPos[2] = RakamAta(TextUretimOdun2X);
        }
        private void TextUretimOdun2Y_TextChanged(object sender, EventArgs e)
        {
            uretimPos[3] = RakamAta(TextUretimOdun2Y);
        }
        private void TextUretimDemirX_TextChanged(object sender, EventArgs e)
        {
            uretimPos[4] = RakamAta(TextUretimDemirX);
        }
        private void TextUretimDemirY_TextChanged(object sender, EventArgs e)
        {
            uretimPos[5] = RakamAta(TextUretimDemirY);
        }
        private void TextUretimTasX_TextChanged(object sender, EventArgs e)
        {
            uretimPos[6] = RakamAta(TextUretimTasX);
        }
        private void TextUretimTasY_TextChanged(object sender, EventArgs e)
        {
            uretimPos[7] = RakamAta(TextUretimTasY);
        }
        private void TextUretimTimeOdun1_TextChanged(object sender, EventArgs e)
        {
            uretimTime[0] = RakamAta(TextUretimTimeOdun1);
        }
        private void TextUretimTimeOdun2_TextChanged(object sender, EventArgs e)
        {
            uretimTime[1] = RakamAta(TextUretimTimeOdun2);
        }
        private void TextUretimTimeDemir_TextChanged(object sender, EventArgs e)
        {
            uretimTime[2] = RakamAta(TextUretimTimeDemir);
        }
        private void TextUretimTimeTas_TextChanged(object sender, EventArgs e)
        {
            uretimTime[3] = RakamAta(TextUretimTimeTas);
        }
        #endregion

        #region Gorevler
        public class Actionlar
        {
            public int koorX;
            public int koorY;
            public int actionTime;
            public string actionMouse;
            public string actionDesc;
        }
        public class Gorevler
        {
            public string gorevName;
            public int gorevRepeat;
            public List<Actionlar> actionlar = new List<Actionlar>();
        }

        private List<Gorevler> gorevler = new List<Gorevler>();

        private void ButtonGrupEkle_Click(object sender, EventArgs h)
        {
            Gorevler gorev = GorevOlustur();
            ComboMacro.Items.Add(gorev.gorevName);
            gorevler.Add(gorev);
        }
        private void ButtonGrupSil_Click(object sender, EventArgs h)
        {
            if (gorevler.Count > 0)
            {
                for (int e = gorevler.Count - 1; e >= 0; e--)
                {
                    if (gorevler[e].gorevName == TextGrupName.Text)
                    {
                        ComboMacro.Items.RemoveAt(e);
                        ComboMacro.Text = "";

                        gorevler.RemoveAt(e);

                        TextGrupName.Text = "";
                        TextKoorX.Text = "0";
                        TextKoorY.Text = "0";
                        TextWaitTime.Text = "0";
                        TextActionDesc.Text = "";

                        ListGrupActions.Items.Clear();

                        break;
                    }
                }
            }
        }
        private void ButtonGrupUpdate_Click(object sender, EventArgs h)
        {
            if (gorevler.Count > 0)
            {
                for (int e = gorevler.Count - 1; e >= 0; e--)
                {
                    if (gorevler[e].gorevName == TextGrupName.Text)
                    {
                        gorevler[e] = GorevOlustur();

                        break;
                    }
                }
            }
        }
        private Gorevler GorevOlustur()
        {
            Gorevler gorev = new Gorevler();
            gorev.gorevName = TextGrupName.Text;
            for (int e = 0; e < ListGrupActions.Items.Count; e++)
            {
                Actionlar action = new Actionlar();
                action.koorX = int.Parse(ListGrupActions.Items[e].SubItems[1].Text);
                action.koorY = int.Parse(ListGrupActions.Items[e].SubItems[2].Text);
                action.actionTime = int.Parse(ListGrupActions.Items[e].SubItems[3].Text);
                action.actionDesc = ListGrupActions.Items[e].SubItems[4].Text;
                gorev.actionlar.Add(action);
            }
            return gorev;
        }
        #endregion

        #region Button Actions
        private void TextKoorX_TextChanged(object sender, EventArgs e)
        {
            RakamAtandi(TextKoorX);
        }
        private void TextKoorY_TextChanged(object sender, EventArgs e)
        {
            RakamAtandi(TextKoorY);
        }
        private void ButtonKoordinat_Click(object sender, EventArgs e)
        {
            TextKoorX.Text = mouseKoorX.ToString();
            TextKoorY.Text = mouseKoorY.ToString();
        }
        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            bool isSelected = false;
            for (int h = 0; h < ListGrupActions.Items.Count && !isSelected; h++)
            {
                if (ListGrupActions.Items[h].Selected)
                {
                    TextKoorX.Text = ListGrupActions.Items[h].SubItems[1].Text;
                    TextKoorY.Text = ListGrupActions.Items[h].SubItems[2].Text;
                    TextWaitTime.Text = ListGrupActions.Items[h].SubItems[3].Text;
                    TextActionDesc.Text = ListGrupActions.Items[h].SubItems[4].Text;
                    isSelected = true;
                }
            }
        }
        private void ButtonActionEkle_Click(object sender, EventArgs e)
        {
            ListGrupActions.Items.Add(ListViewItemOlustur());
        }
        private void ButtonActionSil_Click(object sender, EventArgs e)
        {
            for (int c = ListGrupActions.Items.Count - 1; c >= 0; c--)
            {
                if (ListGrupActions.Items[c].Selected)
                {
                    ListGrupActions.Items.RemoveAt(c);
                }
            }
            for (int c = 0; c < ListGrupActions.Items.Count; c++)
            {
                ListGrupActions.Items[c].SubItems[0].Text = c.ToString();
            }
        }
        private void ButtonActionUpdate_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < ListGrupActions.Items.Count; c++)
            {
                if (ListGrupActions.Items[c].Selected)
                {
                    ListViewItem listViewItem = ListViewItemOlustur();
                    listViewItem.SubItems[0].Text = c.ToString();
                    ListGrupActions.Items[c] = listViewItem;
                }
            }
        }
        private void ButtonActionUp_Click(object sender, EventArgs e)
        {
            for (int h = ListGrupActions.Items.Count - 1; h >= 0; h--)
            {
                if (ListGrupActions.Items[h].Selected)
                {
                    if (h != ListGrupActions.Items.Count - 1)
                    {
                        string aktarim = "";
                        for (int c = 1; c < ListGrupActions.Items[h + 1].SubItems.Count; c++)
                        {
                            aktarim = ListGrupActions.Items[h + 1].SubItems[c].Text;

                            ListGrupActions.Items[h + 1].SubItems[c].Text =
                                                        ListGrupActions.Items[h].SubItems[c].Text;

                            ListGrupActions.Items[h].SubItems[c].Text = aktarim;
                        }
                    }
                }
            }
        }
        private void ButtonActionDown_Click(object sender, EventArgs e)
        {
            for (int h = 0; h < ListGrupActions.Items.Count; h++)
            {
                if (ListGrupActions.Items[h].Selected)
                {
                    if (h != 0)
                    {
                        string aktarim = "";
                        for (int c = 1; c < ListGrupActions.Items[h - 1].SubItems.Count; c++)
                        {
                            aktarim = ListGrupActions.Items[h - 1].SubItems[c].Text;

                            ListGrupActions.Items[h - 1].SubItems[c].Text =
                                                        ListGrupActions.Items[h].SubItems[c].Text;

                            ListGrupActions.Items[h].SubItems[c].Text = aktarim;
                        }
                    }
                }
            }
        }
        private ListViewItem ListViewItemOlustur()
        {
            string[] action = { ListGrupActions.Items.Count.ToString(),
                                    TextKoorX.Text, TextKoorY.Text,
                                    TextWaitTime.Text,
                                    TextActionDesc.Text};
            return new ListViewItem(action);
        }
        #endregion

        #region Macro
        private void ButtonMacroEkle_Click(object sender, EventArgs e)
        {
            if (ComboMacro.Text != "")
            {
                string[] gorev = { ListMacro.Items.Count.ToString(),
                                    RakamAta(TextMacroRepeat).ToString()
                                    , ComboMacro.Text};
                ListMacro.Items.Add(new ListViewItem(gorev));
            }
        }
        private void ButtonMacroSil_Click(object sender, EventArgs h)
        {
            for (int e = ListMacro.Items.Count - 1; e >= 0; e--)
            {
                if (ListMacro.Items[e].Selected)
                {
                    ListMacro.Items.RemoveAt(e);
                }
            }
            for (int c = 0; c < ListMacro.Items.Count; c++)
            {
                ListMacro.Items[c].SubItems[0].Text = c.ToString();
            }
        }
        private void TextMacroRepeat_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TextMacroRepeat.Text, out int deger))
            {
                MessageBox.Show("Lütfen rakam giriniz.");
            }
        }
        #endregion

        #region Script Start
        private bool scriptStart;
        private bool scriptBitti;
        private int repeat = 1;
        private int repeatNext;
        private int fishTopla = 300;
        private int fishToplaNext;
        private int location = 3600;
        private int locationNext;
        private int betonTopla = 600;
        private int betonNext;
        private int petrolTopla = 600;
        private int petrolNext;
        private int odun1;
        private int odun2;
        private int demir;
        private int tas;

        private void TextRepeat_TextChanged(object sender, EventArgs e)
        {
            repeat = RakamAta(TextRepeat);
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (!CheckMacroUretim.Checked && !CheckMacroBalik.Checked &&
                (!CheckMacroLocation.Checked ||
                (CheckMacroLocation.Checked && ListMacro.Items.Count == 0)))
            {
                return;
            }
            ScriptStart();
        }
        private void TimerKontrol_Tick(object sender, EventArgs e)
        {
            if (CheckMacroLocation.Checked)
            {
                locationNext++;
                int saniye = (location - locationNext) % 60;
                int dakika = (location - locationNext) / 60;
                TextPassingTime.Text = "" + dakika + " : " + saniye;
            }
            if (CheckMacroUretim.Checked)
            {
                if (CheckUretimOdun1.Checked)
                {
                    odun1++;
                }
                if (CheckUretimOdun2.Checked)
                {
                    odun2++;
                }
                if (CheckUretimDemir.Checked)
                {
                    demir++;
                }
                if (CheckUretimTas.Checked)
                {
                    tas++;
                }
            }
            if (CheckMacroBalik.Checked)
            {
                fishToplaNext++;
            }
            if (CheckMacroPetrol.Checked)
            {
                petrolNext++;
            }
            if (CheckMacroBeton.Checked)
            {
                betonNext++;
            }
            ScriptKontrol();
        }
        private void ScriptKontrol()
        {
            Point clickPoint = new Point();
            if (locationNext >= location)
            {
                locationNext = 0;
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);
                // Makromuzda birşeyler var
                if (ListMacro.Items.Count > 0)
                {
                    // Haritaya geç
                    clickPoint.X = 1185;
                    clickPoint.Y = 668;

                    clickButton.LeftDownClick(clickPoint);
                    Thread.Sleep(1000);
                    clickButton.LeftClickRelease();
                    Thread.Sleep(2000);

                    // Gemi Listesini aç
                    clickPoint.X = 142;
                    clickPoint.Y = 664;

                    clickButton.LeftDownClick(clickPoint);
                    Thread.Sleep(1000);
                    clickButton.LeftClickRelease();
                    Thread.Sleep(2000);

                    // Macroyu kontrol et
                    for (int e = 0; e < ListMacro.Items.Count; e++)
                    {
                        Gorevler gorevim = new Gorevler();
                        bool goreviBuldum = false;
                        for (int h = 0; h < gorevler.Count && !goreviBuldum; h++)
                        {
                            if (ListMacro.Items[e].SubItems[2].Text == gorevler[h].gorevName)
                            {
                                gorevim = gorevler[h];
                                goreviBuldum = true;
                            }
                        }
                        int gorevRepeat = int.Parse(ListMacro.Items[e].SubItems[1].Text);
                        for (int c = 0; c < gorevRepeat; c++)
                        {
                            for (int h = 0; h < gorevim.actionlar.Count; h++)
                            {
                                clickPoint.X = gorevim.actionlar[h].koorX;
                                clickPoint.Y = gorevim.actionlar[h].koorY;

                                clickButton.LeftDownClick(clickPoint);
                                Thread.Sleep(1000);
                                clickButton.LeftClickRelease();
                                Thread.Sleep(gorevim.actionlar[h].actionTime * 1000);
                            }
                        }
                    }
                    // Şehre geç
                    clickPoint.X = 1185;
                    clickPoint.Y = 668;

                    clickButton.LeftDownClick(clickPoint);
                    Thread.Sleep(1000);
                    clickButton.LeftClickRelease();
                    Thread.Sleep(2000);
                }
                repeatNext--;
                TextLastRepeat.Text = repeatNext.ToString();
                if (repeatNext < 0)
                {
                    scriptBitti = true;
                }
            }
            else if (petrolNext >= petrolTopla)
            {
                petrolNext = 0;
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);
                // Bina Sec
                clickPoint.X = 645;
                clickPoint.Y = 395;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(3000);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Petrol Topla
                clickPoint.X = 880;
                clickPoint.Y = 590;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(3000);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Petrol Tut
                clickPoint.X = 135;
                clickPoint.Y = 325;
                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(1000);

                // Petrol Kaydir
                clickPoint.X = 660;
                clickPoint.Y = 365;
                clickButton.MouseMoving(clickPoint);
                Thread.Sleep(1000);
                clickButton.LeftUpClick(clickPoint);
                Thread.Sleep(1000);

                // Kapat
                clickPoint.X = 1230;
                clickPoint.Y = 80;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(3000);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);
            }
            else if (betonNext >= betonTopla)
            {
                betonNext = 0;
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);
                // Bina Sec
                clickPoint.X = 645;
                clickPoint.Y = 395;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(3000);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Beton Topla
                clickPoint.X = 880;
                clickPoint.Y = 590;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(3000);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Beton Tut
                clickPoint.X = 135;
                clickPoint.Y = 500;
                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(1000);

                // Beton Kaydir
                clickPoint.X = 660;
                clickPoint.Y = 365;
                clickButton.MouseMoving(clickPoint);
                Thread.Sleep(1000);
                clickButton.LeftUpClick(clickPoint);
                Thread.Sleep(1000);

                // Kapat
                clickPoint.X = 1230;
                clickPoint.Y = 80;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(3000);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);
            }
            else if (odun1 >= uretimTime[0])
            {
                odun1 = 0;
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);
                // Odun topla
                clickPoint.X = uretimPos[0];
                clickPoint.Y = uretimPos[1];

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Baligi Tut
                clickPoint.X = uretimPos[0] - 150;
                clickPoint.Y = uretimPos[1] - 10;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(1000);

                // Baligi Kaydir
                clickPoint.X = uretimPos[0];
                clickPoint.Y = uretimPos[1];

                if (!CheckUretimLimitsizOdun1.Checked)
                {
                    if (TextUretimLimitOdun1.Text != "0")
                    {
                        int deger = 0;
                        if (int.TryParse(TextUretimLimitOdun1.Text, out deger))
                        {
                            deger--;
                            TextUretimLimitOdun1.Text = deger.ToString();
                        }
                    }
                    else
                    {
                        CheckUretimOdun1.Checked = false;
                        KontrolUretimDurum();
                    }
                }

                clickButton.MouseMoving(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftUpClick(clickPoint);
                Thread.Sleep(1000);
            }
            else if (odun2 >= uretimTime[1])
            {
                odun2 = 0;
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);
                // Odun topla
                clickPoint.X = uretimPos[2];
                clickPoint.Y = uretimPos[3];

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Baligi Tut
                clickPoint.X = uretimPos[2] - 150;
                clickPoint.Y = uretimPos[3] - 10;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(1000);

                // Baligi Kaydir
                clickPoint.X = uretimPos[2];
                clickPoint.Y = uretimPos[3];

                if (!CheckUretimLimitsizOdun2.Checked)
                {
                    if (TextUretimLimitOdun2.Text != "0")
                    {
                        int deger = 0;
                        if (int.TryParse(TextUretimLimitOdun2.Text, out deger))
                        {
                            deger--;
                            TextUretimLimitOdun2.Text = deger.ToString();
                        }
                    }
                    else
                    {
                        CheckUretimOdun2.Checked = false;
                        KontrolUretimDurum();
                    }
                }

                clickButton.MouseMoving(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftUpClick(clickPoint);
                Thread.Sleep(1000);
            }
            else if (demir >= uretimTime[2])
            {
                demir = 0;
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);
                // Demir topla
                clickPoint.X = uretimPos[4];
                clickPoint.Y = uretimPos[5];

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Baligi Tut
                clickPoint.X = uretimPos[4] - 150;
                clickPoint.Y = uretimPos[5] - 10;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(1000);

                // Baligi Kaydir
                clickPoint.X = uretimPos[4];
                clickPoint.Y = uretimPos[5];

                if (!CheckUretimLimitsizDemir.Checked)
                {
                    if (TextUretimLimitDemir.Text != "0")
                    {
                        int deger = 0;
                        if (int.TryParse(TextUretimLimitDemir.Text, out deger))
                        {
                            deger--;
                            TextUretimLimitDemir.Text = deger.ToString();
                        }
                    }
                    else
                    {
                        CheckUretimDemir.Checked = false;
                        KontrolUretimDurum();
                    }
                }

                clickButton.MouseMoving(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftUpClick(clickPoint);
                Thread.Sleep(1000);
            }
            else if (tas >= uretimTime[3])
            {
                tas = 0;
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);
                // Tas topla
                clickPoint.X = uretimPos[6]; // 565
                clickPoint.Y = uretimPos[7]; // 210;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Baligi Tut
                clickPoint.X = uretimPos[6] - 150; // 440
                clickPoint.Y = uretimPos[7] - 10; // 190;

                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(1000);

                // Baligi Kaydir
                clickPoint.X = uretimPos[6]; // 565
                clickPoint.Y = uretimPos[7]; // 210;

                if (!CheckUretimLimitsizTas.Checked)
                {
                    if (TextUretimLimitTas.Text != "0")
                    {
                        int deger = 0;
                        if (int.TryParse(TextUretimLimitTas.Text, out deger))
                        {
                            deger--;
                            TextUretimLimitTas.Text = deger.ToString();
                        }
                    }
                    else
                    {
                        CheckUretimTas.Checked = false;
                        KontrolUretimDurum();
                    }
                }

                clickButton.MouseMoving(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftUpClick(clickPoint);
                Thread.Sleep(1000);
            }
            else if (fishToplaNext >= fishTopla)
            {
                fishToplaNext = 0;
                // Fish - 1
                clickPoint.X = balikPos[0];
                clickPoint.Y = balikPos[1];
                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Fish - 2
                clickPoint.X = balikPos[2];
                clickPoint.Y = balikPos[3];
                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Fish - 3
                clickPoint.X = balikPos[4];
                clickPoint.Y = balikPos[5];
                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Fish - 4
                clickPoint.X = balikPos[6];
                clickPoint.Y = balikPos[7];
                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);

                // Fish - 5
                clickPoint.X = balikPos[8];
                clickPoint.Y = balikPos[9];
                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(100);
                clickButton.LeftClickRelease();
                Thread.Sleep(1000);
            }
            else if (scriptBitti)
            {
                // Script Bitti
                scriptBitti = false;
                repeatNext = repeat - 1;
                ScriptStart();
            }
        }
        private void KontrolUretimDurum()
        {
            if (!CheckUretimOdun1.Checked &&
                !CheckUretimOdun2.Checked &&
                !CheckUretimDemir.Checked &&
                !CheckUretimTas.Checked)
            {
                CheckMacroUretim.Checked = false;
            }
        }
        private void ScriptStart()
        {
            TextRepeat.Enabled = scriptStart;
            ButtonMacroEkle.Enabled = scriptStart;
            ButtonMacroSil.Enabled = scriptStart;
            TabGorevOlustur.Enabled = scriptStart;
            CheckHemenLocation.Enabled = scriptStart;
            CheckHemenOdun1.Enabled = scriptStart;
            CheckHemenOdun2.Enabled = scriptStart;
            CheckHemenDemir.Enabled = scriptStart;
            CheckHemenTas.Enabled = scriptStart;

            TextPassingTime.Text = "";

            scriptStart = !scriptStart;
            if (scriptStart)
            {
                //location = 0;
                //for (int e = 0; e < ListMacro.Items.Count; e++)
                //{
                //    location += RakamAta(ListMacro.Items[e].SubItems[1].Text);
                //}
                if (ComboMacro.Text == "Small Gold")
                {
                    location = 300;
                }
                else
                {
                    location = 3600;
                }

                TextScriptTime.Text = location.ToString();
                if (CheckHemenLocation.Checked)
                {
                    locationNext = location;
                    CheckHemenLocation.Checked = false;
                }
                else
                {
                    locationNext = 0;
                }
                if (CheckHemenOdun1.Checked)
                {
                    odun1 = uretimTime[0];
                    CheckHemenOdun1.Checked = false;
                }
                else
                {
                    odun1 = 0;
                }
                if (CheckHemenOdun2.Checked)
                {
                    odun2 = uretimTime[1];
                    CheckHemenOdun2.Checked = false;
                }
                else
                {
                    odun2 = 0;
                }
                if (CheckHemenDemir.Checked)
                {
                    demir = uretimTime[2];
                    CheckHemenDemir.Checked = false;
                }
                else
                {
                    demir = 0;
                }
                if (CheckHemenTas.Checked)
                {
                    tas = uretimTime[3];
                    CheckHemenTas.Checked = false;
                }
                else
                {
                    tas = 0;
                }

                fishToplaNext = 0;
                repeatNext = repeat - 1;
                TimerKontrol.Start();
            }
            else
            {
                scriptBitti = false;
                TimerKontrol.Stop();
            }
        }
        #endregion

        #region Kargo icin Gemi Hesapla
        private int kargo = 1;
        private int kargoLimit = 3520;
        private int kargoOran = 4;
        private int hesaplamalarX;
        private int hesaplamalarY;
        private int hesaplamalarZ;
        private List<int> kapasiteler = new List<int>();
        private List<int> bestKapasiteler = new List<int>();
        private List<int> yedek = new List<int>();
        private List<int> bestyedek = new List<int>();

        private List<int> kargolar = new List<int>();

        private void TextKargoLimit_TextChanged(object sender, EventArgs e)
        {
            kargo = RakamAta(TextKargoLimit);
        }
        private void ButtonKargoLimitEkle_Click(object sender, EventArgs e)
        {
            KargoEkle(kargo);
        }
        private void KargoEkle(int kargom)
        {
            kargolar.Add(kargom);
            // Kargoları sırala
            kargolar.Sort(GemiSirala);
            // Kargo listesini düzenle
            KargoListesiniDoldur();
        }
        private int GemiSirala(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (a > b)
            {
                return -1;
            }
            return 0;
        }
        private void ButtonKargoLimitSil_Click(object sender, EventArgs e)
        {
            kargolar.Remove(kargo);
            KargoListesiniDoldur();
        }
        private void KargoListesiniDoldur()
        {
            ListGemiKargolar.Items.Clear();
            for (int h = 0; h < kargolar.Count; h++)
            {
                string[] gorev = { (h + 1).ToString(), kargolar[h].ToString() };
                ListGemiKargolar.Items.Add(new ListViewItem(gorev));
            }
        }
        private void TextGonderilecekKargoLimit_TextChanged(object sender, EventArgs e)
        {
            kargoLimit = RakamAta(TextGonderilecekKargoLimit);
        }
        private void TextGonderilecekKargoOran_TextChanged(object sender, EventArgs e)
        {
            kargoOran = RakamAta(TextGonderilecekKargoOran);
        }
        private void ButtonHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }
        public void Hesapla()
        {
            hesaplamalarX = (int)Math.Ceiling(kargoLimit * 1.0f / kargoOran);
            hesaplamalarY = 0;
            hesaplamalarZ = hesaplamalarX;
            MessageBox.Show(hesaplamalarX.ToString() + "--" + kargoLimit + "--" + kargoOran);
            bool bulduk = false;
            bool bulduk2 = false;
            bool farkCok = false;
            bool bestYedek = false;
            int fark = 0;
            for (int e = 0; e < kargolar.Count && !bulduk; e++)
            {
                kapasiteler.Add(e);
                hesaplamalarY += kargolar[e];
                fark = hesaplamalarY - hesaplamalarX;
                if (fark > 0)
                {
                    if (fark <= 30)
                    {
                        bulduk = true;
                        GemiAciklama(0);
                    }
                    else
                    {
                        if (hesaplamalarZ > fark)
                        {
                            hesaplamalarZ = fark;
                            bestKapasiteler.Clear();
                            for (int h = 0; h < kapasiteler.Count; h++)
                            {
                                bestKapasiteler.Add(kapasiteler[h]);
                            }
                        }
                        hesaplamalarY -= kargolar[e];
                        kapasiteler.RemoveAt(kapasiteler.Count - 1);
                    }
                }
            }
            if (!bulduk)
            {
                yedek.Clear();
                bulduk = false;
                bulduk2 = false;
                fark = 0;
                hesaplamalarY = 0;
                for (int e = 0; e < kargolar.Count && !bulduk; e++)
                {
                    yedek.Add(e);
                    hesaplamalarY += kargolar[e];
                    fark = hesaplamalarY - hesaplamalarX;
                    if (fark > 0)
                    {
                        bulduk = true;
                        if (fark > 30)
                        {
                            farkCok = true;
                        }
                    }
                }
                if (farkCok)
                {
                    hesaplamalarY -= kargolar[yedek.Count - 1];
                    yedek.RemoveAt(yedek.Count - 1);
                    if (yedek.Count >= 1)
                    {
                        hesaplamalarY -= kargolar[yedek.Count - 1];
                        yedek.RemoveAt(yedek.Count - 1);
                    }
                }
                for (int e = yedek.Count; e < kargolar.Count - 1 && !bulduk2; e++)
                {
                    hesaplamalarY += kargolar[e];
                    yedek.Add(e);
                    for (int i = e + 1; i < kargolar.Count && !bulduk2; i++)
                    {
                        hesaplamalarY += kargolar[i];
                        yedek.Add(i);
                        fark = hesaplamalarY - hesaplamalarX;
                        if (fark > 0)
                        {
                            if (fark <= 30)
                            {
                                bulduk2 = true;
                                GemiAciklama(1);
                            }
                            else
                            {
                                if (hesaplamalarZ > fark)
                                {
                                    hesaplamalarZ = fark;
                                    bestyedek.Clear();
                                    for (int h = 0; h < yedek.Count; h++)
                                    {
                                        bestyedek.Add(yedek[h]);
                                    }
                                    bestYedek = true;
                                }
                                hesaplamalarY -= kargolar[i];
                                yedek.RemoveAt(yedek.Count - 1);
                            }
                        }
                    }
                    if (!bulduk2)
                    {
                        hesaplamalarY -= kargolar[yedek.Count - 1];
                        yedek.RemoveAt(yedek.Count - 1);
                    }
                }
                if (!bulduk2)
                {
                    if (bestYedek)
                    {
                        GemiAciklama(2);
                    }
                    else
                    {
                        GemiAciklama(3);
                    }
                }
            }
        }
        private void GemiAciklama(int tip)
        {
            if (tip == 0)
            {
                LabelGemiAciklama.Text = "Kapasitelerde bulduk";
                ListGonderilecekGemiler.Items.Clear();
                for (int e = 0; e < kapasiteler.Count; e++)
                {
                    string[] gorev = { e.ToString(), kargolar[kapasiteler[e]].ToString() };
                    ListGonderilecekGemiler.Items.Add(new ListViewItem(gorev));
                }
                kapasiteler.Clear();
            }
            else if (tip == 1)
            {
                LabelGemiAciklama.Text = "Yedeklerde bulduk";
                ListGonderilecekGemiler.Items.Clear();
                for (int e = 0; e < yedek.Count; e++)
                {
                    string[] gorev = { e.ToString(), kargolar[yedek[e]].ToString() };
                    ListGonderilecekGemiler.Items.Add(new ListViewItem(gorev));
                }
                yedek.Clear();
            }
            else if (tip == 2)
            {
                LabelGemiAciklama.Text = "Best Yedekte bulduk";
                ListGonderilecekGemiler.Items.Clear();
                for (int e = 0; e < bestyedek.Count; e++)
                {
                    string[] gorev = { e.ToString(), kargolar[bestyedek[e]].ToString() };
                    ListGonderilecekGemiler.Items.Add(new ListViewItem(gorev));
                }
                bestyedek.Clear();
            }
            else if (tip == 3)
            {
                LabelGemiAciklama.Text = "Best Kapasitelerde bulduk";
                ListGonderilecekGemiler.Items.Clear();
                for (int e = 0; e < bestKapasiteler.Count; e++)
                {
                    string[] gorev = { e.ToString(), kargolar[bestKapasiteler[e]].ToString() };
                    ListGonderilecekGemiler.Items.Add(new ListViewItem(gorev));
                }
                bestKapasiteler.Clear();
            }
        }
        #endregion
    }
}