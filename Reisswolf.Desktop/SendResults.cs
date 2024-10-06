using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reisswolf.Desktop
{
    public partial class SendResults : MetroForm
    {

        public SendResults(IList<string> successList, IList<string> failList)
        {
            InitializeComponent();

            if (successList != null)
            {
                foreach (var successItem in successList)
                {
                    successListView.Items.Add(new ListViewItem(successItem));
                }
            }

            if (failList != null)
            {
                foreach (var failItem in failList)
                {
                    failListView.Items.Add(new ListViewItem(failItem));
                }
            }
        }
    }
}
