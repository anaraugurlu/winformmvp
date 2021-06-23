using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winformmvp.Model;

namespace winformmvp.View
{
  public  interface IMainView
    {
        EventHandler <EventArgs> CheckedChangedLiter { get; set; }
        EventHandler <EventArgs> CheckedChangedAzn { get; set; }
        EventHandler <EventArgs> CalculateButtonClicked{ get; set; }
        EventHandler <EventArgs> SaveButtonClicked{ get; set; }
        EventHandler <EventArgs> LoadButtonClicked { get; set; }
        EventHandler<EventArgs> IndexChanged { get; set; }
        List<Petrol> Petrols { set; }
        List<Petrol> Payments { set; }
        string PriceText { get; set; }
        bool IsLiteer { get; set; }
        string LiterText { get; set; }
        string MoneyText { get; set; }
        string TotalText { get; set; }
        bool LiterEnable { get; set; }
        bool PriceEnable { get; set; }

       
    }
}
