using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DAO;   // để dùng PriceRuleDAO

namespace BadmintonCourtManagement.GUI
{
    public partial class BookCourtDetailGUI : UserControl
    {
        private AccountDTO currentAccount;
        private CourtDTO courtDTO;
        private List<PriceRuleDTO> priceRuleListApplied;
        private BookingBUS bookingBUS;
        private BillBookingBUS billBookingBUS;
        private CustomerBUS customerBUS;
        private string customerIdValue;

        public BookCourtDetailGUI()
        {
            InitializeComponent();
            bookingBUS = new BookingBUS();
            billBookingBUS = new BillBookingBUS();
            customerBUS = new CustomerBUS();
        }

        public BookCourtDetailGUI(AccountDTO currentAccount, CourtDTO courtDTO, string datePicked, string timeStartPicked, string timeEndPicked)
        {
            this.currentAccount = currentAccount;
            this.courtDTO = courtDTO;
            InitializeComponent();
            bookingBUS = new BookingBUS();
            billBookingBUS = new BillBookingBUS();
            customerBUS = new CustomerBUS();
            txtDate.Text = datePicked;
            txtStartTime.Text = timeStartPicked;
            txtEndTime.Text = timeEndPicked;
            calBooking.SetDate(DateOnly.ParseExact(datePicked, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToDateTime(new TimeOnly(0, 0)));
            UpdatePrice();
        }

        // ================== LOAD FORM ==================
        private void BookCourtDetail_Load(object sender, EventArgs e)
        {
            if (courtDTO != null)
                txtCourtID.Text = courtDTO.CourtId;


            // Giờ mặc định: bo tròn về 00, 15, 30, 45 gần nhất phía sau
            int nowMinute = DateTime.Now.Minute;
            int nowHour = DateTime.Now.Hour;

            if (nowMinute < 15)
                nowMinute = 15;
            else if (nowMinute < 30)
                nowMinute = 30;
            else if (nowMinute < 45)
                nowMinute = 45;
            else
            {
                nowMinute = 0;
                nowHour += 1;
            }

            var defaultStart = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                nowHour,
                nowMinute,
                0
            );

            //timeStartPicker.Value = defaultStart;
            //timeEndPicker.Value = defaultStart.AddHours(1);

            //txtStartTime.Text = timeStartPicker.Value.ToString("HH:mm");
            //txtEndTime.Text = timeEndPicker.Value.ToString("HH:mm");
        }


        // ================== SỰ KIỆN BÊN TRÁI (CHỌN LỊCH & GIỜ) ==================

        private void calBooking_DateSelected(object sender, DateRangeEventArgs e)
        {
            // cập nhật ngày bên phải (read-only)
            txtDate.Text = e.Start.ToString("dd/MM/yyyy");
        }

        //private void timeStartPicker_ValueChanged(object sender, EventArgs e)
        //{
        //    // cập nhật giờ bắt đầu bên phải
        //    txtStartTime.Text = timeStartPicker.Value.ToString("HH:mm");

        //    // nếu giờ kết thúc <= giờ bắt đầu thì tự đẩy lên +1h
        //    if (timeEndPicker.Value <= timeStartPicker.Value)
        //    {
        //        timeEndPicker.Value = timeStartPicker.Value.AddHours(1);
        //        txtEndTime.Text = timeEndPicker.Value.ToString("HH:mm");
        //    }
        //}

        //private void timeEndPicker_ValueChanged(object sender, EventArgs e)
        //{
        //    // cập nhật giờ kết thúc bên phải
        //    txtEndTime.Text = timeEndPicker.Value.ToString("HH:mm");
        //}

        // ================== CÁC SỰ KIỆN KHÁC ==================

        private void customPanel3_Paint(object sender, PaintEventArgs e) { }

        private void customPanel2_Paint(object sender, PaintEventArgs e) { }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            var bookingGUI = new BookCourtGUI(currentAccount);
            bookingGUI.Dock = DockStyle.Fill;
            this.Controls.Add(bookingGUI);
        }

        // Validate giờ bắt đầu
        private void txtStartTime_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtDate.Text))
            //{
            //    MessageBox.Show("Vui lòng chọn ngày");
            //    txtStartTime.Text = "";
            //    return;
            //}

            //if (!string.IsNullOrWhiteSpace(txtStartTime.Text))
            //{
            //    if (TimeSpan.TryParse(txtStartTime.Text, out TimeSpan startTime))
            //    {
            //        // kiểm tra phút: chỉ cho phép 00, 15, 30, 45
            //        if (!(startTime.Minutes == 0 || startTime.Minutes == 15 || startTime.Minutes == 30 || startTime.Minutes == 45))
            //        {
            //            MessageBox.Show("Chỉ được chọn phút là 00, 15, 30 hoặc 45");
            //            txtStartTime.Text = "";
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng nhập giờ hợp lệ (HH:mm, VD: 15:30)");
            //        txtStartTime.Text = "";
            //    }
            //}
            //UpdatePrice();
        }

        // Validate giờ kết thúc
        private void txtEndTime_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtStartTime.Text))
            //{
            //    MessageBox.Show("Vui lòng chọn giờ bắt đầu");
            //    txtEndTime.Text = "";
            //    return;
            //}

            //if (TimeSpan.TryParse(txtStartTime.Text, out TimeSpan startTime) &&
            //    TimeSpan.TryParse(txtEndTime.Text, out TimeSpan endTime))
            //{
            //    // tối thiểu 1 tiếng
            //    if ((endTime - startTime).TotalMinutes < 60)
            //    {
            //        MessageBox.Show("Thời gian đặt tối thiểu là 1 tiếng");
            //        txtEndTime.Text = "";
            //        return;
            //    }

            //    // phút phải là 00, 15, 30 hoặc 45
            //    if (!((startTime.Minutes == 0 || startTime.Minutes == 15 || startTime.Minutes == 30 || startTime.Minutes == 45) &&
            //          (endTime.Minutes == 0 || endTime.Minutes == 15 || endTime.Minutes == 30 || endTime.Minutes == 45)))
            //    {
            //        MessageBox.Show("Chỉ được đặt ở phút 00, 15, 30 hoặc 45");
            //        txtEndTime.Text = "";
            //        return;
            //    }
            //    UpdatePrice();

            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập giờ hợp lệ (HH:mm, VD: 15:30)");
            //    txtTotalPrice.Text = "";
            //}
        }

        private void UpdatePrice()
        {
            priceRuleListApplied = new List<PriceRuleDTO>();

            if (!DateOnly.TryParseExact(txtDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly bookingDate))
            {
                MessageBox.Show("Ngày đặt không hợp lệ");
                return;
            }

            if (!TimeOnly.TryParse(txtStartTime.Text, out TimeOnly startTime) ||
                !TimeOnly.TryParse(txtEndTime.Text, out TimeOnly endTime))
            {
                //MessageBox.Show("Giờ bắt đầu hoặc kết thúc không hợp lệ");
                return;
            }

            var priceRuleDao = new PriceRuleDAO();

            TimeOnly currentStart = startTime;
            while (currentStart < endTime)
            {
                TimeOnly currentEnd = currentStart.AddMinutes(15);

                if (currentEnd > endTime)
                    currentEnd = endTime;

                PriceRuleDTO rule = priceRuleDao.GetPriceRuleByTime(currentStart, currentEnd, bookingDate);
                if (rule != null)
                    priceRuleListApplied.Add(rule);

                currentStart = currentEnd;
            }

            double totalPrice = 0;
            foreach (var rule in priceRuleListApplied)
            {
                totalPrice += rule.Price * 0.25; // 0.25 giờ = 15 phút
            }

            txtTotalPrice.Text = totalPrice.ToString("0");
        }



        private void calBooking_DateChanged(object sender, DateRangeEventArgs e) { }

        private void lblCalStart_Click(object sender, EventArgs e) { }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void btnBooking4_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookingBUS == null)
                    bookingBUS = new BookingBUS();
                if (billBookingBUS == null)
                    billBookingBUS = new BillBookingBUS();

                double totalPrice = double.Parse(txtTotalPrice.Text); // tổng tiền đã tính

                // 1️⃣ Validate (giữ nguyên như bạn đang làm)
                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPrePayment.Text))
                    txtPrePayment.Text = "0";
                if (!double.TryParse(txtPrePayment.Text, out double prePaymentValue) || prePaymentValue < 0 || prePaymentValue > totalPrice)
                {
                    MessageBox.Show("Số tiền đặt cọc không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double prePayment = double.Parse(txtPrePayment.Text);


                    // 2️⃣ Parse thông tin booking (giữ nguyên)
                    DateOnly bookingDate = DateOnly.ParseExact(txtDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                TimeOnly startTime = TimeOnly.Parse(txtStartTime.Text);
                TimeOnly endTime = TimeOnly.Parse(txtEndTime.Text);

                DateTime startDateTime = bookingDate.ToDateTime(startTime);
                DateTime endDateTime = bookingDate.ToDateTime(endTime);

                // 3️⃣ Kiểm tra trùng giờ (giữ nguyên)
                List<BookingDTO> existingBookings = bookingBUS.GetSuccessfulBookingsByCourtID(txtCourtID.Text);
                foreach (var booking in existingBookings)
                {
                    if (startDateTime < booking.EndTime && endDateTime > booking.StartTime)
                    {
                        MessageBox.Show($"Đã trùng giờ đã đặt!\n\n" +
                            $"Booking đã tồn tại:\n" +
                            $"Từ: {booking.StartTime:dd/MM/yyyy HH:mm}\n" +
                            $"Đến: {booking.EndTime:HH:mm}",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 4️⃣ Lấy BookingId mới
                string bookingId = bookingBUS.GetNextBookingId();

                // 5️⃣ Tạo BookingDTO
                BookingDTO newBooking = new BookingDTO
                {
                    BookingId = bookingId,
                    CourtId = txtCourtID.Text,
                    Status = BookingDTO.Option.successful,
                    StartTime = startDateTime,
                    EndTime = endDateTime
                };



                // 6️⃣ Insert Booking vào database
                bool bookingResult = bookingBUS.InsertBooking(newBooking);

                if (!bookingResult)
                {
                    MessageBox.Show("Đặt sân thất bại (không lưu được booking)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CustomerDTO customer = customerBUS.GetCustomerByPhone(txtPhone.Text);
                if (customer == null)
                {
                    string nextCustomerId = customerBUS.GetNextId();
                    customerIdValue = nextCustomerId;
                    CustomerDTO newCustomer = new CustomerDTO
                    {
                        CustomerId = nextCustomerId,
                        CustomerName = txtCustomerName.Text,
                        CustomerPhone = txtPhone.Text,
                        IsDeleted = 0
                    };
                    bool customerResult = customerBUS.InsertCustomer(newCustomer);
                    if (!customerResult)
                        MessageBox.Show("Đặt sân thành công nhưng lưu khách hàng thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // 7️⃣ Tạo BillBookingId mới
                string billBookingId = billBookingBUS.GetNextId();


                // Lấy EmployeeId & CustomerId
                string employeeId = currentAccount?.EmployeeId ?? "";   // tùy cấu trúc AccountDTO của bạn

                // 9️⃣ Tạo BillBookingDTO
                BillBookingDTO newBill = new BillBookingDTO
                {
                    BillBookingId = billBookingId,
                    EmployeeId = employeeId,
                    CustomerId = customerIdValue,
                    BookingId = bookingId,
                    TotalPrice = totalPrice,
                    PrePayment = prePayment
                };

                // 🔟 Insert BillBooking vào database
                bool billResult = billBookingBUS.InsertBillBooking(newBill);

                if (!billResult)
                {
                    MessageBox.Show("Đặt sân thành công nhưng tạo hóa đơn thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Gộp các ruleId giống nhau và tính tổng thời giá áp dụng
                Dictionary<string, double> merged = new Dictionary<string, double>();

                foreach (PriceRuleDTO rule in priceRuleListApplied)
                {
                    double priceApplied = rule.Price * 0.25; // giá cho mỗi 15 phút

                    if (merged.ContainsKey(rule.PriceRuleId))
                        merged[rule.PriceRuleId] += priceApplied;
                    else
                        merged[rule.PriceRuleId] = priceApplied;
                }
                List<PriceBookingDetailDTO> priceBookingDetails = new List<PriceBookingDetailDTO>();

                foreach (var item in merged)
                {
                    priceBookingDetails.Add(new PriceBookingDetailDTO
                    {
                        PriceRuleId = item.Key,
                        BillBookingId = billBookingId,
                        PriceApplied = item.Value
                    });
                }

                // Thêm vào pricebookingdetail
                foreach (PriceBookingDetailDTO ruleDetail in priceBookingDetails)
                {
                    if(!PriceBookingDetailBUS.InsertPriceBookingDetail(ruleDetail))
                        MessageBox.Show("Đặt sân thành công nhưng lưu chi tiết giá thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show($"Đặt sân thành công!\n\n" +
                    $"Mã đặt sân: {bookingId}\n" +
                    $"Mã hóa đơn: {billBookingId}\n" +
                    $"Sân: {txtCourtID.Text}\n" +
                    $"Ngày: {txtDate.Text}\n" +
                    $"Giờ: {txtStartTime.Text} - {txtEndTime.Text}\n" +
                    $"Tổng tiền: {txtTotalPrice.Text} VNĐ",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // 1️⃣1️⃣ Quay lại trang danh sách
                this.Controls.Clear();
                var bookingGUI = new BookCourtGUI(currentAccount);
                bookingGUI.Dock = DockStyle.Fill;
                this.Controls.Add(bookingGUI);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtCustomerName.Text = "";
                txtCustomerName.ReadOnly = true;
                customerIdValue = "";
                customPanel3.BackColor = SystemColors.Control;
                return;
            }
            if (txtPhone.Text.Length < 10)
            {
                txtCustomerName.Text = "Số điện thoại không hợp lệ";
                txtCustomerName.ReadOnly = true;
                customerIdValue = "";
                customPanel3.BackColor = SystemColors.Control;
                return;
            }
            if (txtPhone.Text.Length > 10)
            {
                txtCustomerName.Text = "Số điện thoại không hợp lệ";
                txtCustomerName.ReadOnly = true;
                customerIdValue = "";
                customPanel3.BackColor = SystemColors.Control;
                return;
            }
            if (!long.TryParse(txtPhone.Text, out _))
            {
                txtCustomerName.Text = "Số điện thoại không hợp lệ";
                txtCustomerName.ReadOnly = true;
                customerIdValue = "";
                customPanel3.BackColor = SystemColors.Control;
                return;
            }
            CustomerDTO customer = customerBUS.GetCustomerByPhone(txtPhone.Text);
            if (customer != null)
            {
                txtCustomerName.Text = customer.CustomerName;
                txtCustomerName.ReadOnly = true;
                customerIdValue = customer.CustomerId;
                customPanel3.BackColor = SystemColors.Control;
            }
            else
            {
                txtCustomerName.ReadOnly = false;
                txtCustomerName.Text = "";
                customerIdValue = "";
                customPanel3.BackColor = Color.White;
            }
        }
    }
}
