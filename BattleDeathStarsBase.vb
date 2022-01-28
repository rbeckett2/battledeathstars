Option Strict On
' Author(s): Shreeji Patel and Ryan Beckett
' Student ID's: 100635549 100642971
' Date: Feb. 7, 2017
' Filename: BattleDeathStarsBase.vb
' Description:
' BattleDeathStarsBase abstracts generic methods and objects from frmBattleDeathStars

Public Class BattleDeathStarsBase
    Inherits System.Windows.Forms.Form

    ' use a structure to represent X and Y coordinates in the DataGridView
    Public Structure _myPoint
        Public row As Integer
        Public column As Integer
    End Structure

    ' definition of playmodes within BattleDeathStars
    Public Enum playmode
        place
        battle
        test
    End Enum

    ' array of points used to keep track of placement of planets
    Public _arrPlanets(10) As _myPoint

    ' countdown counter for planets
    Public _planetCounter As Integer

    ' array of points used to keep track of placement of shots by user
    Public _arrShots(11) As _myPoint

    ' the current playmode, one of an enumeration
    Public _mode As playmode

    ' countdown counter for shots
    Public _shotCounter As Integer

    ' initguard to keep miscellaneous controls from firing their event handlers' during initialization
    ' (or re-initialization)
    Public _initGuard As Boolean

    ' a flag to correct an extraneous problem when user clicks test checkbox and randomization button
    ' at the same time
    Public _bFirstShotAfterTest As Boolean

#Region "BattleDeathStarsBase functions and methods"

    ''' <summary>
    ''' Function: HaveTheyAlreadyShotThere
    ''' 
    ''' Pre-conditions: None
    ''' 
    ''' Post-conditions:
    ''' returns true, otherwise returns false depending on whether the user has placed a shot there before
    ''' 
    ''' Return Value: boolean
    ''' </summary>
    ''' <param name="inPoint">_myPoint structure</param>
    Public Function HaveTheyAlreadyShotThere(ByVal inPoint As _myPoint) As Boolean

        Dim foundShot As Boolean
        For Each coordinate In _arrShots
            If inPoint.column = coordinate.column And inPoint.row = coordinate.row Then
                foundShot = True
            End If
        Next
        Return foundShot

    End Function

    ''' <summary>
    ''' Procedure: ResetArrays
    ''' 
    ''' Pre-conditions: none
    ''' 
    ''' Post-conditions:
    ''' reinitializes our global arrays
    ''' 
    ''' Return Value: None
    ''' </summary>
    Public Sub ResetArrays()

        For i As Integer = 0 To _arrPlanets.Length - 1
            _arrPlanets(i).column = 0
            _arrPlanets(i).row = 0
        Next
        For i As Integer = 0 To _arrShots.Length - 1
            _arrShots(i).column = 0
            _arrShots(i).row = 0
        Next

    End Sub

#End Region

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
        components = New System.ComponentModel.Container
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Text = "BattleDeathStarsBase"
    End Sub

    Private Sub BattleDeathStarsBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class
