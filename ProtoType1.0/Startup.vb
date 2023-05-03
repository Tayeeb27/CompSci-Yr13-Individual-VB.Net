Public Class Startup
    'Declaration for the Slideshow
    ReadOnly images(6) As Bitmap
    Dim pos As Integer = 0
    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setting the images to slideshow
        images(0) = My.Resources.IMG1
        images(1) = My.Resources.IMG2
        images(2) = My.Resources.IMG3
        images(3) = My.Resources.IMG4
        images(4) = My.Resources.IMG5
        images(5) = My.Resources.IMG0
        pbNewImage.Image = images(pos)
        DGVMPD.DataSource = SQLCommands.SQLFillTable("SELECT Item, Items.ItemCategory ,COUNT(item) as value_occurence
   FROM ItemsOrdered 
   JOIN Items
   ON ItemsOrdered.Item = Items.ItemDescription
   WHERE ItemCategory = 'Main'
   GROUP BY ItemsOrdered.Item, Items.ItemCategory
   Order by COUNT(Item) DESC
")
        DGVDay.DataSource = SQLCommands.SQLFillTable("SELECT OrderDay, COUNT(OrderDay) as Value_Occurence FROM OrderTable GROUP BY OrderDay ORDER BY COUNT(OrderDay) ASC")



        LblOffer.Text = "15% Off" & DGVMPD.Rows(0).Cells(0).Value & vbNewLine & "20% Off on " & DGVDay.Rows(0).Cells(0).Value & vbNewLine & "10% Off at "
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        'To Login Page
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        'Loop which allows you to view the next image
        pos += 1

        If pos < images.Length - 1 Then

            pbNewImage.Image = images(pos)

        Else
            pos = images.Length - 2
        End If
    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        'Loop which allows you to view the previous image
        pos -= 1

        If pos >= 0 Then

            pbNewImage.Image = images(pos)

        Else
            pos = 0
        End If
    End Sub
End Class
