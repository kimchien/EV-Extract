Imports Syncfusion.Windows.Forms.Tools

Public Class JobWizard

    Sub SwitchPanel(ByVal Panel As Form)

        WizPanel.Controls.Clear()
        Panel.TopLevel = False
        WizPanel.Controls.Add(Panel)
        Panel.Show()

    End Sub

    Private Sub JobWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SwitchPanel(ConfigFileInputForm)

    End Sub

    Private Sub ConfigFileInput_Click(sender As Object, e As EventArgs) Handles ConfigFileInput.Click

        SwitchPanel(ConfigFileInputForm)

    End Sub

    Private Sub ConfigOCR_Click(sender As Object, e As EventArgs) Handles ConfigOCR.Click

        SwitchPanel(ConfigOCRForm)

    End Sub

    Private Sub ConfigBarcode_Click(sender As Object, e As EventArgs) Handles ConfigBarcode.Click

        SwitchPanel(ConfigBarcodeForm)

    End Sub

    Private Sub ConfigTemplateMatch_Click(sender As Object, e As EventArgs) Handles ConfigTemplateMatch.Click

        SwitchPanel(ConfigTemplateForm)

    End Sub

    Private Sub ConfigFileOutput_Click(sender As Object, e As EventArgs) Handles ConfigFileOutput.Click

        SwitchPanel(ConfigFileOutputForm)

    End Sub

End Class