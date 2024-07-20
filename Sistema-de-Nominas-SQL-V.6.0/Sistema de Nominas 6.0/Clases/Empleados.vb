Public Class Empleados

    Private CodEmpleado As Double
    Private CodEmpleado1 As String
    Private Nombre1 As String
    Private Nombre2 As String
    Private Apellido1 As String
    Private Apellido2 As String
    Private NumHijos As Double
    Private Direccion As String
    Private Nacionalidad As String
    Private CodigoPostal As String
    Private Sexo As String
    Private CodInss As String
    Private CodIr As String
    Private NumCedula As String
    Private Sindicalista As String
    Private CodDepartamento As String
    Private CodGrupo As String
    Private CodCargo As String
    Private NumeroInss As String
    Private NumeroRuc As String
    Private CodTipoNomina As String
    Private DiasDescuento As Double
    Private SalPorcentaje As Double
    Private CantPts As Double
    Private SueldoPeriodo As Double
    Private TarifaHoraria As Double
    Private PorcentajeComision As Double
    Private OtrosIngresos As Double
    Private DescripOtrIngre As String
    Private ExentoInss As Boolean
    Private ExentoIr As Boolean
    Private PagoInssPatronal As Boolean
    Private SalarioMinimo As Boolean
    Private Observaciones As String
    Private Activo As Boolean
    Private Liquidado As Boolean
    Private Ausente As Boolean
    Private SalarioFijo As String
    Private SumarSubsidio As Boolean
    Private PorcientoIncentivo As Double
    Private Gravidez As Boolean
    Private VacacionesBasico As Boolean
    Private Dolarizado As Boolean
    Private FechaAntiguedad As String
    Private Antiguedad As Boolean
    Private CuentaBanco As String
    Private SueldoActualBasico As Boolean
    Private HorasTurno As Boolean
    Private DiasBasico As Double
    Private AumentoBasico As Double
    Private EmpleadoConstruccion As Boolean
    Private MontoPension As Double
    Private PorcentajePension As Double
    Private ViaticoxDia As Double
    Private DeducirPorciento As Boolean
    Private Reembolso As Double
    Private Telefono As String
    Private MontoViatico As Double

    '////////////////HISTORICO EMPLEADOS //////////////////////////////
    Private Id As Integer
    Private FechaBaja As Date
    Private MotivoBaja As String
    Private MotivoAumento As String
    Private FechaInicialSusp As Date
    Private FechaFinalSusp As Date
    Private MotivoSuspencion As String
    Private FechaNacimiento As Date
    Private FechaContrato As Date
    Private FechaContratoVac As Date
    Private CargoInicial As String
    Private CargoActual As String
    Private CargoAnterior As String
    Private SueldoInicial As Double
    Private SueldoAnterior As Double
    Private SueldoActual As Double
    Private CuentaDebito As String
    Private CuentaCredito As String
    Private CuentaPrestamo As String
    Private CuentaOtrosIngresos As String
    Private CuentaINSS As String
    Private CuentaIR As String
    Private CuentaSueldos As String
    Private ProvAguinaldo As String
    Private ProvVacaciones As String
    Private INSSPatronal As String
    Private INATEC As String
    Private AguinaldoxPagar As String
    Private VacacionesxPagar As String
    Private INSSxPagar As String
    Private INATECxPagar As String
    Private IRxPagar As String
    Private PrestamoxPagar As String
    Private NominaxPagar As String
    Private CuentaHorasExtra As String
    Private INSSPatronalPagar As String
    Private CuentaSubsidio As String

    Public Property Cod_Empleado As Double
        Get
            Return CodEmpleado
        End Get
        Set(value As Double)
            CodEmpleado = value
        End Set
    End Property

    Public Property Cod_Empleado1 As String
        Get
            Return CodEmpleado1
        End Get
        Set(value As String)
            CodEmpleado1 = value
        End Set
    End Property

    Public Property Primer_Nombre As String
        Get
            Return Nombre1
        End Get
        Set(value As String)
            Nombre1 = value
        End Set
    End Property

    Public Property Segundo_Nombre As String
        Get
            Return Nombre2
        End Get
        Set(value As String)
            Nombre2 = value
        End Set
    End Property

    Public Property Primer_Apellido As String
        Get
            Return Apellido1
        End Get
        Set(value As String)
            Apellido1 = value
        End Set
    End Property

    Public Property Segundo_Apellido As String
        Get
            Return Apellido2
        End Get
        Set(value As String)
            Apellido2 = value
        End Set
    End Property

    Public Property Num_Hijos As Double
        Get
            Return NumHijos
        End Get
        Set(value As Double)
            NumHijos = value
        End Set
    End Property

    Public Property Empleado_Direccion As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    Public Property Empleado_Nacionalidad As String
        Get
            Return Nacionalidad
        End Get
        Set(value As String)
            Nacionalidad = value
        End Set
    End Property

    Public Property Codigo_Postal As String
        Get
            Return CodigoPostal
        End Get
        Set(value As String)
            CodigoPostal = value
        End Set
    End Property

    Public Property Empleado_Sexo As String
        Get
            Return Sexo
        End Get
        Set(value As String)
            Sexo = value
        End Set
    End Property

    Public Property Cod_Inss As String
        Get
            Return CodInss
        End Get
        Set(value As String)
            CodInss = value
        End Set
    End Property

    Public Property Cod_Ir As String
        Get
            Return CodIr
        End Get
        Set(value As String)
            CodIr = value
        End Set
    End Property

    Public Property Num_Cedula As String
        Get
            Return NumCedula
        End Get
        Set(value As String)
            NumCedula = value
        End Set
    End Property

    Public Property Empleado_Sindicalista As String
        Get
            Return Sindicalista
        End Get
        Set(value As String)
            Sindicalista = value
        End Set
    End Property

    Public Property Cod_Departamento As String
        Get
            Return CodDepartamento
        End Get
        Set(value As String)
            CodDepartamento = value
        End Set
    End Property

    Public Property Cod_Grupo As String
        Get
            Return CodGrupo
        End Get
        Set(value As String)
            CodGrupo = value
        End Set
    End Property

    Public Property Cod_Cargo As String
        Get
            Return CodCargo
        End Get
        Set(value As String)
            CodCargo = value
        End Set
    End Property

    Public Property Numero_Inss As String
        Get
            Return NumeroInss
        End Get
        Set(value As String)
            NumeroInss = value
        End Set
    End Property

    Public Property Numero_Ruc As String
        Get
            Return NumeroRuc
        End Get
        Set(value As String)
            NumeroRuc = value
        End Set
    End Property

    Public Property Cod_TipoNomina As String
        Get
            Return CodTipoNomina
        End Get
        Set(value As String)
            CodTipoNomina = value
        End Set
    End Property

    Public Property Dias_Descuento As Double
        Get
            Return DiasDescuento
        End Get
        Set(value As Double)
            DiasDescuento = value
        End Set
    End Property

    Public Property Sal_Porcentaje As Double
        Get
            Return SalPorcentaje
        End Get
        Set(value As Double)
            SalPorcentaje = value
        End Set
    End Property

    Public Property Cant_Pts As Double
        Get
            Return CantPts
        End Get
        Set(value As Double)
            CantPts = value
        End Set
    End Property

    Public Property Sueldo_Periodo As Double
        Get
            Return SueldoPeriodo
        End Get
        Set(value As Double)
            SueldoPeriodo = value
        End Set
    End Property

    Public Property Tarifa_Horaria As Double
        Get
            Return TarifaHoraria
        End Get
        Set(value As Double)
            TarifaHoraria = value
        End Set
    End Property

    Public Property Porcentaje_Comision As Double
        Get
            Return PorcentajeComision
        End Get
        Set(value As Double)
            PorcentajeComision = value
        End Set
    End Property

    Public Property Otros_Ingresos As Double
        Get
            Return OtrosIngresos
        End Get
        Set(value As Double)
            OtrosIngresos = value
        End Set
    End Property

    Public Property Descrip_OtrIngre As String
        Get
            Return DescripOtrIngre
        End Get
        Set(value As String)
            DescripOtrIngre = value
        End Set
    End Property

    Public Property Exento_Inss As Boolean
        Get
            Return ExentoInss
        End Get
        Set(value As Boolean)
            ExentoInss = value
        End Set
    End Property

    Public Property Exento_Ir As Boolean
        Get
            Return ExentoIr
        End Get
        Set(value As Boolean)
            ExentoIr = value
        End Set
    End Property

    Public Property PagoInss_Patronal As Boolean
        Get
            Return PagoInssPatronal
        End Get
        Set(value As Boolean)
            PagoInssPatronal = value
        End Set
    End Property

    Public Property Salario_Minimo As Boolean
        Get
            Return SalarioMinimo
        End Get
        Set(value As Boolean)
            SalarioMinimo = value
        End Set
    End Property

    Public Property Empleado_Observaciones As String
        Get
            Return Observaciones
        End Get
        Set(value As String)
            Observaciones = value
        End Set
    End Property

    Public Property Empleado_Activo As Boolean
        Get
            Return Activo
        End Get
        Set(value As Boolean)
            Activo = value
        End Set
    End Property

    Public Property Empleado_Liquidado As Boolean
        Get
            Return Liquidado
        End Get
        Set(value As Boolean)
            Liquidado = value
        End Set
    End Property

    Public Property Empleado_Ausente As Boolean
        Get
            Return Ausente
        End Get
        Set(value As Boolean)
            Ausente = value
        End Set
    End Property

    Public Property Salario_Fijo As String
        Get
            Return SalarioFijo
        End Get
        Set(value As String)
            SalarioFijo = value
        End Set
    End Property

    Public Property Sumar_Subsidio As Boolean
        Get
            Return SumarSubsidio
        End Get
        Set(value As Boolean)
            SumarSubsidio = value
        End Set
    End Property

    Public Property Porciento_Incentivo As Double
        Get
            Return PorcientoIncentivo
        End Get
        Set(value As Double)
            PorcientoIncentivo = value
        End Set
    End Property

    Public Property Empleado_Gravidez As Boolean
        Get
            Return Gravidez
        End Get
        Set(value As Boolean)
            Gravidez = value
        End Set
    End Property

    Public Property Vacaciones_Basico As Boolean
        Get
            Return VacacionesBasico
        End Get
        Set(value As Boolean)
            VacacionesBasico = value
        End Set
    End Property

    Public Property Empleado_Dolarizado As Boolean
        Get
            Return Dolarizado
        End Get
        Set(value As Boolean)
            Dolarizado = value
        End Set
    End Property

    Public Property Fecha_Antiguedad As String
        Get
            Return FechaAntiguedad
        End Get
        Set(value As String)
            FechaAntiguedad = value
        End Set
    End Property

    Public Property Empleado_Antiguedad As Boolean
        Get
            Return Antiguedad
        End Get
        Set(value As Boolean)
            Antiguedad = value
        End Set
    End Property

    Public Property Empleado_CuentaBanco As String
        Get
            Return CuentaBanco
        End Get
        Set(value As String)
            CuentaBanco = value
        End Set
    End Property

    Public Property SueldoActual_Basico As Boolean
        Get
            Return SueldoActualBasico
        End Get
        Set(value As Boolean)
            SueldoActualBasico = value
        End Set
    End Property

    Public Property Horas_Turno As Boolean
        Get
            Return HorasTurno
        End Get
        Set(value As Boolean)
            HorasTurno = value
        End Set
    End Property

    Public Property Dias_Basico As Double
        Get
            Return DiasBasico
        End Get
        Set(value As Double)
            DiasBasico = value
        End Set
    End Property

    Public Property Aumento_Basico As Double
        Get
            Return AumentoBasico
        End Get
        Set(value As Double)
            AumentoBasico = value
        End Set
    End Property

    Public Property Empleado_Construccion As Boolean
        Get
            Return EmpleadoConstruccion
        End Get
        Set(value As Boolean)
            EmpleadoConstruccion = value
        End Set
    End Property

    Public Property Monto_Pension As Double
        Get
            Return MontoPension
        End Get
        Set(value As Double)
            MontoPension = value
        End Set
    End Property

    Public Property Porcentaje_Pension As Double
        Get
            Return PorcentajePension
        End Get
        Set(value As Double)
            PorcentajePension = value
        End Set
    End Property

    Public Property Viatico_Dia As Double
        Get
            Return ViaticoxDia
        End Get
        Set(value As Double)
            ViaticoxDia = value
        End Set
    End Property

    Public Property Deducir_Porciento As Boolean
        Get
            Return DeducirPorciento
        End Get
        Set(value As Boolean)
            DeducirPorciento = value
        End Set
    End Property

    Public Property Empleado_Reembolso As Double
        Get
            Return Reembolso
        End Get
        Set(value As Double)
            Reembolso = value
        End Set
    End Property

    Public Property Empleado_Telefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property

    Public Property Monto_Viatico As Double
        Get
            Return MontoViatico
        End Get
        Set(value As Double)
            MontoViatico = value
        End Set
    End Property

    Public Property Empleado_Id As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property

    Public Property Fecha_Baja As Date
        Get
            Return FechaBaja
        End Get
        Set(value As Date)
            FechaBaja = value
        End Set
    End Property

    Public Property Motivo_Baja As String
        Get
            Return MotivoBaja
        End Get
        Set(value As String)
            MotivoBaja = value
        End Set
    End Property

    Public Property Motivo_Aumento As String
        Get
            Return MotivoAumento
        End Get
        Set(value As String)
            MotivoAumento = value
        End Set
    End Property

    Public Property FechaInicial_Susp As Date
        Get
            Return FechaInicialSusp
        End Get
        Set(value As Date)
            FechaInicialSusp = value
        End Set
    End Property

    Public Property FechaFinal_Susp As Date
        Get
            Return FechaFinalSusp
        End Get
        Set(value As Date)
            FechaFinalSusp = value
        End Set
    End Property

    Public Property Motivo_Suspencion As String
        Get
            Return MotivoSuspencion
        End Get
        Set(value As String)
            MotivoSuspencion = value
        End Set
    End Property

    Public Property Fecha_Nacimiento As Date
        Get
            Return FechaNacimiento
        End Get
        Set(value As Date)
            FechaNacimiento = value
        End Set
    End Property

    Public Property Fecha_Contrato As Date
        Get
            Return FechaContrato
        End Get
        Set(value As Date)
            FechaContrato = value
        End Set
    End Property

    Public Property Fecha_ContratoVac As Date
        Get
            Return FechaContratoVac
        End Get
        Set(value As Date)
            FechaContratoVac = value
        End Set
    End Property

    Public Property Cargo_Inicial As String
        Get
            Return CargoInicial
        End Get
        Set(value As String)
            CargoInicial = value
        End Set
    End Property

    Public Property Cargo_Actual As String
        Get
            Return CargoActual
        End Get
        Set(value As String)
            CargoActual = value
        End Set
    End Property

    Public Property Cargo_Anterior As String
        Get
            Return CargoAnterior
        End Get
        Set(value As String)
            CargoAnterior = value
        End Set
    End Property

    Public Property Sueldo_Inicial As Double
        Get
            Return SueldoInicial
        End Get
        Set(value As Double)
            SueldoInicial = value
        End Set
    End Property

    Public Property Sueldo_Anterior As Double
        Get
            Return SueldoAnterior
        End Get
        Set(value As Double)
            SueldoAnterior = value
        End Set
    End Property

    Public Property Sueldo_Actual As Double
        Get
            Return SueldoActual
        End Get
        Set(value As Double)
            SueldoActual = value
        End Set
    End Property

    Public Property Cuenta_Debito As String
        Get
            Return CuentaDebito
        End Get
        Set(value As String)
            CuentaDebito = value
        End Set
    End Property

    Public Property Cuenta_Credito As String
        Get
            Return CuentaCredito
        End Get
        Set(value As String)
            CuentaCredito = value
        End Set
    End Property

    Public Property Cuenta_Prestamo As String
        Get
            Return CuentaPrestamo
        End Get
        Set(value As String)
            CuentaPrestamo = value
        End Set
    End Property

    Public Property CuentaOtros_Ingresos As String
        Get
            Return CuentaOtrosIngresos
        End Get
        Set(value As String)
            CuentaOtrosIngresos = value
        End Set
    End Property

    Public Property Cuenta_INSS As String
        Get
            Return CuentaINSS
        End Get
        Set(value As String)
            CuentaINSS = value
        End Set
    End Property

    Public Property Cuenta_IR As String
        Get
            Return CuentaIR
        End Get
        Set(value As String)
            CuentaIR = value
        End Set
    End Property

    Public Property Cuenta_Sueldos As String
        Get
            Return CuentaSueldos
        End Get
        Set(value As String)
            CuentaSueldos = value
        End Set
    End Property

    Public Property Prov_Aguinaldo As String
        Get
            Return ProvAguinaldo
        End Get
        Set(value As String)
            ProvAguinaldo = value
        End Set
    End Property

    Public Property Prov_Vacaciones As String
        Get
            Return ProvVacaciones
        End Get
        Set(value As String)
            ProvVacaciones = value
        End Set
    End Property

    Public Property INSS_Patronal As String
        Get
            Return INSSPatronal
        End Get
        Set(value As String)
            INSSPatronal = value
        End Set
    End Property

    Public Property Empleado_INATEC As String
        Get
            Return INATEC
        End Get
        Set(value As String)
            INATEC = value
        End Set
    End Property

    Public Property Aguinaldo_Pagar As String
        Get
            Return AguinaldoxPagar
        End Get
        Set(value As String)
            AguinaldoxPagar = value
        End Set
    End Property

    Public Property Vacaciones_Pagar As String
        Get
            Return VacacionesxPagar
        End Get
        Set(value As String)
            VacacionesxPagar = value
        End Set
    End Property

    Public Property INSS_Pagar As String
        Get
            Return INSSxPagar
        End Get
        Set(value As String)
            INSSxPagar = value
        End Set
    End Property

    Public Property INATEC_Pagar As String
        Get
            Return INATECxPagar
        End Get
        Set(value As String)
            INATECxPagar = value
        End Set
    End Property

    Public Property IR_Pagar As String
        Get
            Return IRxPagar
        End Get
        Set(value As String)
            IRxPagar = value
        End Set
    End Property

    Public Property Prestamo_Pagar As String
        Get
            Return PrestamoxPagar
        End Get
        Set(value As String)
            PrestamoxPagar = value
        End Set
    End Property

    Public Property Nomina_Pagar As String
        Get
            Return NominaxPagar
        End Get
        Set(value As String)
            NominaxPagar = value
        End Set
    End Property

    Public Property CuentaHoras_Extra As String
        Get
            Return CuentaHorasExtra
        End Get
        Set(value As String)
            CuentaHorasExtra = value
        End Set
    End Property

    Public Property INSSPatronal_Pagar As String
        Get
            Return INSSPatronalPagar
        End Get
        Set(value As String)
            INSSPatronalPagar = value
        End Set
    End Property

    Public Property Cuenta_Subsidio As String
        Get
            Return CuentaSubsidio
        End Get
        Set(value As String)
            CuentaSubsidio = value
        End Set
    End Property





End Class
