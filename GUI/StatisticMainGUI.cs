using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StatisticMainGUI : UserControl
    {
        private List<BillBookingDTO> listBillBookings;
        private List<BillProductDTO> listBillProduct;
        private List<ImportBillDTO> listImportBill;
        private List<BillProductDetailDTO> listBillDetails;
        private List<ProductDTO> listProducts;

        private List<BookingDTO> listBooking;
        private List<CourtDTO> listCourts;

        private List<BillImportDetailDTO> listImportDetails;
        public StatisticMainGUI(List<BillBookingDTO> listBillBookings, List<BillProductDTO> listBillProduct, List<ImportBillDTO> listImportBill, List<BillProductDetailDTO> listBillDetails, List<ProductDTO> listProducts, List<BookingDTO> listBooking, List<CourtDTO> listCourts, List<BillImportDetailDTO> listImportDetails)
        {
            this.listBillBookings = listBillBookings;
            this.listBillProduct = listBillProduct;
            this.listImportBill = listImportBill;
            this.listBillDetails = listBillDetails;
            this.listProducts = listProducts;
            this.listBooking = listBooking;
            this.listCourts = listCourts;
            this.listImportDetails = listImportDetails;
            InitializeComponent();
        }
    }
}
