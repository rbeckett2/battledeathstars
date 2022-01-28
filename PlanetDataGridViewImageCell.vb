Option Strict On

Imports System.Drawing
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
'
' Author(s): Shreeji Patel and Ryan Beckett
' Student ID's: 100635549 100642971
' Date: Feb 1, 2017
' Filename: PlanetDataGridViewImageCell.vb
' Description: The PlanetDataGridViewImageCell class is a derivation of the DataGridViewImageCell class
' Purpose: The purpose of this class is to override the GetFormattedValue function found in the
' DataGridViewImageCell class. The default GetFormattedValue in DataGridViewImageCell sometimes
' throws exceptions when stuffed with a GDI bitmap
Public Class PlanetDataGridViewImageCell
    Inherits DataGridViewImageCell

    ' our class' context options
    Public Enum initStatus
        planetSpace
        planetDestroy
        planetRandom
    End Enum

    ' the class context
    Public curStatus As initStatus

    ''' <summary>
    ''' The GetFormattedValue function is used by the DataGridViewImageCell to display
    ''' the contents of a cell.
    ''' </summary>
    ''' <param name="value">not used</param>
    ''' <param name="rowIndex">not used</param>
    ''' <param name="cellStyle">not used</param>
    ''' <param name="valueTypeConverter">not used</param>
    ''' <param name="formattedValueTypeConverter">not used</param>
    ''' <param name="context">not used</param>
    ''' <returns>Image</returns>
    Protected Overrides Function GetFormattedValue(ByVal value As Object,
                                                   ByVal rowIndex As Integer,
                                                   ByRef cellStyle As DataGridViewCellStyle,
                                                   ByVal valueTypeConverter As TypeConverter,
                                                   ByVal formattedValueTypeConverter As TypeConverter,
                                                   ByVal context As DataGridViewDataErrorContexts) As Object
        ' sets image to blank to avoid compile warning
        Dim image As Image = Nothing
        If initStatus.planetSpace = curStatus Then
            image = Image.FromHbitmap(My.Resources.stars.GetHbitmap)
        ElseIf initStatus.planetRandom = curStatus Then
            Dim randomNum As Integer = 0
            Dim randomPlanets As Random
            randomPlanets = New Random()
            randomNum = randomPlanets.Next(4)

            ' select a random image from the resources
            Select Case randomNum

                Case 0
                    image = Image.FromHbitmap(My.Resources.planet.GetHbitmap)

                Case 1
                    image = Image.FromHbitmap(My.Resources.planet2.GetHbitmap)

                Case 2
                    image = Image.FromHbitmap(My.Resources.planet3.GetHbitmap)

                Case 3
                    image = Image.FromHbitmap(My.Resources.planet4.GetHbitmap)

                Case 4
                    image = Image.FromHbitmap(My.Resources.planet5.GetHbitmap)

            End Select
        ElseIf initStatus.planetDestroy = curStatus Then
            image = Image.FromHbitmap(My.Resources.planet_Destroyed30.GetHbitmap)
        End If

        Return image
    End Function

    ' TODO: Implement DeleteObject
    <System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")>
    Private Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
    End Function


End Class 'PlanetDataGridViewImage