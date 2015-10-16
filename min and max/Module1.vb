
Module Module1

    Sub Main()
        Dim i, num As Integer
        Console.WriteLine("請輸入總個數:")
        num = Val(Console.ReadLine())
        Dim h(num - 1) As Integer
        'h 是 陣列
        For i = 0 To h.GetUpperBound(0)
            Console.Write("請輸入第{0}個數值:", (i + 1).ToString())
            h(i) = Val(Console.ReadLine())
        Next
        Console.WriteLine("最大數是{0}", GetMax(h).ToString())
        Console.WriteLine("最小數是{0}", GetMin(h).ToString())
        Console.ReadLine()

    End Sub
    Function GetMax(ByVal ParamArray h() As Integer) As Integer
        Dim max As Integer
        max = h(0)
        For i As Integer = 1 To h.Length - 1
            If h(i) > max Then
                max = h(i)
            End If
        Next
        Return max
    End Function
    Function GetMin(ByVal ParamArray h() As Integer) As Integer
        Dim min As Integer
        min = h(0)
        For i As Integer = 1 To h.Length - 1
            If h(i) < min Then
                min = h(i)
            End If
        Next
        Return min
    End Function
End Module
