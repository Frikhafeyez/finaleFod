using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyApplicationBackend.Domain;
using MyApplicationBackend.Domain.Interface;

namespace BackEndSmartCoiffure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoiffeurController : ControllerBase
    {
        private readonly ILogger<CoiffeurController> _logger;
        private List<Coiffeur> coiffeurs ;

        private readonly ILogger<CoiffeurController> _loggerHomme;
        private List<Coiffeur> coiffeursHomme;

        private readonly ILogger<CoiffeurController> _loggerFemme;
        private List<Coiffeur> coiffeursFemme;

        private InterfaceCoiffeurRepository _interfaceCoiffeurRepository;

        public CoiffeurController(
            ILogger<CoiffeurController> logger, 
            ILogger<CoiffeurController> loggerHomme, 
            ILogger<CoiffeurController> loggerFemme,
            InterfaceCoiffeurRepository interfaceCoiffeurRepository)
        {
            _logger = logger;
            _loggerHomme = loggerHomme;
            _loggerFemme = loggerFemme;
            _interfaceCoiffeurRepository = interfaceCoiffeurRepository;
        }

        [HttpGet]
        public IEnumerable<Coiffeur> Get()
        {
            _logger.LogInformation("***************   Starting *********** ");
            coiffeurs = _interfaceCoiffeurRepository.GetCoiffeursList();
            _logger.LogInformation("***************   End *********** ");
            return coiffeurs;
        }

        [HttpGet]
        [Route("homme")]
        public IEnumerable<Coiffeur> GetHommes()
        {
            _loggerHomme.LogInformation("***************   Starting list Homme  *********** ");
            coiffeursHomme = _interfaceCoiffeurRepository.GetCoiffeursListHomme();
            _loggerHomme.LogInformation("***************   End *********** ");
            return coiffeursHomme;
        }
        [HttpGet]
        [Route("femme")]
        public IEnumerable<Coiffeur> GetFemmes()
        {
            _loggerFemme.LogInformation("***************   Starting list femme  *********** ");
            coiffeursFemme = _interfaceCoiffeurRepository.GetCoiffeursListFemme();
            _loggerFemme.LogInformation("***************   End *********** ");
            return coiffeursFemme;
        }

        }
    }
