using System;
using System.Collections.Generic;

namespace LibraryLib
{
    public class LibraryFunctions
    {
        // Данные библиотеки
        private string libraryName = "Городская библиотека г.Чита";
        private string chiefLibrarian = "Иванова Мария Петровна";

        // Список сотрудников
        private List<string> staff = new List<string>
        {
            "Ифимова С.С.",
            "Сидоров А.В.",
            "Голубев И.Д.",
            "Иванова М.П."
        };

        // 1. Возвращает ФИО главного библиотекаря
        public string GetChiefLibrarian()
        {
            return chiefLibrarian;
        }

        // 2. Возвращает название библиотеки
        public string GetLibraryName()
        {
            return libraryName;
        }

        // 3. Изменяет главного библиотекаря, только если он есть в списке сотрудников
        public bool SetChiefLibrarian(string fullname)
        {
            if (staff.Contains(fullname))
            {
                chiefLibrarian = fullname;
                return true;
            }
            return false;
        }

        // 4. Формирует код книги вида CAT_number
        public string GenerateBookCode(string category, int number)
        {
            return category + "_" + number;
        }

        // 5. Возвращает список сотрудников
        public List<string> GetStaff()
        {
            return staff;
        }

        // 6. Добавляет нового сотрудника
        public void AddStaff(string fullname)
        {
            staff.Add(fullname);
        }
    }
}