Public Class Form1
    'Raven Williams
    'French Numbers Form/Assignment P1
    'GUI Development 

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFrenchOne.Visible = False
        lblFrenchTwo.Visible = False
        lblFrenchThree.Visible = False
        lblFrenchFour.Visible = False
        lblFrenchFive.Visible = False


        'When the form opens, there will be no french numbers displayed
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        Close()
        'when the exit butotn is pressed the form will close 
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrenchOne.Visible = True
        lblFrenchTwo.Visible = False
        lblFrenchThree.Visible = False
        lblFrenchFour.Visible = False
        lblFrenchFive.Visible = False
        'When the button labeled 1 is clicked once, only the french number for 1 will appear and all other french numbers will not be visible 


    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrenchTwo.Visible = True
        lblFrenchOne.Visible = False
        lblFrenchThree.Visible = False
        lblFrenchFour.Visible = False
        lblFrenchFive.Visible = False


    End Sub

    Private Sub lblFrenchOne_Click(sender As Object, e As EventArgs) Handles lblFrenchOne.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrenchTwo.Visible = False
        lblFrenchOne.Visible = False
        lblFrenchThree.Visible = True
        lblFrenchFour.Visible = False
        lblFrenchFive.Visible = False
        ' when the button labeled 3 is clicked once, the french number for 3 will apperar and all other french number will not be visible 
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrenchTwo.Visible = False
        lblFrenchOne.Visible = False
        lblFrenchThree.Visible = False
        lblFrenchFour.Visible = True
        lblFrenchFive.Visible = False
        'when the button labled 4 is chicked once, the french number for 4 will appear and all other frucnh number will not be visible 
    End Sub

    Private Sub BtnFive_Click(sender As Object, e As EventArgs) Handles BtnFive.Click
        lblFrenchTwo.Visible = False
        lblFrenchOne.Visible = False
        lblFrenchThree.Visible = False
        lblFrenchFour.Visible = False
        lblFrenchFive.Visible = True
        'when the button labeled 5 is clcked once, the french numbe rfor 5 will apear and all other french numbers will not be visible 
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub lblFrenchFive_Click(sender As Object, e As EventArgs) Handles lblFrenchFive.Click

    End Sub
End Class
