using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace VisibleMahjong {
    public class SimpleButton {
        Texture2D texture;
        public int x, y;
        public bool isClicking = false;

        /// <summary>
        /// Because each button represents a logic,
        /// So the button can be only painted in one place.
        /// </summary>
        public SimpleButton(int x, int y, Texture2D texture) {
            this.x = x;
            this.y = y;
            this.texture = texture;
        }

        public void Paint(SpriteBatch spriteBatch) {
            if (isClicking) {
                spriteBatch.Draw(texture, new Vector2(x, y- 5), Color.White);
            } else {
                spriteBatch.Draw(texture, new Vector2(x, y), Color.White);
            }
            isClicking = false;
        }

        public bool OnClick(int mouseX, int mouseY) {
            Rectangle r = new Rectangle(x, y, texture.Width, texture.Height);
            if (r.Contains(mouseX, mouseY)) {
                isClicking = true;
                return true;
            } else {
                isClicking = false;
                return false;
            }
        }
    }
}
