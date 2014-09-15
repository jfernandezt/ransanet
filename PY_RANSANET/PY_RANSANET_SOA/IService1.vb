Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.ServiceModel.Web
Imports System.Text

Namespace PY_RANSANET_SOA

    ' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
    <ServiceContract()>
    Public Interface IService1

        <OperationContract()>
        Function F_ValidaUsuario(pStr_Usuario As String, pStr_Contrasenia As String) As Integer

        <OperationContract()>
        Function Suma(ByVal Num1 As Integer, ByVal Num2 As Integer) As Integer

    End Interface


    '' Use a data contract as illustrated in the sample below to add composite types to service operations.

    '<DataContract()>
    'Public Class CompositeType

    '    <DataMember()>
    '    Public Property BoolValue() As Boolean

    '    <DataMember()>
    '    Public Property StringValue() As String

    'End Class

End Namespace
