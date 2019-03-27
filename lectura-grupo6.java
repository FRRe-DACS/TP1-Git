import java.util.Scanner;

public class Bienvenida{

	public static void main(String[] args){
		System.out.println("-----RZ Software----");
		System.out.println("");
		System.out.println("Hola, por favor ingresá tu Nombre: ");
		System.out.println("");
		String entradaTeclado="";
		Scanner entradaScanner= new Scanner(System.in);
		entradaTeclado = entradaScanner.nextLine();
		System.out.println("");
		System.out.println("Bienvenid@ "+entradaTeclado+" gracias por elegirnos!!!");
		System.out.println("");
		System.out.println("Hasta la proxima...");



	}
}


