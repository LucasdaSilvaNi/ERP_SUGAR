﻿Imports CrystalDecisions.Shared
Imports System.Configuration
Imports System.Data.SqlClient

Public Class InformeEstadisticaVentasPaises
    Public Function verInforme(ByVal sBusqueda As String, ByVal Orden As String, ByVal iidCliente As Integer, ByVal Titulo As String) As Boolean
        Dim informe As Object
        'If iidCliente = 0 Then
        informe = New EstadisticaVentasXPaisH
        'Else
        '    informe = New EstadisticaVentas
        'End If
        Dim settings As ConnectionStringSettings
        settings = ConfigurationManager.ConnectionStrings(1)
        Dim csb As New SqlConnectionStringBuilder
        csb.ConnectionString = settings.ConnectionString
        Dim sParametro As String = ""
        If iidCliente > 0 Then
            sParametro = " WHERE FA.idCliente = " & iidCliente
            If sBusqueda <> "" Then sParametro = sParametro & " AND " & sBusqueda
        ElseIf sBusqueda <> "" Then
            sParametro = "WHERE " & sBusqueda
        End If
        If Orden = "" Then
            Orden = " Order By NombreComercial ASC "
        Else
            Orden = " Order By " & Orden
        End If
        informe.SetParameterValue("sParametro", sParametro)
        informe.SetParameterValue("sOrden", Orden)
        informe.setParameterValue("VerTotal", iidCliente = 0)
        informe.setParameterValue("Titulo", Titulo)
        informe.SetDatabaseLogon(csb.UserID, csb.Password)
        CRVESTADISTICAPAIS.ReportSource = informe
        Return True
    End Function

End Class