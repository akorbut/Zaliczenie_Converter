using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExchangeLesson
{
    public partial class Form1 : Form
    {
        private DataOperations _service = new DataOperations();
        public Form1()
        {
            InitializeComponent();
            UpdateLists(_service.HttpGet(null));
        }

        private void UpdateLists(JToken info)
        {
            from.Items.Clear();
            to.Items.Clear();
            foreach (var wallet in info)
            {
                if (double.Parse(wallet.ToString().Substring(6), CultureInfo.InvariantCulture) == 1.0)
                {
                    var id = from.Items.Add(wallet.ToString());
                    from.SelectedIndex = id;
                }
                else
                {
                    from.Items.Add(wallet.ToString());
                }
                to.Items.Add(wallet.ToString());

            }

            to.SelectedIndex = 0;
            Start.Text = from.SelectedItem.ToString().Substring(1, 3);
            End.Text = to.SelectedItem.ToString().Substring(1, 3);
        }

        private void FromComBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateLists(_service.HttpGet(from.SelectedItem.ToString().Substring(1, 3)));
            
        }

        private void SaveAsJson(object sender, EventArgs e)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(@"ExchangeResult.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, new
                {
                    BaseCurrency = from.SelectedItem.ToString().Substring(1, 3),
                    Amount = StartAmount.Text,
                    Currency = to.SelectedItem.ToString(),
                    ResultAmount = Result.Text +
                                   to.SelectedItem.ToString().Substring(1, 3)
                });
            }
        }

        private void ToComBox_SelectedValueChanged(object sender, EventArgs e)
        {
            End.Text = to.SelectedItem.ToString().Substring(1, 3);
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(StartAmount.Text, out var numResult)) return;
            var wallet = double.Parse(to.SelectedItem.ToString().Substring(6), CultureInfo.InvariantCulture);
            Result.Text = _service.Convert(wallet, numResult).ToString();
        }
    }
}
