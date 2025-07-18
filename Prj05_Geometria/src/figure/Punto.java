package figure;

public class Punto {
	public int x, y;
	//           parametri fromali          argomenti attuali
	public Punto(int x, int y) {//new Punto(3, 2);
		this.x = x; //per dire quale tra le tante
		this.y = y;
	}
	
	public String toString() {
		return "(" + this.x + ", " + this.y + ")"; //(3,2)
	}
}
