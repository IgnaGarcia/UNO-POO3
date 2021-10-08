package pruebas;

public class Hilo1 implements Runnable{
	private long tiempoDeEspera;
	
	public Hilo1(long tiempo) {
		this.tiempoDeEspera = tiempo;
	}
	
	@Override
	public void run() {
		try {
			Thread.sleep(tiempoDeEspera);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		
		System.out.println(this.tiempoDeEspera + " - " + System.currentTimeMillis());
	}
	
	public static void main(String[] args) throws InterruptedException {
		Hilo1 h1 = new Hilo1(2500l);
		Hilo1 h2 = new Hilo1(1000l);
		
		Thread t1 = new Thread(h1);
		Thread t2 = new Thread(h2);
		Thread t3 = new Thread(h1);
		
		System.err.println("Inicio");
		t1.start();
		t2.start();
		t3.start();
		
		System.err.println("Intermedio");
		
		t1.join();
		t2.join();
		t3.join();
		System.err.println("Fin");
	}
}
