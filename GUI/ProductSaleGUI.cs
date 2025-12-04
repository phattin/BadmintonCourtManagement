using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using Mysqlx;
using Mysqlx.Crud;
using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class ProductSaleGUI : UserControl
    {
        private List<ProductDTO> productList = new();
        private List<TypeProductDTO> typeList = new();
        private List<BrandDTO> brandList = new();
        private List<StorageDTO> storageList = new();
        private Dictionary<string, int> _cart = new(); // ProductId -> QuantityToBuy

        private bool _isRowSelected = false;
        private int _selectedRowIndex = -1;
        private AccountDTO acc;
        private bool isInsert = false;

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
            acc = currentAccount;
            CheckPermissions("F03");
            SetupGrid();
            LoadInitialData();
            searchBar.KeyDown += searchEnterEvent;
            this.Resize += ProductSaleGUI_Resize;
        }

        private void CheckPermissions(string functionId)
        {
            PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
            
            if (permissiondetailBUS == null)
            {
                MessageBox.Show("PermissionDetailBUS is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<PermissionDetailDTO> permissionDetails = permissiondetailBUS.GetPermissionDetailsByFunctionId(functionId);
            if (permissionDetails == null)
            {
                MessageBox.Show("No permissions found for the given function ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (acc == null)
            {
                MessageBox.Show("Account information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var p in permissionDetails)
            {
                if (p.PermissionId == acc.PermissionId)
                {
                    if (p.Option == "Insert") isInsert = true;
                }
            }

            btnAddInvoice.Visible = isInsert;
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
        private void LoadProducts(List<ProductDTO> list)
        {
            // pSaleProductList.SuspendLayout();
            // pSaleProductList.Controls.Clear();

            // pSaleProductList.ResumeLayout();
            var typeBus = new TypeProductBUS();
            var brandBus = new BrandBUS();
            var billImportDetailBus = new BillImportDetailBUS();
            typeList = typeBus.GetAllTypeProducts();
            brandList = brandBus.GetAllBrands();
            storageList = StorageBUS.GetAllStorages();

            DataTable table = new DataTable();
            var displayList = productList
                .Select(p => new
                {
                    p.ProductName,
                    Brand = brandList.FirstOrDefault(b => b.BrandId == p.BrandId)?.BrandName ?? "hi",
                    Type = typeList.FirstOrDefault(t => t.TypeProductId == p.TypeId)?.TypeProductName ?? "bye",
                    ProductQuantity = p.Quantity,
                    StockQuantity = storageList.First(ob => ob.ProductId == p.ProductId && ob.Status == StorageDTO.Option.active)
                                .Quantity, //  to show available stock
                    Price = storageList.Where(ob => ob.ProductId == p.ProductId && ob.Status == StorageDTO.Option.active)
                                // .OrderByDescending(ob => ob.ImportBillDetailId)
                                .Select(ob => ob.Price)
                                .FirstOrDefault(),
                    QuantityToBuy = _cart.ContainsKey(p.ProductId) ? _cart[p.ProductId] : 0
                })
                .OrderBy(x => x.QuantityToBuy) // use OrderByDescending(x => x.QuantityToBuy) for descending order
                .ThenBy(x => x.ProductName)
                .ToList();
            table.Columns.Clear();
            table.Columns.Add("ProductName", typeof(string));
            table.Columns.Add("Brand", typeof(string));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("ProductQuantity", typeof(decimal));
            table.Columns.Add("StockQuantity", typeof(decimal));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("QuantityToBuy", typeof(int));

            foreach (var item in displayList)
            {
                var price = Convert.ToDecimal(item.Price);
                var qty = Convert.ToInt32(item.QuantityToBuy);
                var productQty = Convert.ToDecimal(item.ProductQuantity);
                var stockQty = Convert.ToDecimal(item.StockQuantity);
                table.Rows.Add(item.ProductName, item.Brand, item.Type, item.ProductQuantity, stockQty, price, qty);
            }

            table.DefaultView.Sort = "QuantityToBuy DESC, ProductName ASC";

            dtv.DataSource = table;
            // dtv.DataSource = displayList;
        }

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
            dtv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtv.AllowUserToResizeColumns = false;
            dtv.AllowUserToResizeRows = false;
            dtv.RowTemplate.Height = 45;
            dtv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtv.MultiSelect = false;

            // Thêm các cột với tỷ lệ đẹp (tổng = 100)
            var colName = new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "Tên Sản Phẩm",
                DataPropertyName = "ProductName",
                FillWeight = 35,        // Rộng nhất
                ReadOnly = true
            };

            var colBrand = new DataGridViewTextBoxColumn
            {
                Name = "Brand",
                HeaderText = "Thương Hiệu",
                DataPropertyName = "Brand",
                FillWeight = 15,
                ReadOnly = true
            };

            var colType = new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "Loại",
                DataPropertyName = "Type",
                FillWeight = 15,
                ReadOnly = true
            };

            var colPrice = new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Đơn Giá",
                DataPropertyName = "Price",
                FillWeight = 10,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "N0"  // 1,234,567 ₫
                }
            };

            var colQtyToBuy = new DataGridViewTextBoxColumn
            {
                Name = "QuantityToBuy",
                HeaderText = "SL Mua",
                DataPropertyName = "QuantityToBuy",
                FillWeight = 9,
                ReadOnly = false,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.DarkBlue
                }
            };

            var colStockQty = new DataGridViewTextBoxColumn
            {
                Name = "StockQuantity",
                HeaderText = "Tồn kho",
                DataPropertyName = "StockQuantity",
                FillWeight = 8,
                ReadOnly = false,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.DarkBlue
                }
            };

            var colQty = new DataGridViewTextBoxColumn
            {
                Name = "ProductQuantity",
                HeaderText = "SL Sản Phẩm",
                DataPropertyName = "ProductQuantity",
                FillWeight = 14,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.DarkBlue
                }
            };

            dtv.Columns.AddRange(colName, colBrand, colType, colQty, colStockQty, colPrice, colQtyToBuy);

            // Làm đẹp header
            dtv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 103);
            dtv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtv.EnableHeadersVisualStyles = false;

            // helper to apply quantity change for a specific row
            Action<DataGridViewRow, int> applyQtyToRow = (row, qty) =>
            {
                var cell = row.Cells["QuantityToBuy"];
                var stockQtyCell = row.Cells["StockQuantity"];
                var productNameCell = row.Cells["ProductName"];

                if (qty < 0)
                {
                    cell.Value = 0;
                    return;
                }

                var product = productList.FirstOrDefault(p =>
                    string.Equals(p.ProductName, productNameCell.Value?.ToString(), StringComparison.OrdinalIgnoreCase));

                if (product == null)
                {
                    MessageBox.Show("Sản phẩm không tồn tại trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cell.Value = 0;
                    return;
                }

                var stock = 0;
                int.TryParse(stockQtyCell.Value?.ToString(), out stock);

                if (qty > Convert.ToInt32(product.Quantity))
                {
                    MessageBox.Show($"Chỉ còn {product.Quantity} sản phẩm trong kho!", "Vượt tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cell.Value = _cart.ContainsKey(product.ProductId) ? _cart[product.ProductId] : 0;
                }
                else if (qty > stock)
                {
                    var storages = StorageBUS.GetAllStorages();
                    var productStorage = storages.Where(ob => ob.ProductId == product.ProductId && ob.Status == StorageDTO.Option.active).ToList();
                    string storageInfo = productStorage.Any()
                        ? string.Join("\n", productStorage.Select(ob => $"- Giá: {ob.Price}, SL: {ob.Quantity}"))
                        : "Không có lô hàng khả dụng.";
                    var firstPrice = productStorage.Any() ? productStorage[0].Price.ToString() : "N/A";
                    var result = MessageBox.Show($"Chỉ còn {stock} sản phẩm trong lô có giá {firstPrice}!\n\nCác lô đang có trong hệ thống:\n{storageInfo}\n\nBạn có chắc muốn mua sản phẩm của lô khác chứ?", "Vượt tồn kho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _cart[product.ProductId] = qty;
                        cell.Value = qty;
                        // updateTotalPrice(productList); // ERROR
                    }
                    else
                    {
                        cell.Value = 0;
                        _cart.Remove(product.ProductId);
                    }
                }
                else
                {
                    if (qty == 0)
                        _cart.Remove(product.ProductId);
                    else
                        _cart[product.ProductId] = qty;

                    cell.Value = qty;
                }
                updateTotalPrice(productList);
            };

            // Bắt sự kiện khi người dùng sửa trực tiếp số lượng trên grid
            // dtv.CellEndEdit += (s, e) =>
            // {
            //     if (e.ColumnIndex == dtv.Columns["QuantityToBuy"].Index && e.RowIndex >= 0)
            //     {
            //         var cell = dtv.Rows[e.RowIndex].Cells["QuantityToBuy"];
            //         if (int.TryParse(cell.Value?.ToString(), out int qty))
            //         {
            //             var row = dtv.Rows[e.RowIndex];
            //             applyQtyToRow(row, qty);
            //         }
            //         else
            //         {
            //             dtv.Rows[e.RowIndex].Cells["QuantityToBuy"].Value = 0;
            //         }
                    
            //         updateTotalPrice();
            //     }
            // };

            // Cập nhật tổng tiền khi click vào dòng bất kỳ
            // dtv.SelectionChanged += (s, e) => updateTotalPrice(); // TODO

            // Khi người dùng thay đổi số lượng từ textbox bên ngoài, áp dụng lên dòng đang chọn
            txt_productQuantity.TextChanged += (s, e) =>
            {
                if (!IsRowSelected()) return;
                var row = SelectedRow;
                if (row == null) return;

                if (string.IsNullOrWhiteSpace(txt_productQuantity.Text))
                {
                    // clear selection quantity
                    row.Cells["QuantityToBuy"].Value = 0;
                    updateTotalPrice(productList);
                    return;
                }

                if (int.TryParse(txt_productQuantity.Text.Trim(), out int qty))
                {
                    applyQtyToRow(row, qty);
                }
                else
                {
                    row.Cells["QuantityToBuy"].Value = 0;
                }

                updateTotalPrice(productList);
            };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            searchBar.Clear();
            ReloadProductList();
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
            // Build confirmation summary from _cart
            var selectedItems = _cart.Where(kv => kv.Value > 0).ToList();
            if (!selectedItems.Any())
            {
                MessageBox.Show("Chưa chọn sản phẩm nào để bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (getPrice(txt_totalPrice.Text) > getPrice(txt_priceCustomerPay.Text))
            {
                MessageBox.Show("Khách hàng chưa trả đủ số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var confirm = MessageBox.Show("Bạn có chắc chứ?", "Xác nhận đơn hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                createBill(selectedItems);
                MessageBox.Show("Đã xác nhận đơn hàng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // clear cart and reset UI
                _cart.Clear();
                ReloadProductList();
                txt_totalPrice.Text = "0";
                txt_priceCustomerPay.Text = "";
                txt_priceExchange.Text = "";
            }
        }

        private void createBill(List<KeyValuePair<string, int>> selectedItems)
        {
            ProductBUS product_bus = new ProductBUS();
            BillProductBUS bill_bus = new BillProductBUS();
            BillProductDetailBUS bill_detail_bus = new BillProductDetailBUS();
            StorageBUS storageBus = new StorageBUS();
            var selectedIds = selectedItems.Select(kv => kv.Key).ToHashSet();
            List<ProductDTO> productList = new List<ProductDTO>();
            foreach (string id in selectedIds)
            {
                productList.Add(product_bus.GetProductById(id));
            }

            // bill product
            string billId = bill_bus.GetMaxId();
            EmployeeBUS empBus = new EmployeeBUS();
            var employee = empBus.GetEmployeeByUsername(acc.Username);
            if (employee == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên tương ứng với tài khoản này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string employeeId = employee.EmployeeId;
            double totalPrice = double.Parse(txt_totalPrice.Text);

            if (string.IsNullOrWhiteSpace(billId))
            {
                billId = "BP00001";
            }
            else
            {
                var match = Regex.Match(billId, @"^([A-Za-z]*)(\d+)$");
                if (match.Success)
                {
                    var prefix = match.Groups[1].Value;
                    var numberPart = match.Groups[2].Value;
                    if (int.TryParse(numberPart, out var number))
                    {
                        number++;
                        billId = prefix + number.ToString().PadLeft(numberPart.Length, '0');
                    }
                }
            }

            // inserting bill product 
            BillProductDTO product = new BillProductDTO(billId, employeeId, totalPrice);
            bill_bus.InsertProductBill(product);

            // inserting bill product detail
            foreach (ProductDTO p in productList)
            {
                // get the quantity for this product id from the selectedItems list
                var qty = selectedItems.First(kv => kv.Key == p.ProductId).Value;
                if (qty <= 0) continue;
                StorageDTO storageOb = new StorageDTO();
                storageOb = storageList.First(ob => ob.ProductId == p.ProductId);
                BillProductDetailDTO bill_detail = new BillProductDetailDTO(billId, p.ProductId, qty, storageOb.Price, totalPrice);
                bill_detail_bus.InsertBillProductDetail(bill_detail);
            }

            // updating product quantity
            foreach (ProductDTO p in productList)
            {
                var qty = selectedItems.First(kv => kv.Key == p.ProductId).Value;
                p.Quantity -= qty;
                product_bus.UpdateProduct(p);
            }

            foreach (StorageDTO ob in storageList)
            {
                var qty = selectedItems.FirstOrDefault(kv => kv.Key == ob.ProductId).Value;
                ob.Quantity -= qty;
                StorageBUS.UpdateStorage(ob);
            }
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
                _cart[product.ProductId] = inputQty;
                updateTotalPrice(productList);
            }
        }
        /*
            Todolist:
            - Fix error totalPrice not being updated if customer confirm to buy products from different stocks
            - update quantity in productDTO and storageDTO(s) also
            - if storageDTO have quantity == 0 => inactive (optional)
        */

        private void updateTotalPrice(List<ProductDTO> productList) // Not updating totalPrice when customer confirm to buy products from different stock
        {
            var storageList = StorageBUS.GetAllStorages();
            ProductBUS productBus = new();
            int rowCount = dtv.RowCount;
            decimal totalPrice = 0m;
            for (int i = 0; i < rowCount; i++)
            {
                var qtyObj = dtv.Rows[i].Cells["QuantityToBuy"].Value;
                var priceObj = dtv.Rows[i].Cells["Price"].Value;
                var product = productList.FirstOrDefault(p =>
                    string.Equals(p.ProductName, dtv.Rows[i].Cells["ProductName"].Value?.ToString(), StringComparison.OrdinalIgnoreCase));
                var productIdObj = product.ProductId;

                var storageProduct = storageList
                .Where(ob => ob.ProductId == productIdObj && ob.Status == StorageDTO.Option.active)
                .ToList();

                int qty = 0;
                long price = 0;

                if (qtyObj != null && int.TryParse(qtyObj.ToString(), out var q))
                    qty = q;

                if (qty <= storageProduct[0].Quantity && priceObj != null && long.TryParse(priceObj.ToString(), out var p))
                {
                    price = p;
                    totalPrice += qty * price;
                }
                else
                {
                    // if quantity exceeds stock, use available stock quantity for total price calculation
                    int j = 0;
                    do
                    {    
                        int availableQty = storageProduct[j].Quantity;
                        while (availableQty > 0 && qty > 0)
                        {
                            totalPrice += availableQty * price;
                            qty--;
                            availableQty--;    
                        }
                        j++;
                    } while (qty > 0 && j < storageProduct.Count);
                }
            }
            txt_totalPrice.Text = totalPrice.ToString();            
        }

        private long getPrice(string price)
        {
            // basic numeric validation
            if (string.IsNullOrWhiteSpace(price))
            {
                errorProvider2.SetError(txt_priceCustomerPay, "");
                return -1;
            }

            if (!int.TryParse(price.Trim(), out var inputQty))
            {
                errorProvider2.SetError(txt_priceCustomerPay, "Giá tiền phải là thuộc dạng số.");
                return -1;
            }

            if (inputQty < 0)
            {
                errorProvider2.SetError(txt_priceCustomerPay, "Giá tiền không được âm.");
                return -1;
            }
            return long.Parse(price);
        }

        private void updateExchangePrice(object sender, EventArgs e)
        {
            long totalPrice = long.Parse(txt_totalPrice.Text);
            long priceCustomerPay = getPrice(txt_priceCustomerPay.Text);
            long priceExchange = priceCustomerPay - totalPrice;
            txt_priceExchange.Text = priceExchange.ToString();
        }
    }
}