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

        public char RenderArrow()
        {
            switch (_arrowType) {
                case ArrowType.Single:
                    return 'S';
                case ArrowType.Double:
                    return 'D';
                case ArrowType.Triple:
                    return 'T';
                case ArrowType.Bomb:
                    return 'B';
                case ArrowType.Conveyor:
                    return 'C';
                default:
                    return '?';
            }
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
