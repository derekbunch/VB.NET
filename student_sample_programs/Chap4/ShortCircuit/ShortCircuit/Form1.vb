Public Class Form1

	Dim intValueA, intValueB, intValueC, intValueD As Integer

	Function CheckExpression1() As Boolean
		intValueA = CInt(txtValueA.Text)
		intValueB = CInt(txtValueB.Text)
		If intValueA > intValueB Then
			lstResult.Items.Add("Expression 1 is True")
			Return True
		Else
			lstResult.Items.Add("Expression 1 is False")
			Return False
		End If
	End Function


	Function CheckExpression2() As Boolean
		intValueC = CInt(txtValueC.Text)
		intValueD = CInt(txtValueD.Text)
		If intValueC < intValueD Then
			lstResult.Items.Add("Expression 2 is True")
			Return True
		Else
			lstResult.Items.Add("Expression 2 is False")
			Return False
		End If
	End Function

	Private Sub btnOr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOr.Click
		'The OR operator does not perform short-circuit evaluation.

		lstResult.Items.Clear()
		If CheckExpression1() Or CheckExpression2() Then
			lstResult.Items.Add(">> Final result is TRUE")
		Else
			lstResult.Items.Add(">> Final result is FALSE")
		End If
	End Sub

	Private Sub btnOrElse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrElse.Click

		'The OrElse operator performs short-circuit evaluation.

		lstResult.Items.Clear()
		If CheckExpression1() OrElse CheckExpression2() Then
			lstResult.Items.Add(">> Final result is TRUE")
		Else
			lstResult.Items.Add(">> Final result is FALSE")
		End If

	End Sub

	Private Sub btnAnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnd.Click

		'The And operator does not perform short-circuit evaluation.
		lstResult.Items.Clear()
		If CheckExpression1() And CheckExpression2() Then
			lstResult.Items.Add(">> Final result is TRUE")
		Else
			lstResult.Items.Add(">> Final result is FALSE")
		End If

	End Sub

	Private Sub btnAndAlso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAndAlso.Click

		'The AndAlso operator performs short-circuit evaluation.
		lstResult.Items.Clear()
		If CheckExpression1() AndAlso CheckExpression2() Then
			lstResult.Items.Add(">> Final result is TRUE")
		Else
			lstResult.Items.Add(">> Final result is FALSE")
		End If
	End Sub
End Class
