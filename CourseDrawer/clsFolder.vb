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
    Private Function add_to_xml(ByVal file As String, _
    ByVal xml_path As String, ByVal value_name As String, _
    ByVal value As String) As String
        Dim return_value As String
        Try
            Dim cr As String = Environment.NewLine
            Dim dool As String
            dool = Out_xml_from_xml_path(xml_path, value_name, value, Nothing, Nothing)
            Dim xd As New XmlDocument()
            xd.Load(file)
            Dim docFrag As XmlDocumentFragment = xd.CreateDocumentFragment()
            docFrag.InnerXml = dool
            Dim root As XmlNode = xd.DocumentElement
            root.AppendChild(docFrag)
            xd.Save(file)
            return_value = "True"
        Catch ex As Exception
            return_value = ex.Message
        End Try
        Return return_value
    End Function

    Private Function Out_xml_from_xml_path(ByVal xml_path As String, _
   ByVal value_name As String, ByVal value As String, _
   ByVal att_name As String, ByVal att_value As String) As String
        Dim return_value As String
        Dim a, b, c, d As String
        Dim x, y, z As Integer
        Dim master As String
        Dim buffer As String
        If String.IsNullOrEmpty(att_name) = False Then
            master = "<" & value_name & " " & att_name & "=" & _
            Chr(34) & att_value & Chr(34) & ">" & value & "</" & value_name & ">"
        Else
            master = "<" & value_name & ">" & value & "</" & value_name & ">"
        End If
        a = xml_path.Trim("/")
        x = a.IndexOf("/")
        If x < 1 Then ' Is Root
            return_value = master
            GoTo 1
        End If
        b = a.Remove(0, x + 1)
        d = b
        Do
            x = d.LastIndexOf("/")
            If x < 1 Then ' Is Last Key
                master = "<" & d & ">" & master & "</" & d & ">"
                return_value = master
                Exit Do
            End If
            b = d.Remove(0, x + 1) ' that is without /
            c = d.Remove(0, x) ' that is with /
            master = "<" & b & ">" & master & "</" & b & ">"
            a = d.Replace(c, "")
            d = a
        Loop
1:
        Return master
    End Function

End Class
