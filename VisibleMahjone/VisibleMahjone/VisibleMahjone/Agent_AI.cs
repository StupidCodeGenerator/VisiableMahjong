using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace VisibleMahjong {
    public class Agent_AI :Agent {

        public Agent_AI(int agentIndex, Manager manager):base(agentIndex, manager) { 
        }

        public override void AskForChi(Card targetCard) {
            manager.AskForChiCallback(null, this.agentIndex);
        }

        public override void AskForZiMo() {
            manager.AskForZiMoCallback(false, this.agentIndex);
        }

        public override void AskForAnGang() {
            manager.AskForAnGangCallback(null, this.agentIndex);
        }

        public override void AskForHu(Card targetCard) {
            manager.AskForDianPaoCallback(false, this.agentIndex);
        }

        public override void AskForPeng(Card targetCard) {
            manager.AskForPengCallback(null, this.agentIndex);
        }

        public override void AskForPlay() {
            manager.AskForPlayCallback(this.holdingCards[0], this.agentIndex);
        }
    }
}
