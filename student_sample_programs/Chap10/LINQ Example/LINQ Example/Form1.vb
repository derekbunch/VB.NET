Public Class Form1
    ' Create an array of integers.
    Dim intNumbers() As Integer = {4, 104, 2, 102, 1, 101, 3, 103}

    Private Sub btnDisplayValues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayValues.Click
        ' Clear the list box.
        lstResults.Items.Clear()

        ' Select all the items from the array.
        Dim queryResults = From item In intNumbers
        Select item

        ' Add the query results to the list box.
        For Each intNum As Integer In intNumbers
            lstResults.Items.Add(intNum)
        Next
    End Sub

    Private Sub btnExecuteQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecuteQuery.Click
        ' Clear the list box.
        lstResults.Items.Clear()

        ' Get the results.
        Dim queryResults = From item In intNumbers
        Where item > 100
        Select item

        ' Add the query results to the list box.
        For Each intNum As Integer In queryResults
            lstResults.Items.Add(intNum)
        Next
    End Sub

    Private Sub btnSortAcending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortAcending.Click
        ' Clear the list box.
        lstResults.Items.Clear()

        ' Sort the results in acending order.
        Dim queryResults = From item In intNumbers
                           Where item > 100
                           Select item
                           Order By item

        ' Add the query results to the list box.
        For Each intNum As Integer In queryResults
            lstResults.Items.Add(intNum)
        Next
    End Sub

    Private Sub btnSortDecending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortDecending.Click
        ' Clear the list box.
        lstResults.Items.Clear()

        ' Sort the results in decending order.
        Dim queryResults = From item In intNumbers
                           Where item > 100
                           Select item
                           Order By item Descending

        ' Add the query results to the list box.
        For Each intNum As Integer In queryResults
            lstResults.Items.Add(intNum)
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
