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
            var P = new Palindromo();
            P.palindromo = guardar;

            var PFinal = string.Empty;
            var Pcontar = guardar;

            int i = Pcontar.Length;

            var PalindrFinal = "";

            for (int j = i - 1; j >= 0; j--)
            {
                PFinal = PFinal + Pcontar[j];
            }
            if (PFinal.ToLower().Replace(" ", string.Empty) == Pcontar.ToLower().Replace(" ", string.Empty))
            {
                PalindrFinal = (Pcontar + " es palindrome");
            }
            else
            {
                PalindrFinal = (Pcontar + " no es palindrome");
            }

            int Semi = Pcontar.Length - Pcontar.Replace(" ", string.Empty).Count() + 1;
            var ResultadoInvert = ("La palabra ingresada: " + PalindrFinal.ToLower() + " y su invertido es: " + PFinal.ToLower() + "El numero de palabras es: " + Semi);
            return Ok(ResultadoInvert.ToLower());
        }
    }
}