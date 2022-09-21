using FormForCafeTap.Models;
using System.Collections.Generic;

namespace FormForCafeTap.ViewModels
{
    public class HomeVM
    {
        public List<Form> Forms { get; set; }
        public List<Work> Works { get; set; }
        public List<University> Universities { get; set; }
    }
}
