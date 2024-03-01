using System.Data.SqlTypes;
using System.Runtime.ExceptionServices;

int? zero = 0;


try
{
	Console.WriteLine("Inserisci il primo numero");
	int? a = int.Parse(Console.ReadLine());
	Console.WriteLine("Inserisci il secondo numero");
	int? b = int.Parse(Console.ReadLine());

	zero = a / b;

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
		makeMock(5);
	}
	catch(Exception ex) { 
		Console.WriteLine(ex.Message);
	}

}catch (NotImplementedException VariabileDiErrore){
	Console.WriteLine("Error 6: " + VariabileDiErrore);
}catch (Exception VariabileDiErrore){
	Console.WriteLine("Error 7 ( Generic ): " + VariabileDiErrore);
}finally { 
	Console.WriteLine("Tutte le eventuali eccezioni sono state gestite [ Forse ;-) ]");
}

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