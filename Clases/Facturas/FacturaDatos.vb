﻿Public Class DatosFactura

    Private numFactura As Integer
    Private ReferenciaCliente As String
    Private idEstado As Integer
    Private Fecha As Date
    Private FechaEntrega As Date
    Private idCliente As Integer
    Private idUbicacion As Integer
    Private idContacto As Integer
    Private idMedioPago As Integer
    Private idTipoPago As Integer
    Private idCuentaBanco As Integer
    Private codMoneda As String
    Private idTipoIVA As Integer
    Private idTipoRetencion As Integer
    Private RecargoEquivalencia As Boolean
    Private Descuento As Double
    Private Descuento2 As Double
    Private ProntoPago As Double
    Private SolicitadoVia As String
    Private Notas As String   'Se imprimen al final del documento
    Private Observaciones As String 'Sólo se ven en pantalla
    Private TipoRetencionFac As Double 'Datos que se guardan en la factura aunque cambien en la tabla.
    Private TipoIVAFac As Double
    Private TipoRecargoEqFac As Double
    Private idPersona As Integer
    Private PrecioTransporte As Double
    Private idLiquidacion As Integer


    'Datos de otras tablas
    Private Estado As String
    Private numSAbono As List(Of Integer) 'En lo que se ha convertido
    Private Cliente As String
    Private Direccion As String
    Private Contacto As String
    Private MedioPago As String
    Private TipoPago As String
    Private Banco As String
    Private IBAN As String
    Private Divisa As String
    Private Simbolo As String
    Private TipoIVA As Double
    Private NombreTipoIVA As String
    Private TipoRecargoEq As Double
    Private TipoRetencion As Double
    Private NombreTipoRetencion As String
    Private ObservacionesCli As String
    Private numSAlbaran As List(Of Integer) 'los numalbarán incluidos en la factura
    Private Vencimientos As List(Of DatosVencimiento)
    Private Persona As String
    Private LiquidadaComision As Boolean
    Private FechaLiquidacion As Date

    'Calculadas
    Private Base As Double
    Private TotalIVA As Double
    Private TotalRE As Double
    Private Retencion As Double
    Private Total As Double
    Private ImportePP As Double 'Importe del descuento Pronto Pago
    Private ImporteDescuentos As Double
    Private Pendiente As Double 'Importe pendiente de cobro (calculado desde los vencimientos)
    Private PrimerVencimientoNoCobrado As Date


    Public Property gnumFactura() As Integer
        Get
            Return numFactura
        End Get
        Set(ByVal value As Integer)
            numFactura = value
        End Set
    End Property

    Public Property gReferenciaCliente() As String
        Get
            Return ReferenciaCliente
        End Get
        Set(ByVal value As String)
            ReferenciaCliente = value
        End Set
    End Property

    Public Property gidEstado() As Integer
        Get
            Return idEstado
        End Get
        Set(ByVal value As Integer)
            idEstado = value
        End Set
    End Property

    Public Property gFecha() As Date
        Get
            Return Fecha
        End Get
        Set(ByVal value As Date)
            Fecha = value
        End Set
    End Property

    Public Property gFechaEntrega() As Date
        Get
            Return FechaEntrega
        End Get
        Set(ByVal value As Date)
            FechaEntrega = value
        End Set
    End Property

    Public Property gidCliente() As Integer
        Get
            Return idCliente
        End Get
        Set(ByVal value As Integer)
            idCliente = value
        End Set
    End Property

    Public Property gidUbicacion() As Integer
        Get
            Return idUbicacion
        End Get
        Set(ByVal value As Integer)
            idUbicacion = value
        End Set
    End Property

    Public Property gidContacto() As Integer
        Get
            Return idContacto
        End Get
        Set(ByVal value As Integer)
            idContacto = value
        End Set
    End Property

    Public Property gidMedioPago() As Integer
        Get
            Return idMedioPago
        End Get
        Set(ByVal value As Integer)
            idMedioPago = value
        End Set
    End Property

    Public Property gidTipoPago() As Integer
        Get
            Return idTipoPago
        End Get
        Set(ByVal value As Integer)
            idTipoPago = value
        End Set
    End Property

    Public Property gidCuentaBanco() As Integer
        Get
            Return idCuentaBanco
        End Get
        Set(ByVal value As Integer)
            idCuentaBanco = value
        End Set
    End Property

    Public Property gcodMoneda() As String
        Get
            Return codMoneda
        End Get
        Set(ByVal value As String)
            codMoneda = value
        End Set
    End Property

    Public Property gidTipoIVA() As Integer
        Get
            Return idTipoIVA
        End Get
        Set(ByVal value As Integer)
            idTipoIVA = value
        End Set
    End Property

    Public Property gidTipoRetencion() As Integer
        Get
            Return idTipoRetencion
        End Get
        Set(ByVal value As Integer)
            idTipoRetencion = value
        End Set
    End Property

    Public Property gRecargoEquivalencia() As Boolean
        Get
            Return RecargoEquivalencia
        End Get
        Set(ByVal value As Boolean)
            RecargoEquivalencia = value
        End Set
    End Property

    Public Property gDescuento() As Double
        Get
            Return Descuento
        End Get
        Set(ByVal value As Double)
            Descuento = value
        End Set
    End Property

    Public Property gDescuento2() As Double
        Get
            Return Descuento2
        End Get
        Set(ByVal value As Double)
            Descuento2 = value
        End Set
    End Property

    Public Property gProntoPago() As Double
        Get
            Return ProntoPago
        End Get
        Set(ByVal value As Double)
            ProntoPago = value
        End Set
    End Property

    Public Property gSolicitadoVia() As String
        Get
            Return SolicitadoVia
        End Get
        Set(ByVal value As String)
            SolicitadoVia = value
        End Set
    End Property

    Public Property gNotas() As String
        Get
            Return Notas
        End Get
        Set(ByVal value As String)
            Notas = value
        End Set
    End Property

    Public Property gObservaciones() As String
        Get
            Return Observaciones
        End Get
        Set(ByVal value As String)
            Observaciones = value
        End Set
    End Property

    Public Property gTipoRetencionFac() As Double
        Get
            Return TipoRetencionFac
        End Get
        Set(ByVal value As Double)
            TipoRetencionFac = value
        End Set
    End Property


    Public Property gTipoIVAFac() As Double
        Get
            Return TipoIVAFac
        End Get
        Set(ByVal value As Double)
            TipoIVAFac = value
        End Set
    End Property


    Public Property gTipoRecargoEqFac() As Double
        Get
            Return TipoRecargoEqFac
        End Get
        Set(ByVal value As Double)
            TipoRecargoEqFac = value
        End Set
    End Property

    Public Property gidPersona() As Integer
        Get
            Return idPersona
        End Get
        Set(ByVal value As Integer)
            idPersona = value
        End Set
    End Property

    Public Property gidLiquidacion() As Integer
        Get
            Return idLiquidacion
        End Get
        Set(ByVal value As Integer)
            idLiquidacion = value
        End Set
    End Property


  

    'Otras tablas

    Public Property gEstado() As String
        Get
            Return Estado
        End Get
        Set(ByVal value As String)
            Estado = value
        End Set
    End Property

    Public Property gnumSAbono() As List(Of Integer)
        Get
            Return numSAbono
        End Get
        Set(ByVal value As List(Of Integer))
            numSAbono = value
        End Set
    End Property

  


    Public Property gPrecioTransporte() As Double
        Get
            Return PrecioTransporte
        End Get
        Set(ByVal value As Double)
            PrecioTransporte = value
        End Set
    End Property

    Public Property gCliente() As String
        Get
            Return Cliente
        End Get
        Set(ByVal value As String)
            Cliente = value
        End Set
    End Property

    Public Property gDireccion() As String
        Get
            Return Direccion
        End Get
        Set(ByVal value As String)
            Direccion = value
        End Set
    End Property

    Public Property gContacto() As String
        Get
            Return Contacto
        End Get
        Set(ByVal value As String)
            Contacto = value
        End Set
    End Property


    Public Property gMedioPago() As String
        Get
            Return MedioPago
        End Get
        Set(ByVal value As String)
            MedioPago = value
        End Set
    End Property

    Public Property gTipoPago() As String
        Get
            Return TipoPago
        End Get
        Set(ByVal value As String)
            TipoPago = value
        End Set
    End Property

    Public Property gBanco() As String
        Get
            Return Banco
        End Get
        Set(ByVal value As String)
            Banco = value
        End Set
    End Property

    Public Property gIBAN() As String
        Get
            Return IBAN
        End Get
        Set(ByVal value As String)
            IBAN = value
        End Set
    End Property

    Public Property gDivisa() As String
        Get
            Return Divisa
        End Get
        Set(ByVal value As String)
            Divisa = value
        End Set
    End Property

    Public Property gSimbolo() As String
        Get
            Return Simbolo
        End Get
        Set(ByVal value As String)
            Simbolo = value
        End Set
    End Property

    Public Property gTipoIVA() As Double
        Get
            Return TipoIVA
        End Get
        Set(ByVal value As Double)
            TipoIVA = value
        End Set
    End Property

    Public Property gNombreTipoIVA() As String
        Get
            Return NombreTipoIVA
        End Get
        Set(ByVal value As String)
            NombreTipoIVA = value
        End Set
    End Property

    Public Property gTipoRecargoEq() As Double
        Get
            Return TipoRecargoEq
        End Get
        Set(ByVal value As Double)
            TipoRecargoEq = value
        End Set
    End Property

    Public Property gTipoRetencion() As Double
        Get
            Return TipoRetencion
        End Get
        Set(ByVal value As Double)
            TipoRetencion = value
        End Set
    End Property

    Public Property gNombreTipoRetencion() As String
        Get
            Return NombreTipoRetencion
        End Get
        Set(ByVal value As String)
            NombreTipoRetencion = value
        End Set
    End Property


    Public Property gObservacionesCli() As String
        Get
            Return ObservacionesCli
        End Get
        Set(ByVal value As String)
            ObservacionesCli = value
        End Set
    End Property


    Public Property gnumsAlbaran() As List(Of Integer)
        Get
            Return numSAlbaran
        End Get
        Set(ByVal value As List(Of Integer))
            numSAlbaran = value
        End Set
    End Property

    Public Property gLiquidadaComision() As Boolean
        Get
            Return LiquidadaComision
        End Get
        Set(ByVal value As Boolean)
            LiquidadaComision = value
        End Set
    End Property

    Public Property gFechaLiquidacion() As Date
        Get
            Return FechaLiquidacion
        End Get
        Set(ByVal value As Date)
            FechaLiquidacion = value
        End Set
    End Property

    'Calculadas

    Public Property gBase() As Double
        Get
            Return Base
        End Get
        Set(ByVal value As Double)
            Base = value
        End Set
    End Property

    Public Property gTotalIVA() As Double
        Get
            Return TotalIVA
        End Get
        Set(ByVal value As Double)
            TotalIVA = value
        End Set
    End Property

    Public Property gTotalRE() As Double
        Get
            Return TotalRE
        End Get
        Set(ByVal value As Double)
            TotalRE = value
        End Set
    End Property

    Public Property gRetencion() As Double
        Get
            Return Retencion
        End Get
        Set(ByVal value As Double)
            Retencion = value
        End Set
    End Property

    Public Property gTotal() As Double
        Get
            Return Total
        End Get
        Set(ByVal value As Double)
            Total = value
        End Set
    End Property

    Public Property gImportePP() As Double
        Get
            Return ImportePP
        End Get
        Set(ByVal value As Double)
            ImportePP = value
        End Set
    End Property

  

    Public Property gImporteDescuentos() As Double
        Get
            Return ImporteDescuentos
        End Get
        Set(ByVal value As Double)
            ImporteDescuentos = value
        End Set
    End Property

    Public Property gVencimientos() As List(Of DatosVencimiento)
        Get
            Return Vencimientos
        End Get
        Set(ByVal value As List(Of DatosVencimiento))
            Vencimientos = value
        End Set
    End Property

    Public Property gPersona() As String
        Get
            Return Persona
        End Get
        Set(ByVal value As String)
            Persona = value
        End Set
    End Property

    Public Property gPendiente() As Double
        Get
            Return Pendiente
        End Get
        Set(ByVal value As Double)
            Pendiente = value
        End Set
    End Property

    Public Property gPrimerVencimientoNoCobrado() As Date
        Get
            Return PrimerVencimientoNoCobrado
        End Get
        Set(ByVal value As Date)
            PrimerVencimientoNoCobrado = value
        End Set
    End Property

End Class

