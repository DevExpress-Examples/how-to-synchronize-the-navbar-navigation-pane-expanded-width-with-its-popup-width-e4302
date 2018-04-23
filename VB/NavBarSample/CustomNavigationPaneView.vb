Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Xpf.NavBar

Namespace NavBarSample
    Public Class CustomNavigationPaneView
        Inherits NavigationPaneView

        Public Property OpenedWidth() As Double
        Public Property PreviousWidth() As Double
        Protected Overrides Sub UpdatePresenterTemplateByEnabledState()
            If OpenedWidth <> 0 Then
                ExpandedWidth = OpenedWidth
            End If
            MyBase.UpdatePresenterTemplateByEnabledState()
        End Sub
    End Class
End Namespace
