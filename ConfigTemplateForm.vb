Public Class ConfigTemplateForm
    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles NextPage.Click

        If ActivateTemplate.CheckState = CheckState.Checked Then

            If TemplateLabel.Text = "" Then

                MsgBox("Template label must not be left empty")

            Else

                JobWizard.ConfigFileOutput.Enabled = True
                JobWizard.ConfigFileOutput.PerformClick()
                JobWizard.WizardProgressBar.Value = 80%

            End If

        Else

            JobWizard.ConfigFileOutput.Enabled = True
            JobWizard.ConfigFileOutput.PerformClick()
            JobWizard.WizardProgressBar.Value = 80%

        End If
    End Sub

    Private Sub PreviousPage_Click(sender As Object, e As EventArgs) Handles PreviousPage.Click

        JobWizard.ConfigBarcode.PerformClick()
        JobWizard.WizardProgressBar.Value = 60%

    End Sub

    Private Sub ActivateTemplate_CheckedChanged(sender As Object, e As EventArgs) Handles ActivateTemplate.CheckedChanged

        If ConfigBarcodeForm.ActivateBarcode.CheckState = CheckState.Checked Then

            If ActivateTemplate.CheckState = CheckState.Checked Then

                TemplateLabel.Enabled = True

            Else

                TemplateLabel.Enabled = False

            End If

        Else

            ActivateTemplate.CheckState = CheckState.Unchecked
            MsgBox("Template matching cannot be activate without barcode being activated!")

        End If


    End Sub
End Class