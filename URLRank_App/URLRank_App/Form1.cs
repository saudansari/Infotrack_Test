using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            rtb_ResultString.Font = new Font(rtb_ResultString.Font,FontStyle.Italic);
            rtb_ResultString.Text = "Searching....";
            try
            {
                InputValidation();

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
                    rtb_ResultString.Font = new Font(rtb_ResultString.Font, FontStyle.Regular);
                    if (rtb_ResultString.Text.Length == 0)
                        rtb_ResultString.Text = $"{x + 1}";
                    else
                        rtb_ResultString.Text += $", {x+1}";
                });
            }
            catch (Exception ex)
            {
                rtb_ResultString.Font = new Font(rtb_ResultString.Font, FontStyle.Italic);
                rtb_ResultString.Text = $"Input Validation Failed - \r\nReason:{ex.Message}";
                return;
            }

        }

        #region Helpers

        private bool InputValidation()
        {
            if (string.IsNullOrEmpty(tb_SearchString.Text))
                throw new Exception("Search string is null");

            if (tb_SearchString.Text.Any(x => !char.IsLetterOrDigit(x) && !char.IsWhiteSpace(x)))
                throw new Exception("Search string has special characters");

            if (string.IsNullOrEmpty(tb_URLString.Text))
                throw new Exception("URL String to match is empty");

            return true;
        }

        #endregion
    }
}
