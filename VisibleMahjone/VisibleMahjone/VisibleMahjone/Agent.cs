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

namespace VisibleMahjong {
    public class Agent {
        public Manager manager; // manager的引用，方便回调
        public List<Card> holdingCards;
        public List<Card> playedCards;
        public bool isDealer; // 庄家最先说话，并且在一开始多抓一张牌
        public int agentIndex;
        public Agent(int agentIndex, Manager manager) {
            this.manager = manager;
            holdingCards = new List<Card>();
            playedCards = new List<Card>();
            this.agentIndex = agentIndex;
        }
        
        public virtual void Paint() {
        }

        /// <summary>
        /// 让Agent抓一张牌。这张牌会添加到手牌中
        /// </summary>
        public void PickCard(Card c) {
            this.holdingCards.Add(c);
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
