﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeListadoAlbaranes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CRVPedido = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CRVPedido
        '
        Me.CRVPedido.ActiveViewIndex = -1
        Me.CRVPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.CRVPedido.DisplayGroupTree = False
        Me.CRVPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVPedido.Location = New System.Drawing.Point(0, 0)
        Me.CRVPedido.Name = "CRVPedido"
        Me.CRVPedido.SelectionFormula = ""
        Me.CRVPedido.ShowGroupTreeButton = False
        Me.CRVPedido.ShowRefreshButton = False
        Me.CRVPedido.Size = New System.Drawing.Size(1020, 778)
        Me.CRVPedido.TabIndex = 0
        Me.CRVPedido.ViewTimeSelectionFormula = ""
        '
        'InformeListadoAlbaranes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 778)
        Me.Controls.Add(Me.CRVPedido)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InformeListadoAlbaranes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LSTADO DE ALBARANES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVPedido As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
