﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xna_Test.Artifacts.Physical.Entities
{
    public class Player : GameObject
    {

        public Player(Vector2 loc, Texture2D sprite) : base(ObjectId.ENTITY_PLAYER, "main:player", loc, sprite)
        {

        }
    }
}
