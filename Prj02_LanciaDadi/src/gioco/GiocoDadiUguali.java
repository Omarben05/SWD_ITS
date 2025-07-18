package gioco;

public class GiocoDadiUguali {
	
	public static void main(String[] args) {
		
		Dado dado1 = new Dado();
		Dado dado2 = new Dado();
		
		final int NUM_LANCI = 10; //snake_case
		int vittorie = 0;
		
		//un ciclo per ripetere le istruzioni per NUM_LANCI
		
		long start= System.currentTimeMillis();
		
		for(int i = 0; i < NUM_LANCI; i++) {

			dado1.lanciaDado();
			dado2.lanciaDado();
			
			System.out.println("Il valore di dado 1" + dado1.valoreFacciaSuperiore);
			System.out.println("Il valore di dado 2" + dado2.valoreFacciaSuperiore);
			
			
			if (dado1.valoreFacciaSuperiore == dado2.valoreFacciaSuperiore) {
				System.out.println("Hai vinto");
				vittorie++;//incremento le vittorie
				
			} else {
				System.out.println("Non hai vinto");
			}
		} //chiude il ciclo for
		
		long stop = System.currentTimeMillis();
		long tempoImpiegato = stop - start; //ms
		double percentuale = (double) vittorie/NUM_LANCI *100;
		
		System.out.println("Percentuale vittorie" + percentuale +"%");
		System.out.println("Numero di vittorie" + vittorie);
		System.out.println("Numero di partite" + NUM_LANCI); 
		System.out.println("Tempo impiegato" + tempoImpiegato + "ms"); 
		
	} // chiude il main
} //chiude la classe
