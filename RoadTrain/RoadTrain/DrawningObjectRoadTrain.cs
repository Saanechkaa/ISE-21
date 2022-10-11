using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTrain
{
    internal class DrawningObjectRoadTrain : IDrawningObject
    {
        private DrawningRoadTrain _roadTrain = null;
        public DrawningObjectRoadTrain(DrawningRoadTrain roadTrain)
        {
            _roadTrain = roadTrain;
        }
        public float Step => _roadTrain?.RoadTrain?.Step ?? 0;
        public (float Left, float Top, float Right, float Bottom) GetCurrentPosition()
        {
            return _roadTrain?.GetCurrentPosition() ?? default;
        }
        public void MoveObject(Direction direction)
        {
            _roadTrain?.MoveTransport(direction);
        }
        public void SetObject(int x, int y, int width, int height)
        {
            _roadTrain.SetPosition(x, y, width, height);
        }
        public void DrawningObject(Graphics g)
        {
            _roadTrain.DrawTransport(g);
        }
    }
}
