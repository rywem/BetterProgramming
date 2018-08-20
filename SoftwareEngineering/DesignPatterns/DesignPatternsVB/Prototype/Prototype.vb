Imports System.Console
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Imports DesignPatternsVB


Module ExtensionMethods
    <Extension()>
    Public Function DeepCopySerializer(Of T)(self As T) As T
        Dim stream = New MemoryStream()
        Dim formatter = New BinaryFormatter()
        formatter.Serialize(stream, self)
        stream.Seek(0, SeekOrigin.Begin)
        Dim copy As Object = formatter.Deserialize(stream)
        stream.Close()
        Return CType(copy, T)
    End Function
    <Extension()>
    Public Function DeepCopyXML(Of T)(self As T) As T
        Using ms As New MemoryStream
            Dim ser = New XmlSerializer(GetType(T))
            ser.Serialize(ms, self)
            ms.Position = 0
            Return CType(ser.Deserialize(ms), T)
        End Using
    End Function
End Module

<Serializable()>
Public Class Person
    Public Property Names As String()
    Public Property Address As Address

    Public Sub New()

    End Sub

    Public Sub New(names As String(), address As Address)
        Me.Names = names
        Me.Address = address
    End Sub

    Public Sub New(other As Person)
        Me.Names = other.Names
        Me.Address = New Address(other.Address)
    End Sub

    Public Overrides Function ToString() As String
        Return $"{NameOf(Names)}: {String.Join(" ", Names)}, {NameOf(Address)} - {Address}"
    End Function
End Class
<Serializable()>
Public Class Address
    Public Property StreetName As String
    Public Property HouseNumber As Integer

    Public Sub New()

    End Sub

    Public Sub New(streetName As String, houseNumber As Integer)
        Me.StreetName = streetName
        Me.HouseNumber = houseNumber
    End Sub
    Public Overrides Function ToString() As String
        Return $"{NameOf(HouseNumber)} and {NameOf(StreetName)}: {HouseNumber} {StreetName}"
    End Function

    Public Sub New(other As Address)
        Me.StreetName = other.StreetName
        Me.HouseNumber = other.HouseNumber
    End Sub

    Public Function DeepCopy() As Address
        Return New Address(Me.StreetName, Me.HouseNumber)
    End Function
End Class

Public Class Prototype
    Public Sub Run()
        Dim sherlock = New Person()
        With sherlock
            sherlock.Names = New String() {"Sherlock", "Holmes"}
            sherlock.Address = New Address("Baker Street", 221)
        End With
        Dim watson = sherlock.DeepCopyXML()
        watson.Names(0) = "John"
        watson.Names(1) = "Watson"

        WriteLine(sherlock)
        WriteLine(watson)
    End Sub
End Class
