﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MvvmDataGridTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim BuchungenDataGrid_ColumnNr As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim BuchungenDataGrid_ColumnPrio As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim BuchungenDataGrid_ColumnDatum As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim BuchungenDataGrid_ColumnText As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim BuchungenDataGrid_ColumnKostenart As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim BuchungenDataGrid_ColumnAusgaben As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim BuchungenDataGrid_ColumnSatz As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim BuchungenDataGrid_ColumnEntSteuer As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim BuchungenDataGrid_ColumnBetrag As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim BuchungenDataGrid_MvvmDataGridColumn10 As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Me.BuchungenDataGrid = New ActiveDevelop.EntitiesFormsLib.MvvmDataGrid()
        Me.MvvmManager1 = New ActiveDevelop.EntitiesFormsLib.MvvmManager(Me.components)
        BuchungenDataGrid_ColumnNr.TextWrapping = System.Windows.TextWrapping.NoWrap
        BuchungenDataGrid_ColumnNr.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        BuchungenDataGrid_ColumnNr.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        BuchungenDataGrid_ColumnNr.Width = 1.0R
        BuchungenDataGrid_ColumnNr.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        BuchungenDataGrid_ColumnNr.Visibility = System.Windows.Visibility.Visible
        BuchungenDataGrid_ColumnNr.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        BuchungenDataGrid_ColumnNr.Header = "Nr."
        BuchungenDataGrid_ColumnNr.IsEnabled = False
        BuchungenDataGrid_ColumnNr.BackgroundColor = System.Drawing.Color.Silver
        BuchungenDataGrid_ColumnNr.ForegroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnNr.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        BuchungenDataGrid_ColumnNr.VerticalAlignment = System.Windows.VerticalAlignment.Top
        BuchungenDataGrid_ColumnNr.ColumnHeaderFont = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BuchungenDataGrid_ColumnNr.ColumnHeaderPadding = New System.Windows.Forms.Padding(10)
        BuchungenDataGrid_ColumnNr.Name = "ColumnNr"
        BuchungenDataGrid_ColumnNr.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        BuchungenDataGrid_ColumnNr.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BuchungenDataGrid_ColumnPrio.TextWrapping = System.Windows.TextWrapping.NoWrap
        BuchungenDataGrid_ColumnPrio.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        BuchungenDataGrid_ColumnPrio.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        BuchungenDataGrid_ColumnPrio.Width = 1.0R
        BuchungenDataGrid_ColumnPrio.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        BuchungenDataGrid_ColumnPrio.Visibility = System.Windows.Visibility.Visible
        BuchungenDataGrid_ColumnPrio.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        BuchungenDataGrid_ColumnPrio.Header = "Wichtig"
        BuchungenDataGrid_ColumnPrio.IsEnabled = True
        BuchungenDataGrid_ColumnPrio.BackgroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnPrio.ForegroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnPrio.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        BuchungenDataGrid_ColumnPrio.VerticalAlignment = System.Windows.VerticalAlignment.Top
        BuchungenDataGrid_ColumnPrio.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        BuchungenDataGrid_ColumnPrio.Name = "ColumnPrio"
        BuchungenDataGrid_ColumnPrio.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.CheckBox
        BuchungenDataGrid_ColumnDatum.TextWrapping = System.Windows.TextWrapping.NoWrap
        BuchungenDataGrid_ColumnDatum.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        BuchungenDataGrid_ColumnDatum.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        BuchungenDataGrid_ColumnDatum.Width = 1.0R
        BuchungenDataGrid_ColumnDatum.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        BuchungenDataGrid_ColumnDatum.Visibility = System.Windows.Visibility.Visible
        BuchungenDataGrid_ColumnDatum.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        BuchungenDataGrid_ColumnDatum.Header = "Datum"
        BuchungenDataGrid_ColumnDatum.IsEnabled = True
        BuchungenDataGrid_ColumnDatum.BackgroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnDatum.ForegroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnDatum.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        BuchungenDataGrid_ColumnDatum.VerticalAlignment = System.Windows.VerticalAlignment.Top
        BuchungenDataGrid_ColumnDatum.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        BuchungenDataGrid_ColumnDatum.Name = "ColumnDatum"
        BuchungenDataGrid_ColumnDatum.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        BuchungenDataGrid_ColumnDatum.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        BuchungenDataGrid_ColumnText.TextWrapping = System.Windows.TextWrapping.NoWrap
        BuchungenDataGrid_ColumnText.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        BuchungenDataGrid_ColumnText.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        BuchungenDataGrid_ColumnText.Width = 75.0R
        BuchungenDataGrid_ColumnText.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        BuchungenDataGrid_ColumnText.Visibility = System.Windows.Visibility.Visible
        BuchungenDataGrid_ColumnText.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        BuchungenDataGrid_ColumnText.Header = "Buchungstext"
        BuchungenDataGrid_ColumnText.IsEnabled = True
        BuchungenDataGrid_ColumnText.BackgroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnText.ForegroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnText.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        BuchungenDataGrid_ColumnText.VerticalAlignment = System.Windows.VerticalAlignment.Top
        BuchungenDataGrid_ColumnText.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        BuchungenDataGrid_ColumnText.Name = "ColumnText"
        BuchungenDataGrid_ColumnText.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        BuchungenDataGrid_ColumnKostenart.TextWrapping = System.Windows.TextWrapping.NoWrap
        BuchungenDataGrid_ColumnKostenart.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        BuchungenDataGrid_ColumnKostenart.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        BuchungenDataGrid_ColumnKostenart.Width = 1.0R
        BuchungenDataGrid_ColumnKostenart.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.[Auto]
        BuchungenDataGrid_ColumnKostenart.Visibility = System.Windows.Visibility.Visible
        BuchungenDataGrid_ColumnKostenart.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        BuchungenDataGrid_ColumnKostenart.Header = "Kostenarten"
        BuchungenDataGrid_ColumnKostenart.IsEnabled = True
        BuchungenDataGrid_ColumnKostenart.BackgroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnKostenart.ForegroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnKostenart.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        BuchungenDataGrid_ColumnKostenart.VerticalAlignment = System.Windows.VerticalAlignment.Top
        BuchungenDataGrid_ColumnKostenart.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        BuchungenDataGrid_ColumnKostenart.DisplayMemberPath = "Name"
        BuchungenDataGrid_ColumnKostenart.Name = "ColumnKostenart"
        BuchungenDataGrid_ColumnKostenart.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.ComboBox
        BuchungenDataGrid_ColumnKostenart.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        BuchungenDataGrid_ColumnAusgaben.TextWrapping = System.Windows.TextWrapping.NoWrap
        BuchungenDataGrid_ColumnAusgaben.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        BuchungenDataGrid_ColumnAusgaben.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        BuchungenDataGrid_ColumnAusgaben.Width = 25.0R
        BuchungenDataGrid_ColumnAusgaben.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        BuchungenDataGrid_ColumnAusgaben.Visibility = System.Windows.Visibility.Visible
        BuchungenDataGrid_ColumnAusgaben.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        BuchungenDataGrid_ColumnAusgaben.Header = "Umsatz (brutto)"
        BuchungenDataGrid_ColumnAusgaben.IsEnabled = True
        BuchungenDataGrid_ColumnAusgaben.BackgroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnAusgaben.ForegroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnAusgaben.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        BuchungenDataGrid_ColumnAusgaben.VerticalAlignment = System.Windows.VerticalAlignment.Top
        BuchungenDataGrid_ColumnAusgaben.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        BuchungenDataGrid_ColumnAusgaben.Name = "ColumnAusgaben"
        BuchungenDataGrid_ColumnAusgaben.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        BuchungenDataGrid_ColumnAusgaben.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        BuchungenDataGrid_ColumnSatz.TextWrapping = System.Windows.TextWrapping.NoWrap
        BuchungenDataGrid_ColumnSatz.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        BuchungenDataGrid_ColumnSatz.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        BuchungenDataGrid_ColumnSatz.Width = 1.0R
        BuchungenDataGrid_ColumnSatz.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        BuchungenDataGrid_ColumnSatz.Visibility = System.Windows.Visibility.Visible
        BuchungenDataGrid_ColumnSatz.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        BuchungenDataGrid_ColumnSatz.Header = "Satz"
        BuchungenDataGrid_ColumnSatz.IsEnabled = True
        BuchungenDataGrid_ColumnSatz.BackgroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnSatz.ForegroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnSatz.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        BuchungenDataGrid_ColumnSatz.VerticalAlignment = System.Windows.VerticalAlignment.Top
        BuchungenDataGrid_ColumnSatz.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        BuchungenDataGrid_ColumnSatz.Name = "ColumnSatz"
        BuchungenDataGrid_ColumnSatz.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        BuchungenDataGrid_ColumnSatz.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        BuchungenDataGrid_ColumnEntSteuer.TextWrapping = System.Windows.TextWrapping.NoWrap
        BuchungenDataGrid_ColumnEntSteuer.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        BuchungenDataGrid_ColumnEntSteuer.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        BuchungenDataGrid_ColumnEntSteuer.Width = 1.0R
        BuchungenDataGrid_ColumnEntSteuer.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        BuchungenDataGrid_ColumnEntSteuer.Visibility = System.Windows.Visibility.Visible
        BuchungenDataGrid_ColumnEntSteuer.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        BuchungenDataGrid_ColumnEntSteuer.Header = "enth. Steuer"
        BuchungenDataGrid_ColumnEntSteuer.IsEnabled = False
        BuchungenDataGrid_ColumnEntSteuer.BackgroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnEntSteuer.ForegroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnEntSteuer.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        BuchungenDataGrid_ColumnEntSteuer.VerticalAlignment = System.Windows.VerticalAlignment.Top
        BuchungenDataGrid_ColumnEntSteuer.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        BuchungenDataGrid_ColumnEntSteuer.Name = "ColumnEntSteuer"
        BuchungenDataGrid_ColumnEntSteuer.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        BuchungenDataGrid_ColumnEntSteuer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        BuchungenDataGrid_ColumnBetrag.TextWrapping = System.Windows.TextWrapping.NoWrap
        BuchungenDataGrid_ColumnBetrag.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        BuchungenDataGrid_ColumnBetrag.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        BuchungenDataGrid_ColumnBetrag.Width = 1.0R
        BuchungenDataGrid_ColumnBetrag.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        BuchungenDataGrid_ColumnBetrag.Visibility = System.Windows.Visibility.Visible
        BuchungenDataGrid_ColumnBetrag.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        BuchungenDataGrid_ColumnBetrag.Header = "Betrag (netto)"
        BuchungenDataGrid_ColumnBetrag.IsEnabled = False
        BuchungenDataGrid_ColumnBetrag.BackgroundColor = System.Drawing.Color.Silver
        BuchungenDataGrid_ColumnBetrag.ForegroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_ColumnBetrag.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        BuchungenDataGrid_ColumnBetrag.VerticalAlignment = System.Windows.VerticalAlignment.Top
        BuchungenDataGrid_ColumnBetrag.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        BuchungenDataGrid_ColumnBetrag.Name = "ColumnBetrag"
        BuchungenDataGrid_ColumnBetrag.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        BuchungenDataGrid_ColumnBetrag.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BuchungenDataGrid_MvvmDataGridColumn10.TextWrapping = System.Windows.TextWrapping.NoWrap
        BuchungenDataGrid_MvvmDataGridColumn10.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        BuchungenDataGrid_MvvmDataGridColumn10.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        BuchungenDataGrid_MvvmDataGridColumn10.Width = 1.0R
        BuchungenDataGrid_MvvmDataGridColumn10.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        BuchungenDataGrid_MvvmDataGridColumn10.Visibility = System.Windows.Visibility.Visible
        BuchungenDataGrid_MvvmDataGridColumn10.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        BuchungenDataGrid_MvvmDataGridColumn10.Header = "Link"
        BuchungenDataGrid_MvvmDataGridColumn10.IsEnabled = True
        BuchungenDataGrid_MvvmDataGridColumn10.BackgroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_MvvmDataGridColumn10.ForegroundColor = System.Drawing.Color.Empty
        BuchungenDataGrid_MvvmDataGridColumn10.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        BuchungenDataGrid_MvvmDataGridColumn10.VerticalAlignment = System.Windows.VerticalAlignment.Top
        BuchungenDataGrid_MvvmDataGridColumn10.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        BuchungenDataGrid_MvvmDataGridColumn10.Name = "MvvmDataGridColumn10"
        BuchungenDataGrid_MvvmDataGridColumn10.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.Hyperlink
        CType(Me.BuchungenDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MvvmManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuchungenDataGrid
        '
        Me.BuchungenDataGrid.AllowMultiColumnFiltering = False
        Me.BuchungenDataGrid.AutoGenerateColumns = False
        Me.BuchungenDataGrid.CanUserAddRows = False
        Me.BuchungenDataGrid.CanUserDeleteRows = True
        Me.BuchungenDataGrid.CanUserSortColumns = True
        BuchungenDataGrid_ColumnNr.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(Object)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Nummer", GetType(Integer)))
        BuchungenDataGrid_ColumnNr.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("FontFamily", GetType(System.Windows.Media.FontFamily)), GetType(EFL_CodedUITestContainer.BooleanToBoldConverter), Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Wichtig", GetType(Boolean)))
        Me.BuchungenDataGrid.Columns.Add(BuchungenDataGrid_ColumnNr)
        BuchungenDataGrid_ColumnPrio.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.TwoWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(Object)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Wichtig", GetType(Boolean)))
        Me.BuchungenDataGrid.Columns.Add(BuchungenDataGrid_ColumnPrio)
        BuchungenDataGrid_ColumnDatum.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(Object)), GetType(EFL_CodedUITestContainer.DateWithoutTimeConverter), Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Datum", GetType(Date)))
        Me.BuchungenDataGrid.Columns.Add(BuchungenDataGrid_ColumnDatum)
        BuchungenDataGrid_ColumnText.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.TwoWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.LostFocus), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(Object)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Buchungstext", GetType(String)))
        BuchungenDataGrid_ColumnText.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("FontFamily", GetType(System.Windows.Media.FontFamily)), GetType(EFL_CodedUITestContainer.BooleanToBoldConverter), Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Wichtig", GetType(Boolean)))
        BuchungenDataGrid_ColumnText.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("ForegroundColor", GetType(System.Drawing.Color)), GetType(EFL_CodedUITestContainer.UmsatzToFarbeConverter), Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Betrag", GetType(Double)))
        Me.BuchungenDataGrid.Columns.Add(BuchungenDataGrid_ColumnText)
        BuchungenDataGrid_ColumnKostenart.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("ComboBoxItemsSource", GetType(Object)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Kostenarten", GetType(System.Collections.ObjectModel.ObservableCollection(Of EFL_CodedUITestContainer.Kostenart))))
        BuchungenDataGrid_ColumnKostenart.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.TwoWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(Object)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Kostenart", GetType(EFL_CodedUITestContainer.Kostenart)))
        Me.BuchungenDataGrid.Columns.Add(BuchungenDataGrid_ColumnKostenart)
        BuchungenDataGrid_ColumnAusgaben.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.TwoWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.LostFocus), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(Object)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Ausgaben", GetType(Double)))
        Me.BuchungenDataGrid.Columns.Add(BuchungenDataGrid_ColumnAusgaben)
        BuchungenDataGrid_ColumnSatz.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.TwoWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.LostFocus), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(Object)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Satz", GetType(Integer)))
        Me.BuchungenDataGrid.Columns.Add(BuchungenDataGrid_ColumnSatz)
        BuchungenDataGrid_ColumnEntSteuer.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(Object)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("EnthaleteneSteuer", GetType(Double)))
        Me.BuchungenDataGrid.Columns.Add(BuchungenDataGrid_ColumnEntSteuer)
        BuchungenDataGrid_ColumnBetrag.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(Object)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Betrag", GetType(Double)))
        BuchungenDataGrid_ColumnBetrag.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("BackgroundColor", GetType(System.Drawing.Color)), GetType(EFL_CodedUITestContainer.UmsatzToFarbeConverter), Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Betrag", GetType(Double)))
        Me.BuchungenDataGrid.Columns.Add(BuchungenDataGrid_ColumnBetrag)
        BuchungenDataGrid_MvvmDataGridColumn10.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(Object)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Url", GetType(String)))
        Me.BuchungenDataGrid.Columns.Add(BuchungenDataGrid_MvvmDataGridColumn10)
        Me.BuchungenDataGrid.CustomColumnTemplateType = Nothing
        Me.BuchungenDataGrid.DataSourceType = GetType(EFL_CodedUITestContainer.Buchung)
        Me.BuchungenDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuchungenDataGrid.EnterAction = Nothing
        Me.MvvmManager1.SetEventBindings(Me.BuchungenDataGrid, Nothing)
        Me.BuchungenDataGrid.FilterCaseSensitive = False
        Me.BuchungenDataGrid.GridLinesVisibility = System.Windows.Controls.DataGridGridLinesVisibility.All
        Me.BuchungenDataGrid.HeadersVisibility = CType((System.Windows.Controls.DataGridHeadersVisibility.Column Or System.Windows.Controls.DataGridHeadersVisibility.Row), System.Windows.Controls.DataGridHeadersVisibility)
        Me.BuchungenDataGrid.IsFilteringEnabled = True
        Me.BuchungenDataGrid.IsGroupingEnabled = False
        Me.BuchungenDataGrid.IsReadOnly = False
        Me.BuchungenDataGrid.ItemsSource = Nothing
        Me.BuchungenDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.BuchungenDataGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.BuchungenDataGrid.Name = "BuchungenDataGrid"
        Me.BuchungenDataGrid.SelectedIndex = -1
        Me.BuchungenDataGrid.SelectedItem = Nothing
        Me.BuchungenDataGrid.SelectionMode = System.Windows.Controls.DataGridSelectionMode.Extended
        Me.BuchungenDataGrid.Size = New System.Drawing.Size(912, 485)
        Me.BuchungenDataGrid.TabIndex = 0
        '
        'MvvmManager1
        '
        Me.MvvmManager1.CancelButton = Nothing
        Me.MvvmManager1.ContainerControl = Me
        Me.MvvmManager1.CurrentContextGuid = New System.Guid("861fafc2-3724-48ce-9bcf-d4a6f0dc5f0b")
        Me.MvvmManager1.DataContext = Nothing
        Me.MvvmManager1.DataContextType = GetType(EFL_CodedUITestContainer.MainViewModel)
        Me.MvvmManager1.DataSourceType = GetType(EFL_CodedUITestContainer.MainViewModel)
        Me.MvvmManager1.DirtyStateManagerComponent = Nothing
        Me.MvvmManager1.DynamicEventHandlingList = Nothing
        Me.MvvmManager1.HostingForm = Me
        Me.MvvmManager1.HostingUserControl = Nothing
        Me.MvvmManager1.MvvmBindings.AddPropertyBinding(Me.BuchungenDataGrid, New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.PropertyChangedImmediately), New ActiveDevelop.EntitiesFormsLib.BindingProperty("ItemsSource", GetType(System.Collections.IEnumerable)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Buchungen", GetType(System.Collections.ObjectModel.ObservableCollection(Of EFL_CodedUITestContainer.Buchung))))
        '
        'MvvmDataGridTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 485)
        Me.Controls.Add(Me.BuchungenDataGrid)
        Me.MvvmManager1.SetEventBindings(Me, Nothing)
        Me.Name = "MvvmDataGridTest"
        Me.Text = "Buchungen"
        CType(Me.BuchungenDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MvvmManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BuchungenDataGrid As ActiveDevelop.EntitiesFormsLib.MvvmDataGrid
    Friend WithEvents MvvmManager1 As ActiveDevelop.EntitiesFormsLib.MvvmManager

End Class
