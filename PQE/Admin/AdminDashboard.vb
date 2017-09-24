﻿Imports MaterialSkin

Imports MigraDoc.DocumentObjectModel
Imports MigraDoc.Rendering
Imports MigraDoc.DocumentObjectModel.Tables

Imports System.IO
Imports System.IO.Path
Imports System.Text

Public Class AdminDashboard

    ' For date
    Dim currentDate As String = Date.Now.ToString("yyyy-MM-dd")
    Dim newID As String
    Dim printDate As String

    ' For Examinee Tab
    Dim isEditable As Boolean = False


    ' For Exam Tab
    Dim examSetDescription As String
    Dim examLevelID As Integer
    Dim examTypeID As Integer
    Dim correctAnswer As String
    Dim rowClicked As Integer

    ' Configuration Tab variables
    Dim tempoAdminID As String = ""

    ' For examinee picture in function dgvExaminee_MouseDown
    Dim hasPicture As Boolean = False

    Public sql As New SQLControl

    ' VB.NET - Dynamically Resize and Reposition All Controls when Form is resized, including font sizes wonderful class I got from CodeProject by Member 10974085
    Dim rs As New Resizer


    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim _skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        _skinManager.AddFormToManage(Me)
        _skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        _skinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        ' Get current month name
        Dim _currentDate As Date = Date.Now
        printDate = _currentDate.ToString("MMMM dd, yyyy")

        ' Examinee tab
        LoadExamineeSet()
        LoadExamineeDgv()
        LoadExamineeLevel()
        LoadExamineePosition()
        ' Filter Dates
        dtpFromFilter.Enabled = False
        dtpToFilter.Enabled = False




        ' Exams tab
        LoadExamSet()

        ' Configuration Tab
        LoadDgvTempo()
        LoadTimers()

        ' Load lastBackup and lastRestore
        sql.ExecuteQuery("SELECT * from tbl_admin
                           WHERE adminID = 1
                             AND adminUsername = 'admin'
                             AND adminLevel = 0")

        lblLastBackup.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("lastBackup")
        lblLastRestore.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("lastRestore")

        picExaminee.Visible = False
        picExamError.Visible = False
        picExamineeError.Visible = False
        lblExamError.Visible = False
        lblExamineeError.Visible = False

        btnExamineeEdit.Visible = False



        rs.FindAllControls(Me)
    End Sub

    Private Sub btnBackLogin_Click(sender As Object, e As EventArgs) Handles btnBackLogin.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnUserManual_Click(sender As Object, e As EventArgs) Handles btnUserManual.Click
        Dim _doc As Document = New Document()
        Dim _sect As Section = _doc.AddSection()
        _sect.PageSetup.PageFormat = PageFormat.A4
        _sect.PageSetup.Orientation = Orientation.Portrait

        'Logo Code source: Image to left of text. Code by the wonderful Thomas Hoevel
        'Also view Invoice Example for Migradoc. Really useful
        Dim _logo As Shapes.Image = _sect.Headers.Primary.AddImage(My.Application.Info.DirectoryPath & "\..\..\Resources\rsz_dost.png")
        _logo.LockAspectRatio = True
        _logo.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
        _logo.WrapFormat.Style = Shapes.WrapStyle.None


        Dim _fontStyle As Style = _doc.Styles("Heading1")
        _fontStyle.Font.Size = 15
        _fontStyle.Font.Bold = True
        _fontStyle.Font.Underline = 1


        _fontStyle = _doc.Styles("Heading2")
        _fontStyle.Font.Size = 9
        _fontStyle.Font.Bold = False
        _fontStyle.Font.Underline = 0

        Dim _headerText As Paragraph = New Paragraph()
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("Republic of the Philippines" & vbNewLine, TextFormat.Bold)
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("Department of Science and Technology" & vbNewLine, "Heading1")
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("DOST Regional Operations Building, A. Bonifacio Avenue, Bicutan, Taguig, Metro Manila", "Heading2")

        'Add this at the end so that it doesn't interfere with our image
        _sect.Headers.Primary.Add(_headerText)

        Dim _footer As Paragraph = New Paragraph()
        _footer.Format.Alignment = ParagraphAlignment.Right
        _footer.AddText("Page ")
        _footer.AddPageField()
        _footer.AddText(" of ")
        _footer.AddNumPagesField()

        _sect.Footers.Primary.Add(_footer)

        Dim _paraTitle As Paragraph = New Paragraph()

        _paraTitle.AddFormattedText("User Manual for Pre-Qualification Examination", TextFormat.Bold)
        _paraTitle.Format.Alignment = ParagraphAlignment.Center


        _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)

        _sect.Add(_paraTitle)

        'Spaces needed
        _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)

        Dim _paraAdministrator As Paragraph = New Paragraph()
        _paraAdministrator.AddFormattedText("Administrator Side and Temporary Administrator Side", TextFormat.Bold)
        _paraAdministrator.Format.Alignment = ParagraphAlignment.Left
        _sect.Add(_paraAdministrator)

        _sect.AddParagraph("Step 1. As you open the login module the Admin must enter the required fields in order to manage all the questions and supervise the examinees who are going to take the exam." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 2. After logging in, the program will be redirected to the Admin dashboard which contains tabs for Examinee, Exams and Configuration." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 3. The Admin must first insert the Examinee credentials like first name and last name. The admin must also choose a level and position." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 4. After registering the Examinee, the Admin can allow the Examinee to take a picture." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 5. Then the Admin can go to the Exams tab to insert a variety of questions for the examinee. The Admin can categorize the question to a specific level and to a specific exam type." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 6. Next to the Exams tab is the Configuration tab wherein the Admin can configure the time for each level of exam, backup and restore database, and lastly " & vbNewLine & vbNewLine)

        _sect.AddParagraph(vbNewLine & vbNewLine)

        Dim _paraExaminee As Paragraph = New Paragraph()
        _paraExaminee.AddFormattedText("Examinee Side", TextFormat.Bold)
        _paraExaminee.Format.Alignment = ParagraphAlignment.Left
        _sect.Add(_paraExaminee)

        _sect.AddParagraph("Step 1. As you open the login module the Examinee must enter the required fields in order to take the exam prepared by the Admin. (The Examinee must ask for their ID from the Admin)" & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 2. In the Examinee dashboard, the Examinee can select what type of exam he can take first then continue onto the exam." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 3. In the Examination module, the Examinee will take the exam with the given time limit. If the Examinee can’t finish the exam within the given time, the exam will automatically stop." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 4. After the exam is over, the program will compute for the grade of the examinee and the result will be notified to the Administrator" & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 5. The Examinee then must consult the Administrator." & vbNewLine & vbNewLine)




        'Renders the doocument
        Dim _renderer As PdfDocumentRenderer = New PdfDocumentRenderer(True, PdfSharp.Pdf.PdfFontEmbedding.Always)
        _renderer.Document = _doc
        _renderer.RenderDocument()

        'Save document
        Dim filename As String = "UserManual.pdf"
        _renderer.PdfDocument.Save(filename)
        'Start view
        Process.Start(filename)

    End Sub

    Private Sub AdminDashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub


    ' -- EXAMINEE TAB --

    Private Sub LoadExamineeSet()
        cboExamineeSet.Items.Add("A")
        cboExamineeSet.Items.Add("B")
        cboExamineeSet.Items.Add("C")

        cboExamineeSet.SelectedIndex = 0
    End Sub

    Public Sub LoadExamineeDgv()

        sql.AddParam("@setDescription", cboExamineeSet.Text)

        sql.ExecuteQuery("SELECT tbl_examinee.examineeDateID       AS Examinee_ID, 
                                 tbl_examinee.firstName            AS First_Name, 
                                 tbl_examinee.lastName             AS Last_Name,
                                 tbl_level.levelDescription        AS Level,
                                 tbl_position.positionDescription  AS Position,
                                 tbl_examinee_set.result           AS Result,
                                 tbl_examinee.dateTaken            AS Date_Taken,
                                 tbl_examinee.examineePic          AS Examinee_Picture
                            FROM tbl_examinee
   
                      INNER JOIN tbl_position
                              ON tbl_examinee.positionID = tbl_position.positionID
                      INNER JOIN tbl_level
                              ON tbl_examinee.levelID = tbl_level.levelID
                      INNER JOIN tbl_examinee_set
                              ON tbl_examinee.examineeID = tbl_examinee_set.examineeID

                           WHERE tbl_examinee_set.setDescription = @setDescription

                        ORDER BY CASE WHEN tbl_examinee.examineeID = LAST_INSERT_ID() THEN 1 Else 2 END, tbl_examinee.examineeID DESC")

        dgvExaminee.DataSource = sql.sqlDataSet.Tables(0)

        lblExamineeCount.Text = sql.recordCount
    End Sub

    ' Overloading LoadExamineeDgv(). Mostly used after REGISTRATION
    Private Sub LoadExamineeDgv(setDescription As String)
        sql.AddParam("@setDescription", setDescription)

        sql.ExecuteQuery("SELECT tbl_examinee.examineeDateID       AS Examinee_ID, 
                                 tbl_examinee.firstName            AS First_Name, 
                                 tbl_examinee.lastName             AS Last_Name,
                                 tbl_level.levelDescription        AS Level,
                                 tbl_position.positionDescription  AS Position,
                                 tbl_examinee_set.result           AS Result,
                                 tbl_examinee.dateTaken            AS Date_Taken,
                                 tbl_examinee.examineePic          AS Examinee_Picture
                            FROM tbl_examinee
   
                      INNER JOIN tbl_position
                              ON tbl_examinee.positionID = tbl_position.positionID
                      INNER JOIN tbl_level
                              ON tbl_examinee.levelID = tbl_level.levelID
                      INNER JOIN tbl_examinee_set
                              ON tbl_examinee.examineeID = tbl_examinee_set.examineeID

                           WHERE tbl_examinee_set.setDescription = @setDescription

                        ORDER BY CASE WHEN tbl_examinee.examineeID = LAST_INSERT_ID() THEN 1 Else 2 END, tbl_examinee.examineeID DESC")

        dgvExaminee.DataSource = sql.sqlDataSet.Tables(0)

        lblExamineeCount.Text = sql.recordCount
    End Sub

    Private Sub LoadExamineeLevel()
        ' Comboboxes clear
        cboExamineeLevel.Items.Clear()

        sql.ExecuteQuery("SELECT * FROM tbl_level")

        ' FILLING OF CBs
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                cboExamineeLevel.Items.Add(r("levelDescription"))
                cboLevelFilter.Items.Add(r("levelDescription"))
            Next
        Else
            cboExamineeLevel.Items.Add("No levels yet.")
            cboLevelFilter.Items.Add("No levels yet.")
        End If
    End Sub

    Private Sub LoadExamineePosition()
        ' Comboboxes clear
        cboExamineePosition.Items.Clear()

        sql.ExecuteQuery("SELECT * FROM tbl_position ORDER BY positionDescription ASC")

        ' FILLING OF CBs
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                cboExamineePosition.Items.Add(r("positionDescription"))
                cboPositionFilter.Items.Add(r("positionDescription"))
            Next
        Else
            cboExamineePosition.Items.Add("No positions yet.")
            cboPositionFilter.Items.Add("No positions yet.")
        End If

    End Sub

    Private Sub dgvExaminee_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvExaminee.MouseDown
        Dim _ht = dgvExaminee.HitTest(e.Location.X, e.Location.Y)

        ' Check if there is data on row clicked or data is column header
        If _ht.Type = DataGridViewHitTestType.None Or _ht.Type = DataGridViewHitTestType.ColumnHeader Then
            Exit Sub
        End If

        If e.Button = MouseButtons.Left Then


            btnChangePicture.Visible = True

            ' Gets of row clicked
            rowClicked = dgvExaminee.HitTest(e.Location.X, e.Location.Y).RowIndex
            ' Clears highlight
            dgvExaminee.ClearSelection()
            ' Highlights rowClicked row
            dgvExaminee.Rows(rowClicked).Selected = True

            Dim _examineeID As String = dgvExaminee.SelectedRows(0).Cells("Examinee_ID").Value.ToString()
            Dim _firstName As String = dgvExaminee.SelectedRows(0).Cells("First_Name").Value.ToString()
            Dim _lastName As String = dgvExaminee.SelectedRows(0).Cells("Last_Name").Value.ToString()
            Dim _level As String = dgvExaminee.SelectedRows(0).Cells("Level").Value.ToString()
            Dim _jobTitle As String = dgvExaminee.SelectedRows(0).Cells("Position").Value.ToString()
            Dim _result As String = dgvExaminee.SelectedRows(0).Cells("Result").Value.ToString()

            ' If there is a result. Dont allow editing of comboboxes
            If _result = "Passed" Or _result = "Failed" Then
                cboExamineeLevel.Enabled = False
                cboExamineePosition.Enabled = False
            Else
                cboExamineeLevel.Enabled = True
                cboExamineePosition.Enabled = True
            End If


            lblExamineeID.Text = _examineeID
            txtFirstName.Text = _firstName
            txtLastName.Text = _lastName
            cboExamineePosition.Text = _jobTitle
            cboExamineeLevel.Text = _level

            btnExamineeEdit.Visible = True
            btnExamineeRegister.Visible = False

            ' Gets the image and pass to picturebox
            sql.AddParam("@examineeDateID", lblExamineeID.Text)
            sql.ExecuteQuery("SELECT examineePic FROM tbl_examinee WHERE examineeDateID = @examineeDateID")

            If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")) Then
                ' Set to false if there is no picture
                hasPicture = False
                picExaminee.Visible = True
                picExaminee.Image = PQE.My.Resources.NoExamineePic
            Else
                ' Set to true if there is picture
                picExaminee.Visible = True
                hasPicture = True

                Dim _examineePicByte() As Byte = sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")

                Using _examineePicStream As New System.IO.MemoryStream(_examineePicByte)
                    picExaminee.Image = Image.FromStream(_examineePicStream)
                    picExaminee.SizeMode = PictureBoxSizeMode.StretchImage
                    _examineePicStream.Close()
                End Using

                Dim _saveLocation As String = My.Computer.FileSystem.SpecialDirectories.MyPictures
                Dim _imageOutput As String = Combine(_saveLocation, "Image.jpg")

                SaveImageCopy(_imageOutput)

            End If

        ElseIf e.Button = MouseButtons.Right Then

            btnChangePicture.Visible = True

            ' Gets of row clicked
            rowClicked = dgvExaminee.HitTest(e.Location.X, e.Location.Y).RowIndex
            ' Clears highlight
            dgvExaminee.ClearSelection()
            ' Highlights rowClicked row
            dgvExaminee.Rows(rowClicked).Selected = True

            Dim _examineeDateID = dgvExaminee.Rows(rowClicked).Cells("Examinee_ID").Value.ToString
            Dim _firstName As String = dgvExaminee.SelectedRows(0).Cells("First_Name").Value.ToString()
            Dim _lastName As String = dgvExaminee.SelectedRows(0).Cells("Last_Name").Value.ToString()
            Dim _level As String = dgvExaminee.SelectedRows(0).Cells("Level").Value.ToString()
            Dim _jobTitle As String = dgvExaminee.SelectedRows(0).Cells("Position").Value.ToString()
            Dim _result As String = dgvExaminee.SelectedRows(0).Cells("Result").Value.ToString()

            ' If there is a result. Dont allow editing of comboboxes
            If _result = "Passed" Or _result = "Failed" Then
                cboExamineeLevel.Enabled = False
                cboExamineePosition.Enabled = False
            Else
                cboExamineeLevel.Enabled = True
                cboExamineePosition.Enabled = True
            End If
            ' Passes to the text field
            lblExamineeID.Text = _examineeDateID
            txtFirstName.Text = _firstName
            txtLastName.Text = _lastName
            cboExamineePosition.Text = _jobTitle
            cboExamineeLevel.Text = _level

            ' Gets the image and pass to picturebox
            sql.AddParam("@examineeDateID", lblExamineeID.Text)
            sql.ExecuteQuery("SELECT examineePic FROM tbl_examinee WHERE examineeDateID = @examineeDateID")

            If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")) Then
                ' Set to false if there is no picture
                hasPicture = False
                picExaminee.Visible = True
                picExaminee.Image = PQE.My.Resources.NoExamineePic
            Else
                ' Set to true if there is picture
                picExaminee.Visible = True
                hasPicture = True

                Dim _examineePicByte() As Byte = sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")

                Using _examineePicStream As New System.IO.MemoryStream(_examineePicByte)
                    picExaminee.Image = Image.FromStream(_examineePicStream)
                    picExaminee.SizeMode = PictureBoxSizeMode.StretchImage
                    _examineePicStream.Close()
                End Using

                Dim _saveLocation As String = My.Computer.FileSystem.SpecialDirectories.MyPictures
                Dim _imageOutput As String = Combine(_saveLocation, "Image.jpg")

                SaveImageCopy(_imageOutput)
            End If

        End If



    End Sub

    ' Code source: Saving an image from picturebox without savefiledialog by Frank L. Smith
    Private Sub SaveImageCopy(filePath As String)

        Try
            ' We scale the image by using the function ScaleImage
            Using bmp As New Bitmap(ScaleImage(picExaminee.Image, 100, 100))
                bmp.Save(filePath, Drawing.Imaging.ImageFormat.Jpeg)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Code source: Simple Proper Image Scaling in Correct Aspect Ratio by the awesome stepdragon. This function resizes by Pixels
    Private Function ScaleImage(ByVal OldImage As Image, ByVal TargetHeight As Integer, ByVal TargetWidth As Integer) As System.Drawing.Image

        'Dim NewHeight As Integer = TargetHeight
        'Dim NewWidth As Integer = NewHeight / OldImage.Height * OldImage.Width

        Dim NewWidth As Integer = TargetWidth
        Dim NewHeight As Integer = TargetHeight

        'If NewWidth > TargetWidth Then
        ' NewWidth = TargetWidth
        ' NewHeight = NewWidth / OldImage.Width * OldImage.Height
        'End If

        Return New Bitmap(OldImage, NewWidth, NewHeight)

    End Function

    Private Sub btnExamineeRegister_Click(sender As Object, e As EventArgs) Handles btnExamineeRegister.Click

        ' Error catching
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or cboExamineePosition.SelectedIndex = -1 Or cboExamineeLevel.SelectedIndex = -1 Then
            picExamineeError.Visible = True
            lblExamineeError.Text = "Incorrect Details"
            lblExamineeError.Visible = True
            Exit Sub
        End If

        ' The Examinee Date ID
        newID = currentDate

        ' Get ID of position
        Dim _positionID As Integer
        sql.AddParam("@positionSelected", cboExamineePosition.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_position WHERE positionDescription = @positionSelected")
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                ' Converts position ID to integer
                _positionID = Convert.ToInt64((r("positionID")))
            Next
        Else
            picExamineeError.Visible = True
            lblExamineeError.Text = "No Position selected yet!"
            lblExamineeError.Visible = True
        End If



        ' Get ID of levels
        Dim _levelID As Integer

        sql.AddParam("@levelSelected", cboExamineeLevel.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_level WHERE levelDescription = @levelSelected")
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                _levelID = Convert.ToInt64((r("levelID")))
            Next
        Else
            picExamineeError.Visible = True
            lblExamineeError.Text = "No Level selected yet!"
            lblExamineeError.Visible = True
        End If

        ' INSERTION OF EXAMINEE
        sql.AddParam("@firstName", txtFirstName.Text)
        sql.AddParam("@lastName", txtLastName.Text)
        sql.AddParam("@newID", newID)
        ' FK here
        sql.AddParam("@levelID", _levelID)
        sql.AddParam("@positionID", _positionID)
        sql.ExecuteQuery("INSERT INTO tbl_examinee (firstName, lastName, dateTaken, levelID, positionID) VALUES (@firstName, @lastName, @newID, @levelID, @positionID)")

        ' PUT newID to LAST INSERTED ROW
        sql.AddParam("@newID", newID)
        sql.ExecuteQuery("UPDATE tbl_examinee
                           SET examineeDateID = CONCAT(@newID, '-', LAST_INSERT_ID())
                         WHERE examineeID = LAST_INSERT_ID() ")

        ' INSERT to tbl_examinee_set. Reason: Each newly registered user has Test A
        sql.AddParam("@setDescription", "A")
        sql.ExecuteQuery("INSERT INTO tbl_examinee_set (examineeID, setDescription)
                               VALUES (LAST_INSERT_ID(), @setDescription)")

        txtFirstName.Text = ""
        txtLastName.Text = ""
        lblExamineeID.Text = ""
        cboExamineeLevel.SelectedIndex = -1
        cboExamineePosition.SelectedIndex = -1

        ' Scenario: cboExamineeSet could not be A so we revert it back to A after each registration
        cboExamineeSet.Text = "A"
        LoadExamineeDgv(cboExamineeSet.Text)

        lblExamineeError.Visible = False
        picExamineeError.Visible = False
    End Sub

    Private Sub btnExamineeEdit_Click(sender As Object, e As EventArgs) Handles btnExamineeEdit.Click

        ' Checks to see if there is no data inside text fields 
        If lblExamineeID.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Then
            lblExamineeError.Text = "Please select a record below first!"
            lblExamineeError.Visible = True
            picExamineeError.Visible = True
            Exit Sub
        End If

        ' Get ID of position
        Dim _positionID As Integer

        sql.AddParam("@positionSelected", cboExamineePosition.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_position WHERE positionDescription = @positionSelected")
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                _positionID = Convert.ToInt64((r("positionID")))
            Next
        Else
            lblExamineeError.Text = "No Position selected yet!"
            lblExamineeError.Visible = True
            picExamineeError.Visible = True
        End If



        ' Get ID of levels
        Dim _levelID As Integer

        sql.AddParam("@levelSelected", cboExamineeLevel.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_level WHERE levelDescription = @levelSelected")
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                _levelID = Convert.ToInt64((r("levelID")))
            Next
        Else
            lblExamineeError.Text = "No Level selected yet!"
            lblExamineeError.Visible = True
            picExamineeError.Visible = True
        End If



        ' Edit function
        sql.AddParam("@examineeDateID", lblExamineeID.Text)
        sql.AddParam("@newFirstName", txtFirstName.Text)
        sql.AddParam("@newLastName", txtLastName.Text)
        ' Adding foreign keys as parameter
        sql.AddParam("@levelID", _levelID)
        sql.AddParam("@positionID", _positionID)
        sql.ExecuteQuery("UPDATE tbl_examinee
                             SET      firstName = @newFirstName,
                                       lastName = @newLastname,
                                        levelID = @levelID,
                                     positionID = @positionID
                           WHERE examineeDateID = @examineeDateID")
        lblExamineeID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboExamineeLevel.Text = ""
        cboExamineePosition.Text = ""

        LoadExamineeDgv()

        ' Hindi ko alam bakit may ganito to
        'LoadJobs()

        lblExamineeError.Visible = False
        picExamineeError.Visible = False

        btnExamineeEdit.Visible = False
        btnExamineeRegister.Visible = True

    End Sub

    Private Sub btnExamineeClear_Click(sender As Object, e As EventArgs) Handles btnExamineeClear.Click

        lblExamineeID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboExamineeLevel.SelectedIndex = -1
        cboExamineePosition.SelectedIndex = -1
        cboExamineeLevel.Enabled = True
        cboExamineePosition.Enabled = True

        btnExamineeEdit.Visible = False
        btnExamineeRegister.Visible = True
        picExaminee.Visible = False

        btnChangePicture.Visible = False
        picExamineeError.Visible = False
        lblExamineeError.Visible = False


    End Sub

    Private Sub btnPrintExamineeDgv_Click(sender As Object, e As EventArgs) Handles btnPrintExamineeDgv.Click

        ' Create document
        Dim _doc As Document = New Document()
        ' Add sections to document
        Dim _sect As Section = _doc.AddSection()
        _sect.PageSetup.Orientation = Orientation.Landscape

        ' Header Logo
        Dim _logo As Shapes.Image = _sect.Headers.Primary.AddImage("...\...\Resources\rsz_dost.png")
        _logo.LockAspectRatio = True
        _logo.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
        _logo.WrapFormat.Style = Shapes.WrapStyle.Through

        Dim _fontStyle As Style = _doc.Styles("Heading1")
        _fontStyle.Font.Size = 15
        _fontStyle.Font.Bold = True
        _fontStyle.Font.Underline = 1


        Dim _headerText As Paragraph = New Paragraph()
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("Republic of the Philippines" & vbNewLine, TextFormat.Bold)
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("Department of Science and Technology" & vbNewLine, "Heading1")
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("DOST Regional Operations Building, A. Bonifacio Avenue, Bicutan, Taguig, Metro Manila")


        ' Add this at the end so that it doesn't interfere with our image
        _sect.Headers.Primary.Add(_headerText)

        ' Footer 
        Dim _footer As Paragraph = New Paragraph()
        _footer.Format.Alignment = ParagraphAlignment.Right
        _footer.AddText("Page ")
        _footer.AddPageField()
        _footer.AddText(" of ")
        _footer.AddNumPagesField()

        _sect.Footers.Primary.Add(_footer)

        _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)

        Dim _printDate As Paragraph = New Paragraph()
        _printDate.AddText(printDate)
        _printDate.Format.Alignment = ParagraphAlignment.Right
        _sect.Add(_printDate)

        _sect.AddParagraph(vbNewLine & vbNewLine)

        ' Declare table
        Dim _table As Table = New Table()
        _table.Borders.Width = 0.75

        ' First column
        Dim _column As Column = New Column()
        _column = _table.AddColumn(Unit.FromCentimeter(3))
        _column.Format.Alignment = ParagraphAlignment.Center
        ' NOTE BEFORE YOU CAN ADD CELLS, YOU MUST ADD THE COLUMN
        _column = _table.AddColumn(Unit.FromCentimeter(4))
        _column = _table.AddColumn(Unit.FromCentimeter(4))
        _column = _table.AddColumn(Unit.FromCentimeter(4))
        _column = _table.AddColumn(Unit.FromCentimeter(7))
        _column = _table.AddColumn(Unit.FromCentimeter(4))
        Dim _row As Row = New Row()
        ' For table header
        _row = _table.AddRow()
        ' Adds color to the first row
        _row.Shading.Color = Colors.PaleGoldenrod
        Dim _cell As Cell = New Cell()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Examinee ID")
        _cell = _row.Cells(1)
        _cell.AddParagraph("First Name")
        _cell = _row.Cells(2)
        _cell.AddParagraph("Last Name")
        _cell = _row.Cells(3)
        _cell.AddParagraph("Level")
        _cell = _row.Cells(4)
        _cell.AddParagraph("Position")
        _cell = _row.Cells(5)
        _cell.AddParagraph("Result")


        ' Execute query to get data on the appropriate set
        sql.AddParam("@setDescription", cboExamineeSet.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee
                      INNER JOIN tbl_level
                              ON tbl_examinee.levelID = tbl_level.levelID
                      INNER JOIN tbl_position
                              ON tbl_examinee.positionID = tbl_position.positionID
                      INNER JOIN tbl_examinee_set
                              ON tbl_examinee.examineeID = tbl_examinee_set.examineeID
                           WHERE tbl_examinee_set.setDescription = @setDescription")

        For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
            _row = _table.AddRow()
            _cell = _row.Cells(0)
            _cell.AddParagraph(r("examineeDateID"))

            _cell = _row.Cells(1)
            _cell.AddParagraph(r("firstName"))

            _cell = _row.Cells(2)
            _cell.AddParagraph(r("lastName"))

            _cell = _row.Cells(3)
            _cell.AddParagraph(r("levelDescription"))

            _cell = _row.Cells(4)
            _cell.AddParagraph(r("positionDescription"))

            If IsDBNull(r("result")) Then
                _cell = _row.Cells(5)
                _cell.AddParagraph("N/A")
            Else
                _cell = _row.Cells(5)
                _cell.AddParagraph(r("result"))
            End If
        Next

        ' You need to add it to the section
        _sect.Add(_table)

        ' Renders the doocument
        Dim _renderer As PdfDocumentRenderer = New PdfDocumentRenderer(True, PdfSharp.Pdf.PdfFontEmbedding.Always)
        _renderer.Document = _doc
        _renderer.RenderDocument()

        ' Save document
        Dim filename As String = "Examinee.pdf"
        _renderer.PdfDocument.Save(filename)
        ' Start view
        Process.Start(filename)
    End Sub

    Private Sub btnRefreshExamineeDgv_Click(sender As Object, e As EventArgs) Handles btnRefreshExamineeDgv.Click
        LoadExamineeDgv()
    End Sub

    ' Individual Examinee Print
    Private Sub tsmPrintExaminee_Click(sender As Object, e As EventArgs) Handles tsmPrintExaminee.Click
        If lblExamineeID.Text = "" Then
            MessageBox.Show("Please select a record first")
            Exit Sub
        End If

        ' Gets data to be passed to the PDF
        sql.AddParam("@examineeDateID", lblExamineeID.Text)
        sql.AddParam("@setDescription", cboExamineeSet.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee 

                          INNER JOIN tbl_level
                          ON tbl_examinee.levelID = tbl_level.levelID 

                          INNER JOIN tbl_position
                          ON tbl_examinee.positionID = tbl_position.positionID

                          INNER JOIN tbl_examinee_set
                          ON tbl_examinee.examineeID = tbl_examinee_set.examineeID

                          INNER JOIN tbl_examinee_score
                          ON tbl_examinee.examineeID = tbl_examinee_score.examineeID
                    
                          WHERE examineeDateID = @examineeDateID
                            AND tbl_examinee_set.setDescription = @setDescription
                            AND tbl_examinee_score.setDescription = @setDescription")




        MessageBox.Show("Record count " & sql.recordCount)
        ' Examinee Detials
        If sql.recordCount > 0 Then
            Dim _examineeDateID As String = sql.sqlDataSet.Tables(0).Rows(0).Item("examineeDateID").ToString
            Dim _examineeID As String = sql.sqlDataSet.Tables(0).Rows(0).Item("examineeID").ToString
            Dim _firstName As String = sql.sqlDataSet.Tables(0).Rows(0).Item("firstName").ToString
            Dim _lastName As String = sql.sqlDataSet.Tables(0).Rows(0).Item("lastName").ToString
            Dim _levelDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("levelDescription").ToString
            Dim _positionDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("positionDescription").ToString
            Dim _result As String = sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString
            Dim _dateTaken As String = sql.sqlDataSet.Tables(0).Rows(0).Item("dateTaken").ToString
            Dim _setDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("setDescription").ToString

            Dim _dateTakenHolder As Date = Date.Parse(_dateTaken)
            _dateTaken = _dateTakenHolder.ToString("MMMM, dd yyyy")


            Dim _doc As Document = New Document()
            Dim _sect As Section = _doc.AddSection()
            _sect.PageSetup.PageFormat = PageFormat.A4
            _sect.PageSetup.Orientation = Orientation.Portrait

            ' Logo Code source: Image to left of text. Code by the wonderful Thomas Hoevel
            ' Also view Invoice Example for Migradoc. Really useful
            Dim _logo As Shapes.Image = _sect.Headers.Primary.AddImage(My.Application.Info.DirectoryPath & "\..\..\Resources\rsz_dost.png")
            _logo.LockAspectRatio = True
            _logo.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
            _logo.WrapFormat.Style = Shapes.WrapStyle.None


            Dim _fontstyle As Style = _doc.Styles("Normal")

            _fontstyle = _doc.AddStyle("Heading1", "Normal")
            _fontstyle.Font.Size = 15
            _fontstyle.Font.Bold = True
            _fontstyle.Font.Underline = 1


            _fontstyle = _doc.AddStyle("Heading2", "Normal")
            _fontstyle.Font.Size = 9
            _fontstyle.Font.Bold = False
            _fontstyle.Font.Underline = 0

            Dim _headerText As Paragraph = New Paragraph()
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("Republic of the Philippines" & vbNewLine, TextFormat.Bold)
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("Department of Science and Technology" & vbNewLine, "Heading1")
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("DOST Regional Operations Building, A. Bonifacio Avenue, Bicutan, Taguig, Metro Manila", "Heading2")

            ' Add this at the end so that it doesn't interfere with our image
            _sect.Headers.Primary.Add(_headerText)

            'Footer 
            Dim _footer As Paragraph = New Paragraph()
            _footer.Format.Alignment = ParagraphAlignment.Right
            _footer.AddText("Page ")
            _footer.AddPageField()
            _footer.AddText(" of ")
            _footer.AddNumPagesField()

            _sect.Footers.Primary.Add(_footer)

            ' Spaces needed
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)



            If hasPicture = True Then
                Dim _examineePic As Shapes.Image = _sect.AddImage(My.Computer.FileSystem.SpecialDirectories.MyPictures & "\Image.jpg")
                _examineePic.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
                _examineePic.Top = Shapes.ShapePosition.Top
                _examineePic.Left = Shapes.ShapePosition.Right
                _examineePic.WrapFormat.Style = Shapes.WrapStyle.Through
            End If


            ' Adds date
            _sect.AddParagraph(printDate)
            ' Add new line
            _sect.AddParagraph(vbNewLine)

            _fontstyle = _doc.AddStyle("Paragraph", "Normal")
            _fontstyle.Font.Size = 12

            Dim _examineeDetails As Paragraph = New Paragraph()
            _examineeDetails.AddFormattedText("Name: " & _firstName & " " & _lastName & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Level: " & _levelDescription & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Position: " & _positionDescription & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Examinee ID: " & _examineeDateID & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Date of Exam: " & _dateTaken, "Paragraph")

            _sect.Add(_examineeDetails)

            ' Adds a new line
            _sect.AddParagraph(vbNewLine & vbNewLine)


            ' Table Holder and If statements for table Creation
            Dim _tableHolder As Table = New Table()
            If _setDescription = "A" Then
                If _levelDescription = "Supervisory" Then
                    _tableHolder = CreateTableSupervisory(_levelDescription, _examineeID, _setDescription) 'Calls the function to get table
                ElseIf _levelDescription = "Non-Supervisory" Then
                    _tableHolder = CreateTableNonSupervisory(_levelDescription, _examineeID, _setDescription)
                ElseIf _levelDescription = "Clerical" Then
                    _tableHolder = CreateTableClerical(_levelDescription, _examineeID, _setDescription)
                End If
            ElseIf _setDescription = "B" Then
                If _levelDescription = "Supervisory" Then
                    _tableHolder = CreateTableSupervisory(_levelDescription, _examineeID, _setDescription) 'Calls the function to get table
                ElseIf _levelDescription = "Non-Supervisory" Then
                    _tableHolder = CreateTableNonSupervisory(_levelDescription, _examineeID, _setDescription)
                ElseIf _levelDescription = "Clerical" Then
                    _tableHolder = CreateTableClerical(_levelDescription, _examineeID, _setDescription)
                End If
            ElseIf _setDescription = "C" Then
                If _levelDescription = "Supervisory" Then
                    _tableHolder = CreateTableSupervisory(_levelDescription, _examineeID, _setDescription) 'Calls the function to get table
                ElseIf _levelDescription = "Non-Supervisory" Then
                    _tableHolder = CreateTableNonSupervisory(_levelDescription, _examineeID, _setDescription)
                ElseIf _levelDescription = "Clerical" Then
                    _tableHolder = CreateTableClerical(_levelDescription, _examineeID, _setDescription)
                End If
            End If

            ' Paragraph for Results
            Dim _paraResult As Paragraph = New Paragraph()

            ' Paragraph and table for examinee results
            If _result = "Passed" Then

                _paraResult.AddFormattedText("Dear Applicant, " & vbNewLine & vbNewLine & "Congratulations!" & vbNewLine & vbNewLine & "You passed the pre-qualification examination as part of the recruitment process." _
                                   & vbNewLine & vbNewLine & "Below is the result of your examination" & vbNewLine & vbNewLine & vbNewLine, "Paragraph")

                _sect.Add(_paraResult)

                _sect.Add(_tableHolder) ' Add table

            ElseIf _result = "Failed" Then

                _paraResult.AddFormattedText("Dear Applicant, " & vbNewLine & vbNewLine & "We regret to inform you that you did not pass the pre-qualification examination as part of the recruitment process." _
                                   & vbNewLine & vbNewLine & "Below is the result of your examination" & vbNewLine & vbNewLine & vbNewLine, "Paragraph")

                _sect.Add(_paraResult)

                _sect.Add(_tableHolder) ' Add table
            End If

            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)

            Dim _paraSignature As Paragraph = New Paragraph()
            _paraSignature.AddFormattedText("______________________" & vbNewLine & "Printed Name and Signature", "Paragraph")
            _paraSignature.Format.Alignment = ParagraphAlignment.Right

            _sect.Add(_paraSignature)


            ' Renders the doocument
            Dim _renderer As PdfDocumentRenderer = New PdfDocumentRenderer(True, PdfSharp.Pdf.PdfFontEmbedding.Always)
            _renderer.Document = _doc
            _renderer.RenderDocument()

            ' Save document
            Dim filename As String = "ExamineeSummary.pdf"
            _renderer.PdfDocument.Save(filename)
            ' Start view
            Process.Start(filename)

        Else
            MessageBox.Show("Examinee has no results yet on the specified Set")
        End If



    End Sub

    Private Function CreateTableSupervisory(_levelDescription As String, _examineeID As String, _setDescription As String) As Table

        ' Get Number of questions. Using LevelDescription, Examinee ID, SetDescription
        Dim _paraTestType As Paragraph = New Paragraph()
        Dim _paraCorrectAnswers As Paragraph = New Paragraph()
        Dim _paraTotalItems As Paragraph = New Paragraph()

        _paraTestType.AddText("Type of Test")
        _paraTestType.Format.Alignment = ParagraphAlignment.Center

        _paraCorrectAnswers.AddText("Correct Answers")
        _paraCorrectAnswers.Format.Alignment = ParagraphAlignment.Center

        _paraTotalItems.AddText("Total Items")
        _paraTotalItems.Format.Alignment = ParagraphAlignment.Center

        ' setDescription is a Variable
        sql.AddParam("@setDescription", _setDescription)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, COUNT(tbl_question.questionID) AS NumberOfQuestions FROM tbl_question
                      INNER JOIN tbl_kind
                              ON tbl_question.kindID = tbl_kind.kindID
                      INNER JOIN tbl_level
                              ON tbl_kind.levelID = tbl_level.levelID
                           WHERE tbl_question.setDescription = @setDescription AND tbl_level.levelDescription = 'Supervisory'
                        GROUP BY tbl_kind.kindID")

        ' kindID = 1. Management and Leadership Concept
        ' kindID = 2. Numerical
        ' kindID = 3. Verbal
        Dim _maxSupervisoryManagement As String = sql.sqlDataSet.Tables(0).Rows(0).Item("NumberOfQuestions").ToString
        Dim _maxSupervisoryNumerical As String = sql.sqlDataSet.Tables(0).Rows(1).Item("NumberOfQuestions").ToString
        Dim _maxSupervisoryVerbal As String = sql.sqlDataSet.Tables(0).Rows(2).Item("NumberOfQuestions").ToString

        ' Get Scores. Uses kindID, setDescription, and examineeID
        sql.AddParam("@setDescription", _setDescription)
        sql.AddParam("@examineeID", _examineeID)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, tbl_examinee_score.examineeScore AS ExamineeScore FROM tbl_examinee_score
                      INNER JOIN tbl_kind
                              ON tbl_examinee_score.kindID = tbl_kind.kindID
                           WHERE tbl_examinee_score.setDescription = @setDescription AND tbl_examinee_score.examineeID = @examineeID
                        ORDER BY tbl_kind.kindID ASC")

        Dim _supervisoryManagement As String = sql.sqlDataSet.Tables(0).Rows(0).Item("ExamineeScore").ToString
        Dim _supervisoryNumerical As String = sql.sqlDataSet.Tables(0).Rows(1).Item("ExamineeScore").ToString
        Dim _supervisoryVerbal As String = sql.sqlDataSet.Tables(0).Rows(2).Item("ExamineeScore").ToString


        ' Creating our table
        Dim _table As Table = New Table()
        _table.Borders.Width = 0.75

        Dim _column As Column = New Column()
        Dim _row As Row = New Row()
        Dim _cell As Cell = New Cell()


        _column = _table.AddColumn(Unit.FromInch(3.25))
        _column = _table.AddColumn(Unit.FromInch(1.625))
        _column = _table.AddColumn(Unit.FromInch(1.625))

        ' Headers
        _row = _table.AddRow()
        _row.Shading.Color = Colors.PaleGoldenrod
        _cell = _row.Cells(0)
        _cell.Add(_paraTestType)
        _cell = _row.Cells(1)
        _cell.Add(_paraTotalItems)
        _cell = _row.Cells(2)
        _cell.Add(_paraCorrectAnswers)

        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Numerical")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxSupervisoryNumerical)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_supervisoryNumerical)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Verbal")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxSupervisoryVerbal)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_supervisoryVerbal)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Management and Leadership Concept")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxSupervisoryManagement)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_supervisoryManagement)

        ' Grand totals
        Dim _grandTotalItems As Integer = Integer.Parse(_maxSupervisoryManagement) + Integer.Parse(_maxSupervisoryNumerical) + Integer.Parse(_maxSupervisoryVerbal)
        Dim _grandTotalScore As Integer = Integer.Parse(_supervisoryManagement) + Integer.Parse(_supervisoryNumerical) + Integer.Parse(_supervisoryVerbal)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.Format.Font.Bold = True
        _cell.AddParagraph("Grand Total")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.Format.Font.Bold = True
        _cell.AddParagraph(_grandTotalItems)
        _cell = _row.Cells(2)
        _cell.Format.Font.Bold = True
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_grandTotalScore)

        Return _table

    End Function

    Private Function CreateTableNonSupervisory(_levelDescription As String, _examineeID As String, _setDescription As String) As Table

        ' Get Number of questions. Using LevelDescription, Examinee ID, SetDescription
        Dim _paraTestType As Paragraph = New Paragraph()
        Dim _paraCorrectAnswers As Paragraph = New Paragraph()
        Dim _paraTotalItems As Paragraph = New Paragraph()

        _paraTestType.AddText("Type of Test")
        _paraTestType.Format.Alignment = ParagraphAlignment.Center

        _paraCorrectAnswers.AddText("Correct Answers")
        _paraCorrectAnswers.Format.Alignment = ParagraphAlignment.Center

        _paraTotalItems.AddText("Total Items")
        _paraTotalItems.Format.Alignment = ParagraphAlignment.Center

        ' setDescription is a Variable
        sql.AddParam("@setDescription", _setDescription)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, COUNT(tbl_question.questionID) AS NumberOfQuestions FROM tbl_question
                      INNER JOIN tbl_kind
                              ON tbl_question.kindID = tbl_kind.kindID
                      INNER JOIN tbl_level
                              ON tbl_kind.levelID = tbl_level.levelID
                           WHERE tbl_question.setDescription = @setDescription AND tbl_level.levelDescription = 'Non-Supervisory'
                        GROUP BY tbl_kind.kindID")

        ' kindID = 4. Reading Comprehension 
        ' kindID = 5. Numerical
        ' kindID = 6. Verbal
        Dim _maxNonSupervisoryReading As String = sql.sqlDataSet.Tables(0).Rows(0).Item("NumberOfQuestions").ToString
        Dim _maxNonSupervisoryNumerical As String = sql.sqlDataSet.Tables(0).Rows(1).Item("NumberOfQuestions").ToString
        Dim _maxNonSupervisoryVerbal As String = sql.sqlDataSet.Tables(0).Rows(2).Item("NumberOfQuestions").ToString

        ' Get Scores. Uses kindID, setDescription, and examineeID
        sql.AddParam("@setDescription", _setDescription)
        sql.AddParam("@examineeID", _examineeID)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, tbl_examinee_score.examineeScore AS ExamineeScore FROM tbl_examinee_score
                      INNER JOIN tbl_kind
                              ON tbl_examinee_score.kindID = tbl_kind.kindID
                           WHERE tbl_examinee_score.setDescription = @setDescription AND tbl_examinee_score.examineeID = @examineeID
                        ORDER BY tbl_kind.kindID ASC")

        Dim _nonSupervisoryReading As String = sql.sqlDataSet.Tables(0).Rows(0).Item("ExamineeScore").ToString
        Dim _nonSupervisoryNumerical As String = sql.sqlDataSet.Tables(0).Rows(1).Item("ExamineeScore").ToString
        Dim _nonSupervisoryVerbal As String = sql.sqlDataSet.Tables(0).Rows(2).Item("ExamineeScore").ToString


        ' Creating our table
        Dim _table As Table = New Table()
        _table.Borders.Width = 0.75

        Dim _column As Column = New Column()
        Dim _row As Row = New Row()
        Dim _cell As Cell = New Cell()


        _column = _table.AddColumn(Unit.FromInch(3.25))
        _column = _table.AddColumn(Unit.FromInch(1.625))
        _column = _table.AddColumn(Unit.FromInch(1.625))

        ' Headers
        _row = _table.AddRow()
        _row.Shading.Color = Colors.PaleGoldenrod
        _cell = _row.Cells(0)
        _cell.Add(_paraTestType)
        _cell = _row.Cells(1)
        _cell.Add(_paraTotalItems)
        _cell = _row.Cells(2)
        _cell.Add(_paraCorrectAnswers)

        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Numerical")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxNonSupervisoryNumerical)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_nonSupervisoryNumerical)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Verbal")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxNonSupervisoryVerbal)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_nonSupervisoryNumerical)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Reading Comprehension")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxNonSupervisoryReading)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_nonSupervisoryReading)


        ' Grand totals
        Dim _grandTotalItems As Integer = Integer.Parse(_maxNonSupervisoryNumerical) + Integer.Parse(_maxNonSupervisoryReading) + Integer.Parse(_maxNonSupervisoryVerbal)
        Dim _grandTotalScore As Integer = Integer.Parse(_nonSupervisoryNumerical) + Integer.Parse(_nonSupervisoryReading) + Integer.Parse(_nonSupervisoryVerbal)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.Format.Font.Bold = True
        _cell.AddParagraph("Grand Total")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.Format.Font.Bold = True
        _cell.AddParagraph(_grandTotalItems)
        _cell = _row.Cells(2)
        _cell.Format.Font.Bold = True
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_grandTotalScore)

        Return _table

    End Function

    Private Function CreateTableClerical(_levelDescription As String, _examineeID As String, _setDescription As String) As Table

        ' Get Number of questions. Using LevelDescription, Examinee ID, SetDescription
        Dim _paraTestType As Paragraph = New Paragraph()
        Dim _paraCorrectAnswers As Paragraph = New Paragraph()
        Dim _paraTotalItems As Paragraph = New Paragraph()

        _paraTestType.AddText("Type of Test")
        _paraTestType.Format.Alignment = ParagraphAlignment.Center

        _paraCorrectAnswers.AddText("Correct Answers")
        _paraCorrectAnswers.Format.Alignment = ParagraphAlignment.Center

        _paraTotalItems.AddText("Total Items")
        _paraTotalItems.Format.Alignment = ParagraphAlignment.Center

        ' setDescription is a Variable
        sql.AddParam("@setDescription", _setDescription)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, COUNT(tbl_question.questionID) AS NumberOfQuestions FROM tbl_question
                      INNER JOIN tbl_kind
                              ON tbl_question.kindID = tbl_kind.kindID
                      INNER JOIN tbl_level
                              ON tbl_kind.levelID = tbl_level.levelID
                           WHERE tbl_question.setDescription = @setDescription AND tbl_level.levelDescription = 'Clerical'
                        GROUP BY tbl_kind.kindID")

        ' kindID = 7. Numerical  
        ' kindID = 8. Verbal
        ' kindID = 9. General Information and Current Events
        ' kindID = 10. Clerical Reasoning
        ' kindID = 11. Abstract Reasoning 
        Dim _maxClericalNumerical As String = sql.sqlDataSet.Tables(0).Rows(0).Item("NumberOfQuestions").ToString
        Dim _maxClericalVerbal As String = sql.sqlDataSet.Tables(0).Rows(1).Item("NumberOfQuestions").ToString
        Dim _maxClericalGeneralInfo As String = sql.sqlDataSet.Tables(0).Rows(2).Item("NumberOfQuestions").ToString
        Dim _maxClericalClericalReasoning As String = sql.sqlDataSet.Tables(0).Rows(3).Item("NumberOfQuestions").ToString
        Dim _maxClericalAbstractReasoning As String = sql.sqlDataSet.Tables(0).Rows(4).Item("NumberOfQuestions").ToString

        ' Get Scores. Uses kindID, setDescription, and examineeID
        sql.AddParam("@setDescription", _setDescription)
        sql.AddParam("@examineeID", _examineeID)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, tbl_examinee_score.examineeScore AS ExamineeScore FROM tbl_examinee_score
                      INNER JOIN tbl_kind
                              ON tbl_examinee_score.kindID = tbl_kind.kindID
                           WHERE tbl_examinee_score.setDescription = @setDescription AND tbl_examinee_score.examineeID = @examineeID
                        ORDER BY tbl_kind.kindID ASC")

        Dim _clericalNumerical As String = sql.sqlDataSet.Tables(0).Rows(0).Item("ExamineeScore").ToString
        Dim _clericalVerbal As String = sql.sqlDataSet.Tables(0).Rows(1).Item("ExamineeScore").ToString
        Dim _clericalGeneralInfo As String = sql.sqlDataSet.Tables(0).Rows(2).Item("ExamineeScore").ToString
        Dim _clericalClericalReasoning As String = sql.sqlDataSet.Tables(0).Rows(3).Item("ExamineeScore").ToString
        Dim _clericalAbstractReasoning As String = sql.sqlDataSet.Tables(0).Rows(4).Item("ExamineeScore").ToString

        ' Creating our table
        Dim _table As Table = New Table()
        _table.Borders.Width = 0.75

        Dim _column As Column = New Column()
        Dim _row As Row = New Row()
        Dim _cell As Cell = New Cell()


        _column = _table.AddColumn(Unit.FromInch(3.25))
        _column = _table.AddColumn(Unit.FromInch(1.625))
        _column = _table.AddColumn(Unit.FromInch(1.625))

        ' Headers
        _row = _table.AddRow()
        _row.Shading.Color = Colors.PaleGoldenrod
        _cell = _row.Cells(0)
        _cell.Add(_paraTestType)
        _cell = _row.Cells(1)
        _cell.Add(_paraTotalItems)
        _cell = _row.Cells(2)
        _cell.Add(_paraCorrectAnswers)

        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Numerical")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxClericalNumerical)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_clericalNumerical)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Verbal")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxClericalVerbal)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_clericalVerbal)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("General Information and Current Events")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxClericalGeneralInfo)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_clericalGeneralInfo)

        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Clerical Reasoning")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxClericalClericalReasoning)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_clericalClericalReasoning)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Abstract Reasoning")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxClericalAbstractReasoning)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_clericalAbstractReasoning)


        ' Grand totals
        Dim _grandTotalItems As Integer = Integer.Parse(_maxClericalNumerical) + Integer.Parse(_maxClericalVerbal) + Integer.Parse(_maxClericalGeneralInfo) + Integer.Parse(_maxClericalAbstractReasoning) + Integer.Parse(_maxClericalClericalReasoning)
        Dim _grandTotalScore As Integer = Integer.Parse(_clericalNumerical) + Integer.Parse(_clericalVerbal) + Integer.Parse(_clericalGeneralInfo) + Integer.Parse(_clericalAbstractReasoning) + Integer.Parse(_clericalClericalReasoning)

        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.Format.Font.Bold = True
        _cell.AddParagraph("Grand Total")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.Format.Font.Bold = True
        _cell.AddParagraph(_grandTotalItems)
        _cell = _row.Cells(2)
        _cell.Format.Font.Bold = True
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_grandTotalScore)

        Return _table

    End Function

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Try
            Dim xlApp As New Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Dim _excelFile As String

            sfdExcel.Filter = "Excel File|*.xlsx"
            sfdExcel.FileName = "PQE Table Examinee Excel.xlsx"

            If sfdExcel.ShowDialog = DialogResult.OK Then

                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                xlWorkSheet.Range("A1").ColumnWidth = 15
                xlWorkSheet.Range("B1").ColumnWidth = 20
                xlWorkSheet.Range("C1").ColumnWidth = 20
                xlWorkSheet.Range("D1").ColumnWidth = 16
                xlWorkSheet.Range("E1").ColumnWidth = 30
                xlWorkSheet.Range("F1").ColumnWidth = 10
                xlWorkSheet.Range("G1").ColumnWidth = 12

                _excelFile = sfdExcel.FileName

                LoadExamineeDgv()

                For i As Integer = 0 To dgvExaminee.RowCount - 1
                    For j As Integer = 0 To dgvExaminee.ColumnCount - 2
                        For k As Integer = 1 To dgvExaminee.Columns.Count - 1
                            xlWorkSheet.Cells(1, k) = dgvExaminee.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = dgvExaminee(j, i).Value.ToString()
                        Next
                    Next
                Next

                xlWorkSheet.SaveAs(_excelFile)
                xlWorkBook.Close()
                xlApp.Quit()

                ReleaseObject(xlApp)
                ReleaseObject(xlWorkBook)
                ReleaseObject(xlWorkSheet)

                MessageBox.Show("Exporting to Excel file format successful.")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnChangePicture_Click(sender As Object, e As EventArgs) Handles btnChangePicture.Click
        ExamineePicture.lblExamineeDateID.Text = lblExamineeID.Text
        ExamineePicture.Show()
    End Sub


    ' Used for Filters
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Used for filtering
        Dim _stringBuilder As New StringBuilder

        ' Main flow is to add clauses(filters) in WHERE clause if parameters are checked
        ' Add extra space after every clause for safety

        ' Main SELECT Query
        sql.AddParam("@setDescription", cboExamineeSet.Text)

        _stringBuilder.Append("SELECT tbl_examinee.examineeDateID  AS Examinee_ID, 
                                 tbl_examinee.firstName            AS First_Name, 
                                 tbl_examinee.lastName             AS Last_Name,
                                 tbl_level.levelDescription        AS Level,
                                 tbl_position.positionDescription  AS Position,
                                 tbl_examinee_set.result           AS Result,
                                 tbl_examinee.dateTaken            AS Date_Taken,
                                 tbl_examinee.examineePic          AS Examinee_Picture
                            FROM tbl_examinee
   
                      INNER JOIN tbl_position
                              ON tbl_examinee.positionID = tbl_position.positionID
                      INNER JOIN tbl_level
                              ON tbl_examinee.levelID = tbl_level.levelID
                      INNER JOIN tbl_examinee_set
                              ON tbl_examinee.examineeID = tbl_examinee_set.examineeID

                           WHERE tbl_examinee_set.setDescription = @setDescription ")


        ' Name Filter
        If txtFirstNameFilter.Text <> Nothing Then
            sql.AddParam("@firstNameFilter", txtFirstNameFilter.Text)
            _stringBuilder.Append("AND tbl_examinee.firstName = @firstNameFilter ")
        End If

        If txtLastNameFilter.Text <> Nothing Then
            sql.AddParam("@lastNameFilter", txtLastNameFilter.Text)
            _stringBuilder.Append("AND tbl_examinee.lastName = @lastNameFilter ")
        End If



        ' Passed/Failed Filters
        If rbPassedFilter.Checked Then
            _stringBuilder.Append("AND tbl_examinee_set.result = 'Passed' ")
        End If

        If rbFailedFilter.Checked Then
            _stringBuilder.Append("AND tbl_examinee_set.result = 'Failed' ")
        End If

        If rbNoResultFilter.Checked Then
            _stringBuilder.Append("AND tbl_examinee_set.result IS NULL ")
            ' do nothing because passed or failed are already included in current query
        End If



        ' Level Title Filters
        If cboLevelFilter.SelectedIndex <> -1 Then
            sql.AddParam("@levelFilter", cboLevelFilter.Text)
            _stringBuilder.Append("AND tbl_level.levelDescription = @levelFilter ")
        End If

        ' Position Title Filters
        If cboPositionFilter.SelectedIndex <> -1 Then
            sql.AddParam("@positionFilter", cboPositionFilter.Text)
            _stringBuilder.Append("AND tbl_position.positionDescription = @positionFilter ")
        End If


        ' Date Filter
        If chkDateFilter.Checked Then

            sql.AddParam("@fromDateFilter", dtpFromFilter.Value.ToString("yyyy-MM-dd"))
            sql.AddParam("@toDateFilter", dtpToFilter.Value.ToString("yyyy-MM-dd"))

            _stringBuilder.Append("AND dateTaken BETWEEN @fromDateFilter AND @toDateFilter ")

        End If


        _stringBuilder.Append("ORDER BY CASE WHEN tbl_examinee.examineeID = LAST_INSERT_ID() THEN 1 Else 2 END, tbl_examinee.examineeID DESC")

        sql.ExecuteQuery(_stringBuilder.ToString())
        dgvExaminee.DataSource = sql.sqlDataSet.Tables(0)
        MessageBox.Show(_stringBuilder.ToString())
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click

        cboLevelFilter.SelectedIndex = -1
        cboPositionFilter.SelectedIndex = -1

        rbPassedFilter.Checked = False
        rbFailedFilter.Checked = False
        rbNoResultFilter.Checked = False

        chkDateFilter.Checked = False
        dtpFromFilter.Enabled = False
        dtpToFilter.Enabled = False


        LoadExamineeDgv()
    End Sub

    Private Sub chkDateFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkDateFilter.CheckedChanged
        If chkDateFilter.Checked Then
            dtpFromFilter.Enabled = True
            dtpToFilter.Enabled = True
        Else
            dtpFromFilter.Enabled = False
            dtpToFilter.Enabled = False
        End If
    End Sub


    ' -- EXAM TAB --

    Private Sub LoadExamSet()
        ' Clear combobox
        cboExamSet.Items.Clear()

        cboExamSet.Items.Add("A")
        cboExamSet.Items.Add("B")
        cboExamSet.Items.Add("C")

        cboExamSet.SelectedIndex = 0
        cboExamLevel.SelectedIndex = 0
        cboExamType.SelectedIndex = 0


        ' NOT USED ANYMORE
        'sql.ExecuteQuery("SELECT * FROM tbl_set")

        '' Fill Combobox
        'If sql.recordCount > 0 Then
        '    For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
        '        cboExamSet.Items.Add(r("setDescription"))
        '    Next
        'Else
        '    cboExamSet.Items.Add("No sets yet.")
        'End If

    End Sub

    Private Sub cboExamSet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExamSet.SelectedIndexChanged


        If cboExamSet.Text = "A" Then
            examSetDescription = "A"
        ElseIf cboExamSet.Text = "B" Then
            examSetDescription = "B"
        ElseIf cboExamSet.Text = "C" Then
            examSetDescription = "C"
        End If

        lblExamSet.Text = examSetDescription

        ' Clear combobox when changing
        cboExamLevel.Items.Clear()
        cboExamType.Items.Clear()

        LoadExamLevel()



    End Sub

    Private Sub LoadExamLevel()

        ' Comboboxes clear
        cboExamLevel.Items.Clear()

        sql.ExecuteQuery("SELECT * FROM tbl_level")

        ' FILLING OF CBs
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                cboExamLevel.Items.Add(r("levelDescription"))
            Next
        Else
            cboExamLevel.Items.Add("No levels yet.")
        End If

    End Sub

    Private Sub cboExamLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExamLevel.SelectedIndexChanged

        ' SUPERVISORY MENU
        If cboExamLevel.Text = "Supervisory" Or examLevelID = 1 Then

            examLevelID = 1

            ' Comboboxes clear
            cboExamType.Items.Clear()

            sql.AddParam("@examSetID", lblExamSet.Text)
            sql.ExecuteQuery("SELECT * FROM tbl_kind
                                 INNER JOIN tbl_test_type 
                                    ON tbl_kind.testTypeID = tbl_test_type.testTypeID
                                 WHERE tbl_kind.levelID = 1")

            ' FILLING OF CBs
            If sql.recordCount > 0 Then
                For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                    cboExamType.Items.Add(r("testTypeDescription"))
                Next
            Else
                cboExamType.Items.Add("No types yet.")
            End If
        End If



        ' NON-SUPERVISORY MENU
        If cboExamLevel.Text = "Non-Supervisory" Or examLevelID = 2 Then
            examLevelID = 2

            ' Comboboxes clear
            cboExamType.Items.Clear()


            sql.AddParam("@examSetID", lblExamSet.Text)
            sql.ExecuteQuery("SELECT * FROM tbl_kind
                                 INNER JOIN tbl_test_type 
                                    ON tbl_kind.testTypeID = tbl_test_type.testTypeID
                                 WHERE tbl_kind.levelID = 2")
            ' FILLING OF CBs
            If sql.recordCount > 0 Then
                For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                    cboExamType.Items.Add(r("testTypeDescription"))
                Next
            Else
                cboExamType.Items.Add("No types yet.")
            End If

        End If



        ' CLERICAL MENU
        If cboExamLevel.Text = "Clerical" Or examLevelID = 3 Then
            examLevelID = 3

            ' Comboboxes clear
            cboExamType.Items.Clear()


            sql.AddParam("@examSetID", lblExamSet.Text)
            sql.ExecuteQuery("SELECT * FROM tbl_kind
                                 INNER JOIN tbl_test_type 
                                    ON tbl_kind.testTypeID = tbl_test_type.testTypeID
                                 WHERE tbl_kind.levelID = 3")
            ' FILLING OF CBs
            If sql.recordCount > 0 Then
                For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                    cboExamType.Items.Add(r("testTypeDescription"))
                Next
            Else
                cboExamType.Items.Add("No types yet.")
            End If
        End If

        ' Place examLevelID
        lblExamLevelID.Text = examLevelID

    End Sub

    Private Sub cboExamType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExamType.SelectedIndexChanged

        ' NULL EXAM LEVEL CATCH
        If cboExamLevel.Text = "" Then
            picExamError.Visible = True
            lblExamError.Text = "Please select a level first!"
            lblExamError.Visible = True
            Exit Sub
        End If

        ' THIS IS NOT NEEDED
        '' GET EXAM LEVEL ID
        'sql.AddParam("@examLevelselected", cboExamLevel.Text)
        'sql.ExecuteQuery("SELECT * FROM tbl_level WHERE levelDescription = @examLevelselected")
        'If sql.recordCount > 0 Then
        '    For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
        '        examLevelID = Convert.ToInt64((r("levelID")))
        '    Next
        'Else
        '    picExamError.Visible = True
        '    lblExamError.Text = "No Level selected yet!"
        '    lblExamError.Visible = True
        '    Exit Sub
        'End If



        ' GET testtype ID
        sql.AddParam("@testTypeSelected", cboExamType.Text)
        sql.AddParam("@levelID", lblExamLevelID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_test_type
                             INNER JOIN tbl_kind 
                                     ON tbl_test_type.testTypeID = tbl_kind.testTypeID
                                  WHERE tbl_test_type.testTypeDescription = @testTypeSelected
                                    AND tbl_kind.levelID = @levelID")
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                examTypeID = Convert.ToInt64((r("testTypeID")))
            Next
        Else
            picExamError.Visible = True
            lblExamError.Text = "No test type selected yet!"
            lblExamError.Visible = True
            Exit Sub
        End If

        lblExamLevelID.Text = examLevelID
        lblExamTypeID.Text = examTypeID

        ' Query for KindID
        sql.AddParam("@levelID", lblExamLevelID.Text)
        sql.AddParam("@examTypeID", lblExamTypeID.Text)
        sql.ExecuteQuery("SELECT kindID FROM tbl_kind 
                                        WHERE levelID = @levelID 
                                          AND testTypeID = @examTypeID")

        lblKindID.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("kindID").ToString




        ' CLEARS ALL FIELDS
        lblQuestionID.Text = ""
        rtfQuestion.Text = ""
        txtChoice1.Text = ""
        txtChoice2.Text = ""
        txtChoice3.Text = ""
        txtChoice4.Text = ""
        rbChoice1.Checked = False
        rbChoice2.Checked = False
        rbChoice3.Checked = False
        rbChoice4.Checked = False
        txtSearch.Text = ""

        ' FINALLY IF EXAM LEVEL AND TEST TYPE READY THEN QUERY

        If examLevelID <> Nothing And examTypeID <> Nothing Then
            LoadExamDgv()
        End If

        picExamError.Visible = False
        lblExamError.Visible = False
    End Sub

    Private Sub LoadExamDgv()

        ' GETS KIND_ID AND setDescription
        sql.AddParam("@setDescription", lblExamSet.Text)
        sql.AddParam("@kindID", lblKindID.Text)


        ' GETS kind_ID and setDescription for questions 
        sql.ExecuteQuery("SELECT questionID AS Question_ID 
                            FROM tbl_question 
                           WHERE kindID = @kindID
                             AND setDescription = @setDescription")



        dgvExam.DataSource = sql.sqlDataSet.Tables(0)

        ' Sets the number of questions available for that exam or test
        lblQuestionCounter.Text = dgvExam.RowCount

    End Sub

    Private Sub LoadExamDgv(searchString As String)
        sql.AddParam("@setDescription", lblExamSet.Text)
        sql.AddParam("@examLevelID", examLevelID)
        sql.AddParam("@testTypeID", examTypeID)
        sql.AddParam("@kindID", lblKindID.Text)
        'sql.ExecuteQuery("SELECT questionID AS Question_ID, 
        'From tbl_question
        'Where kindID = @kindID 
        '                      And (question LIKE '%" & searchString & "%'
        '                       Or choice1 LIKE '%" & searchString & "%'
        '                       Or choice2 LIKE '%" & searchString & "%'
        '                       Or choice3 LIKE '%" & searchString & "%'
        '                       Or choice4 LIKE '%" & searchString & "%'
        '                       Or correctAnswer LIKE '%" & searchString & "%')")

        sql.AddParam("@searchID", searchString)
        sql.ExecuteQuery("SELECT questionID as Question_ID 
                          FROM tbl_question
                         WHERE setDescription = @setDescription
                           AND questionID LIKE @searchID
                           AND kindID = @kindID")

        If sql.recordCount <= 0 Then
            Exit Sub
        End If
        dgvExam.DataSource = sql.sqlDataSet.Tables(0)

    End Sub

    Private Sub rbChoice1_CheckedChanged(sender As Object, e As EventArgs) Handles rbChoice1.CheckedChanged
        correctAnswer = txtChoice1.Text
    End Sub

    Private Sub rbChoice2_CheckedChanged(sender As Object, e As EventArgs) Handles rbChoice2.CheckedChanged

        correctAnswer = txtChoice2.Text
    End Sub

    Private Sub rbChoice3_CheckedChanged(sender As Object, e As EventArgs) Handles rbChoice3.CheckedChanged

        correctAnswer = txtChoice3.Text
    End Sub

    Private Sub rbChoice4_CheckedChanged(sender As Object, e As EventArgs) Handles rbChoice4.CheckedChanged

        correctAnswer = txtChoice4.Text
    End Sub

    Private Sub btnQuestionSave_Click(sender As Object, e As EventArgs) Handles btnQuestionSave.Click

        ' ERROR CATCHING
        If cboExamSet.Text = "" Then
            picExamError.Visible = True
            lblExamError.Text = "No exam set selected"
            lblExamError.Visible = True
            Exit Sub
        End If

        If cboExamType.Text = "" Then
            picExamError.Visible = True
            lblExamError.Text = "No exam type selected!"
            lblExamError.Visible = True
            Exit Sub
        End If

        If rtfQuestion.Rtf = "" Or rtfQuestion.Text = "" Or txtChoice1.Text = "" Or txtChoice2.Text = "" Or txtChoice3.Text = "" Or txtChoice4.Text = "" Then
            picExamError.Visible = True
            lblExamError.Text = "Fields must be filled!"
            lblExamError.Visible = True
            Exit Sub
        End If

        If txtChoice1.Text = txtChoice2.Text Or txtChoice1.Text = txtChoice3.Text Or txtChoice1.Text = txtChoice4.Text Then
            picExamError.Visible = True
            lblExamError.Text = "No answer should be the same!"
            lblExamError.Visible = True
            Exit Sub
        End If

        If txtChoice2.Text = txtChoice1.Text Or txtChoice2.Text = txtChoice3.Text Or txtChoice2.Text = txtChoice4.Text Then
            picExamError.Visible = True
            lblExamError.Text = "No answer should be the same!"
            lblExamError.Visible = True
            Exit Sub
        End If

        If txtChoice3.Text = txtChoice1.Text Or txtChoice3.Text = txtChoice2.Text Or txtChoice3.Text = txtChoice4.Text Then
            picExamError.Visible = True
            lblExamError.Text = "No answer should be the same!"
            lblExamError.Visible = True
            Exit Sub
        End If

        If txtChoice4.Text = txtChoice1.Text Or txtChoice4.Text = txtChoice2.Text Or txtChoice4.Text = txtChoice3.Text Then
            picExamError.Visible = True
            lblExamError.Text = "No answer should be the same!"
            lblExamError.Visible = True
            Exit Sub
        End If

        If correctAnswer = Nothing Then
            picExamError.Visible = True
            lblExamError.Text = "No answer was chosen!"
            lblExamError.Visible = True

            Exit Sub
        End If



        ' GET CORRECT ANSWER
        If rbChoice1.Checked Then
            correctAnswer = txtChoice1.Text
        ElseIf rbChoice2.Checked Then
            correctAnswer = txtChoice2.Text
        ElseIf rbChoice3.Checked Then
            correctAnswer = txtChoice3.Text
        ElseIf rbChoice4.Checked Then
            correctAnswer = txtChoice4.Text
        End If

        ' Holds the content of our question
        Dim _questionContent As Byte()

        ' EDIT
        ' QUESTION ID PRESENT
        If lblQuestionID.Text <> Nothing Then
            _questionContent = System.Text.Encoding.ASCII.GetBytes(rtfQuestion.Rtf)

            sql.AddParam("@questionID", lblQuestionID.Text)
            sql.AddParam("@question", _questionContent)
            sql.AddParam("@choice1", txtChoice1.Text)
            sql.AddParam("@choice2", txtChoice2.Text)
            sql.AddParam("@choice3", txtChoice3.Text)
            sql.AddParam("@choice4", txtChoice4.Text)
            sql.AddParam("@correctAnswer", correctAnswer)
            sql.ExecuteQuery("UPDATE tbl_question  
                                 SET question = @question,
                                     choice1 = @choice1,
                                     choice2 = @choice2,
                                     choice3 = @choice3,
                                     choice4 = @choice4,
                                     correctAnswer = @correctAnswer
                               WHERE questionID = @questionID")
        End If

        ' QUESTION INSERTION
        If lblQuestionID.Text = "" Then
            _questionContent = System.Text.Encoding.ASCII.GetBytes(rtfQuestion.Rtf)

            sql.AddParam("@kindID", lblKindID.Text)
            sql.AddParam("@question", _questionContent)
            sql.AddParam("@choice1", txtChoice1.Text)
            sql.AddParam("@choice2", txtChoice2.Text)
            sql.AddParam("@choice3", txtChoice3.Text)
            sql.AddParam("@choice4", txtChoice4.Text)
            sql.AddParam("@correctAnswer", correctAnswer)
            sql.AddParam("@setDescription", lblExamSet.Text)
            sql.ExecuteQuery("INSERT 
            INTO tbl_question (kindID, question, choice1, choice2, choice3, choice4, correctAnswer, setDescription)
            VALUES (@kindID, @question, @choice1, @choice2, @choice3, @choice4, @correctAnswer, @setDescription)")

        End If

        lblQuestionID.Text = ""
        rtfQuestion.Text = ""
        txtChoice1.Text = ""
        txtChoice2.Text = ""
        txtChoice3.Text = ""
        txtChoice4.Text = ""
        rbChoice1.Checked = False
        rbChoice2.Checked = False
        rbChoice3.Checked = False
        rbChoice4.Checked = False
        txtSearch.Text = ""

        LoadExamDgv()
        picExamError.Visible = False
        lblExamError.Visible = False


    End Sub

    Private Sub btnQuestionDelete_Click(sender As Object, e As EventArgs) Handles btnQuestionDelete.Click

        ' Edit validator
        If lblQuestionID.Text = "" Then
            picExamError.Visible = True
            lblExamError.Text = "Please select a record below first!"
            lblExamError.Visible = True
            Exit Sub
        End If

        If MsgBox("Delete selected record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            sql.AddParam("@questionID", lblQuestionID.Text)
            sql.ExecuteQuery("DELETE FROM tbl_question
                                WHERE questionID = @questionID")

            ' CLEAR FIELDS
            lblQuestionID.Text = ""
            rtfQuestion.Text = ""
            txtChoice1.Text = ""
            txtChoice2.Text = ""
            txtChoice3.Text = ""
            txtChoice4.Text = ""
            rbChoice1.Checked = False
            rbChoice2.Checked = False
            picExamError.Visible = False
            lblExamError.Visible = False
            rbChoice3.Checked = False
            rbChoice4.Checked = False

        End If
        LoadExamDgv()
        picExamError.Visible = False
        lblExamError.Visible = False
    End Sub

    Private Sub btnExamClear_Click(sender As Object, e As EventArgs) Handles btnExamClear.Click
        lblQuestionID.Text = ""
        rtfQuestion.Rtf = ""

        txtChoice1.Text = ""
        txtChoice2.Text = ""
        txtChoice3.Text = ""
        txtChoice4.Text = ""

        rbChoice1.Checked = False
        rbChoice2.Checked = False
        rbChoice3.Checked = False
        rbChoice4.Checked = False

        picExamError.Visible = False
        lblExamError.Visible = False
    End Sub

    Private Sub dgvExam_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvExam.MouseDown

        ' Do the hit test first
        Dim _ht = dgvExam.HitTest(e.Location.X, e.Location.Y)
        If _ht.Type = DataGridViewHitTestType.None Or _ht.Type = DataGridViewHitTestType.ColumnHeader Then
            Exit Sub
        End If


        If e.Button = MouseButtons.Left Or e.Button = MouseButtons.Right Then
            'Gets of row clicked
            rowClicked = dgvExam.HitTest(e.Location.X, e.Location.Y).RowIndex
            'Clears highlight
            dgvExam.ClearSelection()
            'Highlights rowClicked row
            dgvExam.Rows(rowClicked).Selected = True

            Dim _questionID As String = dgvExam.SelectedRows(0).Cells("Question_ID").Value.ToString()
            lblQuestionID.Text = _questionID
            Dim _content As Byte()

            ' Query for question items
            sql.AddParam("@questionID", _questionID)
            sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")



            _content = sql.sqlDataSet.Tables(0).Rows(0).Item("question")
            rtfQuestion.Rtf = System.Text.Encoding.ASCII.GetChars(_content)

            txtChoice1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice1")
            txtChoice2.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice2")
            txtChoice3.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice3")
            txtChoice4.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice4")
            correctAnswer = sql.sqlDataSet.Tables(0).Rows(0).Item("correctAnswer")

            If correctAnswer = txtChoice1.Text Then
                rbChoice1.Checked = True
            ElseIf correctAnswer = txtChoice2.Text Then
                rbChoice2.Checked = True
            ElseIf correctAnswer = txtChoice3.Text Then
                rbChoice3.Checked = True
            ElseIf correctAnswer = txtChoice4.Text Then
                rbChoice4.Checked = True
            End If

        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            LoadExamDgv()
        Else
            LoadExamDgv(txtSearch.Text)
        End If
    End Sub

    ' Code source: Rich Text Editor(Tabbed) by DimitriV
    Private Sub tsbInsertImage_Click(sender As Object, e As EventArgs) Handles tsbInsertImage.Click
        Dim _imageOpen As New OpenFileDialog

        With _imageOpen
            .Filter = "JPG Images (*.jpg)|*.jpg|BMP Images (*.bmp)|*.bmp"
        End With

        ' _imageOpen.ShowDialog()

        If _imageOpen.ShowDialog = DialogResult.OK Then
            Clipboard.SetImage(New Bitmap(_imageOpen.FileName))
            rtfQuestion.Paste()
        End If

    End Sub

    Private Sub tsbChangeFont_Click(sender As Object, e As EventArgs) Handles tsbChangeFont.Click

        If fdChangeFont.ShowDialog = DialogResult.OK Then
            rtfQuestion.DeselectAll()
            rtfQuestion.SelectAll()
            rtfQuestion.SelectionFont = fdChangeFont.Font
        End If

    End Sub

    Private Sub tslInsertImage_Click(sender As Object, e As EventArgs) Handles tslInsertImage.Click
        Dim _imageOpen As New OpenFileDialog

        With _imageOpen
            .Filter = "JPG Images (*.jpg)|*.jpg|BMP Images (*.bmp)|*.bmp"
        End With

        ' _imageOpen.ShowDialog()

        If _imageOpen.ShowDialog = DialogResult.OK Then
            Clipboard.SetImage(New Bitmap(_imageOpen.FileName))
            rtfQuestion.Paste()
        End If

    End Sub

    Private Sub tslChangeFont_Click(sender As Object, e As EventArgs) Handles tslChangeFont.Click
        If fdChangeFont.ShowDialog = DialogResult.OK Then
            rtfQuestion.DeselectAll()
            rtfQuestion.SelectAll()
            rtfQuestion.SelectionFont = fdChangeFont.Font
        End If
    End Sub

    ' -- CONFIGURATION TAB -- 

    Private Sub btnTimerSave_Click(sender As Object, e As EventArgs) Handles btnTimerSave.Click

        ' CATCH WHETHER INPUT IS CHARACTER OR NUMBER
        If HasChar(txtManagementTime.Text) Or HasChar(txtSupervisoryNumericalTime.Text) Or HasChar(txtSupervisoryVerbalTime.Text) Or HasChar(txtReadingComprehensionTime.Text) Or HasChar(txtNonSupervisoryNumericalTime.Text) Or HasChar(txtNonSupervisoryVerbalTime.Text) Or HasChar(txtClericalNumericalTime.Text) Or HasChar(txtClericalVerbalTime.Text) Or HasChar(txtClericalReasoningTime.Text) Or HasChar(txtAbstractReasoningTime.Text) Or HasChar(txtGeneralInfoTime.Text) Then
            MessageBox.Show("No letters in Timers please.")
            Exit Sub
        End If

        If txtSupervisoryNumericalTime.Text = "" Or txtSupervisoryVerbalTime.Text = "" Or txtManagementTime.Text = "" Then
            MessageBox.Show("Please fill fields")
            Exit Sub
        End If

        If txtNonSupervisoryVerbalTime.Text = "" Or txtNonSupervisoryNumericalTime.Text = "" Or txtReadingComprehensionTime.Text = "" Then
            MessageBox.Show("Please fill fields")
            Exit Sub
        End If

        If txtClericalReasoningTime.Text = "" Or txtClericalVerbalTime.Text = "" Or txtClericalNumericalTime.Text = "" Or txtAbstractReasoningTime.Text = "" Or txtGeneralInfoTime.Text = "" Then
            MessageBox.Show("Please fill fields")
            Exit Sub
        End If


        ' Minutes to be passed in the database
        Dim _supervisoryManagementTime As Integer = txtManagementTime.Text
        Dim _supervisoryNumericalTime As Integer = txtSupervisoryNumericalTime.Text
        Dim _supervisoryVerbalTime As Integer = txtSupervisoryVerbalTime.Text


        sql.AddParam("@superManagement", _supervisoryManagementTime)
        sql.AddParam("@levelID", 1)
        sql.AddParam("@testTypeID", 3)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @superManagement WHERE testTypeID = @testTypeID And levelID = @levelID")

        sql.AddParam("@superNumerical", _supervisoryNumericalTime)
        sql.AddParam("@levelID", 1)
        sql.AddParam("@testTypeID", 1)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @superNumerical WHERE testTypeID = @testTypeID And levelID = @levelID")

        sql.AddParam("@superVerbal", _supervisoryVerbalTime)
        sql.AddParam("@levelID", 1)
        sql.AddParam("@testTypeID", 2)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @superVerbal WHERE testTypeID = @testTypeID And levelID = @levelID")


        Dim _nonSupervisoryReadingTime As Integer = txtReadingComprehensionTime.Text
        Dim _nonSupervisoryNumericalTime As Integer = txtNonSupervisoryNumericalTime.Text
        Dim _nonSupervisoryVerbalTime As Integer = txtNonSupervisoryVerbalTime.Text

        sql.AddParam("@nonReading", _nonSupervisoryReadingTime)
        sql.AddParam("@levelID", 2)
        sql.AddParam("@testTypeID", 4)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @nonReading WHERE testTypeID = @testTypeID And levelID = @levelID")

        sql.AddParam("@nonNumerical", _nonSupervisoryNumericalTime)
        sql.AddParam("@levelID", 2)
        sql.AddParam("@testTypeID", 1)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @nonNumerical WHERE testTypeID = @testTypeID And levelID = @levelID")

        sql.AddParam("@nonVerbal", _nonSupervisoryVerbalTime)
        sql.AddParam("@levelID", 2)
        sql.AddParam("@testTypeID", 2)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @nonVerbal WHERE testTypeID = @testTypeID And levelID = @levelID")


        Dim _clericalGeneralInfoTime As Integer = txtGeneralInfoTime.Text
        Dim _clericalClericalReasoningTime As Integer = txtClericalReasoningTime.Text
        Dim _clericalAbstractReasoningTime As Integer = txtAbstractReasoningTime.Text
        Dim _clericalNumericalTime As Integer = txtClericalNumericalTime.Text
        Dim _clericalVerbalTime As Integer = txtClericalVerbalTime.Text

        sql.AddParam("@cleGeneralInformationTime", _clericalGeneralInfoTime)
        sql.AddParam("@levelID", 3)
        sql.AddParam("@testTypeID", 5)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @cleGeneralInformationTime WHERE testTypeID = @testTypeID And levelID = @levelID")

        sql.AddParam("@cleClericalTime", _clericalClericalReasoningTime)
        sql.AddParam("@levelID", 3)
        sql.AddParam("@testTypeID", 6)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @cleClericalTime WHERE testTypeID = @testTypeID And levelID = @levelID")

        sql.AddParam("@cleAbstractTime", _clericalAbstractReasoningTime)
        sql.AddParam("@levelID", 3)
        sql.AddParam("@testTypeID", 7)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @cleAbstractTime WHERE testTypeID = @testTypeID And levelID = @levelID")

        sql.AddParam("@cleNumericalTime", _clericalNumericalTime)
        sql.AddParam("@levelID", 3)
        sql.AddParam("@testTypeID", 1)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @cleNumericalTime WHERE testTypeID = @testTypeID And levelID = @levelID")

        sql.AddParam("@cleVerbalTime", _clericalVerbalTime)
        sql.AddParam("@levelID", 3)
        sql.AddParam("@testTypeID", 2)
        sql.ExecuteQuery("UPDATE tbl_kind SET timer = @cleVerbalTime WHERE testTypeID = @testTypeID And levelID = @levelID")

        MessageBox.Show("Time set")

    End Sub

    Private Function HasChar(Text As String) As Boolean
        Dim _charArray As Char() = Text.ToArray()

        For Each charr In _charArray
            If charr <> "1" And charr <> "2" And charr <> "3" And charr <> "4" And charr <> "5" And charr <> "6" And charr <> "7" And charr <> "8" And charr <> "9" And charr <> "0" Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub LoadTimers()
        ' For Supervisory
        sql.ExecuteQuery("SELECT timer FROM tbl_kind
                                  WHERE levelID = 1")

        txtManagementTime.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("timer")
        txtSupervisoryNumericalTime.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("timer")
        txtSupervisoryVerbalTime.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("timer")

        ' For Non-Supervisory
        sql.ExecuteQuery("SELECT timer FROM tbl_kind
                                  WHERE levelID = 2")

        txtReadingComprehensionTime.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("timer")
        txtNonSupervisoryNumericalTime.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("timer")
        txtNonSupervisoryVerbalTime.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("timer")

        ' For Clerical
        sql.ExecuteQuery("SELECT timer FROM tbl_kind
                                  WHERE levelID = 3")

        txtClericalNumericalTime.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("timer")
        txtClericalVerbalTime.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("timer")
        txtGeneralInfoTime.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("timer")
        txtClericalReasoningTime.Text = sql.sqlDataSet.Tables(0).Rows(3).Item("timer")
        txtAbstractReasoningTime.Text = sql.sqlDataSet.Tables(0).Rows(4).Item("timer")
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        BackupFunction()
    End Sub

    Private Function BackupFunction()

        Dim _currDate As String = Date.Now.ToString("MMMM dd, yyyy - HH:mm")
        Dim _dbFile As String

        Try
            sfdBackup.Filter = "SQL Dump File (*.sql)|*.sql|All Files (*.*)|*.*"
            sfdBackup.FileName = "PQE Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"

            If sfdBackup.ShowDialog = DialogResult.OK Then

                sql.AddParam("@currDate", _currDate)
                sql.ExecuteQuery("UPDATE tbl_admin
                                     SET lastBackup = @currDate
                                   WHERE adminID = 1
                                     AND adminUsername = 'admin'
                                     AND adminLevel = 0")


                _dbFile = sfdBackup.FileName

                Dim backUpProcess As New Process
                backUpProcess.StartInfo.FileName = "cmd.exe"
                backUpProcess.StartInfo.UseShellExecute = False
                backUpProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
                backUpProcess.StartInfo.RedirectStandardInput = True
                backUpProcess.StartInfo.RedirectStandardOutput = True
                backUpProcess.Start()

                Dim backUpStream As StreamWriter = backUpProcess.StandardInput
                Dim streamReady As StreamReader = backUpProcess.StandardOutput
                backUpStream.WriteLine("mysqldump --user=root --password=  -h localhost db_dost > """ + _dbFile + """")

                backUpStream.Close()
                backUpProcess.WaitForExit()
                backUpProcess.Close()

                MsgBox("Backup database successful", MsgBoxStyle.Information, "Backup MySql Database")


            End If

        Catch ex As Exception
            MsgBox("Backup database failed", MsgBoxStyle.Information, "Backup MySql Database")
        End Try

        Return 0
    End Function

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click

        Dim _currDate As String = Date.Now.ToString("MMMM dd, yyyy - HH:mm")
        Dim _dbFile As String

        If MessageBox.Show("Would you like to backup first?", "Restore Databases", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            BackupFunction()
        End If

        Try
            ofdRestore.Filter = "SQL Dump File (*.sql)|*.sql|All Files (*.*)|*.*"

            If ofdRestore.ShowDialog = DialogResult.OK Then

                _dbFile = ofdRestore.FileName

                Dim backUpProcess As New Process
                backUpProcess.StartInfo.FileName = "cmd.exe"
                backUpProcess.StartInfo.UseShellExecute = False
                backUpProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
                backUpProcess.StartInfo.RedirectStandardInput = True
                backUpProcess.StartInfo.RedirectStandardOutput = True
                backUpProcess.Start()


                Dim backUpStream As StreamWriter = backUpProcess.StandardInput
                Dim streamReady As StreamReader = backUpProcess.StandardOutput
                backUpStream.WriteLine("mysql --user=root --password=  -h localhost db_dost < """ + _dbFile + """")

                backUpStream.Close()
                backUpProcess.WaitForExit()
                backUpProcess.Close()

                sql.AddParam("@currDate", _currDate)
                sql.ExecuteQuery("UPDATE tbl_admin
                                     SET lastRestore = @currDate
                                   WHERE adminID = 1
                                     AND adminUsername = 'admin'
                                     AND adminLevel = 0")

                lblLastRestore.Text = _currDate

                MsgBox("Restore database successful", MsgBoxStyle.Information, "Restore MySql Database")


            End If



        Catch ex As Exception
            MsgBox("Restore database failed", MsgBoxStyle.Information, "Restore MySql Database")
        End Try



    End Sub

    Private Function HashPass(stringPassword) As String
        Dim _salt1 = "Egg"
        Dim _salt2 = "Bacon"
        Dim _bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(stringPassword)
        Dim _hashOfBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(_bytes)
        Dim _stringHash As String = _salt1 & Convert.ToBase64String(_hashOfBytes) & _salt2
        Return _stringHash
    End Function

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click

        sql.AddParam("@currPass", HashPass(txtCurrentPassword.Text))
        sql.AddParam("@newPass", HashPass(txtNewPassword.Text))

        sql.ExecuteQuery("UPDATE tbl_admin
                             SET adminPassword = @newPass
                           WHERE adminID = 1
                             AND adminPassword = @currPass")

        sql.AddParam("@newPass", HashPass(txtNewPassword.Text))

        sql.ExecuteQuery("SELECT * FROM tbl_admin
                           WHERE adminID = 1
                             AND adminPassword = @newPass")

        If sql.recordCount = 1 Then
            MessageBox.Show("Password successfully changed.")
        Else
            MessageBox.Show("Unmatching current password.")
        End If

        txtCurrentPassword.Text = ""
        txtNewPassword.Text = ""
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        ' Set in Properties 
        If chkShowPassword.Checked = False Then
            txtCurrentPassword.PasswordChar = "*"
            txtNewPassword.PasswordChar = "*"
        Else
            txtCurrentPassword.PasswordChar = ""
            txtNewPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub cboExamineeSet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExamineeSet.SelectedIndexChanged
        LoadExamineeDgv()
    End Sub

    Private Sub btnTempoAdd_Click(sender As Object, e As EventArgs) Handles btnTempoAdd.Click

        ' validate username
        If txtTempoUser.Text.Length < 5 Then
            MessageBox.Show("Temporary Admin's Username must be more than 6 characters and contain at least 1 letter and 1 number.")
            Exit Sub
        End If

        ' validate password
        Dim _letterFilter As Char() = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim _numFilter As Char() = "1234567890"
        Dim _hasLetter As Boolean = False
        Dim _hasNumber As Boolean = False

        If txtTempoPass.Text.Length < 5 Then
            MessageBox.Show("Temporary Admin's Password must be more than 6 characters and contain at least 1 letter and 1 number.")
            Exit Sub
        End If


        ' catches letters
        For Each _charr In txtTempoPass.Text
            For x As Integer = 0 To _letterFilter.Length - 1
                If _charr = _letterFilter(x) Then
                    _hasLetter = True
                    Exit For
                End If
            Next

            If _hasLetter Then
                Exit For
            End If
        Next

        ' catches numbers
        For Each _charr In txtTempoPass.Text
            For x As Integer = 0 To _numFilter.Length - 1
                If _charr = _numFilter(x) Then
                    _hasNumber = True
                    Exit For
                End If
            Next

            If _hasNumber Then
                Exit For
            End If
        Next

        If Not _hasLetter Or Not _hasNumber Then
            MessageBox.Show("Temporary Admin's password must be more than 6 characters and contain at least 1 letter and 1 number.")
            Exit Sub
        End If


        ' to see if admins > 2
        sql.ExecuteQuery("SELECT * FROM tbl_admin")

        If sql.recordCount > 2 Then
            MessageBox.Show("Only 2 Temporary Admins are allowed.")
            txtTempoUser.Text = ""
            txtTempoPass.Text = ""
            Exit Sub
        End If

        ' Query: See if TempAdmin is equal to Admin
        sql.AddParam("@username", txtTempoUser.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_admin WHERE adminUsername = @username AND adminLevel = 0")
        ' If TempAdmin has the same name as Admin
        If sql.recordCount = 1 Then
            MessageBox.Show("Temporary admin has the same username as admin")
            txtTempoUser.Text = ""
            txtTempoPass.Text = ""
            Exit Sub
        End If

        sql.AddParam("@username", txtTempoUser.Text)
        sql.AddParam("@password", txtTempoPass.Text)
        sql.ExecuteQuery("INSERT INTO tbl_admin (adminUsername, adminPassword, adminLevel)
                                         VALUES (@username, @password, 1)")

        txtTempoUser.Text = ""
        txtTempoPass.Text = ""

        LoadDgvTempo()

    End Sub

    Private Sub btnTempoDelete_Click(sender As Object, e As EventArgs) Handles btnTempoDelete.Click

        If tempoAdminID = "" Then
            MessageBox.Show("Please select a record below first.")
            Exit Sub
        End If

        If MsgBox("Would you really like to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql.AddParam("@tempoAdminID", tempoAdminID)
            sql.ExecuteQuery("DELETE FROM tbl_admin
                                    WHERE adminID = @tempoAdminID")

            tempoAdminID = ""
        End If

        LoadDgvTempo()

    End Sub

    Private Sub LoadDgvTempo()

        sql.ExecuteQuery("SELECT adminID AS admin_ID, adminUsername AS Username, adminPassword AS Password FROM tbl_admin
                           WHERE NOT (adminID = 1
                                      OR adminUsername = 'admin'
                                      OR adminLevel = 0)")

        dgvTempo.DataSource = sql.sqlDataSet.Tables(0)
    End Sub

    Private Sub dgvTempo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTempo.CellClick
        tempoAdminID = dgvTempo.SelectedRows(0).Cells("admin_ID").Value.ToString
        txtTempoUser.Text = dgvTempo.SelectedRows(0).Cells("Username").Value.ToString
        txtTempoPass.Text = dgvTempo.SelectedRows(0).Cells("Password").Value.ToString
    End Sub

End Class