<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ITI_Hub_regional_sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ITI_Hub_regional_sales))
        Me.btnDispSalesHist = New System.Windows.Forms.Button()
        Me.btnDispRegPerc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstRegionalSales = New System.Windows.Forms.ListBox()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.lblTotPercent = New System.Windows.Forms.Label()
        Me.rbtnKzn = New System.Windows.Forms.RadioButton()
        Me.rbtnGp = New System.Windows.Forms.RadioButton()
        Me.rbtnWc = New System.Windows.Forms.RadioButton()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblRegionalSalesList = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtTotalCompSales = New System.Windows.Forms.TextBox()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.gboxRegion = New System.Windows.Forms.GroupBox()
        Me.pboxGraph = New System.Windows.Forms.PictureBox()
        Me.gboxRegion.SuspendLayout()
        CType(Me.pboxGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDispSalesHist
        '
        Me.btnDispSalesHist.Location = New System.Drawing.Point(50, 178)
        Me.btnDispSalesHist.Name = "btnDispSalesHist"
        Me.btnDispSalesHist.Size = New System.Drawing.Size(207, 70)
        Me.btnDispSalesHist.TabIndex = 1
        Me.btnDispSalesHist.Text = "&Display Sales History"
        Me.btnDispSalesHist.UseVisualStyleBackColor = True
        '
        'btnDispRegPerc
        '
        Me.btnDispRegPerc.Location = New System.Drawing.Point(50, 267)
        Me.btnDispRegPerc.Name = "btnDispRegPerc"
        Me.btnDispRegPerc.Size = New System.Drawing.Size(207, 70)
        Me.btnDispRegPerc.TabIndex = 2
        Me.btnDispRegPerc.Text = "&Display Regional Percentage"
        Me.btnDispRegPerc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(47, 448)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(207, 70)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstRegionalSales
        '
        Me.lstRegionalSales.FormattingEnabled = True
        Me.lstRegionalSales.ItemHeight = 25
        Me.lstRegionalSales.Location = New System.Drawing.Point(47, 587)
        Me.lstRegionalSales.Name = "lstRegionalSales"
        Me.lstRegionalSales.Size = New System.Drawing.Size(813, 229)
        Me.lstRegionalSales.TabIndex = 9
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(465, 130)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(100, 31)
        Me.txtPercentage.TabIndex = 4
        '
        'lblTotPercent
        '
        Me.lblTotPercent.AutoSize = True
        Me.lblTotPercent.Location = New System.Drawing.Point(222, 86)
        Me.lblTotPercent.Name = "lblTotPercent"
        Me.lblTotPercent.Size = New System.Drawing.Size(237, 75)
        Me.lblTotPercent.TabIndex = 3
        Me.lblTotPercent.Text = "Percentage of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "total regional sales " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "over the past 6 months:"
        '
        'rbtnKzn
        '
        Me.rbtnKzn.AutoSize = True
        Me.rbtnKzn.Location = New System.Drawing.Point(18, 38)
        Me.rbtnKzn.Name = "rbtnKzn"
        Me.rbtnKzn.Size = New System.Drawing.Size(181, 29)
        Me.rbtnKzn.TabIndex = 0
        Me.rbtnKzn.TabStop = True
        Me.rbtnKzn.Text = "Kwazulu-Natal"
        Me.rbtnKzn.UseVisualStyleBackColor = True
        '
        'rbtnGp
        '
        Me.rbtnGp.AutoSize = True
        Me.rbtnGp.Location = New System.Drawing.Point(18, 86)
        Me.rbtnGp.Name = "rbtnGp"
        Me.rbtnGp.Size = New System.Drawing.Size(125, 29)
        Me.rbtnGp.TabIndex = 1
        Me.rbtnGp.TabStop = True
        Me.rbtnGp.Text = "Gauteng"
        Me.rbtnGp.UseVisualStyleBackColor = True
        '
        'rbtnWc
        '
        Me.rbtnWc.AutoSize = True
        Me.rbtnWc.Location = New System.Drawing.Point(18, 134)
        Me.rbtnWc.Name = "rbtnWc"
        Me.rbtnWc.Size = New System.Drawing.Size(180, 29)
        Me.rbtnWc.TabIndex = 2
        Me.rbtnWc.TabStop = True
        Me.rbtnWc.Text = "Western Cape"
        Me.rbtnWc.UseVisualStyleBackColor = True
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(13, -8)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(0, 25)
        Me.lblRegion.TabIndex = 9
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(42, 58)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(387, 88)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "ITI Hub regional sales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(6 month history):"
        '
        'lblRegionalSalesList
        '
        Me.lblRegionalSalesList.AutoSize = True
        Me.lblRegionalSalesList.Location = New System.Drawing.Point(45, 544)
        Me.lblRegionalSalesList.Name = "lblRegionalSalesList"
        Me.lblRegionalSalesList.Size = New System.Drawing.Size(462, 25)
        Me.lblRegionalSalesList.TabIndex = 8
        Me.lblRegionalSalesList.Text = "Regional sales totals per month over 6 months:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(47, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(207, 70)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtTotalCompSales
        '
        Me.txtTotalCompSales.Location = New System.Drawing.Point(498, 478)
        Me.txtTotalCompSales.Name = "txtTotalCompSales"
        Me.txtTotalCompSales.Size = New System.Drawing.Size(344, 31)
        Me.txtTotalCompSales.TabIndex = 6
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Location = New System.Drawing.Point(282, 484)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(216, 25)
        Me.lblTotalSales.TabIndex = 7
        Me.lblTotalSales.Text = "Total company sales:"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'gboxRegion
        '
        Me.gboxRegion.Controls.Add(Me.lblRegion)
        Me.gboxRegion.Controls.Add(Me.rbtnKzn)
        Me.gboxRegion.Controls.Add(Me.txtPercentage)
        Me.gboxRegion.Controls.Add(Me.lblTotPercent)
        Me.gboxRegion.Controls.Add(Me.rbtnGp)
        Me.gboxRegion.Controls.Add(Me.rbtnWc)
        Me.gboxRegion.Location = New System.Drawing.Point(276, 279)
        Me.gboxRegion.Name = "gboxRegion"
        Me.gboxRegion.Size = New System.Drawing.Size(573, 181)
        Me.gboxRegion.TabIndex = 5
        Me.gboxRegion.TabStop = False
        Me.gboxRegion.Text = "Region sales percentage:"
        '
        'pboxGraph
        '
        Me.pboxGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pboxGraph.Image = CType(resources.GetObject("pboxGraph.Image"), System.Drawing.Image)
        Me.pboxGraph.InitialImage = Nothing
        Me.pboxGraph.Location = New System.Drawing.Point(597, 35)
        Me.pboxGraph.Name = "pboxGraph"
        Me.pboxGraph.Size = New System.Drawing.Size(252, 238)
        Me.pboxGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxGraph.TabIndex = 19
        Me.pboxGraph.TabStop = False
        '
        'ITI_Hub_regional_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 865)
        Me.Controls.Add(Me.pboxGraph)
        Me.Controls.Add(Me.gboxRegion)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.txtTotalCompSales)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblRegionalSalesList)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lstRegionalSales)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDispRegPerc)
        Me.Controls.Add(Me.btnDispSalesHist)
        Me.Name = "ITI_Hub_regional_sales"
        Me.Text = "ITI Hub regional sales"
        Me.gboxRegion.ResumeLayout(False)
        Me.gboxRegion.PerformLayout()
        CType(Me.pboxGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDispSalesHist As Button
    Friend WithEvents btnDispRegPerc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstRegionalSales As ListBox
    Friend WithEvents txtPercentage As TextBox
    Friend WithEvents lblTotPercent As Label
    Friend WithEvents rbtnKzn As RadioButton
    Friend WithEvents rbtnGp As RadioButton
    Friend WithEvents rbtnWc As RadioButton
    Friend WithEvents lblRegion As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblRegionalSalesList As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtTotalCompSales As TextBox
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents gboxRegion As GroupBox
    Friend WithEvents pboxGraph As PictureBox
End Class
