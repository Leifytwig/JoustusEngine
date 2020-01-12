using System;

namespace JoustusEngine
{
    public class Arrow
    {
        ArrowType _arrowType;

        public Arrow(ArrowType arrowType)
        {
            _arrowType = arrowType;
        }

        public ArrowType GetArrowType()
        {
            return _arrowType;
        }

        public void SetArrowType(ArrowType arrowType)
        {
            _arrowType = arrowType;
        }
    }

    public enum ArrowType
    {
        Single,
        Double,
        Triple,
        Bomb,
        Conveyor
    }
}
