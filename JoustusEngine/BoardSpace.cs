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
