Console.WriteLine("Tipo de incidente: \n 1. Malware \n2. Phishing \n3. Acceso no autorizado \n4. Fuga de información");
int tipoIncidente = int.Parse(Console.ReadLine());

Console.WriteLine("Activo afectado: \n1. PC \n2. Servidor \n3. Base de datos \n.4. Red");
int activoAfectado = int.Parse(Console.ReadLine());

Console.WriteLine("Datos compromeditos: \n1. Ninguno \n2. Internos \n3. Personales \n4. Financieros");
int datosComprometidos = int.Parse(Console.ReadLine());

Console.WriteLine("Persistencia afectada S/N:");
string persistenciaAfectada = Console.ReadLine();
Console.WriteLine("Numero de usuarios afectados:");
int numeroUsuariosAfectados = int.Parse(Console.ReadLine());