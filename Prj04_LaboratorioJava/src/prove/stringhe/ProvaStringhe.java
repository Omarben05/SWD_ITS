package prove.stringhe;

public class ProvaStringhe {

	public static void main(String[] args) {
		
		String s1 = "Ciao";
		String sX = "Ciao";
		String s2 = new String("Ciao");
		char[] c1= {'c','i','a','o'};
		String s3 = new String(new char[]{'c','i','a','o'});
		
		System.out.println(s1 == s2);
		System.out.println(s1 == s3);
		System.out.println(s2 == s3);
		System.out.println("-----------------");
		System.out.println(s1 == sX);
		System.out.println("-----------------");
		
		System.out.println(s1.equals (s2));
		System.out.println(s1.equals (s3));
		System.out.println(s2.equals (s3));
		
	}

}
