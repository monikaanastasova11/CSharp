﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Contracts.Commands
{
    public class WriteCommand : ICommand
    {
        private ISession session;

        public WriteCommand(ISession session)
        {
            this.session = session;
        }

        public IMenu Execute( params string[] args)
        {
            ITextAreaMenu currentMenu = (ITextAreaMenu)this.session.CurrentMenu;
            currentMenu.TextArea.Write();
            return currentMenu; 
        }

        
    }
}
