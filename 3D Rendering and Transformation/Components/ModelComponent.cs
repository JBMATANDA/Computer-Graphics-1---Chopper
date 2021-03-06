﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Rendering_and_Transformation.Components
{
    public class ModelComponent : IComponent
    {
       
        public Model Model { get; set; }
        public Matrix ObjectWorld { get; set; }
        public Matrix[] BoneTransformations { get; set; }
        public float Angle;
        public ModelComponent()
        {
            ObjectWorld = Matrix.Identity;
            
        }
    }
}
