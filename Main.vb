Imports System.Drawing.Imaging
Imports System.IO
Imports Saraff.Twain
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.OCRProcessor
Imports Syncfusion.Pdf.Parsing
Imports Syncfusion.BarcodeReader.OPX
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Microsoft.VisualBasic.Devices

Public Class Main

#Region "Public Variables"

    Public Class ArgumentType

        Public File As String
        Public SubFolder As String
        Public Filename As String
        Public OCRCount As Integer
        Public BarcodeCount As Integer

    End Class

    Public CurrentPage As String

    Public CurDocNdx As Integer
    Public lastnonemptyresultindex As Integer = 0

    Public DataList(100, 2) As String
    Public ResultList(100, 3) As String

    Public CurrentImageIndex As Integer = 0

    Public ScanComplete As Boolean = False


#End Region

#Region "Timer"

    Private Sub ImportFilesTimer_Tick(sender As Object, e As EventArgs) Handles ImportFilesTimer.Tick

        Dim totalInputFiles As Integer
        totalInputFiles = IO.Directory.GetFiles(InputDirectory).Count

        Dim totalCopiedFiles As Integer
        totalCopiedFiles = IO.Directory.GetFiles(Application.StartupPath + "\Temp\Input").Count

        If totalCopiedFiles = totalInputFiles Then
            ImportFilesProgressBar.Value = 100
            ImportFilesTimer.Stop()
        Else
            ImportFilesProgressBar.Value = (totalCopiedFiles / totalInputFiles) * 100
        End If

    End Sub

#End Region

#Region "Job Config"

    'Execution Configuration File Param

    '//Job
    Public JobName As String

    '//Input
    Public InputMethod As String
    Public InputDirectory As String
    Public RemoveAfterProcess As String
    Public ProcessSubFolders As String
    Public RemoveEmptyFolders As String

    '//Output
    Public OutputFormat As String
    Public OutputDirectory As String
    Public ExistingFiles As String

    '//Processing
    Public MaxCPU As String
    Public AutoIndex As String

    '//Barcode Detection
    Public Barcode As String
    Public BarcodeTypes As String
    Public PageToProcess As String
    Public EnhanceBarcode As String

    '//OCR Detection
    Public OCR As String
    Public SkipIfOCRExist As String
    Public ExportOCRText As String
    Public OCRTextPath As String

    '//Process Log
    Public Log As String
    Public LogFormat As String

    '//Template Matching 
    Public Regex As String
    Public Template As String

#End Region

#Region "Ribbon Tab Controls"

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles CreateJob.Click

        JobWizard.ShowDialog()

    End Sub

    Private Sub EditJob_Click(sender As Object, e As EventArgs) Handles EditJob.Click

        EditFileBrowser.Filter = "EV Job File (*.evj)|*.evj"
        If EditFileBrowser.ShowDialog = DialogResult.OK Then

            'Check if EVJ file exist
            If File.Exists(EditFileBrowser.FileName) And EditFileBrowser.FileName.Contains(".evj") Then

                'Get EVJ config keys
                Dim Lines() As String = IO.File.ReadAllLines(EditFileBrowser.FileName)
                Dim FunctionKeys As New Dictionary(Of String, String)
                For Each line As String In Lines
                    Dim LineCounts() As String = Strings.Split(line, "=", 2)
                    If LineCounts.Count < 2 Then
                        Continue For
                    Else
                        Dim Key As String = LineCounts(0)
                        Dim Value As String = LineCounts(1)
                        FunctionKeys.Add(Key, Value)
                    End If
                Next

                '//Job
                JobName = FunctionKeys("JobName")

                '//Input
                InputMethod = FunctionKeys("InputMethod")
                InputDirectory = FunctionKeys("InputDirectory")
                RemoveAfterProcess = FunctionKeys("RemoveAfterProcess")
                ProcessSubFolders = FunctionKeys("ProcessSubFolders")
                'RemoveEmptyFolders = FunctionKeys("RemoveEmptyFolders")

                '//Output
                OutputFormat = FunctionKeys("OutputFormat")
                OutputDirectory = FunctionKeys("OutputDirectory")
                'ExistingFiles = FunctionKeys("ExistingFiles")

                '//Processing
                'MaxCPU = FunctionKeys("MaxCPU")
                'AutoIndex = FunctionKeys("AutoIndex")

                '//Barcode Detection
                Barcode = FunctionKeys("Barcode")
                BarcodeTypes = FunctionKeys("BarcodeTypes")
                PageToProcess = FunctionKeys("PageToProcess")
                EnhanceBarcode = FunctionKeys("EnhanceBarcode")

                '//OCR Detection
                OCR = FunctionKeys("OCR")
                SkipIfOCRExist = FunctionKeys("SkipIfOCRExist")
                'ExportOCRText = FunctionKeys("ExportOCRText")
                'OCRTextPath = FunctionKeys("OCRTextPath")

                '//Process Log
                'Log = FunctionKeys("Log")
                'LogFormat = FunctionKeys("LogFormat")

                '//Template Matching 
                Regex = FunctionKeys("Regex")
                Template = FunctionKeys("Template")


                'Populate to job wizard
                If InputMethod = "Scanning" Then

                    ConfigFileInputForm.Scanning.Checked = True

                ElseIf inputmethod = "Browsing" Then

                    ConfigFileInputForm.Browsing.Checked = True

                End If

                ConfigFileInputForm.SelectedDefaultInputFolder.Text = InputDirectory

                If RemoveAfterProcess = "True" Then

                    ConfigFileInputForm.RemoveAfterProcess.Checked = True

                ElseIf RemoveAfterProcess = "False" Then

                    ConfigFileInputForm.RemoveAfterProcess.Checked = False

                End If

                If ProcessSubFolders = "True" Then

                    ConfigFileInputForm.ProcessSubFolder.Checked = True

                ElseIf ProcessSubFolders = "False" Then

                    ConfigFileInputForm.ProcessSubFolder.Checked = False

                End If

                ConfigFileOutputForm.OutputFormat.SelectedIndex = 0
                ConfigFileOutputForm.SelectedDefaultOutputFolder.Text = OutputDirectory

                If Barcode = "True" Then

                    ConfigBarcodeForm.ActivateBarcode.Checked = True

                ElseIf Barcode = "False" Then

                    ConfigBarcodeForm.ActivateBarcode.Checked = False

                End If

                ConfigBarcodeForm.BarcodeType.SelectedItem = BarcodeTypes
                ConfigBarcodeForm.PageToRead.Text = PageToProcess

                If EnhanceBarcode = "True" Then

                    ConfigBarcodeForm.EnhanceBarcode.Checked = True

                ElseIf EnhanceBarcode = "False" Then

                    ConfigBarcodeForm.EnhanceBarcode.Checked = False

                End If

                If OCR = "True" Then

                    ConfigOCRForm.ActivateOCR.Checked = True

                ElseIf OCR = "False" Then

                    ConfigOCRForm.ActivateOCR.Checked = False

                End If

                If SkipIfOCRExist = "True" Then

                    ConfigOCRForm.SkipIfOCRExist.Checked = True

                ElseIf SkipIfOCRExist = "False" Then

                    ConfigOCRForm.SkipIfOCRExist.Checked = False

                End If

                If Regex = "True" Then

                    ConfigTemplateForm.ActivateTemplate.Checked = True

                ElseIf Regex = "False" Then

                    ConfigTemplateForm.ActivateTemplate.Checked = False

                End If

                ConfigTemplateForm.TemplateLabel.Text = Template

                SaveJob.SaveJobConfig.FileName = EditFileBrowser.FileName
                SaveJob.JobNameTextbox.Text = EditFileBrowser.FileName
                JobWizard.ShowDialog()

            ElseIf EditFileBrowser.FileName = "" Then

                MessageBox.Show("Please select a valid EV Extract job file!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else

                    MessageBox.Show("Invalid job file selected. Please select a valid EV Extract job file!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExecuteJob.Enabled = False

            End If


        End If

    End Sub

#End Region

#Region "Main Form"
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Disable execution if no config file found
        ExecuteJob.Enabled = False

        'Set all progess bar to 0
        ImportFilesProgressBar.Value = 0

    End Sub

#End Region

#Region "Multithreading"

    Function CheckCore()

        Dim coreCount As Integer = 0

        For Each item In New System.Management.ManagementObjectSearcher("Select * from Win32_Processor").[Get]()
            coreCount += Integer.Parse(item("NumberOfCores").ToString())
        Next

        If CheckCoreAllocation(coreCount) = True Then
            Return True
        End If

    End Function

    Function CheckCoreAllocation(core As Integer)

        Dim i As Integer

        For i = 0 To core - 1

            Dim Thread(i) As System.Threading.Thread

        Next

        If MaxCPU > i Then

            MessageBox.Show("CPU allocated more than available machine Core (" & i & ")." & vbCrLf & "System will reallocate the assigned CPU to maximum core of " & i & ".", "CPU Allocation Error!", MessageBoxButtons.OK)
            MaxCPU = i

        Else

            MaxCPU = MaxCPU

        End If

        Return MaxCPU
        Return True

    End Function
#End Region

#Region "Process Update"
    Function UpdateProcessBar(Count As Integer)

        If ProcessSubFolders = True Then
            Dim totalfilecount As Integer = IO.Directory.GetFiles(Application.StartupPath + "\Temp\Input\", "*.*", SearchOption.AllDirectories).Count
            ProgressBar.BeginInvoke(Sub() ProgressBar.Value = (Count / totalfilecount) * 100)
        Else
            Dim totalfilecount As Integer = IO.Directory.GetFiles(Application.StartupPath + "\Temp\Input\", "*.*").Count
            ProgressBar.BeginInvoke(Sub() ProgressBar.Value = (Count / totalfilecount) * 100)
        End If

    End Function
#End Region

#Region "Import Files"

    Function RemoveTempInputFiles()

        If IO.Directory.Exists(Application.StartupPath + "\Temp\Input\") Then

            Try
                'Remove whole directory to remove all file
                IO.Directory.Delete(Application.StartupPath + "\Temp\Input\", True)

                'Recreate directory
                IO.Directory.CreateDirectory(Application.StartupPath + "\Temp\Input\")

                Return True

            Catch ex As Exception

                MessageBox.Show("Error creating directory. " & vbCrLf & "Error: " & ex.Message)
                PrimaryTab.SelectedIndex = 0

            End Try

        Else

            Try

                'Create temp directory for OCR
                IO.Directory.CreateDirectory(Application.StartupPath + "\Temp\Input\")

                Return True

            Catch ex As Exception

                MessageBox.Show("Error creating directory. " & vbCrLf & "Error: " & ex.Message)
                PrimaryTab.SelectedIndex = 0

            End Try

        End If

    End Function

    Function CopyDirectoryToTemp(path As String)

        My.Computer.FileSystem.CopyDirectory(path, Application.StartupPath + "\Temp\Input\")

        ImportFilesTimer.Interval = 100

        ImportFilesTimer.Start()

        Dim totalInputFiles As Integer
        totalInputFiles = IO.Directory.GetFiles(InputDirectory, "*.*", SearchOption.AllDirectories).Count

        Dim totalCopiedFiles As Integer
        totalCopiedFiles = IO.Directory.GetFiles(Application.StartupPath + "\Temp\Input", "*.*", SearchOption.AllDirectories).Count

        If totalInputFiles = totalCopiedFiles Then

            ImportFilesProgressBar.Value = 100
            ImportFilesTimer.Stop()
            Return True

        Else

            Do Until totalInputFiles = totalCopiedFiles
                ImportFilesProgressBar.Value = 100
                ImportFilesTimer.Stop()
                Return True
            Loop

        End If

    End Function


#End Region

#Region "Scanning"

    Function BeginScanning()

        Try

            TwainDriver.SelectSource()
            TwainDriver.Acquire()

            Return True

        Catch ex As Exception

            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try

    End Function


    Private Sub TwainDriver_AcquireCompleted(sender As Object, e As EventArgs) Handles TwainDriver.AcquireCompleted

        Try

            If Not ScanImageView.Image Is Nothing Then
                ScanImageView.Image.Dispose()
            End If
            ScanImageView.Image = TwainDriver.GetImage(0)

            Dim TotalPage As Integer = TwainDriver.ImageCount

            ConvertToPDF(TotalPage)

        Catch ex As Exception

            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub PreviousImage_Click(sender As Object, e As EventArgs) Handles PreviousImage.Click

        ScanImageView.Image = TwainDriver.GetImage(CurrentImageIndex - 1)
        CurrentImageIndex = CurrentImageIndex - 1

    End Sub


    Private Sub NextImage_Click(sender As Object, e As EventArgs) Handles NextImage.Click

        ScanImageView.Image = Me.TwainDriver.GetImage(CurrentImageIndex + 1)
        CurrentImageIndex = CurrentImageIndex + 1

    End Sub

    Function ConvertToPDF(TotalPage As Integer)

        Dim DateTimeNow As String = DateTime.Now.ToString("ddMMyyyyHHmmss")

        'Create a new PDF document
        Dim doc As New PdfDocument()
        'Add a page to the document
        Dim page As PdfPage = doc.Pages.Add()
        'Getting page size to draw the image which fits the page 
        Dim pageSize As SizeF = page.GetClientSize()
        'Create PDF graphics for the page
        Dim graphics As PdfGraphics = page.Graphics

        'Load the image from the disk
        Dim image As New PdfBitmap(TwainDriver.GetImage(0))

        'Draw the image
        graphics.DrawImage(image, New RectangleF(0, 0, pageSize.Width, pageSize.Height))

        'Save the document
        doc.Save(InputDirectory + "\" + DateTimeNow + ".pdf")

        'Close the document
        doc.Close(True)

        If TotalPage > 1 Then

            For index As Integer = 1 To TotalPage - 1

                'Load a PDF document

                Dim addemptydoc As New PdfLoadedDocument(InputDirectory + "\" + DateTimeNow + ".pdf")

                addemptydoc.Pages.Insert(index)
                'Insert a new page in the beginning of the document

                'Save and close the document
                addemptydoc.Save(InputDirectory + "\" + DateTimeNow + ".pdf")
                addemptydoc.Close(True)

                Dim adddoc As New PdfLoadedDocument(InputDirectory + "\" + DateTimeNow + ".pdf")

                Dim addpage As PdfLoadedPage = TryCast(adddoc.Pages(index), PdfLoadedPage)

                'Create PDF graphics for the page

                Dim addgraphics As PdfGraphics = addpage.Graphics

                'Load the image from the disk

                Dim addimage As New PdfBitmap(TwainDriver.GetImage(index))

                'Draw the image

                addgraphics.DrawImage(addimage, 0, 0)

                'Save the document

                adddoc.Save(InputDirectory + "\" + DateTimeNow + ".pdf")

                'Close the document

                adddoc.Close(True)

            Next

        End If

        Dim dialogresults As DialogResult = MessageBox.Show("Continue scanning?", "Continue...?", MessageBoxButtons.YesNo)

        If dialogresults = DialogResult.Yes Then

            TwainDriver.Acquire()

        Else

            ScanComplete = True

        End If

        'This will open the PDF file so, the result will be seen in default PDF viewer
        'Process.Start("C:\Users\KC Boon\Desktop\EV Extract\OutputImage.pdf")

    End Function


#End Region

#Region "Files To Process"
    Function DisplayFilesToProcess(Maindirectory() As String, GetDirectories() As String)

        Dim mainfolderpath As String = Application.StartupPath + "\Temp\Input"

        Dim MainFolderNode As New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv()
        MainFolderNode.Text = mainfolderpath

        FilesToProcessTree.Nodes.AddRange({MainFolderNode})

        For Each file As String In Maindirectory

            Dim filename As String = IO.Path.GetFileName(file)

            Dim MainFolderChildNode As New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv()
            MainFolderChildNode.Text = filename

            MainFolderNode.Nodes.AddRange({MainFolderChildNode})

        Next

        If ProcessSubFolders = True Then

            'Process All Files in Sub Folder
            For Each folder As String In GetDirectories

                Dim fileList() As String = IO.Directory.GetFiles(folder)

                Dim MainChildFolderNode As New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv()
                MainChildFolderNode.Text = folder

                MainFolderNode.Nodes.AddRange({MainChildFolderNode})

                'Process All Files in Sub Folders
                For Each file As String In fileList

                    'Get filename of the file
                    Dim filename As String = IO.Path.GetFileName(file)

                    Dim MainFolderChildNode As New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv()
                    MainFolderChildNode.Text = filename

                    MainChildFolderNode.Nodes.AddRange({MainFolderChildNode})

                Next

            Next

        End If

        FilesToProcessTree.ExpandAll()

        Return True

    End Function

    Function DisplayFilesDone(filename As String)

        Dim ProcessCompleteFileNode As New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv()
        ProcessCompleteFileNode.Text = filename

        FileProcessCompletedTree.BeginInvoke(Sub() FileProcessCompletedTree.Nodes.AddRange({ProcessCompleteFileNode}))

    End Function

#End Region

#Region "OCR"

    Function FullPageOCR(File As String, OCRCount As Integer)

        ProgressBar.BeginInvoke(Sub() ProcessLog.Text += "Recognizing text.." & vbCrLf)

        Dim args As ArgumentType = New ArgumentType()
        args.File = File
        args.OCRCount = OCRCount

        OCRFilesBackgroundWorker.RunWorkerAsync(args)

    End Function

    Private Sub OCRFilesBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles OCRFilesBackgroundWorker.DoWork

        Dim args As ArgumentType = e.Argument

        Dim File As String = args.File
        Dim OCRCount As Integer = args.OCRCount

        Dim processor As New OCRProcessor(Application.StartupPath + "\Assemblies\Tesseract Binaries\3.02")

        'Load a PDF document

        Dim lDoc As New PdfLoadedDocument(File)

        'Set OCR language to process

        processor.Settings.Language = Languages.English

        'Process OCR by providing the PDF document and Tesseract data

        processor.PerformOCR(lDoc, Application.StartupPath + "\Assemblies\Tessdata\3.02")

        UpdateProcessBar(OCRCount)

        lDoc.Save(File)

        lDoc.Close(True)

    End Sub

#End Region

#Region "Barcode"
    Function ReadBarcode(file As String, barcodeCount As Integer)

        Dim args As ArgumentType = New ArgumentType()
        args.File = file
        args.BarcodeCount = barcodeCount

        BarcodeFilesBackgroundWorker.RunWorkerAsync(args)

    End Function

    Private Function GetBarcodeIndex(BarcodeTypes As String)

        If BarcodeTypes = "Aztec" Then
            Return 0
        ElseIf BarcodeTypes = "CODABAR" Then
            Return 1
        ElseIf BarcodeTypes = "Code39" Then
            Return 2
        ElseIf BarcodeTypes = "Code93" Then
            Return 3
        ElseIf BarcodeTypes = "Code128" Then
            Return 4
        ElseIf BarcodeTypes = "DataMaxtrix" Then
            Return 5
        ElseIf BarcodeTypes = "EAN8" Then
            Return 6
        ElseIf BarcodeTypes = "EAN13" Then
            Return 7
        ElseIf BarcodeTypes = "IMB" Then
            Return 8
        ElseIf BarcodeTypes = "ITF" Then
            Return 9
        ElseIf BarcodeTypes = "MAXICODE" Then
            Return 10
        ElseIf BarcodeTypes = "PDF417" Then
            Return 11
        ElseIf BarcodeTypes = "QRCode" Then
            Return 12
        ElseIf BarcodeTypes = "RSS14" Then
            Return 13
        ElseIf BarcodeTypes = "RSSExpanded" Then
            Return 14
        ElseIf BarcodeTypes = "UPCA" Then
            Return 15
        ElseIf BarcodeTypes = "UPCE" Then
            Return 16
        ElseIf BarcodeTypes = "UPCEanExpansion" Then
            Return 17
        ElseIf BarcodeTypes = "MSI" Then
            Return 18
        ElseIf BarcodeTypes = "PLESSEY" Then
            Return 19

        End If
    End Function

    Private Sub BarcodeFilesBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BarcodeFilesBackgroundWorker.DoWork

        Dim args As ArgumentType = e.Argument

        Dim File As String = args.File
        Dim barcodeCount As String = args.BarcodeCount

        Try

            Dim reader As BarcodeReader = New BarcodeReader(File, FormatType.PDF)

            If EnhanceBarcode = True Then
                reader.Settings.TryHarder = True
            Else
                reader.Settings.TryHarder = False
            End If

            Dim result As BarcodeResultCollection = reader.ScanMultipleBarcode()

            If result.Count > 0 Then


                For Each results As BarcodeResult In result

                    If BarcodeTypes = "Auto" Then

                        DataList(CurDocNdx, 0) = File
                        DataList(CurDocNdx, 1) = results.BarcodeType
                        DataList(CurDocNdx, 2) = results.Text

                        CurDocNdx = CurDocNdx + 1

                    Else

                        Dim BarcodeTypeIndex As Integer = GetBarcodeIndex(BarcodeTypes)

                        If results.BarcodeType = BarcodeTypeIndex Then

                            DataList(CurDocNdx, 0) = File
                            DataList(CurDocNdx, 1) = results.BarcodeType
                            DataList(CurDocNdx, 2) = results.Text

                            CurDocNdx = CurDocNdx + 1

                        End If

                    End If

                    ProgressBar.BeginInvoke(Sub() ProcessLog.Text += "Barcode Found : " & results.Text & vbCrLf)

                Next

            Else

                DataList(CurDocNdx, 0) = File
                DataList(CurDocNdx, 1) = "No Barcode Detected"
                DataList(CurDocNdx, 2) = "No Barcode Detected"

                CurDocNdx = CurDocNdx + 1

                ProgressBar.BeginInvoke(Sub() ProcessLog.Text += "Barcode Found : None" & vbCrLf)

            End If

            UpdateProcessBar(barcodeCount)

        Catch ex As Barcode.PdfBarcodeException

            MsgBox("Barcode Reading Error" + ex.Message)

        End Try

    End Sub

#End Region

#Region "Template Matching"

    Function CheckForAlphabethCharacters(ByVal StringToCheck As String)

        For i = 0 To StringToCheck.Length - 1

            If Not Char.IsLetter(StringToCheck.Chars(i)) Then

                Return False

            End If

        Next

        Return "A"

    End Function
    Function CheckForDigitCharacters(ByVal StringToCheck As String)

        For i = 0 To StringToCheck.Length - 1

            If Not Char.IsDigit(StringToCheck.Chars(i)) Then

                Return False

            End If
        Next

        Return "#"

    End Function

    Function MatchPattern(Value As String) As String

        Dim Pattern As String = Template
        Dim charArray() As Char = Pattern.ToCharArray

        Dim ValuePattern As String = Value
        Dim ValuecharArray() As Char = ValuePattern.ToCharArray

        If Not charArray.Count = ValuecharArray.Count Then

            Return False

        Else

            For i = 0 To charArray.Count - 1

                If charArray(i) = "A" Then

                    If Not CheckForAlphabethCharacters(ValuecharArray(i)) = "A" Then

                        Return False

                    Else

                        Continue For

                    End If

                ElseIf charArray(i) = "#" Then

                    If Not CheckForDigitCharacters(ValuecharArray(i)) = "#" Then

                        Return False

                    Else

                        Continue For

                    End If

                Else

                    Return "Incorrect Syntax"

                End If

            Next

            Return True

        End If

    End Function

#End Region
    '
#Region "Job Select"
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles SelectJob.Click

        'Filters only selection of EVJ config file
        BrowseJob.Filter = "EV Job File (*.evj)|*.evj"
        If BrowseJob.ShowDialog = DialogResult.OK Then
            JobConfig()
        End If

    End Sub

    Function JobConfig()

        'Check if EVJ file exist
        If File.Exists(BrowseJob.FileName) And BrowseJob.FileName.Contains(".evj") Then

            'Get EVJ config keys
            Dim Lines() As String = IO.File.ReadAllLines(BrowseJob.FileName)
            Dim FunctionKeys As New Dictionary(Of String, String)
            For Each line As String In Lines
                Dim LineCounts() As String = Strings.Split(line, "=", 2)
                If LineCounts.Count < 2 Then
                    Continue For
                Else
                    Dim Key As String = LineCounts(0)
                    Dim Value As String = LineCounts(1)
                    FunctionKeys.Add(Key, Value)
                End If
            Next

            '//Job
            JobName = FunctionKeys("JobName")

            '//Input
            InputMethod = FunctionKeys("InputMethod")
            InputDirectory = FunctionKeys("InputDirectory")
            RemoveAfterProcess = FunctionKeys("RemoveAfterProcess")
            ProcessSubFolders = FunctionKeys("ProcessSubFolders")
            'RemoveEmptyFolders = FunctionKeys("RemoveEmptyFolders")

            '//Output
            OutputFormat = FunctionKeys("OutputFormat")
            OutputDirectory = FunctionKeys("OutputDirectory")
            'ExistingFiles = FunctionKeys("ExistingFiles")

            '//Processing
            'MaxCPU = FunctionKeys("MaxCPU")
            'AutoIndex = FunctionKeys("AutoIndex")

            '//Barcode Detection
            Barcode = FunctionKeys("Barcode")
            BarcodeTypes = FunctionKeys("BarcodeTypes")
            PageToProcess = FunctionKeys("PageToProcess")
            EnhanceBarcode = FunctionKeys("EnhanceBarcode")

            '//OCR Detection
            OCR = FunctionKeys("OCR")
            SkipIfOCRExist = FunctionKeys("SkipIfOCRExist")
            'ExportOCRText = FunctionKeys("ExportOCRText")
            'OCRTextPath = FunctionKeys("OCRTextPath")

            '//Process Log
            'Log = FunctionKeys("Log")
            'LogFormat = FunctionKeys("LogFormat")

            '//Template Matching 
            Regex = FunctionKeys("Regex")
            Template = FunctionKeys("Template")

            Me.Text = "EV Extract - " + JobName
            ExecuteJob.Enabled = True


        ElseIf BrowseJob.FileName = "" Then

            MessageBox.Show("Please select a valid EV Extract job file!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            MessageBox.Show("Invalid job file selected. Please select a valid EV Extract job file!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExecuteJob.Enabled = False

        End If

    End Function


#End Region

#Region "Job Execution"
    Private Sub ExecuteJob_Click(sender As Object, e As EventArgs) Handles ExecuteJob.Click

        CreateJob.Enabled = False
        EditJob.Enabled = False

        ImportFilesStatus.Visible = False
        ImportFilesProgressBar.Visible = False

        'Send runjobpanel to back
        PrimaryTab.SelectedIndex = 1

        'Begin execution 

        'Check file input method = Scanning
        If InputMethod = "Scanning" Then

            If BeginScanning() = True Then  'Begin scanning

                ScanTaskTimer.Interval = 1000
                ScanTaskTimer.Start()

            Else

                'Do nothing on this line, error message handled on function

            End If

            'Check file input method = Browsing
        ElseIf InputMethod = "Browsing" Then

            NextProcess()

        End If

    End Sub

    Function NextProcess()

        'Remove unremoved temp files in temp directory
        If RemoveTempInputFiles() = True Then

            'Run Check Core for multithread process and notify user
            If CheckCore() = True Then

                'MsgBox("Allocated maximum number of CPU: " & MaxCPU)

                ImportFilesStatus.Visible = True
                ImportFilesProgressBar.Visible = True

            End If

            'Make a copy of file to temp directory
            If CopyDirectoryToTemp(InputDirectory) = True Then

                Dim Maindirectory() As String = IO.Directory.GetFiles(Application.StartupPath + "\Temp\Input")
                Dim GetDirectories() As String = IO.Directory.GetDirectories(Application.StartupPath + "\Temp\Input", "*", System.IO.SearchOption.AllDirectories)

                PrimaryTab.SelectedIndex = 2
                ProcessStatus.Visible = True
                ProgressBar.Visible = True

                If DisplayFilesToProcess(Maindirectory, GetDirectories) = True Then

                    'Get Input Folder Name
                    Dim InputFolder() As String = InputDirectory.Split("\")
                    Dim InputFolderLength As Integer = InputFolder.Length
                    Dim SplitInputFolderName As String = InputFolder(InputFolderLength - 1)

                    Dim OCRCount As Integer = 0
                    Dim fileslocation() As String
                    Dim CurNdx As Integer = 0

                    'Process All Files in Main Folder
                    For Each file As String In Maindirectory

                        CurNdx = CurNdx + 1
                        ReDim Preserve fileslocation(CurNdx)

                        fileslocation(CurNdx) = file

                    Next

                    'Check if Process Sub Folders is enabled
                    If ProcessSubFolders = True Then

                        'Process All Files in Sub Folder
                        For Each folder As String In GetDirectories

                            Dim rgx As New Regex(SplitInputFolderName)
                            Dim getsubdirectorypath() As String = rgx.Split(folder)
                            Dim subdirectorypath As String = getsubdirectorypath(1)

                            Dim fileList() As String = IO.Directory.GetFiles(folder)

                            'Process All Files in Sub Folders
                            For Each file As String In fileList

                                CurNdx = CurNdx + 1
                                ReDim Preserve fileslocation(CurNdx)

                                fileslocation(CurNdx) = file

                            Next

                        Next

                    End If

                    If IsNothing(fileslocation) = True Then

                        MsgBox("No file to process!")
                        EndProcess()
                        Exit Function

                    Else

                        For i As Integer = 1 To fileslocation.Count - 1

                            'Get filename of the file
                            Dim filename As String = IO.Path.GetFileName(fileslocation(i))

                            OCRCount = OCRCount + 1

                            ProgressBar.BeginInvoke(Sub() ProcessLog.Text += vbCrLf & "[PROCESSING]" & vbCrLf)
                            ProgressBar.BeginInvoke(Sub() ProcessLog.Text += "File: " & filename & vbCrLf)

                            'Check if OCR enabled
                            If OCR = True Then

                                ProcessStatus.Text = "Recognizing Text.."
                                ProgressBar.Value = 0

                                While OCRFilesBackgroundWorker.IsBusy

                                    Application.DoEvents()

                                End While

                                'Check if Skip OCR process if text already exist in documennt
                                If SkipIfOCRExist = True Then

                                    'Load an existing PDF.
                                    Dim loadDocument As New PdfLoadedDocument(fileslocation(i))

                                    'Load the first page.
                                    Dim firstpage As PdfPageBase = loadDocument.Pages(0)

                                    'Extract the text from first page.
                                    Dim extractedText As String = firstpage.ExtractText()

                                    'close the document.
                                    loadDocument.Close(True)

                                    If extractedText Is Nothing Then

                                        'Process OCR
                                        FullPageOCR(fileslocation(i), OCRCount)

                                    Else

                                        ProgressBar.BeginInvoke(Sub() ProcessLog.Text += "Skip recognizing text. Text found." & vbCrLf)
                                        UpdateProcessBar(OCRCount)

                                    End If

                                Else

                                    'Process OCR
                                    FullPageOCR(fileslocation(i), OCRCount)

                                End If

                                'Check If Barcode enabled
                                If Barcode = True Then

                                    ProcessStatus.Text = "Reading Barcode.."
                                    ProgressBar.Value = 0

                                    ProgressBar.BeginInvoke(Sub() ProcessLog.Text += "Reading barcode.." & vbCrLf)

                                    ' Process Barcode
                                    ReadBarcode(fileslocation(i), i)

                                    While BarcodeFilesBackgroundWorker.IsBusy

                                        Application.DoEvents()

                                    End While


                                End If

                                DisplayFilesDone(filename)

                            Else

                                'Check If Barcode enabled
                                If Barcode = True Then

                                    ProcessStatus.Text = "Reading Barcode.."
                                    ProgressBar.Value = 0

                                    ProgressBar.BeginInvoke(Sub() ProcessLog.Text += "Reading barcode.." & vbCrLf)


                                    ' Process Barcode
                                    ReadBarcode(fileslocation(i), i)

                                    While BarcodeFilesBackgroundWorker.IsBusy

                                        Application.DoEvents()

                                    End While


                                End If

                                DisplayFilesDone(filename)

                            End If

                        Next

                    End If

                    If Regex = True And Barcode = True Then

                        ProcessStatus.Text = "Matching Template Expression.."
                        ProgressBar.Value = 0

                        Dim LastNonEmptyIndex As Integer

                        For i As Integer = 0 To DataList.GetLength(0) - 1

                            If DataList(i, 0) Is Nothing Then

                                LastNonEmptyIndex = i - 1

                                Exit For

                            End If

                        Next

                        For i As Integer = 0 To LastNonEmptyIndex

                            If MatchPattern(DataList(i, 2)) = "Incorrect Syntax" Then

                                For j As Integer = 0 To LastNonEmptyIndex

                                    ResultList(j, 0) = DataList(i, 0)
                                    ResultList(j, 1) = DataList(i, 1)
                                    ResultList(j, 2) = DataList(i, 2)
                                    ResultList(j, 3) = "Incorrect Syntax"

                                Next

                                MsgBox("Incorrect syntax in template. Template matching will not process.")
                                Exit For

                            Else

                                Thread.Sleep(50)

                                If MatchPattern(DataList(i, 2)) = True Then

                                    ResultList(i, 0) = DataList(i, 0)
                                    ResultList(i, 1) = DataList(i, 1)
                                    ResultList(i, 2) = DataList(i, 2)
                                    ResultList(i, 3) = "Matched"
                                    Continue For

                                ElseIf MatchPattern(DataList(i, 2)) = False Then

                                    ResultList(i, 0) = DataList(i, 0)
                                    ResultList(i, 1) = DataList(i, 1)
                                    ResultList(i, 2) = DataList(i, 2)
                                    ResultList(i, 3) = "Not Matched"
                                    Continue For

                                End If

                            End If


                        Next

                        PrimaryTab.SelectedIndex = 3

                        For i As Integer = 0 To ResultList.GetLength(0) - 1

                            If ResultList(i, 0) Is Nothing Then

                                lastnonemptyresultindex = i

                                Exit For

                            End If

                        Next

                        For i As Integer = 0 To lastnonemptyresultindex - 1

                            Dim filename As String = Path.GetFileName(ResultList(i, 0))
                            Dim filesizeinfo As New FileInfo(ResultList(i, 0))
                            Dim filesize As Long = filesizeinfo.Length
                            Dim n As Integer = IndexResult.Rows.Add()
                            Dim Count As Integer = 0

                            Dim loadedDocument As PdfLoadedDocument = New PdfLoadedDocument(ResultList(i, 0))
                            Dim pageCount As Integer = loadedDocument.Pages.Count
                            loadedDocument.Close(True)

                            For Each file As String In ResultList

                                If file = ResultList(i, 0) Then

                                    Count = Count + 1

                                End If

                            Next

                            If Count = 1 Then

                                If ResultList(i, 3) = "Matched" Then

                                    IndexResult.Rows.Item(n).Cells(0).Value = filename
                                    IndexResult.Rows.Item(n).Cells(3).Value = pageCount
                                    IndexResult.Rows.Item(n).Cells(4).Value = filesize
                                    IndexResult.Rows.Item(n).Cells(5).Value = ResultList(i, 0)
                                    IndexResult.Rows.Item(n).Cells(1).Value = ResultList(i, 2)
                                    IndexResult.Rows.Item(n).Cells(2).Value = ResultList(i, 1)

                                Else

                                    IndexResult.Rows.Item(n).Cells(0).Value = filename
                                    IndexResult.Rows.Item(n).Cells(3).Value = pageCount
                                    IndexResult.Rows.Item(n).Cells(4).Value = filesize
                                    IndexResult.Rows.Item(n).Cells(5).Value = ResultList(i, 0)
                                    IndexResult.Rows.Item(n).Cells(1).Value = ""
                                    IndexResult.Rows.Item(n).Cells(2).Value = ""

                                End If


                            ElseIf Count > 1 Then

                                If ResultList(i, 3) = "Matched" Then

                                    IndexResult.Rows.Item(n).Cells(0).Value = filename
                                    IndexResult.Rows.Item(n).Cells(3).Value = pageCount
                                    IndexResult.Rows.Item(n).Cells(4).Value = filesize
                                    IndexResult.Rows.Item(n).Cells(5).Value = ResultList(i, 0)
                                    IndexResult.Rows.Item(n).Cells(1).Value = "Multiple Data"
                                    IndexResult.Rows.Item(n).Cells(2).Value = "Multiple Data"


                                End If

                            End If

                        Next

                        'Remove Duplicated Value
                        For i = IndexResult.Rows.Count - 1 To 0 Step -1

                            For j = i - 1 To 0 Step -1

                                If IndexResult.Rows(i).Cells(4).Value = IndexResult.Rows(j).Cells(4).Value Or IndexResult.Rows(i).Cells(0).Value = "" Then

                                    IndexResult.Rows.RemoveAt(i)

                                    Exit For

                                End If

                            Next

                        Next

                        IndexResult.ClearSelection()

                    ElseIf Regex = True And Barcode = False Then

                        MsgBox("Template matching will not process because barcode is not enabled. ", "Incorrect Configuration", MessageBoxButtons.OK)

                    End If

                End If

            End If

        Else

            'Do something on removetempinputfile failed

        End If

    End Function

    Function EndProcess()

        CreateJob.Enabled = True
        EditJob.Enabled = True

        ScanImageView = Nothing
        ImportFilesStatus.Visible = False
        ImportFilesProgressBar.Visible = False
        ImportFilesProgressBar.Value = 0
        PreviousImage.Visible = False
        NextImage.Visible = False
        ProcessStatus.Visible = False
        ProgressBar.Visible = False
        ProgressBar.Value = 0
        FilesToProcessTree.Nodes.Clear()
        FileProcessCompletedTree.Nodes.Clear()
        ProcessLog.Clear()
        ProcessLog.Visible = False
        IndexResult.Rows.Clear()
        BarcodeText.Clear()
        BarcodeText.Enabled = False
        DocumentView.Visible = False
        PrimaryTab.SelectedIndex = 0

    End Function

    Private Sub ProcessLog_TextChanged(sender As Object, e As EventArgs) Handles ProcessLog.TextChanged

        ProcessLog.SelectionStart = ProcessLog.Text.Length

    End Sub

    Private Sub BarcodeText_TextChanged(sender As Object, e As EventArgs) Handles BarcodeText.TextChanged

        If IndexResult.Rows.Count > 0 Then

            Dim rowIndex = IndexResult.SelectedCells(0).OwningRow.Index

            If MatchPattern(BarcodeText.Text) = False Then

                BarcodeText.BackColor = Color.Red

            Else

                BarcodeText.BackColor = Color.Empty
                IndexResult.Rows.Item(rowIndex).Cells(1).Value = BarcodeText.Text

            End If

        End If


    End Sub

    Private Sub NextRow_Click(sender As Object, e As EventArgs) Handles NextRow.Click

        If IndexResult.SelectedRows.Count = 1 Then

            Dim rowIndex = IndexResult.SelectedCells(0).OwningRow.Index

            If BarcodeText.Text = "" Then

                MsgBox("Please complete the empty box")

            ElseIf BarcodeText.BackColor = Color.Red Then

                MsgBox("Input does not match template")
                BarcodeText.Clear()
                BarcodeText.Select()

            Else

                If rowIndex = IndexResult.RowCount - 1 Then

                    For Each emptyrow As DataGridViewRow In IndexResult.Rows

                        If emptyrow.Cells(1).Value = "" Or emptyrow.Cells(1).Value = "Multiple Data" Then

                            MsgBox("Field not complete.")
                            emptyrow.Cells(1).Selected = True
                            BarcodeText.Text = ""
                            Exit For

                        Else

                            If emptyrow.Index = IndexResult.RowCount - 1 Then

                                Dim ReleaseBatch As DialogResult = MessageBox.Show("Release batch?", "Save File?", MessageBoxButtons.YesNo)

                                If ReleaseBatch = DialogResult.Yes Then

                                    For i = 0 To IndexResult.RowCount - 1

                                        My.Computer.FileSystem.RenameFile(Application.StartupPath + "\Temp\Input" & "\" & IndexResult.Item(0, i).Value, IndexResult.Item(1, i).Value & ".pdf")
                                        System.IO.File.Move(Application.StartupPath + "\Temp\Input" & "\" & IndexResult.Item(1, i).Value & ".pdf", OutputDirectory & "\" & IndexResult.Item(1, i).Value & ".pdf")

                                    Next

                                    If RemoveAfterProcess = True Then

                                        For Each inputfile In Directory.GetFiles(InputDirectory, "*.*", SearchOption.TopDirectoryOnly)

                                            File.Delete(inputfile)

                                        Next

                                        MsgBox("Process completed")
                                        EndProcess()

                                    Else

                                        MsgBox("Process completed")
                                        EndProcess()

                                    End If

                                Else
                                    'Do nothing
                                End If

                            Else

                                Continue For

                            End If

                        End If

                    Next

                Else

                    BarcodeText.Clear()
                    IndexResult.Rows(rowIndex + 1).Selected = True
                    BarcodeText.Select()
                    BarcodeText.Text = IndexResult.Item(1, rowIndex + 1).Value

                End If

            End If

        Else

            MsgBox("No row selected.")

        End If



    End Sub

    Private Sub IndexResult_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles IndexResult.CellClick

        BarcodeText.Enabled = True
        BarcodeText.Select()

        Dim FilePath As String = IndexResult.Item(5, IndexResult.CurrentRow.Index).Value
        DocumentView.ToolbarSettings.SaveButton.IsVisible = False
        DocumentView.ToolbarSettings.PrintButton.IsVisible = False
        DocumentView.ToolbarSettings.OpenButton.IsVisible = False

        DocumentView.Load(FilePath)
        DocumentView.Visible = True

        If IndexResult.Item(1, IndexResult.CurrentRow.Index).Value = "Multiple Data" Then

            BarcodeText.Text = ""

            MultipleData.MultipleDataSelection.Rows.Clear()

            For i As Integer = 0 To lastnonemptyresultindex - 1

                If ResultList(i, 3) = "Matched" And ResultList(i, 0) = FilePath Then

                    Dim n As Integer = MultipleData.MultipleDataSelection.Rows.Add()
                    MultipleData.MultipleDataSelection.Rows.Item(n).Cells(0).Value = ResultList(i, 2)

                End If

            Next

            MultipleData.ShowDialog()

        ElseIf IndexResult.Item(1, IndexResult.CurrentRow.Index).Value = "No Barcode Detected" Then

            BarcodeText.Text = ""

        Else

            BarcodeText.Text = IndexResult.Item(1, IndexResult.CurrentRow.Index).Value

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ScanTaskTimer.Tick

        If ScanComplete = True Then
            ScanTaskTimer.Stop()
            NextProcess()

        End If

    End Sub




#End Region

End Class
