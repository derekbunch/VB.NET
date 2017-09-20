Public Class Form1


    Const oil As Integer = 26D
    Const lube As Integer = 18D
    Const radiator As Integer = 30D
    Const trans As Integer = 80D
    Const inspec As Integer = 15D
    Const replace As Integer = 100D
    Const tire As Integer = 20D
    Const perhour As Integer = 20D
    Const taxrate As Decimal = 0.06D

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim OilLubeCharges As Double
        Dim FlushCharges As Double
        Dim MiscCharges As Double
        Dim TotalCharges As Double
        Dim servicecharges As Double
        Dim intparts As Double
        Dim labor As Double
        Dim laborcharges As Double
        Dim taxcharge As Double
        Dim blnInputOk As Boolean = True
 
        If blnInputOk = True Then

            If chkoil.Checked = True Then
                OilLubeCharges += oil
            End If
            ''''
            If chklube.Checked = True Then
                OilLubeCharges += lube
            End If
            '''''
            If chkradiator.Checked = True Then
                FlushCharges += radiator
            End If
            '''''
            If chktrans.Checked = True Then
                FlushCharges += trans
            End If
            ''''
            If chkinspec.Checked = True Then
                MiscCharges += inspec
            End If
            '''''
            If chkreplace.Checked = True Then
                MiscCharges += replace
            End If
            '''''
            If chktire.Checked = True Then
                MiscCharges = tire
            End If
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''
        'Error Message
        If (txtlabor.Text And txtparts.Text) <= 0 Then
            MessageBox.Show(" Negative amounts are not acceptable")
            blnInputOk = False
        End If
        '''''''''''''''''''''''''''''''''''''''''''
        If blnInputOk = True Then
            intparts = CDbl(txtparts.Text)
            lblparts.Text = intparts.ToString("C")
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''
        labor = perhour * txtlabor.Text
        laborcharges = labor
        ''''''''''''''''''''''''''''''''''''''''
        servicecharges = MiscCharges + FlushCharges + OilLubeCharges + laborcharges
        lblservice.Text = servicecharges.ToString("C")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        taxcharge = (taxrate * intparts)
        lbltax.Text = taxcharge.ToString("C")

        '''''''''''''''''''''''''''''''''''''''''
        'Total Fees
        TotalCharges = taxcharge + intparts + servicecharges
        lbltotal.Text = TotalCharges.ToString("C")



    End Sub


    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        'Clear checkboxes
        chkinspec.Checked = False
        chklube.Checked = False
        chkoil.Checked = False
        chkradiator.Checked = False
        chkreplace.Checked = False
        chktire.Checked = False
        chktrans.Checked = False
        'Clear Parts and labor
        txtparts.Clear()
        txtlabor.Clear()
        'Clear summary
        lblparts.Text = String.Empty
        lblservice.Text = String.Empty
        lbltax.Text = String.Empty
        lbltotal.Text = String.Empty
    End Sub
End Class
