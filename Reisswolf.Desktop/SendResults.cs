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

        public SendResults(IList<string> successList, Dictionary<string, string> failList)
        {
            InitializeComponent();

            foreach (var successItem in successList)
            {
                successListView.Items.Add(new ListViewItem(successItem));
            }

            foreach (var failItem in failList)
            {
                failListView.Items.Add(new ListViewItem(new[] {failItem.Key, failItem.Value}));
            }
        }
    }
}
