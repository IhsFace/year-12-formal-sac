<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        grpDetails = New GroupBox()
        txtAmountPaid = New TextBox()
        txtNumTickets = New TextBox()
        txtName = New TextBox()
        cbxDietaryRequirements = New CheckBox()
        lblAmountPaid = New Label()
        lblNumTickets = New Label()
        lblName = New Label()
        btnBuyTickets = New Button()
        btnSalesReport = New Button()
        btnClear = New Button()
        btnDietaryRequirements = New Button()
        lblReport = New Label()
        lstData = New ListBox()
        grpDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(409, 37)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(561, 56)
        lblTitle.TabIndex = 0
        lblTitle.Text = "YEAR 12 FORMAL 2024"
        ' 
        ' grpDetails
        ' 
        grpDetails.Controls.Add(txtAmountPaid)
        grpDetails.Controls.Add(txtNumTickets)
        grpDetails.Controls.Add(txtName)
        grpDetails.Controls.Add(cbxDietaryRequirements)
        grpDetails.Controls.Add(lblAmountPaid)
        grpDetails.Controls.Add(lblNumTickets)
        grpDetails.Controls.Add(lblName)
        grpDetails.Location = New Point(58, 129)
        grpDetails.Name = "grpDetails"
        grpDetails.Size = New Size(650, 350)
        grpDetails.TabIndex = 1
        grpDetails.TabStop = False
        grpDetails.Text = "Guest Details"
        ' 
        ' txtAmountPaid
        ' 
        txtAmountPaid.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmountPaid.Location = New Point(283, 188)
        txtAmountPaid.Name = "txtAmountPaid"
        txtAmountPaid.Size = New Size(361, 44)
        txtAmountPaid.TabIndex = 6
        ' 
        ' txtNumTickets
        ' 
        txtNumTickets.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNumTickets.Location = New Point(283, 122)
        txtNumTickets.Name = "txtNumTickets"
        txtNumTickets.Size = New Size(361, 44)
        txtNumTickets.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(283, 57)
        txtName.Name = "txtName"
        txtName.Size = New Size(361, 44)
        txtName.TabIndex = 4
        ' 
        ' cbxDietaryRequirements
        ' 
        cbxDietaryRequirements.AutoSize = True
        cbxDietaryRequirements.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxDietaryRequirements.Location = New Point(6, 261)
        cbxDietaryRequirements.Name = "cbxDietaryRequirements"
        cbxDietaryRequirements.Size = New Size(352, 40)
        cbxDietaryRequirements.TabIndex = 3
        cbxDietaryRequirements.Text = "Dietary Requirements"
        cbxDietaryRequirements.UseVisualStyleBackColor = True
        ' 
        ' lblAmountPaid
        ' 
        lblAmountPaid.AutoSize = True
        lblAmountPaid.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmountPaid.Location = New Point(6, 188)
        lblAmountPaid.Name = "lblAmountPaid"
        lblAmountPaid.Size = New Size(196, 36)
        lblAmountPaid.TabIndex = 2
        lblAmountPaid.Text = "Amount Paid"
        ' 
        ' lblNumTickets
        ' 
        lblNumTickets.AutoSize = True
        lblNumTickets.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumTickets.Location = New Point(6, 122)
        lblNumTickets.Name = "lblNumTickets"
        lblNumTickets.Size = New Size(271, 36)
        lblNumTickets.TabIndex = 1
        lblNumTickets.Text = "Number of Tickets"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(6, 60)
        lblName.Name = "lblName"
        lblName.Size = New Size(193, 36)
        lblName.TabIndex = 0
        lblName.Text = "Guest Name"
        ' 
        ' btnBuyTickets
        ' 
        btnBuyTickets.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuyTickets.Location = New Point(37, 514)
        btnBuyTickets.Name = "btnBuyTickets"
        btnBuyTickets.Size = New Size(350, 75)
        btnBuyTickets.TabIndex = 2
        btnBuyTickets.Text = "Buy Tickets"
        btnBuyTickets.UseVisualStyleBackColor = True
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalesReport.Location = New Point(393, 514)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Size = New Size(350, 75)
        btnSalesReport.TabIndex = 3
        btnSalesReport.Text = "Ticket Sales Report"
        btnSalesReport.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(37, 622)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(350, 75)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDietaryRequirements
        ' 
        btnDietaryRequirements.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDietaryRequirements.Location = New Point(393, 622)
        btnDietaryRequirements.Name = "btnDietaryRequirements"
        btnDietaryRequirements.Size = New Size(350, 75)
        btnDietaryRequirements.TabIndex = 5
        btnDietaryRequirements.Text = "Dietary Requirements"
        btnDietaryRequirements.UseVisualStyleBackColor = True
        ' 
        ' lblReport
        ' 
        lblReport.AutoSize = True
        lblReport.Font = New Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReport.Location = New Point(978, 129)
        lblReport.Name = "lblReport"
        lblReport.Size = New Size(175, 44)
        lblReport.TabIndex = 6
        lblReport.Text = "REPORT"
        ' 
        ' lstData
        ' 
        lstData.BackColor = Color.LemonChiffon
        lstData.Font = New Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstData.FormattingEnabled = True
        lstData.ItemHeight = 24
        lstData.Location = New Point(788, 186)
        lstData.Name = "lstData"
        lstData.Size = New Size(557, 508)
        lstData.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Salmon
        ClientSize = New Size(1374, 729)
        Controls.Add(lstData)
        Controls.Add(lblReport)
        Controls.Add(btnDietaryRequirements)
        Controls.Add(btnClear)
        Controls.Add(btnSalesReport)
        Controls.Add(btnBuyTickets)
        Controls.Add(grpDetails)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Y12 FORMAL"
        grpDetails.ResumeLayout(False)
        grpDetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents lblNumTickets As Label
    Friend WithEvents cbxDietaryRequirements As CheckBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumTickets As TextBox
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents btnBuyTickets As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDietaryRequirements As Button
    Friend WithEvents lblReport As Label
    Friend WithEvents lstData As ListBox

End Class
