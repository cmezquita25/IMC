using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//UNIVERSIDAD TECNOLOGICA METROPOLITANA
//JOEL IVAN CHUC UC
//APLICACIONES WEB ORIENTADAS A SERVICIOS
//CARLOS MANUEL MEZQUITA ALVARADO
// CALCULAR INDICE DE MASA CORPORAL
// 4 ° B
//PARCIAL 1
// SEPTIEMBRE - DICIEMBRE 2021


namespace IMC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Resultado : ControllerBase
    {
        [HttpGet]
        public IActionResult IMCFinal(double altura, double peso)
        {
            //VARIABLES
            var R = new Persona();
            R.Peso = peso;
            R.Altura = altura / 100;
            var alturaFinal = R.Altura;
            var IMC = peso / (alturaFinal * alturaFinal);
            var Calculo = "";


            //CALCULOS
            if (IMC < 18.5)
            {
                Calculo = "TIENE UN PESO INFERIOR AL NORMAL";
            }
            else
            {
                if (IMC >= 18.5 && IMC <= 24.9)
                {
                    Calculo = "TIENE UN PESO NORMAL";
                }
                else
                {
                    if (IMC >= 25.0 && IMC <= 29.9)
                    {
                        Calculo = "TIENES UN PESO SUPERIOR AL NORMAL";
                    }
                    else
                    {
                        Calculo = "TIENE OBESIDAD";
                    }
                }
            }
            //RESULTADO FINAL
            var Resultado = "SU IMC ES: " + Convert.ToString(IMC) + " SU RESULTADO ES: " + Calculo;

            return Ok(Resultado);
        }
    }
}
