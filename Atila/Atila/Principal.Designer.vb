<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.pnlArriba = New System.Windows.Forms.Panel()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.lblCantidadDeNotificaciones = New System.Windows.Forms.Label()
        Me.btnNotificaciones = New System.Windows.Forms.Button()
        Me.lblPerfil = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pnlCuadroNotificaciones = New System.Windows.Forms.Panel()
        Me.llblPaginaAnterior = New System.Windows.Forms.LinkLabel()
        Me.pnlNotificacion1 = New System.Windows.Forms.Panel()
        Me.lblNotificacion1Texto = New System.Windows.Forms.Label()
        Me.lblNotificacion1Motivo = New System.Windows.Forms.Label()
        Me.lblNotificacion1Fecha = New System.Windows.Forms.Label()
        Me.lblNotificacion1Hora = New System.Windows.Forms.Label()
        Me.btnNotificacion1Cancelar = New System.Windows.Forms.Button()
        Me.btnNotificacion1Aceptar = New System.Windows.Forms.Button()
        Me.pnlNotificacion3 = New System.Windows.Forms.Panel()
        Me.lblNotificacion3Texto = New System.Windows.Forms.Label()
        Me.lblNotificacion3Motivo = New System.Windows.Forms.Label()
        Me.lblNotificacion3Fecha = New System.Windows.Forms.Label()
        Me.lblNotificacion3Hora = New System.Windows.Forms.Label()
        Me.btnNotificacion3Cancelar = New System.Windows.Forms.Button()
        Me.btnNotificacion3Aceptar = New System.Windows.Forms.Button()
        Me.llblPaginaSiguiente = New System.Windows.Forms.LinkLabel()
        Me.pnlNotificacion2 = New System.Windows.Forms.Panel()
        Me.lblNotificacion2Texto = New System.Windows.Forms.Label()
        Me.lblNotificacion2Motivo = New System.Windows.Forms.Label()
        Me.lblNotificacion2Fecha = New System.Windows.Forms.Label()
        Me.lblNotificacion2Hora = New System.Windows.Forms.Label()
        Me.btnNotificacion2Cancelar = New System.Windows.Forms.Button()
        Me.btnNotificacion2Aceptar = New System.Windows.Forms.Button()
        Me.lblNoHayNotificaciones = New System.Windows.Forms.Label()
        Me.pnlMostrador = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.lblDesplegadorNormal = New System.Windows.Forms.Label()
        Me.lblDesplegadorAbajo = New System.Windows.Forms.Label()
        Me.pnlApartadoSeleccionado = New System.Windows.Forms.Panel()
        Me.Atila = New System.Windows.Forms.Label()
        Me.pnlConfiguracion = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnCostos = New System.Windows.Forms.Button()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.btnGanancias = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnReservas = New System.Windows.Forms.Button()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.pbLogoAtilaGrande = New System.Windows.Forms.PictureBox()
        Me.timerMostrarConfiguracion = New System.Windows.Forms.Timer(Me.components)
        Me.timerOcultarConfiguracion = New System.Windows.Forms.Timer(Me.components)
        Me.timerMostrarNotificacion = New System.Windows.Forms.Timer(Me.components)
        Me.timerOcultarNotificacion = New System.Windows.Forms.Timer(Me.components)
        Me.pnlArriba.SuspendLayout()
        Me.pnlCuadroNotificaciones.SuspendLayout()
        Me.pnlNotificacion1.SuspendLayout()
        Me.pnlNotificacion3.SuspendLayout()
        Me.pnlNotificacion2.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlConfiguracion.SuspendLayout()
        CType(Me.pbLogoAtilaGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlArriba
        '
        Me.pnlArriba.Controls.Add(Me.btnAyuda)
        Me.pnlArriba.Controls.Add(Me.lblCantidadDeNotificaciones)
        Me.pnlArriba.Controls.Add(Me.btnNotificaciones)
        Me.pnlArriba.Controls.Add(Me.lblPerfil)
        Me.pnlArriba.Controls.Add(Me.btnMinimizar)
        Me.pnlArriba.Controls.Add(Me.btnCerrar)
        Me.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlArriba.Location = New System.Drawing.Point(0, 0)
        Me.pnlArriba.Name = "pnlArriba"
        Me.pnlArriba.Size = New System.Drawing.Size(1550, 43)
        Me.pnlArriba.TabIndex = 17
        '
        'btnAyuda
        '
        Me.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAyuda.FlatAppearance.BorderSize = 0
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Image = Global.Atila.My.Resources.Resources.LOGO_PEQUEÑITO
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAyuda.Location = New System.Drawing.Point(7, 2)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(51, 36)
        Me.btnAyuda.TabIndex = 23
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'lblCantidadDeNotificaciones
        '
        Me.lblCantidadDeNotificaciones.AutoSize = True
        Me.lblCantidadDeNotificaciones.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadDeNotificaciones.ForeColor = System.Drawing.Color.Red
        Me.lblCantidadDeNotificaciones.Location = New System.Drawing.Point(1413, 7)
        Me.lblCantidadDeNotificaciones.Name = "lblCantidadDeNotificaciones"
        Me.lblCantidadDeNotificaciones.Size = New System.Drawing.Size(19, 14)
        Me.lblCantidadDeNotificaciones.TabIndex = 29
        Me.lblCantidadDeNotificaciones.Text = "+9"
        '
        'btnNotificaciones
        '
        Me.btnNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotificaciones.FlatAppearance.BorderSize = 0
        Me.btnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificaciones.Image = Global.Atila.My.Resources.Resources.icono_campanita_solita
        Me.btnNotificaciones.Location = New System.Drawing.Point(1412, 0)
        Me.btnNotificaciones.Name = "btnNotificaciones"
        Me.btnNotificaciones.Size = New System.Drawing.Size(40, 40)
        Me.btnNotificaciones.TabIndex = 24
        Me.btnNotificaciones.UseVisualStyleBackColor = True
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfil.Location = New System.Drawing.Point(1309, 11)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(98, 18)
        Me.lblPerfil.TabIndex = 21
        Me.lblPerfil.Text = "Modo Prueba"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Atila.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMinimizar.Location = New System.Drawing.Point(1463, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(45, 43)
        Me.btnMinimizar.TabIndex = 19
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.Location = New System.Drawing.Point(1505, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 43)
        Me.btnCerrar.TabIndex = 18
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'pnlCuadroNotificaciones
        '
        Me.pnlCuadroNotificaciones.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pnlCuadroNotificaciones.Controls.Add(Me.llblPaginaAnterior)
        Me.pnlCuadroNotificaciones.Controls.Add(Me.pnlNotificacion1)
        Me.pnlCuadroNotificaciones.Controls.Add(Me.pnlNotificacion3)
        Me.pnlCuadroNotificaciones.Controls.Add(Me.llblPaginaSiguiente)
        Me.pnlCuadroNotificaciones.Controls.Add(Me.pnlNotificacion2)
        Me.pnlCuadroNotificaciones.Controls.Add(Me.lblNoHayNotificaciones)
        Me.pnlCuadroNotificaciones.Location = New System.Drawing.Point(1090, 36)
        Me.pnlCuadroNotificaciones.Name = "pnlCuadroNotificaciones"
        Me.pnlCuadroNotificaciones.Size = New System.Drawing.Size(366, 469)
        Me.pnlCuadroNotificaciones.TabIndex = 23
        Me.pnlCuadroNotificaciones.Visible = False
        '
        'llblPaginaAnterior
        '
        Me.llblPaginaAnterior.AutoSize = True
        Me.llblPaginaAnterior.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblPaginaAnterior.LinkColor = System.Drawing.SystemColors.GrayText
        Me.llblPaginaAnterior.Location = New System.Drawing.Point(15, 447)
        Me.llblPaginaAnterior.Name = "llblPaginaAnterior"
        Me.llblPaginaAnterior.Size = New System.Drawing.Size(54, 14)
        Me.llblPaginaAnterior.TabIndex = 35
        Me.llblPaginaAnterior.TabStop = True
        Me.llblPaginaAnterior.Text = "< Anterior"
        Me.llblPaginaAnterior.Visible = False
        '
        'pnlNotificacion1
        '
        Me.pnlNotificacion1.BackColor = System.Drawing.SystemColors.Info
        Me.pnlNotificacion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNotificacion1.Controls.Add(Me.lblNotificacion1Texto)
        Me.pnlNotificacion1.Controls.Add(Me.lblNotificacion1Motivo)
        Me.pnlNotificacion1.Controls.Add(Me.lblNotificacion1Fecha)
        Me.pnlNotificacion1.Controls.Add(Me.lblNotificacion1Hora)
        Me.pnlNotificacion1.Controls.Add(Me.btnNotificacion1Cancelar)
        Me.pnlNotificacion1.Controls.Add(Me.btnNotificacion1Aceptar)
        Me.pnlNotificacion1.Location = New System.Drawing.Point(0, 0)
        Me.pnlNotificacion1.Name = "pnlNotificacion1"
        Me.pnlNotificacion1.Size = New System.Drawing.Size(366, 148)
        Me.pnlNotificacion1.TabIndex = 29
        '
        'lblNotificacion1Texto
        '
        Me.lblNotificacion1Texto.AutoSize = True
        Me.lblNotificacion1Texto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion1Texto.Location = New System.Drawing.Point(8, 10)
        Me.lblNotificacion1Texto.Name = "lblNotificacion1Texto"
        Me.lblNotificacion1Texto.Size = New System.Drawing.Size(350, 36)
        Me.lblNotificacion1Texto.TabIndex = 37
        Me.lblNotificacion1Texto.Text = "Confirmar si la siguiente reserva se ha realizado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "correctamente." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblNotificacion1Texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotificacion1Motivo
        '
        Me.lblNotificacion1Motivo.AutoSize = True
        Me.lblNotificacion1Motivo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion1Motivo.Location = New System.Drawing.Point(18, 64)
        Me.lblNotificacion1Motivo.Name = "lblNotificacion1Motivo"
        Me.lblNotificacion1Motivo.Size = New System.Drawing.Size(41, 15)
        Me.lblNotificacion1Motivo.TabIndex = 32
        Me.lblNotificacion1Motivo.Text = "Motivo"
        '
        'lblNotificacion1Fecha
        '
        Me.lblNotificacion1Fecha.AutoSize = True
        Me.lblNotificacion1Fecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion1Fecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNotificacion1Fecha.Location = New System.Drawing.Point(117, 64)
        Me.lblNotificacion1Fecha.Name = "lblNotificacion1Fecha"
        Me.lblNotificacion1Fecha.Size = New System.Drawing.Size(69, 15)
        Me.lblNotificacion1Fecha.TabIndex = 31
        Me.lblNotificacion1Fecha.Text = "00/00/0000"
        '
        'lblNotificacion1Hora
        '
        Me.lblNotificacion1Hora.AutoSize = True
        Me.lblNotificacion1Hora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion1Hora.Location = New System.Drawing.Point(213, 64)
        Me.lblNotificacion1Hora.Name = "lblNotificacion1Hora"
        Me.lblNotificacion1Hora.Size = New System.Drawing.Size(34, 15)
        Me.lblNotificacion1Hora.TabIndex = 30
        Me.lblNotificacion1Hora.Text = "Hora"
        '
        'btnNotificacion1Cancelar
        '
        Me.btnNotificacion1Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotificacion1Cancelar.FlatAppearance.BorderSize = 0
        Me.btnNotificacion1Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificacion1Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotificacion1Cancelar.Location = New System.Drawing.Point(216, 105)
        Me.btnNotificacion1Cancelar.Name = "btnNotificacion1Cancelar"
        Me.btnNotificacion1Cancelar.Size = New System.Drawing.Size(81, 28)
        Me.btnNotificacion1Cancelar.TabIndex = 29
        Me.btnNotificacion1Cancelar.Text = "Cancelar"
        Me.btnNotificacion1Cancelar.UseVisualStyleBackColor = True
        '
        'btnNotificacion1Aceptar
        '
        Me.btnNotificacion1Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotificacion1Aceptar.FlatAppearance.BorderSize = 0
        Me.btnNotificacion1Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificacion1Aceptar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotificacion1Aceptar.Location = New System.Drawing.Point(83, 105)
        Me.btnNotificacion1Aceptar.Name = "btnNotificacion1Aceptar"
        Me.btnNotificacion1Aceptar.Size = New System.Drawing.Size(81, 28)
        Me.btnNotificacion1Aceptar.TabIndex = 26
        Me.btnNotificacion1Aceptar.Text = "Aceptar"
        Me.btnNotificacion1Aceptar.UseVisualStyleBackColor = True
        '
        'pnlNotificacion3
        '
        Me.pnlNotificacion3.BackColor = System.Drawing.SystemColors.Info
        Me.pnlNotificacion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNotificacion3.Controls.Add(Me.lblNotificacion3Texto)
        Me.pnlNotificacion3.Controls.Add(Me.lblNotificacion3Motivo)
        Me.pnlNotificacion3.Controls.Add(Me.lblNotificacion3Fecha)
        Me.pnlNotificacion3.Controls.Add(Me.lblNotificacion3Hora)
        Me.pnlNotificacion3.Controls.Add(Me.btnNotificacion3Cancelar)
        Me.pnlNotificacion3.Controls.Add(Me.btnNotificacion3Aceptar)
        Me.pnlNotificacion3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNotificacion3.Location = New System.Drawing.Point(0, 296)
        Me.pnlNotificacion3.Name = "pnlNotificacion3"
        Me.pnlNotificacion3.Size = New System.Drawing.Size(366, 148)
        Me.pnlNotificacion3.TabIndex = 33
        '
        'lblNotificacion3Texto
        '
        Me.lblNotificacion3Texto.AutoSize = True
        Me.lblNotificacion3Texto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion3Texto.Location = New System.Drawing.Point(8, 10)
        Me.lblNotificacion3Texto.Name = "lblNotificacion3Texto"
        Me.lblNotificacion3Texto.Size = New System.Drawing.Size(350, 36)
        Me.lblNotificacion3Texto.TabIndex = 39
        Me.lblNotificacion3Texto.Text = "Confirmar si la siguiente reserva se ha realizado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "correctamente." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblNotificacion3Texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotificacion3Motivo
        '
        Me.lblNotificacion3Motivo.AutoSize = True
        Me.lblNotificacion3Motivo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion3Motivo.Location = New System.Drawing.Point(18, 64)
        Me.lblNotificacion3Motivo.Name = "lblNotificacion3Motivo"
        Me.lblNotificacion3Motivo.Size = New System.Drawing.Size(41, 15)
        Me.lblNotificacion3Motivo.TabIndex = 32
        Me.lblNotificacion3Motivo.Text = "Motivo"
        '
        'lblNotificacion3Fecha
        '
        Me.lblNotificacion3Fecha.AutoSize = True
        Me.lblNotificacion3Fecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion3Fecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNotificacion3Fecha.Location = New System.Drawing.Point(117, 64)
        Me.lblNotificacion3Fecha.Name = "lblNotificacion3Fecha"
        Me.lblNotificacion3Fecha.Size = New System.Drawing.Size(69, 15)
        Me.lblNotificacion3Fecha.TabIndex = 31
        Me.lblNotificacion3Fecha.Text = "00/00/0000"
        '
        'lblNotificacion3Hora
        '
        Me.lblNotificacion3Hora.AutoSize = True
        Me.lblNotificacion3Hora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion3Hora.Location = New System.Drawing.Point(213, 64)
        Me.lblNotificacion3Hora.Name = "lblNotificacion3Hora"
        Me.lblNotificacion3Hora.Size = New System.Drawing.Size(34, 15)
        Me.lblNotificacion3Hora.TabIndex = 30
        Me.lblNotificacion3Hora.Text = "Hora"
        '
        'btnNotificacion3Cancelar
        '
        Me.btnNotificacion3Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotificacion3Cancelar.FlatAppearance.BorderSize = 0
        Me.btnNotificacion3Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificacion3Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotificacion3Cancelar.Location = New System.Drawing.Point(216, 105)
        Me.btnNotificacion3Cancelar.Name = "btnNotificacion3Cancelar"
        Me.btnNotificacion3Cancelar.Size = New System.Drawing.Size(81, 28)
        Me.btnNotificacion3Cancelar.TabIndex = 29
        Me.btnNotificacion3Cancelar.Text = "Cancelar"
        Me.btnNotificacion3Cancelar.UseVisualStyleBackColor = True
        '
        'btnNotificacion3Aceptar
        '
        Me.btnNotificacion3Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotificacion3Aceptar.FlatAppearance.BorderSize = 0
        Me.btnNotificacion3Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificacion3Aceptar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotificacion3Aceptar.Location = New System.Drawing.Point(83, 105)
        Me.btnNotificacion3Aceptar.Name = "btnNotificacion3Aceptar"
        Me.btnNotificacion3Aceptar.Size = New System.Drawing.Size(81, 28)
        Me.btnNotificacion3Aceptar.TabIndex = 26
        Me.btnNotificacion3Aceptar.Text = "Aceptar"
        Me.btnNotificacion3Aceptar.UseVisualStyleBackColor = True
        '
        'llblPaginaSiguiente
        '
        Me.llblPaginaSiguiente.AutoSize = True
        Me.llblPaginaSiguiente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblPaginaSiguiente.LinkColor = System.Drawing.SystemColors.GrayText
        Me.llblPaginaSiguiente.Location = New System.Drawing.Point(291, 447)
        Me.llblPaginaSiguiente.Name = "llblPaginaSiguiente"
        Me.llblPaginaSiguiente.Size = New System.Drawing.Size(60, 14)
        Me.llblPaginaSiguiente.TabIndex = 34
        Me.llblPaginaSiguiente.TabStop = True
        Me.llblPaginaSiguiente.Text = "Siguiente >"
        Me.llblPaginaSiguiente.Visible = False
        '
        'pnlNotificacion2
        '
        Me.pnlNotificacion2.BackColor = System.Drawing.SystemColors.Info
        Me.pnlNotificacion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNotificacion2.Controls.Add(Me.lblNotificacion2Texto)
        Me.pnlNotificacion2.Controls.Add(Me.lblNotificacion2Motivo)
        Me.pnlNotificacion2.Controls.Add(Me.lblNotificacion2Fecha)
        Me.pnlNotificacion2.Controls.Add(Me.lblNotificacion2Hora)
        Me.pnlNotificacion2.Controls.Add(Me.btnNotificacion2Cancelar)
        Me.pnlNotificacion2.Controls.Add(Me.btnNotificacion2Aceptar)
        Me.pnlNotificacion2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNotificacion2.Location = New System.Drawing.Point(0, 148)
        Me.pnlNotificacion2.Name = "pnlNotificacion2"
        Me.pnlNotificacion2.Size = New System.Drawing.Size(366, 148)
        Me.pnlNotificacion2.TabIndex = 33
        '
        'lblNotificacion2Texto
        '
        Me.lblNotificacion2Texto.AutoSize = True
        Me.lblNotificacion2Texto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion2Texto.Location = New System.Drawing.Point(8, 10)
        Me.lblNotificacion2Texto.Name = "lblNotificacion2Texto"
        Me.lblNotificacion2Texto.Size = New System.Drawing.Size(350, 36)
        Me.lblNotificacion2Texto.TabIndex = 38
        Me.lblNotificacion2Texto.Text = "Confirmar si la siguiente reserva se ha realizado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "correctamente." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblNotificacion2Texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotificacion2Motivo
        '
        Me.lblNotificacion2Motivo.AutoSize = True
        Me.lblNotificacion2Motivo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion2Motivo.Location = New System.Drawing.Point(18, 64)
        Me.lblNotificacion2Motivo.Name = "lblNotificacion2Motivo"
        Me.lblNotificacion2Motivo.Size = New System.Drawing.Size(41, 15)
        Me.lblNotificacion2Motivo.TabIndex = 32
        Me.lblNotificacion2Motivo.Text = "Motivo"
        '
        'lblNotificacion2Fecha
        '
        Me.lblNotificacion2Fecha.AutoSize = True
        Me.lblNotificacion2Fecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion2Fecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNotificacion2Fecha.Location = New System.Drawing.Point(117, 64)
        Me.lblNotificacion2Fecha.Name = "lblNotificacion2Fecha"
        Me.lblNotificacion2Fecha.Size = New System.Drawing.Size(69, 15)
        Me.lblNotificacion2Fecha.TabIndex = 31
        Me.lblNotificacion2Fecha.Text = "00/00/0000"
        '
        'lblNotificacion2Hora
        '
        Me.lblNotificacion2Hora.AutoSize = True
        Me.lblNotificacion2Hora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion2Hora.Location = New System.Drawing.Point(213, 64)
        Me.lblNotificacion2Hora.Name = "lblNotificacion2Hora"
        Me.lblNotificacion2Hora.Size = New System.Drawing.Size(34, 15)
        Me.lblNotificacion2Hora.TabIndex = 30
        Me.lblNotificacion2Hora.Text = "Hora"
        '
        'btnNotificacion2Cancelar
        '
        Me.btnNotificacion2Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotificacion2Cancelar.FlatAppearance.BorderSize = 0
        Me.btnNotificacion2Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificacion2Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotificacion2Cancelar.Location = New System.Drawing.Point(216, 105)
        Me.btnNotificacion2Cancelar.Name = "btnNotificacion2Cancelar"
        Me.btnNotificacion2Cancelar.Size = New System.Drawing.Size(81, 28)
        Me.btnNotificacion2Cancelar.TabIndex = 29
        Me.btnNotificacion2Cancelar.Text = "Cancelar"
        Me.btnNotificacion2Cancelar.UseVisualStyleBackColor = True
        '
        'btnNotificacion2Aceptar
        '
        Me.btnNotificacion2Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotificacion2Aceptar.FlatAppearance.BorderSize = 0
        Me.btnNotificacion2Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificacion2Aceptar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotificacion2Aceptar.Location = New System.Drawing.Point(83, 105)
        Me.btnNotificacion2Aceptar.Name = "btnNotificacion2Aceptar"
        Me.btnNotificacion2Aceptar.Size = New System.Drawing.Size(81, 28)
        Me.btnNotificacion2Aceptar.TabIndex = 26
        Me.btnNotificacion2Aceptar.Text = "Aceptar"
        Me.btnNotificacion2Aceptar.UseVisualStyleBackColor = True
        '
        'lblNoHayNotificaciones
        '
        Me.lblNoHayNotificaciones.AutoSize = True
        Me.lblNoHayNotificaciones.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHayNotificaciones.Location = New System.Drawing.Point(109, 90)
        Me.lblNoHayNotificaciones.Name = "lblNoHayNotificaciones"
        Me.lblNoHayNotificaciones.Size = New System.Drawing.Size(171, 18)
        Me.lblNoHayNotificaciones.TabIndex = 0
        Me.lblNoHayNotificaciones.Text = "No hay notificaciones"
        '
        'pnlMostrador
        '
        Me.pnlMostrador.Location = New System.Drawing.Point(330, 42)
        Me.pnlMostrador.Name = "pnlMostrador"
        Me.pnlMostrador.Size = New System.Drawing.Size(1220, 807)
        Me.pnlMostrador.TabIndex = 19
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Contacto"
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.lblDesplegadorNormal)
        Me.pnlMenu.Controls.Add(Me.lblDesplegadorAbajo)
        Me.pnlMenu.Controls.Add(Me.pnlApartadoSeleccionado)
        Me.pnlMenu.Controls.Add(Me.Atila)
        Me.pnlMenu.Controls.Add(Me.pnlConfiguracion)
        Me.pnlMenu.Controls.Add(Me.btnConfiguracion)
        Me.pnlMenu.Controls.Add(Me.btnGanancias)
        Me.pnlMenu.Controls.Add(Me.btnClientes)
        Me.pnlMenu.Controls.Add(Me.btnReservas)
        Me.pnlMenu.Controls.Add(Me.btnReservar)
        Me.pnlMenu.Controls.Add(Me.pbLogoAtilaGrande)
        Me.pnlMenu.Location = New System.Drawing.Point(0, 42)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(330, 807)
        Me.pnlMenu.TabIndex = 31
        '
        'lblDesplegadorNormal
        '
        Me.lblDesplegadorNormal.Image = Global.Atila.My.Resources.Resources.icono_desplegador_rotado
        Me.lblDesplegadorNormal.Location = New System.Drawing.Point(59, 636)
        Me.lblDesplegadorNormal.Name = "lblDesplegadorNormal"
        Me.lblDesplegadorNormal.Size = New System.Drawing.Size(23, 11)
        Me.lblDesplegadorNormal.TabIndex = 39
        '
        'lblDesplegadorAbajo
        '
        Me.lblDesplegadorAbajo.Image = Global.Atila.My.Resources.Resources.lista_de_fiestas_reservadas_0032_Capa_13
        Me.lblDesplegadorAbajo.Location = New System.Drawing.Point(59, 636)
        Me.lblDesplegadorAbajo.Name = "lblDesplegadorAbajo"
        Me.lblDesplegadorAbajo.Size = New System.Drawing.Size(23, 11)
        Me.lblDesplegadorAbajo.TabIndex = 38
        '
        'pnlApartadoSeleccionado
        '
        Me.pnlApartadoSeleccionado.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pnlApartadoSeleccionado.Location = New System.Drawing.Point(2, 359)
        Me.pnlApartadoSeleccionado.Name = "pnlApartadoSeleccionado"
        Me.pnlApartadoSeleccionado.Size = New System.Drawing.Size(8, 60)
        Me.pnlApartadoSeleccionado.TabIndex = 37
        '
        'Atila
        '
        Me.Atila.AutoSize = True
        Me.Atila.Font = New System.Drawing.Font("Courier New", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Atila.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Atila.Location = New System.Drawing.Point(57, 212)
        Me.Atila.Name = "Atila"
        Me.Atila.Size = New System.Drawing.Size(220, 69)
        Me.Atila.TabIndex = 36
        Me.Atila.Text = "Atila"
        '
        'pnlConfiguracion
        '
        Me.pnlConfiguracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.pnlConfiguracion.Controls.Add(Me.btnCerrarSesion)
        Me.pnlConfiguracion.Controls.Add(Me.btnInventario)
        Me.pnlConfiguracion.Controls.Add(Me.btnCostos)
        Me.pnlConfiguracion.Location = New System.Drawing.Point(82, 671)
        Me.pnlConfiguracion.Name = "pnlConfiguracion"
        Me.pnlConfiguracion.Size = New System.Drawing.Size(248, 82)
        Me.pnlConfiguracion.TabIndex = 22
        Me.pnlConfiguracion.Visible = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 51)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(248, 27)
        Me.btnCerrarSesion.TabIndex = 38
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnInventario.Location = New System.Drawing.Point(0, 25)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(248, 26)
        Me.btnInventario.TabIndex = 37
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnCostos
        '
        Me.btnCostos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCostos.FlatAppearance.BorderSize = 0
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCostos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCostos.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCostos.Location = New System.Drawing.Point(0, 0)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.Size = New System.Drawing.Size(248, 26)
        Me.btnCostos.TabIndex = 36
        Me.btnCostos.Text = "Costos"
        Me.btnCostos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCostos.UseVisualStyleBackColor = True
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguracion.FlatAppearance.BorderSize = 0
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnConfiguracion.Image = Global.Atila.My.Resources.Resources.icono_configuracion
        Me.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfiguracion.Location = New System.Drawing.Point(8, 611)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(322, 60)
        Me.btnConfiguracion.TabIndex = 35
        Me.btnConfiguracion.Text = "    Configuracion"
        Me.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'btnGanancias
        '
        Me.btnGanancias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGanancias.FlatAppearance.BorderSize = 0
        Me.btnGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGanancias.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGanancias.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnGanancias.Image = Global.Atila.My.Resources.Resources.icono_ganancias
        Me.btnGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGanancias.Location = New System.Drawing.Point(8, 548)
        Me.btnGanancias.Name = "btnGanancias"
        Me.btnGanancias.Size = New System.Drawing.Size(322, 60)
        Me.btnGanancias.TabIndex = 34
        Me.btnGanancias.Text = "  Estadísticas"
        Me.btnGanancias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGanancias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGanancias.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClientes.Image = Global.Atila.My.Resources.Resources.icono_clientes
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(8, 485)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(322, 60)
        Me.btnClientes.TabIndex = 33
        Me.btnClientes.Text = "  Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnReservas
        '
        Me.btnReservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservas.FlatAppearance.BorderSize = 0
        Me.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservas.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservas.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReservas.Image = Global.Atila.My.Resources.Resources.icono_listar_reservas
        Me.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservas.Location = New System.Drawing.Point(8, 422)
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Size = New System.Drawing.Size(322, 60)
        Me.btnReservas.TabIndex = 32
        Me.btnReservas.Text = "  Listar Reservas"
        Me.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReservas.UseVisualStyleBackColor = True
        '
        'btnReservar
        '
        Me.btnReservar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservar.FlatAppearance.BorderSize = 0
        Me.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservar.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReservar.Image = Global.Atila.My.Resources.Resources.icono_agregar_reserva
        Me.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservar.Location = New System.Drawing.Point(8, 359)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(322, 60)
        Me.btnReservar.TabIndex = 31
        Me.btnReservar.Text = "  Realizar una reserva"
        Me.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReservar.UseVisualStyleBackColor = True
        '
        'pbLogoAtilaGrande
        '
        Me.pbLogoAtilaGrande.Image = Global.Atila.My.Resources.Resources.LOGO_ATILA_PRINCIPAL
        Me.pbLogoAtilaGrande.Location = New System.Drawing.Point(69, 41)
        Me.pbLogoAtilaGrande.Name = "pbLogoAtilaGrande"
        Me.pbLogoAtilaGrande.Size = New System.Drawing.Size(195, 137)
        Me.pbLogoAtilaGrande.TabIndex = 0
        Me.pbLogoAtilaGrande.TabStop = False
        '
        'timerMostrarConfiguracion
        '
        Me.timerMostrarConfiguracion.Interval = 5
        '
        'timerOcultarConfiguracion
        '
        Me.timerOcultarConfiguracion.Interval = 5
        '
        'timerMostrarNotificacion
        '
        Me.timerMostrarNotificacion.Interval = 5
        '
        'timerOcultarNotificacion
        '
        Me.timerOcultarNotificacion.Interval = 5
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1550, 850)
        Me.Controls.Add(Me.pnlCuadroNotificaciones)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlMostrador)
        Me.Controls.Add(Me.pnlArriba)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.pnlArriba.ResumeLayout(False)
        Me.pnlArriba.PerformLayout()
        Me.pnlCuadroNotificaciones.ResumeLayout(False)
        Me.pnlCuadroNotificaciones.PerformLayout()
        Me.pnlNotificacion1.ResumeLayout(False)
        Me.pnlNotificacion1.PerformLayout()
        Me.pnlNotificacion3.ResumeLayout(False)
        Me.pnlNotificacion3.PerformLayout()
        Me.pnlNotificacion2.ResumeLayout(False)
        Me.pnlNotificacion2.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.pnlConfiguracion.ResumeLayout(False)
        CType(Me.pbLogoAtilaGrande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlArriba As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents lblPerfil As System.Windows.Forms.Label
    Friend WithEvents pnlMostrador As System.Windows.Forms.Panel
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnNotificaciones As System.Windows.Forms.Button
    Friend WithEvents pnlCuadroNotificaciones As System.Windows.Forms.Panel
    Friend WithEvents lblNoHayNotificaciones As System.Windows.Forms.Label
    Friend WithEvents btnNotificacion1Aceptar As System.Windows.Forms.Button
    Friend WithEvents pnlNotificacion1 As System.Windows.Forms.Panel
    Friend WithEvents btnNotificacion1Cancelar As System.Windows.Forms.Button
    Friend WithEvents lblNotificacion1Hora As System.Windows.Forms.Label
    Friend WithEvents lblNotificacion1Motivo As System.Windows.Forms.Label
    Friend WithEvents lblNotificacion1Fecha As System.Windows.Forms.Label
    Friend WithEvents pnlNotificacion3 As System.Windows.Forms.Panel
    Friend WithEvents lblNotificacion3Motivo As System.Windows.Forms.Label
    Friend WithEvents lblNotificacion3Fecha As System.Windows.Forms.Label
    Friend WithEvents lblNotificacion3Hora As System.Windows.Forms.Label
    Friend WithEvents btnNotificacion3Cancelar As System.Windows.Forms.Button
    Friend WithEvents btnNotificacion3Aceptar As System.Windows.Forms.Button
    Friend WithEvents pnlNotificacion2 As System.Windows.Forms.Panel
    Friend WithEvents lblNotificacion2Motivo As System.Windows.Forms.Label
    Friend WithEvents lblNotificacion2Fecha As System.Windows.Forms.Label
    Friend WithEvents lblNotificacion2Hora As System.Windows.Forms.Label
    Friend WithEvents btnNotificacion2Cancelar As System.Windows.Forms.Button
    Friend WithEvents btnNotificacion2Aceptar As System.Windows.Forms.Button
    Friend WithEvents llblPaginaAnterior As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCantidadDeNotificaciones As System.Windows.Forms.Label
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents pbLogoAtilaGrande As System.Windows.Forms.PictureBox
    Friend WithEvents timerMostrarConfiguracion As System.Windows.Forms.Timer
    Friend WithEvents btnReservar As System.Windows.Forms.Button
    Friend WithEvents btnConfiguracion As System.Windows.Forms.Button
    Friend WithEvents btnGanancias As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnReservas As System.Windows.Forms.Button
    Friend WithEvents pnlConfiguracion As System.Windows.Forms.Panel
    Friend WithEvents btnInventario As System.Windows.Forms.Button
    Friend WithEvents btnCostos As System.Windows.Forms.Button
    Friend WithEvents lblNotificacion1Texto As System.Windows.Forms.Label
    Friend WithEvents llblPaginaSiguiente As System.Windows.Forms.LinkLabel
    Friend WithEvents lblNotificacion3Texto As System.Windows.Forms.Label
    Friend WithEvents lblNotificacion2Texto As System.Windows.Forms.Label
    Friend WithEvents Atila As System.Windows.Forms.Label
    Friend WithEvents pnlApartadoSeleccionado As System.Windows.Forms.Panel
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents timerOcultarConfiguracion As System.Windows.Forms.Timer
    Friend WithEvents timerMostrarNotificacion As System.Windows.Forms.Timer
    Friend WithEvents timerOcultarNotificacion As System.Windows.Forms.Timer
    Friend WithEvents lblDesplegadorAbajo As System.Windows.Forms.Label
    Friend WithEvents lblDesplegadorNormal As System.Windows.Forms.Label

End Class
