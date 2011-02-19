using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace Uglybird.Class
{
    class Actor
    {
        public Texture2D texture { get; set; }
        public Vector2 position { get; set; }
        public SpriteEffects effect { get; set; }
        public Vector2 origin { get; set; }
        public bool display { get; set; }
        public Vector2 target { get; set; }
        public Vector2 velocity { get; set; }

        Actor(String assit,ContentManager content)
        {
            texture = content.Load<Texture2D>(assit); 
            position    =   new Vector2(0,0);
            effect      =   SpriteEffects.None;   
            origin      =   new Vector2(0,0);
            display     =   false;
            target      =   new Vector2(0,0);
            velocity    =   new Vector2(0, 0);
        }
    }
}
