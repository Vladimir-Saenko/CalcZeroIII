using System;
using System.Drawing;
using System.Windows.Forms;
using Tesseract;
using IniParser;
using IniParser.Model;
using System.IO;
using SSR;
using DrillToolWeight;

namespace CalcZeroIII
{
    public partial class MainForm : Form
    {
        private TunningData tunningData;
        private Bitmap captured;

        public MainForm()
        {
            InitializeComponent();
        }

        /* Действия при старте программы */
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Загрузка данных из INI-файла
            string iniPath = $"{Environment.CurrentDirectory}\\CalcZeroIII.ini";
            if (File.Exists(iniPath))
            {
                var parser = new FileIniDataParser();
                IniData iniData = parser.ReadFile(iniPath);
                string iniStr;

                iniStr = iniData["UI"]["winLeft"];
                if (int.Parse(iniStr) >= 0)
                {
                    this.Left = int.Parse(iniStr);  // Если форма на главном экране
                }
                else
                {
                    this.Left = 0;    // Иначе ставим в левый угол главного экрана
                } 

                iniStr = iniData["UI"]["winTop"];
                this.Top = int.Parse(iniStr);

                iniStr = iniData["UI"]["winHeight"];
                this.Height = int.Parse(iniStr);

                iniStr = iniData["UI"]["winWidth"];
                this.Width = int.Parse(iniStr);

                iniStr = iniData["Regions"]["DepthTop"];
                tunningData.depth.Y = int.Parse(iniStr);

                iniStr = iniData["Regions"]["DepthLeft"];
                tunningData.depth.X = int.Parse(iniStr);

                iniStr = iniData["Regions"]["DepthHeight"];
                tunningData.depth.Height = int.Parse(iniStr);

                iniStr = iniData["Regions"]["DepthWidth"];
                tunningData.depth.Width = int.Parse(iniStr);

                iniStr = iniData["Regions"]["CalcDepthTop"];
                tunningData.calcDepth.Y = int.Parse(iniStr);

                iniStr = iniData["Regions"]["CalcDepthLeft"];
                tunningData.calcDepth.X = int.Parse(iniStr);

                iniStr = iniData["Regions"]["CalcDepthHeight"];
                tunningData.calcDepth.Height = int.Parse(iniStr);

                iniStr = iniData["Regions"]["CalcDepthWidth"];
                tunningData.calcDepth.Width = int.Parse(iniStr);

                iniStr = iniData["Regions"]["TalblockTop"];
                tunningData.talblock.Y = int.Parse(iniStr);

                iniStr = iniData["Regions"]["TalblockLeft"];
                tunningData.talblock.X = int.Parse(iniStr);

                iniStr = iniData["Regions"]["TalblockHeight"];
                tunningData.talblock.Height = int.Parse(iniStr);

                iniStr = iniData["Regions"]["TalblockWidth"];
                tunningData.talblock.Width = int.Parse(iniStr);

                iniStr = iniData["Data"]["MinTalblock"];
                tunningData.minTalblock = SStrings.ParseToFloat(iniStr);

                iniStr = iniData["Data"]["VbtLength"];
                tunningData.vbtLength = SStrings.ParseToFloat(iniStr);
            }

            // Сброс режима СПО
            SPOcheckBox.Checked = false;
            VBTcheckBox.Checked = false;
            VBTcheckBox.Enabled = false;
        }

        /* Настройка программы */
        private void Tunning_fileMainMenu_Click(object sender, EventArgs e)
        {
            TunningForm tunningDlg = new TunningForm();
            tunningDlg.resultData = tunningData;
            if (tunningDlg.ShowDialog() == DialogResult.Yes)
            {
                tunningData = tunningDlg.resultData;
            }
        }

        /* Расчет */
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp;
            string tesseractStr = "";
            string errorStr = "";

            // Снимаем скриншот
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            captured = new Bitmap(bounds.Width, bounds.Height);
            Graphics gr = Graphics.FromImage(captured);
            gr.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size);

            MinTalblockTextBox.Text = tunningData.minTalblock.ToString();
            
            // вырезаем окошки и оцифровываем данные:
             
            // Текущий забой
            bmp = new Bitmap(tunningData.depth.Width, tunningData.depth.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //Рисуем на битмапе изображение заданных размеров, что попало в прямоугольник redRect
                g.DrawImage(captured, new Rectangle(0, 0, bmp.Width, bmp.Height), tunningData.depth, GraphicsUnit.Pixel);
            }
            //Пробуем распознать 
            using (var ocrengine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                var res = ocrengine.Process(bmp);
                tesseractStr = res.GetText().Trim().Replace(',', '.');  // обрезаем пробелы/переносы
            }                                                          // и меняем запятую на точку
            float depth = SStrings.ParseToFloat(tesseractStr);
            if (tesseractStr != depth.ToString().Replace(',', '.'))
            {
                errorStr = "Забой";
            }

            // Забой на конец квадрата
            bmp = new Bitmap(tunningData.calcDepth.Width, tunningData.calcDepth.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //Рисуем на битмапе изображение заданных размеров, что попало в прямоугольник redRect
                g.DrawImage(captured, new Rectangle(0, 0, bmp.Width, bmp.Height), tunningData.calcDepth, GraphicsUnit.Pixel);
            }
            //Пробуем распознать 
            using (var ocrengine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                var res = ocrengine.Process(bmp);
                tesseractStr = res.GetText().Trim().Replace(',', '.');  // обрезаем пробелы/переносы
            }                                                          // и меняем запятую на точку
        
            float calcDepth = SStrings.ParseToFloat(tesseractStr);
            if (tesseractStr != calcDepth.ToString().Replace(',', '.'))
            {
                errorStr += ", Положение долота по свечам";
            }

            // Тальблок
            bmp = new Bitmap(tunningData.talblock.Width, tunningData.talblock.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //Рисуем на битмапе изображение заданных размеров, что попало в прямоугольник redRect
                g.DrawImage(captured, new Rectangle(0, 0, bmp.Width, bmp.Height), tunningData.talblock, GraphicsUnit.Pixel);
            }
            //Пробуем распознать 
            using (var ocrengine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                var res = ocrengine.Process(bmp);
                tesseractStr = res.GetText().Trim().Replace(',', '.');  // обрезаем пробелы/переносы
            }                                                          // и меняем запятую на точку
            float talblock = SStrings.ParseToFloat(tesseractStr);
            if (tesseractStr != talblock.ToString().Replace(',', '.'))
            {
                errorStr += ", Тальблок";
            }

            TalblockTextBox.Text = talblock.ToString();

            float onDepth = talblock - tunningData.minTalblock - (calcDepth - depth);

            float talblockOnDepth = calcDepth - depth + tunningData.minTalblock;

            if (errorStr == "")  // Если все данные корректны, считаем и выводим 
            {
                if (SPOcheckBox.Checked) // Если СПО
                {
                    onDepth = depth - calcDepth;
                    if (VBTcheckBox.Checked)
                    {
                        onDepth += tunningData.vbtLength;
                    }

                    Talblock_0TextBox.Text = "Нет данных";
                }
                
                OnDepthTextBox.Text = (Math.Round(onDepth * 1000) / 1000).ToString();
                if (talblockOnDepth > tunningData.minTalblock &&
                    talblockOnDepth < (tunningData.vbtLength + tunningData.minTalblock) &&
                    !SPOcheckBox.Checked)
                {
                    Talblock_0TextBox.Text = (Math.Round(talblockOnDepth * 1000) / 1000).ToString();
                }
                else Talblock_0TextBox.Text = "Нет данных";
                Clipboard.SetDataObject(OnDepthTextBox.Text);
            }
            else                // Если данные не корректны, выводим сообщение об ошибке
            {
                OnDepthTextBox.Text = "";
                Talblock_0TextBox.Text = "";
                MessageBox.Show("Ошибка при вычислении параметров: \n" + errorStr + ".\n" + 
                                "Проверьте позиции окон для этих параметров.");
            }
        }

        /* Переключение СПО - Циркуляция */
        private void SPOcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SPOcheckBox.Checked)
            {
                VBTcheckBox.Enabled = true;
            }
            else
            {
                VBTcheckBox.Enabled = false;
                VBTcheckBox.Checked = false;
            }
        }

        /* Окно сведений о программе */
        private void About_fileMainMenu_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        /* Выход из программы */
        private void Exit_fileMainMenu_Click(object sender, EventArgs e) => Close();

        /* Действия при закрытии программы */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохранение данных в INI-файл
            string iniPath = $"{Environment.CurrentDirectory}\\CalcZeroIII.ini";
            var parser = new FileIniDataParser();

            IniData iniData = new IniData();

            iniData["UI"]["winLeft"] = this.Left.ToString();
            iniData["UI"]["winTop"] = this.Top.ToString();
            iniData["UI"]["winHeight"] = this.Size.Height.ToString();
            iniData["UI"]["winWidth"] = this.Size.Width.ToString();

            iniData["Regions"]["DepthTop"] = tunningData.depth.Top.ToString();
            iniData["Regions"]["DepthLeft"] = tunningData.depth.Left.ToString();
            iniData["Regions"]["DepthHeight"] = tunningData.depth.Height.ToString();
            iniData["Regions"]["DepthWidth"] = tunningData.depth.Width.ToString();

            iniData["Regions"]["CalcDepthTop"] = tunningData.calcDepth.Top.ToString();
            iniData["Regions"]["CalcDepthLeft"] = tunningData.calcDepth.Left.ToString();
            iniData["Regions"]["CalcDepthHeight"] = tunningData.calcDepth.Height.ToString();
            iniData["Regions"]["CalcDepthWidth"] = tunningData.calcDepth.Width.ToString();

            iniData["Regions"]["TalblockTop"] = tunningData.talblock.Top.ToString();
            iniData["Regions"]["TalblockLeft"] = tunningData.talblock.Left.ToString();
            iniData["Regions"]["TalblockHeight"] = tunningData.talblock.Height.ToString();
            iniData["Regions"]["TalblockWidth"] = tunningData.talblock.Width.ToString();

            iniData["Data"]["MinTalblock"] = tunningData.minTalblock.ToString();
            iniData["Data"]["VbtLength"] = tunningData.vbtLength.ToString();

            parser.WriteFile(iniPath, iniData);
        }

    }
}
