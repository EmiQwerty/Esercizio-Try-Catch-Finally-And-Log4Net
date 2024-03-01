using System.Data.SqlTypes;
using System.IO;
using System.Reflection;
using System.Runtime.ExceptionServices;
using log4net;
using log4net.Config;

int? zero = 0;

//DICHIARIAMO E INIZIALIZZIAMO 

var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

var _log4net = LogManager.GetLogger(typeof(Program));

//TRY CATCH FINALLY
try
{
	//PRENDIAMO IN INPUT DUE NUMERI
	_log4net.Info("Start Program");

	Console.WriteLine("Inserisci il primo numero");
	//USIAMO IL METODO INT.PARSE PER FARE UNA CONVERSIONE O CAST ESPLICITO DELLA VARIBILE POICHE Console.ReadLine() RESTITUISCE UNA STRINGA  
	int? a = int.Parse(Console.ReadLine());

	Console.WriteLine("Inserisci il secondo numero");
	int? b = int.Parse(Console.ReadLine());

	//CREIAMO UN ECCEZIONE

	zero = a / b;

	//DA QUI GESTIAMO ALCUNE POSSIBILI ECCEZIONI
}
catch (DivideByZeroException VariabileDiErrore){
	_log4net.Error("Error Type: "+ VariabileDiErrore);
}catch (NotImplementedException VariabileDiErrore){
	_log4net.Error("Error Type: " + VariabileDiErrore);
}catch (Exception VariabileDiErrore){
	_log4net.Error("Error Type: " + VariabileDiErrore);
}
//QUESTO BLOCCO VIENE ESEGUITO A PRESCINDERE DALLA PRESENZA O MENO DEGLI ERRORI
finally { 
	Console.WriteLine("Tutte le eventuali eccezioni sono state gestite [ Forse ;-) ]");
}

//FUNZIONE FAI DA TE PER LA GENERAZIONE DI ALCUNI ERRORI
void makeMock(int n){
	switch (n){
		case 0:
			throw new DivideByZeroException();
		case 1:
			throw new DuplicateWaitObjectException();
		case 2:
			throw new ArithmeticException();
		case 3:
			throw new NotImplementedException();
		case 4:
			throw new FormatException();
		case 5:
			throw new InvalidOperationException();
		default: throw new Exception();
	}
}