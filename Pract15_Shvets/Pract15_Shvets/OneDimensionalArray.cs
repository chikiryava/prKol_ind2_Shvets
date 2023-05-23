using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Pract15_Shvets
{
    class OneDimensionalArray
    {
        ArrayList array;
        static Random rnd = new Random();
        public string TakeElement(string index)
        {
            try
            {
                if (array == null)
                {
                    MessageBox.Show("Вы не создали массив");
                    return null;
                }
                if (int.TryParse(index, out int result))
                    return array[result].ToString();
                else
                {
                    MessageBox.Show("Введенное значение не является числом");
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Элемент находится за границей массива");
                return null;
            }
        }
        public void CreateArray(string size)
        {
            try
            {
                if (int.TryParse(size, out int result))
                {
                    array = new ArrayList(result);
                    for (int i = 0; i < result; i++)
                        array.Add(rnd.Next(-100, 100));
                    MessageBox.Show("Массив был создан!");
                }
                else
                    MessageBox.Show("Введенное значение не является числом");
            }
            catch
            {
                MessageBox.Show("Размер массива должен быть больше 0");
            }
        }
        public void Multiply(string factor)
        {
            if (array == null)
            {
                MessageBox.Show("Вы не создали массив");
            }
            if (factor.Contains(".") || factor.Contains(","))
                MessageBox.Show("Возможно вы хотели ввести дробное число. Разрешено вводить только целые числа");
            else
            {
                try
                {
                    int multiplier = int.Parse(factor);
                    for (int i = 0; i < array.Count; i++)
                    {
                        array[i] = Convert.ToInt32(array[i])*multiplier;
                    }
                    MessageBox.Show("Все элементы массива были умножены на " + multiplier);
                }
                catch
                {
                    MessageBox.Show("Введенное значение не является числом");
                }
            }
        }
        public ArrayList ReturnArray()
        {
            return array;
        }
        
    }
}
