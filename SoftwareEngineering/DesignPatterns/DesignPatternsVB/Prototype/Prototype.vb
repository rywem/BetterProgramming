Imports System.Console
Imports DesignPatternsVB

Public Interface IPrototype(Of T)
    Function DeepCopy() As T
End Interface
Public Class Person
    Implements IPrototype(Of Person)

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

    Public Function DeepCopy() As Person Implements IPrototype(Of Person).DeepCopy
        Return New Person(Names, Address.DeepCopy())
    End Function
End Class

Public Class Address
    Implements IPrototype(Of Address)
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

    Public Function DeepCopy() As Address Implements IPrototype(Of Address).DeepCopy
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
        Dim watson = New Person(sherlock)
        watson.Names(0) = "Watson"
        WriteLine(sherlock)
        WriteLine(watson)
    End Sub
End Class
