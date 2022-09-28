using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadTrain
{
    public partial class FormRoadTrain : Form
    {
        private DrawningRoadTrain _RoadTrain;
        public FormRoadTrain()
        {
            InitializeComponent();
        }
      
        /// <summary>
        /// Метод прорисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new(pictureBoxRoadTrain.Width, pictureBoxRoadTrain.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _RoadTrain?.DrawTransport(gr);
            pictureBoxRoadTrain.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _RoadTrain = new DrawningRoadTrain();
            _RoadTrain.Init(rnd.Next(100, 300), rnd.Next(1000, 2000),
            Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            _RoadTrain.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100),
            pictureBoxRoadTrain.Width, pictureBoxRoadTrain.Height);
            toolStripStatusLabelSpeed.Text = $"Скорость: {_RoadTrain.RoadTrain.Speed}";
            toolStripStatusLabelWeight.Text = $"Вес: {_RoadTrain.RoadTrain.Weight}";
            toolStripStatusLabelBodyColor.Text = $"Цвет: {_RoadTrain.RoadTrain.BodyColor.Name}";
            Draw();
        }

        /// <summary>
        /// Изменение размеров формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    _RoadTrain?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    _RoadTrain?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    _RoadTrain?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    _RoadTrain?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        /// <summary>
        /// Изменение размеров формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxCar_Resize(object sender, EventArgs e)
        {
            _RoadTrain?.ChangeBorders(pictureBoxRoadTrain.Width, pictureBoxRoadTrain.Height);
            Draw();
        }

    }
}
