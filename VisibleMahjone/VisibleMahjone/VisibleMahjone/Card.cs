/*
 *  Card.cs 
 *  
 *  Class of the mahjong cards
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace VisibleMahjong {
    /// <summary>
    /// nil means null
    /// </summary>
    public enum CardName {
        b1, b2, b3, b4, b5, b6, b7, b8, b9,
        t1, t2, t3, t4, t5, t6, t7, t8, t9,
        w1, w2, w3, w4, w5, w6, w7, w8, w9,
        dong, nan, xi, bei, zhong, fa, bai,
        nil
    }

    public class Card {

        public static int WIDTH = 33;
        public static int HEIGHT = 42;

        public static Texture2D cardTexture = null;

        public static Dictionary<CardName, Rectangle> MOJANG_RECT_DIC = new Dictionary<CardName, Rectangle>() {
            {CardName.b1, new Rectangle(0, 0,   33, 42)},
            {CardName.b2, new Rectangle(33, 0,  33, 42)},
            {CardName.b3, new Rectangle(66, 0,  33, 42)},
            {CardName.b4, new Rectangle(100, 0, 33, 42)},
            {CardName.b5, new Rectangle(133, 0, 33, 42)},
            {CardName.b6, new Rectangle(166, 0, 33, 42)},
            {CardName.b7, new Rectangle(200, 0, 33, 42)},
            {CardName.b8, new Rectangle(233, 0, 33, 42)},
            {CardName.b9, new Rectangle(266, 0, 33, 42)},
            {CardName.t1, new Rectangle(0,   42,   33, 42)},
            {CardName.t2, new Rectangle(33,  42,  33, 42)},
            {CardName.t3, new Rectangle(66,  42,  33, 42)},
            {CardName.t4, new Rectangle(100, 42, 33, 42)},
            {CardName.t5, new Rectangle(133, 42, 33, 42)},
            {CardName.t6, new Rectangle(166, 42, 33, 42)},
            {CardName.t7, new Rectangle(200, 42, 33, 42)},
            {CardName.t8, new Rectangle(233, 42, 33, 42)},
            {CardName.t9, new Rectangle(266, 42, 33, 42)},
            {CardName.w1, new Rectangle(0,   84,   33, 42)},
            {CardName.w2, new Rectangle(33,  84,  33, 42)},
            {CardName.w3, new Rectangle(66,  84,  33, 42)},
            {CardName.w4, new Rectangle(100, 84, 33, 42)},
            {CardName.w5, new Rectangle(133, 84, 33, 42)},
            {CardName.w6, new Rectangle(166, 84, 33, 42)},
            {CardName.w7, new Rectangle(200, 84, 33, 42)},
            {CardName.w8, new Rectangle(233, 84, 33, 42)},
            {CardName.w9, new Rectangle(266, 84, 33, 42)},
            {CardName.dong, new Rectangle(0,   126, 33, 42)},
            {CardName.nan, new Rectangle(33,   126, 33, 42)},
            {CardName.xi, new Rectangle(66,    126, 33, 42)},
            {CardName.bei, new Rectangle(100,  126, 33, 42)},
            {CardName.zhong, new Rectangle(133,126, 33, 42)},
            {CardName.fa, new Rectangle(166,   126, 33, 42)},
            {CardName.bai, new Rectangle(200,  126, 33, 42)},
        };

        public CardName name;


        public static void DrawCard(SpriteBatch spriteBatch, float x, float y, CardName name, float rotate) {
            Rectangle rect = MOJANG_RECT_DIC[name];
            spriteBatch.Draw(cardTexture, new Vector2(x, y), rect, Color.White, rotate,
                new Vector2(0f, 0f), 1f, SpriteEffects.None, 0f);
        }

        public void Paint(SpriteBatch spriteBatch, float x, float y, float rotate) {
            DrawCard(spriteBatch, x, y, name, rotate);
        }

        public Card(CardName name) {
            this.name = name;
        }

        public Card(int index) {
            this.name = (CardName)(index / 4);
        }
    }
}
