﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace Ws_RansaNetMessage
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Cls_PedidoEN", [Namespace]:="http://schemas.datacontract.org/2004/07/PY_RANSA_NET_EN"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Cls_PedidoEN
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private IdEstadoPedidoField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private IdPedidoField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private IdUsuarioField As Integer
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IdEstadoPedido() As Integer
            Get
                Return Me.IdEstadoPedidoField
            End Get
            Set
                If (Me.IdEstadoPedidoField.Equals(value) <> true) Then
                    Me.IdEstadoPedidoField = value
                    Me.RaisePropertyChanged("IdEstadoPedido")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IdPedido() As Integer
            Get
                Return Me.IdPedidoField
            End Get
            Set
                If (Me.IdPedidoField.Equals(value) <> true) Then
                    Me.IdPedidoField = value
                    Me.RaisePropertyChanged("IdPedido")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IdUsuario() As Integer
            Get
                Return Me.IdUsuarioField
            End Get
            Set
                If (Me.IdUsuarioField.Equals(value) <> true) Then
                    Me.IdUsuarioField = value
                    Me.RaisePropertyChanged("IdUsuario")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="PedidoMovimientoRansa", [Namespace]:="http://schemas.datacontract.org/2004/07/PY_RANSA_NET_WCF.Ws_RansaNet"),  _
     System.SerializableAttribute()>  _
    Partial Public Class PedidoMovimientoRansa
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private PropertyChanged1Field As System.ComponentModel.PropertyChangedEventHandler
        
        Private fecCreacionFieldField As System.Nullable(Of Date)
        
        Private fecCreacionFieldSpecifiedField As Boolean
        
        Private fecFinFieldField As System.Nullable(Of Date)
        
        Private fecFinFieldSpecifiedField As Boolean
        
        Private fecInicioFieldField As System.Nullable(Of Date)
        
        Private fecInicioFieldSpecifiedField As Boolean
        
        Private fecMovimeintoFieldField As System.Nullable(Of Date)
        
        Private fecMovimeintoFieldSpecifiedField As Boolean
        
        Private fecUpdateFieldField As System.Nullable(Of Date)
        
        Private fecUpdateFieldSpecifiedField As Boolean
        
        Private idEstadopedidoFieldField As Integer
        
        Private idEstadopedidoFieldSpecifiedField As Boolean
        
        Private idPedidoFieldField As Integer
        
        Private idPedidoFieldSpecifiedField As Boolean
        
        Private idPedidoMovimientoFieldField As Integer
        
        Private idPedidoMovimientoFieldSpecifiedField As Boolean
        
        Private idUsuarioCreadorFieldField As Integer
        
        Private idUsuarioCreadorFieldSpecifiedField As Boolean
        
        Private idUsuarioUpdateFieldField As Integer
        
        Private idUsuarioUpdateFieldSpecifiedField As Boolean
        
        Private nomEstadoPedidoFieldField As String
        
        Private nomUsuarioCreadorFieldField As String
        
        Private nomUsuarioUpdateFieldField As String
        
        Private stsRegistroFieldField As SByte
        
        Private stsRegistroFieldSpecifiedField As Boolean
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(Name:="PropertyChanged", IsRequired:=true)>  _
        Public Property PropertyChanged1() As System.ComponentModel.PropertyChangedEventHandler
            Get
                Return Me.PropertyChanged1Field
            End Get
            Set
                If (Object.ReferenceEquals(Me.PropertyChanged1Field, value) <> true) Then
                    Me.PropertyChanged1Field = value
                    Me.RaisePropertyChanged("PropertyChanged1")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property fecCreacionField() As System.Nullable(Of Date)
            Get
                Return Me.fecCreacionFieldField
            End Get
            Set
                If (Me.fecCreacionFieldField.Equals(value) <> true) Then
                    Me.fecCreacionFieldField = value
                    Me.RaisePropertyChanged("fecCreacionField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property fecCreacionFieldSpecified() As Boolean
            Get
                Return Me.fecCreacionFieldSpecifiedField
            End Get
            Set
                If (Me.fecCreacionFieldSpecifiedField.Equals(value) <> true) Then
                    Me.fecCreacionFieldSpecifiedField = value
                    Me.RaisePropertyChanged("fecCreacionFieldSpecified")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property fecFinField() As System.Nullable(Of Date)
            Get
                Return Me.fecFinFieldField
            End Get
            Set
                If (Me.fecFinFieldField.Equals(value) <> true) Then
                    Me.fecFinFieldField = value
                    Me.RaisePropertyChanged("fecFinField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property fecFinFieldSpecified() As Boolean
            Get
                Return Me.fecFinFieldSpecifiedField
            End Get
            Set
                If (Me.fecFinFieldSpecifiedField.Equals(value) <> true) Then
                    Me.fecFinFieldSpecifiedField = value
                    Me.RaisePropertyChanged("fecFinFieldSpecified")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property fecInicioField() As System.Nullable(Of Date)
            Get
                Return Me.fecInicioFieldField
            End Get
            Set
                If (Me.fecInicioFieldField.Equals(value) <> true) Then
                    Me.fecInicioFieldField = value
                    Me.RaisePropertyChanged("fecInicioField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property fecInicioFieldSpecified() As Boolean
            Get
                Return Me.fecInicioFieldSpecifiedField
            End Get
            Set
                If (Me.fecInicioFieldSpecifiedField.Equals(value) <> true) Then
                    Me.fecInicioFieldSpecifiedField = value
                    Me.RaisePropertyChanged("fecInicioFieldSpecified")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property fecMovimeintoField() As System.Nullable(Of Date)
            Get
                Return Me.fecMovimeintoFieldField
            End Get
            Set
                If (Me.fecMovimeintoFieldField.Equals(value) <> true) Then
                    Me.fecMovimeintoFieldField = value
                    Me.RaisePropertyChanged("fecMovimeintoField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property fecMovimeintoFieldSpecified() As Boolean
            Get
                Return Me.fecMovimeintoFieldSpecifiedField
            End Get
            Set
                If (Me.fecMovimeintoFieldSpecifiedField.Equals(value) <> true) Then
                    Me.fecMovimeintoFieldSpecifiedField = value
                    Me.RaisePropertyChanged("fecMovimeintoFieldSpecified")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property fecUpdateField() As System.Nullable(Of Date)
            Get
                Return Me.fecUpdateFieldField
            End Get
            Set
                If (Me.fecUpdateFieldField.Equals(value) <> true) Then
                    Me.fecUpdateFieldField = value
                    Me.RaisePropertyChanged("fecUpdateField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property fecUpdateFieldSpecified() As Boolean
            Get
                Return Me.fecUpdateFieldSpecifiedField
            End Get
            Set
                If (Me.fecUpdateFieldSpecifiedField.Equals(value) <> true) Then
                    Me.fecUpdateFieldSpecifiedField = value
                    Me.RaisePropertyChanged("fecUpdateFieldSpecified")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property idEstadopedidoField() As Integer
            Get
                Return Me.idEstadopedidoFieldField
            End Get
            Set
                If (Me.idEstadopedidoFieldField.Equals(value) <> true) Then
                    Me.idEstadopedidoFieldField = value
                    Me.RaisePropertyChanged("idEstadopedidoField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property idEstadopedidoFieldSpecified() As Boolean
            Get
                Return Me.idEstadopedidoFieldSpecifiedField
            End Get
            Set
                If (Me.idEstadopedidoFieldSpecifiedField.Equals(value) <> true) Then
                    Me.idEstadopedidoFieldSpecifiedField = value
                    Me.RaisePropertyChanged("idEstadopedidoFieldSpecified")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property idPedidoField() As Integer
            Get
                Return Me.idPedidoFieldField
            End Get
            Set
                If (Me.idPedidoFieldField.Equals(value) <> true) Then
                    Me.idPedidoFieldField = value
                    Me.RaisePropertyChanged("idPedidoField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property idPedidoFieldSpecified() As Boolean
            Get
                Return Me.idPedidoFieldSpecifiedField
            End Get
            Set
                If (Me.idPedidoFieldSpecifiedField.Equals(value) <> true) Then
                    Me.idPedidoFieldSpecifiedField = value
                    Me.RaisePropertyChanged("idPedidoFieldSpecified")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property idPedidoMovimientoField() As Integer
            Get
                Return Me.idPedidoMovimientoFieldField
            End Get
            Set
                If (Me.idPedidoMovimientoFieldField.Equals(value) <> true) Then
                    Me.idPedidoMovimientoFieldField = value
                    Me.RaisePropertyChanged("idPedidoMovimientoField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property idPedidoMovimientoFieldSpecified() As Boolean
            Get
                Return Me.idPedidoMovimientoFieldSpecifiedField
            End Get
            Set
                If (Me.idPedidoMovimientoFieldSpecifiedField.Equals(value) <> true) Then
                    Me.idPedidoMovimientoFieldSpecifiedField = value
                    Me.RaisePropertyChanged("idPedidoMovimientoFieldSpecified")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property idUsuarioCreadorField() As Integer
            Get
                Return Me.idUsuarioCreadorFieldField
            End Get
            Set
                If (Me.idUsuarioCreadorFieldField.Equals(value) <> true) Then
                    Me.idUsuarioCreadorFieldField = value
                    Me.RaisePropertyChanged("idUsuarioCreadorField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property idUsuarioCreadorFieldSpecified() As Boolean
            Get
                Return Me.idUsuarioCreadorFieldSpecifiedField
            End Get
            Set
                If (Me.idUsuarioCreadorFieldSpecifiedField.Equals(value) <> true) Then
                    Me.idUsuarioCreadorFieldSpecifiedField = value
                    Me.RaisePropertyChanged("idUsuarioCreadorFieldSpecified")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property idUsuarioUpdateField() As Integer
            Get
                Return Me.idUsuarioUpdateFieldField
            End Get
            Set
                If (Me.idUsuarioUpdateFieldField.Equals(value) <> true) Then
                    Me.idUsuarioUpdateFieldField = value
                    Me.RaisePropertyChanged("idUsuarioUpdateField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property idUsuarioUpdateFieldSpecified() As Boolean
            Get
                Return Me.idUsuarioUpdateFieldSpecifiedField
            End Get
            Set
                If (Me.idUsuarioUpdateFieldSpecifiedField.Equals(value) <> true) Then
                    Me.idUsuarioUpdateFieldSpecifiedField = value
                    Me.RaisePropertyChanged("idUsuarioUpdateFieldSpecified")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property nomEstadoPedidoField() As String
            Get
                Return Me.nomEstadoPedidoFieldField
            End Get
            Set
                If (Object.ReferenceEquals(Me.nomEstadoPedidoFieldField, value) <> true) Then
                    Me.nomEstadoPedidoFieldField = value
                    Me.RaisePropertyChanged("nomEstadoPedidoField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property nomUsuarioCreadorField() As String
            Get
                Return Me.nomUsuarioCreadorFieldField
            End Get
            Set
                If (Object.ReferenceEquals(Me.nomUsuarioCreadorFieldField, value) <> true) Then
                    Me.nomUsuarioCreadorFieldField = value
                    Me.RaisePropertyChanged("nomUsuarioCreadorField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property nomUsuarioUpdateField() As String
            Get
                Return Me.nomUsuarioUpdateFieldField
            End Get
            Set
                If (Object.ReferenceEquals(Me.nomUsuarioUpdateFieldField, value) <> true) Then
                    Me.nomUsuarioUpdateFieldField = value
                    Me.RaisePropertyChanged("nomUsuarioUpdateField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property stsRegistroField() As SByte
            Get
                Return Me.stsRegistroFieldField
            End Get
            Set
                If (Me.stsRegistroFieldField.Equals(value) <> true) Then
                    Me.stsRegistroFieldField = value
                    Me.RaisePropertyChanged("stsRegistroField")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property stsRegistroFieldSpecified() As Boolean
            Get
                Return Me.stsRegistroFieldSpecifiedField
            End Get
            Set
                If (Me.stsRegistroFieldSpecifiedField.Equals(value) <> true) Then
                    Me.stsRegistroFieldSpecifiedField = value
                    Me.RaisePropertyChanged("stsRegistroFieldSpecified")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="Ws_RansaNetMessage.ServicioPedido")>  _
    Public Interface ServicioPedido
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ServicioPedido/RegistrarPedidoMovimiento", ReplyAction:="http://tempuri.org/ServicioPedido/RegistrarPedidoMovimientoResponse")>  _
        Function RegistrarPedidoMovimiento(ByVal pedido As Ws_RansaNetMessage.Cls_PedidoEN) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ServicioPedido/ConsultaPedidoMovimiento", ReplyAction:="http://tempuri.org/ServicioPedido/ConsultaPedidoMovimientoResponse")>  _
        Function ConsultaPedidoMovimiento(ByVal pStr_CodPedido As String) As Ws_RansaNetMessage.PedidoMovimientoRansa()
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ServicioPedidoChannel
        Inherits Ws_RansaNetMessage.ServicioPedido, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServicioPedidoClient
        Inherits System.ServiceModel.ClientBase(Of Ws_RansaNetMessage.ServicioPedido)
        Implements Ws_RansaNetMessage.ServicioPedido
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function RegistrarPedidoMovimiento(ByVal pedido As Ws_RansaNetMessage.Cls_PedidoEN) As Boolean Implements Ws_RansaNetMessage.ServicioPedido.RegistrarPedidoMovimiento
            Return MyBase.Channel.RegistrarPedidoMovimiento(pedido)
        End Function
        
        Public Function ConsultaPedidoMovimiento(ByVal pStr_CodPedido As String) As Ws_RansaNetMessage.PedidoMovimientoRansa() Implements Ws_RansaNetMessage.ServicioPedido.ConsultaPedidoMovimiento
            Return MyBase.Channel.ConsultaPedidoMovimiento(pStr_CodPedido)
        End Function
    End Class
End Namespace