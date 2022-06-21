using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorialDomain.Enums
{
    public enum Gender
    {
        [Display (Name = "Aventuras")]
        Adventure = 1,
        [Display(Name = "CienciaFicción")]
        ScienceFiction,
        [Display(Name = "Policíaca")]
        Police,
        [Display(Name = "TerrorMisterio")]
        TerrorMystery,
        [Display(Name = "Romántica")]
        Romantic,
        [Display(Name = "Mitología")]
        Mythology,
        [Display(Name = "Teatro")]
        Theater,
        [Display(Name = "Cuento")]
        Story
    }
}
