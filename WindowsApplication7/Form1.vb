Public Class Form1


    Dim arrNum(41) As Integer
    Dim curNum As Integer
    Dim i As Integer = 0


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Var NON-GLO   'return con   'tester
        ' Dim arrNum(101) As Integer
        ' Dim curNum As Integer
        ' Dim i As Integer = 0
        ' Dim strTest As String
        ' strTest = ""
        'IO.File.AppendAllText("D:\PooN\Rannum.txt", "")


        ' While (1)
        Label1.Text = ""
Start: 'loop for found number in arrnum
        Randomize()
        curNum = Int((40 * Rnd()) + 1) ' random number 1 to 49

        If Array.IndexOf(arrNum, curNum) <> -1 Then 'find curNum in arrNum ,if not found return -1

            'tester 100%
            If i = 40 Then
                Label1.Text = "GAME OVER :("
                GoTo End_process
                ' GoTo End_while
            End If

            GoTo Start
        End If

        'process
        arrNum(i) = curNum
        i += 1
        'tester 100%
        ' strTest += curNum.ToString + vbNewLine

        'show num
        Label2.Text = "i = " + i.ToString
        Label1.Text = curNum

        ' End While
        ' End_while: 'END TEST
End_process:
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        '   Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class
