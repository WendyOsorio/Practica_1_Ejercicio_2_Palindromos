using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * Nombre de la escuela: Universidad Tecnologica Metropolitana
 * Asignatura: Aplicaciones Web Orientadas a Objetos
 * Nombre del Maestro: Chuc Uc Joel Ivan
 * Nombre de la actividad: Palindromos
 * Nombre del alumno: Osorio Solis Wendy Yazmin
 * Cuatrimestre: 4
 * Grupo: C
 * Parcial: 1
*/

namespace Practica_1_Ejercicio_2_Palindromos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromoController : ControllerBase
    {
        [HttpGet]
        public IActionResult PalindromoResultado(string palabra)
        {
            var P = new Datos();
            P.Palabra = palabra;
            var PalindromoFinal = string.Empty;
            var PalindromoContado = palabra;
            int i = PalindromoContado.Length;
            var Resultado = "";

            for (int n = i - 1; n >= 0; n--)
            {

            }

            for (int j = i - 1; j >= 0; j--)
            {
                PalindromoFinal = PalindromoFinal + PalindromoContado[j];
            }
            if (PalindromoFinal.ToLower().Replace(" ", string.Empty) == PalindromoContado.ToLower().Replace(" ", string.Empty))
            {
                Resultado = (PalindromoContado + " es palindrome");
            }
            else
            {
                Resultado = (PalindromoContado + " no es palindrome");
            }
            int Palabras = PalindromoContado.Length - PalindromoContado.Replace(" ", string.Empty).Count() + 1;
            var PalindromorInvertido = ("La palabra ingresada: " + Resultado.ToLower() + " y su invertido es: " + PalindromoFinal.ToLower() + ", el numero de palabras es: " + Palabras);
            return Ok(PalindromorInvertido.ToLower());

        }
    }
}

