Public Class ConfigOCRForm
    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles NextPage.Click

        JobWizard.ConfigBarcode.Enabled = True
        JobWizard.ConfigBarcode.PerformClick()
        JobWizard.WizardProgressBar.Value = 40%

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PreviousPage.Click

        JobWizard.ConfigFileInput.PerformClick()
        JobWizard.WizardProgressBar.Value = 20%

    End Sub

    Private Sub ActivateOCR_CheckedChanged_1(sender As Object, e As EventArgs) Handles ActivateOCR.CheckedChanged

        If ActivateOCR.CheckState = CheckState.Checked Then

            SkipIfOCRExist.Enabled = True

        Else

            SkipIfOCRExist.Enabled = False

        End If

    End Sub
End Class