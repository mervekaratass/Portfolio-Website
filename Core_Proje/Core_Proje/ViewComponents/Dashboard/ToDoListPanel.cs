﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramewoek;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ToDoListPanel:ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        { var values = toDoListManager.TGetList();
            return View(values);
        }
    }
}
