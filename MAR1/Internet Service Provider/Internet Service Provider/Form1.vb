Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnCalculateClick_Click(sender As Object, e As EventArgs) Handles btnCalculateClick.Click
        Dim decBaseFee As Decimal       ' Base Fee
        Dim decTotalFee As Decimal      ' Total Fee
        Dim intHours As Integer        ' Number of hours
        Dim blnInputOk As Boolean = True

        ' Constants for base fees.
        Const decPackageA_FEE As Decimal = 9.95D
        Const decPackageB_FEE As Decimal = 14.95D
        Const decPackageC_FEE As Decimal = 19.95D
        Const decNonprofitA_FEE As Decimal = 7.96D
        Const decNonprofitB_FEE As Decimal = 11.96D
        Const decNonprofitC_FEE As Decimal = 15.96D


        ' Constants for additional fees.
        Const decAdditionalA_FEE As Decimal = 2D
        Const decAdditionalB_FEE As Decimal = 1D
        Const decAdditionalNPA_FEE As Decimal = 1.6D
        Const decAdditionalNPB_FEE As Decimal = 0.8D

        ' Validate and convert the number of hours.
        lblStatus.Text = String.Empty
        If Integer.TryParse(txtHours.Text, intHours) = False Then
            lblStatus.Text = "Hours must be numeric."
            blnInputOk = False
        End If

        ' Validate the number of Hours.
        If intHours < 1 Or intHours > 744 Then
            lblStatus.Text = "Hours must be in the range 1 - 744."
            blnInputOk = False
        End If

        If blnInputOk = True Then
            ' Determine the base fee.
            If radA.Checked = True Then
                If chkNonprofit.Checked = True Then
                    decBaseFee = decNonprofitA_FEE
                Else
                    decBaseFee = decPackageA_FEE
                End If
            ElseIf radB.Checked = True Then
                If chkNonprofit.Checked = True Then
                    decBaseFee = decNonprofitB_FEE
                Else
                    decBaseFee = decPackageB_FEE
                End If
            ElseIf radC.Checked = True Then
                If chkNonprofit.Checked = True Then
                    decBaseFee = decNonprofitC_FEE
                Else
                    decBaseFee = decPackageC_FEE
                End If
            End If
        End If

        ' Check for additional hours.
        If radA.Checked = True Then
            If chkNonprofit.Checked = True Then
                If intHours > 10 Then
                    decBaseFee = (decBaseFee + (intHours - 10) * decAdditionalNPA_FEE)
                End If
            Else
                If intHours > 10 Then
                    decBaseFee = (decBaseFee + (intHours - 10) * decAdditionalA_FEE)
                End If
            End If
        ElseIf radB.Checked = True Then
            If chkNonprofit.Checked = True Then
                If intHours > 20 Then
                    decBaseFee = (decBaseFee + (intHours - 20) * decAdditionalNPB_FEE)
                End If
            Else
                If intHours > 20 Then
                    decBaseFee = (decBaseFee + (intHours - 20) * decAdditionalB_FEE)
                End If
            End If
        End If

        'Calculate the total fee.
        decTotalFee = decBaseFee

        ' Display the fees.
        lblTotal.Text = decTotalFee.ToString("c")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Reset all labels, radio buttons, text boxes, and check boxes.
        radA.Checked = True
        chkNonprofit.Checked = False
        txtHours.Clear()
        lblTotal.Text = String.Empty
        lblStatus.Text = String.Empty

        ' Give txtHours the focus.
        txtHours.Focus()
    End Sub
End Class
