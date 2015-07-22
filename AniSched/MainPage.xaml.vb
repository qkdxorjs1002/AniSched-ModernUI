' 빈 페이지 항목 템플릿에 대한 설명은 http://go.microsoft.com/fwlink/?LinkId=234238에 나와 있습니다.

''' <summary>
''' 자체에서 사용하거나 프레임 내에서 탐색할 수 있는 빈 페이지입니다.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub webview1_NavigationFailed(sender As Object, e As WebViewNavigationFailedEventArgs) Handles webview1.NavigationFailed
        fail_txt.Visibility = Windows.UI.Xaml.Visibility.Visible
    End Sub
End Class
