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

        'validar campo sexo utilizando o short if
        Dim sexo As String = IIf(rbtnFem.Checked, "Feminino", "Masculino")

        'criacao do array e apresentacao do resultado ao usuario
        Dim arrayDados As Object = {txtNome.Text, cpf, txtNascimento.Text, sexo}
        MsgBox("Nome: " & arrayDados(0) _
             & " - CPF: " & arrayDados(1) _
             & " - Nascimento: " & arrayDados(2) _
             & " - Sexo: " & arrayDados(3))
    End Sub
End Class
