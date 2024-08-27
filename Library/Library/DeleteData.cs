using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal class DeleteData
    {
        public int ID;

        public DeleteData(int _Id)
        {
            this.ID = _Id;
        }

        public virtual void DeleteSelectedData()
        {
            MessageBox.Show("Delete Data");
        }
    }
}
