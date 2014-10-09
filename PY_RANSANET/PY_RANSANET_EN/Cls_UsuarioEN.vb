Public Class Cls_UsuarioEN
    Private _IdUsuario As Integer
    Public Property IdUsuario() As Integer
        Get
            Return _IdUsuario
        End Get

        Set(ByVal value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Private _TipoUsuario As String
    Public Property TipoUsuario() As String
        Get
            Return _TipoUsuario
        End Get

        Set(ByVal value As String)
            _TipoUsuario = value
        End Set
    End Property

    Private _CodUsuario As String
    Public Property CodUsuario() As String
        Get
            Return _CodUsuario
        End Get

        Set(ByVal value As String)
            _CodUsuario = value
        End Set
    End Property

    Private _ApellidosUsuario As String
    Public Property ApellidosUsuario() As String
        Get
            Return _ApellidosUsuario
        End Get

        Set(ByVal value As String)
            _ApellidosUsuario = value
        End Set
    End Property

    Private _NombresUsuario As String
    Public Property NombresUsuario() As String
        Get
            Return _NombresUsuario
        End Get

        Set(ByVal value As String)
            _NombresUsuario = value
        End Set
    End Property

    Private _CorreoUsuario As String
    Public Property CorreoUsuario() As String
        Get
            Return _CorreoUsuario
        End Get

        Set(ByVal value As String)
            _CorreoUsuario = value
        End Set
    End Property

    Private _Contrasenia As String
    Public Property Contrasenia() As String
        Get
            Return _Contrasenia
        End Get

        Set(ByVal value As String)
            _Contrasenia = value
        End Set
    End Property

    Private _IdCliente As Integer
    Public Property IdCliente() As Integer
        Get
            Return _IdCliente
        End Get

        Set(ByVal value As Integer)
            _IdCliente = value
        End Set
    End Property

    Private _StsRegistro As String
    Public Property StsRegistro() As String
        Get
            Return _StsRegistro
        End Get

        Set(ByVal value As String)
            _StsRegistro = value
        End Set
    End Property

    Private _IdUsuarioCreador As Integer
    Public Property IdUsuarioCreador() As Integer
        Get
            Return _IdUsuarioCreador
        End Get

        Set(ByVal value As Integer)
            _IdUsuarioCreador = value
        End Set
    End Property

    Private _FecCreacion As DateTime
    Public Property FecCreacion() As DateTime
        Get
            Return _FecCreacion
        End Get

        Set(ByVal value As DateTime)
            _FecCreacion = value
        End Set
    End Property

    Private _IdUsuarioUpdate As Integer
    Public Property IdUsuarioUpdate() As Integer
        Get
            Return _IdUsuarioUpdate
        End Get

        Set(ByVal value As Integer)
            _IdUsuarioUpdate = value
        End Set
    End Property

    Private _FecUpdate As DateTime
    Public Property FecUpdate() As DateTime
        Get
            Return _FecUpdate
        End Get

        Set(ByVal value As DateTime)
            _FecUpdate = value
        End Set
    End Property
End Class
