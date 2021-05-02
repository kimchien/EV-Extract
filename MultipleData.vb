Public Class MultipleData
    Private Sub MultipleData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Remove Duplicated Value
        For i = MultipleDataSelection.Rows.Count - 1 To 0 Step -1

            For j = i - 1 To 0 Step -1

                If MultipleDataSelection.Rows(i).Cells(0).Value = MultipleDataSelection.Rows(j).Cells(0).Value Then

                    MultipleDataSelection.Rows.RemoveAt(i)

                    Exit For

                End If

            Next

        Next


    End Sub

    Private Sub MultipleDataSelection_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MultipleDataSelection.CellDoubleClick

        Main.BarcodeText.Text = MultipleDataSelection.Item(0, MultipleDataSelection.CurrentRow.Index).Value
        Main.IndexResult.Rows.Item(Main.IndexResult.CurrentRow.Index).Cells(1).Value = MultipleDataSelection.Item(0, MultipleDataSelection.CurrentRow.Index).Value
        Me.Close()

    End Sub


End Class