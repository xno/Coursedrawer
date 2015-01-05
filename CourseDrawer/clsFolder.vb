Imports System
Imports System.Xml
Imports System.IO
Imports System.Xml.XPath
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
    Private Function check_xml_entry(ByVal file As String, _
    ByVal xml_path As String, ByVal value_name As String) As String
        Dim return_value As String
        Try
            Dim xd As New XmlDocument()
            xd.Load(file)
            ' Find the node where the Person's attribute ID is 1 using its XPath.
            Dim nod As XmlNode = xd.SelectSingleNode(xml_path)
            If nod IsNot Nothing Then
                return_value = "True"
            Else
                return_value = "False"
            End If
            xd.Save(file)
        Catch ex As Exception
            return_value = ex.Message
        End Try
        Return return_value
    End Function
    ''' <summary>
    ''' Create XML of folder
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getXML() As XElement
        Dim f1 As New XElement("folder")
        Dim idx As Integer = 1
        f1.Add(New XAttribute("name", Me.Name))
        f1.Add(New XAttribute("id", Me.id.ToString))
        f1.Add(New XAttribute("parent", Me.parent.ToString))
        For Each folder As clsFolder In _folders
            f1.Add(folder.getXML())
        Next
        Return f1
    End Function
End Class
