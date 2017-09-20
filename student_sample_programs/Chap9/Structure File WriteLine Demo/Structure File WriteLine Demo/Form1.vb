Imports System.IO

Public Class Form1

    ' Structure to hold friend information

    Structure FriendInfo
        Dim strName As String   ' To hold a name
        Dim strPhone As String  ' To hold a phone number
    End Structure

    Private Sub btnCreateFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFile.Click
        ' Constant for the number of friends
        Const intNUM_FRIENDS As Integer = 3

        ' Local variables
        Dim strFilename As String       ' File name
        Dim intCount As Integer         ' Loop counter
        Dim friendFile As StreamWriter  ' Object variable
        Dim myFriend As FriendInfo      ' Structure variable

        ' Get the file name from the user.
        strFilename = InputBox("Enter the filename.")

        Try
            ' Open the file.
            friendFile = File.CreateText(strFilename)

            ' Get the data and write it to the file.
            For intCount = 1 To intNUM_FRIENDS
                ' Get a friend's name.
                myFriend.strName = InputBox("Enter the name of friend " &
                                            "number " & intCount.ToString())

                ' Get a friend's phone number.
                myFriend.strPhone = InputBox("Enter the that friend's " &
                                             "phone number.")

                ' Write the data to the file.
                friendFile.WriteLine(myFriend.strName)
                friendFile.WriteLine(myFriend.strPhone)
            Next

            ' Close the file.
            friendFile.Close()
        Catch
            ' Error message
            MessageBox.Show("That file cannot be created.")
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class

