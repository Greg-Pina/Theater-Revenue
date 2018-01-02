'***************************************
' Greg Pina
' .Net Programming 1 (101-401)
'Assignment #6 - Theater Revenue
'9/29/2017
'***************************************


Option Strict On

Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Sets our variables
        Const dblRECEIPTS As Double = 0.2
        Dim dblGrossAdult As Double
        Dim dblGrossChild As Double
        Dim dblAdultPrice As Double
        Dim dblChildPrice As Double
        Dim dblAdultSold As Double
        Dim dblChildSold As Double
        Dim dblGrossRevenue As Double
        Dim dblNetAdult As Double
        Dim dblNetChild As Double
        Dim dblNetRevenue As Double
        txtAdultSold.BackColor = Color.White
        txtAdultPrice.BackColor = Color.White
        txtChildPrice.BackColor = Color.White
        txtChildSold.BackColor = Color.White



        Try

            'Validates if Theater data is numeric
            If IsNumeric(txtAdultPrice.Text) Then
                dblAdultPrice = CDbl(txtAdultPrice.Text)
            Else
                MessageBox.Show("Please make sure to only use numbers")
                txtAdultPrice.Focus()
                txtAdultPrice.BackColor = Color.Yellow
                Exit Sub
            End If

            If IsNumeric(txtChildPrice.Text) Then
                dblChildPrice = CDbl(txtChildPrice.Text)
            Else
                MessageBox.Show("Please make sure to only use numbers")
                txtChildPrice.Focus()
                txtChildPrice.BackColor = Color.Yellow
                Exit Sub
            End If
            If IsNumeric(txtAdultSold.Text) Then
                dblAdultSold = CDbl(txtAdultSold.Text)
            Else
                MessageBox.Show("Please make sure to only use numbers")
                txtAdultSold.Focus()
                txtAdultSold.BackColor = Color.Yellow
                Exit Sub
            End If

            If IsNumeric(txtChildSold.Text) Then
                dblChildSold = CDbl(txtChildSold.Text)
            Else
                MessageBox.Show("Please make sure to only use numbers")
                txtChildSold.Focus()
                txtChildSold.BackColor = Color.Yellow
                Exit Sub
            End If


            'Fetches our Theater Input Data
            dblAdultPrice = CDbl(txtAdultPrice.Text)
            dblChildPrice = CDbl(txtChildPrice.Text)
            dblAdultSold = CDbl(txtAdultSold.Text)
            dblChildSold = CDbl(txtChildSold.Text)

            'Calculates Gross Revenue for Theater
            dblGrossAdult = dblAdultPrice * dblAdultSold
            lblGrossAdult.Text = dblGrossAdult.ToString("c")
            dblGrossChild = dblChildPrice * dblChildSold
            lblGrossChild.Text = dblGrossChild.ToString("c")
            dblGrossRevenue = dblGrossAdult + dblGrossChild
            lblGrossRevenue.Text = dblGrossRevenue.ToString("c")

            'Calculates Net Revenue for Theater
            dblNetAdult = dblGrossAdult * dblRECEIPTS
            lblNetAdult.Text = dblNetAdult.ToString("c")
            dblNetChild = dblGrossChild * dblRECEIPTS
            lblNetChild.Text = dblNetChild.ToString("c")
            dblNetRevenue = dblNetChild + dblNetAdult
            lblNetRevenue.Text = dblNetRevenue.ToString("c")


            ' Displays the calculated revenue.
            lblGrossAdult.Text = dblGrossAdult.ToString("c")
            lblGrossChild.Text = dblGrossChild.ToString("c")
            lblGrossRevenue.Text = dblGrossRevenue.ToString("c")
            lblNetAdult.Text = dblNetAdult.ToString("c")
            lblNetChild.Text = dblNetChild.ToString("c")
            lblNetRevenue.Text = dblNetRevenue.ToString("c")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler clears the numbers.
        txtAdultPrice.Clear()
        txtChildSold.Clear()
        txtChildPrice.Clear()
        txtAdultSold.Clear()
        lblGrossChild.Text = String.Empty
        lblGrossAdult.Text = String.Empty
        lblGrossRevenue.Text = String.Empty
        lblNetAdult.Text = String.Empty
        lblNetChild.Text = String.Empty
        lblNetRevenue.Text = String.Empty

        ' Reset the focus
        txtAdultPrice.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the Application
        Close()
    End Sub
End Class
