package productorConsumidor;

public class App {
	public static int PROD_TAM = 10;
	public static int BUFF_TAM = 10;
	
	public static void main(String[] args) {
		Buffer buffer1 = new Buffer(BUFF_TAM);
		Buffer buffer2 = new Buffer(BUFF_TAM);

		new Thread(new Generador(buffer1, 1)).start();
		new Thread(new Generador(buffer1, 2)).start();

		new Thread(new Ordenador(buffer1, 1, buffer2)).start();
		new Thread(new Ordenador(buffer1, 2, buffer2)).start();
		
		new Thread(new Impresor(buffer2, 1)).start();
		new Thread(new Impresor(buffer2, 2)).start();
	}
}
