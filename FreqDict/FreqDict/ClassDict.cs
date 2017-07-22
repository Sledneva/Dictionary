using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FreqDict
{
    public class ClassDict
    {
        const string AlfaBet = "EUOIAeuioaаяуюоёыиэеАУЯЫИОЮЕЭ";
        Dictionary <string, int> dict;  // типа частотный словарь
        public List<string> listOpen; // список слов, начинающихся с гласной буквы
        public List<string> listConcord; // список слов, начинающихся с согласной буквы

        public ClassDict()
        {
            dict = new Dictionary<string, int>();
            listOpen = new List<string>();
            listConcord = new List<string>();
        }

        void AddInDict(string aWord) // записать слово в словарь с учётом частоты повторений
        {
            // ContainsKey(TKey) Определяет, содержится ли указанный ключ в словаре Dictionary<TKey, TValue>.
            // Remove(TKey)	Удаляет значение с указанным ключом из Dictionary<TKey, TValue>.
            //Item[TKey] Возвращает или задает значение, связанное с указанным ключом.
            if (dict.ContainsKey(aWord))
            {
                int n = dict[aWord];
                dict.Remove(aWord); //удаление значения с заданным ключом
                n++;
                dict.Add(aWord, n);
            }
            else dict.Add(aWord, 1);
        } //AddInDict

        void FormLists()             //добавляем слова в два листа, не отсортированные
        {
            foreach (KeyValuePair <string, int> keyValue in dict)
            {
                if (keyValue.Value == 1) //
                {
                    char firstLett = keyValue.Key[0]; //находим первую букву из слова, слово - массив из букв
                    if (AlfaBet.IndexOf(firstLett) >= 0) listOpen.Add(keyValue.Key); //если буква содержится в строчке, добавляем значение слова
                    else listConcord.Add(keyValue.Key); //в другой лист
                }
            }
            listOpen.Sort();   //сортировка 
            listConcord.Sort();
        } // FormList

        void FillDict(string FlOpen)     //заполнить словарь, все слова добавили в частотный словарь
         {
             FileStream stream = new FileStream(FlOpen, FileMode.Open, FileAccess.Read); 
             StreamReader reader = new StreamReader(stream);
             string s = "";
             s = reader.ReadLine(); //строчка
             while (s != null)
             {
                 if (s != "") //строчка не пустая
                 {
                     string[] word = s.Split(); //создаем массив слов, разделяем на слова
                     int len = word.Length; //колво букв в слове
                     for (int i = 0; i < len; i++)
                     {
                         if (word[i] !="") //слово не пустое, 
                        {
                            int lenWord = word[i].Length;
                            char last = word[i][lenWord - 1];
                            if (!Char.IsLetter(last)) word[i] = word[i].Remove(lenWord-1); //если последний символ не буква, то это слово состоит из букв кроме последнего символа
                            this.AddInDict( word[i]);
                        }
                                                     
                     }
                 }
                 s = reader.ReadLine(); //
             }
             reader.Close(); //закрываем чтение
             stream.Close();
         } // FillDict

        void ListToFile(string FlSave)
         {
            FileStream stream = new FileStream(FlSave, FileMode.Create, FileAccess.Write);
             StreamWriter writer = new StreamWriter(stream);
             string s = "";
             long len = listOpen.LongCount(); //общее число элементов в последовательности
             for (int i = 0; i < len; i++)
             {
                 s = this.listOpen.First();
                 //RemoveAt	Удаляет элемент списка List <T> с указанным индексом.
                 this.listOpen.RemoveAt(0);
                 writer.WriteLine(s);
             }
             writer.WriteLine(" ");
            len = this.listConcord.LongCount();
            for (int i = 0; i < len; i++)

             {
                 s = this.listConcord.First();
                 // RemoveAt	Удаляет элемент списка List <T> с указанным индексом.
                 this.listConcord.RemoveAt(0);
                 writer.WriteLine(s);
             }

             writer.Close();
             stream.Close();
         } // ListToFile

        public void ProcAll(string FlOpen, string FlSave)
        {
             FillDict(FlOpen);
             FormLists();
             ListToFile(FlSave);
        }

    }
}
