using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba4
{
    class main
    {
        public event EventHandler<StudentCollection> RaiseCustomEvent;

        static void Main(string[] args)
        {
            StudentCollection T = new StudentCollection();
            List<StudentCollection> First = new List<StudentCollection>();
            List<StudentCollection> Second = new List<StudentCollection>();
            Journal One = new Journal();
            Journal Two = new Journal();


            

            //One.StudentCountChanged();
            //One.ToString();

            //First.Add(new StudentCollection());

            ////StudentListHandlerEventArgs E = new StudentListHandlerEventArgs();
            ////TestCollections T = new TestCollections(3);
            for(int i = 0; i < 5; i++)
                T.AddDefaults(i);
            //    S.ToString();
    
            Console.ReadKey();
        }
    }
}
