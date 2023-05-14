<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PizzaBuilderForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSizeSmall = New System.Windows.Forms.RadioButton()
        Me.rbSizeMedium = New System.Windows.Forms.RadioButton()
        Me.rbSizeLarge = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbBaseGlutenFree = New System.Windows.Forms.RadioButton()
        Me.rbBaseNormal = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbToppingTomato = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbFetta = New System.Windows.Forms.CheckBox()
        Me.cbMozzarella = New System.Windows.Forms.CheckBox()
        Me.cbHalloumi = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbMushrooms = New System.Windows.Forms.CheckBox()
        Me.cbPineapple = New System.Windows.Forms.CheckBox()
        Me.cbHam = New System.Windows.Forms.CheckBox()
        Me.cbBeefStrips = New System.Windows.Forms.CheckBox()
        Me.cbRibs = New System.Windows.Forms.CheckBox()
        Me.cbChickenStrips = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbTableNumber = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSoftDrinks = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.txtChips = New System.Windows.Forms.TextBox()
        Me.txtOrderDetails = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UIAssessment3.My.Resources.Resources.pizzathumb
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 133)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Build your own pizza"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(452, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Your order"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(769, 62)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 16)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rbSizeLarge)
        Me.GroupBox1.Controls.Add(Me.rbSizeMedium)
        Me.GroupBox1.Controls.Add(Me.rbSizeSmall)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 115)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose size"
        '
        'rbSizeSmall
        '
        Me.rbSizeSmall.AutoSize = True
        Me.rbSizeSmall.Location = New System.Drawing.Point(7, 31)
        Me.rbSizeSmall.Name = "rbSizeSmall"
        Me.rbSizeSmall.Size = New System.Drawing.Size(62, 20)
        Me.rbSizeSmall.TabIndex = 0
        Me.rbSizeSmall.TabStop = True
        Me.rbSizeSmall.Tag = "25"
        Me.rbSizeSmall.Text = "Small"
        Me.rbSizeSmall.UseVisualStyleBackColor = True
        '
        'rbSizeMedium
        '
        Me.rbSizeMedium.AutoSize = True
        Me.rbSizeMedium.Location = New System.Drawing.Point(7, 58)
        Me.rbSizeMedium.Name = "rbSizeMedium"
        Me.rbSizeMedium.Size = New System.Drawing.Size(76, 20)
        Me.rbSizeMedium.TabIndex = 1
        Me.rbSizeMedium.TabStop = True
        Me.rbSizeMedium.Tag = "40"
        Me.rbSizeMedium.Text = "Medium"
        Me.rbSizeMedium.UseVisualStyleBackColor = True
        '
        'rbSizeLarge
        '
        Me.rbSizeLarge.AutoSize = True
        Me.rbSizeLarge.Location = New System.Drawing.Point(6, 82)
        Me.rbSizeLarge.Name = "rbSizeLarge"
        Me.rbSizeLarge.Size = New System.Drawing.Size(63, 20)
        Me.rbSizeLarge.TabIndex = 2
        Me.rbSizeLarge.TabStop = True
        Me.rbSizeLarge.Tag = "50"
        Me.rbSizeLarge.Text = "Large"
        Me.rbSizeLarge.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "add R25"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "add R15"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "R25"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.rbBaseGlutenFree)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.rbBaseNormal)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 286)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 71)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pizza base"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(129, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "add R15"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(156, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "R25"
        '
        'rbBaseGlutenFree
        '
        Me.rbBaseGlutenFree.AutoSize = True
        Me.rbBaseGlutenFree.Location = New System.Drawing.Point(7, 41)
        Me.rbBaseGlutenFree.Name = "rbBaseGlutenFree"
        Me.rbBaseGlutenFree.Size = New System.Drawing.Size(97, 20)
        Me.rbBaseGlutenFree.TabIndex = 9
        Me.rbBaseGlutenFree.TabStop = True
        Me.rbBaseGlutenFree.Tag = "40"
        Me.rbBaseGlutenFree.Text = "Gluten Free"
        Me.rbBaseGlutenFree.UseVisualStyleBackColor = True
        '
        'rbBaseNormal
        '
        Me.rbBaseNormal.AutoSize = True
        Me.rbBaseNormal.Location = New System.Drawing.Point(7, 18)
        Me.rbBaseNormal.Name = "rbBaseNormal"
        Me.rbBaseNormal.Size = New System.Drawing.Size(72, 20)
        Me.rbBaseNormal.TabIndex = 8
        Me.rbBaseNormal.TabStop = True
        Me.rbBaseNormal.Tag = "25"
        Me.rbBaseNormal.Text = "Normal"
        Me.rbBaseNormal.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.rbToppingTomato)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 363)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 86)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Base topping"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(136, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "add R5"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 53)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(106, 20)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Tag = "15"
        Me.RadioButton1.Text = "Spicy tomato"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(156, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "R10"
        '
        'rbToppingTomato
        '
        Me.rbToppingTomato.AutoSize = True
        Me.rbToppingTomato.Location = New System.Drawing.Point(7, 27)
        Me.rbToppingTomato.Name = "rbToppingTomato"
        Me.rbToppingTomato.Size = New System.Drawing.Size(75, 20)
        Me.rbToppingTomato.TabIndex = 8
        Me.rbToppingTomato.TabStop = True
        Me.rbToppingTomato.Tag = "10"
        Me.rbToppingTomato.Text = "Tomato"
        Me.rbToppingTomato.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbHalloumi)
        Me.GroupBox4.Controls.Add(Me.cbMozzarella)
        Me.GroupBox4.Controls.Add(Me.cbFetta)
        Me.GroupBox4.Location = New System.Drawing.Point(239, 363)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cheeses"
        '
        'cbFetta
        '
        Me.cbFetta.AutoSize = True
        Me.cbFetta.Location = New System.Drawing.Point(7, 28)
        Me.cbFetta.Name = "cbFetta"
        Me.cbFetta.Size = New System.Drawing.Size(59, 20)
        Me.cbFetta.TabIndex = 0
        Me.cbFetta.Text = "Fetta"
        Me.cbFetta.UseVisualStyleBackColor = True
        '
        'cbMozzarella
        '
        Me.cbMozzarella.AutoSize = True
        Me.cbMozzarella.Location = New System.Drawing.Point(6, 54)
        Me.cbMozzarella.Name = "cbMozzarella"
        Me.cbMozzarella.Size = New System.Drawing.Size(94, 20)
        Me.cbMozzarella.TabIndex = 1
        Me.cbMozzarella.Text = "Mozzarella"
        Me.cbMozzarella.UseVisualStyleBackColor = True
        '
        'cbHalloumi
        '
        Me.cbHalloumi.AutoSize = True
        Me.cbHalloumi.Location = New System.Drawing.Point(6, 80)
        Me.cbHalloumi.Name = "cbHalloumi"
        Me.cbHalloumi.Size = New System.Drawing.Size(82, 20)
        Me.cbHalloumi.TabIndex = 2
        Me.cbHalloumi.Text = "Halloumi"
        Me.cbHalloumi.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.cbBeefStrips)
        Me.GroupBox5.Controls.Add(Me.cbRibs)
        Me.GroupBox5.Controls.Add(Me.cbChickenStrips)
        Me.GroupBox5.Controls.Add(Me.cbMushrooms)
        Me.GroupBox5.Controls.Add(Me.cbPineapple)
        Me.GroupBox5.Controls.Add(Me.cbHam)
        Me.GroupBox5.Location = New System.Drawing.Point(239, 165)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 192)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Toppings"
        '
        'cbMushrooms
        '
        Me.cbMushrooms.AutoSize = True
        Me.cbMushrooms.Location = New System.Drawing.Point(6, 80)
        Me.cbMushrooms.Name = "cbMushrooms"
        Me.cbMushrooms.Size = New System.Drawing.Size(99, 20)
        Me.cbMushrooms.TabIndex = 2
        Me.cbMushrooms.Text = "Mushrooms"
        Me.cbMushrooms.UseVisualStyleBackColor = True
        '
        'cbPineapple
        '
        Me.cbPineapple.AutoSize = True
        Me.cbPineapple.Location = New System.Drawing.Point(6, 54)
        Me.cbPineapple.Name = "cbPineapple"
        Me.cbPineapple.Size = New System.Drawing.Size(91, 20)
        Me.cbPineapple.TabIndex = 1
        Me.cbPineapple.Text = "Pineapple"
        Me.cbPineapple.UseVisualStyleBackColor = True
        '
        'cbHam
        '
        Me.cbHam.AutoSize = True
        Me.cbHam.Location = New System.Drawing.Point(7, 28)
        Me.cbHam.Name = "cbHam"
        Me.cbHam.Size = New System.Drawing.Size(58, 20)
        Me.cbHam.TabIndex = 0
        Me.cbHam.Text = "Ham"
        Me.cbHam.UseVisualStyleBackColor = True
        '
        'cbBeefStrips
        '
        Me.cbBeefStrips.AutoSize = True
        Me.cbBeefStrips.Location = New System.Drawing.Point(6, 158)
        Me.cbBeefStrips.Name = "cbBeefStrips"
        Me.cbBeefStrips.Size = New System.Drawing.Size(92, 20)
        Me.cbBeefStrips.TabIndex = 5
        Me.cbBeefStrips.Text = "Beef strips"
        Me.cbBeefStrips.UseVisualStyleBackColor = True
        '
        'cbRibs
        '
        Me.cbRibs.AutoSize = True
        Me.cbRibs.Location = New System.Drawing.Point(6, 132)
        Me.cbRibs.Name = "cbRibs"
        Me.cbRibs.Size = New System.Drawing.Size(57, 20)
        Me.cbRibs.TabIndex = 4
        Me.cbRibs.Text = "Ribs"
        Me.cbRibs.UseVisualStyleBackColor = True
        '
        'cbChickenStrips
        '
        Me.cbChickenStrips.AutoSize = True
        Me.cbChickenStrips.Location = New System.Drawing.Point(7, 106)
        Me.cbChickenStrips.Name = "cbChickenStrips"
        Me.cbChickenStrips.Size = New System.Drawing.Size(112, 20)
        Me.cbChickenStrips.TabIndex = 3
        Me.cbChickenStrips.Text = "Chicken strips"
        Me.cbChickenStrips.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 494)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(427, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Start over"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(443, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Table number"
        '
        'lbTableNumber
        '
        Me.lbTableNumber.FormattingEnabled = True
        Me.lbTableNumber.ItemHeight = 16
        Me.lbTableNumber.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "Outside", "Take-a-way"})
        Me.lbTableNumber.Location = New System.Drawing.Point(446, 175)
        Me.lbTableNumber.Name = "lbTableNumber"
        Me.lbTableNumber.Size = New System.Drawing.Size(120, 148)
        Me.lbTableNumber.TabIndex = 17
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(584, 147)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(152, 23)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(649, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Total cost"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(609, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 16)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Add chips (@R15)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(581, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 16)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Add soft drinks (@R20)"
        '
        'txtSoftDrinks
        '
        Me.txtSoftDrinks.Location = New System.Drawing.Point(742, 169)
        Me.txtSoftDrinks.MaxLength = 4
        Me.txtSoftDrinks.Name = "txtSoftDrinks"
        Me.txtSoftDrinks.Size = New System.Drawing.Size(63, 22)
        Me.txtSoftDrinks.TabIndex = 22
        Me.txtSoftDrinks.Tag = "20"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Enabled = False
        Me.txtTotalCost.Location = New System.Drawing.Point(742, 224)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(63, 22)
        Me.txtTotalCost.TabIndex = 23
        '
        'txtChips
        '
        Me.txtChips.Location = New System.Drawing.Point(742, 196)
        Me.txtChips.MaxLength = 4
        Me.txtChips.Name = "txtChips"
        Me.txtChips.Size = New System.Drawing.Size(63, 22)
        Me.txtChips.TabIndex = 24
        Me.txtChips.Tag = "15"
        '
        'txtOrderDetails
        '
        Me.txtOrderDetails.Enabled = False
        Me.txtOrderDetails.Location = New System.Drawing.Point(446, 383)
        Me.txtOrderDetails.Multiline = True
        Me.txtOrderDetails.Name = "txtOrderDetails"
        Me.txtOrderDetails.Size = New System.Drawing.Size(427, 134)
        Me.txtOrderDetails.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(136, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "add R15"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(136, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "add R25"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(136, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 16)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "add R10"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(136, 133)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 16)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "add R25"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(136, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 16)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "add R15"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(136, 159)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 16)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "add R25"
        '
        'PizzaBuilderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 544)
        Me.Controls.Add(Me.txtOrderDetails)
        Me.Controls.Add(Me.txtChips)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtSoftDrinks)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lbTableNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PizzaBuilderForm"
        Me.Text = "Pizza"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbSizeLarge As RadioButton
    Friend WithEvents rbSizeMedium As RadioButton
    Friend WithEvents rbSizeSmall As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbBaseGlutenFree As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents rbBaseNormal As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents rbToppingTomato As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbHalloumi As CheckBox
    Friend WithEvents cbMozzarella As CheckBox
    Friend WithEvents cbFetta As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbBeefStrips As CheckBox
    Friend WithEvents cbRibs As CheckBox
    Friend WithEvents cbChickenStrips As CheckBox
    Friend WithEvents cbMushrooms As CheckBox
    Friend WithEvents cbPineapple As CheckBox
    Friend WithEvents cbHam As CheckBox
    Friend WithEvents btnReset As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lbTableNumber As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSoftDrinks As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents txtChips As TextBox
    Friend WithEvents txtOrderDetails As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
End Class
