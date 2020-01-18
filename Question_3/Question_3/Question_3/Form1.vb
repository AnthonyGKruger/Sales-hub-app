Public Class ITI_Hub_regional_sales

    Dim salesArray(5, 2), totalCompSales, salesPercentage, tempNum As Integer
    Dim tempString As String

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gboxRegion.Enter

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'code to close the application'
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Code to clear any variables'
        txtPercentage.Clear()
        txtTotalCompSales.Clear()
        lstRegionalSales.Items.Clear()

        'Code to clear any chosen radio buttons'
        rbtnGp.Checked = False
        rbtnKzn.Checked = False
        rbtnWc.Checked = False


    End Sub

    Private Sub btnDispRegPerc_Click(sender As Object, e As EventArgs) Handles btnDispRegPerc.Click

        'Code to clear any variables'
        totalCompSales = 0
        salesPercentage = 0
        tempNum = 0
        txtPercentage.Clear()

        'Assigning data into a two-dimensional array according to month first and the sales per each region for that month'
        salesArray(0, 0) = 120000
        salesArray(0, 1) = 90000
        salesArray(0, 2) = 65000
        salesArray(1, 0) = 190000
        salesArray(1, 1) = 85000
        salesArray(1, 2) = 64000
        salesArray(2, 0) = 175000
        salesArray(2, 1) = 80000
        salesArray(2, 2) = 71000
        salesArray(3, 0) = 188000
        salesArray(3, 1) = 83000
        salesArray(3, 2) = 67000
        salesArray(4, 0) = 125000
        salesArray(4, 1) = 87000
        salesArray(4, 2) = 65000
        salesArray(5, 0) = 163000
        salesArray(5, 1) = 80000
        salesArray(5, 2) = 64000


        'iterating through the range of months first and then through the range of regions that made sales that month, adding it to the total company sales variable'
        For j As Integer = 0 To 5
            For k As Integer = 0 To 2
                totalCompSales += salesArray(j, k)
            Next
        Next

        'code to check if radio button was checked, if checked then temp num is added with the value from the two dimensional array'
        If rbtnGp.Checked Then
            For i As Integer = 0 To 5
                tempNum += salesArray(i, 1)
            Next
        End If

        'code to check if radio button was checked, if checked then temp num is added with the value from the two dimensional array'
        If rbtnKzn.Checked Then
            For i As Integer = 0 To 5
                tempNum += salesArray(i, 0)
            Next
        End If

        'code to check if radio button was checked, if checked then temp num is added with the value from the two dimensional array'
        If rbtnWc.Checked Then
            For i As Integer = 0 To 5
                tempNum += salesArray(i, 2)
            Next
        End If

        'code to calculate the percentage of sales a region contributed to the company'
        salesPercentage = ((tempNum / totalCompSales) * 100)

        If salesPercentage = 0 Then
            MessageBox.Show("Please select a region before requesting its contribution percentage", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'code to add the percentage to a textbox to be displayed'
            txtPercentage.Text = salesPercentage & "%"
        End If
    End Sub


    Private Sub btnDispSalesHist_Click(sender As Object, e As EventArgs) Handles btnDispSalesHist.Click

        'Code to clear any chosen radio buttons'
        rbtnGp.Checked = False
        rbtnKzn.Checked = False
        rbtnWc.Checked = False

        'Code to clear any variables'
        totalCompSales = 0
        salesPercentage = 0
        tempNum = 0
        txtPercentage.Clear()
        lstRegionalSales.Items.Clear()

        'Assigning data into a two-dimensional array according to month first and the sales per each region for that month'
        salesArray(0, 0) = 120000
        salesArray(0, 1) = 90000
        salesArray(0, 2) = 65000
        salesArray(1, 0) = 190000
        salesArray(1, 1) = 85000
        salesArray(1, 2) = 64000
        salesArray(2, 0) = 175000
        salesArray(2, 1) = 80000
        salesArray(2, 2) = 71000
        salesArray(3, 0) = 188000
        salesArray(3, 1) = 83000
        salesArray(3, 2) = 67000
        salesArray(4, 0) = 125000
        salesArray(4, 1) = 87000
        salesArray(4, 2) = 65000
        salesArray(5, 0) = 163000
        salesArray(5, 1) = 80000
        salesArray(5, 2) = 64000

        'code to add headings to the listbox'
        lstRegionalSales.Items.Add("Month         Kwazulu-Natal sales
            Gauteng sales         Western Cape sales")

        'code to go through the two dimensional array and add sales achieved from each region'
        For i As Integer = 0 To 5
            tempString = i + 1 & "                " & " R" & salesArray(i, 0) & "                             " & "R" & salesArray(i, 1) & "                   " & "R" & salesArray(i, 2)
            lstRegionalSales.Items.Add(tempString)
        Next

        'iterating through the range of months first and then through the range of regions that made sales that month, adding it to the total company sales variable'
        For j As Integer = 0 To 5
            For k As Integer = 0 To 2
                totalCompSales += salesArray(j, k)
            Next
        Next

        'code to add the total company sales to the dedicated textbox'
        txtTotalCompSales.Text = "R" & totalCompSales

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
