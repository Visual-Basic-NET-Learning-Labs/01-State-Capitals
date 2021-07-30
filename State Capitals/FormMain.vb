Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''Declare Variables
        'Dim json As String = File.ReadAllText("States.json")
        'Dim JObject As JObject = JObject.Parse(json)
        'Dim jsonArray As JArray = JObject("usa")

        ''Dim counter As Integer = 0


        'For Each Item As JObject In jsonArray
        '    'MessageBox.Show(jsonArray.Item(0).ToString)
        '    'MessageBox.Show(Item.SelectToken("name"))
        '    States.Add(Item.SelectToken("name"))

        '    'If States.Count < 0 Then
        '    'Else
        '    '    MessageBox.Show(States.Item(counter))
        '    '    MessageBox.Show(States.IndexOf(Item.SelectToken("name").ToString))
        '    'End If
        '    'counter = counter + 1
        'Next

        Parser.GetStates(States)

        'For Each State As String In States
        '    cboStates.Items.Add(State)
        'Next

        cboStates.DataSource = States
        cboStates.DisplayMember = "Name"

    End Sub

    Private Sub cboStates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStates.SelectedIndexChanged
        'MessageBox.Show(States.IndexOf(cboStates.Text))

        If cboStates.Text = "Select One..." Then
            lblStateName.Text = " "
            lblStateAbbreviation.Text = " "
            lblStateCapital.Text = " "
            lblStateLongitude.Text = " "
            lblStateLatitude.Text = " "
        Else

        End If

        lblStateName.Text = States(States.IndexOf(cboStates.Text)).Name
        lblStateAbbreviation.Text = States(States.IndexOf(cboStates.Text)).Abbreviation
        lblStateCapital.Text = States(States.IndexOf(cboStates.Text)).Capital
        lblStateLongitude.Text = States(States.IndexOf(cboStates.Text)).Longitude
        lblStateLatitude.Text = States(States.IndexOf(cboStates.Text)).Latitude
    End Sub
End Class