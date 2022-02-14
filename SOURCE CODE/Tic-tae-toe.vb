


Public Class TictaetoeForm

    Private Sub TictaetoeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxNumOfPlayers.SelectedIndex = 0
    End Sub

    Private Sub LinkLabelSeeRules_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSeeRules.LinkClicked

        Dim RulesForm As New FormRules

        RulesForm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim GameDisplayForm As New FormGameDisplay
        'If GameDisplayForm Is Nothing Then
        GameDisplayForm = New FormGameDisplay
        GameDisplayForm.myCaller = Me
        'End If
        GameDisplayForm.Show()
    End Sub
End Class




