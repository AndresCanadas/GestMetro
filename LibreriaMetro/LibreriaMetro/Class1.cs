using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMetro
{
    public class Trenes
    {
        #region DECLARACION DE VARIABLES 
        String matricula_tren;
        String nombre_tren;
        String modelo;
        String fecha_de_construccion;
        String DNI_conductor;
        int potencia;
        int velocidad_maxima;
        int frenos_de_seguridad_especial;
        int sistema_de_aire_acondicionado;
        #endregion

        public String Matriculatren
        {
            get
            {
                return matricula_tren;
            }
            set
            {
                matricula_tren = value;
            }
        }



    }
    public class Vagones
    {
        String matricula_vagon;
        int capacidad_de_pasajeros_sentados;
        int capacidad_de_pasajeros_de_pie;
        DateTime fecha_de_construccion;
    }
    public class Conductores
    {
        String DNI_conductor;
        String nombre;
        String apellidos;
        String direccion;
        int telefono;
        String email;
        DateTime fecha_de_ingreso;
        DateTime fecha_nacimiento;
        //estudios realizados(nombre del estudio, fecha de titulación, centro docente donde se tituló
    }
    public class Lineas
    {

    }
    public class JefedeEstacion
    {
        String DNI_del_jefe;
        String nombre;
        String apellidos;
        String estacion;
        DateTime fecha_de_entrada_al_puesto;
    }
    public class Hangar
    {

    }
    public class Cuidados
    {
        DateTime fechayhoradeatencionaltren;
        String matricula_tren_atendido;
       // tipo de atención(limpieza, revisión mecánica, revisión de materiales, electricidad, cabinas y material del pasajero, DNI del técnico que lo ha atendido, características de la atención, valoración, fecha y hora de salida de la atención.
    }
    public class Tecnicos
    {
        String DNI_tercnico;
        String nombre;
        String apellidos;
        String direccion;
        int telefono;
        String email;
        DateTime fecha_de_entrada;
        DateTime fecha_de_nacimiento;
    }
    public class Tornos
    {
        int numeropasajerosentran;
        int numeropasajerosalen;
    }
    public class Cnominas
    {
        DateTime fecha_de_nomina;
        //periodo de nómina
        String DNI_empleado;
        int sueldobrutoapercibir;
        int descuento_de_seguridad_social;
        int descuente_de_IRPF;
        int plus_de_trienios;
        int plus_de_productividad;
        int sueldo_neto_a_percibir;
        //Hay empleados que trabajan por horas, para estos es necesario especificar el precio hora y el número total de horas que trabajan al mes.
    }


}
