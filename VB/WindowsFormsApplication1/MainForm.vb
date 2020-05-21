#Region "#Reference"
Imports DevExpress.Pdf
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
' ...
#End Region ' #Reference

Namespace WindowsFormsApplication1
    Partial Public Class MainForm
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            pdfViewer1.LoadDocument("..\..\TextExtraction.pdf")
            AddHandler repositoryItemButtonEdit3.ButtonClick, AddressOf repositoryItemButtonEdit3_ButtonClick
        End Sub

        #Region "#ExtractText"
        Private Function ExtractTextFromPDF(ByVal filePath As String) As String
            Dim documentText As String = ""
            Try
                Using documentProcessor As New PdfDocumentProcessor()
                    documentProcessor.LoadDocument(filePath)
                    documentText = documentProcessor.Text
                End Using
            Catch
            End Try
            Return documentText
        End Function
        #End Region ' #ExtractText

        #Region "#WordCount"
        Private Function WordCount(ByVal filePath As String, ByVal word As String) As Integer
            Dim count As Integer = 0
            Try
                Using documentProcessor As New PdfDocumentProcessor()
                    documentProcessor.LoadDocument(filePath)
                    Do While documentProcessor.FindText(word).Status = PdfTextSearchStatus.Found
                        count += 1
                    Loop
                End Using
            Catch
            End Try

            Return count
        End Function
        #End Region ' #WordCount

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barButtonItem1.ItemClick
            Dim path As String = pdfViewer1.DocumentFilePath
            Dim textViewer As New TextViewerForm()
            textViewer.textBox1.Text = ExtractTextFromPDF(path)
            textViewer.ShowDialog()
        End Sub


        Private Sub repositoryItemButtonEdit3_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            Dim path As String = pdfViewer1.DocumentFilePath
            Dim word As String = (TryCast(sender, ButtonEdit)).Text

            Dim message As New StringBuilder()
            message.Append("The number of times the word """)
            message.Append(word)
            message.Append(""" appears in the PDF document: ")
            message.Append(WordCount(path, word).ToString())

            MessageBox.Show(message.ToString())
        End Sub
    End Class
End Namespace


