using AcunmedyaAkademiBabyCare.Context;
using AcunmedyaAkademiBabyCare.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcunmedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultTeamComponentPartial:ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultTeamComponentPartial(BabyCareContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            try
            {
                var values = _context.Teams
                    .Include(t => t.Branch) // Branch tablosunu dahil et
                    .ToList();

                // Hata ayıklama için konsola yaz
                Console.WriteLine($"Bulunan takım üyesi sayısı: {values.Count}");
                foreach (var item in values)
                {
                    Console.WriteLine($"Üye: {item.NameSurname}, Branş: {item.Branch?.BranchName ?? "Bilinmiyor"}, Şehir: {item.City}");
                }

                return View(values);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return View(new List<Team>());
            }
        }
    }
}
