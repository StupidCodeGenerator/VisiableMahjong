using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VisibleMahjong {
    public class Utils {
        public static int GetRandomSeed() {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        /// <summary>
        /// The UpLimit is not included
        /// </summary>
        public static int GetRandomInt(int upLimit) {
            Random ra = new Random(GetRandomSeed());
            return ra.Next(upLimit);
        }
    }
}
