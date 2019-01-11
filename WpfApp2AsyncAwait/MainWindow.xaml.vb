Imports System
Imports System.Threading
Imports System.Threading.Tasks
'async-await - синтаксический сахар (
Class MainWindow
	Private Sub mysub()
		Thread.Sleep(5000)
		MsgBox("END")
	End Sub
	Private Async Sub mysubAsync()
		Await Task.Run(Sub() Thread.Sleep(5000))
		MsgBox("END1")
		Await Task.Run(Sub() Thread.Sleep(5000))
		MsgBox("END2")
	End Sub
	Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
		mysubAsync()
	End Sub
End Class
