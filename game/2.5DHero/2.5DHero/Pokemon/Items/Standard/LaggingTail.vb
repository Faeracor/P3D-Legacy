Namespace Items.Standard

    <Item(142, "Lagging Tail")>
    Public Class LaggingTail

        Inherits Item

        Public Overrides ReadOnly Property FlingDamage As Integer = 10
        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False

        Public Sub New()
            _textureRectangle = New Rectangle(432, 192, 24, 24)
        End Sub

    End Class

End Namespace
