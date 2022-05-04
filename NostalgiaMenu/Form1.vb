Imports System.IO
Imports MadMilkman.Ini

Public Class Form1
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim DefaultLaunchTime As Integer = 60
    Dim DefaultGamePath As String = ""
    Dim GameConfigPath As String = "games.ini"
    Dim GameCount = 0
    Dim GameLauncherKVP As New List(Of KeyValuePair(Of String, String))



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGamesConfig()
        DrawButtons()
        If DefaultGamePath <> "" = True Then
            Countdown.Enabled = True
            Countdown.Start()
        End If
    End Sub

    Function LoadGamesConfig()
        Dim inifile As New IniFile()

        If My.Computer.FileSystem.FileExists(GameConfigPath) = True Then
            inifile.Load(GameConfigPath)

            For Each S In inifile.Sections
                If S.Name.ToUpper = "DEFAULT GAME" Then
                    If S.Keys.Count > 1 Then
                        MessageBox.Show("DEFAULT GAME Sections, contains more then one launcher. Please fix and retry.")
                        Application.Exit()
                    Else
                        For Each k In S.Keys
                            If k.Name.ToLower = "launcher" Then
                                If k.Value.ToUpper = "FALSE" Then
                                    Console.WriteLine("DEFAULT GAME = FALSE, Skipping.")
                                    lblDefaultGame.Text = "Default Game: DISABLED"
                                    lblDefaultGame.BackColor = Color.Coral
                                Else
                                    DefaultGamePath = k.Value
                                    lblDefaultGame.BackColor = Color.LightGreen
                                End If
                            End If
                        Next
                    End If
                Else 'if not Default game add to List
                    For Each K In S.Keys
                        If K.Name.ToLower = "launcher" Then
                            If K.Value.ToUpper <> "FALSE" Or K.Value.ToUpper <> "N/A" Then
                                GameLauncherKVP.Add(New KeyValuePair(Of String, String)(S.Name, K.Value))
                                Console.WriteLine(K.Value)
                                GameCount = GameCount + 1
                            End If
                        End If
                    Next
                End If
            Next
        Else
            Dim Section As IniSection = inifile.Sections.Add("GAMES")
            Section.TrailingComment.Text = "
Add sections for each game/data you want to use.
Ensure you have a DEFAULT GAME section, you can disable default game launch by setting launcher value to false.
ex. [NOSTALGIA Op.1 2017-06-27]
    launcher=D:/games/nost1_2017062700/gamestart.bat
    [NOSTALGIA Op.1 2018-06-20]
    launcher=D:/games/nost1_2018062002/gamestart.bat
    [DEFAULT GAME]
    launcher=D:/games/nost1_081816/gamestart.bat"
            inifile.Sections.Add(
                New IniSection(inifile, "DEFAULT GAME",
                    New IniKey(inifile, "launcher", "D:/PAN-2021072700/contents/gamestart.bat")
            ))
            inifile.Sections.Add(
                New IniSection(inifile, "Nostalgia Op.1 - 2017062700",
                    New IniKey(inifile, "launcher", "D:/PAN-2017062700/contents/gamestart.bat")
            ))
            inifile.Sections.Add(
                New IniSection(inifile, "Nostalgia Forte - 2018062002",
                    New IniKey(inifile, "launcher", "D:/PAN-2018062002/contents/gamestart.bat")
            ))
            inifile.Sections.Add(
                New IniSection(inifile, "Nostalgia Op.2 - 2019112700",
                    New IniKey(inifile, "launcher", "D:/PAN-2019112700/contents/gamestart.bat")
            ))
            inifile.Sections.Add(
                New IniSection(inifile, "Nostalgia Op.3 - 2021072700",
                    New IniKey(inifile, "launcher", "D:/PAN-2021072700/contents/gamestart.bat")
            ))
            inifile.Sections.Add(
                New IniSection(inifile, "BeatStream 1 - 2015121600",
                    New IniKey(inifile, "launcher", "D:/NBT-2015121600/contents/gamestart.bat")
            ))
            inifile.Sections.Add(
                New IniSection(inifile, "BeatStream 2 - 2016111400",
                    New IniKey(inifile, "launcher", "D:/NBT-2016111400/contents/gamestart.bat")
            ))
            inifile.Save(GameConfigPath)
            MessageBox.Show("Created games.ini, Please configure and relaunch.")
            Application.Exit()
        End If
    End Function

    Function DrawButtons()
        Dim ButtonCount = 0
        Dim ButtonYCount = 0
        Dim LocationX = 20
        Dim LocationY = 12

        For Each G In GameLauncherKVP
            Dim ButtonName = "dbtn" & G.Key
            Dim dbtn As New Button
            dbtn.Location = New Point(LocationX, LocationY)
            dbtn.Text = G.Key
            dbtn.Size = New Size(200, 200)
            dbtn.Name = ButtonName
            dbtn.Font = New Font("Georgia", 12)
            If G.Key.ToLower.Contains("nostalgia") Then
                dbtn.BackColor = Color.LightGoldenrodYellow
            ElseIf G.Key.ToLower.Contains("beatstream") Then
                dbtn.BackColor = Color.AliceBlue
            End If
            AddHandler dbtn.Click, AddressOf dbtn_Click
            Controls.Add(dbtn)

            LocationX = LocationX + 215
            ButtonYCount = ButtonYCount + 1
            ButtonCount = ButtonCount + 1
        Next

        SetFormSize(LocationY, LocationX)
    End Function

    Private Sub dbtn_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        For Each G In GameLauncherKVP
            If btn.Name = "dbtn" & G.Key Then
                'MessageBox.Show(G.Value)
                Process.Start(G.Value)
                Application.Exit()
            End If
        Next
    End Sub

    Function SetFormSize(ByVal Y As Integer, ByVal X As Integer)
        Size = New Size(X + 16, Size.Height)
        lblBottom.Size = New Size(X - 26, 25)
        lblDefaultGame.Size = New Size(X - 26, 25)
    End Function

    Private Sub Countdown_Tick(sender As Object, e As EventArgs) Handles Countdown.Tick
        If DefaultLaunchTime = 0 Then
            Process.Start(DefaultGamePath)
            Application.Exit()
        Else
            lblDefaultGame.Text = "Default Game will launch in " & DefaultLaunchTime & "/s"
            DefaultLaunchTime = DefaultLaunchTime - 1
            If DefaultLaunchTime < 10 Then
                lblDefaultGame.BackColor = Color.LightCoral
            ElseIf DefaultLaunchTime < 30 Then
                lblDefaultGame.BackColor = Color.LightGoldenrodYellow
            End If
        End If
    End Sub
End Class
