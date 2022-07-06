using AppNet.AppService;
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
    public partial class SelectProductFrm : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService ps;
        private readonly IStockService sts;
        public SelectProductFrm(IServiceProvider sp, IProductService ps, IStockService sts)
        {
            InitializeComponent();
            this.sp = sp;
            this.ps = ps;
            this.sts = sts;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void SelectProductFrm_Load(object sender, EventArgs e)
        {
            cbbSize.Items.Clear();
            cbbColor.Items.Clear();
            var frm = sp.GetRequiredService<AddSale>();
            txtProductName.Text = frm.grdProduct.CurrentRow.Cells[1].Value.ToString();
            var p = (await ps.GetAll()).ToList();
            var s=(await sts.GetAll()).ToList();
            var productList = (from q in p
                               join st in s
                               on q.ProductID equals st.ProductID
                               where q.ProductName.ToUpper() == (txtProductName.Text).ToUpper()
                               select new
                               {
                                   ProductID = q.ProductID,
                                   ProductName = q.ProductName,
                                   color = st.Color,
                                   size = st.Size,

                               }).ToList();
            
            foreach (var item in productList)
            {
                cbbColor.Items.Add(item.color);
                cbbSize.Items.Add(item.size);
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
