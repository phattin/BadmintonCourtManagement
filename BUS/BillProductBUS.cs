using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;
using System.Security.Permissions;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Linq;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Helpers;
namespace BadmintonCourtManagement.BUS
{ 
    public class BillProductBUS
    {
        private BillProductDAO dao = new BillProductDAO();
        public string GetMaxId()
        {
            return dao.GetMaxId();
        }
        public bool InsertProductBill(BillProductDTO bill)
        {
            return dao.InsertProductBill(bill);
        }
        public List<BillProductDTO> GetAllProductBills()
        {
            return dao.GetAllProductBills();
        }

        public List<BillProductDTO> GetProductBillByPriceRange(double start, double end)
        {
            return dao.GetProductBillByPriceRange(start, end);
        }
        public List<BillProductDTO> GetProductBillByTimeRange(DateTime startTime, DateTime endTime)
        {
            return dao.GetProductBillByTimeRange(startTime, endTime);
        }
        public List<BillProductDTO> Search(string searchCriteria)
        {
            return dao.Search(searchCriteria);
        }

        public bool UpdateProductBill(BillProductDTO bill)
        {
            return dao.UpdateProductBill(bill);
        }
        public bool DeleteProductBill(string id)
        {
            return dao.DeleteProductBill(id);
        }
        public BillProductDTO GetProductBillById(string id)
        {
            return dao.GetProductBillById(id);
        }
        public bool ExportBillPdf(string billProductId, string filePath)
{
    try
    {
        // Giả sử bạn đã có sẵn thư viện xuất PDF (iText7, PdfSharp, QuestPDF, v.v.)
        // Dưới đây là ví dụ dùng QuestPDF (rất phổ biến và đẹp)

        var bill = GetProductBillById(billProductId);
        var details = new BillProductDetailBUS().GetDetailByBillProductId(billProductId);
        var productBus = new ProductBUS();

        QuestPDF.Fluent.Document.Create(document =>
        {
            document.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(40);
                // page.PageColor(QuestPDF.Settings.Colors.White);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(12));

                page.Header().Text("HÓA ĐƠN BÁN HÀNG").FontSize(20).Bold().AlignCenter();

                page.Content().PaddingVertical(20).Column(col =>
                {
                    col.Item().Text($"Mã hóa đơn: {bill.BillProductId}");
                    col.Item().Text($"Nhân viên: {bill.EmployeeId ?? "Không xác định"}");
                    col.Item().Text($"Ngày lập: {bill.DateCreated:dd/MM/yyyy HH:mm:ss}");
                    col.Item().LineHorizontal(1).LineColor(Colors.Grey.Darken2);

col.Item().PaddingTop(10).Element(element => 
{
    element.Border(1).BorderColor(Colors.Black).Table(table =>
    {
        table.ColumnsDefinition(columns =>
        {
            columns.ConstantColumn(50);
            columns.RelativeColumn();
            columns.ConstantColumn(80);
            columns.ConstantColumn(100);
            columns.ConstantColumn(100);
        });

        table.Header(header =>
        {
            header.Cell().Background("#f0f0f0").BorderBottom(2).BorderColor(Colors.Black).Padding(10)
                  .Text("STT").Bold().AlignCenter();

            header.Cell().Background("#f0f0f0").BorderBottom(2).BorderColor(Colors.Black).Padding(10)
                  .Text("Sản phẩm").Bold().AlignCenter();

            header.Cell().Background("#f0f0f0").BorderBottom(2).BorderColor(Colors.Black).Padding(10)
                  .Text("SL").Bold().AlignCenter();

            header.Cell().Background("#f0f0f0").BorderBottom(2).BorderColor(Colors.Black).Padding(10)
                  .Text("Đơn giá").Bold().AlignCenter();

            header.Cell().Background("#f0f0f0").BorderBottom(2).BorderColor(Colors.Black).Padding(10)
                  .Text("Thành tiền").Bold().AlignCenter();
        });

        int stt = 1;
        foreach (var d in details)
        {
            var product = productBus.GetProductById(d.ProductId);
            string name = product?.ProductName ?? "Sản phẩm đã xóa";

            table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten1).PaddingVertical(8)
                  .Text(stt++.ToString()).AlignCenter();

            table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten1).PaddingVertical(8).PaddingLeft(6)
                  .Text(name).AlignLeft();

            table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten1).PaddingVertical(8)
                  .Text(d.Quantity.ToString()).AlignCenter();

                    table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten1).PaddingVertical(8)
                  .Text(d.Price.ToString("N0")).AlignCenter();
                    table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten1).PaddingVertical(8)
                  .Text(d.TotalPrice.ToString("N0")).AlignCenter();

        }
    });
}); 

                    var total = details.Sum(x => x.TotalPrice);
                    col.Item().AlignRight().Text($"TỔNG TIỀN: {total:N0} ₫").FontSize(16).Bold();
                });

                page.Footer().AlignCenter().Text(x =>
                {
                    x.CurrentPageNumber();
                    x.Span(" / ");
                    x.TotalPages();
                });
            });
        }).GeneratePdf(filePath);

        return true;
    }
    catch (Exception ex)
    {
        // Ghi log nếu cần
        // MessageBox.Show("Lỗi xuất PDF: " + ex.Message);
        return false;
    }
}
    }
}