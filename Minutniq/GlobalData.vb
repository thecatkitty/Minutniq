Module GlobalData
    Class Centytime
        Public t As New Integer

        Public ReadOnly Property s As Integer
            Get
                Return t Mod 60
            End Get
        End Property
        Public ReadOnly Property m As Integer
            Get
                Return (t \ 60) Mod 60
            End Get
        End Property
        Public ReadOnly Property h As Integer
            Get
                Return t \ 3600
            End Get
        End Property
    End Class

    Public Time As New Centytime
    Public Left As New Centytime

    Public Function ToString() As String
        Return String.Format("{0}:{1,2:00}:{2,2:00}", Left.h, Left.m, Left.s)
    End Function

    Public Function Backtick() As Boolean
        If Left.t = 0 Then
            Return False
        End If

        Left.t -= 1
        Return True
    End Function

    Public Sub Reset()
        Left.t = Time.t
    End Sub
End Module
