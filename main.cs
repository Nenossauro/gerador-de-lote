using System;
					
public class Program
{
	public static void Main()
	{
	string[] letras = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
	int lote_numero = 1;
	int lote_letra = 0;
	int lote_ult_numero = 1;
	int i = 1;
	while(lote_ult_numero <10){
	while(lote_letra <= 25){
	while(lote_numero < 1000){
		Console.WriteLine("Lote: "+lote_numero+" "+letras[lote_letra]+lote_ult_numero+". Dia: "+i);
		lote_numero ++;
		i ++;			
	}
	lote_numero = 1;
	lote_letra ++;
	}
	lote_letra = 0;
	lote_ult_numero ++;
	}
}
