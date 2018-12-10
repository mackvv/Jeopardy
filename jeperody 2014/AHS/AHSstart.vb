Public Class AHSstart





    Private Sub btnM1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM1.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "What is Violet's mother's name?"
        btnQ1.Text = "Susan"
        btnQ2.Text = "Vivien"
        btnQ3.Text = "Melisa"
        btnQ4.Text = "Pepper"

    End Sub

    Private Sub btnM2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM2.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "How many kids did Constance have?"
        btnQ1.Text = "1"
        btnQ2.Text = "2"
        btnQ3.Text = "3"
        btnQ4.Text = "4"

    End Sub

    Private Sub btnM3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM3.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "What is the maid's name?"
        btnQ1.Text = "Moria"
        btnQ2.Text = "Chad"
        btnQ3.Text = "Misty"
        btnQ4.Text = "John"
    End Sub

    Private Sub btnM4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM4.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "How many kids died during the Westfield High shooting?"
        btnQ1.Text = "10"
        btnQ2.Text = "5"
        btnQ3.Text = "15"
        btnQ4.Text = "20"

    End Sub

    Private Sub btnM5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM5.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Who murdered Hayden?"
        btnQ1.Text = "Ben"
        btnQ2.Text = "Moria"
        btnQ3.Text = "Vivien"
        btnQ4.Text = "Larry"
    End Sub


    Private Sub btnQ1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ1.Click
        If btnQ1.BackColor = Color.DarkGreen Then
            txtPoints.Text = txtPoints.Text + 0
        ElseIf btnQ2.BackColor = Color.DarkGreen Then

        ElseIf btnQ3.BackColor = Color.DarkGreen Then

        ElseIf btnQ4.BackColor = Color.DarkGreen Then
            txtPoints.Text = txtPoints.Text + 0

        ElseIf btnQ2.Text = "Vivien" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnM1.Visible = False

        ElseIf btnQ4.Text = "4" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnM2.Visible = False

        ElseIf btnQ1.Text = "Moria" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnM3.Visible = False


            txtPoints.Text = txtPoints.Text + 30

        ElseIf btnQ3.Text = "15" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnM4.Visible = False

        ElseIf btnQ4.Text = "Larry" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnM5.Visible = False

        ElseIf btnQ2.Text = "Adam Levine" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA1.Visible = False

        ElseIf btnQ3.Text = "Aliens" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnA2.Visible = False

        ElseIf btnQ2.Text = "2" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA3.Visible = False

        ElseIf btnQ4.Text = "Lana Bananas" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnA4.Visible = False

        ElseIf btnQ1.Text = "An Axe" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA5.Visible = False

            txtPoints.Text = txtPoints.Text + 50

        ElseIf btnQ2.Text = "Witches" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC1.Visible = False

        ElseIf btnQ1.Text = "A Movie Star" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC2.Visible = False

            txtPoints.Text = txtPoints.Text + 20

        ElseIf btnQ3.Text = "Madison" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnC3.Visible = False

        ElseIf btnQ2.Text = "Stevie Nicks" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC4.Visible = False

        ElseIf btnQ2.Text = "A cigarette" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC5.Visible = False

        ElseIf btnQ4.Text = "October 8th" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnF1.Visible = False

        ElseIf btnQ2.Text = "2-Headed Women" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF2.Visible = False

        ElseIf btnQ1.Text = "Jupiter,FL" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF3.Visible = False

            txtPoints.Text = txtPoints.Text + 30

        ElseIf btnQ1.Text = "Fortuneteller" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF4.Visible = False

            txtPoints.Text = txtPoints.Text + 40

        ElseIf btnQ2.Text = "Jessica Lange's" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF5.Visible = False

        ElseIf btnQ1.Text = "All of them" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB1.Visible = False

            txtPoints.Text = txtPoints.Text + 10

        ElseIf btnQ3.Text = "Glee" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnB2.Visible = False

        ElseIf btnQ1.Text = "MH and Coven" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB3.Visible = False

            txtPoints.Text = txtPoints.Text + 30

        ElseIf btnQ2.Text = "Emma Roberts and Evan Petters" Then

            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB4.Visible = False

        ElseIf btnQ1.Text = "Willow(typeface)" Then

            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB5.Visible = False

            txtPoints.Text = txtPoints.Text + 50



        End If
    End Sub

    Private Sub btnQ2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ2.Click
        If btnQ1.BackColor = Color.DarkGreen Then

        ElseIf btnQ2.BackColor = Color.DarkGreen Then

        ElseIf btnQ3.BackColor = Color.DarkGreen Then

        ElseIf btnQ4.BackColor = Color.DarkGreen Then

        ElseIf btnQ2.Text = "Vivien" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnM1.Visible = False

            txtPoints.Text = txtPoints.Text + 10

        ElseIf btnQ4.Text = "4" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnM2.Visible = False

        ElseIf btnQ1.Text = "Moria" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnM3.Visible = False

        ElseIf btnQ3.Text = "15" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnM4.Visible = False

        ElseIf btnQ4.Text = "Larry" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnM5.Visible = False

        ElseIf btnQ2.Text = "Adam Levine" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA1.Visible = False

            txtPoints.Text = txtPoints.Text + 10

        ElseIf btnQ3.Text = "Aliens" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnA2.Visible = False

        ElseIf btnQ2.Text = "2" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA3.Visible = False

            txtPoints.Text = txtPoints.Text + 30

        ElseIf btnQ4.Text = "Lana Bananas" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnA4.Visible = False

        ElseIf btnQ1.Text = "An Axe" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA5.Visible = False

        ElseIf btnQ2.Text = "Witches" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC1.Visible = False

            txtPoints.Text = txtPoints.Text + 10

        ElseIf btnQ1.Text = "A Movie Star" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC2.Visible = False



        ElseIf btnQ3.Text = "Madison" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnC3.Visible = False

        ElseIf btnQ2.Text = "Stevie Nicks" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC4.Visible = False

            txtPoints.Text = txtPoints.Text + 40

        ElseIf btnQ2.Text = "A cigarette" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC5.Visible = False

            txtPoints.Text = txtPoints.Text + 50


        ElseIf btnQ4.Text = "October 8th" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnF1.Visible = False

        ElseIf btnQ2.Text = "2-Headed Women" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF2.Visible = False

            txtPoints.Text = txtPoints.Text + 20

        ElseIf btnQ1.Text = "Jupiter,FL" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF3.Visible = False


        ElseIf btnQ1.Text = "Fortuneteller" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF4.Visible = False


        ElseIf btnQ2.Text = "Jessica Lange's" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF5.Visible = False

            txtPoints.Text = txtPoints.Text + 50

        ElseIf btnQ1.Text = "All of them" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB1.Visible = False



        ElseIf btnQ3.Text = "Glee" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnB2.Visible = False

        ElseIf btnQ1.Text = "MH and Coven" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB3.Visible = False



        ElseIf btnQ2.Text = "Emma Roberts and Evan Petters" Then

            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB4.Visible = False


            txtPoints.Text = txtPoints.Text + 40


        ElseIf btnQ1.Text = "Willow(typeface)" Then

            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB5.Visible = False





        End If


    End Sub

    Private Sub btnQ3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ3.Click
        If btnQ1.BackColor = Color.DarkGreen Then

        ElseIf btnQ2.BackColor = Color.DarkGreen Then

        ElseIf btnQ3.BackColor = Color.DarkGreen Then

        ElseIf btnQ4.BackColor = Color.DarkGreen Then

        ElseIf btnQ2.Text = "Vivien" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnM1.Visible = False

        ElseIf btnQ4.Text = "4" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnM2.Visible = False

        ElseIf btnQ1.Text = "Moria" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnM3.Visible = False


        ElseIf btnQ3.Text = "15" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnM4.Visible = False

            txtPoints.Text = txtPoints.Text + 40

        ElseIf btnQ4.Text = "Larry" Then

            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnM5.Visible = False

        ElseIf btnQ2.Text = "Adam Levine" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA1.Visible = False

        ElseIf btnQ3.Text = "Aliens" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnA2.Visible = False

            txtPoints.Text = txtPoints.Text + 20

        ElseIf btnQ2.Text = "2" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA3.Visible = False

        ElseIf btnQ4.Text = "Lana Bananas" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnA4.Visible = False

        ElseIf btnQ1.Text = "An Axe" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA5.Visible = False

        ElseIf btnQ2.Text = "Witches" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC1.Visible = False

        ElseIf btnQ1.Text = "A Movie Star" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC2.Visible = False


        ElseIf btnQ3.Text = "Madison" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnC3.Visible = False

            txtPoints.Text = txtPoints.Text + 30

        ElseIf btnQ2.Text = "Stevie Nicks" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC4.Visible = False

        ElseIf btnQ2.Text = "A cigarette" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC5.Visible = False


        ElseIf btnQ4.Text = "October 8th" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnF1.Visible = False

        ElseIf btnQ2.Text = "2-Headed Women" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF2.Visible = False

        ElseIf btnQ1.Text = "Jupiter,FL" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF3.Visible = False

        ElseIf btnQ1.Text = "Fortuneteller" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF4.Visible = False


        ElseIf btnQ2.Text = "Jessica Lange's" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF5.Visible = False


        ElseIf btnQ1.Text = "All of them" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB1.Visible = False


        ElseIf btnQ3.Text = "Glee" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnB2.Visible = False

            txtPoints.Text = txtPoints.Text + 20

        ElseIf btnQ1.Text = "MH and Coven" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB3.Visible = False


        ElseIf btnQ2.Text = "Emma Roberts and Evan Petters" Then

            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB4.Visible = False

        ElseIf btnQ1.Text = "Willow(typeface)" Then

            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB5.Visible = False


        End If

    End Sub

    Private Sub btnQ4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ4.Click
        If btnQ1.BackColor = Color.DarkGreen Then

        ElseIf btnQ2.BackColor = Color.DarkGreen Then

        ElseIf btnQ3.BackColor = Color.DarkGreen Then

        ElseIf btnQ4.BackColor = Color.DarkGreen Then

        ElseIf btnQ2.Text = "Vivien" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnM1.Visible = False

        ElseIf btnQ4.Text = "4" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnM2.Visible = False

            txtPoints.Text = txtPoints.Text + 20

        ElseIf btnQ1.Text = "Moria" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnM3.Visible = False


        ElseIf btnQ3.Text = "15" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnM4.Visible = False

        ElseIf btnQ4.Text = "Larry" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnM5.Visible = False

            txtPoints.Text = txtPoints.Text + 50

        ElseIf btnQ2.Text = "Adam Levine" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA1.Visible = False

        ElseIf btnQ3.Text = "Aliens" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnA2.Visible = False

        ElseIf btnQ2.Text = "2" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA3.Visible = False

        ElseIf btnQ4.Text = "Lana Bananas" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnA4.Visible = False

            txtPoints.Text = txtPoints.Text + 40

        ElseIf btnQ1.Text = "An Axe" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnA5.Visible = False

        ElseIf btnQ2.Text = "Witches" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC1.Visible = False

        ElseIf btnQ1.Text = "A Movie Star" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC2.Visible = False


        ElseIf btnQ3.Text = "Madison" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnC3.Visible = False

        ElseIf btnQ2.Text = "Stevie Nicks" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC4.Visible = False

        ElseIf btnQ2.Text = "A cigarette" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnC5.Visible = False


        ElseIf btnQ4.Text = "October 8th" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkGreen
            btnF1.Visible = False

            txtPoints.Text = txtPoints.Text + 10

        ElseIf btnQ2.Text = "2-Headed Women" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF2.Visible = False

        ElseIf btnQ1.Text = "Jupiter,FL" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF3.Visible = False


        ElseIf btnQ1.Text = "Fortuneteller" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF4.Visible = False


        ElseIf btnQ2.Text = "Jessica Lange's" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnF5.Visible = False

        ElseIf btnQ1.Text = "All of them" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB1.Visible = False



        ElseIf btnQ3.Text = "Glee" Then
            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkGreen
            btnQ4.BackColor = Color.DarkRed
            btnB2.Visible = False

        ElseIf btnQ1.Text = "MH and Coven" Then
            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB3.Visible = False


        ElseIf btnQ2.Text = "Emma Roberts and Evan Petters" Then

            btnQ1.BackColor = Color.DarkRed
            btnQ2.BackColor = Color.DarkGreen
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB4.Visible = False

        ElseIf btnQ1.Text = "Willow(typeface)" Then

            btnQ1.BackColor = Color.DarkGreen
            btnQ2.BackColor = Color.DarkRed
            btnQ3.BackColor = Color.DarkRed
            btnQ4.BackColor = Color.DarkRed
            btnB5.Visible = False



        End If


    End Sub


    Private Sub btnA1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA1.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Which singer apeared in this season?"
        btnQ1.Text = "Miley Cyrus"
        btnQ2.Text = "Adam Levine"
        btnQ3.Text = "Matty Harris"
        btnQ4.Text = "Mackenzie Van Vliet"
    End Sub

    Private Sub btnA2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA2.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "What does Grace keep drawing?"
        btnQ1.Text = "Miley Cyrus"
        btnQ2.Text = "Circles"
        btnQ3.Text = "Aliens"
        btnQ4.Text = "Maps"
    End Sub

    Private Sub btnA3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA3.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "How many kids does Kit have?"
        btnQ1.Text = "0"
        btnQ2.Text = "2"
        btnQ3.Text = "4"
        btnQ4.Text = "6"
    End Sub

    Private Sub btnA4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA4.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "What does Sister Jude call Lana?"
        btnQ1.Text = "Lan"
        btnQ2.Text = "Lorie"
        btnQ3.Text = "Lazy"
        btnQ4.Text = "Lana Bananas"
    End Sub

    Private Sub btnA5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA5.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "What does Alma use to kill Grace?"
        btnQ1.Text = "An Axe"
        btnQ2.Text = "Kindness"
        btnQ3.Text = "Rat Poison"
        btnQ4.Text = "Gun"
    End Sub


    Private Sub btnC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC1.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "The season Coven is about..."
        btnQ1.Text = "Demons"
        btnQ2.Text = "Witches"
        btnQ3.Text = "Movie stars"
        btnQ4.Text = "Ghosts"
    End Sub

    Private Sub btnC2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC2.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "What was Madison before she found out she was a witch?"
        btnQ1.Text = "A Movie Star"
        btnQ2.Text = "A Gardener"
        btnQ3.Text = "A Singer"
        btnQ4.Text = "A Clerk"
    End Sub

    Private Sub btnC3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC3.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Who flipped the tour bus?"
        btnQ1.Text = "Zoe"
        btnQ2.Text = "Kyle"
        btnQ3.Text = "Madison"
        btnQ4.Text = "Fiona"
    End Sub

    Private Sub btnC4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC4.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Who was Misty's idol?"
        btnQ1.Text = "Mackenzie Van Vliet"
        btnQ2.Text = "Stevie Nicks"
        btnQ3.Text = "Bob Marley"
        btnQ4.Text = "Hanna Montanna"
    End Sub

    Private Sub btnC5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC5.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "What did Madison ask for when she was brought back to life?"
        btnQ1.Text = "Kyle"
        btnQ2.Text = "A cigarette"
        btnQ3.Text = "A drink"
        btnQ4.Text = "A shower"
    End Sub


    Private Sub btnF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF1.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "When is this season set to air?"
        btnQ1.Text = "October 3th"
        btnQ2.Text = "October 15th"
        btnQ3.Text = "October 31st"
        btnQ4.Text = "October 8th"
    End Sub

    Private Sub btnF2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF2.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "What 'freak' does Sarah Paulson play?"
        btnQ1.Text = "3-Armed Women"
        btnQ2.Text = "2-Headed Women"
        btnQ3.Text = "Killer Clown"
        btnQ4.Text = "Ring Master"
    End Sub

    Private Sub btnF3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF3.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Where is the Freak Show located?"
        btnQ1.Text = "Jupiter,FL"
        btnQ2.Text = "Ripton,UK"
        btnQ3.Text = "Kingston,ON"
        btnQ4.Text = "Gibsonton,FL"
    End Sub

    Private Sub btnF4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF4.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Emma Roberts plays a..."
        btnQ1.Text = "Fortuneteller"
        btnQ2.Text = "Bearded Women"
        btnQ3.Text = "2-Headed Women"
        btnQ4.Text = "Journalist"
    End Sub

    Private Sub btnF5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF5.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Who's last season is this?"
        btnQ1.Text = "Emma Robert's"
        btnQ2.Text = "Jessica Lange's"
        btnQ3.Text = "Evan Petter's"
        btnQ4.Text = "Kathy Bate's"
    End Sub


    Private Sub btnB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB1.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Which seasons has Evan Peter's been in?"
        btnQ1.Text = "All of them"
        btnQ2.Text = "MH and FS"
        btnQ3.Text = "MH and Coven"
        btnQ4.Text = "Asylum and MH"


    End Sub

    Private Sub btnB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB2.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Ryan Murphy, the creater, also co-created..."
        btnQ1.Text = "OINTB"
        btnQ2.Text = "Care Bears"
        btnQ3.Text = "Glee"
        btnQ4.Text = "Revenge"

    End Sub

    Private Sub btnB3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB3.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Taissa Farmiga and Evan Peters portray love interests in which season(s)?"
        btnQ1.Text = "MH and Coven"
        btnQ2.Text = "Asylum and FS"
        btnQ3.Text = "MH"
        btnQ4.Text = "Asylum"

    End Sub

    Private Sub btnB4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB4.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "Which love interests are enganged in real life"
        btnQ1.Text = "Taissa Farmiga and Evan Petters"
        btnQ2.Text = "Emma Roberts and Evan Petters"
        btnQ3.Text = "Kenzie Van Vliet and Evan Petters"
        btnQ4.Text = "Vivien Harmon and Evan Peters"

    End Sub

    Private Sub btnB5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB5.Click
        btnQ1.BackColor = Color.Black
        btnQ2.BackColor = Color.Black
        btnQ3.BackColor = Color.Black
        btnQ4.BackColor = Color.Black

        lblQ.Visible = True
        btnQ1.Visible = True
        btnQ2.Visible = True
        btnQ3.Visible = True
        btnQ4.Visible = True

        lblQ.Text = "What is the American Horror Story font?"
        btnQ1.Text = "Willow(typeface)"
        btnQ2.Text = "AHS"
        btnQ3.Text = "Spooky"
        btnQ4.Text = "New Times Roman"
    End Sub


    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click

        picAsylum.Visible = False
        picBonus.Visible = False
        picCoven.Visible = False
        picFreak.Visible = False
        PicMurder.Visible = False

        btnQ1.Visible = False
        btnQ2.Visible = False
        btnQ3.Visible = False
        btnQ4.Visible = False
        btnFinish.Visible = False
        lblQ.Visible = False
        btnA1.Visible = False
        btnA2.Visible = False
        btnA3.Visible = False
        btnA4.Visible = False
        btnA5.Visible = False
        btnB1.Visible = False
        btnB2.Visible = False
        btnB3.Visible = False
        btnB4.Visible = False
        btnB5.Visible = False
        btnC1.Visible = False
        btnC2.Visible = False
        btnC3.Visible = False
        btnC4.Visible = False
        btnC5.Visible = False
        btnM1.Visible = False
        btnM2.Visible = False
        btnM3.Visible = False
        btnM4.Visible = False
        btnM5.Visible = False
        btnF1.Visible = False
        btnF2.Visible = False
        btnF3.Visible = False
        btnF4.Visible = False
        btnF5.Visible = False


        lblPoints.Location = New Point(248, 151)
        txtPoints.Location = New Point(368, 148)

        btnEnd.Visible = True

        lbl1.Visible = True



        If txtPoints.Text < 150 Then
            lbl1.Text = "You know little."
            picLittle.Visible = True

        ElseIf txtPoints.Text >= 150 And txtPoints.Text < 300 Then
            lbl1.Text = "You need to study."
            picStudy.Visible = True

        ElseIf txtPoints.Text >= 300 And txtPoints.Text < 450 Then
            lbl1.Text = "You're ok."
            picOK.Visible = True

        ElseIf txtPoints.Text >= 450 And txtPoints.Text < 750 Then
            lbl1.Text = "Close."
            picClose.Visible = True


        ElseIf txtPoints.Text = "750" Then
            lbl1.Text = "Perfect."
            picPerf.Visible = True
        End If









    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class