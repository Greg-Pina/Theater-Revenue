<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAdultSold = New System.Windows.Forms.TextBox()
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtChildSold = New System.Windows.Forms.TextBox()
        Me.txtChildPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblGrossRevenue = New System.Windows.Forms.Label()
        Me.lblGrossChild = New System.Windows.Forms.Label()
        Me.lblGrossAdult = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNetRevenue = New System.Windows.Forms.Label()
        Me.lblNetChild = New System.Windows.Forms.Label()
        Me.lblNetAdult = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdultSold)
        Me.GroupBox1.Controls.Add(Me.txtAdultPrice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Ticket Sales"
        '
        'txtAdultSold
        '
        Me.txtAdultSold.Location = New System.Drawing.Point(113, 84)
        Me.txtAdultSold.Name = "txtAdultSold"
        Me.txtAdultSold.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultSold.TabIndex = 3
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(113, 32)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultPrice.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tickets Sold"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price Per Ticket"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtChildSold)
        Me.GroupBox2.Controls.Add(Me.txtChildPrice)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(367, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 139)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Ticket Sales"
        '
        'txtChildSold
        '
        Me.txtChildSold.Location = New System.Drawing.Point(124, 83)
        Me.txtChildSold.Name = "txtChildSold"
        Me.txtChildSold.Size = New System.Drawing.Size(100, 20)
        Me.txtChildSold.TabIndex = 3
        '
        'txtChildPrice
        '
        Me.txtChildPrice.Location = New System.Drawing.Point(124, 31)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtChildPrice.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tickets Sold"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Price Per Ticket"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblGrossRevenue)
        Me.GroupBox3.Controls.Add(Me.lblGrossChild)
        Me.GroupBox3.Controls.Add(Me.lblGrossAdult)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 161)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Revenue"
        '
        'lblGrossRevenue
        '
        Me.lblGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossRevenue.Location = New System.Drawing.Point(113, 112)
        Me.lblGrossRevenue.Name = "lblGrossRevenue"
        Me.lblGrossRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblGrossRevenue.TabIndex = 6
        '
        'lblGrossChild
        '
        Me.lblGrossChild.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossChild.Location = New System.Drawing.Point(113, 65)
        Me.lblGrossChild.Name = "lblGrossChild"
        Me.lblGrossChild.Size = New System.Drawing.Size(100, 23)
        Me.lblGrossChild.TabIndex = 5
        '
        'lblGrossAdult
        '
        Me.lblGrossAdult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossAdult.Location = New System.Drawing.Point(113, 19)
        Me.lblGrossAdult.Name = "lblGrossAdult"
        Me.lblGrossAdult.Size = New System.Drawing.Size(100, 23)
        Me.lblGrossAdult.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 43)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Gross Revenue for Ticket Sales"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Child Ticket Sales"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adult Ticket Sales"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.lblNetRevenue)
        Me.GroupBox4.Controls.Add(Me.lblNetChild)
        Me.GroupBox4.Controls.Add(Me.lblNetAdult)
        Me.GroupBox4.Location = New System.Drawing.Point(367, 186)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(263, 161)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Revenue"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 43)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total Net Revenue for Ticket Sales"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(13, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Child Ticket Sales"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Adult Ticket Sales"
        '
        'lblNetRevenue
        '
        Me.lblNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetRevenue.Location = New System.Drawing.Point(124, 112)
        Me.lblNetRevenue.Name = "lblNetRevenue"
        Me.lblNetRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblNetRevenue.TabIndex = 5
        '
        'lblNetChild
        '
        Me.lblNetChild.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetChild.Location = New System.Drawing.Point(124, 65)
        Me.lblNetChild.Name = "lblNetChild"
        Me.lblNetChild.Size = New System.Drawing.Size(100, 23)
        Me.lblNetChild.TabIndex = 4
        '
        'lblNetAdult
        '
        Me.lblNetAdult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetAdult.Location = New System.Drawing.Point(124, 29)
        Me.lblNetAdult.Name = "lblNetAdult"
        Me.lblNetAdult.Size = New System.Drawing.Size(100, 23)
        Me.lblNetAdult.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 374)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(157, 33)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate Ticket Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(267, 374)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 33)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(491, 374)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 33)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 429)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtAdultSold As TextBox
    Friend WithEvents txtAdultPrice As TextBox
    Friend WithEvents txtChildSold As TextBox
    Friend WithEvents txtChildPrice As TextBox
    Friend WithEvents lblGrossRevenue As Label
    Friend WithEvents lblGrossChild As Label
    Friend WithEvents lblGrossAdult As Label
    Friend WithEvents lblNetRevenue As Label
    Friend WithEvents lblNetChild As Label
    Friend WithEvents lblNetAdult As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
