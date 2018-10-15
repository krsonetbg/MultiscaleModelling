using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModelling
{
    public class CellularAutomata
    {

        private Random rand;
        public CellularAutomata(){}


        public State grow(State previous_state)
        {
            Console.WriteLine("[CellularAutomata.cs] grow()");
            //current_state.updateState(current_state);

            //return current_state;
            State s = new State();
            return s;
        }


 
    }
}
