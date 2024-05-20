Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class frmPrinting

    Dim majunits As Integer
    Dim minunits As Integer
    Dim misc As Integer
    Dim lab As Integer
    Dim spec As Integer
    'NEED LAB

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnPrint.Visible = False
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.PrinterSettings = PageSetupDialog1.PrinterSettings
        If PrintForm1.PrinterSettings.IsValid Then
            PrintForm1.Print()
        End If
        frmEnrollment.Show()
        Me.Close()
    End Sub

    Private Sub frmPrinting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadEverything()
        Call loadFees()
        Call calculateAssessment()
    End Sub
    Private Sub loadEverything()
        sql = "SELECT * from qrySubjectList WHERE SectionName = '" & lblSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            x = New ListViewItem(dr("SectionName").ToString())
            x.SubItems.Add(dr("SubjCode").ToString())
            x.SubItems.Add(dr("Description").ToString())
            x.SubItems.Add(dr("Units").ToString())
            x.SubItems.Add(dr("FirstName").ToString() & " " & dr("MiddleName").ToString() & " " & dr("LastName").ToString())
            ListView1.Items.Add(x)
        Loop
    End Sub
    Private Sub loadFees()
        sql = "SELECT Major, Minor, Misc, Laboratory, Specialist FROM tblFees WHERE SY = '" & lblYear.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            majunits = Convert.ToInt32(dr(0).ToString)
            minunits = Convert.ToInt32(dr(1).ToString)
            misc = Convert.ToInt32(dr(2).ToString)
            lab = Convert.ToInt32(dr(3).ToString)
            spec = Convert.ToInt32(dr(4).ToString)
        End If

        Call loadMajorUnits()
        Call loadMinorUnits()
    End Sub
    Private Sub loadMajorUnits()
        sql = "SELECT SUM(Units) FROM qryClassSchedule WHERE SectionName = '" & lblSection.Text & "' AND SubjType = 'Major'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            majunits = Convert.ToInt32(dr(0).ToString) * majunits
        End If
    End Sub

    Private Sub loadMinorUnits()
        sql = "SELECT SUM(Units) FROM qryClassSchedule WHERE SectionName = '" & lblSection.Text & "' AND SubjType = 'Minor'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            majunits = Convert.ToInt32(dr(0).ToString) * minunits
        End If
    End Sub
    Private Sub calculateAssessment()
        lblTF.Text = majunits + minunits
        lblMisc.Text = misc
        lblLabFee.Text = lab

        lblAssessment.Text = majunits + minunits + misc 'ADD LAB AND SPECIALIST AND DISCOUNT MATHEMATICS
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printableArea As Rectangle = e.MarginBounds
        Dim desiredWidth As Integer = 300
        Dim desiredHeight As Integer = 200

        Dim scaleX As Single = desiredWidth / printableArea.Width
        Dim scaleY As Single = desiredHeight / printableArea.Height

        e.Graphics.ScaleTransform(scaleX, scaleY)

        e.HasMorePages = False
    End Sub
End Class
