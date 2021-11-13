using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomizeCodeEvergyMonster {
    public partial class ShowNewCodes : Form {
        public ShowNewCodes() {
            InitializeComponent();
        }

        public ShowNewCodes(string[] codes):this() {
            foreach (string line in codes)
                TextBox.Text = TextBox.Text + $"{line}\r\n";
        }
    }
}
