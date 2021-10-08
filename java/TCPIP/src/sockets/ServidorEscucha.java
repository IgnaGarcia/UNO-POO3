package sockets;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.Socket;

public class ServidorEscucha implements Runnable {
	Socket elCliente;
	DataOutputStream salida;
	BufferedReader entrada;
	String leido;

	public ServidorEscucha(Socket cliente) {
		this.elCliente = cliente;
	}

	public void run() {
		System.out.println(
				"\n Entro puerto= " + this.elCliente.getPort() + "ip" + this.elCliente.getRemoteSocketAddress());

		try {
			salida = new DataOutputStream(elCliente.getOutputStream());

			salida.writeBytes("\nHola\n");
			Thread.sleep(5000);

			while (true) {
				this.entrada = new BufferedReader(new InputStreamReader(this.elCliente.getInputStream()));

				System.out.print("\nEsperando");

				this.leido = this.entrada.readLine();
				System.out.print("\nLeido " + this.leido + "\n");
				
				File directory = new File(this.leido);
				File[] contents = directory.listFiles();
				String res = "";
				for (File f : contents) {
				  res+= f.getName()+"\n";
				}
				salida.writeBytes(res);
			}

		} catch(IOException e) {
			System.out.println("Directorio invalido "+e.getMessage());
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}

	}

}
