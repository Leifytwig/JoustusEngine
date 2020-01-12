using System;

namespace JoustusEngine
{
    public class BoardSpace
    {
        SpaceType _spaceType;
        Card _card;
        bool _hasGem;

        public BoardSpace() : this(SpaceType.Open) { }

        public BoardSpace(SpaceType spaceType) : this(spaceType, false) { }

        public BoardSpace(SpaceType spaceType, bool hasGem) : this(spaceType, hasGem, null) { }

        public BoardSpace(SpaceType spaceType, bool hasGem, Card card)
        {
            _spaceType = spaceType;
            _hasGem = hasGem;
            _card = card;
        }

        public SpaceType GetSpaceType()
        {
            return _spaceType;
        }

        public bool GetHasGem()
        {
            return _hasGem;
        }

        public Card GetCard()
        {
            return _card;
        }

        public void SetSpaceType(SpaceType spaceType)
        {
            _spaceType = spaceType;
        }

        public void SetHasGem(bool hasGem)
        {
            _hasGem = hasGem;
        }

        public void SetCard(Card card)
        {
            _card = card;
        }

        public string RenderRow(int row)
        {
            if (_spaceType == SpaceType.Closed)
            {
                if (_hasGem && row == 2)
                {
                    return "X*X";
                }
                else
                {
                    return "XXX";
                }
            }
            else if (_spaceType == SpaceType.Grave)
            {
                if (_card != null)
                {
                    if (_hasGem && row == 1)
                    {
                        return _card.RenderRow(row).Substring(0, 1) + '*' + _card.RenderRow(row).Substring(2, 1);
                    }
                    else
                    {
                        return _card.RenderRow(row);
                    }
                }
                else if (_hasGem && row == 1)
                {
                    return "-*-";
                }
                else
                {
                    return "---";
                }
            }
            else if (_spaceType == SpaceType.Open)
            {
                if (_card != null)
                {
                    if (_hasGem && row == 1)
                    {
                        return _card.RenderRow(row).Substring(0, 1) + '*' + _card.RenderRow(row).Substring(2, 1);
                    }
                    else
                    {
                        return _card.RenderRow(row);
                    }
                }
                else
                {
                    if (_hasGem && row == 1)
                    {
                        return " * ";
                    }
                    else
                    {
                        return "   ";
                    }
                }
            }
            else
            {
                return "???";
            }
        }
    }

    public enum SpaceType
    {
        Open,
        Grave,
        Hole,
        HoleFilled,
        Rock,
        Closed
    }
}
