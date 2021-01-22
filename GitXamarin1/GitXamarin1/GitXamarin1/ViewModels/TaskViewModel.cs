using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GitXamarin1.ViewModels
{
    class TaskViewModel : BaseViewModel
    {
        #region Atributes
        public object listViewSource;
        #endregion

        #region Properties
        public object ListViewSource
        {
            get
            {
                return this.listViewSource;
            }
            set
            {
                SetValue(ref this.listViewSource, value);
            }
        }
        #endregion
        #region Methods
        public async Task LoadData()
        {
            this.ListViewSource = await App.Database.GetTaskModel();
        }
        #endregion

        #region Constructor
            public TaskViewModel()
        {
            LoadData();
        }
        #endregion
    }
}
