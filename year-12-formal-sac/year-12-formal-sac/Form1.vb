Imports System.Xml

Public Class Form1
    Dim xmlDoc As New XmlDocument()
    Dim xmlFilePath As String = "GuestRecords.xml"
    Dim blnItemsValid As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(xmlFilePath) Then
            xmlDoc.Load(xmlFilePath)
            LoadSalesReport()
        Else
            Dim xmlDeclaration As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            xmlDoc.AppendChild(xmlDeclaration)
            Dim rootNode As XmlNode = xmlDoc.CreateElement("Records")
            xmlDoc.AppendChild(rootNode)
            xmlDoc.Save(xmlFilePath)
        End If
    End Sub

    Private Sub btnBuyTickets_Click(sender As Object, e As EventArgs) Handles btnBuyTickets.Click
        DoValidation()

        If blnItemsValid Then
            Dim strName As String = txtName.Text
            Dim intNumTickets As Integer = Val(txtNumTickets.Text)
            Dim dblAmountPaid As Double = Val(txtAmountPaid.Text)
            Dim blnDietaryRequirements As Boolean = cbxDietaryRequirements.Checked

            Dim guestNode As XmlNode = xmlDoc.CreateElement("GUEST")

            Dim guestNameNode As XmlNode = xmlDoc.CreateElement("GuestName")
            guestNameNode.InnerText = txtName.Text
            guestNode.AppendChild(guestNameNode)

            Dim numTicketsNode As XmlNode = xmlDoc.CreateElement("NumTickets")
            numTicketsNode.InnerText = txtNumTickets.Text
            guestNode.AppendChild(numTicketsNode)

            Dim amountPaidNode As XmlNode = xmlDoc.CreateElement("AmountPaid")
            amountPaidNode.InnerText = txtAmountPaid.Text
            guestNode.AppendChild(amountPaidNode)

            Dim dietaryRequirementsNode As XmlNode = xmlDoc.CreateElement("DietaryRequirements")
            If blnDietaryRequirements Then
                dietaryRequirementsNode.InnerText = "Yes"
                guestNode.AppendChild(dietaryRequirementsNode)
            Else
                dietaryRequirementsNode.InnerText = "No"
                guestNode.AppendChild(dietaryRequirementsNode)
            End If

            Dim rootNode As XmlNode = xmlDoc.SelectSingleNode("Records")
            rootNode.AppendChild(guestNode)

            xmlDoc.Save(xmlFilePath)

            LoadSalesReport()

            MessageBox.Show("Your ticket purchase has been successfully recorded.")
        End If
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        LoadSalesReport()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtNumTickets.Clear()
        txtAmountPaid.Clear()
        cbxDietaryRequirements.Checked = False
        lstData.Items.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnDietaryRequirements_Click(sender As Object, e As EventArgs) Handles btnDietaryRequirements.Click
        Dim strName As String
        Dim intNumTickets As Integer
        Dim dblAmountPaid As Double
        Dim strDietaryRequirements As String

        Dim guestNodes As XmlNodeList = xmlDoc.SelectNodes("//GUEST")

        lstData.Items.Clear()

        lstData.Items.Add("Guests who have dietary requirements:")

        For Each guestNode As XmlNode In guestNodes
            strName = guestNode.SelectSingleNode("GuestName").InnerText
            intNumTickets = Val(guestNode.SelectSingleNode("NumTickets").InnerText)
            dblAmountPaid = Val(guestNode.SelectSingleNode("AmountPaid").InnerText)
            strDietaryRequirements = guestNode.SelectSingleNode("DietaryRequirements").InnerText

            If strDietaryRequirements = "Yes" Then
                lstData.Items.Add(strName)
            End If
        Next
    End Sub

    Private Sub LoadSalesReport()
        Dim strName As String
        Dim intNumTickets As Integer
        Dim dblAmountPaid As Double
        Dim dblAmountOwed As Double
        Dim intTotalSold As Integer
        Dim dblTotalPaid As Double
        Dim dblTotalOwed As Double

        Dim guestNodes As XmlNodeList = xmlDoc.SelectNodes("//GUEST")

        lstData.Items.Clear()

        For Each guestNode As XmlNode In guestNodes
            intNumTickets = Val(guestNode.SelectSingleNode("NumTickets").InnerText)
            dblAmountPaid = Val(guestNode.SelectSingleNode("AmountPaid").InnerText)

            intTotalSold = intTotalSold + intNumTickets
            dblTotalPaid = dblTotalPaid + dblAmountPaid
            dblTotalOwed = (intTotalSold * 95) - dblTotalPaid
        Next

        lstData.Items.Add("Total number of tickets sold: " & intTotalSold)
        lstData.Items.Add("Total amount of money paid: " & FormatCurrency(dblTotalPaid))
        lstData.Items.Add("Total amount still owed by guests: " & FormatCurrency(dblTotalOwed))
        lstData.Items.Add("Guests who have part-paid tickets:")

        For Each guestNode As XmlNode In guestNodes
            strName = guestNode.SelectSingleNode("GuestName").InnerText
            intNumTickets = Val(guestNode.SelectSingleNode("NumTickets").InnerText)
            dblAmountPaid = Val(guestNode.SelectSingleNode("AmountPaid").InnerText)

            dblAmountOwed = (intNumTickets * 95) - dblAmountPaid

            If dblAmountOwed > 0 Then
                lstData.Items.Add(strName)
            End If
        Next
    End Sub

    Private Sub DoValidation()
        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("Please enter a guest name.")
            blnItemsValid = False
            txtName.Focus()
            Return
        ElseIf IsNumeric(txtName.Text) = True Then
            MessageBox.Show("The guest name should not include numbers.")
            blnItemsValid = False
            txtName.Focus()
            Return
        ElseIf String.IsNullOrEmpty(txtNumTickets.Text) Then
            MessageBox.Show("Please enter the number of tickets.")
            blnItemsValid = False
            txtNumTickets.Focus()
            Return
        ElseIf IsNumeric(txtNumTickets.Text) = False Then
            MessageBox.Show("The number of tickets should only include numbers.")
            blnItemsValid = False
            txtName.Focus()
            Return
        ElseIf String.IsNullOrEmpty(txtAmountPaid.Text) Then
            MessageBox.Show("Please enter the amount paid.")
            blnItemsValid = False
            txtAmountPaid.Focus()
            Return
        ElseIf IsNumeric(txtAmountPaid.Text) = False Then
            MessageBox.Show("The amount paid should only include numbers.")
            blnItemsValid = False
            txtAmountPaid.Focus()
            Return
        Else
            blnItemsValid = True
        End If
    End Sub
End Class