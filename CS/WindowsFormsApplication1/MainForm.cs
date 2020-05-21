#region #Reference
using DevExpress.Pdf;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.IO;
using System.Text;
using System.Windows.Forms;
// ...
#endregion #Reference

namespace WindowsFormsApplication1 {
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e) {
            pdfViewer1.LoadDocument(@"..\..\TextExtraction.pdf");
            repositoryItemButtonEdit3.ButtonClick += repositoryItemButtonEdit3_ButtonClick;
        }

        #region #ExtractText
        string ExtractTextFromPDF(string filePath) {
            string documentText = "";
            try {
                using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                    documentProcessor.LoadDocument(filePath);
                    documentText = documentProcessor.Text;
                }
            }
            catch { }
            return documentText;
        }
        #endregion #ExtractText

        #region #WordCount
        private int WordCount(string filePath, string word) {
            int count = 0;
            try {
                using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                    documentProcessor.LoadDocument(filePath);
                    while (documentProcessor.FindText(word).Status == PdfTextSearchStatus.Found) {
                        count++;
                    }
                }
            }
            catch { }

            return count;
        }
        #endregion #WordCount

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e) {
            string path = pdfViewer1.DocumentFilePath;
            TextViewerForm textViewer = new TextViewerForm();
            textViewer.textBox1.Text = ExtractTextFromPDF(path);
            textViewer.ShowDialog();
        }


        void repositoryItemButtonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            string path = pdfViewer1.DocumentFilePath;
            string word = (sender as ButtonEdit).Text;

            StringBuilder message = new StringBuilder();
            message.Append("The number of times the word \"");
            message.Append(word);
            message.Append("\" appears in the PDF document: ");
            message.Append(WordCount(path, word).ToString());

            MessageBox.Show(message.ToString());
        }
    }
}


