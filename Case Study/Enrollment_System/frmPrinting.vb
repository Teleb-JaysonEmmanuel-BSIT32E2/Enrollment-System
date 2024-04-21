Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class frmPrinting

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

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printableArea As Rectangle = e.MarginBounds
        Dim desiredWidth As Integer = 300  ' Adjust desired width
        Dim desiredHeight As Integer = 200 ' Adjust desired height

        ' Calculate scaling factors
        Dim scaleX As Single = desiredWidth / printableArea.Width
        Dim scaleY As Single = desiredHeight / printableArea.Height

        ' Apply scaling transformation 
        e.Graphics.ScaleTransform(scaleX, scaleY)

        ' Indicate that more pages are not required (optional)
        e.HasMorePages = False
    End Sub
End Class
