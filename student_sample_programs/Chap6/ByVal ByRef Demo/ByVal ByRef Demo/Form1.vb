Public Class Form1

    Private Sub btnGo_Click(ByVal sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        Dim intNumber As Integer = 100
        lstOutput.Items.Add("Inside btnGo_Click the value of " &
                            "intNumber is " &
                            intNumber.ToString())

        lstOutput.Items.Add("Now I am calling ChangeArg.")

        ChangeArg(intNumber)
        lstOutput.Items.Add("Now back in btnGo_Click, " &
                                      "the value of intNumber is " &
                                  intNumber.ToString())
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

	Sub ChangeArg(ByVal intArg As Integer)
		' Display the value of intArg.
		lstOutput.Items.Add(" ")
		lstOutput.Items.Add("Inside the ChangeArg procedure, " &
								  "intArg is " & intArg.ToString())
		lstOutput.Items.Add("I will change the value of intArg.")

		' Assign 0 to intArg.
		intArg = 0

		' Display the value of intArg.
		lstOutput.Items.Add("intArg is now " & intArg.ToString())
		lstOutput.Items.Add(" ")
	End Sub
End Class
