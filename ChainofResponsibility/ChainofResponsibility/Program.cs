using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerHandler mp4Player = new ConcreteHandlerMp4();
            PlayerHandler mpgplayer = new ConcreteHandlerMpg();
            PlayerHandler aviplayer = new ConcreteHandlerAvi();

            mp4Player.SonrakiHandler = mpgplayer;
            mpgplayer.SonrakiHandler = aviplayer;

            
            mp4Player.Play("video.mpg");
            mp4Player.Play("video.avi");
            mp4Player.Play("video.mp4");
            mp4Player.Play("video.swf");


            Console.ReadLine();

        }
    }
}
