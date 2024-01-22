using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main()
        {
            Context context = new Context(new StateA());
            //программа будет работать в бесконечном цикле
            //сделать неограниченное колличество изменений состояний
            while (true)
            {
                context.Request();
            }
        }
    }
    abstract class State
    {
        public abstract void Handle(Context context);
    }
    class StateA : State
    {
        public override void Handle(Context context)
        {
            //Если был нажат пробел то переходит в состояние StateB
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                context.State = new StateB();
            }
        }
    }
    class StateB : State
    {
        public override void Handle(Context context)
        {
            //Если был нажат пробел то переходит в состояние StateA
            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                context.State = new StateA();
            }
        }
    }

    class Context
    {
        public State State { get; set; }
        public Context(State state)
        {
            this.State = state;
        }
        public void Request()
        {
            State.Handle(this);
            Console.WriteLine("Context: State is " + State.GetType().Name);
        }
    }
}
