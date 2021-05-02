Imports Syncfusion.Windows.Forms.Tools

Public Class ConfigBarcodeForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PreviousPage.Click

        JobWizard.ConfigOCR.PerformClick()
        JobWizard.WizardProgressBar.Value = 40%

    End Sub

    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles NextPage.Click

        If ActivateBarcode.CheckState = CheckState.Checked Then

            If BarcodeType.SelectedIndex = -1 Then

                MsgBox("Please select barcode type")

            ElseIf PageToRead.Text <= 0 Or PageToRead.Text = "" Then

                MsgBox("Page to read must be more than or equal to 1")

            Else

                JobWizard.ConfigTemplateMatch.Enabled = True
                JobWizard.ConfigTemplateMatch.PerformClick()
                JobWizard.WizardProgressBar.Value = 60%

            End If

        Else

            JobWizard.ConfigTemplateMatch.Enabled = True
            JobWizard.ConfigFileOutput.Enabled = True
            JobWizard.ConfigFileOutput.PerformClick()
            JobWizard.WizardProgressBar.Value = 60%

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ActivateBarcode.CheckedChanged

        If ActivateBarcode.CheckState = CheckState.Checked Then

            BarcodeAdvanceGroup.Enabled = True

        Else

            BarcodeAdvanceGroup.Enabled = False
            ConfigTemplateForm.ActivateTemplate.CheckState = CheckState.Unchecked

        End If


    End Sub

    Private Sub PageToRead_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PageToRead.KeyPress

        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub
End Class