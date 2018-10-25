Public Class Sorting

    Delegate Function OperatorCompare(ByRef x1 As Integer, ByRef x2 As Integer) As Boolean

    Public Shared Sub InsertionSort(array() As Integer, ByVal parametrSort As Integer, ByRef countOfCompare As Integer)
        countOfCompare = 0
        Dim length As Integer
        length = array.Length
        Dim myOperator As OperatorCompare
        If parametrSort = 1 Then
            myOperator = New OperatorCompare(AddressOf Greater)
        Else
            myOperator = New OperatorCompare(AddressOf Less)
        End If
        Dim i, j, k, temp As Integer
        If length > 1 Then
            For i = 1 To length - 1
                For j = 0 To i - 1
                    countOfCompare += 1
                    If myOperator(array(i), array(j)) Then
                        Exit For
                    End If
                Next j
                temp = array(i)
                For k = i - 1 To j Step -1
                    array(k + 1) = array(k)
                Next k
                array(j) = temp
            Next i
        End If
    End Sub

    Public Shared Sub InsertionSortBinary(array() As Integer, ByVal parametrSort As Integer, ByRef countOfCompare As Integer)
        countOfCompare = 0
        Dim length As Integer
        length = array.Length
        Dim myOperator As OperatorCompare
        If parametrSort = 1 Then
            myOperator = New OperatorCompare(AddressOf Greater)
        Else
            myOperator = New OperatorCompare(AddressOf Less)
        End If
        Dim i, j, k, temp As Integer
        If length > 1 Then
            For i = 1 To length - 1
                Dim first, last As Integer
                first = 0
                last = i - 1
                While first < last
                    countOfCompare += 1
                    j = (first + last) / 2
                    If myOperator(array(j), array(i)) Then
                        last = j
                    ElseIf myOperator(array(i), array(j)) Then
                        first = j
                    Else
                        Exit While
                    End If
                End While
                temp = array(i)
                For k = i - 1 To j Step -1
                    array(k + 1) = array(k)
                Next k
                array(j) = temp
            Next i
        End If
    End Sub

    Private Shared Function Greater(ByRef x1 As Integer, ByRef x2 As Integer) As Boolean
        Return x1 > x2
    End Function

    Private Shared Function Less(ByRef x1 As Integer, ByRef x2 As Integer) As Boolean
        Return x1 < x2
    End Function

End Class