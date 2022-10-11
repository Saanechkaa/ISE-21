﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTrain
{
    internal interface IDrawningObject
    {
        /// <summary>
        /// Шаг перемещения объекта
        /// </summary>
        public float Step { get; }
        /// <summary>
        /// Установка позиции объекта
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина полотна</param>
        /// <param name="height">Высота полотна</param>
        void SetObject(int x, int y, int width, int height);
        /// <summary>
        /// Изменение направления пермещения объекта
        /// </summary>
        /// <param name="direction">Направление</param>
        void MoveObject(Direction direction);
        /// <summary>
        /// Отрисовка объекта
        /// </summary>
        /// <param name="g"></param>
        void DrawningObject(Graphics g);
        /// <summary>
        /// Получение текущей позиции объекта
        /// </summary>
        /// <returns></returns>
        (float Left, float Top, float Right, float Bottom) GetCurrentPosition();

    }
}
