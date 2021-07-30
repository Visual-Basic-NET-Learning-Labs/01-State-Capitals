Imports System.IO
Imports Newtonsoft.Json.Linq

Module Parser
    Private ReadOnly json As String = File.ReadAllText("States.json")
    Private ReadOnly JObject As JObject = JObject.Parse(json)
    Private ReadOnly jsonArray As JArray = JObject("usa")
    'Public States As New List(Of String)()
    Public States As New List(Of State)()



    'Public Function GetStates()
    '    For Each item As JObject In jsonArray
    '        'States.Add(item.SelectToken("name"))
    '    Next
    '    Return States
    'End Function

    Public Function GetStates(States As List(Of State))
        For Each item As JObject In jsonArray
            States.Add(
                New State() With {
                    .Name = item.SelectToken("name"),
                    .Abbreviation = item.SelectToken("abbr"),
                    .Capital = item.SelectToken("capital"),
                    .Latitude = item.SelectToken("latitude"),
                    .Longitude = item.SelectToken("longitude")
                    }
                )
        Next

        Dim InitialState As New State("", "States...", "ST", "", "")

        States.Insert(0, InitialState)

        Return States
    End Function

    Public Function GetStateByName(SelectedStateName As String) As Integer

        Dim ListIndex As Integer = 0

        For Each State In States
            If State.Name = SelectedStateName Then
                Return ListIndex
            End If

            ListIndex = ListIndex + 1
        Next

        Return Nothing

    End Function

    'Public Function GetStates(States As List(Of String))
    '    For Each item As JObject In jsonArray
    '        States.Add(item.SelectToken("name"))
    '    Next

    '    Return States
    'End Function

    'Public Function GetState(abbreviation As String, name As String, capital As String, latitude As String, longitude As String)
    '    For Each item As JObject In jsonArray

    '    Next
    '    Return Nothing
    'End Function
End Module
