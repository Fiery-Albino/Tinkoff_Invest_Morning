using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tinkoff.Trading.OpenApi.Models;
using Tinkoff.Trading.OpenApi.Network;

namespace Tinkoff_Invest_Morning
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> TikersByFigi = new Dictionary<string, string>();
        List<string> accounts = new List<string>();

        IContext context = null;

        DataTable dt;
        Random Random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        void SetEmptyDT()
        {
            dt = new DataTable();
            dt.Columns.Add("Checked", typeof(bool));
            dt.Columns.Add("Tiker", typeof(string));
            dt.Columns.Add("Figi", typeof(string));
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("BuyQtty", typeof(int));
            dt.Columns.Add("BuyPrice", typeof(decimal));
            dt.Columns.Add("AvailablePrice", typeof(decimal));

            List<string> tikers = new List<string>() { "MOMO","MFGP","GSKY","PBF","COTY","PBI","ZYXI" };

            foreach (var tiker in tikers)
            {
                var r = dt.NewRow();
                r["Checked"] = false;
                r["Tiker"] = tiker;
                r["Figi"] = "";
                r["FullName"] = "";
                r["BuyQtty"] = 0;
                r["BuyPrice"] = 0;
                r["AvailablePrice"] = 0;
                dt.Rows.Add(r);
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            string success = "";
            string rejected = "";

            string acc = null;
            if (cbAccounts.SelectedIndex > -1)
                acc = accounts[cbAccounts.SelectedIndex];

            foreach(DataRow row in dt.Rows)
            {
                if ((bool)row["Checked"] && (decimal)row["AvailablePrice"] < (decimal)row["BuyPrice"])
                {
                    try
                    {
                        var r = context.PlaceLimitOrderAsync(new LimitOrder(row["Figi"].ToString()
                            , (int)row["BuyQtty"]
                            , OperationType.Buy
                            , (decimal)row["AvailablePrice"]
                            , acc)).Result;
                        if (r.Status == OrderStatus.Rejected)
                            rejected += row["Tiker"] + ",";
                        else
                            success += row["Tiker"] + ",";
                    }
                    catch
                    {
                        rejected += row["Tiker"] + ",";
                    }
                }
            }
            if (rejected.Length == 0 && success.Length > 0)
                MessageBox.Show("Все заявки успешно выставлены");
            else if (rejected.Length > 0 && success.Length == 0)
                MessageBox.Show("Не удалось выставить заявки", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show($"Заявки выставлены частично\n\nУспешные: {success}\n\nНеудачные: {rejected}", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
        }

        private  void btnUpdate_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        async void updateTable()
        {
            foreach (DataRow row in dt.Rows)
            {
                var insrt = (await context.MarketSearchByTickerAsync(row["Tiker"].ToString())).Instruments.First();
                if (row["FullName"].ToString() == "")
                {
                    row["FullName"] = insrt.Name;
                    row["Figi"] = insrt.Figi;
                    TikersByFigi.Add(insrt.Figi, insrt.Ticker);
                }
                try
                {
                    var ob = await context.MarketOrderbookAsync(insrt.Figi, 10);
                    row["AvailablePrice"] = ob.Asks.Min((a) => a.Price);
                }
                catch { }
            }
        }

        private void btnUpdateLimitOrders_Click(object sender, EventArgs e)
        {
            string acc = null;
            if (cbAccounts.SelectedIndex > -1)
                acc = accounts[cbAccounts.SelectedIndex];

            lbLimitOrders.Items.Clear();
            var orders = context.OrdersAsync(acc).Result;
            foreach (var order in orders)
            {
                
                lbLimitOrders.Items.Add((order.Operation == OperationType.Sell ? "Продажа " : "Покупка ")
                    + getTikerByFigi(order.Figi) + " - "
                    + order.ExecutedLots + "/" + order.RequestedLots + " - "
                    + order.Price + " - "
                    + order.Status);
            }
        }

        string getTikerByFigi(string figi)
        {
            if (TikersByFigi.ContainsKey(figi))
                return TikersByFigi[figi];
            else
                return context.MarketSearchByFigiAsync(figi).Result.Ticker;
        }

        private void bntSetToken_Click(object sender, EventArgs e)
        {
            // токен аутентификации
            var token = tbToken.Text;
            if (cbSandbox.Checked)
            {
                // для работы в песочнице используйте GetSandboxConnection
                var connection = ConnectionFactory.GetSandboxConnection(token);
                //var connection = ConnectionFactory.GetConnection(token);
                context = connection.Context;

                //(context as SandboxContext).SetCurrencyBalanceAsync(Currency.Rub, 100000);
                //(context as SandboxContext).SetCurrencyBalanceAsync(Currency.Usd, 100000);
            }
            else
            {
                // для работы в песочнице используйте GetSandboxConnection
                var connection = ConnectionFactory.GetConnection(token);
                //var connection = ConnectionFactory.GetConnection(token);
                context = connection.Context;
            }
            // вся работа происходит асинхронно через объект 
            SetEmptyDT();
            dataGridView1.DataSource = dt;


            cbAccounts.Items.Clear();
            try
            {           
                var port = context.PortfolioAsync().Result;
                
                var accs = context.AccountsAsync().Result;
                accounts.Clear();
                foreach (var acc in accs)
                {
                    var portCur = context.PortfolioCurrenciesAsync(acc.BrokerAccountId).Result;
                    accounts.Add(acc.BrokerAccountId);
                    string cur = "";
                    foreach(var _cur in portCur.Currencies)
                    {
                        cur += " | " + _cur.Currency + ": " + _cur.Balance;
                    }
                    cbAccounts.Items.Add(acc.BrokerAccountType.ToString() + cur);
                }
            }
            catch {
                MessageBox.Show("Ошибка","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
