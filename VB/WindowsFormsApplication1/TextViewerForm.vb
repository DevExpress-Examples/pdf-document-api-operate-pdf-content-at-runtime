Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsFormsApplication1

    Public Partial Class TextViewerForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub
    End Class
End Namespace
