Public Class clsFolder
    Private _folders As List(Of clsFolder)

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Shared Event SelectionChanged(ByRef folder As clsFolder)
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
    Public Sub ReadXML(ByVal file As String)
        Dim xmlDoc As New Xml.XmlDocument()
        Dim xmlNode As Xml.XmlNode
        Dim xmlNodeReader As Xml.XmlNodeReader
        Dim folder As New clsFolder
        Dim stringA() As String
        If file = String.Empty Then Exit Sub
        xmlDoc.Load(file)
        If xmlDoc Is Nothing Then Exit Sub
        xmlNode = xmlDoc.DocumentElement.SelectSingleNode("folders")
        xmlNodeReader = New Xml.XmlNodeReader(xmlNode)
        Do While (xmlNodeReader.Read())
            Select Case xmlNodeReader.NodeType
                Case Xml.XmlNodeType.Element
                    If xmlNodeReader.LocalName = "folder" Then
                        folder = New clsFolder
                        _folders.Add(folder)
                        While xmlNodeReader.MoveToNextAttribute
                            Select Case xmlNodeReader.LocalName
                                Case "name"
                                    folder.Name = xmlNodeReader.Value
                                Case "id"
                                    Integer.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, folder.id)
                                Case "parent"
                                    Integer.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, folder.parent)
                            End Select
                        End While
                    End If
            End Select
        Loop
    End Sub
    ''' <summary>
    ''' Create XML of folder
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getXML() As XElement
        Dim e1 As New XElement("folder")
        Dim idx As Integer = 1
        e1.Add(New XAttribute("name", Me.Name))
        e1.Add(New XAttribute("id", Me.id.ToString))
        e1.Add(New XAttribute("parent", Me.parent.ToString))
        For Each folder As clsFolder In _folders
            e1.Add(folder.getXML())
        Next
        Return e1
    End Function
End Class
