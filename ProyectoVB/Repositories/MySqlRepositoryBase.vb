Imports MySql.Data.MySqlClient
Imports ProyectoVB.Repositories.Mappers

Namespace Repositories

    Public MustInherit Class MySqlRepositoryBase(Of T As Class)
        Private ReadOnly _connection As MySqlConnection
        Private ReadOnly _mapper As IObjectMapper(Of T)
        Private ReadOnly _connectionString As String = "Server=localhost;Port=3309;Database=vb_proyect_joyfe;User=root;Password=joyfe;"

        Public Sub New(mapper As IObjectMapper(Of T))
            _connection = New MySqlConnection(_connectionString)
            _mapper = mapper
        End Sub

        Public Sub New()
            _connection = New MySqlConnection(_connectionString)
            _mapper = Nothing
        End Sub

        Private Function GetSqlConnection() As MySqlConnection
            Return New MySqlConnection(_connectionString)
        End Function

        Protected Async Function ExecuteQueryAsync(storedProcedure As String, Optional parameters As IDictionary(Of String, Object) = Nothing) As Task(Of IEnumerable(Of T))
            Using connection = GetSqlConnection()
                Await connection.OpenAsync()

                Using command = New MySqlCommand(storedProcedure, connection)
                    command.CommandType = CommandType.StoredProcedure

                    If parameters IsNot Nothing Then
                        SetParameters(command, parameters)
                    End If

                    Using reader = Await command.ExecuteReaderAsync()
                        Dim result = New List(Of T)()

                        While Await reader.ReadAsync()
                            result.Add(MapToEntity(reader))
                        End While

                        Return result
                    End Using
                End Using
            End Using
        End Function

        Protected Async Function ExecuteNonQueryAsync(storedProcedure As String, Optional parameters As IDictionary(Of String, Object) = Nothing) As Task(Of Integer)
            Using connection = GetSqlConnection()
                If connection.State = ConnectionState.Closed Then
                    Await connection.OpenAsync()
                End If


                Using command = New MySqlCommand(storedProcedure, connection)
                    command.CommandType = CommandType.StoredProcedure

                    If parameters IsNot Nothing Then
                        SetParameters(command, parameters)
                    End If

                    ' Configurar el parámetro de salida
                    Dim resultParameter = command.Parameters.Add("@p_Result", MySqlDbType.Int32)
                    resultParameter.Direction = ParameterDirection.Output

                    Await command.ExecuteNonQueryAsync()

                    ' Obtener el valor del parámetro de salida
                    Dim result As Integer = resultParameter.Value
                    Return result
                End Using
            End Using
        End Function

        Protected Sub SetParameters(command As MySqlCommand, parameters As IDictionary(Of String, Object))
            For Each parameter In parameters
                command.Parameters.AddWithValue(parameter.Key, parameter.Value)
            Next
        End Sub

        Protected Function MapToEntity(reader As IDataReader) As T
            If _mapper Is Nothing Then
                Throw New InvalidOperationException("No mapper provided")
            End If
            Return _mapper.Map(reader)
        End Function
    End Class

End Namespace
