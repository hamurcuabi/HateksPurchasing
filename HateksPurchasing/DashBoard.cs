using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using System.Data.SqlClient;
using System.Configuration;
using HateksPurchasing.Helper;

namespace HateksPurchasing
{
    public partial class DashBoard : DevExpress.XtraEditors.XtraForm
    {
        public DashBoard()
        {
            InitializeComponent();
            PrepareData();
        }

        private void PrepareData()
        {
            SqlConnection con = SqlHelper.OpenConnection();
            SqlCommand cmd = SqlHelper.GetSqlCommand("select * from GetTotalPriceByDraft()", con);
            SqlDataReader dr = SqlHelper.GetSqlDataReader(cmd);
            while (dr.Read())
            {
                chart.Series["Departmanlar"].Points.Add(new SeriesPoint(dr["DraftTypeName"], dr["Total"]));
                //  PrepareCompanies(int.Parse(dr["DraftTypeId"].ToString()));
            }

            SqlHelper.CloseConnection(con);

            //Companies


            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Departmanların Harcamaları";
            chartTitle1.WordWrap = true;
            chart.Titles.Add(chartTitle1);

        }

        private void PrepareCompanies(int id)
        {


            SqlConnection con = SqlHelper.OpenConnection();
            SqlCommand cmd = SqlHelper.GetSqlCommand("select * from GetTotalPriceByCompany() where DraftTypeId=" + id, con);
            SqlDataReader dr = SqlHelper.GetSqlDataReader(cmd);
            while (dr.Read())
            {
                chart.Series["Tedarikçiler"].Points.Add(new SeriesPoint(dr["CompanyName"], dr["TotalPrice"]));
            }
            SqlHelper.CloseConnection(con);

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}