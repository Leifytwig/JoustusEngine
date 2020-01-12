using System;

public class Arrow
{
    ArrowType _arrowType;

	public Arrow(ArrowType arrowType)
	{
        _arrowType = arrowType;
	}

    public ArrowType GetType()
    {
        return _arrowType;
    }

    public ArrowType SetType(ArrowType arrowType)
    {
        _arrowType = arrowType;
    }

    public static enum ArrowType
    {
        Single,
        Double,
        Triple,
        Bomb,
        Conveyor
    }
}
