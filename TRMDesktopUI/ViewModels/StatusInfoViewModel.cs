﻿using Caliburn.Micro;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class StatusInfoViewModel : Screen
    {
        public string Header { get; set; }
        public string Message { get; set; }

        public void UpdateMessage(string header, string message)
        {
            Header = header;
            Message = message;

            NotifyOfPropertyChange(() => Header);
            NotifyOfPropertyChange(() => Message);
        }

        public async Task Close()
        {
            await TryCloseAsync();
        }
    }
}
