Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Data

Namespace FilteringWithComboBoxEditor
    Public Class TextConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            If value IsNot Nothing AndAlso TypeOf value Is ElementItem Then
                Return (TryCast(value, ElementItem)).ItemName
            Else
                Return ""
            End If
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            If value IsNot Nothing AndAlso TypeOf value Is ElementItem Then
                Return (TryCast(value, ElementItem)).ItemName
            Else
                Return ""
            End If
        End Function
    End Class
End Namespace
