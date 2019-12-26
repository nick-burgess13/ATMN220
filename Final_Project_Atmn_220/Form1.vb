Public Class Form1
    'arrays for the game data
    Dim arrSize As Integer = 78
    Dim names(arrSize) As String
    Dim dat(arrSize) As String
    Dim dev(arrSize) As String
    Dim type(arrSize) As String
    Dim rating(arrSize) As String

    'only display debug stuff for debug mode
    Public debugMode As Boolean = False

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        lstArray.Items.Clear()

        Dim slots(80) As Integer

        'action filter checked
        If radAction.Checked Then
            lstDebug.Items.Add("Action")
            'init array
            ReDim slots(19)
            Dim count As Integer = 0
            'iterate through the listbox
            For i = 0 To lstType.Items.Count - 1 Step 1
                'found a match
                If lstType.Items.Item(i) = "Action" Then
                    'add the index to the array
                    slots(count) = i
                    count += 1
                End If
            Next
            lstDebug.Items.Add("Done")
        ElseIf radFighting.Checked Then
            lstDebug.Items.Add("Fighting")
            ReDim slots(12)
            Dim count As Integer = 0
            'iterate through the listbox
            For i = 0 To lstType.Items.Count - 1 Step 1
                'found a match
                If lstType.Items.Item(i) = "Fighting" Then
                    'add the index to the array
                    slots(count) = i
                    count += 1
                End If
            Next
            lstDebug.Items.Add("Done")
        ElseIf radRacing.Checked Then
            lstDebug.Items.Add("Racing")
            ReDim slots(5)
            Dim count As Integer = 0
            'iterate through the listbox
            For i = 0 To lstType.Items.Count - 1 Step 1
                'found a match
                If lstType.Items.Item(i) = "Racing" Then
                    'add the index to the array
                    slots(count) = i
                    count += 1
                End If
            Next
            lstDebug.Items.Add("Done")
        ElseIf radShooter.Checked Then
            lstDebug.Items.Add("Shooter")
            ReDim slots(13)
            Dim count As Integer = 0
            'iterate through the listbox
            For i = 0 To lstType.Items.Count - 1 Step 1
                'found a match
                If lstType.Items.Item(i) = "Shooter" Then
                    'add the index to the array
                    slots(count) = i
                    count += 1
                End If
            Next
            lstDebug.Items.Add("Done")
        ElseIf radSports.Checked Then
            lstDebug.Items.Add("Sports")
            ReDim slots(9)
            Dim count As Integer = 0
            'iterate through the listbox
            For i = 0 To lstType.Items.Count - 1 Step 1
                'found a match
                If lstType.Items.Item(i) = "Sports" Then
                    'add the index to the array
                    slots(count) = i
                    count += 1
                End If
            Next
            lstDebug.Items.Add("Done")
        ElseIf radSimulation.Checked Then
            lstDebug.Items.Add("Simulation")
            ReDim slots(4)
            Dim count As Integer = 0
            'iterate through the listbox
            For i = 0 To lstType.Items.Count - 1 Step 1
                'found a match
                If lstType.Items.Item(i) = "Simulation" Then
                    'add the index to the array
                    slots(count) = i
                    count += 1
                End If
            Next
            lstDebug.Items.Add("Done")
        ElseIf radRPG.Checked Then
            lstDebug.Items.Add("RPG")
            ReDim slots(9)
            Dim count As Integer = 0
            'iterate through the listbox
            For i = 0 To lstType.Items.Count - 1 Step 1
                'found a match
                If lstType.Items.Item(i) = "RPG" Then
                    'add the index to the array
                    slots(count) = i
                    count += 1
                End If
            Next
            lstDebug.Items.Add("Done")
        ElseIf radPuzzle.Checked Then
            lstDebug.Items.Add("Puzzle")
            ReDim slots(0)
            Dim count As Integer = 0
            'iterate through the listbox
            For i = 0 To lstType.Items.Count - 1 Step 1
                'found a match
                If lstType.Items.Item(i) = "Puzzle" Then
                    'add the index to the array
                    slots(count) = i
                    count += 1
                End If
            Next
            lstDebug.Items.Add("Done")
        Else
            ReDim slots(-1)
            lstDebug.Items.Add("No filter with btn press")
        End If
        For i = 0 To slots.Length - 1
            lstArray.Items.Add(names(slots(i)))
        Next


    End Sub
    Private Sub Frm1_Load() Handles MyBase.Load
        lstArray.Items.Clear()
        Import()
        InitDebug()
        'add games to the display of games
        For i = 0 To names.Length - 1 Step 1
            lstArray.Items.Add(names(i))
        Next
    End Sub

    Sub Import()
        'try catch for error handleing
        Try
            'init the file reader
            Using fileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("atmn220projdat.csv")
                fileReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                'string variable to look at a single line at a time
                Dim currLine As String

                Dim count As Integer = 0
                'order of csv is: Name, date, type, dev, rating,
                'keep looping till we get to the end of the file
                While Not fileReader.EndOfData
                    'take in the current line
                    currLine = fileReader.ReadLine()
                    'split the line on every instance of a comma and put it in an array
                    Dim line() As String = currLine.Split(",")
                    'throw the data in their proper list boxes
                    names(count) = line(0)
                    dat(count) = line(1)
                    type(count) = line(2)
                    dev(count) = line(3)
                    rating(count) = line(4)
                    count += 1
                    'shooter, racing, fighting, action, sports, simulation, rpg, puzzle
                End While
                lstDebug.Items.Add("Done importing from csv")
                'throw everything in its debug list boxes
                For i = 0 To names.Length - 1
                    lstName.Items.Add(names(i))
                    lstDate.Items.Add(dat(i))
                    lstType.Items.Add(type(i))
                    lstDev.Items.Add(dev(i))
                    lstRating.Items.Add(rating(i))
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Issue importing CSV" & vbNewLine & "Exiting Program")
            Environment.Exit(2)

        End Try
    End Sub

    Private Sub InitDebug()
        'hide all the debug list boxes
        If Not debugMode Then
            lstDebug.Hide()
            lstName.Hide()
            lstType.Hide()
            lstDate.Hide()
            lstDev.Hide()
            lstRating.Hide()
        Else
            lstDebug.Show()
        End If
    End Sub

    Private Sub lstArray_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArray.SelectedIndexChanged
        'string for the image path
        Dim imagePath As String = "Boxart\"
        'get the selected game from list
        Dim gameSel As String = lstArray.SelectedItem
        'string for the case statements
        Dim game As String = ""

        'use case statements for loading the game image/ data
        Select Case gameSel
            Case "Guardian Heroes"
                game = "Guardianheroes"
            Case "Clockwork Knight"
                game = "Clockwork Knight"
            Case "Marvel Super Heroes"
                game = "Marvel Super Heroes"
            Case "Panzer Dragoon"
                game = "Panzerdragoon"
            Case "Sega Rally Championship"
                game = "SegarallyChamp"
            Case "Virtua Fighter"
                game = "Virtuafighter"
            Case "World Series Baseball"
                game = "Worldseriesbaseball"
            Case "Clockwork Knight 2"
                game = "Clockworkknight2"
            Case "NFL Quarterback Club '96"
                game = "Nflquarterbackclub96"
            Case "Rayman"
                game = "Rayman"
            Case "Bug!"
                game = "Bug!"
            Case "Virtua Fighter Remix"
                game = "Virtuafighterremix"
            Case "Astal"
                game = "Astal"
            Case "Theme Park"
                game = "Themepark"
            Case "Solar Eclipse"
                game = "Solareclipse"
            Case "Romance of the Three Kingdoms IV: Wall of Fire"
                game = "Romanceofthreekingdoms"
            Case "Off-World Interceptor Extreme"
                game = "offworldinterceptor"
            Case "Virtua Cop"
                game = "Virtua Cop"
            Case "Daytona USA"
                game = "Daytona USA"
            Case "Pebble Beach Golf Link"
                game = "Pebble Beach"
            Case "Quarterback Attack with Mike Ditka"
                game = "Quarterback Attack"
            Case "Black Fire"
                game = "Black Fire"
            Case "Golden Axe: The Duel"
                game = "Golden Axe The Duel"
            Case "Galactic Attack"
                game = "Galactic Attack"
            Case "NHL All-Star Hockey"
                game = "NHLallStarhockey"
            Case "Ghen War"
                game = "Ghenwar"
            Case "Shellshock"
                game = "Shellshock"
            Case "Street Fighter: The Movie"
                game = "Streetfighterthemovie"
            Case "Soviet Strike"
                game = "Sovietstrike"
            Case "The Need for Speed"
                game = "Theneedforspeed"
            Case "Virtua Fighter 2"
                game = "Virtuafighter2"
            Case "Bust-A-Move 2"
                game = "Bustamove2"
            Case "NHL '97"
                game = "NHL '97"
            Case "Command & Conquer"
                game = "Commandandconquer"
            Case "Dragon Force"
                game = "Dragonforce"
            Case "Andretti Racing"
                game = "Andrettiracing"
            Case "NiGHTS Into Dreams"
                game = "Nightsintodreams"
            Case "Street Fighter Alpha 2"
                game = "Streetfighteralpha2"
            Case "Tomb Raider"
                game = "Tombraider"
            Case "Virtua Cop 2"
                game = "Virtuacop2"
            Case "World Series Baseball II"
                game = "Worldseriesbaseball2"
            Case "Fighting Vipers"
                game = "Fightingvipers"
            Case "Virtual-On: Cyber Troopers"
                game = "Virtualoncybertroopers"
            Case "The Legend of Oasis"
                game = "TheLegendofoasis"
            Case "Night Warriors: Darkstalker's Revenge"
                game = "NightWarriors"
            Case "Dark Savior"
                game = "Darksavior"
            Case "Bug Too!"
                game = "Bugtoo"
            Case "Crusader: No Remorse"
                game = "Crusadernoremorse"
            Case "Sonic 3D Blast"
                game = "Sonic3dblast"
            Case "NFL '97"
                game = "NFl97"
            Case "Batman Forever: The Arcade Game"
                game = "Batmanforever"
            Case "Madden NFL 98"
                game = "Maddennfl98"
            Case "Fighters Megamix"
                game = "Fightersmegamix"
            Case "Saturn Bomberman"
                game = "Saturnbomberman"
            Case "Shining the Holy Ark"
                game = "Shiningtheholyark"
            Case "Sonic Jam"
                game = "Sonicjam"
            Case "Mega Man 8"
                game = "Megaman8"
            Case "Albert Odyssey: Legend of Eldean"
                game = "Albertodyssey"
            Case "Last Bronx"
                game = "Lastbronx"
            Case "Sonic R"
                game = "Sonicr"
            Case "Manx TT Super Bike"
                game = "Manxtt"
            Case "Scud: The Disposable Assassin"
                game = "Scud"
            Case "Enemy Zero"
                game = "Enemyzero"
            Case "CrimeWave"
                game = "Crimewave"
            Case "Hexen: Beyond Heretic"
                game = "Hexen"
            Case "Panzer Dragoon Saga"
                game = "Panzerdragoonsaga"
            Case "Shining Force III"
                game = "Shiningforce3"
            Case "Burning Rangers"
                game = "Burningrangers"
            Case "The House of the Dead"
                game = "Thehouseofthedead"
            Case "Magic Knight Rayearth"
                game = "Magicknightrayearth"
            Case "Robotica"
                game = "Robotica"
            Case "Panzer Dragoon II Zwei"
                game = "Panzerdragoon2"
            Case "Shinobi Legions"
                game = "Shinobilegions"
            Case "Wing Arms"
                game = "Wing Arms"
            Case "Battle Arena Toshinden Remix"
                game = "Battlearenatoshinden"
            Case "NHL PowerPlay '96"
                game = "NHLpowerplay96"
            Case "NHL 97"
                game = "NHL97"
            Case "Virtua Fighter Kids"
                game = "Virtuafighterkids"
            Case "Shining Wisdom"
                game = "Shiningwisdom"
            Case "Herc's Adventures"
                game = "Hercsadventures"
            Case Else
                PictureBox1.Hide()
        End Select
        imagePath &= game & ".jpg"
        LoadImage(imagePath)
        GetGameData(game)
    End Sub

    Sub LoadImage(location As String)
        'try catch for error handleing
        Try
            Dim source As New Bitmap(location)
            '
            PictureBox1.Show()
            PictureBox1.ImageLocation = location
            'adjust image size so it fits in the box
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Load()
        Catch ex As Exception
            MessageBox.Show("Issue Displaying Image: Exiting Program")
            Environment.Exit(2)
        End Try
    End Sub

    Sub GetGameData(name As String)
        Dim index As Integer = -1

        Dim i As Integer = 0
        Dim isDone As Boolean = False
        'look for the game using linear search
        While i < names.Length - 1 And Not isDone
            'found a match
            If names(i).Equals(name) Then
                index = i
                'debug statemnt
                lstDebug.Items.Add("Found the name")
                'don't look for the game any more
                isDone = True
            End If
            'increment counter
            i += 1
        End While
        'output data only if a match was found
        If isDone Then
            lstDebug.Items.Add("Ouputing game Data")
            txtDate.Text = dat(index)
            txtDev.Text = dev(index)
            txtRating.Text = rating(index)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click

        'set the directory to the emulator location
        My.Computer.FileSystem.CurrentDirectory = "C:\Users\Nick\Dropbox\Final_Project_Atmn_220\bin\Debug\Emulator"
        'start the emulator
        Process.Start("VirtuaFighter.cue")
    End Sub
End Class
