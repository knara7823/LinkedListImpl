using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace MyApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(85);
            linkedList.AddLast(33);
            linkedList.AddFirst(333);
            linkedList.AddLast(34133);
            linkedList.AddFirst(0);
            linkedList.AddFirst(4);
            linkedList.PrintNodes();

        }

    }
}