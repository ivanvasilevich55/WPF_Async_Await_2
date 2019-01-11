Imports System.Threading
Imports System.Threading.Tasks


Module Module1

	Sub Main()
		Console.WriteLine("Start main()")
		SomeMethodAsync() 'в данном методе есть await'ы ( и после await'ов есть синхронный код, который будет выполнятся, как колбэк т.е. после очередного awaita
		Console.WriteLine("await from someMethod")
		Console.ReadLine()
	End Sub




	Sub MyMethodAsync()
		Console.WriteLine("Start MyMethod() withaout await")
		Thread.Sleep(8000)
		Console.WriteLine("Выполняется долгая процедура1")
	End Sub




	Async Sub SomeMethodAsync() ' async означает, что дойдя до awaita - управление передатся вызывающему потоку
		Console.WriteLine("Start SomeMethod()")
		Await Task.Run(Sub()
						   MyMethodAsync()
					   End Sub)
		Console.WriteLine("END SomeMethod()") ' это как бы колбэк - будет выполняться Только после завершения await!!!


		Await Task.Run(Sub()
						   MyMethodAsync()
					   End Sub)
		Console.WriteLine("Конец 2 await")

	End Sub



End Module
