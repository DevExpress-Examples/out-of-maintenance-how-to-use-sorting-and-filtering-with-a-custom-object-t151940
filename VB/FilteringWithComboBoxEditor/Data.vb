Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace FilteringWithComboBoxEditor
    Public Class Data
        Public Shared ReadOnly Property DataList() As List(Of Element)
            Get
                Dim list As List(Of Element) = New List(Of Element)(New Element() { _
                    New Element() With { _
                        .Name="elem1", _
                        .Value = New ElementItem() With { _
                            .ItemId=0, _
                            .ItemName="alfa" _
                        } _
                    }, _
                    New Element() With { _
                        .Name="elem2", _
                        .Value = New ElementItem() With { _
                            .ItemId=0, _
                            .ItemName="beta" _
                        } _
                    }, _
                    New Element() With { _
                        .Name="elem3", _
                        .Value = New ElementItem() With { _
                            .ItemId=0, _
                            .ItemName="gamma" _
                        } _
                    }, _
                    New Element() With { _
                        .Name="elem4", _
                        .Value = New ElementItem() With { _
                            .ItemId=0, _
                            .ItemName="omega" _
                        } _
                    }, _
                    New Element() With { _
                        .Name="elem5", _
                        .Value = New ElementItem() With { _
                            .ItemId=0, _
                            .ItemName="lambda" _
                        } _
                    }, _
                    New Element() With { _
                        .Name="elem6", _
                        .Value = New ElementItem() With { _
                            .ItemId=0, _
                            .ItemName="fi" _
                        } _
                    }, _
                    New Element() With { _
                        .Name="elem7", _
                        .Value = New ElementItem() With { _
                            .ItemId=0, _
                            .ItemName="xi" _
                        } _
                    }, _
                    New Element() With { _
                        .Name="elem8", _
                        .Value = New ElementItem() With { _
                            .ItemId=0, _
                            .ItemName="pi" _
                        } _
                    }, _
                    New Element() With { _
                        .Name="elem9", _
                        .Value = New ElementItem() With { _
                            .ItemId=0, _
                            .ItemName="ro" _
                        } _
                    }, _
                    New Element() With { _
                        .Name="elem0", _
                        .Value = New ElementItem() With { _
                            .ItemId=0, _
                            .ItemName="sigma" _
                        } _
                    } _
                })
                For Each elem In list
                    Dim avaliableValues As New List(Of ElementItem)()
                    avaliableValues.Add(elem.Value)
                    For i As Integer = 0 To 4
                        avaliableValues.Add(New ElementItem() With { _
                            .ItemName = elem.Value.ItemName & i, _
                            .ItemId = i _
                        })
                    Next i
                    elem.AvaliableValues = avaliableValues
                Next elem

                Return list
            End Get
        End Property
    End Class

    Public Class Element
        Public Property Name() As String
        Public Property Value() As ElementItem
        Public Property AvaliableValues() As List(Of ElementItem)
    End Class

    Public Class ElementItem
        Public Property ItemName() As String
        Public Property ItemId() As Integer
    End Class

End Namespace
