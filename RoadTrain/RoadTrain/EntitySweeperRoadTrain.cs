using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTrain
{
    /// <summary>
    /// Класс-сущность "Подметально-уборочная машина"
    /// </summary>
    internal class EntitySweeperRoadTrain : EntityRoadTrain
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { get; private set; }
        /// <summary>
        /// Признак наличия бака под воду
        /// </summary>
        public bool WaterTank { get; private set; }
        /// <summary>
        /// Признак наличия подметательной щётки
        /// </summary>
        public bool SweepingBush { get; private set; }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес грузовика</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="waterTank">Признак водяного бака</param>
        /// <param name="sweepingBush">Признак подметательной щётки</param>
        public EntitySweeperRoadTrain(int speed, float weight, Color bodyColor, Color
       dopColor, bool waterTank, bool sweepingBush) :
        base(speed, weight, bodyColor)
        {
            DopColor = dopColor;
            WaterTank = waterTank;
            SweepingBush = sweepingBush;
        }
    }
}
