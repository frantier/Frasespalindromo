using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Objetos
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Palindromos
Nombre del alumno: Pedro Victor Ruvalcaba Novelo
Cuatrimestre: 4
Grupo: B
Parcial: 1
*/

namespace Frasespalindromo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejecucionpalindromo : ControllerBase
    {
        [HttpGet]
        public IActionResult PalindromoResultado(string guardar)
        {

            // Definicion de variables//

            var P = new Palindromo();
            P.palindromo = guardar;

            var PFinal = string.Empty;
            var Pcontador = guardar;

            int i = Pcontador.Length;

            var PalindrFinal = "";

            //Este es el ciclo en el cual se le establecio un contador, ponga las letras sin espacio e identifique si es un palindrome//

            for (int j = i - 1; j >= 0; j--)
            {
                PFinal = PFinal + Pcontador[j];
            }
            if (PFinal.ToLower().Replace(" ", string.Empty) == Pcontador.ToLower().Replace(" ", string.Empty))
            {
                PalindrFinal = (Pcontador + " es palindrome");
            }
            else
            {
                PalindrFinal = (Pcontador + " no es palindrome");
            }

            int palabrasespacio = Pcontador.Length - Pcontador.Replace(" ", string.Empty).Count() + 1;
            var ResultadoInvert = ("La palabra ingresada: " + PalindrFinal.ToLower() + " y su invertido es: " + PFinal.ToLower() + "El numero de palabras es: " + palabrasespacio);
            return Ok(ResultadoInvert.ToLower());
        }
    }
}