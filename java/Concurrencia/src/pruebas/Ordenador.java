package pruebas;

import java.util.Arrays;

public class Ordenador {
	private double[] arr;
	
	public Ordenador(int tam) {
		this.arr = new double[tam];
		this.inicializar();
	}
	
	private void inicializar() {
		for(int i=0; i<this.arr.length; i++) {
			this.arr[i] = Math.random()*1000;
		}
	}
	
	public double[] ordenar() {
		Arrays.sort(this.arr);
		return this.arr;
	}
}
