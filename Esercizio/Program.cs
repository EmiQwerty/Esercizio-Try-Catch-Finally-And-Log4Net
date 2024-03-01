using System.Data.SqlTypes;
using System.Runtime.ExceptionServices;

int? zero = 0;

//TRY CATCH FINALLY

try
{
	//PRENDIAMO IN INPUT DUE NUMERI

	Console.WriteLine("Inserisci il primo numero");
	//USIAMO IL METODO INT.PARSE PER FARE UNA CONVERSIONE O CAST ESPLICITO DELLA VARIBILE POICHE Console.ReadLine() RESTITUISCE UNA STRINGA  
	int? a = int.Parse(Console.ReadLine());

	Console.WriteLine("Inserisci il secondo numero");
	int? b = int.Parse(Console.ReadLine());

	//CREIAMO UN ECCEZIONE

	zero = a / b;

	//DA QUI GESTIAMO ALCUNE POSSIBILI ECCEZIONI
}catch (DivideByZeroException VariabileDiErrore){
	Console.WriteLine("Error 1: "+VariabileDiErrore);
}catch (DuplicateWaitObjectException VariabileDiErrore){
	Console.WriteLine("Error 2: " + VariabileDiErrore);
}catch (ArithmeticException VariabileDiErrore){
	Console.WriteLine("Error 3: " + VariabileDiErrore);
}catch (InvalidOperationException VariabileDiErrore){
	Console.WriteLine("Error 4: " + VariabileDiErrore);
}catch (FormatException VariabileDiErrore){
	Console.WriteLine("Error 5: " + VariabileDiErrore);
	try { 
		//GENERATORE FAI FA TE DI ECCEZIONI
		makeMock(5);
	}
	//ULTERIORE GESTIONE GENERICA DELL'ECCEZIONE
	catch(Exception ex) { 
		Console.WriteLine(ex.Message);
	}
}catch (NotImplementedException VariabileDiErrore){
	Console.WriteLine("Error 6: " + VariabileDiErrore);
}catch (Exception VariabileDiErrore){
	Console.WriteLine("Error 7 ( Generic ): " + VariabileDiErrore);
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