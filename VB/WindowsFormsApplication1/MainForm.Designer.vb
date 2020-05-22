Namespace WindowsFormsApplication1
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
            Me.pdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.pdfFileOpenBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
            Me.pdfFilePrintBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem()
            Me.pdfPreviousPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
            Me.pdfNextPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
            Me.pdfFindTextBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem()
            Me.pdfZoomOutBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
            Me.pdfZoomInBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
            Me.pdfExactZoomListBarSubItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
            Me.pdfZoom10CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
            Me.pdfZoom25CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
            Me.pdfZoom50CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
            Me.pdfZoom75CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
            Me.pdfZoom100CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
            Me.pdfZoom125CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
            Me.pdfZoom150CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
            Me.pdfZoom200CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
            Me.pdfZoom400CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
            Me.pdfZoom500CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
            Me.pdfSetActualSizeZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem()
            Me.pdfSetPageLevelZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem()
            Me.pdfSetFitWidthZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem()
            Me.pdfSetFitVisibleZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.pdfRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfRibbonPage()
            Me.pdfFileRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup()
            Me.pdfNavigationRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup()
            Me.pdfZoomRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.repositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.pdfBarController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarController()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pdfBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pdfViewer1
            ' 
            Me.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfViewer1.Location = New System.Drawing.Point(0, 144)
            Me.pdfViewer1.Name = "pdfViewer1"
            Me.pdfViewer1.Size = New System.Drawing.Size(1121, 509)
            Me.pdfViewer1.TabIndex = 0
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.pdfFileOpenBarItem1, Me.pdfFilePrintBarItem1, Me.pdfPreviousPageBarItem1, Me.pdfNextPageBarItem1, Me.pdfFindTextBarItem1, Me.pdfZoomOutBarItem1, Me.pdfZoomInBarItem1, Me.pdfExactZoomListBarSubItem1, Me.pdfZoom10CheckItem1, Me.pdfZoom25CheckItem1, Me.pdfZoom50CheckItem1, Me.pdfZoom75CheckItem1, Me.pdfZoom100CheckItem1, Me.pdfZoom125CheckItem1, Me.pdfZoom150CheckItem1, Me.pdfZoom200CheckItem1, Me.pdfZoom400CheckItem1, Me.pdfZoom500CheckItem1, Me.pdfSetActualSizeZoomModeCheckItem1, Me.pdfSetPageLevelZoomModeCheckItem1, Me.pdfSetFitWidthZoomModeCheckItem1, Me.pdfSetFitVisibleZoomModeCheckItem1, Me.barButtonItem1, Me.barEditItem2})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 32
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.pdfRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1, Me.repositoryItemButtonEdit1, Me.repositoryItemButtonEdit2, Me.repositoryItemTextEdit2, Me.repositoryItemToggleSwitch1, Me.repositoryItemButtonEdit3})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.ribbonControl1.Size = New System.Drawing.Size(1121, 144)
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above
            ' 
            ' pdfFileOpenBarItem1
            ' 
            Me.pdfFileOpenBarItem1.Id = 1
            Me.pdfFileOpenBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
            Me.pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1"
            ' 
            ' pdfFilePrintBarItem1
            ' 
            Me.pdfFilePrintBarItem1.Id = 2
            Me.pdfFilePrintBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
            Me.pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1"
            ' 
            ' pdfPreviousPageBarItem1
            ' 
            Me.pdfPreviousPageBarItem1.Id = 3
            Me.pdfPreviousPageBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.PageUp)
            Me.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1"
            ' 
            ' pdfNextPageBarItem1
            ' 
            Me.pdfNextPageBarItem1.Id = 4
            Me.pdfNextPageBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.PageDown)
            Me.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1"
            ' 
            ' pdfFindTextBarItem1
            ' 
            Me.pdfFindTextBarItem1.Id = 5
            Me.pdfFindTextBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
            Me.pdfFindTextBarItem1.Name = "pdfFindTextBarItem1"
            ' 
            ' pdfZoomOutBarItem1
            ' 
            Me.pdfZoomOutBarItem1.Id = 6
            Me.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1"
            ' 
            ' pdfZoomInBarItem1
            ' 
            Me.pdfZoomInBarItem1.Id = 7
            Me.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1"
            ' 
            ' pdfExactZoomListBarSubItem1
            ' 
            Me.pdfExactZoomListBarSubItem1.Id = 8
            Me.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom10CheckItem1, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom25CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom50CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom75CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom100CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom125CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom150CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom200CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom400CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom500CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetActualSizeZoomModeCheckItem1, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetPageLevelZoomModeCheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetFitWidthZoomModeCheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetFitVisibleZoomModeCheckItem1) _
            })
            Me.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1"
            Me.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            ' 
            ' pdfZoom10CheckItem1
            ' 
            Me.pdfZoom10CheckItem1.Id = 9
            Me.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1"
            ' 
            ' pdfZoom25CheckItem1
            ' 
            Me.pdfZoom25CheckItem1.Id = 10
            Me.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1"
            ' 
            ' pdfZoom50CheckItem1
            ' 
            Me.pdfZoom50CheckItem1.Id = 11
            Me.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1"
            ' 
            ' pdfZoom75CheckItem1
            ' 
            Me.pdfZoom75CheckItem1.Id = 12
            Me.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1"
            ' 
            ' pdfZoom100CheckItem1
            ' 
            Me.pdfZoom100CheckItem1.Id = 13
            Me.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1"
            ' 
            ' pdfZoom125CheckItem1
            ' 
            Me.pdfZoom125CheckItem1.Id = 14
            Me.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1"
            ' 
            ' pdfZoom150CheckItem1
            ' 
            Me.pdfZoom150CheckItem1.Id = 15
            Me.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1"
            ' 
            ' pdfZoom200CheckItem1
            ' 
            Me.pdfZoom200CheckItem1.Id = 16
            Me.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1"
            ' 
            ' pdfZoom400CheckItem1
            ' 
            Me.pdfZoom400CheckItem1.Id = 17
            Me.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1"
            ' 
            ' pdfZoom500CheckItem1
            ' 
            Me.pdfZoom500CheckItem1.Id = 18
            Me.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1"
            ' 
            ' pdfSetActualSizeZoomModeCheckItem1
            ' 
            Me.pdfSetActualSizeZoomModeCheckItem1.Id = 19
            Me.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1"
            ' 
            ' pdfSetPageLevelZoomModeCheckItem1
            ' 
            Me.pdfSetPageLevelZoomModeCheckItem1.Id = 20
            Me.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1"
            ' 
            ' pdfSetFitWidthZoomModeCheckItem1
            ' 
            Me.pdfSetFitWidthZoomModeCheckItem1.Id = 21
            Me.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1"
            ' 
            ' pdfSetFitVisibleZoomModeCheckItem1
            ' 
            Me.pdfSetFitVisibleZoomModeCheckItem1.Id = 22
            Me.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Extract Text"
            Me.barButtonItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barButtonItem1.Id = 23
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barEditItem2
            ' 
            Me.barEditItem2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barEditItem2.Edit = Me.repositoryItemButtonEdit3
            Me.barEditItem2.EditValue = ""
            Me.barEditItem2.Id = 31
            Me.barEditItem2.Name = "barEditItem2"
            Me.barEditItem2.Width = 100
            ' 
            ' repositoryItemButtonEdit3
            ' 
            Me.repositoryItemButtonEdit3.AutoHeight = False
            Me.repositoryItemButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "OK", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
            Me.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3"
            ' 
            ' pdfRibbonPage1
            ' 
            Me.pdfRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pdfFileRibbonPageGroup1, Me.pdfNavigationRibbonPageGroup1, Me.pdfZoomRibbonPageGroup1, Me.ribbonPageGroup1})
            Me.pdfRibbonPage1.Name = "pdfRibbonPage1"
            ' 
            ' pdfFileRibbonPageGroup1
            ' 
            Me.pdfFileRibbonPageGroup1.ItemLinks.Add(Me.pdfFileOpenBarItem1)
            Me.pdfFileRibbonPageGroup1.ItemLinks.Add(Me.pdfFilePrintBarItem1)
            Me.pdfFileRibbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
            Me.pdfFileRibbonPageGroup1.Name = "pdfFileRibbonPageGroup1"
            ' 
            ' pdfNavigationRibbonPageGroup1
            ' 
            Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfPreviousPageBarItem1)
            Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfNextPageBarItem1)
            Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfFindTextBarItem1)
            Me.pdfNavigationRibbonPageGroup1.Name = "pdfNavigationRibbonPageGroup1"
            ' 
            ' pdfZoomRibbonPageGroup1
            ' 
            Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfZoomOutBarItem1)
            Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfZoomInBarItem1)
            Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfExactZoomListBarSubItem1)
            Me.pdfZoomRibbonPageGroup1.Name = "pdfZoomRibbonPageGroup1"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barEditItem2)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Word Count"
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemButtonEdit1
            ' 
            Me.repositoryItemButtonEdit1.AutoHeight = False
            Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
            ' 
            ' repositoryItemButtonEdit2
            ' 
            Me.repositoryItemButtonEdit2.AutoHeight = False
            Me.repositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2"
            ' 
            ' repositoryItemTextEdit2
            ' 
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' repositoryItemToggleSwitch1
            ' 
            Me.repositoryItemToggleSwitch1.AutoHeight = False
            Me.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1"
            Me.repositoryItemToggleSwitch1.OffText = "Off"
            Me.repositoryItemToggleSwitch1.OnText = "On"
            ' 
            ' pdfBarController1
            ' 
            Me.pdfBarController1.BarItems.Add(Me.pdfFileOpenBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfFilePrintBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfPreviousPageBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfNextPageBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfFindTextBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoomOutBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoomInBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfExactZoomListBarSubItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom10CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom25CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom50CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom75CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom100CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom125CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom150CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom200CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom400CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom500CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetActualSizeZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetPageLevelZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetFitWidthZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetFitVisibleZoomModeCheckItem1)
            Me.pdfBarController1.Control = Me.pdfViewer1
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1121, 653)
            Me.Controls.Add(Me.pdfViewer1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "MainForm"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Main Form"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pdfBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private pdfFileOpenBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem
        Private pdfFilePrintBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem
        Private pdfPreviousPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem
        Private pdfNextPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem
        Private pdfFindTextBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem
        Private pdfZoomOutBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem
        Private pdfZoomInBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem
        Private pdfExactZoomListBarSubItem1 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem
        Private pdfZoom10CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem
        Private pdfZoom25CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem
        Private pdfZoom50CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem
        Private pdfZoom75CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem
        Private pdfZoom100CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem
        Private pdfZoom125CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem
        Private pdfZoom150CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem
        Private pdfZoom200CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem
        Private pdfZoom400CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem
        Private pdfZoom500CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem
        Private pdfSetActualSizeZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem
        Private pdfSetPageLevelZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem
        Private pdfSetFitWidthZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem
        Private pdfSetFitVisibleZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem
        Private pdfRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfRibbonPage
        Private pdfFileRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup
        Private pdfNavigationRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup
        Private pdfZoomRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup
        Private pdfBarController1 As DevExpress.XtraPdfViewer.Bars.PdfBarController
        Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private repositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Private barEditItem2 As DevExpress.XtraBars.BarEditItem
        Private repositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Private repositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    End Class
End Namespace

