using BadmintonCourtManagement.DTO;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ExportBillImport : IDocument
    {
        public ImportBillDTO bill { get; set; }
        public List<BillImportDetailDTO> billDetails { get; set; }

        //public DocumentMetadata GetMetadata() => new DocumentMetadata();
        //public DocumentSettings GetSettings() => new DocumentSettings();

        public string beautyMoney(double money)
        {
            return money.ToString("#,##0 ₫", new CultureInfo("vi-VN"));
        }

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(50);
                page.Header()
                    .Text($"HÓA ĐƠN NHẬP HÀNG - MÃ: {bill.ImportBillId}")
                    .FontSize(20)
                    .Bold()
                    .AlignCenter();
                page.Content()
                    .Column(column =>
                    {
                        column.Item().PaddingTop(40).Text($"Ngày nhập: {bill.DateCreated:dd/MM/yyyy}");
                        column.Item().PaddingTop(20).Text($"Nhà cung cấp: {bill.SupplierId}");
                        column.Item().PaddingTop(20).Text($"Nhân viên: {bill.EmployeeId}");
                        column.Item().PaddingTop(20).Text($"Tổng tiền: {beautyMoney(bill.TotalPrice):C}");
                        column.Item().PaddingTop(40).Table(table =>
                        {
                            // Define columns
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(50);   // STT
                                columns.RelativeColumn(3);    // Mã chi tiết hóa đơn nhập (dài)
                                columns.RelativeColumn(3);    // Mã sản phẩm
                                columns.ConstantColumn(60);   // Số lượng
                                columns.ConstantColumn(80);   // Đơn giá
                                columns.ConstantColumn(80);   // Thành tiền
                            });
                            // Table Header
                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("STT").Bold();
                                header.Cell().Element(CellStyle).Text("Mã chi tiết hóa đơn nhập").Bold();
                                header.Cell().Element(CellStyle).Text("Mã sản phẩm").Bold();
                                header.Cell().Element(CellStyle).Text("Số lượng").Bold();
                                header.Cell().Element(CellStyle).Text("Đơn giá").Bold();
                                header.Cell().Element(CellStyle).Text("Thành tiền").Bold();
                            });
                            // Table Rows
                            int index = 1;
                            foreach (var detail in billDetails)
                            {
                                table.Cell().Element(CellStyle).Text(index.ToString());
                                table.Cell().Element(CellStyle).Text(detail.ImportBillDetailId);
                                table.Cell().Element(CellStyle).Text(detail.ProductId);
                                table.Cell().Element(CellStyle).Text(detail.Quantity.ToString());
                                table.Cell().Element(CellStyle).Text($"{beautyMoney(detail.Price):C}");
                                table.Cell().Element(CellStyle).Text($"{beautyMoney(detail.TotalPrice):C}");
                                index++;
                            }

                            static IContainer CellStyle(IContainer container)
                                => container.Border(1).Padding(10);
                        });
                    });
                page.Footer()
                    .AlignCenter()
                    .Text(txt => txt
                        .Line($"Ngày xuất hóa đơn: {DateTime.Now:dd/MM/yyyy}"));
            });
        }
    }
}
