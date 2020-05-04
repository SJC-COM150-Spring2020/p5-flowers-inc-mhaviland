<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.radRoses = New System.Windows.Forms.RadioButton()
        Me.radTulips = New System.Windows.Forms.RadioButton()
        Me.radDaisies = New System.Windows.Forms.RadioButton()
        Me.radDaffodils = New System.Windows.Forms.RadioButton()
        Me.radSunflowers = New System.Windows.Forms.RadioButton()
        Me.radLilies = New System.Windows.Forms.RadioButton()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.picDaffodils = New System.Windows.Forms.PictureBox()
        Me.picDaisies = New System.Windows.Forms.PictureBox()
        Me.picTulips = New System.Windows.Forms.PictureBox()
        Me.picRoses = New System.Windows.Forms.PictureBox()
        Me.picSunflowers = New System.Windows.Forms.PictureBox()
        Me.picLilies = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblGame = New System.Windows.Forms.Label()
        CType(Me.picDaffodils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDaisies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTulips, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSunflowers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLilies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(21, 117)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 37)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(17, 76)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(203, 24)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Type your name below!"
        '
        'radRoses
        '
        Me.radRoses.AutoSize = True
        Me.radRoses.Location = New System.Drawing.Point(612, 117)
        Me.radRoses.Name = "radRoses"
        Me.radRoses.Size = New System.Drawing.Size(55, 17)
        Me.radRoses.TabIndex = 2
        Me.radRoses.TabStop = True
        Me.radRoses.Text = "Roses"
        Me.radRoses.UseVisualStyleBackColor = True
        '
        'radTulips
        '
        Me.radTulips.AutoSize = True
        Me.radTulips.Location = New System.Drawing.Point(612, 186)
        Me.radTulips.Name = "radTulips"
        Me.radTulips.Size = New System.Drawing.Size(53, 17)
        Me.radTulips.TabIndex = 3
        Me.radTulips.TabStop = True
        Me.radTulips.Text = "Tulips"
        Me.radTulips.UseVisualStyleBackColor = True
        '
        'radDaisies
        '
        Me.radDaisies.AutoSize = True
        Me.radDaisies.Location = New System.Drawing.Point(612, 260)
        Me.radDaisies.Name = "radDaisies"
        Me.radDaisies.Size = New System.Drawing.Size(59, 17)
        Me.radDaisies.TabIndex = 4
        Me.radDaisies.TabStop = True
        Me.radDaisies.Text = "Daisies"
        Me.radDaisies.UseVisualStyleBackColor = True
        '
        'radDaffodils
        '
        Me.radDaffodils.AutoSize = True
        Me.radDaffodils.Location = New System.Drawing.Point(612, 325)
        Me.radDaffodils.Name = "radDaffodils"
        Me.radDaffodils.Size = New System.Drawing.Size(66, 17)
        Me.radDaffodils.TabIndex = 5
        Me.radDaffodils.TabStop = True
        Me.radDaffodils.Text = "Daffodils"
        Me.radDaffodils.UseVisualStyleBackColor = True
        '
        'radSunflowers
        '
        Me.radSunflowers.AutoSize = True
        Me.radSunflowers.Location = New System.Drawing.Point(612, 401)
        Me.radSunflowers.Name = "radSunflowers"
        Me.radSunflowers.Size = New System.Drawing.Size(77, 17)
        Me.radSunflowers.TabIndex = 6
        Me.radSunflowers.TabStop = True
        Me.radSunflowers.Text = "Sunflowers"
        Me.radSunflowers.UseVisualStyleBackColor = True
        '
        'radLilies
        '
        Me.radLilies.AutoSize = True
        Me.radLilies.Location = New System.Drawing.Point(612, 475)
        Me.radLilies.Name = "radLilies"
        Me.radLilies.Size = New System.Drawing.Size(48, 17)
        Me.radLilies.TabIndex = 7
        Me.radLilies.TabStop = True
        Me.radLilies.Text = "Lilies"
        Me.radLilies.UseVisualStyleBackColor = True
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.Location = New System.Drawing.Point(557, 37)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(296, 24)
        Me.lblChoose.TabIndex = 8
        Me.lblChoose.Text = "Select your favorite type of flower!"
        '
        'picDaffodils
        '
        Me.picDaffodils.Image = CType(resources.GetObject("picDaffodils.Image"), System.Drawing.Image)
        Me.picDaffodils.Location = New System.Drawing.Point(718, 299)
        Me.picDaffodils.Name = "picDaffodils"
        Me.picDaffodils.Size = New System.Drawing.Size(128, 58)
        Me.picDaffodils.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDaffodils.TabIndex = 9
        Me.picDaffodils.TabStop = False
        '
        'picDaisies
        '
        Me.picDaisies.Image = CType(resources.GetObject("picDaisies.Image"), System.Drawing.Image)
        Me.picDaisies.Location = New System.Drawing.Point(718, 232)
        Me.picDaisies.Name = "picDaisies"
        Me.picDaisies.Size = New System.Drawing.Size(135, 61)
        Me.picDaisies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDaisies.TabIndex = 10
        Me.picDaisies.TabStop = False
        '
        'picTulips
        '
        Me.picTulips.Image = CType(resources.GetObject("picTulips.Image"), System.Drawing.Image)
        Me.picTulips.Location = New System.Drawing.Point(718, 160)
        Me.picTulips.Name = "picTulips"
        Me.picTulips.Size = New System.Drawing.Size(135, 66)
        Me.picTulips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTulips.TabIndex = 11
        Me.picTulips.TabStop = False
        '
        'picRoses
        '
        Me.picRoses.Image = CType(resources.GetObject("picRoses.Image"), System.Drawing.Image)
        Me.picRoses.Location = New System.Drawing.Point(728, 76)
        Me.picRoses.Name = "picRoses"
        Me.picRoses.Size = New System.Drawing.Size(125, 78)
        Me.picRoses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRoses.TabIndex = 12
        Me.picRoses.TabStop = False
        '
        'picSunflowers
        '
        Me.picSunflowers.Image = CType(resources.GetObject("picSunflowers.Image"), System.Drawing.Image)
        Me.picSunflowers.Location = New System.Drawing.Point(728, 377)
        Me.picSunflowers.Name = "picSunflowers"
        Me.picSunflowers.Size = New System.Drawing.Size(100, 59)
        Me.picSunflowers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSunflowers.TabIndex = 13
        Me.picSunflowers.TabStop = False
        '
        'picLilies
        '
        Me.picLilies.Image = CType(resources.GetObject("picLilies.Image"), System.Drawing.Image)
        Me.picLilies.Location = New System.Drawing.Point(728, 458)
        Me.picLilies.Name = "picLilies"
        Me.picLilies.Size = New System.Drawing.Size(110, 67)
        Me.picLilies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLilies.TabIndex = 14
        Me.picLilies.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(31, 415)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 101)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack1
        '
        Me.btnBack1.BackgroundImage = CType(resources.GetObject("btnBack1.BackgroundImage"), System.Drawing.Image)
        Me.btnBack1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack1.Location = New System.Drawing.Point(195, 415)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(165, 101)
        Me.btnBack1.TabIndex = 16
        Me.btnBack1.Text = "Main Menu"
        Me.btnBack1.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(21, 186)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(437, 82)
        Me.lstResults.TabIndex = 17
        '
        'btnLoad
        '
        Me.btnLoad.BackgroundImage = CType(resources.GetObject("btnLoad.BackgroundImage"), System.Drawing.Image)
        Me.btnLoad.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(81, 274)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(163, 109)
        Me.btnLoad.TabIndex = 18
        Me.btnLoad.Text = "Load my results!"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.Location = New System.Drawing.Point(5, 9)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(546, 39)
        Me.lblGame.TabIndex = 19
        Me.lblGame.Text = "What does your favorite flower say about you?"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(883, 537)
        Me.Controls.Add(Me.lblGame)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnBack1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.picLilies)
        Me.Controls.Add(Me.picSunflowers)
        Me.Controls.Add(Me.picRoses)
        Me.Controls.Add(Me.picTulips)
        Me.Controls.Add(Me.picDaisies)
        Me.Controls.Add(Me.picDaffodils)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.radLilies)
        Me.Controls.Add(Me.radSunflowers)
        Me.Controls.Add(Me.radDaffodils)
        Me.Controls.Add(Me.radDaisies)
        Me.Controls.Add(Me.radTulips)
        Me.Controls.Add(Me.radRoses)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.picDaffodils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDaisies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTulips, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSunflowers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLilies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents radRoses As RadioButton
    Friend WithEvents radTulips As RadioButton
    Friend WithEvents radDaisies As RadioButton
    Friend WithEvents radDaffodils As RadioButton
    Friend WithEvents radSunflowers As RadioButton
    Friend WithEvents radLilies As RadioButton
    Friend WithEvents lblChoose As Label
    Friend WithEvents picDaffodils As PictureBox
    Friend WithEvents picDaisies As PictureBox
    Friend WithEvents picTulips As PictureBox
    Friend WithEvents picRoses As PictureBox
    Friend WithEvents picSunflowers As PictureBox
    Friend WithEvents picLilies As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack1 As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents lblGame As Label
End Class
