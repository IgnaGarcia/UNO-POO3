package pruebas;

import java.util.Arrays;

public class Hilo2 implements Runnable{
	private Ordenador o;
	private int tam;
	private int n;
	private static double sumTiempo = 0; 
	
	public Hilo2(int tam, int n) {
		this.tam = tam;
		this.n = n;
		this.o = new Ordenador(tam);
	}
	
//	public void correr() {
//		this.o.ordenar();
//		System.out.println(n + " Finalizo: " + tam);
//	}
	
	public synchronized void sumarTiempo(double tiempo) {
		this.sumTiempo += tiempo;
	}
	
	@Override
	public void run() {
		long startMillis = System.currentTimeMillis();
		this.o.ordenar();
		long endMillis = System.currentTimeMillis();
		sumarTiempo(endMillis-startMillis);
		System.out.println(n + " Finalizo: " + tam + "; Tiempo: " + (endMillis-startMillis) + " milis");
	}
	
	public static void main(String[] args) throws InterruptedException {
		int tam = 300;
		
		//Hilos		
		Thread[] hilos = new Thread[tam];
		
		System.out.println("INICIO Hilos");
		long startMillis = System.currentTimeMillis();
		for(int i=0; i<tam; i++) {
			hilos[i] = new Thread(new Hilo2( (int) ((i+1) * (Math.random()*10000)), i ));
			hilos[i].start();
		}
		
		System.out.println("INTERMEDIO Hilos");
		
		for(int i=0; i<tam; i++) hilos[i].join();
		
		long tiempoHilos = System.currentTimeMillis() - startMillis;
		System.err.println("FIN Hilos- Demoro: " + tiempoHilos + "segs");
		System.out.println("Tiempo total: " + sumTiempo/1000 + "segs; Hilos: " + tam + 
				"; Promedio: " + sumTiempo/tam + "milis");
		
		
		//Secuencial
//		hilos = null;
//		Hilo2[] seq = new Hilo2[tam];
//		
//		System.out.println("INICIO Secuencial");
//		startMillis = System.currentTimeMillis();
//		
//		for(int i=0; i<tam; i++) seq[i] = new Hilo2( (int) ((i+1) * (Math.random()*10000)), i );
//		
//		for(int i=0; i<tam; i++) seq[i].correr();
//		
//		long tiempoSecuencial = System.currentTimeMillis() - startMillis;
//		System.err.println("FIN Secuencial- Demoro: " + tiempoSecuencial/1000 + "segs");
//		
//		System.err.println("Hilos fue " + (tiempoSecuencial-tiempoHilos)/1000 + "segs mas rapido");
	}
}
