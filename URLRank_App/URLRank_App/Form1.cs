using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URLRank_App.Models;

namespace URLRank_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tb_SearchString.Text = null;
            tb_URLString.Text = null;
            rtb_ResultString.Text = null;
        }

        private async void btn_Search_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
                return;

            rtb_ResultString.Text = "Searching....";

            var search_string = tb_SearchString.Text;
            var search_url = tb_URLString.Text;

            var searchobj = new GoogleSearchClient();
            var search_result = await searchobj.SearchGoogleAsync(search_string);

            var parser = new GoogleSearchParser();
            var listOfResults = parser.Search_ExtractClassR(search_result);

            var listofIndex = new List<int>();

            for(int x=0;x<listOfResults.Count;x++)
            {
                if (listOfResults[x].Contains(search_url))
                    listofIndex.Add(x);
            }


            rtb_ResultString.Text = string.Empty;
            listofIndex.ForEach(x =>
            {
                rtb_ResultString.Text += $"Position: {x+1}";
            });

        }

        #region Helpers

        private bool InputValidation()
        {
            return true;
        }

        #endregion
    }
}
