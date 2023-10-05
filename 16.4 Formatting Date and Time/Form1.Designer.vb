<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		TextBox1 = New TextBox()
		TextBox2 = New TextBox()
		TextBox3 = New TextBox()
		TextBox4 = New TextBox()
		TextBox5 = New TextBox()
		TextBox6 = New TextBox()
		TextBox7 = New TextBox()
		TextBox8 = New TextBox()
		Button1 = New Button()
		SuspendLayout()
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(120, 36)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 0
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(120, 121)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(150, 31)
		TextBox2.TabIndex = 0
		' 
		' TextBox3
		' 
		TextBox3.Location = New Point(120, 187)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(150, 31)
		TextBox3.TabIndex = 0
		' 
		' TextBox4
		' 
		TextBox4.Location = New Point(120, 254)
		TextBox4.Name = "TextBox4"
		TextBox4.Size = New Size(150, 31)
		TextBox4.TabIndex = 0
		' 
		' TextBox5
		' 
		TextBox5.Location = New Point(318, 36)
		TextBox5.Name = "TextBox5"
		TextBox5.Size = New Size(150, 31)
		TextBox5.TabIndex = 0
		' 
		' TextBox6
		' 
		TextBox6.Location = New Point(321, 121)
		TextBox6.Name = "TextBox6"
		TextBox6.Size = New Size(150, 31)
		TextBox6.TabIndex = 0
		' 
		' TextBox7
		' 
		TextBox7.Location = New Point(318, 187)
		TextBox7.Name = "TextBox7"
		TextBox7.Size = New Size(150, 31)
		TextBox7.TabIndex = 0
		' 
		' TextBox8
		' 
		TextBox8.Location = New Point(330, 254)
		TextBox8.Name = "TextBox8"
		TextBox8.Size = New Size(150, 31)
		TextBox8.TabIndex = 0
		' 
		' Button1
		' 
		Button1.Location = New Point(285, 371)
		Button1.Name = "Button1"
		Button1.Size = New Size(112, 34)
		Button1.TabIndex = 1
		Button1.Text = "Timer1"
		Button1.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(Button1)
		Controls.Add(TextBox8)
		Controls.Add(TextBox7)
		Controls.Add(TextBox6)
		Controls.Add(TextBox5)
		Controls.Add(TextBox4)
		Controls.Add(TextBox3)
		Controls.Add(TextBox2)
		Controls.Add(TextBox1)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents TextBox6 As TextBox
	Friend WithEvents TextBox7 As TextBox
	Friend WithEvents TextBox8 As TextBox
	Friend WithEvents Button1 As Button
End Class
