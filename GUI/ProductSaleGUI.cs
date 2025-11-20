using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.BUS;
using System.Text.RegularExpressions;
using Mysqlx;
using System.Data;

namespace BadmintonCourtManagement.GUI
{
    public partial class ProductSaleGUI : UserControl
    {
        private List<ProductDTO> productList = new();
        private List<TypeProductDTO> typeList = new();
        private List<BrandDTO> brandList = new();

        private bool _isRowSelected = false;
        private int _selectedRowIndex = -1;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (dtv != null)
            {
                dtv.SelectionChanged += Dtv_SelectionChanged;
                dtv.CellClick += Dtv_CellClick_SelectRow;
                dtv.RowEnter += Dtv_RowEnter;
            }
        }

        private void Dtv_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectionFromDgv();
            UpdateProperty();
        }

        private void Dtv_CellClick_SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtv.Rows.Count)
                dtv.Rows[e.RowIndex].Selected = true;
            UpdateSelectionFromDgv();
            UpdateProperty();
        }

        private void Dtv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSelectionFromDgv();
        }

        private void UpdateSelectionFromDgv()
        {
            if (dtv.SelectedRows.Count > 0)
            {
                _isRowSelected = true;
                _selectedRowIndex = dtv.SelectedRows[0].Index;
            }
            else if (dtv.CurrentRow != null)
            {
                _isRowSelected = true;
                _selectedRowIndex = dtv.CurrentRow.Index;
            }
            else
            {
                _isRowSelected = false;
                _selectedRowIndex = -1;
            }
        }

        private void UpdateProperty()
        {
            if (!_isRowSelected)
            {
                return;
            }
            var row = dtv.Rows[_selectedRowIndex];
            if (row == null)
            {
                txt_productName.Text = string.Empty;
                return;
            }

            var cell = row.Cells["ProductName"] ?? row.Cells[0];
            txt_productName.Text = cell?.Value?.ToString() ?? string.Empty;
            cell = row.Cells["QuantityToBuy"] ?? row.Cells[4];
            txt_productQuantity.Text = cell?.Value?.ToString() ?? string.Empty;
        }

        public bool IsRowSelected() => _isRowSelected;
        public int SelectedRowIndex => _selectedRowIndex;
        public DataGridViewRow SelectedRow => (_selectedRowIndex >= 0 && _selectedRowIndex < dtv.Rows.Count) ? dtv.Rows[_selectedRowIndex] : null;

        public ProductSaleGUI(AccountDTO currentAccount)
        {
            InitializeComponent();
            SetupGrid();
            LoadInitialData();
            searchBar.KeyDown += searchEnterEvent;
            this.Resize += ProductSaleGUI_Resize;
        }

        private void LoadInitialData()
        {
            try
            {
                var productBus = new ProductBUS();
                var typeBus = new TypeProductBUS();
                var brandBus = new BrandBUS();
                productList = productBus.GetAllProducts();
                // bind the projected list (with names instead of ids) to the grid
                LoadProducts(productList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu sản phẩm: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Stub to render products into pSaleProductList.
        /// TODO: Replace with sale-specific card layout (price, quantity picker, add-to-bill button, stock color, etc.)
        /// </summary>
        private void LoadProducts(List<ProductDTO> list)
        {
            // pSaleProductList.SuspendLayout();
            // pSaleProductList.Controls.Clear();

            // pSaleProductList.ResumeLayout();
            var typeBus = new TypeProductBUS();
            var brandBus = new BrandBUS();
            typeList = typeBus.GetAllTypeProducts();
            brandList = brandBus.GetAllBrands();

            DataTable table = new DataTable();
            var displayList = productList
                .Select(p => new
                {
                    p.ProductName,
                    Brand = brandList.FirstOrDefault(b => b.BrandId == p.BrandId)?.BrandName ?? "hi",
                    Type = typeList.FirstOrDefault(t => t.TypeProductId == p.TypeId)?.TypeProductName ?? "bye",
                    QuantityToBuy = 0,
                    Price = 0
                })
                .OrderBy(x => x.QuantityToBuy) // use OrderByDescending(x => x.QuantityToBuy) for descending order
                .ThenBy(x => x.ProductName)
                .ToList();
            table.Columns.Clear();
            table.Columns.Add("ProductName", typeof(string));
            table.Columns.Add("Brand", typeof(string));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("QuantityToBuy", typeof(int));

            foreach (var item in displayList)
            {
                var price = Convert.ToDecimal(item.Price);
                var qty = Convert.ToInt32(item.QuantityToBuy);
                table.Rows.Add(item.ProductName, item.Brand, item.Type, price, qty);
            }

            table.DefaultView.Sort = "QuantityToBuy DESC, ProductName ASC";

            dtv.DataSource = table;
            // dtv.DataSource = displayList;
        }

        /// <summary>
        /// Temporary product row (text only) before implementing card UI.
        /// </summary>
        private Control CreatePlaceholderRow(ProductDTO dto)
        {
            var lbl = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Top,
                Padding = new Padding(8),
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                Text = $"{dto.ProductId} - {dto.ProductName} (SL: {dto.Quantity})",
                BackColor = Color.WhiteSmoke,
                Margin = new Padding(4)
            };
            // Later: replace with full panel containing image, quantity selection, etc.
            return lbl;
        }

        private void ReloadProductList()
        {
            var bus = new ProductBUS();
            productList = bus.GetAllProducts();
            LoadProducts(productList);
        }
        // Search
        private void searchEnterEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchProducts(searchBar.Text);
            }
        }

        private void SearchProducts(string keyword)
        {
            try
            {
                var bus = new ProductBUS();
                productList = bus.GetProductByName(keyword);
                LoadProducts(productList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message,
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void SetupGrid()
        {
            dtv.Columns.Clear();

            dtv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "ProductName",
                FillWeight = 26,
                ReadOnly = true,
                Width = 900
            });

            dtv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Brand",
                HeaderText = "Thương hiệu",
                DataPropertyName = "Brand",
                FillWeight = 16,
                ReadOnly = true,
                Width = 150
            });

            dtv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "Thể loại",
                DataPropertyName = "Type",
                FillWeight = 14,
                ReadOnly = true,
                Width = 160
            });

            dtv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Đơn giá",
                DataPropertyName = "Price",
                FillWeight = 12,
                ReadOnly = true,
                Width = 160,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N0" }
            });

            dtv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantityToBuy",
                HeaderText = "Số lượng mua",
                DataPropertyName = "QuantityToBuy",
                FillWeight = 10,
                ReadOnly = false,
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dtv.RowTemplate.Height += 10;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            searchBar.Clear();
            ReloadProductList();
        }

        // Filter open dialog (reuse existing filter form if needed)
        private void filterButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement brand/type filter for sale context if required.
            MessageBox.Show("Filter chức năng sẽ được thêm sau.");
        }

        private void filterButton_MouseEnter(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.FromArgb(0, 142, 123);
        }

        private void filterButton_MouseLeave(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.FromArgb(0, 120, 103);
        }

        // Add / Sell Product click
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // TODO: Implement sale dialog (select products, quantities, create bill).
            MessageBox.Show("Chức năng bán hàng sẽ được phát triển.");
        }

        // Resize: later adapt number of columns or hide image (when implemented).
        private void ProductSaleGUI_Resize(object sender, EventArgs e)
        {
            // Placeholder for future responsive adjustments.
        }

        private void txt_productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_productQuantity_Click(object sender, EventArgs e)
        {

        }

        private void txt_productQuantity_TextChanged(object sender, EventArgs e)
        {
            // basic numeric validation
            if (string.IsNullOrWhiteSpace(txt_productQuantity.Text))
            {
                errorProvider1.SetError(txt_productQuantity, "");
                return;
            }

            if (!int.TryParse(txt_productQuantity.Text.Trim(), out var inputQty))
            {
                errorProvider1.SetError(txt_productQuantity, "Số lượng sản phẩm phải là số nguyên.");
                return;
            }

            if (inputQty < 0)
            {
                errorProvider1.SetError(txt_productQuantity, "Số lượng không được âm.");
                return;
            }

            // try to find the corresponding product by name (txt_productName is updated when a row is selected)
            var productName = txt_productName.Text?.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                // no product selected / name unknown -> just clear error (or you could set an error)
                errorProvider1.SetError(txt_productQuantity, "");
                return;
            }

            var product = productList.FirstOrDefault(p => string.Equals(p.ProductName, productName, StringComparison.OrdinalIgnoreCase));
            if (product == null)
            {
                // product not found in the loaded list
                errorProvider1.SetError(txt_productQuantity, "Sản phẩm chưa được chọn hoặc không tồn tại.");
                return;
            }

            // compare entered quantity with actual stock
            if (inputQty > product.Quantity)
            {
                errorProvider1.SetError(txt_productQuantity, $"Số lượng vượt quá tồn kho ({product.Quantity}).");
            }
            else
            {
                errorProvider1.SetError(txt_productQuantity, "");
                var row = dtv.Rows[_selectedRowIndex];
                if (row == null)
                {
                    txt_productName.Text = string.Empty;
                    return;
                }
                row.Cells["QuantityToBuy"].Value = inputQty;
            }
        }
    }
}