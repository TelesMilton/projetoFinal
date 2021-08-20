using System;
using System.Net.Http;
using projetoFinal.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;



namespace projetoFinal.Servicos
{ 
   public class CandidatoApiService
   {
   
        public static async Task<List<Candidato>> GetCandidatos()
        {
           HttpClient http = new HttpClient();
           var response = await http.GetAsync($"{Program.ApiHost}/candidatos");
           if(response.IsSuccessStatusCode){
               var resultado = response.Content.ReadAsStringAsync().Result;
               var candidatos = JsonConvert.DeserializeObject<List<Candidato>>(resultado);
               return candidatos;
           }
           
           return new List<Candidato>();

        }
     }       
}
        
    
