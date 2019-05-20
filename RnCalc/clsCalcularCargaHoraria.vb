Public Class clsCalcularCargaHoraria
  Public Function TimeToMinutes(ByVal s As String) As Double
    Try
      Dim strTime As String
      strTime = s.Trim(CType(" ", Char()))
      Dim strSplittedTime() As String = strTime.Split(CType(":", Char()))
      If CInt(strSplittedTime(0)) > 23 Or CInt(strSplittedTime(1)) > 59 Then
        Throw New InvalidExpressionException
      End If
      Dim dblMinutes As Double = (CDbl(strSplittedTime(0)) * 60) + CDbl(strSplittedTime(1))
      Return dblMinutes
    Catch e As Exception
      Throw e
    End Try
  End Function
  Public Function MinutesToTime(ByVal dblMinutes As Double) As String
    Try
      Dim strTimeDivided As String = CStr(Math.Round((dblMinutes / 60), 2))
      If CDbl(strTimeDivided) < 0 Then
        strTimeDivided = (CDbl(strTimeDivided) + 24).ToString
      End If
      Dim strSplittedTime() As String = strTimeDivided.Split(CType(",", Char()))
      Dim strTime As String = strSplittedTime(0)
      If CInt(strTime) > 23 Then
        strTime = (CInt(strTime) - 24).ToString
      End If
      If CInt(strTime) < 10 Then
        strTime = "0" & strTime
      End If
      If strSplittedTime.Length > 1 Then
        Dim dblTemp1 As Double = CDbl(strTimeDivided) - CDbl(strSplittedTime(0))
        Dim strTemp2 As String = IIf((Math.Round(dblTemp1 * 60, 0)) > 9, CStr(Math.Round(dblTemp1 * 60, 0)), "0" & CStr(Math.Round(dblTemp1 * 60, 0))).ToString
        strTime += ":" & strTemp2
      Else
        strTime += ":00"
      End If
      Return strTime
    Catch e As Exception
      Throw e
    End Try
  End Function

  Public Function TimeLoadReverse(v As Double, dblIntFixo As Double, dblCargaHoraria As Double) As String
    Throw New NotImplementedException()
  End Function

  Public Function TimeLoad(v As Double, dblIntFixo As Double, dblCargaHoraria As Double) As String
    Throw New NotImplementedException()
  End Function

  Public Function ConvertDownTime(ByVal dblTime As Double) As Double
    Return (dblTime / 60) * 52.5
  End Function
  Public Function ConvertUpTime(ByVal dblTime As Double) As Double
    Return (dblTime / 52.5) * 60
  End Function
  Public Function BreakTime(ByVal strBkIn As String, ByVal strBkOut As String) As Double
    Dim dblBkOut As Double = TimeToMinutes(strBkOut)
    Dim dblBkIn As Double = TimeToMinutes(strBkIn)
    If dblBkOut < 60 Then
      dblBkOut += 1440
    End If
    Try
      Return dblBkOut - dblBkIn
    Catch e As Exception
      Throw e
    End Try
  End Function
  Public Function InvalidBreakTime(ByVal dblBkTime As Double) As Boolean
    Return dblBkTime > 180 OrElse dblBkTime < 60
  End Function
  Public Function TimeBefore5AM(ByVal dblTime As Double) As Double
    Return 300 - dblTime
  End Function
  Public Function TimeAfter5AM(ByVal dblTime As Double) As Double
    Return dblTime - 300
  End Function
  Public Function TimeAfter22(ByVal dblTime As Double) As Double
    Return dblTime - 1320
  End Function
  Public Function TimeBefore22(ByVal dblTime As Double) As Double
    Return 1320 - dblTime
  End Function









End Class
