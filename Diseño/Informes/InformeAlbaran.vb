﻿Imports CrystalDecisions.Shared
Imports System.Configuration
Imports System.Data.SqlClient

Public Class InformeAlbaran

    Dim informe As Object

    Private Sub CRV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRV.Load
        Copias.Text = 1
    End Sub
    Public Function verInforme(ByVal inumAlbaran As Integer, ByVal idIdioma As Integer) As Boolean

        'Tomamos el usuario y la contraseña de la base de datos del la cadena de conexión de la aplicación
        Dim settings As ConnectionStringSettings
        settings = ConfigurationManager.ConnectionStrings(1)
        Dim csb As New SqlConnectionStringBuilder
        csb.ConnectionString = settings.ConnectionString
        If idIdioma = 1 Then
            informe = New Albaran1
            informe.SetDatabaseLogon(csb.UserID, csb.Password)
            informe.SetParameterValue("inumAlbaran", inumAlbaran)
            CRV.ReportSource = informe
        Else
            informe = New Albaran1I
            informe.SetDatabaseLogon(csb.UserID, csb.Password)
            informe.SetParameterValue("inumAlbaran", inumAlbaran)
            CRV.ReportSource = informe
        End If

        Return True

    End Function


    Public Function GeneraPDF(ByVal inumAlbaran As Integer, ByVal idIdioma As Integer, ByVal Fichero As String, ByVal Camino As String) As Boolean

        Try
            Dim settings As ConnectionStringSettings
            settings = ConfigurationManager.ConnectionStrings(1)
            Dim csb As New SqlConnectionStringBuilder
            csb.ConnectionString = settings.ConnectionString
            If idIdioma = 1 Then
                informe = New Albaran1
                informe.SetDatabaseLogon(csb.UserID, csb.Password)
                informe.SetParameterValue("inumAlbaran", inumAlbaran)
                CRV.ReportSource = informe
                informe.ExportToDisk(ExportFormatType.PortableDocFormat, Camino & Fichero)
            Else
                informe = New Albaran1I
                informe.SetDatabaseLogon(csb.UserID, csb.Password)
                informe.SetParameterValue("inumAlbaran", inumAlbaran)
                CRV.ReportSource = informe
                informe.ExportToDisk(ExportFormatType.PortableDocFormat, Camino & Fichero)
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub Copias_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Copias.Click
        sender.selectall()
    End Sub

    Private Sub Copias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Copias.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub bImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImprimir.Click
        If Not informe Is Nothing Then
            If Copias.Text = "" Or Copias.Text = "0" Then Copias.Text = 1
            informe.PrintToPrinter(Copias.Text, False, 1, 999)
        End If

    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

End Class