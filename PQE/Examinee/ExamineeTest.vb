Imports MaterialSkin
Imports System.Text

Public Class ExamineeTest
    Public sql As New SQLControl
    Dim rs As New Resizer

    Dim questionCounter As Integer = 0
    Dim numberOfQuestion As Integer = 0
    Dim examineeAnswer As String
    Dim firstQuestion As Boolean
    Dim score As Integer = 0


    ' changed id
    Dim levelID As String
    Dim pastExamineeAnswer As String

    Private Sub ExamineeTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim _skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        _skinManager.AddFormToManage(Me)
        _skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        _skinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        ' Starts timer
        tmrTest.Start()

        ' GET SPECIFIED TEST QUESTIONS
        sql.AddParam("@kindID", lblKindID.Text)
        sql.AddParam("@setDescription", lblSetDescription.Text)
        sql.ExecuteQuery("SELECT questionID, choice1, choice2, choice3, choice4, correctAnswer FROM tbl_question 
                           WHERE kindID = @kindID AND setDescription = @setDescription")

        numberOfQuestion = sql.recordCount
        dgvQuestion.DataSource = sql.sqlDataSet.Tables(0)

        ' FLAGS FIRST QUESTION
        firstQuestion = True

        ' LOADS SPECIFIED TEST QUESTIONS
        If sql.recordCount > 0 Then
            lblQuestionID.Text = dgvQuestion.Rows(questionCounter).Cells("questionID").Value.ToString
            sql.AddParam("@questionID", lblQuestionID.Text)
            sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")
            rtfQuestion.Rtf = Encoding.ASCII.GetChars(sql.sqlDataSet.Tables(0).Rows(0).Item("question"))
            rbChoice1.Text = dgvQuestion.Rows(questionCounter).Cells("choice1").Value.ToString
            rbChoice2.Text = dgvQuestion.Rows(questionCounter).Cells("choice2").Value.ToString
            rbChoice3.Text = dgvQuestion.Rows(questionCounter).Cells("choice3").Value.ToString
            rbChoice4.Text = dgvQuestion.Rows(questionCounter).Cells("choice4").Value.ToString
            lblAnswer.Text = dgvQuestion.Rows(questionCounter).Cells("correctAnswer").Value.ToString

            lblNumOfQuestion.Text = numberOfQuestion
            lblQuestionCounter.Text = questionCounter

        Else
            MessageBox.Show("No questions yet.
                             Please inform the administrator.
                             The application will now close.")

            ' Close Examinee.vb and this form. Go back to Login.vb
            Examinee.Close()
            Login.Show()
            Me.Close()

        End If
        ' LOADS SPECIFIED TEST QUESTIONS

        rs.FindAllControls(Me)
    End Sub

    Private Sub ExamineeTest_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub btnQuestionNext_Click(sender As Object, e As EventArgs) Handles btnQuestionNext.Click

        ' IF NO ANSWER SELECTED
        If examineeAnswer = "" Then
            MessageBox.Show("No answer selected")
            Exit Sub
        End If

        ' Woohoooooooooooo
        InsertResponse(examineeAnswer) ' This automatically inserts response with ID
        questionCounter = questionCounter + 1 ' Increment counter
        lblQuestionCounter.Text = questionCounter ' Put incremented question counter

        ' Checks if test is finished
        If (numberOfQuestion = questionCounter) Then
            questionCounter = questionCounter - 1 ' Decrement one more so it doesn't cause error

            lblQuestionID.Text = dgvQuestion.Rows(questionCounter).Cells("questionID").Value.ToString
            sql.AddParam("@questionID", lblQuestionID.Text)
            sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")
            rtfQuestion.Rtf = Encoding.ASCII.GetChars(sql.sqlDataSet.Tables(0).Rows(0).Item("question"))
            rbChoice1.Text = dgvQuestion.Rows(questionCounter).Cells("choice1").Value.ToString
            rbChoice2.Text = dgvQuestion.Rows(questionCounter).Cells("choice2").Value.ToString
            rbChoice3.Text = dgvQuestion.Rows(questionCounter).Cells("choice3").Value.ToString
            rbChoice4.Text = dgvQuestion.Rows(questionCounter).Cells("choice4").Value.ToString
            lblAnswer.Text = dgvQuestion.Rows(questionCounter).Cells("correctAnswer").Value.ToString


            ' Stop timer so it doesn't confusion
            tmrTest.Stop()
            MessageBox.Show("Exam finished.")

            InsertScore()
            ' Goes back to examinee score
            TestTypeFinished()
            Exit Sub
        End If


        ' LOAD QUESTIONS
        lblQuestionID.Text = dgvQuestion.Rows(questionCounter).Cells("questionID").Value.ToString
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")
        rtfQuestion.Rtf = Encoding.ASCII.GetChars(sql.sqlDataSet.Tables(0).Rows(0).Item("question"))
        rbChoice1.Text = dgvQuestion.Rows(questionCounter).Cells("choice1").Value.ToString
        rbChoice2.Text = dgvQuestion.Rows(questionCounter).Cells("choice2").Value.ToString
        rbChoice3.Text = dgvQuestion.Rows(questionCounter).Cells("choice3").Value.ToString
        rbChoice4.Text = dgvQuestion.Rows(questionCounter).Cells("choice4").Value.ToString
        lblAnswer.Text = dgvQuestion.Rows(questionCounter).Cells("correctAnswer").Value.ToString
        UncheckRadioButton()
        examineeAnswer = ""

        ' Unchecks radio button

        ReloadRecordedAnswer()
        ' Put score
        lblScore.Text = score

    End Sub

    Private Sub btnQuestionPrevious_Click(sender As Object, e As EventArgs) Handles btnQuestionPrevious.Click
        ' Decrement
        questionCounter = questionCounter - 1

        If questionCounter < 0 Then
            ' Set it back to 0
            firstQuestion = True
            questionCounter = 0
            MessageBox.Show("Can't go back further")
            Exit Sub
        End If


        ' RELOAD OF QUESTION AND CHOICES
        lblQuestionID.Text = dgvQuestion.Rows(questionCounter).Cells("questionID").Value.ToString
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")

        rtfQuestion.Rtf = Encoding.ASCII.GetChars(sql.sqlDataSet.Tables(0).Rows(0).Item("question"))
        rbChoice1.Text = dgvQuestion.Rows(questionCounter).Cells("choice1").Value.ToString
        rbChoice2.Text = dgvQuestion.Rows(questionCounter).Cells("choice2").Value.ToString
        rbChoice3.Text = dgvQuestion.Rows(questionCounter).Cells("choice3").Value.ToString
        rbChoice4.Text = dgvQuestion.Rows(questionCounter).Cells("choice4").Value.ToString
        lblAnswer.Text = dgvQuestion.Rows(questionCounter).Cells("correctAnswer").Value.ToString
        UncheckRadioButton()
        examineeAnswer = ""

        ' RELOADING Examinee's Answer
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.AddParam("@examineeAnswer", examineeAnswer)
        sql.ExecuteQuery("SELECT * FROM tbl_response
                                  WHERE examineeID = @examineeID
                                    AND questionID = @questionID")


        For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
            If rbChoice1.Text = r("examineeAnswer") Then
                rbChoice1.Checked = True
            ElseIf rbChoice2.Text = r("examineeAnswer") Then
                rbChoice2.Checked = True
            ElseIf rbChoice3.Text = r("examineeAnswer") Then
                rbChoice3.Checked = True
            ElseIf rbChoice4.Text = r("examineeAnswer") Then
                rbChoice4.Checked = True
            End If
            pastExamineeAnswer = r("examineeAnswer")
        Next

        ' IF EXAMINEE WAS RIGHT DECREMENT SCORE
        If pastExamineeAnswer = lblAnswer.Text Then
            score -= 1
        End If


        lblScore.Text = score

    End Sub

    Private Sub rbChoice1_CheckedChanged(sender As Object, e As EventArgs) Handles rbChoice1.CheckedChanged
        examineeAnswer = rbChoice1.Text
    End Sub

    Private Sub rbChoice2_CheckedChanged(sender As Object, e As EventArgs) Handles rbChoice2.CheckedChanged
        examineeAnswer = rbChoice2.Text
    End Sub

    Private Sub rbChoice3_CheckedChanged(sender As Object, e As EventArgs) Handles rbChoice3.CheckedChanged
        examineeAnswer = rbChoice3.Text
    End Sub

    Private Sub rbChoice4_CheckedChanged(sender As Object, e As EventArgs) Handles rbChoice4.CheckedChanged
        examineeAnswer = rbChoice4.Text
    End Sub

    Private Sub UncheckRadioButton()
        rbChoice1.Checked = False
        rbChoice2.Checked = False
        rbChoice3.Checked = False
        rbChoice4.Checked = False
    End Sub

    Private Sub TestTypeFinished()

        ' Passing TestID to Examinee Form
        Examinee.lblLevelID.Text = lblLevelID.Text
        sql.AddParam("@levelID", lblLevelID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_kind
                             INNER JOIN tbl_test_type
                                     ON tbl_kind.testTypeID = tbl_test_type.testTypeID
                                  WHERE tbl_kind.levelID = @levelID")

        ' Passing Tests to Examinee Form
        Examinee.lblTest1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("testTypeDescription")
        Examinee.lblTime1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("timer")
        Examinee.lblTestID1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("testTypeID")

        Examinee.lblTest2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("testTypeDescription")
        Examinee.lblTime2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("timer")
        Examinee.lblTestID2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("testTypeID")

        Examinee.lblTest3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("testTypeDescription")
        Examinee.lblTime3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("timer")
        Examinee.lblTestID3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("testTypeID")


        ' Passing Examinee Credentials to Examinee form
        Examinee.lblExamineeDateID.Text = lblExamineeDateID.Text
        Examinee.lblExamineeID.Text = lblExamineeID.Text
        Examinee.lblFirstName.Text = lblFirstName.Text
        Examinee.lblLastName.Text = lblLastName.Text
        Examinee.lblLevelDescription.Text = lblLevelDescription.Text
        Examinee.lblPositionDescription.Text = lblPositionDescription.Text


        ' update FLAGS if all tests = DONE
        Examinee.lblTestsDone.Text = Examinee.lblTestsDone.Text + 1


        ' nilipat ni mem yung TestDoneChecker() sa Test.vb
        If (Examinee.lblLevelID.Text = "3" And Examinee.lblTestsDone.Text = "5") Or (Examinee.lblLevelID.Text <> 3 And Examinee.lblTestsDone.Text = "3") Then
            Examinee.InsertPassOrFail()
            Login.txtExamineeDateID.Text = ""
            Login.txtLastName.Text = ""
            Examinee.Close()
            Login.Show()
        Else
            Examinee.Show()
        End If

        Me.Close()
    End Sub

    ' Insertion of answer and knows if the answer is correct or not
    Private Sub InsertResponse(examineeAnswer As String)

        ' CHECK IF EXISTING EXAMINEE ANSWER .. IF YES UPDATE .. ELSE INSERT
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.AddParam("@examineeAnswer", examineeAnswer)
        sql.ExecuteQuery("SELECT * FROM tbl_response
                                  WHERE examineeID = @examineeID
                                    AND questionID = @questionID")

        ' PARAMS for REQUERYING
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.AddParam("@examineeAnswer", examineeAnswer)
        If sql.recordCount > 0 Then

            ' UPDATE CURRENT RESPONSE

            sql.ExecuteQuery("UPDATE tbl_response
                             SET examineeAnswer = @examineeAnswer
                           WHERE examineeID = @examineeID
                             AND questionID = @questionID")
        Else
            ' INSERT INTO response
            sql.ExecuteQuery("INSERT INTO tbl_response (examineeID, questionID, examineeAnswer) 
                                            VALUES (@examineeID, @questionID, @examineeAnswer)")

        End If


        ' -- I THINK? CHRISTIAN AM I RIGHT?
        ' -- PARA TO SA RELOAD NG QUESTION
        ' -- PARA TO SA PAGCHECK NG CORRECT ANSWER
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")


        Dim _correctAnswer As String = sql.sqlDataSet.Tables(0).Rows(0).Item("correctAnswer").ToString
        ' If answer is correct increment score
        If examineeAnswer = _correctAnswer Then
            score = score + 1
        End If

    End Sub

    Private Sub ReloadRecordedAnswer()
        ' RELOADING Examinee's Answer
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.AddParam("@examineeAnswer", examineeAnswer)
        sql.ExecuteQuery("SELECT * FROM tbl_response
                                  WHERE examineeID = @examineeID
                                    AND questionID = @questionID")

        For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
            If rbChoice1.Text = r("examineeAnswer") Then
                rbChoice1.Checked = True
            ElseIf rbChoice2.Text = r("examineeAnswer") Then
                rbChoice2.Checked = True
            ElseIf rbChoice3.Text = r("examineeAnswer") Then
                rbChoice3.Checked = True
            ElseIf rbChoice4.Text = r("examineeAnswer") Then
                rbChoice4.Checked = True
            End If
        Next
    End Sub

    ' Insert score
    Private Sub InsertScore()
        ' Checks if there is a record
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@kindID", lblKindID.Text)
        sql.AddParam("@setDescription", lblSetDescription.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee_score WHERE examineeID = @examineeID AND kindID = @kindID AND setDescription = @setDescription")

        If sql.recordCount > 0 Then

            sql.AddParam("@examineeID", lblExamineeID.Text)
            sql.AddParam("@kindID", lblKindID.Text)
            sql.AddParam("@examineeScore", score)
            sql.AddParam("@setDescription", lblSetDescription.Text)

            ' UPDATE CURRENT Examinee_Score
            sql.ExecuteQuery("UPDATE tbl_examinee_score
                             SET examineeScore = @examineeScore
                           WHERE examineeID = @examineeID
                             AND kindID = @kindID
                             AND setDescription = @setDescription")

        Else
            sql.AddParam("@examineeID", lblExamineeID.Text)
            sql.AddParam("@kindID", lblKindID.Text)
            sql.AddParam("@examineeScore", score)
            sql.AddParam("@setDescription", lblSetDescription.Text)
            ' INSERT INTO Examinee_Score
            sql.ExecuteQuery("INSERT INTO tbl_examinee_score (examineeID, kindID, examineeScore, setDescription) 
                                            VALUES (@examineeID, @kindID, @examineeScore, @setDescription)")

        End If


    End Sub

    ' Timer for test. NOTE: Setting are changed in property
    Private Sub timerTest_Tick(sender As Object, e As EventArgs) Handles tmrTest.Tick
        ' Decrements the lbl by 1 everytime the timer hits 1 second
        lblTimer.Text = lblTimer.Text - 1


        If lblTimer.Text = 0 Then
            ' Stops timer
            tmrTest.Stop()
            MessageBox.Show("Time is finished")

            ' Insert score if timer is done
            InsertScore()

            ' Knows that the exam is finished
            TestTypeFinished()

            ' Shows examinee and closes this form
            Me.Close()
            Exit Sub
        End If

    End Sub

End Class