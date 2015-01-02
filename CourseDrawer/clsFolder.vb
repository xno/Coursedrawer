Public Class clsFolder

    Friend folder As Object

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Shared Event SelectionChanged(ByRef course As clsFolder)
    Public Property Name As String
    Public Property id As Object
    Public Property parent As Object

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="Name">Course name</param>
    ''' <param name="id">Course ID</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Name As String, ByVal id As Integer)
        Me.Name = Name
        Me.id = id
        Me.parent = parent
    End Sub



End Class
