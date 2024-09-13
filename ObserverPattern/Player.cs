using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player : IObserver
{
    public int Id => id;
    private int id;
    public void Reception(EventInfo info)
    {
        Console.WriteLine("이벤트 수신됨.");

        Console.WriteLine($"{id}번 유저가 수신한 이벤트\n제목 : {info.name}, 설명 : {info.description}");
    }

    public void SetID(int value)
    {
        id = value;
    }
}
