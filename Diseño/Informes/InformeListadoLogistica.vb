﻿Imports CrystalDecisions.Shared
Imports System.Configuration
Imports System.Data.SqlClient

Public Class InformeListadoLogisitca

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRVPedido.Load
        Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        If desktopSize.Height > 1000 Then
            Me.Height = 950
        Else
            Me.Height = desktopSize.Height - 50
        End If
        Me.Location = New Point(Me.Location.X, 0)
    End Sub

    Public Function verInforme(ByVal sBusqueda As String, ByVal sOrden As String, ByVal Detallado As Boolean) As Boolean

        Dim informe As New ListadoLogistica

        'Tomamos el usuario y la contraseña de la base de datos del la cadena de conexión de la aplicación
        Dim settings As ConnectionStringSettings
        settings = ConfigurationManager.ConnectionStrings(1)
        Dim csb As New SqlConnectionStringBuilder
        csb.ConnectionString = settings.ConnectionString
        informe.SetDatabaseLogon(csb.UserID, csb.Password)


        'Pasamos los parámetros 
        informe.SetParameterValue("sParametro", If(sBusqueda = "", "", " WHERE " & sBusqueda) & If(sOrden = "", " Order By numPedido DESC, CP.idConcepto ASC ", " ORDER BY " & sOrden & ", CP.idConcepto ASC "))
        informe.SetParameterValue("Detallado", Detallado)
        'informe.SetParameterValue("Detalle", Detallado)
        'Asignamos el informe al CRV

        CRVPedido.ReportSource = informe

        Return True

    End Function



End Class