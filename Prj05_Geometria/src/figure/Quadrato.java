package figure;

public class Quadrato extends Rettangolo {
	
	private Segmento lato;
	/**
	 * costruttore del quadrato: prima costruisco il
	 * Rettangolo passando 2 volte il lato del quadrato
	 * @param lato come parametro iniziale, inserisci il lato del quadrato
	 */
	public Quadrato(Segmento lato) {
		super(lato, lato);
		this.lato = lato;
	}
	
	
	@Override
	public double perimetro() {
		System.out.println("Metodo di quadrato");
		return lato.lunghezza() * 4;
	}



	public String toString() {
		return "Quadrato [perimetro()=" + perimetro() + area();
	}
}
