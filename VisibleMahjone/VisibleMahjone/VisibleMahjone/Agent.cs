/*
 * Agent.cs
 * 
 * 这是一个父类。游戏逻辑中出现了两种Agent。一种是AI，一种是人类。
 * 行为相关的返回，都通过回调，这样可以给人类玩家以反应时间
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace VisibleMahjong {

    public class Agent {
        public Manager manager; // manager的引用，方便回调
        public float leftX = int.MinValue;
        public float topY = int.MinValue;
        public List<Card> cards;
        /// <summary>
        /// 选择的是那一张牌
        /// 如果是碰，就选择碰的两张牌
        /// 如果是吃，唯一的情况下就选择唯一的两张，
        /// 如果不唯一，就点一次换一手
        /// </summary>
        public int choosedIndex = -1;
        // 如果是所有人都明牌的话，打出去的牌就没有任何意义。
        // 只要能显示出当前打出的这一张牌就可以了
        //public List<Card> playedCards;
        public bool isDealer; // 庄家最先说话，并且在一开始多抓一张牌
        public int agentIndex;
        public Agent(int agentIndex, Manager manager) {
            this.manager = manager;
            cards = new List<Card>();
            //playedCards = new List<Card>();
            this.agentIndex = agentIndex;
        }

        /// <summary>
        /// 根据AgentIndex区分绘制方向
        /// This is only a prototype so there's no need to manage them in 4 direction.
        /// All in all the UI will be re-designed if I will made more
        /// </summary>
        /// <param name="spriteBatch"></param>
        public virtual void Paint(SpriteBatch spriteBatch, float leftX, float topY) {
            this.leftX = leftX;
            this.topY = topY;
            for (int i = 0; i < cards.Count; i++) {
                if (i == choosedIndex) {
                    cards[i].Paint(spriteBatch, leftX + i * (Card.WIDTH + 1), topY - 5, 0f);
                } else {
                    cards[i].Paint(spriteBatch, leftX + i * (Card.WIDTH + 1), topY, 0f);
                }
            }
        }

        public virtual void OnClick(int x, int y) {
            this.choosedIndex = -1;
            if (y > topY && y < topY + Card.HEIGHT) {
                int index = (int)(x - leftX) / Card.WIDTH;
                if (index >= 0 && index < cards.Count) {
                    this.choosedIndex = index;
                }
            }
        }

        /// <summary>
        /// 让Agent抓一张牌。这张牌会添加到手牌中
        /// </summary>
        public void PickCard(Card c) {
            this.cards.Add(c);
        }

        /// <summary>
        /// 询问是否胡别人打出的这一张
        /// </summary>
        public virtual void AskForHu(Card targetCard) {
        }

        /// <summary>
        /// 是否自摸
        /// </summary>
        public virtual void AskForZiMo() {
        }

        public virtual void AskForAnGang() {
        }

        /// <summary>
        /// 询问是否碰，如果碰给出一个非空集合
        /// 如果给出Count==3的集合，表示杠
        /// 否则给出空集合
        /// </summary>
        public virtual void AskForPeng(Card targetCard) {
        }

        /// <summary>
        /// 询问是否吃，如果吃则给出一个非空集合，
        /// 否则给出空集合
        /// </summary>
        public virtual void AskForChi(Card targetCard) {
        }

        /// <summary>
        /// 要求Agent打出一张牌
        /// </summary>
        public virtual void AskForPlay() {
        }
    }
}
