Namespace Items.Standard

    <Item(84, "Reaper Cloth")>
    Public Class ReaperCloth

        Inherits Item

        Public Overrides ReadOnly Property FlingDamage As Integer = 10
        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False

        Public Sub New()
            _textureRectangle = New Rectangle(96, 168, 24, 24)
        End Sub

    End Class

End Namespace
