''' <summary>
''' Class for collection of folders
''' </summary>
''' <remarks>Singleton class for wrapping folders</remarks>
Public Class clsSettings
    Dim CPF As Object
    Dim CPH As Object
    Dim CPW As Object
    Dim CPI As Object
    Dim CPM As Object
    Public Property posX As String
    Public Property posY As String
    Public Property automaticScan As Boolean
    Public Property onlyScanOwnedFields As Boolean
    Public Property debugScannedFields As Boolean
    Public Property debugCustomLoadedFields As Boolean
    Public Property scanStep As String
    Public Property active As Boolean
    Public Property wagePerHour As String
    Public Property showName As Boolean
    Public Property showCourse As Boolean
    Public Property batchWriteSize As String

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ReadXML(ByVal file As String)
        Dim xmlDoc As New Xml.XmlDocument()
        Dim xmlNode As Xml.XmlNode
        Dim xmlNodeReader As Xml.XmlNodeReader
        If file = String.Empty Then Exit Sub
        xmlDoc.Load(file)
        If xmlDoc Is Nothing Then Exit Sub
        xmlNode = xmlDoc.DocumentElement.SelectSingleNode("courseplayHud")
        If xmlNode Is Nothing Then Exit Sub
        xmlNodeReader = New Xml.XmlNodeReader(xmlNode)
        While xmlNodeReader.MoveToNextAttribute
            Select Case xmlNodeReader.LocalName
                Case "posX"
                    Integer.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, CPH.posX)
                Case "posY"
                    Integer.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, CPH.posY)
            End Select
        End While
        If xmlNodeReader.LocalName = "courseplayFields" Then
            xmlNodeReader = New Xml.XmlNodeReader(xmlNode)
            While xmlNodeReader.MoveToNextAttribute
                Select Case xmlNodeReader.LocalName
                    Case "automaticScan"
                        CPF.automaticscan = xmlNodeReader.ReadElementContentAsBoolean
                    Case "onlyScanOwnedFields"
                        CPF.onlyScanOwnedFields = xmlNodeReader.ReadElementContentAsBoolean
                    Case "debugScannedFields"
                        CPF.debugScannedFields = xmlNodeReader.ReadElementContentAsBoolean
                    Case "debugCustomLoadedFields"
                        CPF.debugCustomLoadedFields = xmlNodeReader.ReadElementContentAsBoolean
                    Case "scanStep"
                        Integer.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, CPF.scanStep)
                End Select
            End While
        else If xmlNodeReader.LocalName = "courseplayWages" Then
        xmlNodeReader = New Xml.XmlNodeReader(xmlNode)
        While xmlNodeReader.MoveToNextAttribute
            Select Case xmlNodeReader.LocalName
                Case "active"
                        CPW.active = xmlNodeReader.ReadElementContentAsBoolean
                Case "wagePerHour"
                    Integer.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, CPW.wagePerHour)
            End Select
        End While
        else If xmlNodeReader.LocalName = "courseplayIngameMap" Then
        xmlNodeReader = New Xml.XmlNodeReader(xmlNode)
        While xmlNodeReader.MoveToNextAttribute
            Select Case xmlNodeReader.LocalName
                Case "active"
                        CPI.active = xmlNodeReader.ReadElementContentAsBoolean
                    Case "showName"
                        CPI.showName = xmlNodeReader.ReadElementContentAsBoolean
                    Case "showCourse"
                        CPI.showCourse = xmlNodeReader.ReadElementContentAsBoolean
                End Select
        End While
            else If xmlNodeReader.LocalName = "courseManagement" Then
        xmlNodeReader = New Xml.XmlNodeReader(xmlNode)
        While xmlNodeReader.MoveToNextAttribute
            Select Case xmlNodeReader.LocalName
                Case "batchWriteSize"
                    Integer.TryParse(xmlNodeReader.Value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, CPM.batchWriteSize)
            End Select
        End While
        End If
    End Sub
End Class
