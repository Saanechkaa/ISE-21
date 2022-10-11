using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RoadTrain
{
    /// <summary>
    /// Класс, отвечающий за прорисовку и перемещение объекта-сущности
    /// </summary>
    internal class DrawningSweeperRoadTrain : DrawningRoadTrain
    {
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес грузовика</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="waterTank">Признак наличия водяного бака</param>
        /// <param name="sweepingBush">Признак наличия подметальной щётки</param>
        public DrawningSweeperRoadTrain(int speed, float weight, Color bodyColor, Color dopColor, bool waterTank, bool sweepingBush) :
        base(speed, weight, bodyColor, 285, 170)
        {
           RoadTrain = new EntitySweeperRoadTrain(speed, weight, bodyColor, dopColor, waterTank,
           sweepingBush);
        }
        public override void DrawTransport(Graphics g)
        {
            if (RoadTrain is not EntitySweeperRoadTrain SweeperRoadTrain)
            {
                return;
            }
            Pen pen = new(Color.Black);
            Brush dopBrush = new SolidBrush(SweeperRoadTrain.DopColor);
            Brush YellowBrush = new SolidBrush(Color.Yellow);
            if (SweeperRoadTrain.WaterTank)
            {
                g.FillRectangle(dopBrush, _startPosX + 20, _startPosY+20, 105, 80);
                g.DrawRectangle(pen, _startPosX + 20, _startPosY+20, 105, 80);
            }
            base.DrawTransport(g);
            if (SweeperRoadTrain.SweepingBush)
            {
                PointF[] handle = {
                    new PointF(_startPosX + 200, _startPosY + 100),
                    new PointF(_startPosX +245,  _startPosY + 105),
                    new PointF(_startPosX +265,  _startPosY + 130),
                    new PointF(_startPosX +240,  _startPosY + 130),
                    new PointF(_startPosX +235,  _startPosY + 120),
                    new PointF(_startPosX +200,  _startPosY + 120),
                    new PointF(_startPosX +200,  _startPosY + 105)
                };
            g.FillPolygon(dopBrush, handle);
            g.DrawPolygon(pen, handle);

            PointF[] holder = {
                    new PointF(_startPosX + 235, _startPosY + 130),
                    new PointF(_startPosX +285,  _startPosY + 130),
                    new PointF(_startPosX +290,  _startPosY + 140),
                    new PointF(_startPosX +225,  _startPosY + 140),
                    new PointF(_startPosX +235,  _startPosY + 130)
                };
            g.FillPolygon(dopBrush, holder);
            g.DrawPolygon(pen, holder);
            PointF[] sweep = {
                    new PointF(_startPosX + 225, _startPosY + 140),
                    new PointF(_startPosX +290,  _startPosY + 140),
                    new PointF(_startPosX +300,  _startPosY + 160),
                    new PointF(_startPosX +215,  _startPosY + 160),
                    new PointF(_startPosX +225,  _startPosY + 140)
                };
            g.FillPolygon(YellowBrush, sweep);
            g.DrawPolygon(pen, sweep);
            }
        }
        
    }
}
