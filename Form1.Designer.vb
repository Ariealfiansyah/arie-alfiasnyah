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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbil1 = New System.Windows.Forms.TextBox()
        Me.txtbil2 = New System.Windows.Forms.TextBox()
        Me.txtoperator = New System.Windows.Forms.TextBox()
        Me.lblhasil = New System.Windows.Forms.Label()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bilangan 1 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bilangan 2 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Operator :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'txtbil1
        '
        Me.txtbil1.Location = New System.Drawing.Point(137, 38)
        Me.txtbil1.Name = "txtbil1"
        Me.txtbil1.Size = New System.Drawing.Size(151, 20)
        Me.txtbil1.TabIndex = 4
        '
        'txtbil2
        '
        Me.txtbil2.Location = New System.Drawing.Point(137, 67)
        Me.txtbil2.Name = "txtbil2"
        Me.txtbil2.Size = New System.Drawing.Size(151, 20)
        Me.txtbil2.TabIndex = 5
        '
        'txtoperator
        '
        Me.txtoperator.Location = New System.Drawing.Point(137, 96)
        Me.txtoperator.Name = "txtoperator"
        Me.txtoperator.Size = New System.Drawing.Size(151, 20)
        Me.txtoperator.TabIndex = 6
        '
        'lblhasil
        '
        Me.lblhasil.AutoSize = True
        Me.lblhasil.Location = New System.Drawing.Point(134, 130)
        Me.lblhasil.Name = "lblhasil"
        Me.lblhasil.Size = New System.Drawing.Size(160, 13)
        Me.lblhasil.TabIndex = 7
        Me.lblhasil.Text = "..................................................."
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(96, 166)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(75, 23)
        Me.btnhitung.TabIndex = 8
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(197, 166)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 9
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 435)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.lblhasil)
        Me.Controls.Add(Me.txtoperator)
        Me.Controls.Add(Me.txtbil2)
        Me.Controls.Add(Me.txtbil1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbil1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbil2 As System.Windows.Forms.TextBox
    Friend WithEvents txtoperator As System.Windows.Forms.TextBox
    Friend WithEvents lblhasil As System.Windows.Forms.Label
    Friend WithEvents btnhitung As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button

End Class
