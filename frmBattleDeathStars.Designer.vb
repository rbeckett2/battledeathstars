<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBattleDeathStars
    Inherits BattleDeathStarsBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBattleDeathStars))
        Me.gbxSetupMode = New System.Windows.Forms.GroupBox()
        Me.btnAddPlanet = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.cbPlayMode = New System.Windows.Forms.CheckBox()
        Me.lblYValue = New System.Windows.Forms.Label()
        Me.lblXValue = New System.Windows.Forms.Label()
        Me.nudSetupYCoordinate = New System.Windows.Forms.NumericUpDown()
        Me.nudSetupXCoordinate = New System.Windows.Forms.NumericUpDown()
        Me.lblManuallySetup = New System.Windows.Forms.Label()
        Me.btnRandomPlacements = New System.Windows.Forms.Button()
        Me.nudNumberOfPlantes = New System.Windows.Forms.NumericUpDown()
        Me.nudMaxShots = New System.Windows.Forms.NumericUpDown()
        Me.lblNumberOfPlanets = New System.Windows.Forms.Label()
        Me.lblMaxShots = New System.Windows.Forms.Label()
        Me.gbBattleMode = New System.Windows.Forms.GroupBox()
        Me.lblPlanetsDestroyed = New System.Windows.Forms.Label()
        Me.lblShotsFired = New System.Windows.Forms.Label()
        Me.lblPlanetsDestroyedDisplay = New System.Windows.Forms.Label()
        Me.lblShotsFiredDisplay = New System.Windows.Forms.Label()
        Me.btnShoot = New System.Windows.Forms.Button()
        Me.lblShootYCoordinateDisplay = New System.Windows.Forms.Label()
        Me.lblShootXCoordinateDisplay = New System.Windows.Forms.Label()
        Me.nudFiringYCoordinate = New System.Windows.Forms.NumericUpDown()
        Me.nudFiringXCoordinate = New System.Windows.Forms.NumericUpDown()
        Me.lblCoordinateArea = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.dgPlayArea = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.tmrCountdownPlanetCreated = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCountdownPlanetDestroyed = New System.Windows.Forms.Timer(Me.components)
        Me.gbxSetupMode.SuspendLayout()
        CType(Me.nudSetupYCoordinate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSetupXCoordinate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfPlantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxShots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBattleMode.SuspendLayout()
        CType(Me.nudFiringYCoordinate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFiringXCoordinate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPlayArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxSetupMode
        '
        Me.gbxSetupMode.BackColor = System.Drawing.Color.Transparent
        Me.gbxSetupMode.Controls.Add(Me.btnAddPlanet)
        Me.gbxSetupMode.Controls.Add(Me.btnPlay)
        Me.gbxSetupMode.Controls.Add(Me.cbPlayMode)
        Me.gbxSetupMode.Controls.Add(Me.lblYValue)
        Me.gbxSetupMode.Controls.Add(Me.lblXValue)
        Me.gbxSetupMode.Controls.Add(Me.nudSetupYCoordinate)
        Me.gbxSetupMode.Controls.Add(Me.nudSetupXCoordinate)
        Me.gbxSetupMode.Controls.Add(Me.lblManuallySetup)
        Me.gbxSetupMode.Controls.Add(Me.btnRandomPlacements)
        Me.gbxSetupMode.Controls.Add(Me.nudNumberOfPlantes)
        Me.gbxSetupMode.Controls.Add(Me.nudMaxShots)
        Me.gbxSetupMode.Controls.Add(Me.lblNumberOfPlanets)
        Me.gbxSetupMode.Controls.Add(Me.lblMaxShots)
        Me.gbxSetupMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSetupMode.ForeColor = System.Drawing.Color.White
        Me.gbxSetupMode.Location = New System.Drawing.Point(11, 50)
        Me.gbxSetupMode.Name = "gbxSetupMode"
        Me.gbxSetupMode.Size = New System.Drawing.Size(483, 139)
        Me.gbxSetupMode.TabIndex = 0
        Me.gbxSetupMode.TabStop = False
        Me.gbxSetupMode.Text = " Game Setup "
        '
        'btnAddPlanet
        '
        Me.btnAddPlanet.BackColor = System.Drawing.Color.Black
        Me.btnAddPlanet.ForeColor = System.Drawing.Color.White
        Me.btnAddPlanet.Location = New System.Drawing.Point(268, 104)
        Me.btnAddPlanet.Name = "btnAddPlanet"
        Me.btnAddPlanet.Size = New System.Drawing.Size(119, 29)
        Me.btnAddPlanet.TabIndex = 14
        Me.btnAddPlanet.Text = "&Add Planet"
        Me.btnAddPlanet.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPlay.Location = New System.Drawing.Point(393, 104)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(76, 29)
        Me.btnPlay.TabIndex = 13
        Me.btnPlay.Text = "&Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'cbPlayMode
        '
        Me.cbPlayMode.AutoSize = True
        Me.cbPlayMode.BackColor = System.Drawing.Color.Transparent
        Me.cbPlayMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlayMode.ForeColor = System.Drawing.Color.White
        Me.cbPlayMode.Location = New System.Drawing.Point(17, 95)
        Me.cbPlayMode.Name = "cbPlayMode"
        Me.cbPlayMode.Size = New System.Drawing.Size(93, 19)
        Me.cbPlayMode.TabIndex = 10
        Me.cbPlayMode.Text = "Test Mode"
        Me.cbPlayMode.UseVisualStyleBackColor = False
        '
        'lblYValue
        '
        Me.lblYValue.BackColor = System.Drawing.Color.Transparent
        Me.lblYValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYValue.ForeColor = System.Drawing.Color.Yellow
        Me.lblYValue.Location = New System.Drawing.Point(374, 68)
        Me.lblYValue.Name = "lblYValue"
        Me.lblYValue.Size = New System.Drawing.Size(24, 33)
        Me.lblYValue.TabIndex = 9
        Me.lblYValue.Text = "Y"
        '
        'lblXValue
        '
        Me.lblXValue.BackColor = System.Drawing.Color.Transparent
        Me.lblXValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXValue.ForeColor = System.Drawing.Color.Yellow
        Me.lblXValue.Location = New System.Drawing.Point(267, 67)
        Me.lblXValue.Name = "lblXValue"
        Me.lblXValue.Size = New System.Drawing.Size(26, 33)
        Me.lblXValue.TabIndex = 8
        Me.lblXValue.Text = "X"
        '
        'nudSetupYCoordinate
        '
        Me.nudSetupYCoordinate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSetupYCoordinate.Location = New System.Drawing.Point(404, 72)
        Me.nudSetupYCoordinate.Name = "nudSetupYCoordinate"
        Me.nudSetupYCoordinate.Size = New System.Drawing.Size(53, 26)
        Me.nudSetupYCoordinate.TabIndex = 7
        Me.nudSetupYCoordinate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudSetupYCoordinate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSetupXCoordinate
        '
        Me.nudSetupXCoordinate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSetupXCoordinate.Location = New System.Drawing.Point(302, 68)
        Me.nudSetupXCoordinate.Name = "nudSetupXCoordinate"
        Me.nudSetupXCoordinate.Size = New System.Drawing.Size(54, 26)
        Me.nudSetupXCoordinate.TabIndex = 6
        Me.nudSetupXCoordinate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudSetupXCoordinate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblManuallySetup
        '
        Me.lblManuallySetup.BackColor = System.Drawing.Color.Transparent
        Me.lblManuallySetup.Location = New System.Drawing.Point(299, 46)
        Me.lblManuallySetup.Name = "lblManuallySetup"
        Me.lblManuallySetup.Size = New System.Drawing.Size(153, 20)
        Me.lblManuallySetup.TabIndex = 5
        Me.lblManuallySetup.Text = "Manually Placement"
        '
        'btnRandomPlacements
        '
        Me.btnRandomPlacements.BackColor = System.Drawing.Color.Black
        Me.btnRandomPlacements.Location = New System.Drawing.Point(147, 21)
        Me.btnRandomPlacements.Name = "btnRandomPlacements"
        Me.btnRandomPlacements.Size = New System.Drawing.Size(146, 47)
        Me.btnRandomPlacements.TabIndex = 4
        Me.btnRandomPlacements.Text = "Choose Random Placements"
        Me.btnRandomPlacements.UseVisualStyleBackColor = False
        '
        'nudNumberOfPlantes
        '
        Me.nudNumberOfPlantes.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.nudNumberOfPlantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumberOfPlantes.ForeColor = System.Drawing.Color.White
        Me.nudNumberOfPlantes.Location = New System.Drawing.Point(77, 57)
        Me.nudNumberOfPlantes.Name = "nudNumberOfPlantes"
        Me.nudNumberOfPlantes.Size = New System.Drawing.Size(64, 35)
        Me.nudNumberOfPlantes.TabIndex = 3
        Me.nudNumberOfPlantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudNumberOfPlantes.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nudMaxShots
        '
        Me.nudMaxShots.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.nudMaxShots.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMaxShots.ForeColor = System.Drawing.Color.White
        Me.nudMaxShots.Location = New System.Drawing.Point(77, 16)
        Me.nudMaxShots.Name = "nudMaxShots"
        Me.nudMaxShots.Size = New System.Drawing.Size(64, 35)
        Me.nudMaxShots.TabIndex = 2
        Me.nudMaxShots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMaxShots.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblNumberOfPlanets
        '
        Me.lblNumberOfPlanets.BackColor = System.Drawing.Color.Transparent
        Me.lblNumberOfPlanets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfPlanets.ForeColor = System.Drawing.Color.White
        Me.lblNumberOfPlanets.Location = New System.Drawing.Point(5, 59)
        Me.lblNumberOfPlanets.Name = "lblNumberOfPlanets"
        Me.lblNumberOfPlanets.Size = New System.Drawing.Size(74, 33)
        Me.lblNumberOfPlanets.TabIndex = 1
        Me.lblNumberOfPlanets.Text = "# Plantes"
        '
        'lblMaxShots
        '
        Me.lblMaxShots.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxShots.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxShots.ForeColor = System.Drawing.Color.White
        Me.lblMaxShots.Location = New System.Drawing.Point(5, 16)
        Me.lblMaxShots.Name = "lblMaxShots"
        Me.lblMaxShots.Size = New System.Drawing.Size(74, 33)
        Me.lblMaxShots.TabIndex = 0
        Me.lblMaxShots.Text = "Max Shots Allowed"
        '
        'gbBattleMode
        '
        Me.gbBattleMode.BackColor = System.Drawing.Color.Transparent
        Me.gbBattleMode.Controls.Add(Me.lblPlanetsDestroyed)
        Me.gbBattleMode.Controls.Add(Me.lblShotsFired)
        Me.gbBattleMode.Controls.Add(Me.lblPlanetsDestroyedDisplay)
        Me.gbBattleMode.Controls.Add(Me.lblShotsFiredDisplay)
        Me.gbBattleMode.Controls.Add(Me.btnShoot)
        Me.gbBattleMode.Controls.Add(Me.lblShootYCoordinateDisplay)
        Me.gbBattleMode.Controls.Add(Me.lblShootXCoordinateDisplay)
        Me.gbBattleMode.Controls.Add(Me.nudFiringYCoordinate)
        Me.gbBattleMode.Controls.Add(Me.nudFiringXCoordinate)
        Me.gbBattleMode.Controls.Add(Me.lblCoordinateArea)
        Me.gbBattleMode.Enabled = False
        Me.gbBattleMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBattleMode.ForeColor = System.Drawing.Color.White
        Me.gbBattleMode.Location = New System.Drawing.Point(511, 223)
        Me.gbBattleMode.Name = "gbBattleMode"
        Me.gbBattleMode.Size = New System.Drawing.Size(576, 136)
        Me.gbBattleMode.TabIndex = 6
        Me.gbBattleMode.TabStop = False
        Me.gbBattleMode.Text = "Battle Mode"
        Me.gbBattleMode.Visible = False
        '
        'lblPlanetsDestroyed
        '
        Me.lblPlanetsDestroyed.AutoSize = True
        Me.lblPlanetsDestroyed.Location = New System.Drawing.Point(165, 55)
        Me.lblPlanetsDestroyed.Name = "lblPlanetsDestroyed"
        Me.lblPlanetsDestroyed.Size = New System.Drawing.Size(0, 16)
        Me.lblPlanetsDestroyed.TabIndex = 18
        '
        'lblShotsFired
        '
        Me.lblShotsFired.AutoSize = True
        Me.lblShotsFired.Location = New System.Drawing.Point(165, 22)
        Me.lblShotsFired.Name = "lblShotsFired"
        Me.lblShotsFired.Size = New System.Drawing.Size(0, 16)
        Me.lblShotsFired.TabIndex = 17
        '
        'lblPlanetsDestroyedDisplay
        '
        Me.lblPlanetsDestroyedDisplay.AutoSize = True
        Me.lblPlanetsDestroyedDisplay.Location = New System.Drawing.Point(18, 55)
        Me.lblPlanetsDestroyedDisplay.Name = "lblPlanetsDestroyedDisplay"
        Me.lblPlanetsDestroyedDisplay.Size = New System.Drawing.Size(140, 16)
        Me.lblPlanetsDestroyedDisplay.TabIndex = 16
        Me.lblPlanetsDestroyedDisplay.Text = "Planets Destroyed:"
        '
        'lblShotsFiredDisplay
        '
        Me.lblShotsFiredDisplay.AutoSize = True
        Me.lblShotsFiredDisplay.Location = New System.Drawing.Point(15, 20)
        Me.lblShotsFiredDisplay.Name = "lblShotsFiredDisplay"
        Me.lblShotsFiredDisplay.Size = New System.Drawing.Size(91, 16)
        Me.lblShotsFiredDisplay.TabIndex = 15
        Me.lblShotsFiredDisplay.Text = "Shots Fired:"
        '
        'btnShoot
        '
        Me.btnShoot.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnShoot.Location = New System.Drawing.Point(358, 88)
        Me.btnShoot.Name = "btnShoot"
        Me.btnShoot.Size = New System.Drawing.Size(76, 29)
        Me.btnShoot.TabIndex = 13
        Me.btnShoot.Text = "&Shoot"
        Me.btnShoot.UseVisualStyleBackColor = False
        '
        'lblShootYCoordinateDisplay
        '
        Me.lblShootYCoordinateDisplay.BackColor = System.Drawing.Color.Transparent
        Me.lblShootYCoordinateDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShootYCoordinateDisplay.ForeColor = System.Drawing.Color.Yellow
        Me.lblShootYCoordinateDisplay.Location = New System.Drawing.Point(393, 36)
        Me.lblShootYCoordinateDisplay.Name = "lblShootYCoordinateDisplay"
        Me.lblShootYCoordinateDisplay.Size = New System.Drawing.Size(24, 33)
        Me.lblShootYCoordinateDisplay.TabIndex = 9
        Me.lblShootYCoordinateDisplay.Text = "Y"
        '
        'lblShootXCoordinateDisplay
        '
        Me.lblShootXCoordinateDisplay.BackColor = System.Drawing.Color.Transparent
        Me.lblShootXCoordinateDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShootXCoordinateDisplay.ForeColor = System.Drawing.Color.Yellow
        Me.lblShootXCoordinateDisplay.Location = New System.Drawing.Point(310, 36)
        Me.lblShootXCoordinateDisplay.Name = "lblShootXCoordinateDisplay"
        Me.lblShootXCoordinateDisplay.Size = New System.Drawing.Size(26, 33)
        Me.lblShootXCoordinateDisplay.TabIndex = 8
        Me.lblShootXCoordinateDisplay.Text = "X"
        '
        'nudFiringYCoordinate
        '
        Me.nudFiringYCoordinate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudFiringYCoordinate.Location = New System.Drawing.Point(412, 37)
        Me.nudFiringYCoordinate.Name = "nudFiringYCoordinate"
        Me.nudFiringYCoordinate.Size = New System.Drawing.Size(53, 26)
        Me.nudFiringYCoordinate.TabIndex = 7
        Me.nudFiringYCoordinate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudFiringYCoordinate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudFiringXCoordinate
        '
        Me.nudFiringXCoordinate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudFiringXCoordinate.Location = New System.Drawing.Point(333, 37)
        Me.nudFiringXCoordinate.Name = "nudFiringXCoordinate"
        Me.nudFiringXCoordinate.Size = New System.Drawing.Size(54, 26)
        Me.nudFiringXCoordinate.TabIndex = 6
        Me.nudFiringXCoordinate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudFiringXCoordinate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCoordinateArea
        '
        Me.lblCoordinateArea.BackColor = System.Drawing.Color.Transparent
        Me.lblCoordinateArea.Location = New System.Drawing.Point(312, 16)
        Me.lblCoordinateArea.Name = "lblCoordinateArea"
        Me.lblCoordinateArea.Size = New System.Drawing.Size(153, 20)
        Me.lblCoordinateArea.TabIndex = 5
        Me.lblCoordinateArea.Text = "Manually Shoot"
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Yellow
        Me.lblHeader.Location = New System.Drawing.Point(28, 6)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(622, 41)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Battle Deathstar"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgPlayArea
        '
        Me.dgPlayArea.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgPlayArea.AllowUserToAddRows = False
        Me.dgPlayArea.AllowUserToDeleteRows = False
        Me.dgPlayArea.AllowUserToResizeColumns = False
        Me.dgPlayArea.AllowUserToResizeRows = False
        Me.dgPlayArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPlayArea.CausesValidation = False
        Me.dgPlayArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPlayArea.ColumnHeadersVisible = False
        Me.dgPlayArea.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dgPlayArea.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgPlayArea.EnableHeadersVisualStyles = False
        Me.dgPlayArea.Location = New System.Drawing.Point(11, 195)
        Me.dgPlayArea.Name = "dgPlayArea"
        Me.dgPlayArea.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPlayArea.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPlayArea.RowHeadersVisible = False
        Me.dgPlayArea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgPlayArea.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgPlayArea.ShowCellErrors = False
        Me.dgPlayArea.ShowEditingIcon = False
        Me.dgPlayArea.ShowRowErrors = False
        Me.dgPlayArea.Size = New System.Drawing.Size(466, 533)
        Me.dgPlayArea.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(500, 50)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(500, 96)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 33)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImage = Global.BattleDeathStars.My.Resources.Resources.help
        Me.btnHelp.Location = New System.Drawing.Point(511, 142)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(50, 47)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'tmrCountdownPlanetCreated
        '
        Me.tmrCountdownPlanetCreated.Interval = 500
        '
        'tmrCountdownPlanetDestroyed
        '
        Me.tmrCountdownPlanetDestroyed.Interval = 500
        '
        'frmBattleDeathStars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BattleDeathStars.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1033, 698)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgPlayArea)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.gbxSetupMode)
        Me.Controls.Add(Me.gbBattleMode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBattleDeathStars"
        Me.Text = "DeathStar Wars"
        Me.gbxSetupMode.ResumeLayout(False)
        Me.gbxSetupMode.PerformLayout()
        CType(Me.nudSetupYCoordinate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSetupXCoordinate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfPlantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxShots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBattleMode.ResumeLayout(False)
        Me.gbBattleMode.PerformLayout()
        CType(Me.nudFiringYCoordinate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFiringXCoordinate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPlayArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxSetupMode As GroupBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents dgPlayArea As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents lblMaxShots As Label
    Friend WithEvents lblNumberOfPlanets As Label
    Friend WithEvents nudMaxShots As NumericUpDown
    Friend WithEvents nudNumberOfPlantes As NumericUpDown
    Friend WithEvents lblManuallySetup As Label
    Friend WithEvents btnRandomPlacements As Button
    Friend WithEvents lblYValue As Label
    Friend WithEvents lblXValue As Label
    Friend WithEvents nudSetupYCoordinate As NumericUpDown
    Friend WithEvents nudSetupXCoordinate As NumericUpDown
    Friend WithEvents cbPlayMode As CheckBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnAddPlanet As Button
    Friend WithEvents tmrCountdownPlanetCreated As Timer
    Friend WithEvents tmrCountdownPlanetDestroyed As Timer
    Friend WithEvents gbBattleMode As GroupBox
    Friend WithEvents btnShoot As Button
    Friend WithEvents lblShootYCoordinateDisplay As Label
    Friend WithEvents lblShootXCoordinateDisplay As Label
    Friend WithEvents nudFiringYCoordinate As NumericUpDown
    Friend WithEvents nudFiringXCoordinate As NumericUpDown
    Friend WithEvents lblCoordinateArea As Label
    Friend WithEvents lblPlanetsDestroyed As Label
    Friend WithEvents lblShotsFired As Label
    Friend WithEvents lblPlanetsDestroyedDisplay As Label
    Friend WithEvents lblShotsFiredDisplay As Label
End Class
