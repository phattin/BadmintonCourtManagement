using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class ProductFilterGUI : UserControl
    {
        public event Action<ProductFilterCriteria> FilterApplied;
        public ProductFilterGUI()
        {
            InitializeComponent();
            saveBtn.Click += saveBtn_Click;
            resetBtn.Click += resetBtn_Click;
        }

        public void InsertData(List<BrandDTO> brands, List<TypeProductDTO> types)
        {
            // AI Generated code
            brand_listBox.DataSource = brands?.ToList() ?? new List<BrandDTO>();
            brand_listBox.DisplayMember = nameof(BrandDTO.BrandName);
            brand_listBox.ValueMember = nameof(BrandDTO.BrandId);

            category_listBox.DataSource = types?.ToList() ?? new List<TypeProductDTO>();
            category_listBox.DisplayMember = nameof(TypeProductDTO.TypeProductName);
            category_listBox.ValueMember = nameof(TypeProductDTO.TypeProductId);
            // End of AI Generated code
        }

        private void Apply()
        {
            // Get all selected brands and types
            int checkedBrandCount = brand_listBox.CheckedItems.Count;
            int checkedItemCount = category_listBox.CheckedItems.Count;

            // if (checkedBrandCount == 0 && checkedItemCount == 0)
            // {
            //     FilterApplied?.Invoke(new ProductFilterCriteria());
            //     FindForm()?.Close();
            //     return;
            // }

            var selectedBrandIds = checkedBrandCount > 0
                ? brand_listBox.CheckedItems.Cast<BrandDTO>().Select(b => b.BrandId)
                : Enumerable.Empty<string>();

            var selectedTypeIds = checkedItemCount > 0
                ? category_listBox.CheckedItems.Cast<TypeProductDTO>().Select(t => t.TypeProductId)
                : Enumerable.Empty<string>();

            /*
            var selectedBrandItems = checkedBrandCount > 0
                ? brand_listBox.CheckedItems.Cast<BrandDTO>()
                : brand_listBox.Items.Cast<BrandDTO>();

            var selectedTypeItems = checkedItemCount > 0
                ? category_listBox.CheckedItems.Cast<TypeProductDTO>()
                : category_listBox.Items.Cast<TypeProductDTO>();

            var selectedBrandIds = selectedBrandItems
                .Select(b => b.BrandId.ToString())
                // .Where(s => !string.IsNullOrWhiteSpace(s))
                .Distinct();

            var selectedTypeIds = selectedTypeItems
                .Select(t => t.TypeProductId.ToString())
                // .Where(s => !string.IsNullOrWhiteSpace(s))
                .Distinct();
            */

            List<string> brandId = new List<string>();
            foreach (string b in selectedBrandIds)
            {
                brandId.Add($"'{b}'");
            }

            List<string> typeId = new List<string>();
            foreach (string b in selectedTypeIds)
            {
                typeId.Add($"'{b}'");
            }

            string brandIdString = string.Join(",", brandId);
            string typeIdString = string.Join(",", typeId);

            // MessageBox.Show("We are in ProductFilterGUI.cs");
            // MessageBox.Show(brandIdString);
            // MessageBox.Show(typeIdString);

            bool onlyStock = checkBox_onlyStock.Checked;

            FilterApplied?.Invoke(new ProductFilterCriteria
            {
                BrandIds = brandIdString,
                TypeIds = typeIdString
            });
            FindForm()?.Close();
        }

        private void ClearAndApply()
        {
            checkBox_onlyStock.Checked = false;

            for (int i = 0; i < brand_listBox.Items.Count; i++)
                brand_listBox.SetItemChecked(i, false);

            for (int i = 0; i < category_listBox.Items.Count; i++)
                category_listBox.SetItemChecked(i, false);

            FilterApplied?.Invoke(new ProductFilterCriteria());
            // FindForm()?.Close();
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Label btn = sender as Label;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Label btn = sender as Label;
            if (btn != null)
            {
                btn.BackColor = Color.Black;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearAndApply();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Apply();
            // Dispose(true);
        }
    }

    public class ProductFilterCriteria
    {
        public string BrandIds { get; set; } = "";
        public string TypeIds { get; set; } = "";
    }
}


/* using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class ProductFilterGUI : UserControl
    {

        // Expose one event with the current criteria
        public event Action<ProductFilterCriteria> FilterApplied;
        
	private ProductFilterCriteria CollectCriteria()
        {
            var selectedBrandIds = clbBrands.CheckedItems.Cast<object>()
                .Select(o => o is BrandDTO b ? b.BrandId : GetValueMember(clbBrands, o))
                .Where(id => !string.IsNullOrWhiteSpace(id))
                .Distinct()
                .ToList();

            var selectedTypeIds = clbTypes.CheckedItems.Cast<object>()
                .Select(o => o is TypeProductDTO t ? t.TypeProductId : GetValueMember(clbTypes, o))
                .Where(id => !string.IsNullOrWhiteSpace(id))
                .Distinct()
                .ToList();

            return new ProductFilterCriteria
            {
                BrandIds = selectedBrandIds,
                TypeIds = selectedTypeIds,
                InStockOnly = chkInStock.Checked
            };
        }

        private static string GetValueMember(CheckedListBox clb, object item)
        {
            var prop = clb.ValueMember;
            if (string.IsNullOrEmpty(prop)) return item?.ToString();
            var pi = item?.GetType().GetProperty(prop);
            return pi?.GetValue(item)?.ToString();
        }

        private void RaiseApply()
        {
            FilterApplied?.Invoke(CollectCriteria());
        }

        private void ClearAndApply()
        {
            chkInStock.Checked = false;

            for (int i = 0; i < clbBrands.Items.Count; i++)
                clbBrands.SetItemChecked(i, false);

            for (int i = 0; i < clbTypes.Items.Count; i++)
                clbTypes.SetItemChecked(i, false);

            RaiseApply();
        }
    }

    // Simple criteria object (no price for now)
    public class ProductFilterCriteria
    {
        public List<string> BrandIds { get; set; } = new();
        public List<string> TypeIds { get; set; } = new();
        public bool InStockOnly { get; set; }
    }
}

*/
