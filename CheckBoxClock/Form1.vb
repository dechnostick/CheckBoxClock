Imports System.Threading.Thread

Public Class Form1

    Private c(27, 5) As CheckBox
    Private colon As Boolean = False

    Private Sub T(ByVal c As CheckBox)
        c.Visible = True
        c.Checked = True
    End Sub

    Private Sub I(ByVal c As CheckBox)
        'c.Visible = True
        'c.Checked = True
        'c.CheckState = CheckState.Indeterminate
        c.Visible = True
        c.Checked = False
    End Sub

    Private Sub F(ByVal c As CheckBox)
        c.Visible = False
        c.Checked = False
    End Sub

    Private Sub colonA(ByVal o As Integer)
        F(c(0 + o, 0)) : F(c(1 + o, 0)) : F(c(2 + o, 0)) 'Å†Å†Å†
        F(c(0 + o, 1)) : I(c(1 + o, 1)) : F(c(2 + o, 1)) 'Å†Å°Å†
        F(c(0 + o, 2)) : F(c(1 + o, 2)) : F(c(2 + o, 2)) 'Å†Å†Å†
        F(c(0 + o, 3)) : I(c(1 + o, 3)) : F(c(2 + o, 3)) 'Å†Å°Å†
        F(c(0 + o, 4)) : F(c(1 + o, 4)) : F(c(2 + o, 4)) 'Å†Å†Å†
    End Sub

    Private Sub colonB(ByVal o As Integer)
        F(c(0 + o, 0)) : F(c(1 + o, 0)) : F(c(2 + o, 0)) 'Å†Å†Å†
        F(c(0 + o, 1)) : F(c(1 + o, 1)) : F(c(2 + o, 1)) 'Å†Å†Å†
        F(c(0 + o, 2)) : F(c(1 + o, 2)) : F(c(2 + o, 2)) 'Å†Å†Å†
        F(c(0 + o, 3)) : F(c(1 + o, 3)) : F(c(2 + o, 3)) 'Å†Å†Å†
        F(c(0 + o, 4)) : F(c(1 + o, 4)) : F(c(2 + o, 4)) 'Å†Å†Å†
    End Sub

    Private Sub CC(ByVal o As Integer)
        F(c(0 + o, 0)) 'Å†
        F(c(0 + o, 1)) 'Å†
        F(c(0 + o, 2)) 'Å†
        F(c(0 + o, 3)) 'Å†
        F(c(0 + o, 4)) 'Å†
    End Sub

    Private Sub C0(ByVal o As Integer)
        T(c(0 + o, 0)) : T(c(1 + o, 0)) : T(c(2 + o, 0)) 'Å°Å°Å°
        T(c(0 + o, 1)) : F(c(1 + o, 1)) : T(c(2 + o, 1)) 'Å°Å†Å°
        T(c(0 + o, 2)) : F(c(1 + o, 2)) : T(c(2 + o, 2)) 'Å°Å†Å°
        T(c(0 + o, 3)) : F(c(1 + o, 3)) : T(c(2 + o, 3)) 'Å°Å†Å°
        T(c(0 + o, 4)) : T(c(1 + o, 4)) : T(c(2 + o, 4)) 'Å°Å°Å°
    End Sub

    Private Sub C1(ByVal o As Integer)
        F(c(0 + o, 0)) : F(c(1 + o, 0)) : T(c(2 + o, 0)) 'Å†Å†Å°
        F(c(0 + o, 1)) : F(c(1 + o, 1)) : T(c(2 + o, 1)) 'Å†Å†Å°
        F(c(0 + o, 2)) : F(c(1 + o, 2)) : T(c(2 + o, 2)) 'Å†Å†Å°
        F(c(0 + o, 3)) : F(c(1 + o, 3)) : T(c(2 + o, 3)) 'Å†Å†Å°
        F(c(0 + o, 4)) : F(c(1 + o, 4)) : T(c(2 + o, 4)) 'Å†Å†Å°
    End Sub

    Private Sub C2(ByVal o As Integer)
        T(c(0 + o, 0)) : T(c(1 + o, 0)) : T(c(2 + o, 0)) 'Å°Å°Å°
        F(c(0 + o, 1)) : F(c(1 + o, 1)) : T(c(2 + o, 1)) 'Å†Å†Å°
        T(c(0 + o, 2)) : T(c(1 + o, 2)) : T(c(2 + o, 2)) 'Å°Å°Å°
        T(c(0 + o, 3)) : F(c(1 + o, 3)) : F(c(2 + o, 3)) 'Å°Å†Å†
        T(c(0 + o, 4)) : T(c(1 + o, 4)) : T(c(2 + o, 4)) 'Å°Å°Å°
    End Sub

    Private Sub C3(ByVal o As Integer)
        T(c(0 + o, 0)) : T(c(1 + o, 0)) : T(c(2 + o, 0)) 'Å°Å°Å°
        F(c(0 + o, 1)) : F(c(1 + o, 1)) : T(c(2 + o, 1)) 'Å†Å†Å°
        T(c(0 + o, 2)) : T(c(1 + o, 2)) : T(c(2 + o, 2)) 'Å°Å°Å°
        F(c(0 + o, 3)) : F(c(1 + o, 3)) : T(c(2 + o, 3)) 'Å†Å†Å°
        T(c(0 + o, 4)) : T(c(1 + o, 4)) : T(c(2 + o, 4)) 'Å°Å°Å°
    End Sub

    Private Sub C4(ByVal o As Integer)
        T(c(0 + o, 0)) : F(c(1 + o, 0)) : T(c(2 + o, 0)) 'Å°Å†Å°
        T(c(0 + o, 1)) : F(c(1 + o, 1)) : T(c(2 + o, 1)) 'Å°Å†Å°
        T(c(0 + o, 2)) : T(c(1 + o, 2)) : T(c(2 + o, 2)) 'Å°Å°Å°
        F(c(0 + o, 3)) : F(c(1 + o, 3)) : T(c(2 + o, 3)) 'Å†Å†Å°
        F(c(0 + o, 4)) : F(c(1 + o, 4)) : T(c(2 + o, 4)) 'Å†Å†Å°
    End Sub

    Private Sub C5(ByVal o As Integer)
        T(c(0 + o, 0)) : T(c(1 + o, 0)) : T(c(2 + o, 0)) 'Å°Å°Å°
        T(c(0 + o, 1)) : F(c(1 + o, 1)) : F(c(2 + o, 1)) 'Å°Å†Å†
        T(c(0 + o, 2)) : T(c(1 + o, 2)) : T(c(2 + o, 2)) 'Å°Å°Å°
        F(c(0 + o, 3)) : F(c(1 + o, 3)) : T(c(2 + o, 3)) 'Å†Å†Å°
        T(c(0 + o, 4)) : T(c(1 + o, 4)) : T(c(2 + o, 4)) 'Å°Å°Å°
    End Sub

    Private Sub C6(ByVal o As Integer)
        T(c(0 + o, 0)) : T(c(1 + o, 0)) : T(c(2 + o, 0)) 'Å°Å°Å°
        T(c(0 + o, 1)) : F(c(1 + o, 1)) : F(c(2 + o, 1)) 'Å°Å†Å†
        T(c(0 + o, 2)) : T(c(1 + o, 2)) : T(c(2 + o, 2)) 'Å°Å°Å°
        T(c(0 + o, 3)) : F(c(1 + o, 3)) : T(c(2 + o, 3)) 'Å°Å†Å°
        T(c(0 + o, 4)) : T(c(1 + o, 4)) : T(c(2 + o, 4)) 'Å°Å°Å°
    End Sub

    Private Sub C7(ByVal o As Integer)
        T(c(0 + o, 0)) : T(c(1 + o, 0)) : T(c(2 + o, 0)) 'Å°Å°Å°
        F(c(0 + o, 1)) : F(c(1 + o, 1)) : T(c(2 + o, 1)) 'Å†Å†Å°
        F(c(0 + o, 2)) : F(c(1 + o, 2)) : T(c(2 + o, 2)) 'Å†Å†Å°
        F(c(0 + o, 3)) : F(c(1 + o, 3)) : T(c(2 + o, 3)) 'Å†Å†Å°
        F(c(0 + o, 4)) : F(c(1 + o, 4)) : T(c(2 + o, 4)) 'Å†Å†Å°
    End Sub

    Private Sub C8(ByVal o As Integer)
        T(c(0 + o, 0)) : T(c(1 + o, 0)) : T(c(2 + o, 0)) 'Å°Å°Å°
        T(c(0 + o, 1)) : F(c(1 + o, 1)) : T(c(2 + o, 1)) 'Å°Å†Å°
        T(c(0 + o, 2)) : T(c(1 + o, 2)) : T(c(2 + o, 2)) 'Å°Å°Å°
        T(c(0 + o, 3)) : F(c(1 + o, 3)) : T(c(2 + o, 3)) 'Å°Å†Å°
        T(c(0 + o, 4)) : T(c(1 + o, 4)) : T(c(2 + o, 4)) 'Å°Å°Å°
    End Sub

    Private Sub C9(ByVal o As Integer)
        T(c(0 + o, 0)) : T(c(1 + o, 0)) : T(c(2 + o, 0)) 'Å°Å°Å°
        T(c(0 + o, 1)) : F(c(1 + o, 1)) : T(c(2 + o, 1)) 'Å°Å†Å°
        T(c(0 + o, 2)) : T(c(1 + o, 2)) : T(c(2 + o, 2)) 'Å°Å°Å°
        F(c(0 + o, 3)) : F(c(1 + o, 3)) : T(c(2 + o, 3)) 'Å†Å†Å°
        T(c(0 + o, 4)) : T(c(1 + o, 4)) : T(c(2 + o, 4)) 'Å°Å°Å°
    End Sub

    Private Sub Cx(ByVal o As Integer)
        F(c(0 + o, 0)) : F(c(1 + o, 0)) : F(c(2 + o, 0)) 'Å†Å†Å†Å°
        F(c(0 + o, 1)) : F(c(1 + o, 1)) : F(c(2 + o, 1)) 'Å†Å†Å†
        F(c(0 + o, 2)) : F(c(1 + o, 2)) : F(c(2 + o, 2)) 'Å†Å†Å†
        F(c(0 + o, 3)) : F(c(1 + o, 3)) : F(c(2 + o, 3)) 'Å†Å†Å†
        F(c(0 + o, 4)) : F(c(1 + o, 4)) : F(c(2 + o, 4)) 'Å†Å†Å†
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For y As Integer = 0 To 5 - 1
            For x As Integer = 0 To 27 - 1

                c(x, y) = New CheckBox()
                c(x, y).Location = New System.Drawing.Point(x * 15, y * 14)
                c(x, y).Size = New System.Drawing.Size(15, 14)

                Me.Controls.Add(c(x, y))
            Next
        Next

        Me.Timer1.Interval = 1000
        Me.Timer1.Start()

        Me.Timer2.Interval = 500
        Me.Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim dt As String = DateTime.Now.ToString("HHmmss")
        Me.SetDigit(dt.Substring(0, 1), 0) : Me.SetDigit(dt.Substring(1, 1), 4)
        Me.SetDigit(dt.Substring(2, 1), 10) : Me.SetDigit(dt.Substring(3, 1), 14)
        Me.SetDigit(dt.Substring(4, 1), 20) : Me.SetDigit(dt.Substring(5, 1), 24)
        Me.CC(3) : Me.CC(13) : Me.CC(23)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If Me.colon Then
            Me.colonA(7) : Me.colonA(17)
            Me.colon = False
        Else
            Me.colonB(7) : Me.colonB(17)
            Me.colon = True
        End If
    End Sub

    Private Sub SetDigit(ByVal d As String, ByVal o As Integer)

        Select Case d
            Case "0" : Me.C0(o)
            Case "1" : Me.C1(o)
            Case "2" : Me.C2(o)
            Case "3" : Me.C3(o)
            Case "4" : Me.C4(o)
            Case "5" : Me.C5(o)
            Case "6" : Me.C6(o)
            Case "7" : Me.C7(o)
            Case "8" : Me.C8(o)
            Case "9" : Me.C9(o)
        End Select
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
        End If
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Visible = True
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Activate()
    End Sub

    Private Sub èIóπToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles èIóπToolStripMenuItem.Click

        Me.Timer1.Stop()
        Me.Timer2.Stop()

        Me.NotifyIcon1.Visible = False
        Application.Exit()
    End Sub
End Class
