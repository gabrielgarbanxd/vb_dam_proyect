Namespace Repositories.Mappers

    Public Interface IObjectMapper(Of T As Class)
        Function Map(reader As IDataReader) As T
    End Interface

End Namespace