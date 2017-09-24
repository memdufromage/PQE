Imports MaterialSkin

Public Class Login

    Public sql As New SQLControl

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim _skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        _skinManager.AddFormToManage(Me)
        _skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        _skinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        MaximizeBox = False
        MinimizeBox = False

    End Sub

    Private Function HashPass(stringPassword) As String
        Dim _salt1 = "Egg"
        Dim _salt2 = "Bacon"
        Dim _bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(stringPassword)
        Dim _hashOfBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(_bytes)
        Dim _stringHash As String = _salt1 & Convert.ToBase64String(_hashOfBytes) & _salt2
        Return _stringHash
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' CHECKS IF NULL
        If txtExamineeDateID.Text = "" Or txtLastName.Text = "" Then
            MessageBox.Show("Details are incorrect")
        End If

        ' SELECTING FROM tbl_admin
        Dim _adminUsername As String = txtExamineeDateID.Text
        Dim _adminPassword As String = HashPass(txtLastName.Text)

        sql.AddParam("@adminUsername", _adminUsername)
        sql.AddParam("@adminPassword", _adminPassword)
        sql.ExecuteQuery("SELECT * FROM tbl_admin 
                                  WHERE adminUsername = @adminUsername 
                                    AND adminPassword = @adminPassword")

        ' Checks if there is an admin
        If sql.recordCount > 0 Then
            AdminDashboard.Show()
            Me.Close()
            Exit Sub
        Else

            ' If there is TEMPORARY ADMIN
            sql.AddParam("@adminUsername", _adminUsername)
            sql.AddParam("@adminPassword", txtLastName.Text)

            sql.ExecuteQuery("SELECT * FROM tbl_admin 
                                      WHERE adminUsername = @adminUsername 
                                        AND adminPassword = @adminPassword
                                        AND adminLevel = 1")

            If sql.recordCount > 0 Then
                AdminTempDashboard.Show()
                Me.Close()
                Exit Sub
            End If


            ' EXAMINEE CASE
            Dim _examineeDateID As String = txtExamineeDateID.Text
            Dim _examineeLastName As String = txtLastName.Text

            sql.AddParam("@examineeDateID", _examineeDateID)
            sql.AddParam("@examineeLastName", _examineeLastName)
            sql.ExecuteQuery("SELECT * FROM tbl_examinee 
                                      WHERE examineeDateID = @examineeDateID
                                        AND lastName = @examineeLastName")

            ' EXAMINEE EXISTING
            If sql.recordCount > 0 Then


                ' Gets our ID to query for tbl_examinee_set
                Dim _examineeSetID As String = sql.sqlDataSet.Tables(0).Rows(0).Item("examineeID").ToString

                sql.AddParam("@examineeSetID", _examineeSetID)
                sql.ExecuteQuery("SELECT * FROM tbl_examinee_set 
                                          WHERE examineeID = @examineeSetID")


                If sql.recordCount > 0 Then
                    If sql.recordCount = 1 Then
                        ' Case of A and B
                        If sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString = "" Then

                            Examinee.lblSetDescription.Text = "A"
                            DoExamination()

                        ElseIf sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString = "Failed" Then

                            Examinee.lblSetDescription.Text = "B"
                            DoExamination()

                        ElseIf sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString = "Passed" Then
                            MessageBox.Show("You already have passed the test.")
                            Exit Sub
                        End If
                    ElseIf sql.recordCount = 2 Then

                        ' Case of A B FAILED
                        If sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString = "Failed" And sql.sqlDataSet.Tables(0).Rows(1).Item("result").ToString = "Failed" Then
                            MessageBox.Show("You go set C")
                            Examinee.lblSetDescription.Text = "C"
                            DoExamination()

                            ' Case of A or B is passed
                        ElseIf sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString = "Passed" Or sql.sqlDataSet.Tables(0).Rows(1).Item("result").ToString = "Passed" Then
                            MessageBox.Show("You already have passed.")
                            Exit Sub
                        End If


                    ElseIf sql.recordCount = 3 Then
                        ' Case of A B C
                        MessageBox.Show("You already have passed or have taken all the tests ")
                        Exit Sub

                    End If
                End If

                ' Explanation, pupunta ka lang ng A kapag result mo is NULL
                '            , pupunta ka lang ng B kapag 1 result mo is Failed
                '            , pupunta ka lang ng C kapag 2 result mo is Failed

            Else
                ' NO SUCH EXAMINEE
                MessageBox.Show("Login unsuccessful")
                Exit Sub
            End If
        End If
    End Sub

    ' Proceed to Examination
    Private Sub DoExamination()
        Examinee.lblExamineeDateID.Text = txtExamineeDateID.Text

        ' PASSING VALUES TO EXAMINEE FORM
        sql.AddParam("@examineeDateID", txtExamineeDateID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee
                              INNER JOIN tbl_level
                                      ON tbl_examinee.levelID = tbl_level.levelID
                              INNER JOIN tbl_position
                                      ON tbl_examinee.positionID = tbl_position.positionID
                                   WHERE tbl_examinee.examineeDateID = @examineeDateID")


        ' TO GET TEST_TYPES FOR SPECIFIC LEVEL 
        ' STORAGE FOR LEVEL ID
        Dim _levelID As String
        Dim _position As String

        ' Passing Examinee Credentials to Examinee form
        For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
            Examinee.lblExamineeID.Text = r("examineeID")
            Examinee.lblExamineeDateID.Text = r("examineeDateID")
            Examinee.lblFirstName.Text = r("firstName")
            Examinee.lblLastName.Text = r("lastName")
            Examinee.lblLevelDescription.Text = r("levelDescription")
            Examinee.lblPositionDescription.Text = r("positionDescription")

            _levelID = r("levelID")
            _position = r("positionDescription")

        Next



        ' Get test types and pass it to Examinee form
        sql.AddParam("@levelID", _levelID)
        sql.ExecuteQuery("SELECT * FROM tbl_kind
                                     INNER JOIN tbl_test_type
                                             ON tbl_kind.testTypeID = tbl_test_type.testTypeID
                                           WHERE tbl_kind.levelID = @levelID")


        Examinee.lblTest1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("testTypeDescription")
        Examinee.lblTime1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("timer")
        Examinee.lblTestID1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("testTypeID")

        Examinee.lblTest2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("testTypeDescription")
        Examinee.lblTime2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("timer")
        Examinee.lblTestID2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("testTypeID")

        Examinee.lblTest3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("testTypeDescription")
        Examinee.lblTime3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("timer")
        Examinee.lblTestID3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("testTypeID")


        ' IF CLERICAL THEN SEND Test type 4 and 5 GOOD
        If _levelID = 3 Then

            Examinee.lblTest4.Text = sql.sqlDataSet.Tables(0).Rows(3).Item("testTypeDescription")
            Examinee.lblTime4.Text = sql.sqlDataSet.Tables(0).Rows(3).Item("timer")
            Examinee.lblTestID4.Text = sql.sqlDataSet.Tables(0).Rows(3).Item("testTypeID")

            Examinee.lblTest5.Text = sql.sqlDataSet.Tables(0).Rows(4).Item("testTypeDescription")
            Examinee.lblTime5.Text = sql.sqlDataSet.Tables(0).Rows(4).Item("timer")
            Examinee.lblTestID5.Text = sql.sqlDataSet.Tables(0).Rows(4).Item("testTypeID")

            Examinee.Size = New Size(640, 400)

        End If


        Examinee.lblLevelID.Text = _levelID



        Examinee.Show()
        Me.Close()
    End Sub

    Private Sub txtExamineeDateID_Click(sender As Object, e As EventArgs) Handles txtExamineeDateID.TextChanged
        If txtExamineeDateID.Text = "admin" Then
            txtLastName.PasswordChar = "*"
        Else
            txtLastName.PasswordChar = ""
        End If
    End Sub

    ' Tab-indexing for MaterialSkin Single Line Text Field
    Private Sub txtExamineeDateID_KeyPressed(sender As Object, e As PreviewKeyDownEventArgs) Handles txtExamineeDateID.PreviewKeyDown
        ' If Tab-key pressed
        If Convert.ToInt32(e.KeyCode) = 9 Then
            txtLastName.Select()
            txtLastName.Select()
        End If

        ' If Enter-key pressed
        If Convert.ToInt32(e.KeyCode) = 13 Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtLastName_Click(sender As Object, e As PreviewKeyDownEventArgs) Handles txtLastName.PreviewKeyDown
        ' If Enter-key pressed


        If Convert.ToInt32(e.KeyCode) = 13 Then
            btnLogin_Click(sender, e)
        Else
            Exit Sub
        End If
    End Sub


End Class
