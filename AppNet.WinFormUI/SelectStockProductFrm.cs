using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNet.WinFormUI
{
    public partial class SelectStockProductFrm : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService ps;
        private readonly IStockService sts;
        public SelectStockProductFrm(IServiceProvider sp, IProductService ps, IStockService sts)
        {
            InitializeComponent();
            this.sp = sp;
            this.ps = ps;
            this.sts = sts;
        }

        private async void SelectStockProductFrm_Load(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddStock>();
            txtProductName.Text = frm.grdProduct.CurrentRow.Cells[1].Value.ToString();
            var p = (await ps.GetAll()).ToList();
            var s = (await sts.GetAll()).ToList();
            var productList = (from q in p
                               join st in s
                               on q.ProductID equals st.ProductID
                               where ProductName.ToUpper() == (txtProductName.Text).ToUpper()
                               select new
                               {
                                   ProductID = q.ProductID,
                                   ProductName = q.ProductName,

                               }).ToList();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
