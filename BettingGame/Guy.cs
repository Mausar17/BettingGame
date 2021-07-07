using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Guys
{
    class Guy
    {
        public string name = "";
        public int cashOnGuy = 0;
        /// <summary>
        /// Writes my name and the amount of cash I have to the console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine("My name is " + name + ". I have $" + cashOnGuy + ".");
        }
        /// <summary>
        /// Gives some of my cash, removing it from my wallet (or printing a message
        /// if I don't have enough cash).
        /// </summary>
        /// <param name="cashGiven"></param>
        /// <returns>The amount of cash removed from my wallet, or 0 if I don't
        /// have enough cash (or if the amount is invalid).</returns>
        public int GiveCash(int cashGiven)
        {
            if (cashGiven <= 0)
            {
                Console.WriteLine(name + " says: " + cashGiven + " isn't a valid amount.");
                return 0;
            }

            if (cashGiven > cashOnGuy)
            {
                Console.WriteLine(name + " says: I don't have enough enough cash to give you " + cashGiven);
                return 0;
            }
            cashOnGuy -= cashGiven;
            return cashGiven;
        }
        /// <summary>
        /// Receive some cash, adding it to my wallet (or printing
        /// a message to the console if the amount is invalid).
        /// </summary>
        /// <param name="cashReceived">Amount of cash to give. </param>
        public void ReceiveCash(int cashReceived)
        {
            if (cashReceived <= 0)
            {
                Console.WriteLine(name + " says: " + cashReceived + " isn't an amount I'll take...");
            }
            else
            {
                cashOnGuy += cashReceived;
            }
        }
    }
}
