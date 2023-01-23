using SSR;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tesseract;

namespace CalcZeroIII
{
    public struct TunningData
    {
        public Rectangle depth;
        public Rectangle calcDepth;
        public Rectangle talblock;
        public float minTalblock;
        public float vbtLength;
    }

    public partial class TunningForm : Form
    {
        private Bitmap captured;
        private readonly Pen redPen = new Pen(Color.Red, 2);
        private Rectangle redRect = new Rectangle(0, 0, 50, 20);
        private Point mouseOffset = new Point(0,0);
        private bool moveOn = false;
        public TunningData resultData;
        
        public TunningForm()
        {
            InitializeComponent();
        }

        /* Действия при загрузке формы */
        private void TunningForm_Load(object sender, EventArgs e)
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;

            captured = new Bitmap(bounds.Width, bounds.Height);
            Graphics gr = Graphics.FromImage(captured);
            gr.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size);
            screenImg.Size = bounds.Size;
            screenImg.BackgroundImage = captured;
            widthUpDown.Value = redRect.Width;
            heightUpDown.Value = redRect.Height;

            minTalblockTextBox.Text = resultData.minTalblock.ToString();
            VbtLengthTextBox.Text = resultData.vbtLength.ToString();

            ParamListBox.SelectedIndex = 0;

            applyBtn.Enabled = CheckAllData();
        }

        /* Нажатие кнопки мыши на скриншоте */
        private void ScreenImg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MouseInRect(e.Location)) 
            {
                mouseOffset.X = e.Location.X - redRect.X;
                mouseOffset.Y = e.Location.Y - redRect.Y;
                moveOn = true;
            }
        }

        /* Проверка нахождения указателя мыши в области распознавания */
        private bool MouseInRect(Point location)
        {
            if ((location.X > redRect.X && location.X < (redRect.X + redRect.Width)) &&
                location.Y > redRect.Y && location.Y < (redRect.Y + redRect.Height))
                return true;
            else
                return false;
        }

        /* Наложение прямоугольника области распознавания на скриншот */
        private void ScreenImg_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(redPen, redRect);
        }

        /* 'Перетаскивание' области распознавания */
        private void ScreenImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && moveOn == true)
            {
                redRect.X = e.Location.X - mouseOffset.X;
                redRect.Y = e.Location.Y - mouseOffset.Y;
                screenImg.Invalidate();
            }
            
        }

        /* Окончание 'перетаскивания' */
        private void ScreenImg_MouseUp(object sender, MouseEventArgs e)
        {
            moveOn = false;
            // Проверяем корректность преобразования в число
            EndMoveRect();
        }

        /* Распознавание текста в заданной области */
        private void EndMoveRect() 
        {
            Bitmap bmp = new Bitmap(redRect.Width, redRect.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //Рисуем на битмапе изображение заданных размеров, что попало в прямоугольник redRect
                g.DrawImage(screenImg.BackgroundImage, new Rectangle(0, 0, bmp.Width, bmp.Height), redRect, GraphicsUnit.Pixel);
            }
            pictureBox1.Image = bmp.Clone() as Image;

            //Пробуем распознать
            using (var ocrengine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                var res = ocrengine.Process(bmp);
                tesseractTextBox.Text = res.GetText();
            }
        }

        /* Сдвиг области распознавания вверх */
        private void UpBtn_Click(object sender, EventArgs e)
        {
            redRect.Offset(0, -1);
            screenImg.Invalidate();
            EndMoveRect();
        }

        /* Сдвиг области распознавания вниз */
        private void DownBtn_Click(object sender, EventArgs e)
        {
            redRect.Offset(0, 1);
            screenImg.Invalidate();
            EndMoveRect();
        }

        /* Сдвиг области распознавания влево */
        private void LeftBtn_Click(object sender, EventArgs e)
        {
            redRect.Offset(-1, 0);
            screenImg.Invalidate();
            EndMoveRect();
        }

        /* Сдвиг области распознавания вправо */
        private void RightBtn_Click(object sender, EventArgs e)
        {
            redRect.Offset(1, 0);
            screenImg.Invalidate();
            EndMoveRect();
        }

        /* Изменение ширины области распознавания */
        private void WidthUpDown_ValueChanged(object sender, EventArgs e)
        {
            redRect.Width = (int)widthUpDown.Value;
            screenImg.Invalidate();
            EndMoveRect();
        }

        /* Изменение высоты области распознавания */
        private void HeightUpDown_ValueChanged(object sender, EventArgs e)
        {
            redRect.Height = (int)heightUpDown.Value;
            screenImg.Invalidate();
            EndMoveRect();
        }

        /* Проверка правильности необходимых параметров */
        private bool CheckAllData() 
        {
            if (resultData.depth.Width > 0 &&
                resultData.calcDepth.Width > 0 &&
                resultData.talblock.Width > 0 &&
                (float.TryParse(minTalblockTextBox.Text, out _) | 
                SStrings.ParseToFloat(minTalblockTextBox.Text) != 0 ) &&
                (float.TryParse(VbtLengthTextBox.Text, out _) |
                SStrings.ParseToFloat(VbtLengthTextBox.Text) != 0))
            {
                return true;
            }
            else
                return false;
        }

        /* Преобразование в число minTalblock */
        private void MinTalblockTextBox_TextChanged(object sender, EventArgs e)
        {
            resultData.minTalblock = SStrings.ParseToFloat(minTalblockTextBox.Text);
            applyBtn.Enabled = CheckAllData();
        }

        /* Преобразование в число vbtLength */
        private void VbtLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            resultData.vbtLength = SStrings.ParseToFloat(VbtLengthTextBox.Text);
            applyBtn.Enabled = CheckAllData();
        }

        /* Фиксация окна для параметра */
        private void LockBtn_Click(object sender, EventArgs e)
        {
            if (ParamListBox.SelectedIndex > -1)
            {
                switch (ParamListBox.SelectedIndex)
                {
                    case 0:
                        resultData.depth = redRect;
                        break;
                    case 1:
                        resultData.calcDepth = redRect;
                        break;
                    default:
                        resultData.talblock = redRect;
                        break;
                }
                applyBtn.Enabled = CheckAllData();
            }
        }

        /* Выбор параметра */
        private void ParamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ParamListBox.SelectedIndex)
            {
                case 0:
                    redRect = resultData.depth;
                    break;
                case 1:
                    redRect = resultData.calcDepth;
                    break;
                default:
                    redRect = resultData.talblock;
                    break;
            }
            widthUpDown.Value = redRect.Width;
            heightUpDown.Value = redRect.Height;
            screenImg.Invalidate();
            EndMoveRect();
        }

    }
}