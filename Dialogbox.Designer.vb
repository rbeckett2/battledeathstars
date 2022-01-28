<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDialogbox))
        Me.tcSetup = New System.Windows.Forms.TabControl()
        Me.tpInstructions = New System.Windows.Forms.TabPage()
        Me.lblAboutGame = New System.Windows.Forms.Label()
        Me.lblUseImages = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPlanetsDB = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTestMode = New System.Windows.Forms.Label()
        Me.lblSetupHeader = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblClickFiringDetail = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblClickFiring = New System.Windows.Forms.Label()
        Me.lblEndGame = New System.Windows.Forms.Label()
        Me.lblCoordFiring = New System.Windows.Forms.Label()
        Me.lblGamePlayDB = New System.Windows.Forms.Label()
        Me.lblHeaderDB = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCloseDB = New System.Windows.Forms.Button()
        Me.tcSetup.SuspendLayout()
        Me.tpInstructions.SuspendLayout()
        Me.lblUseImages.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcSetup
        '
        Me.tcSetup.Controls.Add(Me.tpInstructions)
        Me.tcSetup.Controls.Add(Me.lblUseImages)
        Me.tcSetup.Controls.Add(Me.TabPage3)
        Me.tcSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcSetup.Location = New System.Drawing.Point(12, 110)
        Me.tcSetup.Name = "tcSetup"
        Me.tcSetup.SelectedIndex = 0
        Me.tcSetup.Size = New System.Drawing.Size(537, 407)
        Me.tcSetup.TabIndex = 0
        '
        'tpInstructions
        '
        Me.tpInstructions.BackgroundImage = Global.BattleDeathStars.My.Resources.Resources.Background
        Me.tpInstructions.Controls.Add(Me.lblAboutGame)
        Me.tpInstructions.Location = New System.Drawing.Point(4, 24)
        Me.tpInstructions.Name = "tpInstructions"
        Me.tpInstructions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInstructions.Size = New System.Drawing.Size(529, 379)
        Me.tpInstructions.TabIndex = 0
        Me.tpInstructions.Text = "About Battle Deathstar"
        Me.tpInstructions.UseVisualStyleBackColor = True
        '
        'lblAboutGame
        '
        Me.lblAboutGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutGame.ForeColor = System.Drawing.Color.White
        Me.lblAboutGame.Location = New System.Drawing.Point(6, 17)
        Me.lblAboutGame.Name = "lblAboutGame"
        Me.lblAboutGame.Size = New System.Drawing.Size(131, 317)
        Me.lblAboutGame.TabIndex = 0
        Me.lblAboutGame.Text = "Battle DeathStar is designed and created by Ryan Beckett and Shreeji Patel as par" &
    "t of the NETD2202 (.NET DEVELOPMENT 1) course at Durham College. "
        '
        'lblUseImages
        '
        Me.lblUseImages.BackColor = System.Drawing.Color.Black
        Me.lblUseImages.Controls.Add(Me.Label11)
        Me.lblUseImages.Controls.Add(Me.Label10)
        Me.lblUseImages.Controls.Add(Me.lblPlanetsDB)
        Me.lblUseImages.Controls.Add(Me.Label9)
        Me.lblUseImages.Controls.Add(Me.Label8)
        Me.lblUseImages.Controls.Add(Me.Label7)
        Me.lblUseImages.Controls.Add(Me.lblTestMode)
        Me.lblUseImages.Controls.Add(Me.lblSetupHeader)
        Me.lblUseImages.Location = New System.Drawing.Point(4, 24)
        Me.lblUseImages.Name = "lblUseImages"
        Me.lblUseImages.Padding = New System.Windows.Forms.Padding(3)
        Me.lblUseImages.Size = New System.Drawing.Size(529, 379)
        Me.lblUseImages.TabIndex = 1
        Me.lblUseImages.Text = "Setup"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(126, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(368, 80)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = resources.GetString("Label11.Text")
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(126, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(368, 67)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'lblPlanetsDB
        '
        Me.lblPlanetsDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanetsDB.ForeColor = System.Drawing.Color.Yellow
        Me.lblPlanetsDB.Location = New System.Drawing.Point(25, 217)
        Me.lblPlanetsDB.Name = "lblPlanetsDB"
        Me.lblPlanetsDB.Size = New System.Drawing.Size(105, 29)
        Me.lblPlanetsDB.TabIndex = 7
        Me.lblPlanetsDB.Text = "Planets"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(126, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(368, 56)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "This is an advanced feature (i.e. bonus question) that follows the user to play t" &
    "he game with some simple graphics rather than just numbers and colors."
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(25, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 29)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Use Images"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(126, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(368, 56)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "This allows the user to view the data stored in the array and view where planets " &
    "are placed during game play. They are visible during setup anyways."
        '
        'lblTestMode
        '
        Me.lblTestMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestMode.ForeColor = System.Drawing.Color.Yellow
        Me.lblTestMode.Location = New System.Drawing.Point(25, 105)
        Me.lblTestMode.Name = "lblTestMode"
        Me.lblTestMode.Size = New System.Drawing.Size(105, 29)
        Me.lblTestMode.TabIndex = 3
        Me.lblTestMode.Text = "Test Mode"
        '
        'lblSetupHeader
        '
        Me.lblSetupHeader.BackColor = System.Drawing.Color.Black
        Me.lblSetupHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetupHeader.ForeColor = System.Drawing.Color.White
        Me.lblSetupHeader.Location = New System.Drawing.Point(6, 16)
        Me.lblSetupHeader.Name = "lblSetupHeader"
        Me.lblSetupHeader.Size = New System.Drawing.Size(517, 89)
        Me.lblSetupHeader.TabIndex = 2
        Me.lblSetupHeader.Text = resources.GetString("lblSetupHeader.Text")
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Black
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.lblClickFiringDetail)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.lblClickFiring)
        Me.TabPage3.Controls.Add(Me.lblEndGame)
        Me.TabPage3.Controls.Add(Me.lblCoordFiring)
        Me.TabPage3.Controls.Add(Me.lblGamePlayDB)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(529, 379)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Game Play"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(140, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(368, 51)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "3) Victory: You have destroyed all the resistance planets and crippled the rebell" &
    "ion. This occurs when the number of destroyed planets equals the maximum number " &
    "of planets allowed."
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(140, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(368, 51)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "2) Failure: You have drained the energy from the sun and can no longer fire. This" &
    " occurs when the number of shots taken matches the maximum number of shots possi" &
    "ble."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(140, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(368, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "1) Reset: This will erase all data with respect to planets and shots fired prepar" &
    "ing to start a new game beginning with the setup."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(140, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(335, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "There are 3 ways to end the game."
        '
        'lblClickFiringDetail
        '
        Me.lblClickFiringDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickFiringDetail.ForeColor = System.Drawing.Color.White
        Me.lblClickFiringDetail.Location = New System.Drawing.Point(140, 129)
        Me.lblClickFiringDetail.Name = "lblClickFiringDetail"
        Me.lblClickFiringDetail.Size = New System.Drawing.Size(335, 52)
        Me.lblClickFiringDetail.TabIndex = 6
        Me.lblClickFiringDetail.Text = "Alternatively, you can click on the grid in which you wish to fire the weapon. It" &
    " will be fired immediately upon clicking. If a planet exists, it will be destroy" &
    "ed."
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(140, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(335, 52)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "You can set the X and Y coordinates and click the fire button. This will fire the" &
    " weapon and if a planet exists in that grid, it will be destroyed."
        '
        'lblClickFiring
        '
        Me.lblClickFiring.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickFiring.ForeColor = System.Drawing.Color.Yellow
        Me.lblClickFiring.Location = New System.Drawing.Point(16, 129)
        Me.lblClickFiring.Name = "lblClickFiring"
        Me.lblClickFiring.Size = New System.Drawing.Size(105, 29)
        Me.lblClickFiring.TabIndex = 4
        Me.lblClickFiring.Text = "Click Firing"
        '
        'lblEndGame
        '
        Me.lblEndGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndGame.ForeColor = System.Drawing.Color.Yellow
        Me.lblEndGame.Location = New System.Drawing.Point(16, 185)
        Me.lblEndGame.Name = "lblEndGame"
        Me.lblEndGame.Size = New System.Drawing.Size(105, 29)
        Me.lblEndGame.TabIndex = 3
        Me.lblEndGame.Text = "End Game"
        '
        'lblCoordFiring
        '
        Me.lblCoordFiring.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoordFiring.ForeColor = System.Drawing.Color.Yellow
        Me.lblCoordFiring.Location = New System.Drawing.Point(16, 68)
        Me.lblCoordFiring.Name = "lblCoordFiring"
        Me.lblCoordFiring.Size = New System.Drawing.Size(105, 29)
        Me.lblCoordFiring.TabIndex = 2
        Me.lblCoordFiring.Text = "Coord Firing"
        '
        'lblGamePlayDB
        '
        Me.lblGamePlayDB.BackColor = System.Drawing.Color.Black
        Me.lblGamePlayDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamePlayDB.ForeColor = System.Drawing.Color.White
        Me.lblGamePlayDB.Location = New System.Drawing.Point(16, 5)
        Me.lblGamePlayDB.Name = "lblGamePlayDB"
        Me.lblGamePlayDB.Size = New System.Drawing.Size(473, 75)
        Me.lblGamePlayDB.TabIndex = 1
        Me.lblGamePlayDB.Text = "To play this game, you simple take shots within the Galaxy Grid and desroy all th" &
    "e resistance planets before you completely drain the energy of the sun and can n" &
    "o longer fire the weapon."
        '
        'lblHeaderDB
        '
        Me.lblHeaderDB.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeaderDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderDB.ForeColor = System.Drawing.Color.Yellow
        Me.lblHeaderDB.Location = New System.Drawing.Point(25, 9)
        Me.lblHeaderDB.Name = "lblHeaderDB"
        Me.lblHeaderDB.Size = New System.Drawing.Size(559, 41)
        Me.lblHeaderDB.TabIndex = 2
        Me.lblHeaderDB.Text = "Battle Deathstar"
        Me.lblHeaderDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(25, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Battle Deathstars Instructions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCloseDB
        '
        Me.btnCloseDB.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCloseDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseDB.ForeColor = System.Drawing.Color.White
        Me.btnCloseDB.Location = New System.Drawing.Point(448, 63)
        Me.btnCloseDB.Name = "btnCloseDB"
        Me.btnCloseDB.Size = New System.Drawing.Size(97, 44)
        Me.btnCloseDB.TabIndex = 14
        Me.btnCloseDB.Text = "&Close"
        Me.btnCloseDB.UseVisualStyleBackColor = False
        '
        'frmDialogbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BattleDeathStars.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(605, 516)
        Me.Controls.Add(Me.btnCloseDB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeaderDB)
        Me.Controls.Add(Me.tcSetup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDialogbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deathstar Wars"
        Me.tcSetup.ResumeLayout(False)
        Me.tpInstructions.ResumeLayout(False)
        Me.lblUseImages.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcSetup As TabControl
    Friend WithEvents tpInstructions As TabPage
    Friend WithEvents lblUseImages As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblHeaderDB As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCloseDB As Button
    Friend WithEvents lblAboutGame As Label
    Friend WithEvents lblGamePlayDB As Label
    Friend WithEvents lblCoordFiring As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblClickFiring As Label
    Friend WithEvents lblEndGame As Label
    Friend WithEvents lblClickFiringDetail As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSetupHeader As Label
    Friend WithEvents lblTestMode As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPlanetsDB As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
