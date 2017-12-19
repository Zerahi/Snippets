Dim x = 0
Dim z = 1
Dim y = Lists.Count - 1
If y > 0 Then
While x < y
  If CInt(Lists(x)) > CInt(Lists(z)) Then
    Dim tmp = Lists(z)
    Lists(z) = Lists(x)
    Lists(x) = tmp
    z = x + 1
  End If
  If z = y Then
    x += 1
    z = x
  End If
  z += 1
End While
