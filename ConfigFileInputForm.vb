Public Class ConfigFileInputForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BrowseInputFolder.Click

        If BrowseFolder.ShowDialog() = DialogResult.OK Then

            SelectedDefaultInputFolder.Text = BrowseFolder.SelectedPath

        End If

    End Sub

    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles NextPage.Click

        If Scanning.Checked = False And Browsing.Checked = False Then

            MsgBox("Please select input type")

        ElseIf SelectedDefaultInputFolder.Text = "" Then

            MsgBox("Please select default input path")

            If BrowseFolder.ShowDialog() = DialogResult.OK Then

                SelectedDefaultInputFolder.Text = BrowseFolder.SelectedPath

            End If

        Else

            JobWizard.ConfigOCR.Enabled = True
            JobWizard.ConfigOCR.PerformClick()
            JobWizard.WizardProgressBar.Value = 20%

        End If

    End Sub

End Class