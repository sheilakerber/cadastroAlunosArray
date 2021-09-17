Public Class Form1
    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        'validar campo nome
        If (txtNome.Text = Nothing) Then
            MsgBox("O campo nome não foi preenchido.", MsgBoxStyle.Critical, "Por favor, verifique seus dados!")
            Exit Sub
        End If

        'validar campo cpf
        txtMskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        Dim cpf As String = txtMskCpf.Text

        If (cpf = Nothing) Then
            MsgBox("O campo CPF não foi preenchido.", MsgBoxStyle.Critical, "Por favor, verifique seus dados!")
            Exit Sub
        End If

        'validar campo sexo
        If (Not rbtnFem.Checked And Not rbtnMasc.Checked) Then
            MsgBox("O campo Sexo não foi preenchido.", MsgBoxStyle.Critical, "Por favor, verifique seus dados!")
            Exit Sub
        End If

        Dim sexo As String
        If (rbtnFem.Checked) Then
            sexo = rbtnFem.Text
        Else
            sexo = rbtnMasc.Text
        End If

        'criacao do array e apresentacao do resultado ao usuario
        Dim arrayDados As Object = {txtNome.Text, cpf, txtNascimento.Text, sexo}
        MsgBox("Dados cadastrados: " & vbCrLf & Join(arrayDados, ", "), MsgBoxStyle.Information, "Confirmação de cadastro")
    End Sub
End Class
