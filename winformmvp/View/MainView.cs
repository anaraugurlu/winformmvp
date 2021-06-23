using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformmvp.Model;

namespace winformmvp.View
{
    public partial class MainView : Form,IMainView 
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> CheckedChangedLiter { get ; set ; }
        public EventHandler<EventArgs> ComboboxIndexChanged { get ; set ; }
        public EventHandler<EventArgs> CheckedChangedAzn { get ; set ; }
        public EventHandler<EventArgs> CalculateButtonClicked { get ; set; }
        public EventHandler<EventArgs> IndexChanged { get ; set; }
        public List<Petrol> Petrols { set { comboBox1.DataSource = null;
                comboBox1.DataSource = value;
            } }
        public List<Petrol> Payments
        {
            set
            {
                listBox1  .DataSource = null;
                listBox1  .DataSource = value;
            }
        }
        public string PriceText { get => pricelbl .Text ; set => pricelbl.Text =value; }
        public bool IsLiteer { get =>literrdbtn .Checked   ; set => literrdbtn .Checked =value; }
        public bool IsAzn { get =>aznrdbtn  .Checked   ; set => aznrdbtn  .Checked =value; }
        public string LiterText { get => litertxtb .Text ; set => litertxtb .Text =value; }
        public string MoneyText { get => aznttxtb .Text ; set => aznttxtb .Text =value; }
        public string TotalText { get => totallbl .Text ; set => totallbl.Text =value; }
        public bool LiterEnable { get => litertxtb .Enabled ; set => litertxtb.Enabled=value; }
        public bool PriceEnable { get => aznttxtb .Enabled ; set => aznttxtb.Enabled =value; }
        public EventHandler<EventArgs> SaveButtonClicked { get; set ; }
        public EventHandler<EventArgs> LoadButtonClicked { get ; set ; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void litertxtb_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedLiter.Invoke(sender,e);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            ComboboxIndexChanged.Invoke(sender, e);
            }
            catch (Exception)
            {
            }
        }

        private void aznrdbtn_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedAzn.Invoke(sender, e);
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            CalculateButtonClicked.Invoke(sender, e);
        }

        private void aznttxtb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            SaveButtonClicked.Invoke(sender, e);
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
          
            LoadButtonClicked.Invoke(sender, e);
        }
    }
}
