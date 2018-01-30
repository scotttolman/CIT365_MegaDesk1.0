﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_scotttolman
{
    public class Desk
    {
        public enum material { oak, laminate, pine, rosewood, veneer };

        private float width;
        private float depth;
        private int drawers;
        private material surface;

        public Desk(float width, float depth, int drawers, material surface)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.surface = surface;
        }

        public float getWidth()
        {
            return width;
        }

        public void setWidth(float width)
        {
            if (width > 24 && width < 96)
                this.width = width;
        }

        public float getDepth()
        {
            return depth;
        }

        public void setDepth(float depth)
        {
            if (depth > 12 && depth < 48)
                this.depth = depth;
        }

        public int getDrawers()
        {
            return drawers;
        }

        public void setDrawers(int drawers)
        {
            if (drawers >= 0 && drawers < 8)
            {
                this.drawers = drawers;
            }
        }

        public material getSurface()
        {
            return surface;
        }

        public void setSurface(material _surface)
        {
            if (Enum.IsDefined(typeof(material), _surface))
            this.surface = _surface;
        }
    }
}
