using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RoadTrain
{
    internal abstract class AbstractMap
    {
        private IDrawningObject _drawningObject = null;
        protected int[,] _map = null;
        protected int _width;
        protected int _height;
        protected float _size_x;
        protected float _size_y;
        protected readonly Random _random = new();
        protected readonly int _freeRoad = 0;
        protected readonly int _barrier = 1;
        public Bitmap CreateMap(int width, int height, IDrawningObject drawningObject)
        {
            _width = width;
            _height = height;
            _drawningObject = drawningObject;
            GenerateMap();
            while (!SetObjectOnMap())
            {
                GenerateMap();
            }
            return DrawMapWithObject();
        }
        public bool CheckBarrier(float Left, float Right, float Top, float Bottom)
        {
            int startX = (int)(Left / _size_x);
            int startY = (int)(Right / _size_y);
            int endX = (int)(Top / _size_x);
            int endY = (int)(Bottom / _size_y);
            for (int i = startX; i<= endX; i++)
            {
                for (int j = startY; j<= endY; j++)
                {
                    if (_map[i, j] == _barrier)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public Bitmap MoveObject(Direction direction)
        {
            // TODO проверка, что объект может переместится в требуемом направлении
            _drawningObject.MoveObject(direction);
            (float Left, float Top, float Right, float Bottom) = _drawningObject.GetCurrentPosition();
            if (CheckBarrier(Left, Top, Right, Bottom))
            {
                _drawningObject.MoveObject(MoveObjectNew(direction));
            }
            return DrawMapWithObject();
        }
        private Direction MoveObjectNew(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    return Direction.Down;
                case Direction.Down:
                    return Direction.Up;
                case Direction.Left:
                    return Direction.Right;
                case Direction.Right:
                    return Direction.Left;
            }
            return Direction.None;
        }

        private bool SetObjectOnMap()
        {
            if (_drawningObject == null || _map == null)
            {
                return false;
            }
            int x = _random.Next(0, 10);
            int y = _random.Next(0, 10);
            _drawningObject.SetObject(x, y, _width, _height);
            (float Left, float Top, float Right, float Bottom) = _drawningObject.GetCurrentPosition();
            if (!CheckBarrier(Left, Top, Right, Bottom)) return true;
            return false;
        }
        private Bitmap DrawMapWithObject()
        {
            Bitmap bmp = new(_width, _height);
            if (_drawningObject == null || _map == null)
            {
                return bmp;
            }
            Graphics gr = Graphics.FromImage(bmp);
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    if (_map[i, j] == _freeRoad)
                    {
                        DrawRoadPart(gr, i, j);
                    }
                    else if (_map[i, j] == _barrier)
                    {
                        DrawBarrierPart(gr, i, j);
                    }
                }
            }
            _drawningObject.DrawningObject(gr);
            return bmp;
        }
        protected abstract void GenerateMap();
        protected abstract void DrawRoadPart(Graphics g, int i, int j);
        protected abstract void DrawBarrierPart(Graphics g, int i, int j);

    }
}
