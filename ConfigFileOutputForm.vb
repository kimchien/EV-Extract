Public Class ConfigFileOutputForm
    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles NextPage.Click

        If SelectedDefaultOutputFolder.Text = "" Then

            MsgBox("Please select default output path")

            If BrowseFolder.ShowDialog() = DialogResult.OK Then

                SelectedDefaultOutputFolder.Text = BrowseFolder.SelectedPath

            End If

            If Not ConfigOCRForm.ActivateOCR.CheckState = CheckState.Checked And Not ConfigBarcodeForm.ActivateBarcode.CheckState = CheckState.Checked And Not ConfigTemplateForm.ActivateTemplate.CheckState = CheckState.Checked Then

                MsgBox("You did not activate any feature. Please review your configuration. ")

            End If

        ElseIf Not ConfigOCRForm.ActivateOCR.CheckState = CheckState.Checked And Not ConfigBarcodeForm.ActivateBarcode.CheckState = CheckState.Checked And Not ConfigTemplateForm.ActivateTemplate.CheckState = CheckState.Checked Then

            MsgBox("You did not activate any feature. Please review your configuration. ")

        Else

            SaveJob.Show()
            JobWizard.WizardProgressBar.Value = 99%

        End If
    End Sub

    Private Sub BrowseInputFolder_Click(sender As Object, e As EventArgs) Handles BrowseInputFolder.Click

        If BrowseFolder.ShowDialog() = DialogResult.OK Then

            SelectedDefaultOutputFolder.Text = BrowseFolder.SelectedPath

        End If

    End Sub

    Private Sub ConfigFileOutputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OutputFormat.SelectedIndex = 0

    End Sub

    Private Sub PreviousPage_Click(sender As Object, e As EventArgs) Handles PreviousPage.Click

        JobWizard.ConfigTemplateMatch.PerformClick()
        JobWizard.WizardProgressBar.Value = 80%

    End Sub

End Class