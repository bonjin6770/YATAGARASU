using Microsoft.TeamFoundation.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatagarasu
{
    class AutoCompleteViewModel : ViewModelBase
    {
        private ObservableCollection<UserCommand> _userCommandSource;
        public ObservableCollection<UserCommand> UserCommandSource
        {
            get
            {

                if (DomainRegistory.IsNullCommandList())
                {
                    DomainRegistory.LoadCommandList();
                }

                if (_userCommandSource == null)
                {
                    _userCommandSource = DomainRegistory.CommandList.GetSource();
                }

                return _userCommandSource;
            }
        }
    }
}
