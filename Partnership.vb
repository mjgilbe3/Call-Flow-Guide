Imports System.Diagnostics.CodeAnalysis
Imports System.Diagnostics.Eventing.Reader
Imports System.IO.Pipes
Imports System.Net.Http.Headers
Imports System.Security.Principal
Imports System.Threading
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles
Imports Accessibility

Public Class Partnership
    Private WithEvents Menu As Button
    Private Sub UpdateScore()

        Dim totalProgress As Integer
        Dim maxProgress As Integer = 5

        If UnderstandProgress.Value = UnderstandProgress.Maximum = True Then
            totalProgress += 1
        End If
        If DiscoverProgress.Value = DiscoverProgress.Maximum = True Then
            totalProgress += 1
        End If
        If EducateProgress.Value = EducateProgress.Maximum = True Then
            totalProgress += 1
        End If
        If AdvocateProgress.Value = AdvocateProgress.Maximum = True Then
            totalProgress += 1
        End If
        If ReviewProgress.Value = ReviewProgress.Maximum = True Then
            totalProgress += 1
        End If

        Dim totalscore As Double = CDbl(totalProgress) / maxProgress * 5

        Score.Text = totalscore.ToString("0.0")

        If totalscore = 5.0 Then
            PerfectCall.Visible = True
        Else
            PerfectCall.Visible = False
        End If
    End Sub

    Private Sub UpdateProgressBarColors()
        ' Set the progress bar colors based on the value and maximum value
        If UnderstandProgress.Value < UnderstandProgress.Maximum Then
            UnderstandProgress.ForeColor = Color.Red
        Else
            UnderstandProgress.ForeColor = Color.Green
        End If

        If DiscoverProgress.Value < DiscoverProgress.Maximum Then
            DiscoverProgress.ForeColor = Color.Red
        Else
            DiscoverProgress.ForeColor = Color.Green
        End If
        If EducateProgress.Value < EducateProgress.Maximum Then
            EducateProgress.ForeColor = Color.Red
        Else
            EducateProgress.ForeColor = Color.Green
        End If
        If AdvocateProgress.Value < AdvocateProgress.Maximum Then
            AdvocateProgress.ForeColor = Color.Red
        Else
            AdvocateProgress.ForeColor = Color.Green
        End If

        If ReviewProgress.Value < ReviewProgress.Maximum Then
            ReviewProgress.ForeColor = Color.Red
        Else
            ReviewProgress.ForeColor = Color.Green
        End If
    End Sub

    Private Sub UpdateProgressBars()
        Call UpdateProgressBarColors()
        Call UpdateScore()
    End Sub
    Private Sub CallExpectationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateProgressBars()
    End Sub

    Private Sub Understand1_CheckedChanged(sender As Object, e As EventArgs) Handles Understand1.CheckedChanged
        If Understand1.Checked Then
            UnderstandProgress.Value += 1
        Else
            UnderstandProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub

    Private Sub Discover1_CheckedChanged(sender As Object, e As EventArgs) Handles Discover1.CheckedChanged
        If Discover1.Checked Then
            DiscoverProgress.Value += 1
        Else
            DiscoverProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub

    Private Sub Discover2_CheckedChanged(sender As Object, e As EventArgs) Handles Discover2.CheckedChanged
        If Discover2.Checked Then
            DiscoverProgress.Value += 1
        Else
            DiscoverProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub

    Private Sub Discover3_CheckedChanged(sender As Object, e As EventArgs) Handles Discover3.CheckedChanged
        If Discover3.Checked Then
            DiscoverProgress.Value += 1
        Else
            DiscoverProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub

    Private Sub Educate1_CheckedChanged(sender As Object, e As EventArgs) Handles Educate1.CheckedChanged
        If Educate1.Checked Then
            EducateProgress.Value += 1
        Else
            EducateProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub

    Private Sub Educate2_CheckedChanged(sender As Object, e As EventArgs) Handles Educate2.CheckedChanged
        If Educate2.Checked Then
            EducateProgress.Value += 1
        Else
            EducateProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub

    Private Sub Educate3_CheckedChanged(sender As Object, e As EventArgs) Handles Educate3.CheckedChanged
        If Educate3.Checked Then
            EducateProgress.Value += 1
        Else
            EducateProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub


    '1st Question in Advocate
    Private Sub Yes1_CheckedChanged_1(sender As Object, e As EventArgs) Handles AdvocateYes1.CheckedChanged
        If AdvocateQuestion1.Text = "Does the customer have an account?" Then
            If AdvocateYes1.Checked Then
                AdvocateNo1.Checked = False
                AdvocateYes1.BackColor = Color.DarkGray
                AdvocateNo1.BackColor = Color.White

                AdvocateQuestion1.Text = "Can the customer access their account?"
                AdvocateYes1.BackColor = Color.White
                AdvocateNo1.BackColor = Color.White
                AdvocateYes1.Checked = False
                AdvocateNo1.Checked = False
            End If
        Else
            If AdvocateQuestion1.Text = "Can the customer access their account?" Then
                If AdvocateYes1.Checked Then
                    AdvocateNo1.Checked = False
                    AdvocateYes1.BackColor = Color.DarkGray
                    AdvocateNo1.BackColor = Color.White

                    If Advocate1.Checked = True Then
                        Advocate1.Checked = False
                    End If
                    Advocate1.Text = "Have the customer login!"
                    Advocate1.Visible = True
                End If
            End If
        End If
    End Sub
    Private Sub No1_CheckedChanged_1(sender As Object, e As EventArgs) Handles AdvocateNo1.CheckedChanged
        If AdvocateQuestion1.Text = "Does the customer have an account?" Then
            If AdvocateNo1.Checked Then
                AdvocateYes1.Checked = False
                AdvocateNo1.BackColor = Color.DarkGray
                AdvocateYes1.BackColor = Color.White
            End If
            If Advocate1.Checked = True Then
                Advocate1.Checked = False
            End If
            Advocate1.Text = "Create a Carvana.com account!"
            Advocate1.Visible = True
        Else
            If AdvocateQuestion1.Text = "Can the customer access their account?" Then
                If AdvocateNo1.Checked Then
                    AdvocateYes1.Checked = False
                    AdvocateNo1.BackColor = Color.DarkGray
                    AdvocateYes1.BackColor = Color.White
                End If
                If Advocate1.Checked = True Then
                    Advocate1.Checked = False
                End If
                Advocate1.Text = "Send the Password Reset Link"
                Advocate1.Visible = True
            End If
        End If
    End Sub


    '2nd Question in Advocate
    Private Sub Yes2_CheckedChanged(sender As Object, e As EventArgs) Handles AdvocateYes2.CheckedChanged
        If AdvocateQuestion2.Text = "Were we able to find a vehicle?" Then
            If AdvocateYes2.Checked Then
                AdvocateNo2.Checked = False
                AdvocateYes2.BackColor = Color.DarkGray
                AdvocateNo2.BackColor = Color.White

                If Advocate2.Checked = True Then
                    Advocate2.Checked = False
                End If
                Advocate2.Text = "Lock in that vehicle"
                Advocate2.Visible = True
            End If
        End If
    End Sub

    Private Sub No2_CheckedChanged(sender As Object, e As EventArgs) Handles AdvocateNo2.CheckedChanged
        If AdvocateQuestion2.Text = "Were we able to find a vehicle?" Then
            If AdvocateNo2.Checked Then
                AdvocateYes2.Checked = False
                AdvocateNo2.BackColor = Color.DarkGray
                AdvocateYes2.BackColor = Color.White

                If Advocate2.Checked = True Then
                    Advocate2.Checked = False
                End If
                Advocate2.Text = "Set up Search Alerts"
                Advocate2.Visible = True
            End If
        End If
    End Sub

    Private Sub Yes3_CheckedChanged(sender As Object, e As EventArgs) Handles AdvocateYes3.CheckedChanged
        If AdvocateQuestion3.Text = "Customer looking to finance with Carvana?" Then
            If AdvocateYes3.Checked Then
                AdvocateNo3.Checked = False
                AdvocateYes3.BackColor = Color.DarkGray
                AdvocateNo3.BackColor = Color.White

                Advocate3.Text = "Have customer complete Soft Pull"
                Advocate3.Visible = True
            End If
        End If
    End Sub

    Private Sub No3_CheckedChanged(sender As Object, e As EventArgs) Handles AdvocateNo3.CheckedChanged
        If AdvocateQuestion3.Text = "Customer looking to finance with Carvana?" Then
            If AdvocateNo3.Checked Then
                AdvocateYes3.Checked = False
                AdvocateNo3.BackColor = Color.DarkGray
                AdvocateYes3.BackColor = Color.White

                Advocate3.Text = "Confirm you have gone over Cash/3rd Party"
                Advocate3.Visible = True
            End If
        End If
    End Sub

    Private Sub Advocate1_CheckedChanged(sender As Object, e As EventArgs) Handles Advocate1.CheckedChanged
        If Advocate1.Checked Then
            AdvocateProgress.Value += 1
        Else
            AdvocateProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub
    Private Sub Advocate2_CheckedChanged(sender As Object, e As EventArgs) Handles Advocate2.CheckedChanged
        If Advocate2.Checked Then
            AdvocateProgress.Value += 1
        Else
            AdvocateProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub
    Private Sub Advocate3_CheckedChanged(sender As Object, e As EventArgs) Handles Advocate3.CheckedChanged
        If Advocate3.Checked Then
            AdvocateProgress.Value += 1
        Else
            AdvocateProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub

    Private Sub AdvocateResetButton_Click(sender As Object, e As EventArgs) Handles AdvocateResetButton.Click
        AdvocateQuestion1.Text = "Does the customer have an account?"
        AdvocateQuestion2.Text = "Were we able to find a vehicle?"
        AdvocateQuestion3.Text = "Customer looking to finance with Carvana?"

        AdvocateYes1.Checked = False
        AdvocateYes2.Checked = False
        AdvocateYes3.Checked = False
        AdvocateYes1.BackColor = Color.White
        AdvocateYes2.BackColor = Color.White
        AdvocateYes3.BackColor = Color.White

        AdvocateNo1.BackColor = Color.White
        AdvocateNo2.BackColor = Color.White
        AdvocateNo3.BackColor = Color.White
        AdvocateNo1.Checked = False
        AdvocateNo2.Checked = False
        AdvocateNo3.Checked = False

        Advocate1.Visible = False
        Advocate2.Visible = False
        Advocate3.Visible = False

        Advocate1.Checked = False
        Advocate2.Checked = False
        Advocate3.Checked = False
    End Sub

    Private Sub Yes1_CheckedChanged(sender As Object, e As EventArgs) Handles ReviewYes1.CheckedChanged
        If ReviewQuestion1.Text = "Was an order placed?" Then
            If ReviewYes1.Checked Then
                ReviewNo1.Checked = False
                ReviewYes1.BackColor = Color.DarkGray
                ReviewNo1.BackColor = Color.White

                If Review1.Checked = True Then
                    Review1.Checked = False
                End If
                Review1.Text = "Underwriting review in 24-48 hours/Delivery Expectations"
                Review1.Visible = True
            End If
        Else
            If ReviewQuestion1.Text = "Were we able to lock in a vehicle?" Then
                If ReviewYes1.Checked Then
                    ReviewNo1.Checked = False
                    ReviewYes1.BackColor = Color.DarkGray
                    ReviewNo1.BackColor = Color.White

                    If Review1.Checked = True Then
                        Review1.Checked = False
                    End If
                    Review1.Text = "Underwriting review in 24-48 hours"
                    Review1.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub No1_CheckedChanged(sender As Object, e As EventArgs) Handles ReviewNo1.CheckedChanged
        If ReviewQuestion1.Text = "Was an order placed?" Then
            If ReviewNo1.Checked Then
                ReviewYes1.Checked = False
                ReviewNo1.BackColor = Color.DarkGray
                ReviewYes1.BackColor = Color.White

                If Review1.Checked = True Then
                    Review1.Checked = False
                End If
                Review1.Visible = False

                ReviewQuestion1.Text = "Were we able to lock in a vehicle?"
                ReviewYes1.BackColor = Color.White
                ReviewNo1.BackColor = Color.White
                ReviewYes1.Checked = False
                ReviewNo1.Checked = False
            End If
        Else
            If ReviewQuestion1.Text = "Were we able to lock in a vehicle?" Then
                If ReviewNo1.Checked Then
                    ReviewYes1.Checked = False
                    ReviewNo1.BackColor = Color.DarkGray
                    ReviewYes1.BackColor = Color.White

                    If Review1.Checked = True Then
                        Review1.Checked = False
                    End If
                    Review1.Text = "Green Get Started button"
                    Review1.Visible = True
                End If
            End If
        End If
    End Sub
    Private Sub Review1_CheckedChanged(sender As Object, e As EventArgs) Handles Review1.CheckedChanged
        If Review1.Checked Then
            ReviewProgress.Value += 1
        Else
            ReviewProgress.Value -= 1
        End If
        UpdateProgressBars()
    End Sub

    Private Sub NotesButton_Click(sender As Object, e As EventArgs) Handles NotesButton.Click
        If Notepad.Visible = False Then
            Notepad.Location = New Point(Me.Location.X + Me.Width + 2, Me.Location.Y)
            Notepad.Show()
        Else
            Notepad.Hide()
        End If
    End Sub
End Class