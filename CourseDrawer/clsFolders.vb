''' <summary>
''' Class for collection of folders
''' </summary>
''' <remarks>Singleton class for wrapping folders</remarks>
Public Class clsFolders
    Private _folders As List(Of clsFolder)
    Private _seledtedCrs As Integer
    Dim Hidden As Boolean

    Public ReadOnly Property Count As Integer
        Get
            Return _folders.Count
        End Get
    End Property
    Private Shared _instance As clsFolders
    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub New()
        _folders = New List(Of clsFolder)
    End Sub
    ''' <summary>
    ''' Get instance of singleton class
    ''' </summary>
    ''' <param name="forceNew">force create new instance</param>
    ''' <returns>Instance of courses collection</returns>
    ''' <remarks></remarks>
    Public Shared Function getInstance(Optional ByVal forceNew As Boolean = False) As clsFolders
        If _instance Is Nothing Or forceNew = True Then
            _instance = New clsFolders
        End If
        Return _instance
    End Function
    ''' <summary>
    ''' Get list of course name and hidden attribute
    ''' </summary>
    ''' <value></value>
    ''' <returns>Dictionary of course names and hidden attribute</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FolderList As Dictionary(Of String, Boolean)
        Get
            Dim dir As New Dictionary(Of String, Boolean)
            For Each crs As clsFolder In _folders
                dir.Add(crs.parent.ToString & " : " & crs.Name, Not Hidden)
            Next
            Return dir
        End Get
    End Property
End Class
