using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        EventInfoBuilder eventInfoBuilder = new EventInfoBuilder();
        
        EventInfo firstEventInfo = eventInfoBuilder
            .SetName("#1 이벤트")
            .SetDescription("테스트 이벤트입니다.")
            .Build();

        GameEvent newGameEvent = new GameEvent();

        for (int i = 0; i < 10 ; i++)
        {
            Player newPlayer = new Player();
            newPlayer.SetID(i);
            newGameEvent.Add(newPlayer);
        }

        newGameEvent.Notify(firstEventInfo);
    }
}