﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public class Rectangle : Shape
    {
       public  int x, y, size, size1;
       public  int texturestyle;
        
       public  Brush bb;
       public  Color c1;

        /// <summary>
        /// this function will draw rectangle
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);
            if (texturestyle == 0)
            {
                g.DrawRectangle(p, x, y, size, size1);
            }
            else
            {
                g.FillRectangle(bb, x, y, size, size1);
            }
        }

        /// <summary>
        /// Setting the required properties for rectangle
        /// </summary>
        /// <param name="texturestyle"></param>
        /// <param name="bb"></param>
        /// <param name="c1"></param>
        /// <param name="list"></param>
  
