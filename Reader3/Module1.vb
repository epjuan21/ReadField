Module Module1

    Sub Main()
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\epjua\Desktop\Texto\SGD280RPED20170331MU000000005411N01.txt")
            'Dim sr As System.IO.StreamReader = New IO.StreamReader("C:\Texto\SGD280RPED20170331MU000000005411N01.txt")

            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("|")

            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        MsgBox(currentField)
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "Is not valid")

                End Try
            End While


        End Using



    End Sub

End Module
