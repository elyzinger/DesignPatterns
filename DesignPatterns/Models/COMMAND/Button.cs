using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Command
{
    class Button
    {
        Command command;

        public Button(Command newCommand)
        {
            command = newCommand;
        }

        public void Press()
        {
            command.Execute();
        }
        public void UndoPress()
        {
            command.Undo();
        }


    }
}
