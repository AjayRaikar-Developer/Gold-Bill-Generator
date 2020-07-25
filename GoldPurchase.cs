using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static BillGenerator.Models;

namespace BillGenerator
{
    public partial class GoldPurchase : Form
    {
        public GoldPurchase()
        {
            InitializeComponent();
            // Changes the window state to Maximized.
            WindowState = FormWindowState.Maximized;

            IdProofMenu.Items.Add("Aadhaar");
            IdProofMenu.Items.Add("PAN");
            IdProofMenu.Items.Add("VoterId");

        }
        private void Save_Click(object sender, EventArgs e)
        {
            var GenerateBill = BillGenerate();
            MessageBox.Show(GenerateBill.ResponseMessage, "Information");
            System.Windows.Forms.Application.Exit();
        }

        private DocumentSave BillGenerate()
        {
            DocumentSave response = new DocumentSave();
            try
            {
                //Creating a landScape A4 - Size Document
                Document document = new Document(new iTextSharp.text.Rectangle(288f, 144f), 10, 10, 10, 10);
                document.SetPageSize(PageSize.A4.Rotate());

                //Bill Saving File Path
                string Path = @"H:/Bills/Bill-" + BillNumber.Text + ".Pdf";

                FileStream fileStream = new FileStream(Path, FileMode.Create, FileAccess.Write, FileShare.None);
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, fileStream);

                document.Open();

                string imageURL = "../../images/BillHeader.jpg";

                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);

                jpg.Alignment = Element.ALIGN_CENTER;

                document.Add(jpg);

                PdfPTable TblBillHeader = new PdfPTable(4);
                PdfPCell cell;
                //ADDS A NEW LINE TO PDF
                Phrase newline = new Phrase(Environment.NewLine);

                //DATA PUSHING TO PDFTable
                //cell = new PdfPCell(new Phrase("Gold Bill Voucher No :"));
                //testtable.AddCell(cell);


                TblBillHeader.DefaultCell.Padding = 103;
                TblBillHeader.WidthPercentage = 100;
                TblBillHeader.HorizontalAlignment = Element.ALIGN_LEFT;

                cell = new PdfPCell(new Phrase("Gold Bill Voucher No :", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE)));
                cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                TblBillHeader.AddCell(cell);

                cell = new PdfPCell(new Phrase(BillNumber.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                TblBillHeader.AddCell(cell);

                cell = new PdfPCell(new Phrase("Date:", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE)));
                cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                TblBillHeader.AddCell(cell);

                cell = new PdfPCell(new Phrase(BillDate.Value.Date.ToString("dd MMMM yyyy"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                TblBillHeader.AddCell(cell);

                document.Add(TblBillHeader);

                
                document.Add(newline);
               
                PdfPTable CustomerDetailsTable = new PdfPTable(2);
                CustomerDetailsTable = new PdfPTable(4);
                CustomerDetailsTable.DefaultCell.Padding = 3;
                CustomerDetailsTable.WidthPercentage = 100;
                CustomerDetailsTable.HorizontalAlignment = Element.ALIGN_LEFT;

                cell = new PdfPCell(new Phrase("CUSTOMER DETAILS", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                CustomerDetailsTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(CusName.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                CustomerDetailsTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(Name.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                CustomerDetailsTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(MobileNumber.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                CustomerDetailsTable.AddCell(cell);


                cell = new PdfPCell(new Phrase(CusMobile.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                CustomerDetailsTable.AddCell(cell);


                cell = new PdfPCell(new Phrase(Address.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                CustomerDetailsTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(CusAddress.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                CustomerDetailsTable.AddCell(cell);

                cell = new PdfPCell(new Phrase("Id Proof: " + IdProofMenu.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                CustomerDetailsTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(CusIdDetails.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                CustomerDetailsTable.AddCell(cell);

                cell = new PdfPCell(new Phrase("ITEM DETAILS", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                CustomerDetailsTable.AddCell(cell);


                //CustomerDetailsTable.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                document.Add(CustomerDetailsTable);

                //document.Add(newline);

                PdfPTable ItemDetailsTable = new PdfPTable(ItemDetails.Columns.Count);
                ItemDetailsTable.DefaultCell.Padding = 3;
                ItemDetailsTable.WidthPercentage = 100;
                ItemDetailsTable.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn column in ItemDetails.Columns)
                {
                    cell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(94, 237, 244);
                    ItemDetailsTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in ItemDetails.Rows)
                {
                    foreach (DataGridViewCell cells in row.Cells)
                    {
                        if (cells.Value != null)
                            ItemDetailsTable.AddCell(cells.Value.ToString());
                    }
                }


               

               
                cell = new PdfPCell(new Phrase("RoundOff:", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.Colspan = 10;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                ItemDetailsTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(RoundOffAmt.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                ItemDetailsTable.AddCell(cell);

                cell = new PdfPCell(new Phrase("GrandTotal:", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.Colspan = 10;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                ItemDetailsTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(FinalAmount.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                ItemDetailsTable.AddCell(cell);

                var AmountWordings = Indianwords(Convert.ToDouble(FinalAmount.Text));

                cell = new PdfPCell(new Phrase("Amount In Words: " + AmountWordings, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.Colspan = 11;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                ItemDetailsTable.AddCell(cell);

                document.Add(ItemDetailsTable);

                document.Add(newline);

                PdfPTable FinalTable;

                FinalTable = new PdfPTable(3);
                FinalTable.HorizontalAlignment = Element.ALIGN_CENTER;
                cell = new PdfPCell(new Phrase("Customer Signature", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(94, 237, 244);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                FinalTable.AddCell(cell);


                cell = new PdfPCell(new Phrase(""));
                cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                FinalTable.AddCell(cell);

                cell = new PdfPCell(new Phrase("For ABC Company Private Limited", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(94, 237, 244);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                FinalTable.AddCell(cell);

                for(int i=1;i<=4;i++)
                {
                    cell = new PdfPCell(new Phrase(" "));
                    cell.Colspan = 3;
                    cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    FinalTable.AddCell(cell);
                }


                cell = new PdfPCell(new Phrase("", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cell.Colspan = 2;
                FinalTable.AddCell(cell);


                cell = new PdfPCell(new Phrase("Authorized Signatory", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(94, 237, 244);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                FinalTable.AddCell(cell);

                document.Add(FinalTable);


                document.Close();

            }
            catch (Exception exp)
            {
                response.ResponseMessage = "Bill Cannot Be Generated - Transaction Failed - Because " + exp.Message;
                response.TxnStatus = false;
                return response;
            }
            response.ResponseMessage = "Bill Successfully Generated!!!!";
            response.TxnStatus = true;

            return response;
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                Gold GoldData = new Gold();

                GoldData.SlNo = ItemDetails.Rows.Count;
                GoldData.PerGramRate = Convert.ToDecimal(GldPerGm.Text);
                GoldData.Description = ItemDesc.Text;
                GoldData.GrossWeight = Convert.ToDecimal(GWt.Text);
                GoldData.LessWeight = Convert.ToDecimal(LWt.Text);
                GoldData.Purity = Convert.ToDecimal(GPur.Text);
                GoldData.StoneAmount = Convert.ToDecimal(StoneAmount.Text);
                decimal OldChargeable = 0;

                if (!String.IsNullOrEmpty(ChargeableAmt.Text) && !String.IsNullOrEmpty(RoundOffAmt.Text) && !String.IsNullOrEmpty(FinalAmount.Text))
                {
                    OldChargeable = Convert.ToDecimal(ChargeableAmt.Text);
                }

                var result = Calculation(GoldData);

                decimal ChargeableAmount = OldChargeable + result.ChargeableAmount;
                decimal TotalFinalAmount = Math.Round(ChargeableAmount, MidpointRounding.AwayFromZero);
                decimal RoundOffAmount = TotalFinalAmount - ChargeableAmount;

                ChargeableAmt.Text = Convert.ToString(ChargeableAmount);
                FinalAmount.Text = Convert.ToString(TotalFinalAmount);
                RoundOffAmt.Text = Convert.ToString(RoundOffAmount);


                ItemDetails.Rows.Add(result.SlNo, result.TxnDescription, result.Hsn, result.GrossWeight, result.LessWeight,
                                     result.Purity, result.PureWeight, result.Rate, result.StoneAmount, result.TxnAmount, result.ChargeableAmount);

            }
            catch
            {
                MessageBox.Show("Some Fields are Missing- Transaction Failed!!!", "Error");
            }

        }
        private GoldCalculation Calculation(Gold GoldData)
        {
            GoldCalculation FinalResponse = new GoldCalculation();
            FinalResponse.SlNo = GoldData.SlNo;
            FinalResponse.TxnDescription = GoldData.Description;
            FinalResponse.Hsn = "7112";
            FinalResponse.GrossWeight = GoldData.GrossWeight;
            FinalResponse.LessWeight = GoldData.LessWeight;
            FinalResponse.Purity = GoldData.Purity;
            FinalResponse.PureWeight = (((GoldData.GrossWeight - GoldData.LessWeight) * GoldData.Purity) / 100);
            FinalResponse.Rate = GoldData.PerGramRate;

            FinalResponse.StoneAmount = GoldData.StoneAmount;
            FinalResponse.TxnAmount = Math.Round((FinalResponse.PureWeight * GoldData.PerGramRate), 2);

            FinalResponse.ChargeableAmount = Math.Round((FinalResponse.PureWeight * GoldData.PerGramRate) + FinalResponse.StoneAmount, 2);

            return FinalResponse;
        }

        public string Indianwords(double? numbers, Boolean paisaconversion = false)
        {
            var pointindex = numbers.ToString().IndexOf(".");
            var paisaamt = 0;
            if (pointindex > 0)
                paisaamt = Convert.ToInt32(numbers.ToString().Substring(pointindex + 1, 2));

            int number = Convert.ToInt32(numbers);

            if (number == 0) return "Zero";
            if (number == -2147483648) return "Minus Two Hundred and Fourteen Crore Seventy Four Lakh Eighty Three Thousand Six Hundred and Forty Eight";
            int[] num = new int[4];
            int first = 0;
            int u, h, t;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (number < 0)
            {
                sb.Append("Minus ");
                number = -number;
            }
            string[] words0 = { "", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
            string[] words1 = { "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] words2 = { "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            string[] words3 = { "Thousand ", "Lakh ", "Crore " };
            num[0] = number % 1000; // units
            num[1] = number / 1000;
            num[2] = number / 100000;
            num[1] = num[1] - 100 * num[2]; // thousands
            num[3] = number / 10000000; // crores
            num[2] = num[2] - 100 * num[3]; // lakhs
            for (int i = 3; i > 0; i--)
            {
                if (num[i] != 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = first; i >= 0; i--)
            {
                if (num[i] == 0) continue;
                u = num[i] % 10; // ones
                t = num[i] / 10;
                h = num[i] / 100; // hundreds
                t = t - 10 * h; // tens
                if (h > 0) sb.Append(words0[h] + "Hundred ");
                if (u > 0 || t > 0)
                {
                    if (h > 0 || i == 0) sb.Append("and ");
                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }
                if (i != 0) sb.Append(words3[i - 1]);
            }

            if (paisaamt == 0 && paisaconversion == false)
            {
                sb.Append("Rupees Only");
            }
            //else if (paisaamt > 0)
            //{
            //    var paisatext = words(paisaamt, true);
            //    sb.AppendFormat("rupees {0} paise only", paisatext);
            //}
            return sb.ToString().TrimEnd();
        }
    }
}
