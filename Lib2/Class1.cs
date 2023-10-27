using System;

namespace Lib2
{

    public class Class1
    {
        /// <summary>
        /// Massiv ��� ������
        /// </summary>
        /// <param name="mas"></param>�����
        /// <param name="Kol"></param> ����������� �����
        /// <param name="range1"></param> ��������
        public static void Massiv( out int [] mas, int Kol, int range1)
        {
            mas = new int[Kol];
            Random random = new Random();
            for(int i = 0; i < Kol; i++)
            {
                mas[i] = random.Next(range1);
            }
        }

        /// <summary>
        /// Compos ��� ������
        /// </summary>
        /// <param name="com"></param> ������������
        /// <param name="mas"></param> ������
        public static void Compos (out int com, int[] mas)
        {
            com = 1;
            for(int i = 0;i<mas.Length;i++)
            {
                if (mas[i] != 0)
                {
                    com *= mas[i];
                }
            }
        }
    }
}
