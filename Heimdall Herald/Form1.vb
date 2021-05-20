Imports System.ComponentModel
Imports System.IO
Public Class heimdall_herald
    Dim path As String
    Dim count As Integer = 15
    Dim config As String

    Dim data As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim location As String = System.Environment.GetCommandLineArgs()(0)
        Dim appName As String = System.IO.Path.GetFileName(location)
        path = AppDomain.CurrentDomain.BaseDirectory + appName.ToString

        Try
            data = Command()
            config = data 'config_class



            If data.Contains("herald:") Then

                config = config.Split(":")(1)
                config_class.Text = "Heimdall #~~>>  " + config.ToString 'data_config_class 

            Else
                config_class.Text = "Heimdall #~~>> Mesaj alınamadı. ex location: herald.GET.PUSH_API"
            End If



        Catch ex As Exception
            config_class.Text = "Heimdall #~~>> Mesaj alınamadı. ex location: try_Load.herald"
        End Try
    End Sub

    Private Sub config_class_TextChanged(sender As Object, e As EventArgs) Handles config_class.TextChanged

    End Sub

    Private Sub counter_Tick(sender As Object, e As EventArgs) Handles counter.Tick
        If count = -1 Then
            Application.Exit()
        Else

        End If
        If count <= 5 Then
            count_herald.ForeColor = Color.Red
        ElseIf count <= 10 And count > 5 Then
            count_herald.ForeColor = Color.Yellow
        ElseIf count <= 15 And count > 10 Then
            count_herald.ForeColor = Color.SpringGreen
        End If
        count_herald.Text = count.ToString
        count = count - 1


    End Sub

    Private Sub heimdall_herald_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            If count > 1 Then
                Dim starter = New ProcessStartInfo(path.ToString)


                starter.Arguments = data

                Process.Start(starter)

            Else

            End If
        Catch ex As Exception
            config_class.Text = ex.Message.ToString
        End Try

    End Sub

    Private Sub topper_Tick(sender As Object, e As EventArgs)

    End Sub
End Class
