using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformmvp.Data;
using winformmvp.Model;
using winformmvp.View;

namespace winformmvp.Presenter
{
    public class MainPresenter
    {
        private readonly PetrolContext _db;
        private IMainView _view;
        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.IndexChanged += ComboboxIndexChanged;
            _view.CheckedChangedLiter += LiterCheckedChanged;
            _view.CheckedChangedAzn += AznCheckedChanged;
            _view.CalculateButtonClicked += CalculateButtonClicked;
            _view.LoadButtonClicked += LoadButtonClicked;
            _view.SaveButtonClicked += SaveButtonClicked;
            //method subscribing
            _db = new PetrolContext();
            _db.Petrols.Add(new Model.Petrol { Name = "a343", Price = 3 });
            _db.Petrols.Add(new Model.Petrol { Name = "a343", Price = 3 });
            _db.Petrols.Add(new Model.Petrol { Name = "a343", Price = 3 });
            _db.SaveChanges();
            var list = _db.Petrols.ToList();
            _view.Petrols = list;

        }
        public string NameOfOil { get; set; }
        public void ComboboxIndexChanged(object sender, EventArgs e)
        {
            var item = (sender as ComboBox).SelectedItem;
            var petrol = item as Petrol;
            NameOfOil = petrol.Name;
            _view.PriceText = petrol.Price.ToString();
        }
        public void LoadButtonClicked(object sender, EventArgs e)
        {
            var list = _db.Payments.ToList();
           // _view.Payments = list;


        }
        public void SaveButtonClicked(object sender, EventArgs e)
            {

            //Payment payment = new Payment
            //{
              
            //   TotalPayment.= _view.TotalText  ,
              

            //};
            //_db.Payments.Add(payment);
            //_db.SaveChanges();
        }
        public void LiterCheckedChanged(object sender,EventArgs e)
        {
            var item =sender as RadioButton;
            if(item.Checked)
            {
                _view.LiterEnable = true;
                
            }
            else
            {
                _view.LiterEnable = false;
            }
        }
        public void AznCheckedChanged(object sender,EventArgs e)
        {
            var item = sender as RadioButton;
            if (item.Checked)
            {
                _view.PriceEnable = true;

            }
            else
            {
                _view.PriceEnable  = false;
            }
        }
        public void CalculateButtonClicked(object sender,EventArgs e)
        {
            if(_view.LiterEnable)
            {
                var money = double.Parse(_view.LiterText) * (double.Parse(_view.PriceText));
                _view.TotalText = money.ToString();
            }
            else
            {
                var money = double.Parse(_view.MoneyText) / (double.Parse(_view.PriceText));
                _view.LiterText = String .Empty ;
                var moneyfull = (int)money;
                _view.LiterText = moneyfull.ToString();
                _view.TotalText = _view.MoneyText;
            }

            Payment payment = new Payment
            {
                Liter = int.Parse(_view.LiterText),
                Oil = NameOfOil,
                TotalPayment = double.Parse(_view.TotalText)
            };
            _db.Payments.Add(payment);
            _db.SaveChanges();
            //calculate add
            //load listboxa databasani gondermek
        }
    }
}
