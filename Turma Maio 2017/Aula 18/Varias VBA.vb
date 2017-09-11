Public Function Cubooo(ByVal numero As Single)

Cubooo = numero ^ 3

End Function

'multiplica

Public Function UmVezesOOutro(num1 As Integer, num2 As Integer) As Double

UmVezesOOutro = num1 * num2

End Function

'cacula o imc

Public Function IMC(Peso As Double, Altura As Double)

IMC = Peso / (Altura * Altura)

End Function

'------------------------------------------
'inverte o texto

Function TextoRevertido(Texto) As String
Dim lista As Integer
Dim x As Integer
TextLen = Len(Texto)
For x = TextLen To 1 Step -1
TextoRevertido = TextoRevertido & Mid(Texto, x, 1)
Next x
End Function

'------------------------------------------
Function NOMEDIASEMANA(rng As Date)

NOMEDIASEMANA = Format(rng, "dddd")

End Function

'------------------------------------------
Function StatusNotaV2(nota)
    Select Case nota
    Case Is < 30:    StatusNotaV2 = "desqualificado"
    Case Is < 40:    StatusNotaV2 = "situação crítica"
    Case Is < 50:    StatusNotaV2 = "estado de alerta"
    Case Is < 60:    StatusNotaV2 = "sob monitoramento"
    Case Is < 70:    StatusNotaV2 = "aceitável"
    Case Is < 80:    StatusNotaV2 = "bom"
    Case Is < 90:    StatusNotaV2 = "muito bom"
    Case Else:       StatusNotaV2 = "excelente"
    End Select
End Function

'------------------------------------------
Private Sub Worksheet_Change(ByVal Target As Range)
         If Target.Column <= 10 And Target.Row <= 2000 Then
            Application.OnTime Now + TimeSerial(0, 0, 6), "Atualiza_TD"
        End If
End Sub
