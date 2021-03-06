﻿Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Allows editing of single-line text values, which can be retrieved over the Value property, 
''' and which can handle Nothing (null in CSharp) on top.
''' </summary>
<ToolboxBitmap(GetType(NullableTextValue),
               "Resources\NullableTextValue"),
 ToolboxItem(True),
 Description("Allows editing of single-line text values which can be retrieved over the Value property," &
             "and which can handle Nothing (null in CSharp) on top.")>
Public Class NullableTextValue
    Inherits NullableValueBase(Of StringValue, NullableValuePrimalTextBox)

    Sub New()
        MyBase.New
    End Sub

    Private myEliminateWhitespacesOnAssignment As Boolean

    Protected Overrides Function GetDefaultFormatString() As String
        Return ""
    End Function

    Protected Overrides Function GetDefaultFormatterEngine() As INullableValueFormatterEngine
        Dim retTmp = New NullableStringValueFormatterEngine(Me.Value, Me.GetDefaultFormatString, Me.NullValueString)
        Return (retTmp)
    End Function

    Protected Overrides Function GetDefaultNullValueString() As String
        Return DEFAULT_NULL_VALUE_STRING
    End Function

    Protected Overrides Sub InitializeProperties()
        myEliminateWhitespacesOnAssignment = True
    End Sub

    Protected Overrides Function IsMultiLineControl() As Boolean
        Return False
    End Function

    'TODO: Soll so etwas möglich sein?
    ''' <summary>
    ''' EXPERIMENTAL: Bestimmt oder ermittelt, ob eine FormsToBusinessManager-Instanz die MaxLength-Eigenschaft zur Laufzeit auf Basis des Business-Objektes setzen darf.
    ''' </summary>
    ''' <value>Name des Attributs, dass über der zu bindenden Eigenschaft stehen muss, dass die Länge des Strings angibt.</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
     Description("Bestimmt oder ermittelt, ob eine FormsToBusinessManager-Instanz die MaxLength-Eigenschaft zur Laufzeit auf Basis des Business-Objektes setzen darf."),
     Category("Verhalten"),
     EditorBrowsable(EditorBrowsableState.Advanced),
     Browsable(True), DefaultValue(True)>
    Public Shared Property MaxLengthAttributeName As String

    ''' <summary>
    ''' Bestimmt oder ermittelt, ob WhiteSpaces (Füllzeichen) die vor oder hinter dem eigentlichen Text stehen, bei einer Zuweisung eliminiert werden sollen.
    ''' </summary>
    ''' <value>True, wenn WhiteSpaces bei der Zuweisung eliminiert werden sollen.</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
     Description("Bestimmt oder ermittelt, ob WhiteSpaces (Füllzeichen) die vor oder hinter dem eigentlichen Text stehen, bei einer Zuweisung eliminiert werden sollen."),
     Category("Verhalten"),
     EditorBrowsable(EditorBrowsableState.Advanced),
     Browsable(True), DefaultValue(True)>
    Property EliminateWhitespacesOnAssignment As Boolean
        Get
            Return myEliminateWhitespacesOnAssignment
        End Get
        Set(ByVal value As Boolean)
            myEliminateWhitespacesOnAssignment = value
        End Set
    End Property

    'Sorgt dafür, dass die EliminateWhitespacesOnAssignment-Eigenschaft berücksichtigt wird.
    Protected Overrides Sub OnValueChanging(ByVal e As ValueChangingEventArgs(Of StringValue?))
        MyBase.OnValueChanging(e)
        If EliminateWhitespacesOnAssignment Then
            If e.OriginalValue IsNot Nothing Then
                'Wir arbeiten bei Strings mit StringValue, deswegen auf Typgleichheit achten!
                If e.OriginalValue.GetType Is GetType(StringValue) Then
                    e.NewValue = New StringValue(e.OriginalValue.ToString.Trim)
                Else
                    'Eigentlich dürften wir hier nie hinkommen.
                    e.NewValue = e.OriginalValue.ToString.Trim
                End If
            End If
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
