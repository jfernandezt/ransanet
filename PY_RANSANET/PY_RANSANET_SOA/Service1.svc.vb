Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.ServiceModel.Web
Imports System.Text
Imports PY_RANSANET_SOA.PY_RANSANET_SOA

Namespace PY_RANSANET_SOA

    ' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
    Public Class Service1 : Implements IService1

        <OperationContract()> _
        Function F_ValidaUsuario(pStr_Usuario As String, pStr_Contrasenia As String) As Integer Implements IService1.F_ValidaUsuario
            Return 1
        End Function

        <OperationContract()>
        Function Suma(ByVal Num1 As Integer, ByVal Num2 As Integer) As Integer Implements IService1.Suma
            Return Num1 + Num2
        End Function
    End Class

End Namespace
