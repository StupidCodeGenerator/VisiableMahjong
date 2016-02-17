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
        public Agent_Human(int agentIndex, Manager manager)
            : base(agentIndex, manager) {
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
