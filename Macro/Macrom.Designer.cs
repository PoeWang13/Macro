namespace Macro
{
    partial class Macrom
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuPanel = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAlarmKur = new System.Windows.Forms.Button();
            this.TextTimeBalik = new System.Windows.Forms.TextBox();
            this.TextTimeTas = new System.Windows.Forms.TextBox();
            this.TextTimeDemir = new System.Windows.Forms.TextBox();
            this.TextTimeOdun = new System.Windows.Forms.TextBox();
            this.CheckAlarmBalik = new System.Windows.Forms.CheckBox();
            this.CheckAlarmTas = new System.Windows.Forms.CheckBox();
            this.CheckAlarmDemir = new System.Windows.Forms.CheckBox();
            this.CheckAlarmOdun = new System.Windows.Forms.CheckBox();
            this.CheckAlarmLocation = new System.Windows.Forms.CheckBox();
            this.TextTimeLocation = new System.Windows.Forms.TextBox();
            this.NeedShip = new System.Windows.Forms.TabPage();
            this.LabelGemiAciklama = new System.Windows.Forms.Label();
            this.ButtonHesapla = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextGonderilecekKargoOran = new System.Windows.Forms.TextBox();
            this.TextGonderilecekKargoLimit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ListGonderilecekGemiler = new System.Windows.Forms.ListView();
            this.ColumnGonderilecekSira = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnGonderilecekKargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.ListGemiKargolar = new System.Windows.Forms.ListView();
            this.ColumnSira = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnKargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonKargoLimitSil = new System.Windows.Forms.Button();
            this.ButtonKargoLimitEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TextKargoLimit = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ComboMousePos = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.ComboStartStop = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.LabelMousePos = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.TextRepeat = new System.Windows.Forms.TextBox();
            this.TimerAlarm = new System.Windows.Forms.Timer(this.components);
            this.TimerKontrol = new System.Windows.Forms.Timer(this.components);
            this.GenelMenu = new System.Windows.Forms.TabControl();
            this.Macro = new System.Windows.Forms.TabPage();
            this.TabMacro = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.CheckMacroPetrol = new System.Windows.Forms.CheckBox();
            this.CheckMacroBeton = new System.Windows.Forms.CheckBox();
            this.TextScriptTime = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TextPassingTime = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TextLastRepeat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CheckHemenTas = new System.Windows.Forms.CheckBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.CheckHemenDemir = new System.Windows.Forms.CheckBox();
            this.ListMacro = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonMacroSil = new System.Windows.Forms.Button();
            this.CheckHemenOdun2 = new System.Windows.Forms.CheckBox();
            this.ButtonMacroEkle = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.CheckHemenOdun1 = new System.Windows.Forms.CheckBox();
            this.TextMacroRepeat = new System.Windows.Forms.TextBox();
            this.ComboMacro = new System.Windows.Forms.ComboBox();
            this.CheckHemenLocation = new System.Windows.Forms.CheckBox();
            this.CheckMacroBalik = new System.Windows.Forms.CheckBox();
            this.CheckMacroLocation = new System.Windows.Forms.CheckBox();
            this.CheckMacroUretim = new System.Windows.Forms.CheckBox();
            this.TabGorevOlustur = new System.Windows.Forms.TabPage();
            this.ButtonInfo = new System.Windows.Forms.Button();
            this.ButtonKoordinat = new System.Windows.Forms.Button();
            this.ButtonGrupUpdate = new System.Windows.Forms.Button();
            this.ButtonActionUpdate = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.ButtonGrupSil = new System.Windows.Forms.Button();
            this.ButtonGrupEkle = new System.Windows.Forms.Button();
            this.ButtonActionUp = new System.Windows.Forms.Button();
            this.ButtonActionDown = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.ButtonActionSil = new System.Windows.Forms.Button();
            this.ListGrupActions = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TextWaitTime = new System.Windows.Forms.TextBox();
            this.ButtonActionEkle = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.TextActionDesc = new System.Windows.Forms.TextBox();
            this.TextKoorY = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.TextKoorX = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.TextGrupName = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.CheckUretimLimitsizTas = new System.Windows.Forms.CheckBox();
            this.CheckUretimLimitsizDemir = new System.Windows.Forms.CheckBox();
            this.CheckUretimLimitsizOdun2 = new System.Windows.Forms.CheckBox();
            this.CheckUretimLimitsizOdun1 = new System.Windows.Forms.CheckBox();
            this.label53 = new System.Windows.Forms.Label();
            this.TextUretimLimitTas = new System.Windows.Forms.TextBox();
            this.TextUretimLimitDemir = new System.Windows.Forms.TextBox();
            this.TextUretimLimitOdun2 = new System.Windows.Forms.TextBox();
            this.TextUretimLimitOdun1 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.TextUretimTimeTas = new System.Windows.Forms.TextBox();
            this.TextUretimTimeDemir = new System.Windows.Forms.TextBox();
            this.TextUretimTimeOdun2 = new System.Windows.Forms.TextBox();
            this.TextUretimTimeOdun1 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.TextUretimTasY = new System.Windows.Forms.TextBox();
            this.TextUretimTasX = new System.Windows.Forms.TextBox();
            this.TextUretimDemirY = new System.Windows.Forms.TextBox();
            this.TextUretimDemirX = new System.Windows.Forms.TextBox();
            this.TextUretimOdun2Y = new System.Windows.Forms.TextBox();
            this.TextUretimOdun2X = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.TextUretimOdun1Y = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.TextUretimOdun1X = new System.Windows.Forms.TextBox();
            this.CheckUretimTas = new System.Windows.Forms.CheckBox();
            this.CheckUretimDemir = new System.Windows.Forms.CheckBox();
            this.CheckUretimOdun2 = new System.Windows.Forms.CheckBox();
            this.CheckUretimOdun1 = new System.Windows.Forms.CheckBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.label58 = new System.Windows.Forms.Label();
            this.TextBalik5Y = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.TextBalik5X = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.TextBalik4Y = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.TextBalik4X = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.TextBalik3Y = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.TextBalik3X = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.TextBalik2Y = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.TextBalik2X = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.TextBalik1Y = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.TextBalik1X = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.Helpers = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.NeedShip.SuspendLayout();
            this.GenelMenu.SuspendLayout();
            this.Macro.SuspendLayout();
            this.TabMacro.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.TabGorevOlustur.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.Helpers.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.Controls.Add(this.tabPage5);
            this.MenuPanel.Controls.Add(this.NeedShip);
            this.MenuPanel.Location = new System.Drawing.Point(3, 3);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Padding = new System.Drawing.Point(0, 0);
            this.MenuPanel.SelectedIndex = 0;
            this.MenuPanel.Size = new System.Drawing.Size(533, 333);
            this.MenuPanel.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.ButtonAlarmKur);
            this.tabPage5.Controls.Add(this.TextTimeBalik);
            this.tabPage5.Controls.Add(this.TextTimeTas);
            this.tabPage5.Controls.Add(this.TextTimeDemir);
            this.tabPage5.Controls.Add(this.TextTimeOdun);
            this.tabPage5.Controls.Add(this.CheckAlarmBalik);
            this.tabPage5.Controls.Add(this.CheckAlarmTas);
            this.tabPage5.Controls.Add(this.CheckAlarmDemir);
            this.tabPage5.Controls.Add(this.CheckAlarmOdun);
            this.tabPage5.Controls.Add(this.CheckAlarmLocation);
            this.tabPage5.Controls.Add(this.TextTimeLocation);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(525, 307);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Alarm";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAlarmKur
            // 
            this.ButtonAlarmKur.Location = new System.Drawing.Point(351, 8);
            this.ButtonAlarmKur.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAlarmKur.Name = "ButtonAlarmKur";
            this.ButtonAlarmKur.Size = new System.Drawing.Size(75, 30);
            this.ButtonAlarmKur.TabIndex = 44;
            this.ButtonAlarmKur.Text = "Kur";
            this.ButtonAlarmKur.UseVisualStyleBackColor = true;
            this.ButtonAlarmKur.Click += new System.EventHandler(this.ButtonAlarmKur_Click);
            // 
            // TextTimeBalik
            // 
            this.TextTimeBalik.Location = new System.Drawing.Point(193, 150);
            this.TextTimeBalik.Margin = new System.Windows.Forms.Padding(0);
            this.TextTimeBalik.Name = "TextTimeBalik";
            this.TextTimeBalik.Size = new System.Drawing.Size(100, 20);
            this.TextTimeBalik.TabIndex = 43;
            this.TextTimeBalik.Text = "3600";
            this.TextTimeBalik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextTimeBalik.TextChanged += new System.EventHandler(this.TextTimeBalik_TextChanged);
            // 
            // TextTimeTas
            // 
            this.TextTimeTas.Location = new System.Drawing.Point(193, 115);
            this.TextTimeTas.Margin = new System.Windows.Forms.Padding(0);
            this.TextTimeTas.Name = "TextTimeTas";
            this.TextTimeTas.Size = new System.Drawing.Size(100, 20);
            this.TextTimeTas.TabIndex = 42;
            this.TextTimeTas.Text = "3000";
            this.TextTimeTas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextTimeTas.TextChanged += new System.EventHandler(this.TextTimeTas_TextChanged);
            // 
            // TextTimeDemir
            // 
            this.TextTimeDemir.Location = new System.Drawing.Point(193, 80);
            this.TextTimeDemir.Margin = new System.Windows.Forms.Padding(0);
            this.TextTimeDemir.Name = "TextTimeDemir";
            this.TextTimeDemir.Size = new System.Drawing.Size(100, 20);
            this.TextTimeDemir.TabIndex = 41;
            this.TextTimeDemir.Text = "4200";
            this.TextTimeDemir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextTimeDemir.TextChanged += new System.EventHandler(this.TextTimeDemir_TextChanged);
            // 
            // TextTimeOdun
            // 
            this.TextTimeOdun.Location = new System.Drawing.Point(193, 45);
            this.TextTimeOdun.Margin = new System.Windows.Forms.Padding(0);
            this.TextTimeOdun.Name = "TextTimeOdun";
            this.TextTimeOdun.Size = new System.Drawing.Size(100, 20);
            this.TextTimeOdun.TabIndex = 40;
            this.TextTimeOdun.Text = "1800";
            this.TextTimeOdun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextTimeOdun.TextChanged += new System.EventHandler(this.TextTimeOdun_TextChanged);
            // 
            // CheckAlarmBalik
            // 
            this.CheckAlarmBalik.AutoSize = true;
            this.CheckAlarmBalik.Location = new System.Drawing.Point(7, 150);
            this.CheckAlarmBalik.Margin = new System.Windows.Forms.Padding(0);
            this.CheckAlarmBalik.Name = "CheckAlarmBalik";
            this.CheckAlarmBalik.Size = new System.Drawing.Size(49, 17);
            this.CheckAlarmBalik.TabIndex = 39;
            this.CheckAlarmBalik.Text = "Balık";
            this.CheckAlarmBalik.UseVisualStyleBackColor = true;
            this.CheckAlarmBalik.CheckedChanged += new System.EventHandler(this.CheckAlarmBalik_CheckedChanged);
            // 
            // CheckAlarmTas
            // 
            this.CheckAlarmTas.AutoSize = true;
            this.CheckAlarmTas.Location = new System.Drawing.Point(7, 115);
            this.CheckAlarmTas.Margin = new System.Windows.Forms.Padding(0);
            this.CheckAlarmTas.Name = "CheckAlarmTas";
            this.CheckAlarmTas.Size = new System.Drawing.Size(44, 17);
            this.CheckAlarmTas.TabIndex = 38;
            this.CheckAlarmTas.Text = "Tas";
            this.CheckAlarmTas.UseVisualStyleBackColor = true;
            this.CheckAlarmTas.CheckedChanged += new System.EventHandler(this.CheckAlarmTas_CheckedChanged);
            // 
            // CheckAlarmDemir
            // 
            this.CheckAlarmDemir.AutoSize = true;
            this.CheckAlarmDemir.Location = new System.Drawing.Point(7, 80);
            this.CheckAlarmDemir.Margin = new System.Windows.Forms.Padding(0);
            this.CheckAlarmDemir.Name = "CheckAlarmDemir";
            this.CheckAlarmDemir.Size = new System.Drawing.Size(53, 17);
            this.CheckAlarmDemir.TabIndex = 37;
            this.CheckAlarmDemir.Text = "Demir";
            this.CheckAlarmDemir.UseVisualStyleBackColor = true;
            this.CheckAlarmDemir.CheckedChanged += new System.EventHandler(this.CheckAlarmDemir_CheckedChanged);
            // 
            // CheckAlarmOdun
            // 
            this.CheckAlarmOdun.AutoSize = true;
            this.CheckAlarmOdun.Location = new System.Drawing.Point(7, 45);
            this.CheckAlarmOdun.Margin = new System.Windows.Forms.Padding(0);
            this.CheckAlarmOdun.Name = "CheckAlarmOdun";
            this.CheckAlarmOdun.Size = new System.Drawing.Size(52, 17);
            this.CheckAlarmOdun.TabIndex = 36;
            this.CheckAlarmOdun.Text = "Odun";
            this.CheckAlarmOdun.UseVisualStyleBackColor = true;
            this.CheckAlarmOdun.CheckedChanged += new System.EventHandler(this.CheckAlarmOdun_CheckedChanged);
            // 
            // CheckAlarmLocation
            // 
            this.CheckAlarmLocation.AutoSize = true;
            this.CheckAlarmLocation.Location = new System.Drawing.Point(7, 10);
            this.CheckAlarmLocation.Margin = new System.Windows.Forms.Padding(0);
            this.CheckAlarmLocation.Name = "CheckAlarmLocation";
            this.CheckAlarmLocation.Size = new System.Drawing.Size(67, 17);
            this.CheckAlarmLocation.TabIndex = 35;
            this.CheckAlarmLocation.Text = "Location";
            this.CheckAlarmLocation.UseVisualStyleBackColor = true;
            this.CheckAlarmLocation.CheckedChanged += new System.EventHandler(this.CheckAlarmLocation_CheckedChanged);
            // 
            // TextTimeLocation
            // 
            this.TextTimeLocation.Location = new System.Drawing.Point(193, 10);
            this.TextTimeLocation.Margin = new System.Windows.Forms.Padding(0);
            this.TextTimeLocation.Name = "TextTimeLocation";
            this.TextTimeLocation.Size = new System.Drawing.Size(100, 20);
            this.TextTimeLocation.TabIndex = 34;
            this.TextTimeLocation.Text = "3600";
            this.TextTimeLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextTimeLocation.TextChanged += new System.EventHandler(this.TextTimeLocation_TextChanged);
            // 
            // NeedShip
            // 
            this.NeedShip.Controls.Add(this.label12);
            this.NeedShip.Controls.Add(this.LabelGemiAciklama);
            this.NeedShip.Controls.Add(this.ButtonHesapla);
            this.NeedShip.Controls.Add(this.label10);
            this.NeedShip.Controls.Add(this.label9);
            this.NeedShip.Controls.Add(this.TextGonderilecekKargoOran);
            this.NeedShip.Controls.Add(this.TextGonderilecekKargoLimit);
            this.NeedShip.Controls.Add(this.label8);
            this.NeedShip.Controls.Add(this.ListGonderilecekGemiler);
            this.NeedShip.Controls.Add(this.label7);
            this.NeedShip.Controls.Add(this.ListGemiKargolar);
            this.NeedShip.Controls.Add(this.ButtonKargoLimitSil);
            this.NeedShip.Controls.Add(this.ButtonKargoLimitEkle);
            this.NeedShip.Controls.Add(this.label6);
            this.NeedShip.Controls.Add(this.TextKargoLimit);
            this.NeedShip.Location = new System.Drawing.Point(4, 22);
            this.NeedShip.Name = "NeedShip";
            this.NeedShip.Padding = new System.Windows.Forms.Padding(3);
            this.NeedShip.Size = new System.Drawing.Size(525, 307);
            this.NeedShip.TabIndex = 5;
            this.NeedShip.Text = "Need Ship";
            this.NeedShip.UseVisualStyleBackColor = true;
            // 
            // LabelGemiAciklama
            // 
            this.LabelGemiAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelGemiAciklama.Location = new System.Drawing.Point(420, 215);
            this.LabelGemiAciklama.Margin = new System.Windows.Forms.Padding(0);
            this.LabelGemiAciklama.Name = "LabelGemiAciklama";
            this.LabelGemiAciklama.Size = new System.Drawing.Size(100, 88);
            this.LabelGemiAciklama.TabIndex = 57;
            this.LabelGemiAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonHesapla
            // 
            this.ButtonHesapla.Enabled = false;
            this.ButtonHesapla.Location = new System.Drawing.Point(435, 185);
            this.ButtonHesapla.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonHesapla.Name = "ButtonHesapla";
            this.ButtonHesapla.Size = new System.Drawing.Size(75, 30);
            this.ButtonHesapla.TabIndex = 56;
            this.ButtonHesapla.Text = "Hesapla";
            this.ButtonHesapla.UseVisualStyleBackColor = true;
            this.ButtonHesapla.Click += new System.EventHandler(this.ButtonHesapla_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(420, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Kargo Oran";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(420, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Kargo Limit";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextGonderilecekKargoOran
            // 
            this.TextGonderilecekKargoOran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextGonderilecekKargoOran.Location = new System.Drawing.Point(420, 155);
            this.TextGonderilecekKargoOran.Margin = new System.Windows.Forms.Padding(0);
            this.TextGonderilecekKargoOran.Name = "TextGonderilecekKargoOran";
            this.TextGonderilecekKargoOran.Size = new System.Drawing.Size(100, 20);
            this.TextGonderilecekKargoOran.TabIndex = 53;
            this.TextGonderilecekKargoOran.Text = "1";
            this.TextGonderilecekKargoOran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextGonderilecekKargoOran.TextChanged += new System.EventHandler(this.TextGonderilecekKargoOran_TextChanged);
            // 
            // TextGonderilecekKargoLimit
            // 
            this.TextGonderilecekKargoLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextGonderilecekKargoLimit.Location = new System.Drawing.Point(420, 100);
            this.TextGonderilecekKargoLimit.Margin = new System.Windows.Forms.Padding(0);
            this.TextGonderilecekKargoLimit.Name = "TextGonderilecekKargoLimit";
            this.TextGonderilecekKargoLimit.Size = new System.Drawing.Size(100, 20);
            this.TextGonderilecekKargoLimit.TabIndex = 52;
            this.TextGonderilecekKargoLimit.Text = "0";
            this.TextGonderilecekKargoLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextGonderilecekKargoLimit.TextChanged += new System.EventHandler(this.TextGonderilecekKargoLimit_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(215, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 40);
            this.label8.TabIndex = 51;
            this.label8.Text = "Gönderilecek Gemiler";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListGonderilecekGemiler
            // 
            this.ListGonderilecekGemiler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListGonderilecekGemiler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListGonderilecekGemiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnGonderilecekSira,
            this.ColumnGonderilecekKargo});
            this.ListGonderilecekGemiler.FullRowSelect = true;
            this.ListGonderilecekGemiler.HideSelection = false;
            this.ListGonderilecekGemiler.Location = new System.Drawing.Point(215, 80);
            this.ListGonderilecekGemiler.Margin = new System.Windows.Forms.Padding(0);
            this.ListGonderilecekGemiler.Name = "ListGonderilecekGemiler";
            this.ListGonderilecekGemiler.Size = new System.Drawing.Size(200, 223);
            this.ListGonderilecekGemiler.TabIndex = 50;
            this.ListGonderilecekGemiler.UseCompatibleStateImageBehavior = false;
            this.ListGonderilecekGemiler.View = System.Windows.Forms.View.Details;
            // 
            // ColumnGonderilecekSira
            // 
            this.ColumnGonderilecekSira.Text = "Sira";
            this.ColumnGonderilecekSira.Width = 43;
            // 
            // ColumnGonderilecekKargo
            // 
            this.ColumnGonderilecekKargo.Text = "Kargo Miktar";
            this.ColumnGonderilecekKargo.Width = 151;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 40);
            this.label7.TabIndex = 49;
            this.label7.Text = "Gemi Kargolar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListGemiKargolar
            // 
            this.ListGemiKargolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListGemiKargolar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnSira,
            this.ColumnKargo});
            this.ListGemiKargolar.FullRowSelect = true;
            this.ListGemiKargolar.HideSelection = false;
            this.ListGemiKargolar.Location = new System.Drawing.Point(6, 80);
            this.ListGemiKargolar.Margin = new System.Windows.Forms.Padding(0);
            this.ListGemiKargolar.Name = "ListGemiKargolar";
            this.ListGemiKargolar.Size = new System.Drawing.Size(200, 223);
            this.ListGemiKargolar.TabIndex = 48;
            this.ListGemiKargolar.UseCompatibleStateImageBehavior = false;
            this.ListGemiKargolar.View = System.Windows.Forms.View.Details;
            // 
            // ColumnSira
            // 
            this.ColumnSira.Text = "Sira";
            this.ColumnSira.Width = 50;
            // 
            // ColumnKargo
            // 
            this.ColumnKargo.Text = "Kargo Miktar";
            this.ColumnKargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnKargo.Width = 143;
            // 
            // ButtonKargoLimitSil
            // 
            this.ButtonKargoLimitSil.Enabled = false;
            this.ButtonKargoLimitSil.Location = new System.Drawing.Point(290, 3);
            this.ButtonKargoLimitSil.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonKargoLimitSil.Name = "ButtonKargoLimitSil";
            this.ButtonKargoLimitSil.Size = new System.Drawing.Size(75, 30);
            this.ButtonKargoLimitSil.TabIndex = 47;
            this.ButtonKargoLimitSil.Text = "Sil";
            this.ButtonKargoLimitSil.UseVisualStyleBackColor = true;
            this.ButtonKargoLimitSil.Click += new System.EventHandler(this.ButtonKargoLimitSil_Click);
            // 
            // ButtonKargoLimitEkle
            // 
            this.ButtonKargoLimitEkle.Enabled = false;
            this.ButtonKargoLimitEkle.Location = new System.Drawing.Point(213, 3);
            this.ButtonKargoLimitEkle.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonKargoLimitEkle.Name = "ButtonKargoLimitEkle";
            this.ButtonKargoLimitEkle.Size = new System.Drawing.Size(75, 30);
            this.ButtonKargoLimitEkle.TabIndex = 46;
            this.ButtonKargoLimitEkle.Text = "Ekle";
            this.ButtonKargoLimitEkle.UseVisualStyleBackColor = true;
            this.ButtonKargoLimitEkle.Click += new System.EventHandler(this.ButtonKargoLimitEkle_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Gemi Kargo Limit";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextKargoLimit
            // 
            this.TextKargoLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextKargoLimit.Location = new System.Drawing.Point(105, 8);
            this.TextKargoLimit.Margin = new System.Windows.Forms.Padding(0);
            this.TextKargoLimit.Name = "TextKargoLimit";
            this.TextKargoLimit.Size = new System.Drawing.Size(100, 20);
            this.TextKargoLimit.TabIndex = 46;
            this.TextKargoLimit.Text = "1";
            this.TextKargoLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextKargoLimit.TextChanged += new System.EventHandler(this.TextKargoLimit_TextChanged);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(236, 5);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 30);
            this.ButtonStart.TabIndex = 32;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ComboMousePos
            // 
            this.ComboMousePos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMousePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboMousePos.FormattingEnabled = true;
            this.ComboMousePos.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.ComboMousePos.Location = new System.Drawing.Point(110, 35);
            this.ComboMousePos.Margin = new System.Windows.Forms.Padding(0);
            this.ComboMousePos.Name = "ComboMousePos";
            this.ComboMousePos.Size = new System.Drawing.Size(100, 21);
            this.ComboMousePos.TabIndex = 41;
            this.ComboMousePos.SelectedIndexChanged += new System.EventHandler(this.ComboMousePos_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(10, 35);
            this.label29.Margin = new System.Windows.Forms.Padding(0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 20);
            this.label29.TabIndex = 40;
            this.label29.Text = "Mouse Pozisyon";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboStartStop
            // 
            this.ComboStartStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboStartStop.FormattingEnabled = true;
            this.ComboStartStop.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.ComboStartStop.Location = new System.Drawing.Point(110, 8);
            this.ComboStartStop.Margin = new System.Windows.Forms.Padding(0);
            this.ComboStartStop.Name = "ComboStartStop";
            this.ComboStartStop.Size = new System.Drawing.Size(100, 21);
            this.ComboStartStop.TabIndex = 39;
            this.ComboStartStop.SelectedIndexChanged += new System.EventHandler(this.ComboStartStop_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(10, 10);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 20);
            this.label30.TabIndex = 38;
            this.label30.Text = "Start-Stop Key";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(221, 35);
            this.label31.Margin = new System.Windows.Forms.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 25);
            this.label31.TabIndex = 43;
            this.label31.Text = "Mouse Pozisyon";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMousePos
            // 
            this.LabelMousePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelMousePos.Location = new System.Drawing.Point(319, 35);
            this.LabelMousePos.Margin = new System.Windows.Forms.Padding(0);
            this.LabelMousePos.Name = "LabelMousePos";
            this.LabelMousePos.Size = new System.Drawing.Size(180, 25);
            this.LabelMousePos.TabIndex = 42;
            this.LabelMousePos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(10, 60);
            this.label32.Margin = new System.Windows.Forms.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 20);
            this.label32.TabIndex = 44;
            this.label32.Text = "Repeat";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextRepeat
            // 
            this.TextRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextRepeat.Location = new System.Drawing.Point(110, 60);
            this.TextRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.TextRepeat.Name = "TextRepeat";
            this.TextRepeat.Size = new System.Drawing.Size(100, 20);
            this.TextRepeat.TabIndex = 34;
            this.TextRepeat.Text = "1";
            this.TextRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextRepeat.TextChanged += new System.EventHandler(this.TextRepeat_TextChanged);
            // 
            // TimerAlarm
            // 
            this.TimerAlarm.Interval = 1000;
            this.TimerAlarm.Tick += new System.EventHandler(this.TimerAlarm_Tick);
            // 
            // TimerKontrol
            // 
            this.TimerKontrol.Interval = 1000;
            this.TimerKontrol.Tick += new System.EventHandler(this.TimerKontrol_Tick);
            // 
            // GenelMenu
            // 
            this.GenelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenelMenu.Controls.Add(this.Macro);
            this.GenelMenu.Controls.Add(this.Helpers);
            this.GenelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenelMenu.Location = new System.Drawing.Point(0, 85);
            this.GenelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.GenelMenu.Name = "GenelMenu";
            this.GenelMenu.Padding = new System.Drawing.Point(0, 0);
            this.GenelMenu.SelectedIndex = 0;
            this.GenelMenu.Size = new System.Drawing.Size(547, 365);
            this.GenelMenu.TabIndex = 45;
            // 
            // Macro
            // 
            this.Macro.Controls.Add(this.TabMacro);
            this.Macro.Location = new System.Drawing.Point(4, 22);
            this.Macro.Name = "Macro";
            this.Macro.Padding = new System.Windows.Forms.Padding(3);
            this.Macro.Size = new System.Drawing.Size(539, 339);
            this.Macro.TabIndex = 6;
            this.Macro.Text = "Macro";
            this.Macro.UseVisualStyleBackColor = true;
            // 
            // TabMacro
            // 
            this.TabMacro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabMacro.Controls.Add(this.tabPage7);
            this.TabMacro.Controls.Add(this.TabGorevOlustur);
            this.TabMacro.Controls.Add(this.tabPage9);
            this.TabMacro.Controls.Add(this.tabPage10);
            this.TabMacro.Location = new System.Drawing.Point(3, 3);
            this.TabMacro.Margin = new System.Windows.Forms.Padding(0);
            this.TabMacro.Name = "TabMacro";
            this.TabMacro.Padding = new System.Drawing.Point(0, 0);
            this.TabMacro.SelectedIndex = 0;
            this.TabMacro.Size = new System.Drawing.Size(533, 333);
            this.TabMacro.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.CheckMacroPetrol);
            this.tabPage7.Controls.Add(this.CheckMacroBeton);
            this.tabPage7.Controls.Add(this.TextScriptTime);
            this.tabPage7.Controls.Add(this.label16);
            this.tabPage7.Controls.Add(this.TextPassingTime);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Controls.Add(this.TextLastRepeat);
            this.tabPage7.Controls.Add(this.label11);
            this.tabPage7.Controls.Add(this.CheckHemenTas);
            this.tabPage7.Controls.Add(this.label82);
            this.tabPage7.Controls.Add(this.label81);
            this.tabPage7.Controls.Add(this.CheckHemenDemir);
            this.tabPage7.Controls.Add(this.ListMacro);
            this.tabPage7.Controls.Add(this.ButtonMacroSil);
            this.tabPage7.Controls.Add(this.CheckHemenOdun2);
            this.tabPage7.Controls.Add(this.ButtonMacroEkle);
            this.tabPage7.Controls.Add(this.label18);
            this.tabPage7.Controls.Add(this.CheckHemenOdun1);
            this.tabPage7.Controls.Add(this.TextMacroRepeat);
            this.tabPage7.Controls.Add(this.ComboMacro);
            this.tabPage7.Controls.Add(this.CheckHemenLocation);
            this.tabPage7.Controls.Add(this.CheckMacroBalik);
            this.tabPage7.Controls.Add(this.CheckMacroLocation);
            this.tabPage7.Controls.Add(this.CheckMacroUretim);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(525, 307);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Macro";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // CheckMacroPetrol
            // 
            this.CheckMacroPetrol.AutoSize = true;
            this.CheckMacroPetrol.Location = new System.Drawing.Point(328, 8);
            this.CheckMacroPetrol.Margin = new System.Windows.Forms.Padding(0);
            this.CheckMacroPetrol.Name = "CheckMacroPetrol";
            this.CheckMacroPetrol.Size = new System.Drawing.Size(53, 17);
            this.CheckMacroPetrol.TabIndex = 53;
            this.CheckMacroPetrol.Text = "Petrol";
            this.CheckMacroPetrol.UseVisualStyleBackColor = true;
            // 
            // CheckMacroBeton
            // 
            this.CheckMacroBeton.AutoSize = true;
            this.CheckMacroBeton.Location = new System.Drawing.Point(274, 8);
            this.CheckMacroBeton.Margin = new System.Windows.Forms.Padding(0);
            this.CheckMacroBeton.Name = "CheckMacroBeton";
            this.CheckMacroBeton.Size = new System.Drawing.Size(54, 17);
            this.CheckMacroBeton.TabIndex = 52;
            this.CheckMacroBeton.Text = "Beton";
            this.CheckMacroBeton.UseVisualStyleBackColor = true;
            // 
            // TextScriptTime
            // 
            this.TextScriptTime.AutoSize = true;
            this.TextScriptTime.Location = new System.Drawing.Point(410, 111);
            this.TextScriptTime.Margin = new System.Windows.Forms.Padding(0);
            this.TextScriptTime.Name = "TextScriptTime";
            this.TextScriptTime.Size = new System.Drawing.Size(0, 13);
            this.TextScriptTime.TabIndex = 51;
            this.TextScriptTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(133, 111);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Passing Tİme";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextPassingTime
            // 
            this.TextPassingTime.AutoSize = true;
            this.TextPassingTime.Location = new System.Drawing.Point(210, 111);
            this.TextPassingTime.Margin = new System.Windows.Forms.Padding(0);
            this.TextPassingTime.Name = "TextPassingTime";
            this.TextPassingTime.Size = new System.Drawing.Size(0, 13);
            this.TextPassingTime.TabIndex = 49;
            this.TextPassingTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(340, 111);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Script Time";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextLastRepeat
            // 
            this.TextLastRepeat.AutoSize = true;
            this.TextLastRepeat.Location = new System.Drawing.Point(75, 111);
            this.TextLastRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.TextLastRepeat.Name = "TextLastRepeat";
            this.TextLastRepeat.Size = new System.Drawing.Size(0, 13);
            this.TextLastRepeat.TabIndex = 47;
            this.TextLastRepeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Last Repeat";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckHemenTas
            // 
            this.CheckHemenTas.AutoSize = true;
            this.CheckHemenTas.Location = new System.Drawing.Point(355, 30);
            this.CheckHemenTas.Margin = new System.Windows.Forms.Padding(0);
            this.CheckHemenTas.Name = "CheckHemenTas";
            this.CheckHemenTas.Size = new System.Drawing.Size(44, 17);
            this.CheckHemenTas.TabIndex = 44;
            this.CheckHemenTas.Text = "Tas";
            this.CheckHemenTas.UseVisualStyleBackColor = true;
            // 
            // label82
            // 
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label82.Location = new System.Drawing.Point(5, 25);
            this.label82.Margin = new System.Windows.Forms.Padding(0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(75, 25);
            this.label82.TabIndex = 45;
            this.label82.Text = "Hemen Basla";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label81.Location = new System.Drawing.Point(5, 5);
            this.label81.Margin = new System.Windows.Forms.Padding(0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(75, 20);
            this.label81.TabIndex = 44;
            this.label81.Text = "Gorevler";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckHemenDemir
            // 
            this.CheckHemenDemir.AutoSize = true;
            this.CheckHemenDemir.Location = new System.Drawing.Point(293, 30);
            this.CheckHemenDemir.Margin = new System.Windows.Forms.Padding(0);
            this.CheckHemenDemir.Name = "CheckHemenDemir";
            this.CheckHemenDemir.Size = new System.Drawing.Size(53, 17);
            this.CheckHemenDemir.TabIndex = 43;
            this.CheckHemenDemir.Text = "Demir";
            this.CheckHemenDemir.UseVisualStyleBackColor = true;
            // 
            // ListMacro
            // 
            this.ListMacro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListMacro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListMacro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListMacro.FullRowSelect = true;
            this.ListMacro.HideSelection = false;
            this.ListMacro.Location = new System.Drawing.Point(2, 133);
            this.ListMacro.Margin = new System.Windows.Forms.Padding(0);
            this.ListMacro.Name = "ListMacro";
            this.ListMacro.Size = new System.Drawing.Size(523, 172);
            this.ListMacro.TabIndex = 31;
            this.ListMacro.UseCompatibleStateImageBehavior = false;
            this.ListMacro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sira";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Repeat";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gorev";
            this.columnHeader3.Width = 380;
            // 
            // ButtonMacroSil
            // 
            this.ButtonMacroSil.Location = new System.Drawing.Point(205, 72);
            this.ButtonMacroSil.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMacroSil.Name = "ButtonMacroSil";
            this.ButtonMacroSil.Size = new System.Drawing.Size(75, 30);
            this.ButtonMacroSil.TabIndex = 30;
            this.ButtonMacroSil.Text = "Sil";
            this.ButtonMacroSil.UseVisualStyleBackColor = true;
            this.ButtonMacroSil.Click += new System.EventHandler(this.ButtonMacroSil_Click);
            // 
            // CheckHemenOdun2
            // 
            this.CheckHemenOdun2.AutoSize = true;
            this.CheckHemenOdun2.Location = new System.Drawing.Point(225, 30);
            this.CheckHemenOdun2.Margin = new System.Windows.Forms.Padding(0);
            this.CheckHemenOdun2.Name = "CheckHemenOdun2";
            this.CheckHemenOdun2.Size = new System.Drawing.Size(58, 17);
            this.CheckHemenOdun2.TabIndex = 42;
            this.CheckHemenOdun2.Text = "Odun2";
            this.CheckHemenOdun2.UseVisualStyleBackColor = true;
            // 
            // ButtonMacroEkle
            // 
            this.ButtonMacroEkle.Location = new System.Drawing.Point(125, 72);
            this.ButtonMacroEkle.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMacroEkle.Name = "ButtonMacroEkle";
            this.ButtonMacroEkle.Size = new System.Drawing.Size(75, 30);
            this.ButtonMacroEkle.TabIndex = 29;
            this.ButtonMacroEkle.Text = "Ekle";
            this.ButtonMacroEkle.UseVisualStyleBackColor = true;
            this.ButtonMacroEkle.Click += new System.EventHandler(this.ButtonMacroEkle_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 81);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Repeat";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckHemenOdun1
            // 
            this.CheckHemenOdun1.AutoSize = true;
            this.CheckHemenOdun1.Location = new System.Drawing.Point(165, 30);
            this.CheckHemenOdun1.Margin = new System.Windows.Forms.Padding(0);
            this.CheckHemenOdun1.Name = "CheckHemenOdun1";
            this.CheckHemenOdun1.Size = new System.Drawing.Size(58, 17);
            this.CheckHemenOdun1.TabIndex = 41;
            this.CheckHemenOdun1.Text = "Odun1";
            this.CheckHemenOdun1.UseVisualStyleBackColor = true;
            // 
            // TextMacroRepeat
            // 
            this.TextMacroRepeat.Location = new System.Drawing.Point(50, 78);
            this.TextMacroRepeat.Name = "TextMacroRepeat";
            this.TextMacroRepeat.Size = new System.Drawing.Size(72, 20);
            this.TextMacroRepeat.TabIndex = 27;
            this.TextMacroRepeat.Text = "1";
            this.TextMacroRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextMacroRepeat.TextChanged += new System.EventHandler(this.TextMacroRepeat_TextChanged);
            // 
            // ComboMacro
            // 
            this.ComboMacro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboMacro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMacro.FormattingEnabled = true;
            this.ComboMacro.Location = new System.Drawing.Point(5, 50);
            this.ComboMacro.Margin = new System.Windows.Forms.Padding(0);
            this.ComboMacro.Name = "ComboMacro";
            this.ComboMacro.Size = new System.Drawing.Size(514, 21);
            this.ComboMacro.TabIndex = 0;
            // 
            // CheckHemenLocation
            // 
            this.CheckHemenLocation.AutoSize = true;
            this.CheckHemenLocation.Location = new System.Drawing.Point(90, 30);
            this.CheckHemenLocation.Margin = new System.Windows.Forms.Padding(0);
            this.CheckHemenLocation.Name = "CheckHemenLocation";
            this.CheckHemenLocation.Size = new System.Drawing.Size(67, 17);
            this.CheckHemenLocation.TabIndex = 40;
            this.CheckHemenLocation.Text = "Location";
            this.CheckHemenLocation.UseVisualStyleBackColor = true;
            // 
            // CheckMacroBalik
            // 
            this.CheckMacroBalik.AutoSize = true;
            this.CheckMacroBalik.Location = new System.Drawing.Point(225, 8);
            this.CheckMacroBalik.Margin = new System.Windows.Forms.Padding(0);
            this.CheckMacroBalik.Name = "CheckMacroBalik";
            this.CheckMacroBalik.Size = new System.Drawing.Size(49, 17);
            this.CheckMacroBalik.TabIndex = 36;
            this.CheckMacroBalik.Text = "Balık";
            this.CheckMacroBalik.UseVisualStyleBackColor = true;
            // 
            // CheckMacroLocation
            // 
            this.CheckMacroLocation.AutoSize = true;
            this.CheckMacroLocation.Location = new System.Drawing.Point(90, 8);
            this.CheckMacroLocation.Margin = new System.Windows.Forms.Padding(0);
            this.CheckMacroLocation.Name = "CheckMacroLocation";
            this.CheckMacroLocation.Size = new System.Drawing.Size(67, 17);
            this.CheckMacroLocation.TabIndex = 34;
            this.CheckMacroLocation.Text = "Location";
            this.CheckMacroLocation.UseVisualStyleBackColor = true;
            // 
            // CheckMacroUretim
            // 
            this.CheckMacroUretim.AutoSize = true;
            this.CheckMacroUretim.Location = new System.Drawing.Point(165, 8);
            this.CheckMacroUretim.Margin = new System.Windows.Forms.Padding(0);
            this.CheckMacroUretim.Name = "CheckMacroUretim";
            this.CheckMacroUretim.Size = new System.Drawing.Size(56, 17);
            this.CheckMacroUretim.TabIndex = 35;
            this.CheckMacroUretim.Text = "Uretim";
            this.CheckMacroUretim.UseVisualStyleBackColor = true;
            // 
            // TabGorevOlustur
            // 
            this.TabGorevOlustur.Controls.Add(this.ButtonInfo);
            this.TabGorevOlustur.Controls.Add(this.ButtonKoordinat);
            this.TabGorevOlustur.Controls.Add(this.ButtonGrupUpdate);
            this.TabGorevOlustur.Controls.Add(this.ButtonActionUpdate);
            this.TabGorevOlustur.Controls.Add(this.label19);
            this.TabGorevOlustur.Controls.Add(this.ButtonGrupSil);
            this.TabGorevOlustur.Controls.Add(this.ButtonGrupEkle);
            this.TabGorevOlustur.Controls.Add(this.ButtonActionUp);
            this.TabGorevOlustur.Controls.Add(this.ButtonActionDown);
            this.TabGorevOlustur.Controls.Add(this.label20);
            this.TabGorevOlustur.Controls.Add(this.ButtonActionSil);
            this.TabGorevOlustur.Controls.Add(this.ListGrupActions);
            this.TabGorevOlustur.Controls.Add(this.label21);
            this.TabGorevOlustur.Controls.Add(this.label22);
            this.TabGorevOlustur.Controls.Add(this.TextWaitTime);
            this.TabGorevOlustur.Controls.Add(this.ButtonActionEkle);
            this.TabGorevOlustur.Controls.Add(this.label23);
            this.TabGorevOlustur.Controls.Add(this.TextActionDesc);
            this.TabGorevOlustur.Controls.Add(this.TextKoorY);
            this.TabGorevOlustur.Controls.Add(this.label26);
            this.TabGorevOlustur.Controls.Add(this.TextKoorX);
            this.TabGorevOlustur.Controls.Add(this.label27);
            this.TabGorevOlustur.Controls.Add(this.label51);
            this.TabGorevOlustur.Controls.Add(this.label52);
            this.TabGorevOlustur.Controls.Add(this.TextGrupName);
            this.TabGorevOlustur.Location = new System.Drawing.Point(4, 22);
            this.TabGorevOlustur.Margin = new System.Windows.Forms.Padding(0);
            this.TabGorevOlustur.Name = "TabGorevOlustur";
            this.TabGorevOlustur.Size = new System.Drawing.Size(525, 307);
            this.TabGorevOlustur.TabIndex = 1;
            this.TabGorevOlustur.Text = "Gorev Olustur";
            this.TabGorevOlustur.UseVisualStyleBackColor = true;
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.Location = new System.Drawing.Point(446, 56);
            this.ButtonInfo.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(75, 29);
            this.ButtonInfo.TabIndex = 56;
            this.ButtonInfo.Text = "List Info";
            this.ButtonInfo.UseVisualStyleBackColor = true;
            this.ButtonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // ButtonKoordinat
            // 
            this.ButtonKoordinat.Location = new System.Drawing.Point(420, 27);
            this.ButtonKoordinat.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonKoordinat.Name = "ButtonKoordinat";
            this.ButtonKoordinat.Size = new System.Drawing.Size(100, 29);
            this.ButtonKoordinat.TabIndex = 55;
            this.ButtonKoordinat.Text = "Koordinat";
            this.ButtonKoordinat.UseVisualStyleBackColor = true;
            this.ButtonKoordinat.Click += new System.EventHandler(this.ButtonKoordinat_Click);
            // 
            // ButtonGrupUpdate
            // 
            this.ButtonGrupUpdate.Location = new System.Drawing.Point(275, 140);
            this.ButtonGrupUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonGrupUpdate.Name = "ButtonGrupUpdate";
            this.ButtonGrupUpdate.Size = new System.Drawing.Size(80, 29);
            this.ButtonGrupUpdate.TabIndex = 54;
            this.ButtonGrupUpdate.Text = "Update";
            this.ButtonGrupUpdate.UseVisualStyleBackColor = true;
            this.ButtonGrupUpdate.Click += new System.EventHandler(this.ButtonGrupUpdate_Click);
            // 
            // ButtonActionUpdate
            // 
            this.ButtonActionUpdate.Location = new System.Drawing.Point(275, 110);
            this.ButtonActionUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonActionUpdate.Name = "ButtonActionUpdate";
            this.ButtonActionUpdate.Size = new System.Drawing.Size(80, 29);
            this.ButtonActionUpdate.TabIndex = 53;
            this.ButtonActionUpdate.Text = "Update";
            this.ButtonActionUpdate.UseVisualStyleBackColor = true;
            this.ButtonActionUpdate.Click += new System.EventHandler(this.ButtonActionUpdate_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(62, 148);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 52;
            this.label19.Text = "Gorev";
            // 
            // ButtonGrupSil
            // 
            this.ButtonGrupSil.Location = new System.Drawing.Point(220, 140);
            this.ButtonGrupSil.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonGrupSil.Name = "ButtonGrupSil";
            this.ButtonGrupSil.Size = new System.Drawing.Size(50, 29);
            this.ButtonGrupSil.TabIndex = 51;
            this.ButtonGrupSil.Text = "Sil";
            this.ButtonGrupSil.UseVisualStyleBackColor = true;
            this.ButtonGrupSil.Click += new System.EventHandler(this.ButtonGrupSil_Click);
            // 
            // ButtonGrupEkle
            // 
            this.ButtonGrupEkle.Location = new System.Drawing.Point(155, 140);
            this.ButtonGrupEkle.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonGrupEkle.Name = "ButtonGrupEkle";
            this.ButtonGrupEkle.Size = new System.Drawing.Size(60, 29);
            this.ButtonGrupEkle.TabIndex = 50;
            this.ButtonGrupEkle.Text = "Ekle";
            this.ButtonGrupEkle.UseVisualStyleBackColor = true;
            this.ButtonGrupEkle.Click += new System.EventHandler(this.ButtonGrupEkle_Click);
            // 
            // ButtonActionUp
            // 
            this.ButtonActionUp.Location = new System.Drawing.Point(360, 110);
            this.ButtonActionUp.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonActionUp.Name = "ButtonActionUp";
            this.ButtonActionUp.Size = new System.Drawing.Size(55, 29);
            this.ButtonActionUp.TabIndex = 49;
            this.ButtonActionUp.Text = "Up";
            this.ButtonActionUp.UseVisualStyleBackColor = true;
            this.ButtonActionUp.Click += new System.EventHandler(this.ButtonActionUp_Click);
            // 
            // ButtonActionDown
            // 
            this.ButtonActionDown.Location = new System.Drawing.Point(420, 110);
            this.ButtonActionDown.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonActionDown.Name = "ButtonActionDown";
            this.ButtonActionDown.Size = new System.Drawing.Size(70, 29);
            this.ButtonActionDown.TabIndex = 48;
            this.ButtonActionDown.Text = "Down";
            this.ButtonActionDown.UseVisualStyleBackColor = true;
            this.ButtonActionDown.Click += new System.EventHandler(this.ButtonActionDown_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(62, 118);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Action";
            // 
            // ButtonActionSil
            // 
            this.ButtonActionSil.Location = new System.Drawing.Point(220, 110);
            this.ButtonActionSil.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonActionSil.Name = "ButtonActionSil";
            this.ButtonActionSil.Size = new System.Drawing.Size(50, 29);
            this.ButtonActionSil.TabIndex = 46;
            this.ButtonActionSil.Text = "Sil";
            this.ButtonActionSil.UseVisualStyleBackColor = true;
            this.ButtonActionSil.Click += new System.EventHandler(this.ButtonActionSil_Click);
            // 
            // ListGrupActions
            // 
            this.ListGrupActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ListGrupActions.FullRowSelect = true;
            this.ListGrupActions.HideSelection = false;
            this.ListGrupActions.Location = new System.Drawing.Point(5, 170);
            this.ListGrupActions.Margin = new System.Windows.Forms.Padding(0);
            this.ListGrupActions.MultiSelect = false;
            this.ListGrupActions.Name = "ListGrupActions";
            this.ListGrupActions.Size = new System.Drawing.Size(515, 135);
            this.ListGrupActions.TabIndex = 45;
            this.ListGrupActions.UseCompatibleStateImageBehavior = false;
            this.ListGrupActions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sira";
            this.columnHeader4.Width = 45;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "X";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Y";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 65;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Waiting";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Desc";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 200;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(221, 59);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 44;
            this.label21.Text = "saniye";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(5, 53);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(145, 24);
            this.label22.TabIndex = 43;
            this.label22.Text = "Action Bekleme";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextWaitTime
            // 
            this.TextWaitTime.Location = new System.Drawing.Point(155, 55);
            this.TextWaitTime.Margin = new System.Windows.Forms.Padding(0);
            this.TextWaitTime.Name = "TextWaitTime";
            this.TextWaitTime.Size = new System.Drawing.Size(60, 20);
            this.TextWaitTime.TabIndex = 42;
            this.TextWaitTime.Text = "1";
            this.TextWaitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonActionEkle
            // 
            this.ButtonActionEkle.Location = new System.Drawing.Point(155, 110);
            this.ButtonActionEkle.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonActionEkle.Name = "ButtonActionEkle";
            this.ButtonActionEkle.Size = new System.Drawing.Size(60, 29);
            this.ButtonActionEkle.TabIndex = 41;
            this.ButtonActionEkle.Text = "Ekle";
            this.ButtonActionEkle.UseVisualStyleBackColor = true;
            this.ButtonActionEkle.Click += new System.EventHandler(this.ButtonActionEkle_Click);
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(5, 83);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(145, 24);
            this.label23.TabIndex = 40;
            this.label23.Text = "Action Açıklama";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextActionDesc
            // 
            this.TextActionDesc.Location = new System.Drawing.Point(155, 85);
            this.TextActionDesc.Margin = new System.Windows.Forms.Padding(0);
            this.TextActionDesc.Name = "TextActionDesc";
            this.TextActionDesc.Size = new System.Drawing.Size(365, 20);
            this.TextActionDesc.TabIndex = 39;
            // 
            // TextKoorY
            // 
            this.TextKoorY.Location = new System.Drawing.Point(275, 30);
            this.TextKoorY.Margin = new System.Windows.Forms.Padding(0);
            this.TextKoorY.Name = "TextKoorY";
            this.TextKoorY.Size = new System.Drawing.Size(50, 20);
            this.TextKoorY.TabIndex = 38;
            this.TextKoorY.Text = "0";
            this.TextKoorY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextKoorY.TextChanged += new System.EventHandler(this.TextKoorY_TextChanged);
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(250, 28);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 25);
            this.label26.TabIndex = 37;
            this.label26.Text = "Y";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextKoorX
            // 
            this.TextKoorX.Location = new System.Drawing.Point(185, 30);
            this.TextKoorX.Margin = new System.Windows.Forms.Padding(0);
            this.TextKoorX.Name = "TextKoorX";
            this.TextKoorX.Size = new System.Drawing.Size(50, 20);
            this.TextKoorX.TabIndex = 36;
            this.TextKoorX.Text = "0";
            this.TextKoorX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextKoorX.TextChanged += new System.EventHandler(this.TextKoorX_TextChanged);
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(155, 28);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(25, 25);
            this.label27.TabIndex = 35;
            this.label27.Text = "X";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(5, 28);
            this.label51.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(145, 24);
            this.label51.TabIndex = 34;
            this.label51.Text = "Koordinat";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(5, 7);
            this.label52.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(145, 24);
            this.label52.TabIndex = 33;
            this.label52.Text = "Gorev İsmi";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextGrupName
            // 
            this.TextGrupName.Location = new System.Drawing.Point(155, 5);
            this.TextGrupName.Margin = new System.Windows.Forms.Padding(0);
            this.TextGrupName.Name = "TextGrupName";
            this.TextGrupName.Size = new System.Drawing.Size(365, 20);
            this.TextGrupName.TabIndex = 32;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.CheckUretimLimitsizTas);
            this.tabPage9.Controls.Add(this.CheckUretimLimitsizDemir);
            this.tabPage9.Controls.Add(this.CheckUretimLimitsizOdun2);
            this.tabPage9.Controls.Add(this.CheckUretimLimitsizOdun1);
            this.tabPage9.Controls.Add(this.label53);
            this.tabPage9.Controls.Add(this.TextUretimLimitTas);
            this.tabPage9.Controls.Add(this.TextUretimLimitDemir);
            this.tabPage9.Controls.Add(this.TextUretimLimitOdun2);
            this.tabPage9.Controls.Add(this.TextUretimLimitOdun1);
            this.tabPage9.Controls.Add(this.label54);
            this.tabPage9.Controls.Add(this.TextUretimTimeTas);
            this.tabPage9.Controls.Add(this.TextUretimTimeDemir);
            this.tabPage9.Controls.Add(this.TextUretimTimeOdun2);
            this.tabPage9.Controls.Add(this.TextUretimTimeOdun1);
            this.tabPage9.Controls.Add(this.label55);
            this.tabPage9.Controls.Add(this.TextUretimTasY);
            this.tabPage9.Controls.Add(this.TextUretimTasX);
            this.tabPage9.Controls.Add(this.TextUretimDemirY);
            this.tabPage9.Controls.Add(this.TextUretimDemirX);
            this.tabPage9.Controls.Add(this.TextUretimOdun2Y);
            this.tabPage9.Controls.Add(this.TextUretimOdun2X);
            this.tabPage9.Controls.Add(this.label56);
            this.tabPage9.Controls.Add(this.TextUretimOdun1Y);
            this.tabPage9.Controls.Add(this.label57);
            this.tabPage9.Controls.Add(this.TextUretimOdun1X);
            this.tabPage9.Controls.Add(this.CheckUretimTas);
            this.tabPage9.Controls.Add(this.CheckUretimDemir);
            this.tabPage9.Controls.Add(this.CheckUretimOdun2);
            this.tabPage9.Controls.Add(this.CheckUretimOdun1);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(525, 307);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Uretim";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // CheckUretimLimitsizTas
            // 
            this.CheckUretimLimitsizTas.AutoSize = true;
            this.CheckUretimLimitsizTas.Checked = true;
            this.CheckUretimLimitsizTas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUretimLimitsizTas.Location = new System.Drawing.Point(375, 151);
            this.CheckUretimLimitsizTas.Margin = new System.Windows.Forms.Padding(0);
            this.CheckUretimLimitsizTas.Name = "CheckUretimLimitsizTas";
            this.CheckUretimLimitsizTas.Size = new System.Drawing.Size(15, 14);
            this.CheckUretimLimitsizTas.TabIndex = 86;
            this.CheckUretimLimitsizTas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckUretimLimitsizTas.UseVisualStyleBackColor = true;
            // 
            // CheckUretimLimitsizDemir
            // 
            this.CheckUretimLimitsizDemir.AutoSize = true;
            this.CheckUretimLimitsizDemir.Checked = true;
            this.CheckUretimLimitsizDemir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUretimLimitsizDemir.Location = new System.Drawing.Point(375, 117);
            this.CheckUretimLimitsizDemir.Margin = new System.Windows.Forms.Padding(0);
            this.CheckUretimLimitsizDemir.Name = "CheckUretimLimitsizDemir";
            this.CheckUretimLimitsizDemir.Size = new System.Drawing.Size(15, 14);
            this.CheckUretimLimitsizDemir.TabIndex = 85;
            this.CheckUretimLimitsizDemir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckUretimLimitsizDemir.UseVisualStyleBackColor = true;
            // 
            // CheckUretimLimitsizOdun2
            // 
            this.CheckUretimLimitsizOdun2.AutoSize = true;
            this.CheckUretimLimitsizOdun2.Checked = true;
            this.CheckUretimLimitsizOdun2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUretimLimitsizOdun2.Location = new System.Drawing.Point(375, 83);
            this.CheckUretimLimitsizOdun2.Margin = new System.Windows.Forms.Padding(0);
            this.CheckUretimLimitsizOdun2.Name = "CheckUretimLimitsizOdun2";
            this.CheckUretimLimitsizOdun2.Size = new System.Drawing.Size(15, 14);
            this.CheckUretimLimitsizOdun2.TabIndex = 84;
            this.CheckUretimLimitsizOdun2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckUretimLimitsizOdun2.UseVisualStyleBackColor = true;
            // 
            // CheckUretimLimitsizOdun1
            // 
            this.CheckUretimLimitsizOdun1.AutoSize = true;
            this.CheckUretimLimitsizOdun1.Checked = true;
            this.CheckUretimLimitsizOdun1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUretimLimitsizOdun1.Location = new System.Drawing.Point(375, 47);
            this.CheckUretimLimitsizOdun1.Margin = new System.Windows.Forms.Padding(0);
            this.CheckUretimLimitsizOdun1.Name = "CheckUretimLimitsizOdun1";
            this.CheckUretimLimitsizOdun1.Size = new System.Drawing.Size(15, 14);
            this.CheckUretimLimitsizOdun1.TabIndex = 83;
            this.CheckUretimLimitsizOdun1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckUretimLimitsizOdun1.UseVisualStyleBackColor = true;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(362, 12);
            this.label53.Margin = new System.Windows.Forms.Padding(0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(40, 13);
            this.label53.TabIndex = 82;
            this.label53.Text = "Limitsiz";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextUretimLimitTas
            // 
            this.TextUretimLimitTas.Location = new System.Drawing.Point(422, 142);
            this.TextUretimLimitTas.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimLimitTas.Name = "TextUretimLimitTas";
            this.TextUretimLimitTas.Size = new System.Drawing.Size(55, 20);
            this.TextUretimLimitTas.TabIndex = 81;
            this.TextUretimLimitTas.Text = "0";
            this.TextUretimLimitTas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextUretimLimitDemir
            // 
            this.TextUretimLimitDemir.Location = new System.Drawing.Point(422, 108);
            this.TextUretimLimitDemir.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimLimitDemir.Name = "TextUretimLimitDemir";
            this.TextUretimLimitDemir.Size = new System.Drawing.Size(55, 20);
            this.TextUretimLimitDemir.TabIndex = 80;
            this.TextUretimLimitDemir.Text = "0";
            this.TextUretimLimitDemir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextUretimLimitOdun2
            // 
            this.TextUretimLimitOdun2.Location = new System.Drawing.Point(422, 74);
            this.TextUretimLimitOdun2.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimLimitOdun2.Name = "TextUretimLimitOdun2";
            this.TextUretimLimitOdun2.Size = new System.Drawing.Size(55, 20);
            this.TextUretimLimitOdun2.TabIndex = 79;
            this.TextUretimLimitOdun2.Text = "0";
            this.TextUretimLimitOdun2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextUretimLimitOdun1
            // 
            this.TextUretimLimitOdun1.Location = new System.Drawing.Point(422, 40);
            this.TextUretimLimitOdun1.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimLimitOdun1.Name = "TextUretimLimitOdun1";
            this.TextUretimLimitOdun1.Size = new System.Drawing.Size(55, 20);
            this.TextUretimLimitOdun1.TabIndex = 78;
            this.TextUretimLimitOdun1.Text = "0";
            this.TextUretimLimitOdun1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(425, 12);
            this.label54.Margin = new System.Windows.Forms.Padding(0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(28, 13);
            this.label54.TabIndex = 77;
            this.label54.Text = "Limit";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextUretimTimeTas
            // 
            this.TextUretimTimeTas.Location = new System.Drawing.Point(275, 142);
            this.TextUretimTimeTas.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimTimeTas.Name = "TextUretimTimeTas";
            this.TextUretimTimeTas.Size = new System.Drawing.Size(55, 20);
            this.TextUretimTimeTas.TabIndex = 76;
            this.TextUretimTimeTas.Text = "3000";
            this.TextUretimTimeTas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimTimeTas.TextChanged += new System.EventHandler(this.TextUretimTimeTas_TextChanged);
            // 
            // TextUretimTimeDemir
            // 
            this.TextUretimTimeDemir.Location = new System.Drawing.Point(275, 108);
            this.TextUretimTimeDemir.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimTimeDemir.Name = "TextUretimTimeDemir";
            this.TextUretimTimeDemir.Size = new System.Drawing.Size(55, 20);
            this.TextUretimTimeDemir.TabIndex = 75;
            this.TextUretimTimeDemir.Text = "4200";
            this.TextUretimTimeDemir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimTimeDemir.TextChanged += new System.EventHandler(this.TextUretimTimeDemir_TextChanged);
            // 
            // TextUretimTimeOdun2
            // 
            this.TextUretimTimeOdun2.Location = new System.Drawing.Point(275, 74);
            this.TextUretimTimeOdun2.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimTimeOdun2.Name = "TextUretimTimeOdun2";
            this.TextUretimTimeOdun2.Size = new System.Drawing.Size(55, 20);
            this.TextUretimTimeOdun2.TabIndex = 74;
            this.TextUretimTimeOdun2.Text = "1800";
            this.TextUretimTimeOdun2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimTimeOdun2.TextChanged += new System.EventHandler(this.TextUretimTimeOdun2_TextChanged);
            // 
            // TextUretimTimeOdun1
            // 
            this.TextUretimTimeOdun1.Location = new System.Drawing.Point(275, 40);
            this.TextUretimTimeOdun1.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimTimeOdun1.Name = "TextUretimTimeOdun1";
            this.TextUretimTimeOdun1.Size = new System.Drawing.Size(55, 20);
            this.TextUretimTimeOdun1.TabIndex = 70;
            this.TextUretimTimeOdun1.Text = "1800";
            this.TextUretimTimeOdun1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimTimeOdun1.TextChanged += new System.EventHandler(this.TextUretimTimeOdun1_TextChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(275, 12);
            this.label55.Margin = new System.Windows.Forms.Padding(0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(30, 13);
            this.label55.TabIndex = 69;
            this.label55.Text = "Time";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextUretimTasY
            // 
            this.TextUretimTasY.Location = new System.Drawing.Point(185, 142);
            this.TextUretimTasY.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimTasY.Name = "TextUretimTasY";
            this.TextUretimTasY.Size = new System.Drawing.Size(55, 20);
            this.TextUretimTasY.TabIndex = 67;
            this.TextUretimTasY.Text = "200";
            this.TextUretimTasY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimTasY.TextChanged += new System.EventHandler(this.TextUretimTasY_TextChanged);
            // 
            // TextUretimTasX
            // 
            this.TextUretimTasX.Location = new System.Drawing.Point(115, 142);
            this.TextUretimTasX.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimTasX.Name = "TextUretimTasX";
            this.TextUretimTasX.Size = new System.Drawing.Size(55, 20);
            this.TextUretimTasX.TabIndex = 65;
            this.TextUretimTasX.Text = "568";
            this.TextUretimTasX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimTasX.TextChanged += new System.EventHandler(this.TextUretimTasX_TextChanged);
            // 
            // TextUretimDemirY
            // 
            this.TextUretimDemirY.Location = new System.Drawing.Point(185, 108);
            this.TextUretimDemirY.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimDemirY.Name = "TextUretimDemirY";
            this.TextUretimDemirY.Size = new System.Drawing.Size(55, 20);
            this.TextUretimDemirY.TabIndex = 63;
            this.TextUretimDemirY.Text = "249";
            this.TextUretimDemirY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimDemirY.TextChanged += new System.EventHandler(this.TextUretimDemirY_TextChanged);
            // 
            // TextUretimDemirX
            // 
            this.TextUretimDemirX.Location = new System.Drawing.Point(115, 108);
            this.TextUretimDemirX.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimDemirX.Name = "TextUretimDemirX";
            this.TextUretimDemirX.Size = new System.Drawing.Size(55, 20);
            this.TextUretimDemirX.TabIndex = 61;
            this.TextUretimDemirX.Text = "651";
            this.TextUretimDemirX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimDemirX.TextChanged += new System.EventHandler(this.TextUretimDemirX_TextChanged);
            // 
            // TextUretimOdun2Y
            // 
            this.TextUretimOdun2Y.Location = new System.Drawing.Point(185, 74);
            this.TextUretimOdun2Y.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimOdun2Y.Name = "TextUretimOdun2Y";
            this.TextUretimOdun2Y.Size = new System.Drawing.Size(55, 20);
            this.TextUretimOdun2Y.TabIndex = 59;
            this.TextUretimOdun2Y.Text = "202";
            this.TextUretimOdun2Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimOdun2Y.TextChanged += new System.EventHandler(this.TextUretimOdun2Y_TextChanged);
            // 
            // TextUretimOdun2X
            // 
            this.TextUretimOdun2X.Location = new System.Drawing.Point(115, 74);
            this.TextUretimOdun2X.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimOdun2X.Name = "TextUretimOdun2X";
            this.TextUretimOdun2X.Size = new System.Drawing.Size(55, 20);
            this.TextUretimOdun2X.TabIndex = 57;
            this.TextUretimOdun2X.Text = "701";
            this.TextUretimOdun2X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimOdun2X.TextChanged += new System.EventHandler(this.TextUretimOdun2X_TextChanged);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(200, 12);
            this.label56.Margin = new System.Windows.Forms.Padding(0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(14, 13);
            this.label56.TabIndex = 56;
            this.label56.Text = "Y";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextUretimOdun1Y
            // 
            this.TextUretimOdun1Y.Location = new System.Drawing.Point(185, 40);
            this.TextUretimOdun1Y.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimOdun1Y.Name = "TextUretimOdun1Y";
            this.TextUretimOdun1Y.Size = new System.Drawing.Size(55, 20);
            this.TextUretimOdun1Y.TabIndex = 55;
            this.TextUretimOdun1Y.Text = "162";
            this.TextUretimOdun1Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimOdun1Y.TextChanged += new System.EventHandler(this.TextUretimOdun1Y_TextChanged);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(135, 12);
            this.label57.Margin = new System.Windows.Forms.Padding(0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(14, 13);
            this.label57.TabIndex = 54;
            this.label57.Text = "X";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextUretimOdun1X
            // 
            this.TextUretimOdun1X.Location = new System.Drawing.Point(115, 40);
            this.TextUretimOdun1X.Margin = new System.Windows.Forms.Padding(0);
            this.TextUretimOdun1X.Name = "TextUretimOdun1X";
            this.TextUretimOdun1X.Size = new System.Drawing.Size(55, 20);
            this.TextUretimOdun1X.TabIndex = 53;
            this.TextUretimOdun1X.Text = "808";
            this.TextUretimOdun1X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUretimOdun1X.TextChanged += new System.EventHandler(this.TextUretimOdun1X_TextChanged);
            // 
            // CheckUretimTas
            // 
            this.CheckUretimTas.AutoSize = true;
            this.CheckUretimTas.Checked = true;
            this.CheckUretimTas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUretimTas.Location = new System.Drawing.Point(10, 142);
            this.CheckUretimTas.Margin = new System.Windows.Forms.Padding(0);
            this.CheckUretimTas.Name = "CheckUretimTas";
            this.CheckUretimTas.Size = new System.Drawing.Size(44, 17);
            this.CheckUretimTas.TabIndex = 52;
            this.CheckUretimTas.Text = "Tas";
            this.CheckUretimTas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckUretimTas.UseVisualStyleBackColor = true;
            // 
            // CheckUretimDemir
            // 
            this.CheckUretimDemir.AutoSize = true;
            this.CheckUretimDemir.Checked = true;
            this.CheckUretimDemir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUretimDemir.Location = new System.Drawing.Point(10, 108);
            this.CheckUretimDemir.Margin = new System.Windows.Forms.Padding(0);
            this.CheckUretimDemir.Name = "CheckUretimDemir";
            this.CheckUretimDemir.Size = new System.Drawing.Size(53, 17);
            this.CheckUretimDemir.TabIndex = 51;
            this.CheckUretimDemir.Text = "Demir";
            this.CheckUretimDemir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckUretimDemir.UseVisualStyleBackColor = true;
            // 
            // CheckUretimOdun2
            // 
            this.CheckUretimOdun2.AutoSize = true;
            this.CheckUretimOdun2.Checked = true;
            this.CheckUretimOdun2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUretimOdun2.Location = new System.Drawing.Point(10, 74);
            this.CheckUretimOdun2.Margin = new System.Windows.Forms.Padding(0);
            this.CheckUretimOdun2.Name = "CheckUretimOdun2";
            this.CheckUretimOdun2.Size = new System.Drawing.Size(61, 17);
            this.CheckUretimOdun2.TabIndex = 50;
            this.CheckUretimOdun2.Text = "Odun 2";
            this.CheckUretimOdun2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckUretimOdun2.UseVisualStyleBackColor = true;
            // 
            // CheckUretimOdun1
            // 
            this.CheckUretimOdun1.AutoSize = true;
            this.CheckUretimOdun1.Checked = true;
            this.CheckUretimOdun1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUretimOdun1.Location = new System.Drawing.Point(10, 40);
            this.CheckUretimOdun1.Margin = new System.Windows.Forms.Padding(0);
            this.CheckUretimOdun1.Name = "CheckUretimOdun1";
            this.CheckUretimOdun1.Size = new System.Drawing.Size(61, 17);
            this.CheckUretimOdun1.TabIndex = 49;
            this.CheckUretimOdun1.Text = "Odun 1";
            this.CheckUretimOdun1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckUretimOdun1.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.label58);
            this.tabPage10.Controls.Add(this.TextBalik5Y);
            this.tabPage10.Controls.Add(this.label59);
            this.tabPage10.Controls.Add(this.TextBalik5X);
            this.tabPage10.Controls.Add(this.label60);
            this.tabPage10.Controls.Add(this.label61);
            this.tabPage10.Controls.Add(this.TextBalik4Y);
            this.tabPage10.Controls.Add(this.label62);
            this.tabPage10.Controls.Add(this.TextBalik4X);
            this.tabPage10.Controls.Add(this.label63);
            this.tabPage10.Controls.Add(this.label64);
            this.tabPage10.Controls.Add(this.TextBalik3Y);
            this.tabPage10.Controls.Add(this.label65);
            this.tabPage10.Controls.Add(this.TextBalik3X);
            this.tabPage10.Controls.Add(this.label66);
            this.tabPage10.Controls.Add(this.label67);
            this.tabPage10.Controls.Add(this.TextBalik2Y);
            this.tabPage10.Controls.Add(this.label68);
            this.tabPage10.Controls.Add(this.TextBalik2X);
            this.tabPage10.Controls.Add(this.label69);
            this.tabPage10.Controls.Add(this.label73);
            this.tabPage10.Controls.Add(this.TextBalik1Y);
            this.tabPage10.Controls.Add(this.label74);
            this.tabPage10.Controls.Add(this.TextBalik1X);
            this.tabPage10.Controls.Add(this.label75);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(525, 307);
            this.tabPage10.TabIndex = 3;
            this.tabPage10.Text = "Balık";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(200, 184);
            this.label58.Margin = new System.Windows.Forms.Padding(0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(14, 13);
            this.label58.TabIndex = 54;
            this.label58.Text = "Y";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBalik5Y
            // 
            this.TextBalik5Y.Location = new System.Drawing.Point(230, 182);
            this.TextBalik5Y.Margin = new System.Windows.Forms.Padding(0);
            this.TextBalik5Y.Name = "TextBalik5Y";
            this.TextBalik5Y.Size = new System.Drawing.Size(55, 20);
            this.TextBalik5Y.TabIndex = 53;
            this.TextBalik5Y.Text = "301";
            this.TextBalik5Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBalik5Y.TextChanged += new System.EventHandler(this.TextBalik5Y_TextChanged);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(100, 184);
            this.label59.Margin = new System.Windows.Forms.Padding(0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(14, 13);
            this.label59.TabIndex = 52;
            this.label59.Text = "X";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBalik5X
            // 
            this.TextBalik5X.Location = new System.Drawing.Point(130, 182);
            this.TextBalik5X.Margin = new System.Windows.Forms.Padding(0);
            this.TextBalik5X.Name = "TextBalik5X";
            this.TextBalik5X.Size = new System.Drawing.Size(55, 20);
            this.TextBalik5X.TabIndex = 51;
            this.TextBalik5X.Text = "68";
            this.TextBalik5X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBalik5X.TextChanged += new System.EventHandler(this.TextBalik5X_TextChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(10, 184);
            this.label60.Margin = new System.Windows.Forms.Padding(0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(39, 13);
            this.label60.TabIndex = 50;
            this.label60.Text = "Balık 5";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(200, 141);
            this.label61.Margin = new System.Windows.Forms.Padding(0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(14, 13);
            this.label61.TabIndex = 49;
            this.label61.Text = "Y";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBalik4Y
            // 
            this.TextBalik4Y.Location = new System.Drawing.Point(230, 139);
            this.TextBalik4Y.Margin = new System.Windows.Forms.Padding(0);
            this.TextBalik4Y.Name = "TextBalik4Y";
            this.TextBalik4Y.Size = new System.Drawing.Size(55, 20);
            this.TextBalik4Y.TabIndex = 48;
            this.TextBalik4Y.Text = "337";
            this.TextBalik4Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBalik4Y.TextChanged += new System.EventHandler(this.TextBalik4Y_TextChanged);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(100, 141);
            this.label62.Margin = new System.Windows.Forms.Padding(0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(14, 13);
            this.label62.TabIndex = 47;
            this.label62.Text = "X";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBalik4X
            // 
            this.TextBalik4X.Location = new System.Drawing.Point(130, 139);
            this.TextBalik4X.Margin = new System.Windows.Forms.Padding(0);
            this.TextBalik4X.Name = "TextBalik4X";
            this.TextBalik4X.Size = new System.Drawing.Size(55, 20);
            this.TextBalik4X.TabIndex = 46;
            this.TextBalik4X.Text = "143";
            this.TextBalik4X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBalik4X.TextChanged += new System.EventHandler(this.TextBalik4X_TextChanged);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(10, 141);
            this.label63.Margin = new System.Windows.Forms.Padding(0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(39, 13);
            this.label63.TabIndex = 45;
            this.label63.Text = "Balık 4";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(200, 98);
            this.label64.Margin = new System.Windows.Forms.Padding(0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(14, 13);
            this.label64.TabIndex = 44;
            this.label64.Text = "Y";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBalik3Y
            // 
            this.TextBalik3Y.Location = new System.Drawing.Point(230, 96);
            this.TextBalik3Y.Margin = new System.Windows.Forms.Padding(0);
            this.TextBalik3Y.Name = "TextBalik3Y";
            this.TextBalik3Y.Size = new System.Drawing.Size(55, 20);
            this.TextBalik3Y.TabIndex = 43;
            this.TextBalik3Y.Text = "384";
            this.TextBalik3Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBalik3Y.TextChanged += new System.EventHandler(this.TextBalik3Y_TextChanged);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(100, 98);
            this.label65.Margin = new System.Windows.Forms.Padding(0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(14, 13);
            this.label65.TabIndex = 42;
            this.label65.Text = "X";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBalik3X
            // 
            this.TextBalik3X.Location = new System.Drawing.Point(130, 96);
            this.TextBalik3X.Margin = new System.Windows.Forms.Padding(0);
            this.TextBalik3X.Name = "TextBalik3X";
            this.TextBalik3X.Size = new System.Drawing.Size(55, 20);
            this.TextBalik3X.TabIndex = 41;
            this.TextBalik3X.Text = "209";
            this.TextBalik3X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBalik3X.TextChanged += new System.EventHandler(this.TextBalik3X_TextChanged);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(10, 98);
            this.label66.Margin = new System.Windows.Forms.Padding(0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(39, 13);
            this.label66.TabIndex = 40;
            this.label66.Text = "Balık 3";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(200, 55);
            this.label67.Margin = new System.Windows.Forms.Padding(0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(14, 13);
            this.label67.TabIndex = 39;
            this.label67.Text = "Y";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBalik2Y
            // 
            this.TextBalik2Y.Location = new System.Drawing.Point(230, 53);
            this.TextBalik2Y.Margin = new System.Windows.Forms.Padding(0);
            this.TextBalik2Y.Name = "TextBalik2Y";
            this.TextBalik2Y.Size = new System.Drawing.Size(55, 20);
            this.TextBalik2Y.TabIndex = 38;
            this.TextBalik2Y.Text = "427";
            this.TextBalik2Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBalik2Y.TextChanged += new System.EventHandler(this.TextBalik2Y_TextChanged);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(100, 55);
            this.label68.Margin = new System.Windows.Forms.Padding(0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(14, 13);
            this.label68.TabIndex = 37;
            this.label68.Text = "X";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBalik2X
            // 
            this.TextBalik2X.Location = new System.Drawing.Point(130, 53);
            this.TextBalik2X.Margin = new System.Windows.Forms.Padding(0);
            this.TextBalik2X.Name = "TextBalik2X";
            this.TextBalik2X.Size = new System.Drawing.Size(55, 20);
            this.TextBalik2X.TabIndex = 36;
            this.TextBalik2X.Text = "276";
            this.TextBalik2X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBalik2X.TextChanged += new System.EventHandler(this.TextBalik2X_TextChanged);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(10, 55);
            this.label69.Margin = new System.Windows.Forms.Padding(0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(39, 13);
            this.label69.TabIndex = 35;
            this.label69.Text = "Balık 2";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(200, 12);
            this.label73.Margin = new System.Windows.Forms.Padding(0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(14, 13);
            this.label73.TabIndex = 29;
            this.label73.Text = "Y";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBalik1Y
            // 
            this.TextBalik1Y.Location = new System.Drawing.Point(230, 10);
            this.TextBalik1Y.Margin = new System.Windows.Forms.Padding(0);
            this.TextBalik1Y.Name = "TextBalik1Y";
            this.TextBalik1Y.Size = new System.Drawing.Size(55, 20);
            this.TextBalik1Y.TabIndex = 28;
            this.TextBalik1Y.Text = "455";
            this.TextBalik1Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBalik1Y.TextChanged += new System.EventHandler(this.TextBalik1Y_TextChanged);
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(100, 12);
            this.label74.Margin = new System.Windows.Forms.Padding(0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(14, 13);
            this.label74.TabIndex = 27;
            this.label74.Text = "X";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBalik1X
            // 
            this.TextBalik1X.Location = new System.Drawing.Point(130, 10);
            this.TextBalik1X.Margin = new System.Windows.Forms.Padding(0);
            this.TextBalik1X.Name = "TextBalik1X";
            this.TextBalik1X.Size = new System.Drawing.Size(55, 20);
            this.TextBalik1X.TabIndex = 26;
            this.TextBalik1X.Text = "39";
            this.TextBalik1X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBalik1X.TextChanged += new System.EventHandler(this.TextBalik1X_TextChanged);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(10, 12);
            this.label75.Margin = new System.Windows.Forms.Padding(0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(39, 13);
            this.label75.TabIndex = 25;
            this.label75.Text = "Balık 1";
            // 
            // Helpers
            // 
            this.Helpers.Controls.Add(this.MenuPanel);
            this.Helpers.Location = new System.Drawing.Point(4, 22);
            this.Helpers.Name = "Helpers";
            this.Helpers.Padding = new System.Windows.Forms.Padding(3);
            this.Helpers.Size = new System.Drawing.Size(539, 339);
            this.Helpers.TabIndex = 7;
            this.Helpers.Text = " Helpers";
            this.Helpers.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(119, 135);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 40);
            this.label12.TabIndex = 58;
            this.label12.Text = "Upgrade ile eklenecektir.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Macrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 453);
            this.Controls.Add(this.GenelMenu);
            this.Controls.Add(this.TextRepeat);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.LabelMousePos);
            this.Controls.Add(this.ComboMousePos);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.ComboStartStop);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.ButtonStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Macrom";
            this.Text = "Macrom";
            this.MenuPanel.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.NeedShip.ResumeLayout(false);
            this.NeedShip.PerformLayout();
            this.GenelMenu.ResumeLayout(false);
            this.Macro.ResumeLayout(false);
            this.TabMacro.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.TabGorevOlustur.ResumeLayout(false);
            this.TabGorevOlustur.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.Helpers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MenuPanel;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.ComboBox ComboMousePos;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox ComboStartStop;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label LabelMousePos;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox TextRepeat;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button ButtonAlarmKur;
        private System.Windows.Forms.TextBox TextTimeBalik;
        private System.Windows.Forms.TextBox TextTimeTas;
        private System.Windows.Forms.TextBox TextTimeDemir;
        private System.Windows.Forms.TextBox TextTimeOdun;
        private System.Windows.Forms.CheckBox CheckAlarmBalik;
        private System.Windows.Forms.CheckBox CheckAlarmTas;
        private System.Windows.Forms.CheckBox CheckAlarmDemir;
        private System.Windows.Forms.CheckBox CheckAlarmOdun;
        private System.Windows.Forms.CheckBox CheckAlarmLocation;
        private System.Windows.Forms.TextBox TextTimeLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerAlarm;
        private System.Windows.Forms.Timer TimerKontrol;
        private System.Windows.Forms.TabControl GenelMenu;
        private System.Windows.Forms.TabPage Macro;
        private System.Windows.Forms.TabControl TabMacro;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox CheckHemenTas;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.CheckBox CheckHemenDemir;
        private System.Windows.Forms.ListView ListMacro;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ButtonMacroSil;
        private System.Windows.Forms.CheckBox CheckHemenOdun2;
        private System.Windows.Forms.Button ButtonMacroEkle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox CheckHemenOdun1;
        private System.Windows.Forms.TextBox TextMacroRepeat;
        private System.Windows.Forms.ComboBox ComboMacro;
        private System.Windows.Forms.CheckBox CheckHemenLocation;
        private System.Windows.Forms.CheckBox CheckMacroBalik;
        private System.Windows.Forms.CheckBox CheckMacroLocation;
        private System.Windows.Forms.CheckBox CheckMacroUretim;
        private System.Windows.Forms.TabPage TabGorevOlustur;
        private System.Windows.Forms.Button ButtonInfo;
        private System.Windows.Forms.Button ButtonKoordinat;
        private System.Windows.Forms.Button ButtonGrupUpdate;
        private System.Windows.Forms.Button ButtonActionUpdate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button ButtonGrupSil;
        private System.Windows.Forms.Button ButtonGrupEkle;
        private System.Windows.Forms.Button ButtonActionUp;
        private System.Windows.Forms.Button ButtonActionDown;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button ButtonActionSil;
        private System.Windows.Forms.ListView ListGrupActions;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TextWaitTime;
        private System.Windows.Forms.Button ButtonActionEkle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TextActionDesc;
        private System.Windows.Forms.TextBox TextKoorY;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox TextKoorX;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox TextGrupName;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.CheckBox CheckUretimLimitsizTas;
        private System.Windows.Forms.CheckBox CheckUretimLimitsizDemir;
        private System.Windows.Forms.CheckBox CheckUretimLimitsizOdun2;
        private System.Windows.Forms.CheckBox CheckUretimLimitsizOdun1;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox TextUretimLimitTas;
        private System.Windows.Forms.TextBox TextUretimLimitDemir;
        private System.Windows.Forms.TextBox TextUretimLimitOdun2;
        private System.Windows.Forms.TextBox TextUretimLimitOdun1;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox TextUretimTimeTas;
        private System.Windows.Forms.TextBox TextUretimTimeDemir;
        private System.Windows.Forms.TextBox TextUretimTimeOdun2;
        private System.Windows.Forms.TextBox TextUretimTimeOdun1;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox TextUretimTasY;
        private System.Windows.Forms.TextBox TextUretimTasX;
        private System.Windows.Forms.TextBox TextUretimDemirY;
        private System.Windows.Forms.TextBox TextUretimDemirX;
        private System.Windows.Forms.TextBox TextUretimOdun2Y;
        private System.Windows.Forms.TextBox TextUretimOdun2X;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox TextUretimOdun1Y;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox TextUretimOdun1X;
        private System.Windows.Forms.CheckBox CheckUretimTas;
        private System.Windows.Forms.CheckBox CheckUretimDemir;
        private System.Windows.Forms.CheckBox CheckUretimOdun2;
        private System.Windows.Forms.CheckBox CheckUretimOdun1;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox TextBalik5Y;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox TextBalik5X;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox TextBalik4Y;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox TextBalik4X;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox TextBalik3Y;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox TextBalik3X;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox TextBalik2Y;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox TextBalik2X;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox TextBalik1Y;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox TextBalik1X;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TabPage Helpers;
        private System.Windows.Forms.TabPage NeedShip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextKargoLimit;
        private System.Windows.Forms.Button ButtonKargoLimitSil;
        private System.Windows.Forms.Button ButtonKargoLimitEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView ListGonderilecekGemiler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView ListGemiKargolar;
        private System.Windows.Forms.ColumnHeader ColumnSira;
        private System.Windows.Forms.ColumnHeader ColumnKargo;
        private System.Windows.Forms.ColumnHeader ColumnGonderilecekSira;
        private System.Windows.Forms.ColumnHeader ColumnGonderilecekKargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextGonderilecekKargoOran;
        private System.Windows.Forms.TextBox TextGonderilecekKargoLimit;
        private System.Windows.Forms.Label LabelGemiAciklama;
        private System.Windows.Forms.Button ButtonHesapla;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TextLastRepeat;
        private System.Windows.Forms.Label TextScriptTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label TextPassingTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CheckMacroPetrol;
        private System.Windows.Forms.CheckBox CheckMacroBeton;
        private System.Windows.Forms.Label label12;
    }
}