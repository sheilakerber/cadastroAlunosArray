<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnMasc = New System.Windows.Forms.RadioButton()
        Me.rbtnFem = New System.Windows.Forms.RadioButton()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtMskCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtNascimento = New System.Windows.Forms.DateTimePicker()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CPF:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nascimento:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnMasc)
        Me.GroupBox1.Controls.Add(Me.rbtnFem)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 75)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo:"
        '
        'rbtnMasc
        '
        Me.rbtnMasc.AutoSize = True
        Me.rbtnMasc.Location = New System.Drawing.Point(114, 33)
        Me.rbtnMasc.Name = "rbtnMasc"
        Me.rbtnMasc.Size = New System.Drawing.Size(73, 17)
        Me.rbtnMasc.TabIndex = 1
        Me.rbtnMasc.Text = "Masculino"
        Me.rbtnMasc.UseVisualStyleBackColor = True
        '
        'rbtnFem
        '
        Me.rbtnFem.AutoSize = True
        Me.rbtnFem.Checked = True
        Me.rbtnFem.Location = New System.Drawing.Point(20, 33)
        Me.rbtnFem.Name = "rbtnFem"
        Me.rbtnFem.Size = New System.Drawing.Size(67, 17)
        Me.rbtnFem.TabIndex = 0
        Me.rbtnFem.TabStop = True
        Me.rbtnFem.Text = "Feminino"
        Me.rbtnFem.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(80, 32)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(166, 20)
        Me.txtNome.TabIndex = 4
        '
        'txtMskCpf
        '
        Me.txtMskCpf.Location = New System.Drawing.Point(80, 67)
        Me.txtMskCpf.Mask = "000-000-000-00"
        Me.txtMskCpf.Name = "txtMskCpf"
        Me.txtMskCpf.Size = New System.Drawing.Size(166, 20)
        Me.txtMskCpf.TabIndex = 5
        '
        'txtNascimento
        '
        Me.txtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtNascimento.Location = New System.Drawing.Point(99, 105)
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.Size = New System.Drawing.Size(147, 20)
        Me.txtNascimento.TabIndex = 6
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(30, 223)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(216, 34)
        Me.btnCadastrar.TabIndex = 7
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 278)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.txtNascimento)
        Me.Controls.Add(Me.txtMskCpf)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Cadastro de Alunos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnMasc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFem As System.Windows.Forms.RadioButton
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtMskCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNascimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button

End Class
