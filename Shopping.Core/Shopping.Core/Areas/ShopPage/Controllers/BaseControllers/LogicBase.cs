﻿using Microsoft.AspNet.Identity.EntityFramework;
using Shopping.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Core.Areas.ShopPage.Controllers.BaseControllers
{
    public class LogicBase : IDisposable
    {
        protected ShopEntities Database;

        public LogicBase(ShopEntities db)
        {
            Database = db;
        }
        public LogicBase()
        {
            Database = new ShopEntities();
        }
        #region IDisposable Support
        private bool disposedValue = false; // Aby wykryć nadmiarowe wywołania

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: wyczyść stan zarządzany (obiekty zarządzane).
                    Database.Dispose();
                }

                // TODO: Zwolnić niezarządzane zasoby (niezarządzane obiekty) i przesłonić poniższy finalizator.
                // TODO: ustaw wartość null dla dużych pól.

                Database = null;

                disposedValue = true;
            }
        }

        // TODO: Przesłonić finalizator tylko w sytuacji, gdy powyższa metoda Dispose(bool disposing) zawiera kod służący do zwalniania niezarządzanych zasobów.
        // ~LogicBase() {
        //   // Nie zmieniaj tego kodu. Umieść kod czyszczący w powyższej metodzie Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Ten kod został dodany w celu prawidłowego zaimplementowania wzorca rozporządzającego.
        public void Dispose()
        {
            // Nie zmieniaj tego kodu. Umieść kod czyszczący w powyższej metodzie Dispose(bool disposing).
            Dispose(true);
            // TODO: Usunąć komentarz z poniższego wiersza, jeśli finalizator został przesłonięty powyżej.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
