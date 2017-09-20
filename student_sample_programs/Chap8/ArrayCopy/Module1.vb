Module Module1

	' Shows the easy way to copy an array.
	Const NUM_SCORES As Integer = 20
	Dim intOldScores(NUM_SCORES) As Integer
	Dim intNewScores(NUM_SCORES) As Integer

	Sub Main()

		Dim j As Integer
		For j = 1 To NUM_scores
			intNewScores(j) = intOldScores(j)
		Next

		Console.WriteLine("done")

	End Sub

End Module
