Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class State
    Private _abbreviation As String
    Private _name As String
    Private _capitol As String
    Private _latitude As String
    Private _longitude As String

    Public Property Abbreviation As String
        Get
            Return Me._abbreviation
        End Get
        Set(value As String)
            Me._abbreviation = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return Me._name
        End Get
        Set(value As String)
            Me._name = value
        End Set
    End Property

    Public Property Capital As String
        Get
            Return Me._capitol
        End Get
        Set(value As String)
            Me._capitol = value
        End Set
    End Property

    Public Property Latitude As String
        Get
            Return Me._latitude
        End Get
        Set(value As String)
            Me._latitude = value
        End Set
    End Property

    Public Property Longitude As String
        Get
            Return Me._longitude
        End Get
        Set(value As String)
            Me._longitude = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(Abbreviation As String, Name As String, Capital As String, Latitude As String, Longitude As String)
        Me._abbreviation = Abbreviation
        Me._name = Name
        Me._capitol = Capital
        Me._latitude = Latitude
        Me._longitude = Longitude
    End Sub

    Public Function GetState(index As Integer)
        Return Nothing
    End Function

    'Private Sub New(ByVal value As String)
    '    Me._name = value
    'End Sub

    'Public Shared Widening Operator CType(ByVal value As String) As State
    '    Return New State(value)
    'End Operator

    'Public Overrides Function ToString() As String
    '    Return _name
    'End Function
End Class
