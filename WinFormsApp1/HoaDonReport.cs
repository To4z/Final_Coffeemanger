using BUS;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class HoaDonReport : Form
    {
        public HoaDonReport()
        {
            InitializeComponent();
        }

        private Hoadonbanhang hoadonbanhang;
        private int tienkhachdua = 0;

        private int tongtien = 0;
        private List<Chitietbanhang> list_chitietbanhang = new List<Chitietbanhang>();
        private List<Hanghoa> list_hanghoa = new List<Hanghoa>();


        public Hoadonbanhang Hoadonbanhang { get => hoadonbanhang; set => hoadonbanhang = value; }
        public List<Chitietbanhang> List_chitietbanhang { get => list_chitietbanhang; set => list_chitietbanhang = value; }
        public List<Hanghoa> List_hanghoa { get => list_hanghoa; set => list_hanghoa = value; }
        public int Tienkhachdua { get => tienkhachdua; set => tienkhachdua = value; }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private String convertNameHH(String mahh)
        {
            String name = "";
            foreach (Hanghoa hh in list_hanghoa)
            {
                if (hh.Ma_hanghoa.Equals(mahh))
                {
                    name = hh.Ten_hanghoa;
                    break;
                }
            }
            return name;
        }

        private void formload()
        {
            ngay.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            mahoadon.Text = Hoadonbanhang.Ma_hd_bh;
            maban.Text = Hoadonbanhang.Maban;

            int y = 395;

            foreach (Chitietbanhang ctbh in List_chitietbanhang)
            {

                String tenhanghoa = convertNameHH(ctbh.Ma_hanghoa);
                int soluong = ctbh.Soluong;
                int thanhtien = ctbh.Thanhtien;
                int gia = thanhtien / soluong;

                tongtien += thanhtien;




                for (int j = 0; j < 4; j++)
                {
                    Label label = new Label();
                    if (j == 0)
                    {

                        label.Location = new Point(24, y);
                        label.Text = tenhanghoa;
                    }
                    else if (j == 1)
                    {

                        label.Location = new Point(141, y);
                        label.Text = soluong.ToString();
                    }
                    else if (j == 2)
                    {

                        label.Location = new Point(302, y);

                        label.Text = gia.ToString();
                    }
                    else if (j == 3)
                    {

                        label.Location = new Point(407, y);
                        label.Text = thanhtien.ToString();

                    }
                    label.Parent = this;
                }
                y = y + 39;




            }


        }

        private void HoaDonReport_Load(object sender, EventArgs e)
        {
            List_hanghoa = HangHoaBUS.Instance.getAllProducts();
            List_chitietbanhang = ChiTietBanHangBUS.Instance.getCTBH(hoadonbanhang.Ma_hd_bh);
            dataGridView1.DataSource = List_chitietbanhang;
            dataGridView1.Visible = false;

            formload();

            Tongtien.Text = tongtien.ToString();
            if (tienkhachdua == -1)
            {
                tienkhach.Text = tongtien.ToString();
                tienthua.Text = "0";
            }
            else
            {
                tienkhach.Text = tienkhachdua.ToString();
                tienthua.Text = (tienkhachdua - tongtien).ToString();
            }




        }

        private void iconButton_xuatfile_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;

                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;


                            pdfTable.SpacingBefore = 10f; // set the margin before the table
                            pdfTable.SpacingAfter = 10f;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                String text1 = "HÓA ĐƠN BÁN HÀNG CỦA MÃ HÓA ĐƠN: " + hoadonbanhang.Ma_hd_bh;
                                Paragraph para = new Paragraph(text1);


                                pdfDoc.Add(para);
                                pdfDoc.Add(pdfTable);
                                String tongtien = "Tổng tiền :" + Tongtien.Text.ToString();
                                Paragraph para1 = new Paragraph(tongtien);
                                pdfDoc.Add(para1);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dữ liệu Export thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }
        }
    }
}
