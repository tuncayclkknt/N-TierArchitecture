using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities3 db = new EgitimKampiEFTravelDbEntities3();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.TblLocation.Count().ToString();
            lblSumCapacity.Text = db.TblLocation.Sum(x => x.LocationCapacity).ToString();
            lblGuideCount.Text = db.TblGuide.Count().ToString();
            lblAvarageCapacity.Text = db.TblLocation.Average(x => x.LocationCapacity).ToString();
            lblAvaragePrice.Text = String.Format("{0:0.00} TL",
               double.Parse(db.TblLocation.Average(x => x.LocationPrice).ToString()));

            int lastCountryId = db.TblLocation.Max(x => x.LocationId);
            lblLastAddedCountry.Text = db.TblLocation.Where(x => x.LocationId == lastCountryId).
                Select(y => y.LocationCountry).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.TblLocation.Where(x => x.LocationCity== "Cappadocia").
                Select(y => y.LocationCapacity).FirstOrDefault().ToString();

            lblAvgCapacityTurkey.Text = String.Format("{0:0.00}", double.Parse(db.TblLocation.Where(x => x.LocationCountry == "Türkiye").
                Average(y => y.LocationCapacity).ToString()));

            var romeGuideId = db.TblLocation.Where(x => x.LocationCity == "Roma touristik").
                Select(y => y.GuideId).FirstOrDefault();
            lblGuideNameRoma.Text = db.TblGuide.Where(x => x.GuideId == romeGuideId).
                Select(y => y.GuideName + "\n" + y.GuideSurname).FirstOrDefault();

            var maxCapacity = db.TblLocation.Max(x => x.LocationCapacity);
            lblMaxCapacityTour.Text = db.TblLocation.Where(x => x.LocationCapacity == maxCapacity).
                Select(y => y.LocationCity).FirstOrDefault().ToString();

            var maxPrice = db.TblLocation.Max(x => x.LocationPrice);
            lblMaxPrice.Text = db.TblLocation.Where(x => x.LocationPrice==maxPrice).
                Select(y => y.LocationCity).FirstOrDefault().ToString();

            var guideIdByNameZeynep = db.TblGuide.Where(x => x.GuideName== "Zeynep").
                Select(y => y.GuideId).FirstOrDefault();
            lblTourNumbersZeynep.Text = db.TblLocation.Where(x => x.GuideId == guideIdByNameZeynep).Count().ToString();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
