Imports System.Console

Module Program
    Sub Main()
        Dim age As Integer
        WriteLine("enter your age ")
        age = ReadLine()
        If age > 18 And age < 85 Then
            WriteLine("allowed to drive")
        Else
            WriteLine("not allowed to drive")

        End If
        ReadKey()
    End Sub
End Module
