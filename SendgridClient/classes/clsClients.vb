Public Class clsClients

    Private _name As String = ""
    Private _emailAddress As String = ""

    'properties
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property EmailAddress() As String
        Get
            Return _emailAddress
        End Get
        Set(ByVal value As String)
            _emailAddress = value
        End Set
    End Property

End Class

'might move the sendEmails into here so i can interact with the collection directly
'rather than having to create a new one in the main form
Public Class colClients
    Inherits clsBindingListBase(Of clsClients)

End Class
