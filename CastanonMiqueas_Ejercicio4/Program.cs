Console.WriteLine("Tipo de incidente: \n1. Malware \n2. Phishing \n3. Acceso no autorizado \n4. Fuga de información");
int tipoIncidente = int.Parse(Console.ReadLine());

Console.WriteLine("Activo afectado: \n1. PC \n2. Servidor \n3. Base de datos \n4. Red");
int activoAfectado = int.Parse(Console.ReadLine());

Console.WriteLine("Datos compromeditos: \n1. Ninguno \n2. Internos \n3. Personales \n4. Financieros");
int datosComprometidos = int.Parse(Console.ReadLine());

Console.WriteLine("Persistencia afectada S/N:");
string persistenciaAfectada = Console.ReadLine();
Console.WriteLine("Numero de usuarios afectados:");
int numeroUsuariosAfectados = int.Parse(Console.ReadLine());


if (tipoIncidente < 0|| tipoIncidente > 4 || activoAfectado < 0 || activoAfectado > 4 || datosComprometidos < 0 || datosComprometidos > 4 || numeroUsuariosAfectados < 0)
{
    Console.WriteLine("Error: Opción no válida. Por favor, ingrese un número entre 1 y 4.");
}
else
{
    switch (tipoIncidente)
    {
        case 1:
            Console.WriteLine("Tipo de incidente: Malware");

            if (activoAfectado == 1 || activoAfectado == 2 || activoAfectado == 3 || activoAfectado == 4)
            {
                if (datosComprometidos == 2 || datosComprometidos == 3 || datosComprometidos == 4)
                {
                    if (persistenciaAfectada == "S" || persistenciaAfectada == "s" || numeroUsuariosAfectados > 2)
                    {
                        Console.WriteLine("Severidad: Alta\nRecomendación: Aislar el dispositivo afectado, realizar un análisis completo con un software antivirus/antimalware actualizado, eliminar las amenazas detectadas, cambiar contraseñas y monitorear la actividad del sistema");
                    }
                    else if (persistenciaAfectada == "N" || persistenciaAfectada == "n" || numeroUsuariosAfectados <= 1)
                    {

                        Console.WriteLine("Serveridad : Critica \nRecomendación: aislar el dispositivo desconectándolo de internet, " +
                                          "ejecutar un análisis completo con un software antivirus/antimalware actualizado, eliminar las amenazas detectadas y cambiar contraseñas");
                    }
                }
                else
                {
                    Console.WriteLine("Severidad: Media\nRecomendación: Eliminar malware del dispositivo");
                }
            }
            break;

        case 2:
            Console.WriteLine("Tipo de incidente: Phishing");
            if (activoAfectado == 1 || activoAfectado == 2 || activoAfectado == 3 || activoAfectado == 4)
            {
                if (datosComprometidos == 2 || datosComprometidos == 3 || datosComprometidos == 4)
                {
                    if (persistenciaAfectada == "S" || persistenciaAfectada == "s" || numeroUsuariosAfectados > 2)
                    {
                        Console.WriteLine("Severidad: Alta\nRecomendación: mantener una desconfianza proactiva ante cualquier mensaje que solicite datos o acciones urgentes");
                    }
                    else
                    {

                        Console.WriteLine("Serveridad : Media \nRecomendación: mantener una desconfianza proactiva ante cualquier mensaje que solicite datos o acciones urgentes");
                    }
                }
                else
                {
                    Console.WriteLine("Severidad: Baja\nRecomendación: Realizar una revisión del dispositivo");
                }
            }
            break;

        case 3:
            Console.WriteLine("Tipo de incidente: Acceso no autorizado");
            if (activoAfectado == 1 || activoAfectado == 2 || activoAfectado == 3 || activoAfectado == 4)
            {
                if (datosComprometidos == 2 || datosComprometidos == 3 || datosComprometidos == 4)
                {
                    if (persistenciaAfectada == "S" || persistenciaAfectada == "s" || numeroUsuariosAfectados > 2)
                 
                    {
                        Console.WriteLine("Severidad: Alta\nRecomendación: Cambiar contraseñas, revisar los registros de acceso y monitorear la actividad del sistema para detectar cualquier actividad sospechosa");
                    }
                    else
                    {
                        Console.WriteLine("Serveridad : Media \nRecomendación: Cambiar contraseñas, revisar los registros de acceso y monitorear la actividad del sistema para detectar cualquier actividad sospechosa");
                    }
                }
                else
                {
                    Console.WriteLine("Severidad: Baja\nRecomendación: Revisar los registros de acceso y monitorear la actividad del sistema para detectar cualquier actividad sospechosa");
                }
            }
            break;
        case 4:
            Console.WriteLine("Tipo de incidente: Fuga de información");
            if (activoAfectado == 1 || activoAfectado == 2 || activoAfectado == 3 || activoAfectado == 4)
            {
                if (datosComprometidos == 2 || datosComprometidos == 3 || datosComprometidos == 4)
                {
                    if (persistenciaAfectada == "S" || persistenciaAfectada == "s" || numeroUsuariosAfectados > 2)
                    {
                        Console.WriteLine("Severidad: Alta\nRecomendación: Identificar la fuente de la fuga, contenerla, notificar a las partes afectadas y revisar las políticas de seguridad para prevenir futuras fugas");
                    }
                    else
                    {
                        Console.WriteLine("Serveridad : Media \nRecomendación: Identificar la fuente de la fuga, contenerla, notificar a las partes afectadas y revisar las políticas de seguridad para prevenir futuras fugas");
                    }
                }
                else
                {
                    Console.WriteLine("Severidad: Baja\nRecomendación: Revisar las políticas de seguridad para prevenir futuras fugas");
                }
            }
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, ingrese un número entre 1 y 4.");
            break;
    }
}