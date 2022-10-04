using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTrain
{
    internal class DrawningRoadTrain
    {
        /// <summary>
        /// Класс-сущность
        /// </summary>
        public EntityRoadTrain RoadTrain { protected set; get; }
        /// <summary>
        /// Левая координата отрисовки грузовика
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Верхняя кооридната отрисовки грузовика
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int? _pictureWidth = null;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int? _pictureHeight = null;
        /// <summary>
        /// Ширина отрисовки грузовика
        /// </summary>
        private readonly int _RoadTrainWidth = 185;
        /// <summary>
        /// Высота отрисовки грузовика
        /// </summary>
        private readonly int _RoadTrainHeight = 155;
        public DrawningRoadTrain(int speed, float weight, Color bodyColor)
        {
            RoadTrain = new EntityRoadTrain(speed, weight, bodyColor);
        }
        /// <summary>
        /// Установка позиции грузовика
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            if (x < 0 || y < 0 || width < x + _pictureWidth || height < y + _pictureHeight)
            {
                _pictureHeight = null;
                _pictureWidth = null;
                return;
            }
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + _RoadTrainWidth + RoadTrain.Step < _pictureWidth)
                    {
                        _startPosX += RoadTrain.Step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX + _RoadTrainWidth - RoadTrain.Step > _RoadTrainWidth)
                    {
                        _startPosX -= RoadTrain.Step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY + _RoadTrainHeight - RoadTrain.Step > _RoadTrainHeight)
                    {
                        _startPosY -= RoadTrain.Step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + _RoadTrainHeight + RoadTrain.Step < _pictureHeight)
                    {
                        _startPosY += RoadTrain.Step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки автомобиля</param>
        /// <param name="carHeight">Высота отрисовки автомобиля</param>
        protected DrawningRoadTrain(int speed, float weight, Color bodyColor, int RoadTrainWidth, int RoadTrainHeight) :
        this(speed, weight, bodyColor)
        {
            _RoadTrainWidth = RoadTrainWidth;
            _RoadTrainHeight = RoadTrainHeight;
        }
       
        /// <summary>
        /// Отрисовка грузовика
        /// </summary>
        /// <param name="g"></param>
        public virtual void DrawTransport(Graphics g)
        {
            Brush mainColor = new SolidBrush(RoadTrain?.BodyColor ?? Color.Black);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.Blue);
            Pen pen = new Pen(Color.Black);
            g.FillRectangle(brBlack, _startPosX+15, _startPosY + 100, 185, 20); //Платформа
            g.DrawRectangle(pen, _startPosX+15, _startPosY + 100, 185, 20);   
            g.FillRectangle(mainColor, _startPosX + 125, _startPosY+10, 75, 90);//Кабина
            g.DrawRectangle(pen, _startPosX + 125, _startPosY+10,75, 90);
            g.FillRectangle(brBlue, _startPosX + 165, _startPosY + 30, 30, 50);//Окно
            g.DrawRectangle(pen, _startPosX + 165, _startPosY + 30, 30, 50);
            g.FillEllipse(brGray, _startPosX+15, _startPosY + 120, 40, 40);//Колёса
            g.DrawEllipse(pen, _startPosX+15, _startPosY + 120, 40, 40);
            g.FillEllipse(brBlack, _startPosX + 20, _startPosY + 125, 30, 30);
            g.FillEllipse(brGray, _startPosX + 60, _startPosY + 120, 40, 40);
            g.DrawEllipse(pen, _startPosX + 60, _startPosY + 120, 40, 40);
            g.FillEllipse(brBlack, _startPosX + 65, _startPosY + 125, 30, 30);
            g.FillEllipse(brGray, _startPosX + 155, _startPosY + 120, 40, 40);
            g.DrawEllipse(pen, _startPosX + 155, _startPosY + 120, 40, 40);
            g.FillEllipse(brBlack, _startPosX + 160, _startPosY + 125, 30, 30);
            
        }
        /// <summary>
        /// Смена границ формы отрисовки
        /// </summary>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_pictureWidth <= _RoadTrainWidth || _pictureHeight <= _RoadTrainHeight)
            {
                _pictureWidth = null;
                _pictureHeight = null;
                return;
            }
            if (_startPosX + _RoadTrainWidth > _pictureWidth)
            {
                _startPosX = _pictureWidth.Value - _RoadTrainWidth;
            }
            if (_startPosY + _RoadTrainHeight > _pictureHeight)
            {
                _startPosY = _pictureHeight.Value - _RoadTrainHeight;
            }
        }
        /// <summary>
        /// Получение текущей позиции объекта
        /// </summary>
        /// <returns></returns>
        public (float Left, float Top, float Right, float Bottom) GetCurrentPosition()
        {
            return (_startPosX, _startPosY, _startPosX + _RoadTrainWidth, _startPosY + _RoadTrainHeight);
        }
    }
}
