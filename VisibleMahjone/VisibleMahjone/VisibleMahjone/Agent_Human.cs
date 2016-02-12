/*
 * Agent_Human.cs
 * 
 * 表示人类玩家
 * 人类玩家的Ask没有回调，也就是不在程序里面直接响应。
 * 当人点击了某个按钮，Form1中会进行回调函数的调用，以达到人类操作的目的
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace VisibleMahjong {
    public class Agent_Human : Agent {
        public int choosedIndex = -1; // 当前玩家选中的牌的Index

        public Agent_Human(int agentIndex, Manager manager)
            : base(agentIndex, manager) {
        }

        /// <summary>
        /// 问：会不会有手里有3张但是只碰两张的情况出现？
        /// </summary>
        public void OnClick(int x, int y) {
            choosedIndex = -1;
            for (int i = 0; i < holdingCards.Count; i++) {
                Rectangle rec = new Rectangle(i * 34 + 10, 40, 33, 42);
                if (rec.Contains(new Point(x, y))) {
                    choosedIndex = i;
                }
            }
        }

        public override void AskForChi(Card targetCard) {
        }

        public override void AskForZiMo() {
        }

        public override void AskForHu(Card targetCard) {
        }

        public override void AskForPeng(Card targetCard) {
        }

        public override void AskForPlay() {
        }
    }
}
