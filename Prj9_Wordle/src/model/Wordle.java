package model;

import java.util.Scanner;
import java.util.ArrayList;


public class Wordle {

	public static void main(String[] args) {
		//inserimento parola chiave da trovare
		char[] arrayWordle1 = {'b','a','n','c','o'};
		
		//diamo delle istruzioni al utente
		System.out.println("inserisci una parola di massimo 5 lettere, tutte le lettere sono diverse tra loro");
		int c = 0, l = 0;
		while(c < 6) {
			//facciamo inserire la parola al utente + controlli
			Scanner input = new Scanner(System.in);
			String risposta = input.nextLine();
			boolean b = risposta.matches("[a-zA-Z]+");
			if(risposta.length()!= 5){
				System.out.println("errore devi inserire una parola di massimo 5 caratteri");
				continue;
			}else if(b == false){
				System.out.println("errore devi inserire solo lettere [a-zA-Z]");
				continue;
			}else {
				c++;
				//System.out.println(c);
			}
			//confronto tra i caratteri della parola con quella chiave, e riscontro visivo del risultato
			char[] rispArray = risposta.toCharArray();
			String v = "giusto" , f = "sbagliato", risp = c+"° tentatino) ",agg = "lettere usate presenti in altre posizioni: " ;
			for(int i = 0; i<5; i++) {
				if(arrayWordle1[i]==rispArray[i]) {
					risp += rispArray[i] + " " + v + " ";
				}else {
					risp += rispArray[i] + " " + f + " ";
					for(int t = 0; t<5; t++) {
						if(rispArray[i]==arrayWordle1[t] && i!=t) {
							agg += rispArray[i] + " ";
							l++;
							}
						}
					}
				}
			
			System.out.println(risp);
			if (l!=0) {
				System.out.println(agg);
			}
			
		}//repeat max 6
	}
	
}