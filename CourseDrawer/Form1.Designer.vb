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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.butSaveGame = New System.Windows.Forms.ToolStripButton()
        Me.butLoadBGImage = New System.Windows.Forms.ToolStripButton()
        Me.butSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.butMove = New System.Windows.Forms.ToolStripButton()
        Me.butZoom = New System.Windows.Forms.ToolStripButton()
        Me.butSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.butAppendNode = New System.Windows.Forms.ToolStripButton()
        Me.butInsertNode = New System.Windows.Forms.ToolStripButton()
        Me.butDeleteNode = New System.Windows.Forms.ToolStripButton()
        Me.sButFillNodes = New System.Windows.Forms.ToolStripSplitButton()
        Me.Distance5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Distance10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Distance20ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.butNewCourse = New System.Windows.Forms.ToolStripButton()
        Me.butDelCourse = New System.Windows.Forms.ToolStripButton()
        Me.butRecalcAngleCrs = New System.Windows.Forms.ToolStripButton()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerDragPicture = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.butCalcAngleSel = New System.Windows.Forms.Button()
        Me.ChWP_Cross = New System.Windows.Forms.CheckBox()
        Me.ChWP_Wait = New System.Windows.Forms.CheckBox()
        Me.ChWP_Rev = New System.Windows.Forms.CheckBox()
        Me.ChWP_TurnStart = New System.Windows.Forms.CheckBox()
        Me.ChWP_TurnEnd = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBWP_Speed = New System.Windows.Forms.MaskedTextBox()
        Me.TBWP_Angle = New System.Windows.Forms.MaskedTextBox()
        Me.TBWP_Y = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBWP_X = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.butSelectAll = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TBCrs_Name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBCrs_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.butCrsUp = New System.Windows.Forms.Button()
        Me.butCrsDown = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.butSaveGame, Me.butLoadBGImage, Me.butSave, Me.ToolStripSeparator1, Me.butMove, Me.butZoom, Me.butSelect, Me.ToolStripSeparator2, Me.butAppendNode, Me.butInsertNode, Me.butDeleteNode, Me.sButFillNodes, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripSeparator4, Me.butNewCourse, Me.butDelCourse, Me.butRecalcAngleCrs})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1308, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'butSaveGame
        '
        Me.butSaveGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butSaveGame.Image = Global.CourseDrawer.My.Resources.Resources.butOpen
        Me.butSaveGame.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butSaveGame.Name = "butSaveGame"
        Me.butSaveGame.Size = New System.Drawing.Size(36, 36)
        Me.butSaveGame.Text = "Savegame"
        '
        'butLoadBGImage
        '
        Me.butLoadBGImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butLoadBGImage.Image = Global.CourseDrawer.My.Resources.Resources.butMap
        Me.butLoadBGImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butLoadBGImage.Name = "butLoadBGImage"
        Me.butLoadBGImage.Size = New System.Drawing.Size(36, 36)
        Me.butLoadBGImage.Text = "Map"
        '
        'butSave
        '
        Me.butSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butSave.Image = Global.CourseDrawer.My.Resources.Resources.butSave
        Me.butSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(36, 36)
        Me.butSave.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'butMove
        '
        Me.butMove.Checked = True
        Me.butMove.CheckOnClick = True
        Me.butMove.CheckState = System.Windows.Forms.CheckState.Checked
        Me.butMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butMove.Image = Global.CourseDrawer.My.Resources.Resources.butMove
        Me.butMove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butMove.Name = "butMove"
        Me.butMove.Size = New System.Drawing.Size(36, 36)
        Me.butMove.Text = "Move"
        '
        'butZoom
        '
        Me.butZoom.CheckOnClick = True
        Me.butZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butZoom.Image = Global.CourseDrawer.My.Resources.Resources.butZoom
        Me.butZoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butZoom.Name = "butZoom"
        Me.butZoom.Size = New System.Drawing.Size(36, 36)
        Me.butZoom.Text = "Zoom"
        '
        'butSelect
        '
        Me.butSelect.CheckOnClick = True
        Me.butSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butSelect.Image = Global.CourseDrawer.My.Resources.Resources.butSelect
        Me.butSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butSelect.Name = "butSelect"
        Me.butSelect.Size = New System.Drawing.Size(36, 36)
        Me.butSelect.Text = "Select"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'butAppendNode
        '
        Me.butAppendNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butAppendNode.Enabled = False
        Me.butAppendNode.Image = Global.CourseDrawer.My.Resources.Resources.butAddNode
        Me.butAppendNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butAppendNode.Name = "butAppendNode"
        Me.butAppendNode.Size = New System.Drawing.Size(36, 36)
        Me.butAppendNode.Text = "Add"
        '
        'butInsertNode
        '
        Me.butInsertNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butInsertNode.Enabled = False
        Me.butInsertNode.Image = Global.CourseDrawer.My.Resources.Resources.butInsertNode
        Me.butInsertNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butInsertNode.Name = "butInsertNode"
        Me.butInsertNode.Size = New System.Drawing.Size(36, 36)
        Me.butInsertNode.Text = "Insert"
        '
        'butDeleteNode
        '
        Me.butDeleteNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butDeleteNode.Enabled = False
        Me.butDeleteNode.Image = Global.CourseDrawer.My.Resources.Resources.butDeleteNode
        Me.butDeleteNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butDeleteNode.Name = "butDeleteNode"
        Me.butDeleteNode.Size = New System.Drawing.Size(36, 36)
        Me.butDeleteNode.Text = "Delete"
        '
        'sButFillNodes
        '
        Me.sButFillNodes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.sButFillNodes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Distance5ToolStripMenuItem, Me.Distance10ToolStripMenuItem, Me.Distance20ToolStripMenuItem})
        Me.sButFillNodes.Enabled = False
        Me.sButFillNodes.Image = Global.CourseDrawer.My.Resources.Resources.butFillNodes
        Me.sButFillNodes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sButFillNodes.Name = "sButFillNodes"
        Me.sButFillNodes.Size = New System.Drawing.Size(48, 36)
        Me.sButFillNodes.Text = "Fill Nodes"
        '
        'Distance5ToolStripMenuItem
        '
        Me.Distance5ToolStripMenuItem.Name = "Distance5ToolStripMenuItem"
        Me.Distance5ToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.Distance5ToolStripMenuItem.Text = "Distance 5"
        '
        'Distance10ToolStripMenuItem
        '
        Me.Distance10ToolStripMenuItem.Name = "Distance10ToolStripMenuItem"
        Me.Distance10ToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.Distance10ToolStripMenuItem.Text = "Distance 10"
        '
        'Distance20ToolStripMenuItem
        '
        Me.Distance20ToolStripMenuItem.Name = "Distance20ToolStripMenuItem"
        Me.Distance20ToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.Distance20ToolStripMenuItem.Text = "Distance 20"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(46, 36)
        Me.ToolStripLabel1.Text = "Circle"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(65, 39)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'butNewCourse
        '
        Me.butNewCourse.CheckOnClick = True
        Me.butNewCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butNewCourse.Image = Global.CourseDrawer.My.Resources.Resources.butNewCrs
        Me.butNewCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butNewCourse.Name = "butNewCourse"
        Me.butNewCourse.Size = New System.Drawing.Size(36, 36)
        Me.butNewCourse.Text = "NewCourse"
        '
        'butDelCourse
        '
        Me.butDelCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butDelCourse.Enabled = False
        Me.butDelCourse.Image = Global.CourseDrawer.My.Resources.Resources.butDelCrs
        Me.butDelCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butDelCourse.Name = "butDelCourse"
        Me.butDelCourse.Size = New System.Drawing.Size(36, 36)
        Me.butDelCourse.Text = "DelCourse"
        '
        'butRecalcAngleCrs
        '
        Me.butRecalcAngleCrs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butRecalcAngleCrs.Enabled = False
        Me.butRecalcAngleCrs.Image = Global.CourseDrawer.My.Resources.Resources.butRecalcDir
        Me.butRecalcAngleCrs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butRecalcAngleCrs.Name = "butRecalcAngleCrs"
        Me.butRecalcAngleCrs.Size = New System.Drawing.Size(36, 36)
        Me.butRecalcAngleCrs.Text = "Recalc directions"
        '
        'panel1
        '
        Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.AutoScroll = True
        Me.panel1.Controls.Add(Me.PictureBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 52)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1077, 585)
        Me.panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2731, 2521)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TimerDragPicture
        '
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(1085, 53)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(208, 191)
        Me.CheckedListBox1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.butCalcAngleSel)
        Me.Panel2.Controls.Add(Me.ChWP_Cross)
        Me.Panel2.Controls.Add(Me.ChWP_Wait)
        Me.Panel2.Controls.Add(Me.ChWP_Rev)
        Me.Panel2.Controls.Add(Me.ChWP_TurnStart)
        Me.Panel2.Controls.Add(Me.ChWP_TurnEnd)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TBWP_Speed)
        Me.Panel2.Controls.Add(Me.TBWP_Angle)
        Me.Panel2.Controls.Add(Me.TBWP_Y)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TBWP_X)
        Me.Panel2.Location = New System.Drawing.Point(1085, 414)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 218)
        Me.Panel2.TabIndex = 4
        '
        'butCalcAngleSel
        '
        Me.butCalcAngleSel.Location = New System.Drawing.Point(8, 187)
        Me.butCalcAngleSel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butCalcAngleSel.Name = "butCalcAngleSel"
        Me.butCalcAngleSel.Size = New System.Drawing.Size(100, 28)
        Me.butCalcAngleSel.TabIndex = 4
        Me.butCalcAngleSel.Text = "Calc angle"
        Me.butCalcAngleSel.UseVisualStyleBackColor = True
        '
        'ChWP_Cross
        '
        Me.ChWP_Cross.AutoSize = True
        Me.ChWP_Cross.Location = New System.Drawing.Point(8, 166)
        Me.ChWP_Cross.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChWP_Cross.Name = "ChWP_Cross"
        Me.ChWP_Cross.Size = New System.Drawing.Size(85, 21)
        Me.ChWP_Cross.TabIndex = 3
        Me.ChWP_Cross.Text = "Crossing"
        Me.ChWP_Cross.UseVisualStyleBackColor = True
        '
        'ChWP_Wait
        '
        Me.ChWP_Wait.AutoSize = True
        Me.ChWP_Wait.Location = New System.Drawing.Point(116, 138)
        Me.ChWP_Wait.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChWP_Wait.Name = "ChWP_Wait"
        Me.ChWP_Wait.Size = New System.Drawing.Size(58, 21)
        Me.ChWP_Wait.TabIndex = 3
        Me.ChWP_Wait.Text = "Wait"
        Me.ChWP_Wait.UseVisualStyleBackColor = True
        '
        'ChWP_Rev
        '
        Me.ChWP_Rev.AutoSize = True
        Me.ChWP_Rev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChWP_Rev.Location = New System.Drawing.Point(8, 138)
        Me.ChWP_Rev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChWP_Rev.Name = "ChWP_Rev"
        Me.ChWP_Rev.Size = New System.Drawing.Size(83, 21)
        Me.ChWP_Rev.TabIndex = 3
        Me.ChWP_Rev.Text = "Reverse"
        Me.ChWP_Rev.UseVisualStyleBackColor = True
        '
        'ChWP_TurnStart
        '
        Me.ChWP_TurnStart.AutoSize = True
        Me.ChWP_TurnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChWP_TurnStart.Location = New System.Drawing.Point(116, 164)
        Me.ChWP_TurnStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChWP_TurnStart.Name = "ChWP_TurnStart"
        Me.ChWP_TurnStart.Size = New System.Drawing.Size(90, 21)
        Me.ChWP_TurnStart.TabIndex = 4
        Me.ChWP_TurnStart.Text = "TurnStart"
        Me.ChWP_TurnStart.UseVisualStyleBackColor = True
        '
        'ChWP_TurnEnd
        '
        Me.ChWP_TurnEnd.AutoSize = True
        Me.ChWP_TurnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChWP_TurnEnd.Location = New System.Drawing.Point(115, 192)
        Me.ChWP_TurnEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChWP_TurnEnd.Name = "ChWP_TurnEnd"
        Me.ChWP_TurnEnd.Size = New System.Drawing.Size(85, 21)
        Me.ChWP_TurnEnd.TabIndex = 4
        Me.ChWP_TurnEnd.Text = "TurnEnd"
        Me.ChWP_TurnEnd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Angle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pos Y"
        '
        'TBWP_Speed
        '
        Me.TBWP_Speed.BeepOnError = True
        Me.TBWP_Speed.Culture = New System.Globalization.CultureInfo("")
        Me.TBWP_Speed.Location = New System.Drawing.Point(56, 106)
        Me.TBWP_Speed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBWP_Speed.Name = "TBWP_Speed"
        Me.TBWP_Speed.Size = New System.Drawing.Size(148, 22)
        Me.TBWP_Speed.TabIndex = 1
        Me.TBWP_Speed.Text = "0"
        '
        'TBWP_Angle
        '
        Me.TBWP_Angle.BeepOnError = True
        Me.TBWP_Angle.Culture = New System.Globalization.CultureInfo("")
        Me.TBWP_Angle.Location = New System.Drawing.Point(56, 74)
        Me.TBWP_Angle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBWP_Angle.Name = "TBWP_Angle"
        Me.TBWP_Angle.Size = New System.Drawing.Size(148, 22)
        Me.TBWP_Angle.TabIndex = 1
        Me.TBWP_Angle.Text = "0"
        '
        'TBWP_Y
        '
        Me.TBWP_Y.BeepOnError = True
        Me.TBWP_Y.Culture = New System.Globalization.CultureInfo("")
        Me.TBWP_Y.Location = New System.Drawing.Point(56, 42)
        Me.TBWP_Y.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBWP_Y.Name = "TBWP_Y"
        Me.TBWP_Y.Size = New System.Drawing.Size(148, 22)
        Me.TBWP_Y.TabIndex = 1
        Me.TBWP_Y.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pos X"
        '
        'TBWP_X
        '
        Me.TBWP_X.BeepOnError = True
        Me.TBWP_X.Culture = New System.Globalization.CultureInfo("")
        Me.TBWP_X.Location = New System.Drawing.Point(56, 10)
        Me.TBWP_X.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBWP_X.Name = "TBWP_X"
        Me.TBWP_X.Size = New System.Drawing.Size(148, 22)
        Me.TBWP_X.TabIndex = 1
        Me.TBWP_X.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Speed"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1308, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'butSelectAll
        '
        Me.butSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butSelectAll.Location = New System.Drawing.Point(1085, 268)
        Me.butSelectAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butSelectAll.Name = "butSelectAll"
        Me.butSelectAll.Size = New System.Drawing.Size(96, 28)
        Me.butSelectAll.TabIndex = 6
        Me.butSelectAll.Text = "(Un)Select"
        Me.butSelectAll.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.TBCrs_Name)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TBCrs_ID)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(1085, 304)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 102)
        Me.Panel3.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(56, 70)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 22)
        Me.TextBox1.TabIndex = 5
        '
        'TBCrs_Name
        '
        Me.TBCrs_Name.Location = New System.Drawing.Point(56, 38)
        Me.TBCrs_Name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBCrs_Name.Name = "TBCrs_Name"
        Me.TBCrs_Name.Size = New System.Drawing.Size(148, 22)
        Me.TBCrs_Name.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Folder"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 42)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Name"
        '
        'TBCrs_ID
        '
        Me.TBCrs_ID.Enabled = False
        Me.TBCrs_ID.Location = New System.Drawing.Point(55, 6)
        Me.TBCrs_ID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBCrs_ID.Name = "TBCrs_ID"
        Me.TBCrs_ID.Size = New System.Drawing.Size(148, 22)
        Me.TBCrs_ID.TabIndex = 1
        Me.TBCrs_ID.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ID:"
        '
        'butCrsUp
        '
        Me.butCrsUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCrsUp.Location = New System.Drawing.Point(1209, 268)
        Me.butCrsUp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butCrsUp.Name = "butCrsUp"
        Me.butCrsUp.Size = New System.Drawing.Size(39, 28)
        Me.butCrsUp.TabIndex = 8
        Me.butCrsUp.Text = "Up"
        Me.butCrsUp.UseVisualStyleBackColor = True
        '
        'butCrsDown
        '
        Me.butCrsDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCrsDown.Location = New System.Drawing.Point(1256, 268)
        Me.butCrsDown.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butCrsDown.Name = "butCrsDown"
        Me.butCrsDown.Size = New System.Drawing.Size(39, 28)
        Me.butCrsDown.TabIndex = 9
        Me.butCrsDown.Text = "Dn"
        Me.butCrsDown.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 662)
        Me.Controls.Add(Me.butCrsDown)
        Me.Controls.Add(Me.butCrsUp)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.butSelectAll)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Courseplay Edit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents butSaveGame As System.Windows.Forms.ToolStripButton
    Friend WithEvents butLoadBGImage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerDragPicture As System.Windows.Forms.Timer
    Friend WithEvents butZoom As System.Windows.Forms.ToolStripButton
    Friend WithEvents butMove As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents butAppendNode As System.Windows.Forms.ToolStripButton
    Friend WithEvents butInsertNode As System.Windows.Forms.ToolStripButton
    Friend WithEvents butDeleteNode As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents butSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TBWP_X As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBWP_Y As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChWP_Cross As System.Windows.Forms.CheckBox
    Friend WithEvents ChWP_Wait As System.Windows.Forms.CheckBox
    Friend WithEvents ChWP_Rev As System.Windows.Forms.CheckBox
    Friend WithEvents ChWP_TurnStart As System.Windows.Forms.CheckBox
    Friend WithEvents ChWP_TurnEnd As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBWP_Speed As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TBWP_Angle As System.Windows.Forms.MaskedTextBox
    Friend WithEvents butSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents butSelectAll As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents butNewCourse As System.Windows.Forms.ToolStripButton
    Friend WithEvents butDelCourse As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TBCrs_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBCrs_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents butCalcAngleSel As System.Windows.Forms.Button
    Friend WithEvents sButFillNodes As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents Distance5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Distance10ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents butRecalcAngleCrs As System.Windows.Forms.ToolStripButton
    Friend WithEvents Distance20ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents butCrsUp As System.Windows.Forms.Button
    Friend WithEvents butCrsDown As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
