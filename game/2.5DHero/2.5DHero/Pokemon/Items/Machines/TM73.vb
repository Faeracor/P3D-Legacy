Namespace Items.Machines

    <Item(373, "TM 73")>
    Public Class TM73

        Inherits TechMachine

        Public Sub New()
            MyBase.New(373, True, 2000, 102, 73)
            CanTeachAlways = True
        End Sub

    End Class

End Namespace
