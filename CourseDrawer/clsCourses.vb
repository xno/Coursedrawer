﻿''' <summary>
''' Class for collection of courses
''' </summary>
''' <remarks>Singleton class for wrapping courses</remarks>
Public Class clsCourses
    Private _coursesList As List(Of clsCourse)
    Private _selectedWP As clsWaypoint
    Private _seledtedCrs As Integer
    Public ReadOnly Property Count As Integer
        Get
            Return _coursesList.Count
        End Get
    End Property
    Private Shared _instance As clsCourses
    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub New()
        _coursesList = New List(Of clsCourse)
        AddHandler clsWaypoint.SelectionChanged, AddressOf Me.selectedChangeHandler
    End Sub
    ''' <summary>
    ''' Get instance of singleton class
    ''' </summary>
    ''' <param name="forceNew">force create new instance</param>
    ''' <returns>Instance of courses collection</returns>
    ''' <remarks></remarks>
    Public Shared Function getInstance(Optional ByVal forceNew As Boolean = False) As clsCourses
        If _instance Is Nothing Or forceNew = True Then
            _instance = New clsCourses
        End If
        Return _instance
    End Function
    ''' <summary>
    ''' Get list of course name and hidden attribute
    ''' </summary>
    ''' <value></value>
    ''' <returns>Dictionary of course names and hidden attribute</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CourseList As Dictionary(Of String, Boolean)
        Get
            Dim dir As New Dictionary(Of String, Boolean)
            For Each crs As clsCourse In _coursesList
                dir.Add(crs.id.ToString & " : " & crs.Name, Not crs.Hidden)
            Next
            Return dir
        End Get
    End Property
    ''' <summary>
    ''' Set course hidden or visible
    ''' </summary>
    ''' <param name="id">id</param>
    ''' <param name="hide">true = hidden, false = visible</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ItemHide(ByVal id As Integer, ByVal hide As Boolean) As Boolean
        If id < 0 Or id >= _coursesList.Count Then Return False
        _coursesList(id).Hidden = hide
        Return True
    End Function
    ''' <summary>
    ''' Read courses from XML file
    ''' </summary>
    ''' <param name="file">filename incl. full path</param>
    ''' <remarks></remarks>
    Public Sub ReadXML(ByVal file As String)
        Dim xmlDoc As New Xml.XmlDocument()
        Dim xmlNode As Xml.XmlNode
        Dim xmlNodeReader As Xml.XmlNodeReader
        Dim course As New clsCourse
        Dim waypoint As New clsWaypoint
        Dim stringA() As String

        If file = String.Empty Then Exit Sub

        xmlDoc.Load(file)
        If xmlDoc Is Nothing Then Exit Sub
        xmlNode = xmlDoc.DocumentElement.SelectSingleNode("courses")
        xmlNodeReader = New Xml.XmlNodeReader(xmlNode)
        Do While (xmlNodeReader.Read())
            Select Case xmlNodeReader.NodeType
                Case Xml.XmlNodeType.Element
                    If xmlNodeReader.LocalName = "course" Then
                        course = New clsCourse
                        _coursesList.Add(course)
                        While xmlNodeReader.MoveToNextAttribute
                            Select Case xmlNodeReader.LocalName
                                Case "name"
                                    course.Name = xmlNodeReader.Value
                                Case "id"
                                    Integer.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, course.id)
                                Case "parent"
                                    Integer.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, course.parent)
                            End Select
                        End While
                    ElseIf xmlNodeReader.LocalName.StartsWith("waypoint") Then
                        waypoint = New clsWaypoint
                        If Not course Is Nothing Then
                            course.addWaypoint(waypoint)
                        End If
                        While xmlNodeReader.MoveToNextAttribute
                            Select Case xmlNodeReader.LocalName
                                Case "angle"
                                    Double.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, waypoint.Angle)
                                Case "speed"
                                    Double.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, waypoint.Speed)
                                Case "turnend"
                                    If xmlNodeReader.Value = "1" Then
                                        waypoint.TurnEnd = True
                                    Else
                                        waypoint.TurnEnd = False
                                    End If
                                Case "pos"
                                    stringA = xmlNodeReader.Value.Split(" "c)
                                    Double.TryParse(stringA(0), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, waypoint.Pos_X)
                                    Double.TryParse(stringA(1), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, waypoint.Pos_Y)
                                Case "crossing"
                                    If xmlNodeReader.Value = "1" Then
                                        waypoint.Cross = True
                                    Else
                                        waypoint.Cross = False
                                    End If
                                Case "turnstart"
                                    If xmlNodeReader.Value = "1" Then
                                        waypoint.TurnStart = True
                                    Else
                                        waypoint.TurnStart = False
                                    End If
                                Case "wait"
                                    If xmlNodeReader.Value = "1" Then
                                        waypoint.Wait = True
                                    Else
                                        waypoint.Wait = False
                                    End If
                                Case "rev"
                                    If xmlNodeReader.Value = "1" Then
                                        waypoint.Reverse = True
                                    Else
                                        waypoint.Reverse = False
                                    End If
                                Case "generated"
                                    If xmlNodeReader.Value = "True" Then
                                        waypoint.generated = True
                                    Else
                                        waypoint.generated = False
                                    End If
                                Case "ridgemarker"
                                    Double.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, waypoint.ridgemarker)
                                Case "dir"
                                    waypoint.dir = xmlNodeReader.Value
                                Case "turn"
                                    If xmlNodeReader.Value <> "false" Then
                                        waypoint.turn = xmlNodeReader.Value
                                    End If
                            End Select
                        End While
                    End If
            End Select
        Loop
        _coursesList.Sort(AddressOf SortCourses)
        Me.RecalcCoursesID()


    End Sub

    ''' <summary>
    ''' Draw courses
    ''' </summary>
    ''' <param name="graphics"></param>
    ''' <param name="zoomLvl"></param>
    ''' <remarks></remarks>
    Public Sub draw(ByRef graphics As Graphics, ByVal zoomLvl As Integer)
        Dim course As clsCourse
        For Each course In _coursesList
            If course.Hidden = False Then
                course.draw(graphics, zoomLvl)
            End If
        Next
    End Sub
    ''' <summary>
    ''' Select course at point
    ''' </summary>
    ''' <param name="point"></param>
    ''' <remarks></remarks>
    Public Sub selectWP(ByVal point As PointF)
        Dim selected As Boolean
        Me._seledtedCrs = -1
        For Each crs As clsCourse In _coursesList
            If crs.Hidden = False Then
                selected = crs.selectWP(point)
                If selected = True Then
                    Me._seledtedCrs = _coursesList.IndexOf(crs)
                    Exit For
                End If
            End If
        Next
    End Sub
    ''' <summary>
    ''' Select course by ID
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub selectWP(ByVal id As Integer)
        If id > 0 And id <= _coursesList.Count Then
            _coursesList(id - 1).selectWP(1)
            Me._seledtedCrs = _coursesList.IndexOf(_coursesList(id - 1))
        End If
    End Sub

    Public ReadOnly Property listSelectedId(id As Integer) As Integer
        Get
            Return _coursesList.IndexOf(_coursesList(id - 1))
        End Get
    End Property
    Public ReadOnly Property listSelectedId(crs As clsCourse) As Integer
        Get
            Return _coursesList.IndexOf(crs)
        End Get
    End Property


    ''' <summary>
    ''' Sort courses by ID
    ''' </summary>
    ''' <param name="X"></param>
    ''' <param name="Y"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function SortCourses(ByVal X As clsCourse, ByVal Y As clsCourse) As Integer
        Return X.id.CompareTo(Y.id)
    End Function
    ''' <summary>
    ''' Set selected waypoint
    ''' </summary>
    ''' <param name="wp"></param>
    ''' <remarks></remarks>
    Private Sub selectedChangeHandler(ByRef wp As clsWaypoint)
        Me._selectedWP = wp
    End Sub
    ''' <summary>
    ''' Delete selected waypoint
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub deleteSelectedWP()
        If Me._seledtedCrs >= 0 Then
            Me._coursesList(Me._seledtedCrs).deleteSelectedWP()
        End If
    End Sub
    ''' <summary>
    ''' Delete selected course
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub deleteSelectedCrs()
        If Me._seledtedCrs >= 0 Then
            _coursesList.RemoveAt(_seledtedCrs)
            Me.RecalcCoursesID()
            clsWaypoint.forceUnselect()
            clsCourse.forceUnselect()
        End If
    End Sub
    ''' <summary>
    ''' Move course UP in list
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub moveCourseUp(ByVal id As Integer)
        If id > 1 Then
            Dim selCrs As clsCourse
            selCrs = _coursesList(id - 1)
            _coursesList.Remove(selCrs)
            _coursesList.Insert(id - 2, selCrs)
            Me.RecalcCoursesID()
        End If
    End Sub
    ''' <summary>
    ''' Move course DOWN in list
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub moveCourseDown(ByVal id As Integer)
        If id < _coursesList.Count Then
            Dim selCrs As clsCourse
            selCrs = _coursesList(id - 1)
            _coursesList.Remove(selCrs)
            _coursesList.Insert(id, selCrs)
            Me.RecalcCoursesID()
        End If
    End Sub
    ''' <summary>
    ''' Recalculate IDs of courses in list based on their position in list
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RecalcCoursesID()
        'Commented to avoid courses Id recalculation
        'For idx = 1 To _coursesList.Count
        '    _coursesList(idx - 1).id = idx
        'Next
    End Sub
    ''' <summary>
    ''' Insert waypoint before selected WP in selected course
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub insertBeforeWP()
        If Me._seledtedCrs >= 0 Then
            Me._coursesList(Me._seledtedCrs).insertBeforeWP()
        End If
    End Sub
    ''' <summary>
    ''' Append waypoint to selected course
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub appendWP()
        If Me._seledtedCrs >= 0 Then
            Me._coursesList(Me._seledtedCrs).appendWP()
        End If
    End Sub
    ''' <summary>
    ''' Destructor
    ''' </summary>
    ''' <remarks></remarks>
    Protected Overrides Sub Finalize()
        RemoveHandler clsWaypoint.SelectionChanged, AddressOf Me.selectedChangeHandler
        MyBase.Finalize()
    End Sub
    ''' <summary>
    ''' Save courses to XML file
    ''' </summary>
    ''' <param name="root">byref xelement node</param>
    ''' <remarks></remarks>
    Public Sub SaveXML(ByRef root As XElement)

        Dim courses As XElement

        courses = New XElement("courses")
        For Each crs In _coursesList
            courses.Add(crs.getXML)
        Next
        root.Add(courses)



    End Sub
    ''' <summary>
    ''' Create new course
    ''' </summary>
    ''' <param name="point">Starting point</param>
    ''' <remarks></remarks>
    Public Sub addCourse(ByVal point As PointF)
        'Attention, new course ID must be lastcourse+1 instead count + 1
        Dim lastcourse As Integer
        If _coursesList.Count = 0 Then lastcourse = 0 Else lastcourse = _coursesList(_coursesList.Count - 1).id
        Dim crs As New clsCourse("course " & lastcourse + 1, lastcourse + 1)
        crs.initWPforNewCourse(point)
        _coursesList.Add(crs)
        Me._seledtedCrs = _coursesList.Count - 1
    End Sub

    ''' <summary>
    ''' Calculate angles(directions) for selected waypoint
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function calculateAngleSelWP() As Double
        If Me._seledtedCrs < 0 Then Return 0
        Return _coursesList(_seledtedCrs).calculateAngleSelWP
    End Function
    ''' <summary>
    ''' Calculate angles(directions) for all waypoints in selected course
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub calculateAngleAllWP()
        If Me._seledtedCrs < 0 Then Exit Sub
        _coursesList(_seledtedCrs).calculateAngleAllWP()
    End Sub
    ''' <summary>
    ''' Fill waypoints between selected and previous WP in course
    ''' </summary>
    ''' <param name="range"></param>
    ''' <remarks></remarks>
    Public Sub fillBeforeSelected(ByVal range As Integer)
        If Me._seledtedCrs < 0 Then Exit Sub
        _coursesList(_seledtedCrs).fillBeforeSelected(range)
    End Sub
End Class
