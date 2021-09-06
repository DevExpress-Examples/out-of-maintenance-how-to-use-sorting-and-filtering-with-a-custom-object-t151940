Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace FilteringWithComboBoxEditor
	Public Class Data
		Public Shared ReadOnly Property DataList() As List(Of Element)
			Get
				Dim list As New List(Of Element)(New Element() {
					New Element() With {
						.Name="elem1",
						.Value = New ElementItem() With {
							.ItemId=0,
							.ItemName="alfa"
						}
					},
					New Element() With {
						.Name="elem2",
						.Value = New ElementItem() With {
							.ItemId=0,
							.ItemName="beta"
						}
					},
					New Element() With {
						.Name="elem3",
						.Value = New ElementItem() With {
							.ItemId=0,
							.ItemName="gamma"
						}
					},
					New Element() With {
						.Name="elem4",
						.Value = New ElementItem() With {
							.ItemId=0,
							.ItemName="omega"
						}
					},
					New Element() With {
						.Name="elem5",
						.Value = New ElementItem() With {
							.ItemId=0,
							.ItemName="lambda"
						}
					},
					New Element() With {
						.Name="elem6",
						.Value = New ElementItem() With {
							.ItemId=0,
							.ItemName="fi"
						}
					},
					New Element() With {
						.Name="elem7",
						.Value = New ElementItem() With {
							.ItemId=0,
							.ItemName="xi"
						}
					},
					New Element() With {
						.Name="elem8",
						.Value = New ElementItem() With {
							.ItemId=0,
							.ItemName="pi"
						}
					},
					New Element() With {
						.Name="elem9",
						.Value = New ElementItem() With {
							.ItemId=0,
							.ItemName="ro"
						}
					},
					New Element() With {
						.Name="elem0",
						.Value = New ElementItem() With {
							.ItemId=0,
							.ItemName="sigma"
						}
					}
				})
				For Each elem In list
					Dim avaliableValues As New List(Of ElementItem)()
					avaliableValues.Add(elem.Value)
					For i As Integer = 0 To 4
						avaliableValues.Add(New ElementItem() With {
							.ItemName = elem.Value.ItemName & i,
							.ItemId = i
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
