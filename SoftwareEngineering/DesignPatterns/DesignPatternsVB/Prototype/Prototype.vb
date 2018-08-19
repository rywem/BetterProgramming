Imports System.Console
Public Class Person
    Public Property Names As String()
    Public Property Address As Address

    Public Sub New()

    End Sub

    Public Sub New(names As String(), address As Address)
        Me.Names = names
        Me.Address = address
    End Sub

    Public Overrides Function ToString() As String
        Return $"{NameOf(Names)}: {String.Join(" ", Names)}, {NameOf(Address)} - {Address}"
    End Function
End Class

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
End Class

Public Class Prototype
    Public Sub Run()
        Dim sherlock = New Person()
        With sherlock
            sherlock.Names = New String() {"Sherlock", "Holmes"}
            sherlock.Address = New Address("Baker Street", 221)
        End With
        WriteLine(sherlock)
    End Sub
End Class
