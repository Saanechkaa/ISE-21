﻿using System;
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
        public EntityRoadTrain RoadTrain { private set; get; }
        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Верхняя кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int? _pictureWidth = null;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int? _pictureHeight = null;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private readonly int _RoadTrainWidth = 335;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        private readonly int _RoadTrainHeight = 280;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="bodyColor">Цвет кузова</param>
        public void Init(int speed, float weight, Color bodyColor)
        {
            RoadTrain = new EntityRoadTrain();
            RoadTrain.Init(speed, weight, bodyColor);
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            // TODO проверки
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
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            



            Brush mainColor = new SolidBrush(RoadTrain?.BodyColor ?? Color.Black);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.Blue);
            Brush brYellow = new SolidBrush(Color.Yellow);
            Brush brBrown = new SolidBrush(Color.Brown);
            Pen pen = new Pen(Color.Black);
            g.FillRectangle(brBlack, _startPosX+30, _startPosY + 200, 305, 20); //Платформа
            g.DrawRectangle(pen, _startPosX+30, _startPosY + 200, 305, 20);
            g.FillRectangle(brGray, _startPosX+10, _startPosY, 200, 200); //Кузов
            g.DrawRectangle(pen, _startPosX+10, _startPosY, 200, 200);
            g.FillRectangle(mainColor, _startPosX + 210, _startPosY + 70, 120, 130);//Кабина
            g.DrawRectangle(pen, _startPosX + 210, _startPosY + 70, 120, 130);
            g.FillRectangle(brBlue, _startPosX + 250, _startPosY + 90, 70, 70);//Окно
            g.DrawRectangle(pen, _startPosX + 250, _startPosY + 90, 70, 70);
            g.FillEllipse(brGray, _startPosX + 30, _startPosY + 220, 60, 60);//Колёса
            g.DrawEllipse(pen, _startPosX + 30, _startPosY + 220, 60, 60);
            g.FillEllipse(brBlack, _startPosX + 40, _startPosY + 230, 40, 40);
            g.FillEllipse(brGray, _startPosX + 95, _startPosY + 220, 60, 60);
            g.DrawEllipse(pen, _startPosX + 95, _startPosY + 220, 60, 60);
            g.FillEllipse(brBlack, _startPosX + 105, _startPosY + 230, 40, 40);
            g.FillEllipse(brGray, _startPosX + 250, _startPosY + 220, 60, 60);
            g.DrawEllipse(pen, _startPosX + 250, _startPosY + 220, 60, 60);
            g.FillEllipse(brBlack, _startPosX + 260, _startPosY + 230, 40, 40);
            g.FillRectangle(brYellow, _startPosX + 300, _startPosY + 180, 30, 10);//Фары
            g.DrawRectangle(pen, _startPosX + 300, _startPosY + 180, 30, 10);
            g.FillRectangle(brBrown, _startPosX, _startPosY + 200, 30, 10);//Выхлопная труба
            g.DrawRectangle(pen, _startPosX, _startPosY + 200, 30, 10);
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
    }
}