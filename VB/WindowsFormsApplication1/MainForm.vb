#Region "#Reference"
Imports DevExpress.Pdf
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

' ...
#End Region  ' #Reference
Namespace WindowsFormsApplication1

    Public Partial Class MainForm
        Inherits Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            pdfViewer1.LoadDocument("..\..\document.pdf")
            AddHandler repositoryItemButtonEdit3.ButtonClick, AddressOf repositoryItemButtonEdit3_ButtonClick
        End Sub

#Region "#ExtractText"
        Private Function ExtractTextFromPDF(ByVal filePath As String) As String
            Dim documentText As String = ""
            Try
                Using documentStream As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
                    Using documentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                        documentProcessor.LoadDocument(documentStream)
                        documentText = documentProcessor.Text
                    End Using
                End Using
            Catch
            End Try

            Return documentText
        End Function

#End Region  ' #ExtractText
#Region "#WordCount"
        Private Function WordCount(ByVal filePath As String, ByVal word As String) As Integer
            Dim count As Integer = 0
            Try
                Using documentStream As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
                    Using documentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                        documentProcessor.LoadDocument(documentStream)
                        While documentProcessor.FindText(word).Status = PdfTextSearchStatus.Found
                            count += 1
                        End While
                    End Using
                End Using
            Catch
            End Try

            Return count
        End Function

#End Region  ' #WordCount
        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim path As String = pdfViewer1.DocumentFilePath
            Dim textViewer As TextViewerForm = New TextViewerForm()
            textViewer.textBox1.Text = ExtractTextFromPDF(path)
            textViewer.ShowDialog()
        End Sub

        Private Sub repositoryItemButtonEdit3_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            Dim path As String = pdfViewer1.DocumentFilePath
            Dim word As String = TryCast(sender, ButtonEdit).Text
            Dim message As StringBuilder = New StringBuilder()
            message.Append("The number of times the word """)
            message.Append(word)
            message.Append(""" appears in the PDF document: ")
            message.Append(WordCount(path, word).ToString())
            Call MessageBox.Show(message.ToString())
        End Sub
    End Class
End Namespace
