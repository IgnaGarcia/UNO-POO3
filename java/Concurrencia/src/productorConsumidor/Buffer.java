package productorConsumidor;

import java.util.Arrays;

public class Buffer {
	private double[][] buffer = null;
	private int length = 0;
	private int size = 0;
	private int putIndex = 0;
	private int popIndex = 0;

	public Buffer(int length) {
		this.length = length;
		this.buffer = new double[length][];
	}

	public synchronized void put(double[] value) {
		while (size == length) {
			try {
				System.out.println("---WAIT – buffer lleno");
				wait();
			} catch (InterruptedException e) {
				System.err.println("wait interrumpido");
			}
		}

		buffer[putIndex] = value;
		putIndex = (putIndex + 1) % length;

		size++;
		if (size == 1)
			notify();
	}

	public synchronized double[] pop() {
		double[] value;

		while (size == 0) {
			try {
				System.out.println("---WAIT - buffer vacio");
				wait();
			} catch (InterruptedException e) {
				System.err.println("wait interrumpido");
			}
		}

		value = buffer[popIndex];
		buffer[popIndex] = null;
		popIndex = (popIndex + 1) % length;

		size--;
		if (size == length - 1)
			notify();

		return value;
	}

	@Override
	public String toString() {
		return this.size+" elementos";
	}
}
