using AcunmedyaAkademiBabyCare.Context;
using AcunmedyaAkademiBabyCare.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultEventComponentPartial:ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultEventComponentPartial(BabyCareContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            try
            {
                var values = _context.Events
                    .Where(e => e.Date >= DateTime.Today) // Gelecekteki etkinlikler
                    .OrderBy(e => e.Date) // Tarihe göre sırala
                    .Take(3) // İlk 3 etkinlik
                    .ToList();

                // Hata ayıklama için konsola yaz
                Console.WriteLine($"Bulunan etkinlik sayısı: {values.Count}");
                foreach (var item in values)
                {
                    Console.WriteLine($"Etkinlik: {item.EventName}, Tarih: {item.Date:dd.MM.yyyy}, Şehir: {item.City}");
                }

                return View(values);
            }
            catch (Exception ex)
            {
                // Hata durumunda konsola yaz
                Console.WriteLine($"Hata: {ex.Message}");
                return View(new List<Event>()); // Boş liste döndür
            }
        }
    }
}
