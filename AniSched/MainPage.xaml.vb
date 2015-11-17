' 빈 페이지 항목 템플릿에 대한 설명은 http://go.microsoft.com/fwlink/?LinkId=234238에 나와 있습니다.

Public NotInheritable Class MainPage
    Inherits Page

    Private Sub page1_Loaded(sender As Object, e As RoutedEventArgs) Handles page1.Loaded
        Dim appv = ApplicationView.GetForCurrentView
        appv.Title = "a"

        'testtext.Visibility = Visibility.Visible
        testtext.Text = DateTime.Now.ToString("HH")
        If 6 <= DateTime.Now.ToString("HH") Then
            If DateTime.Now.ToString("HH") <= 17 Then
                page1.RequestedTheme = ElementTheme.Light
                webview_day.Visibility = Visibility.Visible
            Else
                page1.RequestedTheme = ElementTheme.Dark
                webview_night.Visibility = Visibility.Visible
            End If
        Else
            page1.RequestedTheme = ElementTheme.Dark
            webview_night.Visibility = Visibility.Visible
        End If
    End Sub

    Private Sub runfail()
        fail_txt.Visibility = Visibility.Visible
        webview_day.Visibility = Visibility.Collapsed
        webview_night.Visibility = Visibility.Collapsed
    End Sub

    Private Sub webview_day_NavigationFailed(sender As Object, e As WebViewNavigationFailedEventArgs) Handles webview_day.NavigationFailed
        runfail()
    End Sub

    Private Sub webview_night_NavigationFailed(sender As Object, e As WebViewNavigationFailedEventArgs) Handles webview_night.NavigationFailed
        runfail()
    End Sub

    Dim netbl As Boolean = False

    Private Sub webview_day_NavigationCompleted(sender As WebView, args As WebViewNavigationCompletedEventArgs) Handles webview_day.NavigationCompleted
        If netbl = False Then
            webview_day.Refresh()
            netbl = True
        End If
    End Sub

    Private Sub webview_night_NavigationCompleted(sender As WebView, args As WebViewNavigationCompletedEventArgs) Handles webview_night.NavigationCompleted
        If netbl = False Then
            webview_night.Refresh()
            netbl = True
        End If
    End Sub
End Class
