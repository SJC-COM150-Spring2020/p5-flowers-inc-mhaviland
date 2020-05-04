<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lblAccents = New System.Windows.Forms.Label()
        Me.lblContainer = New System.Windows.Forms.Label()
        Me.lblFlowers = New System.Windows.Forms.Label()
        Me.lblForm3 = New System.Windows.Forms.Label()
        Me.chkSpray = New System.Windows.Forms.CheckBox()
        Me.chkBreath = New System.Windows.Forms.CheckBox()
        Me.chkLeaf = New System.Windows.Forms.CheckBox()
        Me.radVase = New System.Windows.Forms.RadioButton()
        Me.radJar = New System.Windows.Forms.RadioButton()
        Me.radBasket = New System.Windows.Forms.RadioButton()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtDaisies = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoses = New System.Windows.Forms.TextBox()
        Me.lblRoses = New System.Windows.Forms.Label()
        Me.lblDaisies = New System.Windows.Forms.Label()
        Me.lblHydrangeas = New System.Windows.Forms.Label()
        Me.lblLilies = New System.Windows.Forms.Label()
        Me.txtHydrangeas = New System.Windows.Forms.TextBox()
        Me.txtLilies = New System.Windows.Forms.TextBox()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.picDecoration = New System.Windows.Forms.PictureBox()
        CType(Me.picDecoration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAccents
        '
        Me.lblAccents.AutoSize = True
        Me.lblAccents.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccents.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAccents.Location = New System.Drawing.Point(12, 79)
        Me.lblAccents.Name = "lblAccents"
        Me.lblAccents.Size = New System.Drawing.Size(236, 25)
        Me.lblAccents.TabIndex = 0
        Me.lblAccents.Text = "Choose your Accents!"
        '
        'lblContainer
        '
        Me.lblContainer.AutoSize = True
        Me.lblContainer.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainer.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblContainer.Location = New System.Drawing.Point(300, 79)
        Me.lblContainer.Name = "lblContainer"
        Me.lblContainer.Size = New System.Drawing.Size(258, 25)
        Me.lblContainer.TabIndex = 1
        Me.lblContainer.Text = "Choose your Container!"
        '
        'lblFlowers
        '
        Me.lblFlowers.AutoSize = True
        Me.lblFlowers.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblFlowers.Location = New System.Drawing.Point(588, 79)
        Me.lblFlowers.Name = "lblFlowers"
        Me.lblFlowers.Size = New System.Drawing.Size(210, 25)
        Me.lblFlowers.TabIndex = 2
        Me.lblFlowers.Text = "Pick your flowers!"
        '
        'lblForm3
        '
        Me.lblForm3.AutoSize = True
        Me.lblForm3.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm3.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblForm3.Location = New System.Drawing.Point(197, 0)
        Me.lblForm3.Name = "lblForm3"
        Me.lblForm3.Size = New System.Drawing.Size(503, 79)
        Me.lblForm3.TabIndex = 3
        Me.lblForm3.Text = "Build your bouquet!"
        '
        'chkSpray
        '
        Me.chkSpray.AutoSize = True
        Me.chkSpray.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpray.Location = New System.Drawing.Point(4, 113)
        Me.chkSpray.Name = "chkSpray"
        Me.chkSpray.Size = New System.Drawing.Size(274, 28)
        Me.chkSpray.TabIndex = 4
        Me.chkSpray.Text = "Mini Spray Roses ($2.65)"
        Me.chkSpray.UseVisualStyleBackColor = True
        '
        'chkBreath
        '
        Me.chkBreath.AutoSize = True
        Me.chkBreath.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBreath.Location = New System.Drawing.Point(4, 142)
        Me.chkBreath.Name = "chkBreath"
        Me.chkBreath.Size = New System.Drawing.Size(240, 28)
        Me.chkBreath.TabIndex = 5
        Me.chkBreath.Text = "Baby's Breath ($1.50)"
        Me.chkBreath.UseVisualStyleBackColor = True
        '
        'chkLeaf
        '
        Me.chkLeaf.AutoSize = True
        Me.chkLeaf.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLeaf.Location = New System.Drawing.Point(4, 171)
        Me.chkLeaf.Name = "chkLeaf"
        Me.chkLeaf.Size = New System.Drawing.Size(276, 28)
        Me.chkLeaf.TabIndex = 6
        Me.chkLeaf.Text = "Leather Leaf Fern ($1.25)"
        Me.chkLeaf.UseVisualStyleBackColor = True
        '
        'radVase
        '
        Me.radVase.AutoSize = True
        Me.radVase.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVase.Location = New System.Drawing.Point(348, 113)
        Me.radVase.Name = "radVase"
        Me.radVase.Size = New System.Drawing.Size(153, 28)
        Me.radVase.TabIndex = 7
        Me.radVase.TabStop = True
        Me.radVase.Text = "Vase ($6.00)"
        Me.radVase.UseVisualStyleBackColor = True
        '
        'radJar
        '
        Me.radJar.AutoSize = True
        Me.radJar.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radJar.Location = New System.Drawing.Point(348, 155)
        Me.radJar.Name = "radJar"
        Me.radJar.Size = New System.Drawing.Size(204, 28)
        Me.radJar.TabIndex = 8
        Me.radJar.TabStop = True
        Me.radJar.Text = "Mason Jar ($4.00)"
        Me.radJar.UseVisualStyleBackColor = True
        '
        'radBasket
        '
        Me.radBasket.AutoSize = True
        Me.radBasket.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBasket.Location = New System.Drawing.Point(348, 189)
        Me.radBasket.Name = "radBasket"
        Me.radBasket.Size = New System.Drawing.Size(171, 28)
        Me.radBasket.TabIndex = 9
        Me.radBasket.TabStop = True
        Me.radBasket.Text = "Basket ($8.00)"
        Me.radBasket.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(767, 119)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(176, 20)
        Me.lblQuantity.TabIndex = 16
        Me.lblQuantity.Text = "Amount of flowers"
        '
        'txtDaisies
        '
        Me.txtDaisies.Location = New System.Drawing.Point(787, 197)
        Me.txtDaisies.Name = "txtDaisies"
        Me.txtDaisies.Size = New System.Drawing.Size(103, 20)
        Me.txtDaisies.TabIndex = 17
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(642, 488)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.BackgroundImage = CType(resources.GetObject("btnCheckout.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckout.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(783, 408)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(176, 77)
        Me.btnCheckout.TabIndex = 19
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(815, 488)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(75, 23)
        Me.btnMain.TabIndex = 20
        Me.btnMain.Text = "Main Menu"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackgroundImage = CType(resources.GetObject("btnSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnSubmit.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(575, 409)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(172, 74)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(606, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Flower Type"
        '
        'txtRoses
        '
        Me.txtRoses.Location = New System.Drawing.Point(787, 149)
        Me.txtRoses.Name = "txtRoses"
        Me.txtRoses.Size = New System.Drawing.Size(103, 20)
        Me.txtRoses.TabIndex = 25
        '
        'lblRoses
        '
        Me.lblRoses.AutoSize = True
        Me.lblRoses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoses.Location = New System.Drawing.Point(592, 149)
        Me.lblRoses.Name = "lblRoses"
        Me.lblRoses.Size = New System.Drawing.Size(155, 20)
        Me.lblRoses.TabIndex = 26
        Me.lblRoses.Text = "Roses ($2.80/flower)"
        '
        'lblDaisies
        '
        Me.lblDaisies.AutoSize = True
        Me.lblDaisies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaisies.Location = New System.Drawing.Point(592, 197)
        Me.lblDaisies.Name = "lblDaisies"
        Me.lblDaisies.Size = New System.Drawing.Size(161, 20)
        Me.lblDaisies.TabIndex = 27
        Me.lblDaisies.Text = "Daisies ($2.00/flower)"
        '
        'lblHydrangeas
        '
        Me.lblHydrangeas.AutoSize = True
        Me.lblHydrangeas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHydrangeas.Location = New System.Drawing.Point(569, 243)
        Me.lblHydrangeas.Name = "lblHydrangeas"
        Me.lblHydrangeas.Size = New System.Drawing.Size(195, 20)
        Me.lblHydrangeas.TabIndex = 28
        Me.lblHydrangeas.Text = "Hydrangeas ($5.00/flower)"
        '
        'lblLilies
        '
        Me.lblLilies.AutoSize = True
        Me.lblLilies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLilies.Location = New System.Drawing.Point(593, 289)
        Me.lblLilies.Name = "lblLilies"
        Me.lblLilies.Size = New System.Drawing.Size(144, 20)
        Me.lblLilies.TabIndex = 29
        Me.lblLilies.Text = "Lilies ($3.00/flower)"
        '
        'txtHydrangeas
        '
        Me.txtHydrangeas.Location = New System.Drawing.Point(787, 243)
        Me.txtHydrangeas.Name = "txtHydrangeas"
        Me.txtHydrangeas.Size = New System.Drawing.Size(103, 20)
        Me.txtHydrangeas.TabIndex = 30
        '
        'txtLilies
        '
        Me.txtLilies.Location = New System.Drawing.Point(787, 291)
        Me.txtLilies.Name = "txtLilies"
        Me.txtLilies.Size = New System.Drawing.Size(103, 20)
        Me.txtLilies.TabIndex = 31
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirections.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDirections.Location = New System.Drawing.Point(647, 342)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(243, 63)
        Me.lblDirections.TabIndex = 32
        Me.lblDirections.Text = "Click ""Submit Order"" then " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "click ""Checkout""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " to go to the next page"
        '
        'picDecoration
        '
        Me.picDecoration.Image = CType(resources.GetObject("picDecoration.Image"), System.Drawing.Image)
        Me.picDecoration.Location = New System.Drawing.Point(133, 229)
        Me.picDecoration.Name = "picDecoration"
        Me.picDecoration.Size = New System.Drawing.Size(261, 295)
        Me.picDecoration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDecoration.TabIndex = 33
        Me.picDecoration.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(971, 536)
        Me.Controls.Add(Me.picDecoration)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.txtLilies)
        Me.Controls.Add(Me.txtHydrangeas)
        Me.Controls.Add(Me.lblLilies)
        Me.Controls.Add(Me.lblHydrangeas)
        Me.Controls.Add(Me.lblDaisies)
        Me.Controls.Add(Me.lblRoses)
        Me.Controls.Add(Me.txtRoses)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtDaisies)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.radBasket)
        Me.Controls.Add(Me.radJar)
        Me.Controls.Add(Me.radVase)
        Me.Controls.Add(Me.chkLeaf)
        Me.Controls.Add(Me.chkBreath)
        Me.Controls.Add(Me.chkSpray)
        Me.Controls.Add(Me.lblForm3)
        Me.Controls.Add(Me.lblFlowers)
        Me.Controls.Add(Me.lblContainer)
        Me.Controls.Add(Me.lblAccents)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.picDecoration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAccents As Label
    Friend WithEvents lblContainer As Label
    Friend WithEvents lblFlowers As Label
    Friend WithEvents lblForm3 As Label
    Friend WithEvents chkSpray As CheckBox
    Friend WithEvents chkBreath As CheckBox
    Friend WithEvents chkLeaf As CheckBox
    Friend WithEvents radVase As RadioButton
    Friend WithEvents radJar As RadioButton
    Friend WithEvents radBasket As RadioButton
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtDaisies As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnMain As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRoses As TextBox
    Friend WithEvents lblRoses As Label
    Friend WithEvents lblDaisies As Label
    Friend WithEvents lblHydrangeas As Label
    Friend WithEvents lblLilies As Label
    Friend WithEvents txtHydrangeas As TextBox
    Friend WithEvents txtLilies As TextBox
    Friend WithEvents lblDirections As Label
    Friend WithEvents picDecoration As PictureBox
End Class
