Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim answer As Integer
        Dim table As Integer
        table = 5
        lbloutput.Text = " five times table" & vbCrLf

        'Loop 10 times
        For Counter = 1 To 10
            ' calculate the answer to the curent sum 
            answer = table * Counter
            'appemd the answer onto the label with suitable formating 
            lbloutput.Text = lbloutput.Text & table & " times " &
           Counter & " = " & answer & vbCrLf
        Next
    End Sub
End Class
