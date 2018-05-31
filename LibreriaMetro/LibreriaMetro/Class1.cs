using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMetro
{
    #region CLASE TRENES
    public class Tren
    {
        #region DECLARACION DE VARIABLES 
        String matricula;
        String nombre;
        String modelo;
        String fechaConstruccion;
        String dniConductor;
        float potencia;
        float velocidadMaxima;
        String frenosSE;
        String sistemaAA;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string FechaConstruccion { get => fechaConstruccion; set => fechaConstruccion = value; }
        public string DniConductor { get => dniConductor; set => dniConductor = value; }
        public float Potencia { get => potencia; set => potencia = value; }
        public float VelocidadMaxima { get => velocidadMaxima; set => velocidadMaxima = value; }
        public string FrenosSE { get => frenosSE; set => frenosSE = value; }
        public string SistemaAA { get => sistemaAA; set => sistemaAA = value; }
        #endregion
    }
    #endregion

    #region CLASE VAGONES
    public class Vagon
    {
        #region DECLARACION DE VARIABLES
        String matricula;
        int capacidadPS;
        int capacidadPP;
        DateTime fechaConstruccion;
        String matriculaTren;

        public string Matricula { get => matricula; set => matricula = value; }
        public int CapacidadPS { get => capacidadPS; set => capacidadPS = value; }
        public int CapacidadPP { get => capacidadPP; set => capacidadPP = value; }
        public DateTime FechaConstruccion { get => fechaConstruccion; set => fechaConstruccion = value; }
        public string MatriculaTren { get => matriculaTren; set => matriculaTren = value; }
        #endregion
    }
    #endregion

    #region CLASE CONDUCTORES
    public class Conductor
    {
        #region DECLARACION DE VARIABLES
        String dni;
        String nombre;
        String apellidos;
        String direccion;
        int telefono;
        String email;
        DateTime fechaIngreso;
        DateTime fechaNacimiento;
        String nombreEstudio;
        DateTime fechaTitulacion;
        String centroTitulacion;

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string NombreEstudio { get => nombreEstudio; set => nombreEstudio = value; }
        public DateTime FechaTitulacion { get => fechaTitulacion; set => fechaTitulacion = value; }
        public string CentroTitulacion { get => centroTitulacion; set => centroTitulacion = value; }
        #endregion
    }
    #endregion

    #region CLASE LINEAS
    public class Linea
    {
        #region DECLARACION DE VARIABLES
        int id;
        String nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        #endregion
    }
    #endregion

    #region CLASE ESTACION
    public class Estacion
    {
        #region DECLARACION DE VARIABLES
        int id;
        String nombre;
        int idLinea;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdLinea { get => idLinea; set => idLinea = value; }
        #endregion
    }
    #endregion

    #region CLASE JEFE ESTACION
    public class JefeEstacion
    {
        #region DECLARACION DE VARIABLES
        String dni;
        String nombre;
        String apellidos;
        String estacion;
        DateTime fechaEntrada;

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Estacion { get => estacion; set => estacion = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        #endregion
    }
    #endregion

    #region CLASE INCIDENCIA
    public class Incidencia
    {
        #region DECLARACION DE VARIABLES
        int id;
        DateTime fechaHora;
        String nombreEstacion;
        String caracteristicas;
        String valoracion;

        public int Id { get => id; set => id = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public string NombreEstacion { get => nombreEstacion; set => nombreEstacion = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public string Valoracion { get => valoracion; set => valoracion = value; }
        #endregion
    }
    #endregion

    #region CLASE HANGAR
    public class Hangar
    {
        #region DECLARACION DE VARIABLES
        int id;
        String dniConductor;
        int plaza;
        DateTime fechaHoraEntrada;
        DateTime fechaHoraSalida;
        String matriculaTren;

        public int Id { get => id; set => id = value; }
        public string DniConductor { get => dniConductor; set => dniConductor = value; }
        public int Plaza { get => plaza; set => plaza = value; }
        public DateTime FechaHoraEntrada { get => fechaHoraEntrada; set => fechaHoraEntrada = value; }
        public DateTime FechaHoraSalida { get => fechaHoraSalida; set => fechaHoraSalida = value; }
        public string MatriculaTren { get => matriculaTren; set => matriculaTren = value; }
        #endregion
    }
    #endregion

    #region CLASE CUIDADOS
    public class Cuidado
    {
        #region DECLARACION DE VARIABLES
        int id;
        DateTime fechaHoraEntrada;
        DateTime fechaHoraSalida;
        String matriculaTren;
        String tipoAtencion;
        String dniTecnico;
        String caracteristicas;
        String valoracion;

        public int Id { get => id; set => id = value; }
        public DateTime FechaHoraEntrada { get => fechaHoraEntrada; set => fechaHoraEntrada = value; }
        public DateTime FechaHoraSalida { get => fechaHoraSalida; set => fechaHoraSalida = value; }
        public string MatriculaTren { get => matriculaTren; set => matriculaTren = value; }
        public string TipoAtencion { get => tipoAtencion; set => tipoAtencion = value; }
        public string DniTecnico { get => dniTecnico; set => dniTecnico = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public string Valoracion { get => valoracion; set => valoracion = value; }
        #endregion
    }
    #endregion

    #region CLASE TECNICOS
    public class Tecnico
    {
        #region DECLARACION DE VARIABLES
        String dni;
        String nombre;
        String apellidos;
        String direccion;
        int telefono;
        String email;
        DateTime fechaEntrada;
        DateTime fechaNacimiento;
        String tipoTrabajo;

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string TipoTrabajo { get => tipoTrabajo; set => tipoTrabajo = value; }
        #endregion
    }
    #endregion

    #region CLASE TORNOS
    public class Torno
    {
        #region DECLARACION DE VARIABLES
        int id;
        int numeroPE;
        int numeroPS;

        public int Id { get => id; set => id = value; }
        public int NumeroPE { get => numeroPE; set => numeroPE = value; }
        public int NumeroPS { get => numeroPS; set => numeroPS = value; }
        #endregion
    }
    #endregion

    #region CLASE NOMINAS
    public class Nomina
    {
        #region DECLARACION DE VARIABLES
        int id;
        DateTime fecha;
        DateTime periodo;
        String dniEmpleado;
        float sueldoBruto;
        float descuentoSS;
        int descuentoIRPF;
        int plusTrienios;
        int plusProductividad;
        int sueldoNeto;
        String tipoContrato;
        float precioHora;
        int totalHoras;

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Periodo { get => periodo; set => periodo = value; }
        public string DniEmpleado { get => dniEmpleado; set => dniEmpleado = value; }
        public float SueldoBruto { get => sueldoBruto; set => sueldoBruto = value; }
        public float DescuentoSS { get => descuentoSS; set => descuentoSS = value; }
        public int DescuentoIRPF { get => descuentoIRPF; set => descuentoIRPF = value; }
        public int PlusTrienios { get => plusTrienios; set => plusTrienios = value; }
        public int PlusProductividad { get => plusProductividad; set => plusProductividad = value; }
        public int SueldoNeto { get => sueldoNeto; set => sueldoNeto = value; }
        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }
        public float PrecioHora { get => precioHora; set => precioHora = value; }
        public int TotalHoras { get => totalHoras; set => totalHoras = value; }
        #endregion
    }
    #endregion
}
