Imports System
Imports System.Xml
Imports System.IO
Imports System.Xml.XPath
Module Module1
    ' Private Functions List..... This is were the magic happens =P
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
    Private Function Check_Att(ByVal file As String, _
    ByVal xpath As String, ByVal value_name As String, ByVal att_name As String) As String
        Dim return_value As String
        Try
            Dim xd As New XmlDocument
            xd.Load(file)
            Dim nod As XmlNode = xd.SelectSingleNode(xpath & "/" _
            & value_name & "[@" & att_name & "]")
            If nod IsNot Nothing Then
                return_value = "True"
            Else
                return_value = "False"
            End If
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
    Private Function Create_New_XML(ByVal nFile As String, _
    ByVal xml_path As String, ByVal value_name As String, _
    ByVal value As String, ByVal att_name As String, ByVal att_value As String) As String
        Dim return_value As String
        Try
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            settings.Encoding = System.Text.Encoding.UTF8
            Dim a, b, c, d As String
            Dim XmlWrt As XmlWriter = XmlWriter.Create(nFile, settings)
            With XmlWrt
                .WriteStartDocument()
                .WriteComment("XML Document Constructed on " & _
                DateTime.Now.Date & "/" & DateTime.Now.Month & "/" & DateTime.Now.Year)
                .WriteComment("Basic XML File. Create with Code from Dool Cookies")
                .WriteComment("From www.CodeProject.com")
                a = xml_path.Trim("/")
                b = a & "/" & value_name
                For Each t As String In b.Split("/")
                    .WriteStartElement(t)
                Next
                If String.IsNullOrEmpty(att_name) = False Then
                    .WriteAttributeString(att_name, att_value)
                End If
                .WriteString(value)
                .WriteFullEndElement()
                .WriteEndDocument()
                .Close()
                return_value = True
            End With
        Catch ex As Exception
            return_value = ex.Message
        End Try
        Return return_value
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
    Private Function Edit_XML_Entry(ByVal file As String, _
    ByVal xml_path As String, ByVal Value_Name As String, _
    ByVal Value As String) As String
        Dim return_value As String
        Dim xd As New XmlDocument()
        xd.Load(file)
        Dim nod As XmlNode = xd.SelectSingleNode(xml_path & "/" & Value_Name)
        If nod IsNot Nothing Then
            nod.InnerXml = Value
            return_value = "True"
        Else
            return_value = "Dool_Cookies"
        End If
        xd.Save(file)
        Return return_value
    End Function
    Private Function add_xml_att(ByVal file As String, _
    ByVal xml_path As String, ByVal value_name As String, _
    ByVal att_name As String, ByVal att_value As String) As String
        Dim return_value As String
        Try
            Dim document As New Xml.XmlDocument
            document.Load(file)
            Dim nav As Xml.XPath.XPathNavigator = document.CreateNavigator
            nav = nav.SelectSingleNode(xml_path & "/" & value_name)
            nav.CreateAttribute(Nothing, att_name, Nothing, att_value)
            document.Save(file)
            return_value = "True"
        Catch ex As Exception
            return_value = ex.Message
        End Try
        Return return_value
    End Function
    Private Function update_att(ByVal file As String, _
    ByVal xml_path As String, ByVal value_name As String, _
    ByVal att_name As String, ByVal att_value As String) As String
        Dim return_value As String
        Dim xd As New XmlDocument()
        xd.Load(file)
        Dim nod As XmlNode = xd.SelectSingleNode(xml_path & "/" & value_name & "[@" & att_name & "]")
        If nod IsNot Nothing Then
            nod.Attributes.GetNamedItem(att_name).Value = att_value
            return_value = "True"
        Else
            MsgBox("Opps")
        End If
        xd.Save(file)
        Return return_value
    End Function
    Private Function Get_ATT(ByVal file As String, _
    ByVal xml_path As String, ByVal value_name As String, _
    ByVal att_name As String) As String
        Dim return_value As String
        Try
            Dim a As String
            Dim xd As New XmlDocument
            xd.Load(file)
            Dim nod As XmlNode = xd.SelectSingleNode(xml_path & "/" & value_name & "[@" & att_name & "]")
            If nod IsNot Nothing Then
                a = nod.Attributes.GetNamedItem(att_name).Value
                return_value = a
            Else
                return_value = Nothing
            End If
            xd.Save(file)
        Catch ex As Exception
            return_value = ex.Message
        End Try
        Return return_value
    End Function
    Private Function Get_Val(ByVal file As String, _
    ByVal xml_path As String, ByVal value_name As String) As String
        Dim return_value As String
        Try
            Dim a As String
            Dim xd As New XmlDocument
            xd.Load(File)
            Dim nod As XmlNode = xd.SelectSingleNode(xml_path & "/" & value_name)
            If nod IsNot Nothing Then
                a = nod.InnerXml
                return_value = a
            Else
                return_value = Nothing
            End If
            xd.Save(file)
        Catch ex As Exception
            return_value = ex.Message
        End Try
        Return return_value

    End Function
    Private Function delete_Element(ByVal file As String, _
    ByVal xml_path As String, ByVal value_name As String) As String
        Dim return_value As String
        Try
            Dim document As New Xml.XmlDocument
            document.Load(file)
            Dim nav As Xml.XPath.XPathNavigator = document.CreateNavigator
            nav = nav.SelectSingleNode(xml_path & "/" & value_name)
            nav.DeleteSelf()
            document.Save(file)
            return_value = "True"
        Catch ex As Exception
            return_value = ex.Message
        End Try
        Return return_value
    End Function
    Private Function delete_tree(ByVal file As String, _
    ByVal xml_path As String) As String
        Dim return_value As String
        Try
            Dim document As New Xml.XmlDocument
            document.Load(file)
            Dim nav As Xml.XPath.XPathNavigator = document.CreateNavigator
            nav = nav.SelectSingleNode(xml_path)
            nav.DeleteSelf()
            document.Save(file)
            return_value = "True"
        Catch ex As Exception
            return_value = ex.Message
        End Try
        Return return_value
    End Function
    Private Function create_tree(ByVal file As String, _
    ByVal start_at As String, ByVal add_these As String) As String
        Dim return_value As String
        Dim a, b, c, d As String
        Try
            Dim document As New Xml.XmlDocument
            document.Load(file)
            Dim nav As Xml.XPath.XPathNavigator = document.CreateNavigator
            nav = nav.SelectSingleNode(start_at)
            a = add_these.Trim("/")
            b = start_at
            For Each t As String In a.Split("/")
                b = b & "/" & t
                nav.AppendChildElement(Nothing, t, Nothing, "")
                nav = nav.SelectSingleNode(b)
            Next
            document.Save(file)
            return_value = "True"
        Catch ex As Exception
            return_value = ex.Message
        End Try
        Return return_value
    End Function
    Private Function dool_cookies(ByVal file As String, _
    ByVal xml_path As String, ByVal value_name As String, _
    ByVal value As String) As String
        Dim return_value As String
        Try
            Dim dool As New XmlDocument
            dool.Load(file)
            Dim nav As Xml.XPath.XPathNavigator = dool.CreateNavigator
            nav = nav.SelectSingleNode(xml_path)
            nav.AppendChildElement(Nothing, value_name, Nothing, value)
            dool.Save(file)
            return_value = "True"
        Catch ex As Exception
            return_value = ex.Message
        End Try
        Return return_value
    End Function

End Module
