'David Harmon
'RCET0265
'Fall 2020
'Diner Menu Program
'




Public Class DinnerMenuForm



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Move
        If TextBox1.Text = "" Then
            TextBox1.Text = "Welcome. I guess..."
            DesciptionBox.Text = "Here is our menu. Click on one of the menu options at the bottom to see what we got. It probs isn't very good. "
        Else

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub soupButton_Click(sender As Object, e As EventArgs) Handles soupButton.Click
        TextBox1.Text = "Just Soup"
        DesciptionBox.Text = "We will see what we have in the fridge for left overs... We will throw whatever
we can find in some water. Maybe we will boil it. IDK. Or we can make you ramen if you want."
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        TextBox1.Text = "Lettuce and Such"
        DesciptionBox.Text = "We actually dont know what lettuce looks like. We did clip the grass yesterday 
and it is still kind of green."
    End Sub

    Private Sub fishButton_Click(sender As Object, e As EventArgs) Handles fishButton.Click
        TextBox1.Text = "Scales and Tales"
        DesciptionBox.Text = "I dont think it is Halibut but it certianly does smell like Butt."

    End Sub
End Class
