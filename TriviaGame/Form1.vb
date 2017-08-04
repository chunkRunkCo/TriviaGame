Public Class Form1
    Dim question As Integer
    Dim cheats As String
    Dim score As Integer

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Enabled = True
        Label1.Text = "Why?"
        'Panel2.Enabled = True
        RadioButton1.Text = ("Because.")
        RadioButton2.Text = ("Not my problem.")
        RadioButton3.Text = ("Why not?")
        RadioButton4.Text = ("Go away!")
        question = 1
        Button1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton2.Checked And question = 1 Then
            MsgBox("Correct.")
            score = score + 1
        ElseIf RadioButton1.Checked And question = 2 Then
            MsgBox("Correct.")
            score = score + 2
        ElseIf RadioButton4.Checked And question = 3 Then
            MsgBox("Correct.")
            score = score + 3
        ElseIf RadioButton1.Checked And question = 4 Then
            MsgBox("Correct.")
            score = score + 4
        ElseIf RadioButton3.Checked And question = 5 Then
            MsgBox("Correct.")
            score = score + 5
        ElseIf RadioButton4.Checked And question = 6 Then
            MsgBox("Correct.")
            score = score + 6
        Else
            MsgBox("Incorrect.")
        End If
        Button2.Enabled = True

        If Label2.Text = "Cheats Enabled" Then
            score = score + 999999
        End If
        Panel1.Enabled = False
        Label3.Text = score
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Enabled = True
        Label1.Text = "What is the answer?"
        RadioButton1.Text = ("42")
        RadioButton2.Text = ("24")
        RadioButton3.Text = ("Nothing")
        RadioButton4.Text = ("What solves the problem")
        question = 2
        Button2.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Enabled = True
        Label1.Text = "What is the squared root of 144?"
        RadioButton1.Text = ("Uh, 42?")
        RadioButton2.Text = ("No.")
        RadioButton3.Text = ("wut")
        RadioButton4.Text = ("Duh, 12.")
        question = 3
        Button4.Enabled = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Enabled = True
        Label1.Text = "What time is it?"
        RadioButton1.Text = ("I don't know.")
        RadioButton2.Text = ("It is time.")
        RadioButton3.Text = ("42 AM?")
        RadioButton4.Text = ("Answer.")
        question = 4
        Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Enabled = True
        Label1.Text = "Say the alphabet backwards."
        RadioButton1.Text = ("No thanks.")
        RadioButton2.Text = ("zyxwvutsrq...")
        RadioButton3.Text = ("tebahpla")
        RadioButton4.Text = ("FFFFFFFFFF")
        question = 5
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Enabled = True
        Label1.Text = "What vegetable goes great in an undersea salad?"
        RadioButton1.Text = ("Triangle.")
        RadioButton2.Text = ("14?")
        RadioButton3.Text = ("Teal.")
        RadioButton4.Text = ("SEACUCUMBER!!!")
        question = 6
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label2.Text = "Cheats Enabled"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MsgBox("B A Z I N G A")
    End Sub
End Class
