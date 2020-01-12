﻿using System;

namespace JoustusEngine
{
    public class Card
    {
        Arrow _topSide;
        Arrow _leftSide;
        Arrow _rightSide;
        Arrow _bottomSide;

        public Card()
        {
            _topSide = null;
            _leftSide = null;
            _rightSide = null;
            _bottomSide = null;
        }

        public Card(Arrow topSide, Arrow leftSide, Arrow rightSide, Arrow bottomSide)
        {
            _topSide = topSide;
            _leftSide = leftSide;
            _rightSide = rightSide;
            _bottomSide = bottomSide;
        }

        public Arrow GetTopArrow()
        {
            return _topSide;
        }

        public Arrow GetLeftArrow()
        {
            return _leftSide;
        }

        public Arrow GetRightArrow()
        {
            return _rightSide;
        }

        public Arrow GetBottomArrow()
        {
            return _bottomSide;
        }

        public void SetTopArrow(Arrow arrow)
        {
            _topSide = arrow;
        }

        public void SetLeftArrow(Arrow arrow)
        {
            _leftSide = arrow;
        }

        public void SetRightArrow(Arrow arrow)
        {
            _rightSide = arrow;
        }

        public void SetBottommArrow(Arrow arrow)
        {
            _bottomSide = arrow;
        }
    }
}