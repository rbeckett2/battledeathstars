'
' Author(s): Shreeji Patel and Ryan Beckett
' Student ID's: 100635549 100642971
' Date: Feb 1, 2017
' Filename: BattleDeathStars.vb
' Description: The frmBattleDeathStars class is our main implementation class
' Purpose: The purpose of this program is to provide leisure for hard-working students

Option Strict On

Public Class frmBattleDeathStars

#Region "frmBattleDeathStars functions and methods"

    ''' <summary>
    ''' Procedure: RedrawPlanets
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: 
    ''' if outerspace is true, then that means draw stars only
    ''' 
    ''' Notes:
    ''' This procedure is similar to HidePlanets procedure, except it is capable 
    ''' showing planet images as well
    ''' 
    ''' Return Value:None
    ''' </summary>
    ''' <param name="outerspace">boolean</param>
    Private Sub RedrawPlanets(ByVal outerspace As Boolean)

        For i As Integer = 0 To _arrPlanets.Length - 1
            If 0 <> i Then
                If 0 = _arrPlanets(i).column And 0 = _arrPlanets(i).row Then

                    Dim bkgrndImage As PlanetDataGridViewImageCell = New PlanetDataGridViewImageCell()
                    If outerspace Then
                        bkgrndImage.curStatus = PlanetDataGridViewImageCell.initStatus.planetSpace
                        Me.tmrCountdownPlanetDestroyed.Enabled = False
                    Else
                        bkgrndImage.curStatus = PlanetDataGridViewImageCell.initStatus.planetRandom
                    End If

                    dgPlayArea.Rows().Item(_arrPlanets(i).row).Cells().Item(_arrPlanets(i).column) = bkgrndImage

                End If
            End If
        Next

    End Sub

    ''' <summary>
    ''' Procedure: TogglePlayMode
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions: 
    ''' calls RedrawPlanets procedure
    ''' 
    ''' Notes: This function helps in situations where the user has clicked the test button
    ''' in the midst of a round
    ''' 
    ''' Return Value:None
    ''' </summary>
    Private Sub TogglePlayMode(ByVal battleMode As Boolean)

        _bFirstShotAfterTest = True
        If playmode.battle = _mode Then
            If battleMode Then
                RedrawPlanets(False)
            End If
        End If

        If battleMode Then
            _mode = playmode.test
        Else
            _mode = playmode.place
        End If
    End Sub

    ''' <summary>
    ''' Procedure: AnyPlanetsLeft
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: if there is no planets left to place, shows an error message
    ''' and sets a flag to switch to battle mode
    ''' 
    ''' Return Value: None
    ''' </summary>
    Private Sub AnyPlanetsLeft()

        If 0 = _planetCounter Then
            MsgBox("You have already chosen maximum number of planets, switching to battle mode")
            _planetCounter = -1
            Me.tmrCountdownPlanetCreated.Enabled = False
        End If

    End Sub

    ''' <summary>
    ''' Procedure: ResetSpinControls
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: sets the default values of various spin controls
    ''' 
    ''' Return Value: None
    ''' </summary>
    Private Sub ResetSpinControls()

        Me.nudMaxShots.Value = 10
        Me.nudNumberOfPlantes.Value = 10
        Me.nudSetupXCoordinate.Value = 1
        Me.nudSetupYCoordinate.Value = 1
        Me.nudFiringXCoordinate.Value = 1
        Me.nudFiringYCoordinate.Value = 1

    End Sub

    ''' <summary>
    ''' Procedure: ResetLabelControls
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: sets the default values of label controls
    ''' 
    ''' Return Value: None
    ''' </summary>
    Private Sub ResetLabelControls()

        Me.lblShotsFired.Text = "0"
        Me.lblPlanetsDestroyed.Text = "0"

    End Sub

    ''' <summary>
    ''' Procedure: CrossCheckAndVerifyShotResults
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: fixes a problem where shots counted may be less than
    ''' planets destroyed when the user clicks test and random button at the same time
    ''' 
    ''' Return Value: None
    ''' </summary>
    Private Sub CrossCheckAndVerifyShotResults()

        Dim bTrue As Boolean
        IIf(0 = Me.lblShotsFired.Text.CompareTo("0"), bTrue = True, bTrue = False)
        If bTrue Then
            IIf(0 = Me.lblPlanetsDestroyed.Text.CompareTo("0"), bTrue = True, bTrue = False)
        End If
        If Not bTrue Then
            Me.lblShotsFired.Text = "1"
        End If

    End Sub

    ''' <summary>
    ''' Method: resizeArray
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: 
    ''' resizes the selected array
    ''' resets the selected counter
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="planet">boolean</param>
    Private Sub resizeArray(ByVal planet As Boolean)

        Dim amount As Integer
        If planet Then
            amount = GetMaxPlanets()
            Array.Resize(_arrPlanets, amount + 1)
            _planetCounter = amount
        Else
            amount = GetMaxShots()
            Array.Resize(_arrShots, amount + 1)
            _shotCounter = amount
        End If

    End Sub

    ''' <summary>
    ''' Procedure: Init
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions:
    ''' sets size of frmBattleDeathStars form
    ''' paint background of datagridview
    ''' 
    ''' Return Value: None
    ''' </summary>
    Private Sub Init()

        ' resize form
        Me.Width = 608
        Me.Height = 735
        Me.BackgroundImage = My.Resources.Background

        dgPlayArea.ColumnHeadersVisible = False
        dgPlayArea.ColumnCount = 16

        dgPlayArea.RowHeadersVisible = False
        dgPlayArea.RowCount = 16

        Dim hdrStyle As New DataGridViewCellStyle
        hdrStyle.ForeColor = Color.Black
        hdrStyle.Font = New Font("Tahoma", 9)
        hdrStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim Iterator As Integer = 0
        For Each Column In dgPlayArea.Columns

            Dim curColumn As DataGridViewColumn = dgPlayArea.Columns(Iterator)
            curColumn.Width = 29
            dgPlayArea.Rows().Item(0).Cells().Item(Iterator).Value = Iterator
            dgPlayArea.Rows().Item(0).Cells().Item(Iterator).Style = hdrStyle
            Iterator += 1

        Next

        Iterator = 0

        For Each Row In dgPlayArea.Rows

            Dim curRow As DataGridViewRow = dgPlayArea.Rows(Iterator)
            curRow.Height = 29
            dgPlayArea.Rows().Item(Iterator).Cells().Item(0).Value = Iterator
            dgPlayArea.Rows().Item(Iterator).Cells().Item(0).Style = hdrStyle
            Iterator += 1

        Next

        Call PaintDataGrid()
        Call ResetLabelControls()

        _planetCounter = GetMaxPlanets()
        _shotCounter = GetMaxShots()

        _mode = playmode.place

        Me.tmrCountdownPlanetCreated.Enabled = False
        Me.tmrCountdownPlanetDestroyed.Enabled = False

        _initGuard = True

    End Sub

    ''' <summary>
    ''' Procedure: reInit
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions:
    ''' set various controls to their default values
    ''' repaint background of datagridview
    ''' 
    ''' Return Value: None
    ''' </summary>
    Private Sub reInit()

        Call ResetArrays()

        Me.cbPlayMode.Checked = False
        _mode = playmode.place
        ' take guard down
        _initGuard = False
        Call ResetSpinControls()
        Call ResetLabelControls()
        ' put guard up
        _initGuard = True
        Call PaintDataGrid()
        Call ToggleGroupBoxDisplay(False)

        _bFirstShotAfterTest = False
        Me.tmrCountdownPlanetCreated.Enabled = False
        Me.tmrCountdownPlanetDestroyed.Enabled = False

    End Sub

    ''' <summary>
    ''' Procedure: TrackPlanets
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions:
    ''' if user has already shot there, returns nothing, otherwise...
    ''' determines whether we are in battle mode or not
    ''' places planet when not in battle mode
    ''' process shot when in battle mode
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="inPoint">_myPoint structure</param>
    Private Sub TrackPlanets(ByVal inPoint As _myPoint)

        Dim Iterator As Integer = 0
        If HaveTheyAlreadyShotThere(inPoint) Then
            MsgBox("already shot there")
        End If

        Call PlacePlanet(_planetCounter, inPoint)

        Call ProcessShot(_shotCounter, inPoint)

        Call CrossCheckAndVerifyCountdownCounters(True)

    End Sub

    ''' <summary>
    ''' Procedure: PlacePlanet
    ''' 
    ''' Pre-conditions: inoutPlanetCounter must not be Nothing
    ''' 
    ''' Post-conditions:
    ''' records location of planet placement into our global planet array
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="inoutPlanetCounter">Integer - Must not be Nothing</param>
    ''' <param name="inPoint">_myPoint structure</param>
    Private Sub PlacePlanet(ByRef inoutPlanetCounter As Integer, ByVal inPoint As _myPoint)

        If Not -1 = inoutPlanetCounter Then

            If playmode.battle <> _mode Then

                _arrPlanets(inoutPlanetCounter) = inPoint
                inoutPlanetCounter -= 1
                Call DrawPlanet(inPoint)

            End If

        Else
            ' switch groupboxes
            Call ToggleGroupBoxDisplay(True)
            inoutPlanetCounter = GetMaxPlanets()
        End If

    End Sub

    ''' <summary>
    ''' Procedure: DrawPlanet
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' paints a randomized planet icon into the play area
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="inPoint">_myPoint structure</param>
    Private Sub DrawPlanet(ByVal inPoint As _myPoint)

        ' paint the affected cell with a planet
        Dim bkgrndImage As PlanetDataGridViewImageCell = New PlanetDataGridViewImageCell()
        bkgrndImage.curStatus = PlanetDataGridViewImageCell.initStatus.planetRandom
        dgPlayArea.Rows().Item(inPoint.row).Cells().Item(inPoint.column) = bkgrndImage
        ' turn on a half-second timer to hide graphics after being shown
        ' the callback for this timer is tmrCountdownPlanetCreated_Tick
        If playmode.test <> _mode Then
            Me.tmrCountdownPlanetCreated.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Procedure: ProcessShot
    ''' 
    ''' Pre-conditions: inoutShotCounter must not be Nothing
    ''' 
    ''' Post-conditions:
    ''' determines whether the shot fired has hit a planet, and also keeps track of
    ''' how many shots were fired, and whether the user is done the round of shooting
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="inoutShotCounter">Integer - Must not be Nothing</param>
    ''' <param name="inPoint">_myPoint structure</param>
    Private Sub ProcessShot(ByRef inoutShotCounter As Integer, ByVal inPoint As _myPoint)

        If Not 0 >= inoutShotCounter Then

            If playmode.battle = _mode Then

                For i As Integer = 0 To _arrPlanets.Length - 1

                    ' if planet coordinates match shot, then set planet coordinates = 0 (means it has been destroyed)
                    If inPoint.column = _arrPlanets(i).column And inPoint.row = _arrPlanets(i).row Then
                        Dim outPoint As _myPoint
                        outPoint.column = 0
                        outPoint.row = 0
                        _arrPlanets(i) = outPoint
                        Call ProcessHit(inPoint)

                    End If

                Next

                ' reinitialize our test and randomization flag
                If _bFirstShotAfterTest Then
                    _bFirstShotAfterTest = False
                    Call CrossCheckAndVerifyShotResults()
                End If

                _arrShots(inoutShotCounter) = inPoint
                inoutShotCounter -= 1
                Call UpdateShotDisplay(inoutShotCounter)

                ' exit battle mode if there are no shots left
                If 0 >= inoutShotCounter Then
                    Call ReportResults(inoutShotCounter)
                    Call reInit()
                End If

            End If

        End If

    End Sub

    ''' <summary>
    ''' Procedure: ProcessHit
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' sets image of hit planet
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="inPoint">struct</param>
    Private Sub ProcessHit(ByVal inPoint As _myPoint)

        Dim bkgrndImage As PlanetDataGridViewImageCell = New PlanetDataGridViewImageCell()
        bkgrndImage.curStatus = PlanetDataGridViewImageCell.initStatus.planetDestroy
        dgPlayArea.Rows().Item(inPoint.row).Cells().Item(inPoint.column) = bkgrndImage
        UpdatePlanetsDestroyedDisplay()
        ' turn on a half-second timer to hide graphics after being shown
        ' the callback for this timer is tmrCountdownPlanetDestroyed_Tick
        Me.tmrCountdownPlanetDestroyed.Enabled = True

    End Sub

    ''' <summary>
    ''' Procedure: UpdateShotDisplay
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' udpates label controls with current status
    ''' 
    ''' Return Value: None
    ''' </summary>
    Private Sub UpdateShotDisplay(ByVal shotsLeft As Integer)

        Dim iShotsFired As Integer
        iShotsFired = GetMaxShots() - shotsLeft
        Me.lblShotsFired.Text = iShotsFired.ToString()

    End Sub

    ''' <summary>
    ''' Procedure: UpdatePlanetsDestroyedDisplay
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' udpates label controls with current status
    ''' 
    ''' Return Value: None
    ''' </summary>
    Private Sub UpdatePlanetsDestroyedDisplay()

        Dim iPlanetsDestroyed As Integer = 0
        Dim iCurrentlyDestroyed As Integer = 0
        iCurrentlyDestroyed = Convert.ToInt32(Me.lblPlanetsDestroyed.Text)
        iPlanetsDestroyed = iCurrentlyDestroyed + 1
        Me.lblPlanetsDestroyed.Text = iPlanetsDestroyed.ToString()

    End Sub

    ''' <summary>
    ''' Procedure: ReportResults
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' reports results of shooting to messagebox
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="shots">Integer</param>
    Private Sub ReportResults(ByRef shots As Integer)

        Dim iDestroyedCount As Integer = 0
        Dim strDestroyed As String = ""
        For i As Integer = 0 To _arrPlanets.Length - 1
            If 0 <> i Then
                If 0 = _arrPlanets(i).column Or 0 = _arrPlanets(i).row Then
                    iDestroyedCount += 1
                End If
            End If
        Next
        strDestroyed = "You have destroyed " & iDestroyedCount.ToString() & " planet(s)."
        MsgBox(strDestroyed)
        shots = GetMaxShots()

    End Sub

    ''' <summary>
    ''' Function: GetMaxPlanets
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: None
    ''' 
    ''' Return Value: Value of nudPlanetCounter
    ''' </summary>
    Private Function GetMaxPlanets() As Integer

        Dim i As Integer
        i = CType(Me.nudNumberOfPlantes.Value, Integer)
        If 0 >= i Then
            Return 1
        Else
            Return i
        End If

    End Function

    ''' <summary>
    ''' Function: GetMaxShots
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: None
    ''' 
    ''' Return Value: Value of nudShotCounter
    ''' </summary>
    Private Function GetMaxShots() As Integer

        Dim i As Integer
        i = CType(Me.nudMaxShots.Value, Integer)
        If 0 >= i Then
            Return 1
        Else
            Return i
        End If

    End Function

    ''' <summary>
    ''' Procedure: PaintDataGrid
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions:
    ''' For each item in datagrid; EXCEPT headers, reset it to stars only
    ''' 
    ''' Return Value:None
    ''' </summary>
    Private Sub PaintDataGrid()

        For rowIterator As Integer = 1 To dgPlayArea.Rows.Count - 1

            For columnIterator As Integer = 1 To dgPlayArea.Columns.Count - 1

                If playmode.battle <> _mode Then
                    Dim bkgrndImage As PlanetDataGridViewImageCell = New PlanetDataGridViewImageCell()
                    bkgrndImage.curStatus = PlanetDataGridViewImageCell.initStatus.planetSpace
                    dgPlayArea.Rows().Item(columnIterator).Cells().Item(rowIterator) = bkgrndImage
                End If

            Next

        Next

    End Sub

    ''' <summary>
    ''' Procedure: HidePlanets
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: 
    ''' For each PLANET in datagrid, reset it to space if it's been destroyed unless we're in test mode
    ''' 
    ''' Return Value:None
    ''' </summary>
    Private Sub HidePlanets()

        If playmode.test <> _mode Then
            For i As Integer = 0 To _arrPlanets.Length - 1

                If 0 <> _arrPlanets(i).column And 0 <> _arrPlanets(i).row Then
                    Dim bkgrndImage As PlanetDataGridViewImageCell = New PlanetDataGridViewImageCell()
                    bkgrndImage.curStatus = PlanetDataGridViewImageCell.initStatus.planetSpace
                    dgPlayArea.Rows().Item(_arrPlanets(i).row).Cells().Item(_arrPlanets(i).column) = bkgrndImage
                End If

            Next
        End If

    End Sub

#End Region

#Region "frmBattleDeathStars Event Handlers"

    ''' <summary>
    ''' Method: nudNumberOfPlantes_ValueChanged
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the nudNumberOfPlantes.ValueChanged event
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub nudNumberOfPlantes_ValueChanged(sender As Object, e As EventArgs) Handles nudNumberOfPlantes.ValueChanged

        If _initGuard Then
            Call resizeArray(True)
        End If

    End Sub

    ''' <summary>
    ''' Method: btnHelp_Click
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the btnHelp.Click event
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmDialogbox.ShowDialog()

    End Sub

    ''' <summary>
    ''' Method: dgPlayArea_DataError
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the dgPlayArea.DataError event
    ''' 
    ''' Notes: This method is only called in extraenous circumstances
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub dgPlayArea_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

        ' ignore all errors

    End Sub

    ''' <summary>
    ''' Method: tmrCountdownPlanetCreated_Tick
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the tmrCountdownPlanetCreated.Tick event
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub tmrCountdownPlanetCreated_Tick(sender As Object, e As EventArgs) Handles tmrCountdownPlanetCreated.Tick
        Call HidePlanets()
    End Sub

    ''' <summary>
    ''' Method: btnExit_Click
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the btnExit.Click event
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Method: btnRandomPlacements_Click
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the btnRandomPlacements.Click event
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub btnRandomPlacements_Click(sender As Object, e As EventArgs) Handles btnRandomPlacements.Click

        Dim randomNumber As Integer
        Dim iTemp As Integer = 0
        Dim iTemp2 As Integer = 0
        Dim randomPoints As Random

        randomPoints = New Random()

        For i As Integer = 0 To _planetCounter

            Dim randomPoint As _myPoint
            ' offset by 1 to account for table headers
            randomNumber = randomPoints.Next(15) + 1
            randomPoint.column = randomNumber
            ' offset by 1 to account for table headers
            randomNumber = randomPoints.Next(15) + 1
            randomPoint.row = randomNumber
            Call TrackPlanets(randomPoint)

        Next

        _mode = playmode.battle

    End Sub

    ''' <summary>
    ''' Method: cbPlayMode_CheckedChanged
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the cbPlayMode.CheckChanged event
    ''' 
    ''' Notes: Fired when the user checks the test mode checkbox
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub cbPlayMode_CheckedChanged(sender As Object, e As EventArgs) Handles cbPlayMode.CheckedChanged

        Call TogglePlayMode(Me.cbPlayMode.Checked)

    End Sub

    ''' <summary>
    ''' Method: tmrCountdownPlanetDestroyed_Tick
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the tmrCountdownPlanetDestroyed.Tick event
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub tmrCountdownPlanetDestroyed_Tick(sender As Object, e As EventArgs) Handles tmrCountdownPlanetDestroyed.Tick
        Call RedrawPlanets(True)
    End Sub

    ''' <summary>
    ''' Method: btnAddPlanet_Click
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the btnAddPlanet.Click event
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub btnAddPlanet_Click(sender As Object, e As EventArgs) Handles btnAddPlanet.Click

        Dim xCoordinate As Integer
        Dim yCoordinate As Integer
        xCoordinate = CType(nudSetupXCoordinate.Value, Integer)
        yCoordinate = CType(nudSetupYCoordinate.Value, Integer)
        If _arrPlanets.Length > GetMaxPlanets() Then
            Dim newPoint As _myPoint
            newPoint.column = xCoordinate
            newPoint.row = yCoordinate
            AnyPlanetsLeft()
            Call TrackPlanets(newPoint)
        End If

    End Sub

    ''' <summary>
    ''' Method: btnShoot_Click
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the btnShoot.Click event
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click

        Dim xCoordinate As Integer
        Dim yCoordinate As Integer
        xCoordinate = CType(nudFiringXCoordinate.Value, Integer)
        yCoordinate = CType(nudFiringYCoordinate.Value, Integer)
        Dim newPoint As _myPoint
        newPoint.column = xCoordinate
        newPoint.row = yCoordinate
        Call TrackPlanets(newPoint)

    End Sub

    ''' <summary>
    ''' Procedure: ToggleGroupBoxDisplay
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: displays the appropriate group box based 
    ''' whether or not the parameter is true
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="battleMode">boolean</param>
    Private Sub ToggleGroupBoxDisplay(ByVal battleMode As Boolean)

        If battleMode Then
            Me.gbxSetupMode.Enabled = False
            Me.gbxSetupMode.Visible = False
            Me.gbBattleMode.Enabled = True
            Me.gbBattleMode.Top = 50
            Me.gbBattleMode.Left = 11
            Me.gbBattleMode.Width = 483
            Me.gbBattleMode.Height = 139
            Me.gbBattleMode.Anchor = AnchorStyles.Top Or AnchorStyles.Left
            Me.gbBattleMode.Visible = True
            Me.gbBattleMode.BringToFront()
        Else
            Me.gbBattleMode.Enabled = False
            Me.gbBattleMode.Visible = False
            Me.gbxSetupMode.Enabled = True
            Me.gbxSetupMode.Top = 50
            Me.gbxSetupMode.Left = 11
            Me.gbxSetupMode.Width = 483
            Me.gbxSetupMode.Height = 139
            Me.gbxSetupMode.Anchor = AnchorStyles.Top Or AnchorStyles.Left
            Me.gbxSetupMode.Visible = True
            Me.gbxSetupMode.BringToFront()
        End If

    End Sub

    ''' <summary>
    ''' Method: btnReset_Click
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' handles the btnReset.Click event
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reInit()
    End Sub

    ''' <summary>
    ''' Method: btnPlay_Click
    ''' 
    ''' Handles: btnPlay.Click
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions:
    ''' calls CrossCheckAndVerifyCountdownCounters to set the correct playmode
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        Call ResetLabelControls()
        Call CrossCheckAndVerifyCountdownCounters(False)

    End Sub

    ''' <summary>
    ''' Procedure: CrossCheckAndVerifyCountdownCounters
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: sets _mode according to the value of _planetCounter and/or
    ''' _shotCounter. 
    ''' 
    ''' Notes: All we're really looking for is negative numbers
    ''' 
    ''' Return Value: None
    ''' </summary>
    Private Sub CrossCheckAndVerifyCountdownCounters(ByVal clickFromCell As Boolean)

        If 0 >= _planetCounter Then
            _mode = playmode.battle
            If clickFromCell Then
                _shotCounter += 1
            Else
                _planetCounter = -1
            End If
        End If

        If 0 >= _shotCounter Then
            _mode = playmode.place
        End If

        If playmode.test = _mode Then
            Me.tmrCountdownPlanetCreated.Enabled = False
        End If

    End Sub

    ''' <summary>
    ''' Method: frmBattleDeathStars_Load
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions: Calls Init subroutine
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmBattleDeathStars_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Init()

    End Sub

    ''' <summary>
    ''' Method: dgPlayArea_CellContentClick
    ''' 
    ''' Handles: CellClick
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions:
    ''' records position of mouse click and calls TrackPlanets subroutine
    ''' 
    ''' Return Value: None
    ''' </summary>
    ''' <param name="e">not used</param>
    ''' <param name="sender">not used</param>
    Private Sub dgPlayArea_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPlayArea.CellClick

        Dim coordinates As _myPoint

        coordinates.column = Me.dgPlayArea.CurrentCellAddress.X
        coordinates.row = Me.dgPlayArea.CurrentCellAddress.Y

        ' check to see if the planet inventory is run out
        Call AnyPlanetsLeft()

        ' track planet
        Call TrackPlanets(coordinates)

    End Sub

#End Region

End Class 'frmBattleDeathStars
