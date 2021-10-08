using System.IO;
using System.Net.Sockets;

class cl1 {
    TcpClient tcpClient;
    NetworkStream ss;
    StreamReader clientStreamReader;

    public cl1() {
        tcpClient = new TcpClient();
        tcpClient.Connect("localhost", 60001);

        ss = tcpClient.GetStream();
        clientStreamReader = new StreamReader(ss);
    }

    public void Enviar(string S) {
        string aEnviar = S + "\n";
        byte[] ss2 = Encoding.ASCII.GetBytes(aEnviar);
        ss.Write(ss2, 0, ss2.Length);
    }

    public string Recibir() {
        string recibido = "";
        clientStreamReader.BaseStream.ReadTimeout = 20000;
        recibido = clientStreamReader.ReadLine();
        recibido = clientStreamReader.ReadLine();
        return recibido;
    }

    public void probar() {
        string recibido;

        string aEnviar = "hola mundo\n";
        byte[] ss2 = Encoding.ASCII.GetBytes(aEnviar);

        ss.Write(ss2, 0, ss2.Length);
        recibido = clientStreamReader.ReadLine();
        recibido = clientStreamReader.ReadLine();
        //}
    }
}
