package numeri;

public class ProvaInteri {
	
	public static void main(String[] args) {
		
		//final byte b = 1; //8bit  -128 +127  //quando è final non puo più essere estesa
		byte b = 1; //8bit - 128 +127
		short s = 2; //16 bit
		int i = 3; //32bit
		long lo = 4; //64bit
		
		int somma= b + s + i + (int)lo; //   +  = operatore aritmetico 
		System.out.println(b);
		System.out.println(s);
		System.out.println(i);
		System.out.println(lo);
		System.out.println("Il valore di somma: " + somma); //  + = operatore concatenamento
		
	}

}
