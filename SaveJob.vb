Public Class SaveJob
    Private Sub SelectPath_Click(sender As Object, e As EventArgs) Handles SelectPath.Click

        SaveJobConfig.Filter = "EV Job File (*.evj)|*.evj"

        If SaveJobConfig.ShowDialog = DialogResult.OK Then

            JobNameTextbox.Text = SaveJobConfig.FileName

        End If


    End Sub


    Private Sub SaveJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        JobWizard.Enabled = False

    End Sub

    Private Sub SaveJob_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        JobWizard.Enabled = True

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        If WriteJob() = True Then

            'Filters only selection of EVJ config file
            Main.BrowseJob.Filter = "EV Job File (*.evj)|*.evj"
            Main.BrowseJob.FileName = SaveJobConfig.FileName
            Main.JobConfig()
            MsgBox("Job created successfully.")
            JobWizard.Close()
            Me.Close()

        End If

    End Sub

    Function WriteJob()

        Dim InputMethod As String
        If ConfigFileInputForm.Scanning.Checked = True Then
            InputMethod = "Scanning"
        ElseIf ConfigFileInputForm.Browsing.Checked = True Then
            InputMethod = "Browsing"
        End If

        Dim InputDirectory As String = ConfigFileInputForm.SelectedDefaultInputFolder.Text

        Dim RemoveAfterProcess As String = ConfigFileInputForm.RemoveAfterProcess.CheckState
        If ConfigFileInputForm.RemoveAfterProcess.Checked = True Then
            RemoveAfterProcess = True
        ElseIf ConfigFileInputForm.RemoveAfterProcess.Checked = False Then
            RemoveAfterProcess = False
        End If

        Dim ProcessSubFolders As String = ConfigFileInputForm.ProcessSubFolder.CheckState
        If ConfigFileInputForm.ProcessSubFolder.Checked = True Then
            ProcessSubFolders = True
        ElseIf ConfigFileInputForm.ProcessSubFolder.Checked = False Then
            ProcessSubFolders = False
        End If

        Dim OutputFormat As String = ConfigFileOutputForm.OutputFormat.SelectedItem
        If OutputFormat = "Adobe PDF Document (*.pdf)" Then
            OutputFormat = ".pdf"
        Else
            OutputFormat = ""
        End If

        Dim OutputDirectory As String = ConfigFileOutputForm.SelectedDefaultOutputFolder.Text

        Dim OCR As String = ConfigOCRForm.ActivateOCR.CheckState
        If ConfigOCRForm.ActivateOCR.Checked = True Then
            OCR = True
        ElseIf ConfigOCRForm.ActivateOCR.Checked = False Then
            OCR = False
        End If

        Dim SkipIfOCRExist As String = ConfigOCRForm.SkipIfOCRExist.CheckState
        If ConfigOCRForm.SkipIfOCRExist.Checked = True Then
            SkipIfOCRExist = True
        ElseIf ConfigOCRForm.SkipIfOCRExist.Checked = False Then
            SkipIfOCRExist = False
        End If

        Dim Barcode As String = ConfigBarcodeForm.ActivateBarcode.CheckState
        If ConfigBarcodeForm.ActivateBarcode.Checked = True Then
            Barcode = True
        ElseIf ConfigBarcodeForm.ActivateBarcode.Checked = False Then
            Barcode = False
        End If

        Dim BarcodeType As String = ConfigBarcodeForm.BarcodeType.SelectedItem
        Dim Pagetoread As String = ConfigBarcodeForm.PageToRead.Text

        Dim EnhanceBarcode As String = ConfigBarcodeForm.EnhanceBarcode.CheckState
        If ConfigBarcodeForm.EnhanceBarcode.Checked = True Then
            EnhanceBarcode = True
        ElseIf ConfigBarcodeForm.EnhanceBarcode.Checked = False Then
            EnhanceBarcode = False
        End If

        Dim Regex As String = ConfigTemplateForm.ActivateTemplate.CheckState
        If ConfigTemplateForm.ActivateTemplate.Checked = True Then
            Regex = True
        ElseIf ConfigTemplateForm.ActivateTemplate.Checked = False Then
            Regex = False
        End If

        Dim Template As String = ConfigTemplateForm.TemplateLabel.Text

        Dim jobcommand As String = "//Job" + vbCrLf + "JobName=" + System.IO.Path.GetFileNameWithoutExtension(JobNameTextbox.Text) + vbCrLf + vbCrLf _
                                    + "//Input" _
                                    + vbCrLf + "InputMethod=" + InputMethod _
                                    + vbCrLf + "InputDirectory=" + InputDirectory _
                                    + vbCrLf + "RemoveAfterProcess=" + RemoveAfterProcess _
                                    + vbCrLf + "ProcessSubFolders=" + ProcessSubFolders _
                                    + vbCrLf _
                                    + vbCrLf + "//Output" _
                                    + vbCrLf + "OutputFormat=" + OutputFormat _
                                    + vbCrLf + "OutputDirectory=" + OutputDirectory _
                                    + vbCrLf _
                                    + vbCrLf + "//OCR Detection" _
                                    + vbCrLf + "OCR=" + OCR _
                                    + vbCrLf + "SkipIfOCRExist=" + SkipIfOCRExist _
                                    + vbCrLf _
                                    + vbCrLf + "//Barcode Detection" _
                                    + vbCrLf + "Barcode=" + Barcode _
                                    + vbCrLf + "BarcodeTypes=" + BarcodeType _
                                    + vbCrLf + "EnhanceBarcode=" + EnhanceBarcode _
                                    + vbCrLf + "PageToProcess=" + Pagetoread _
                                    + vbCrLf _
                                    + vbCrLf + "//Template Matching " _
                                    + vbCrLf + "Regex=" + Regex _
                                    + vbCrLf + "Template=" + Template _
                                    + vbCrLf _
                                    + vbCrLf + "//FilenameConvention" _
                                    + vbCrLf + "Filename=Default"

        Try

            If IO.File.Exists(JobNameTextbox.Text) = True Then

                IO.File.Delete(JobNameTextbox.Text)
                My.Computer.FileSystem.WriteAllText(JobNameTextbox.Text, jobcommand, True)

            Else

                My.Computer.FileSystem.WriteAllText(JobNameTextbox.Text, jobcommand, True)

            End If


        Catch ex As Exception

            MsgBox("Error creating job file. Please contact vendor." + vbCrLf + ex.Message)
            Return False

        End Try

        Return True

    End Function

End Class