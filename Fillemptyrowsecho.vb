If selectionbox.selected index = 0 Then
        Dim None = True
            For i = 1 To column.max()
                For j = 2 To maxtimerow 'get from time set funct (2 offset for )
                    If None = True Then
                        If Arr(i, j) <> Nothing Then
                            None = False
                        End If
                    Else
                        If Arr(i, j) = Nothing Then
                            Arr(i, j) = Arr(i, j - 1)
                        End If
                    End If
                Next
            Next
        End If
