Option Explicit On
Imports DesignPatternsVB
Imports System.IO
Imports MoreLinq

Namespace Singleton
    Public Interface IDatabase
        Function GetPopulation(name As String) As Integer
    End Interface
    Public Class SingletonDatabase
        Implements IDatabase

        Dim capitals As Dictionary(Of String, Integer)
        Public Sub New()
            Console.WriteLine("Initializing Database")

            ' LINQ... As C#:
            ' capitals = File.ReadAllLines("capitals.txt")
            '               .Batch(2)
            '               .ToDictionary(list => list.ElementAt(0).Trim(), list => int.Parse(list.ElementAt(1)));

            ' LINQ... As VB
            Dim capitals = File.ReadAllLines("capitals.txt") _
                            .Batch(2) _
                            .ToDictionary(Function(list) list.ElementAt(0).Trim(), Function(list) Integer.Parse(list.ElementAt(1)))
        End Sub

        Public Function GetPopulation(name As String) As Integer Implements IDatabase.GetPopulation
            Return capitals(name)
        End Function
    End Class

    Public Class Singleton
        Public Sub Run()
            Dim db = New SingletonDatabase()
            Dim info = db.GetPopulation("Tokyo")
        End Sub
    End Class
End Namespace